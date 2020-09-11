#! /bin/sh

echo VOC_NO_REPORT_OUTPUT > $vocareumReportFile

cd assignment
cp -r $ASNLIB/Prime.Grader .
dotnet sln add Prime.Grader

dotnet test Prime.Tests --collect "xplat code coverage" | tee results.txt
dotnet test Prime.Grader | tee results.txt

fail=`egrep -i "failed|error" results.txt | wc -l`

coverage=`sed -n 2p Prime.Tests/*/*/coverage.*.xml | cut -d'"' -f2`

if [ -z "$coverage" ]; then
  echo "" >> results.txt
  echo "Code coverage: $coverage" >> results.txt
  if [ "$coverage" -lt 1 ]; then
    fail=$((fail+1))
    echo "Code coverage does not meet requirement" >> results.txt
  else
    echo "Code coverage meets requirement" >> results.txt
  fi
fi

echo "-------------------------------------------------------" >> $vocareumReportFile

if [ "$fail" == "0" ]; then
  score=5
  echo "score", $score >> $vocareumGradeFile
  echo "Your program meets all requirements." >> $vocareumReportFile
else
  score=0
  echo "score", $score >> $vocareumGradeFile
  echo "Your program does not meet all requirements." >> $vocareumReportFile
fi

echo "-------------------------------------------------------" >> $vocareumReportFile
echo "" >> $vocareumReportFile

cat results.txt >> $vocareumReportFile

echo "" >> $vocareumReportFile
echo "Grade upload response:" >> $vocareumReportFile
curl -d "{\"score\":$score}" \
-H "Content-Type: application/json" \
-H "EXTERNAL_CLIENT_ID: Vk9DQVJFVU1fTEFC" \
-H "EXTERNAL_CLIENT_TOKEN: ODkyNGRhYWQ1MzBkNzJlYWNhNzJkZTNjMzBjYzhhZWM" \
-X PUT  https://app-ms.revature.com/apigateway/lab/vocareum/users/$VOC_USERID/parts/$VOC_PARTID >> $vocareumReportFile
