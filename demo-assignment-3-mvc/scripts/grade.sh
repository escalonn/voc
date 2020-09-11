#! /bin/sh

echo VOC_NO_REPORT_OUTPUT > $vocareumReportFile

cd assignment
cp -r $ASNLIB/BindViews.Grader .
dotnet sln add BindViews.Grader

dotnet test | tee results.txt

fail=`egrep -i "failed|error" results.txt | wc -l`

if ! egrep "@model" BindViews/Views/Home/Index.cshtml; then
  fail=$((fail+1))
  echo "" >> results.txt
  echo "BindViews/Views/Home/Index.cshtml should be a strongly-typed view" >> results.txt
fi

echo "-------------------------------------------------------" >> $vocareumReportFile

maxscore=5
if [ "$fail" == "0" ]; then
  score=5
  echo "Your program meets all requirements." >> $vocareumReportFile
else
  score=0
  echo "Score: ${score}/${maxscore}" >> $vocareumReportFile
  echo "Your program does not meet all requirements." >> $vocareumReportFile
fi
echo "Score: ${score}/${maxscore}" >> $vocareumReportFile
echo "score", $score >> $vocareumGradeFile

echo "-------------------------------------------------------" >> $vocareumReportFile
echo "" >> $vocareumReportFile

cat results.txt >> $vocareumReportFile

echo "" >> $vocareumReportFile
echo "Grade upload response:" >> $vocareumReportFile
curl -d "{\"score\":$score}" \
-H "Content-Type: application/json" \
-H "EXTERNAL_CLIENT_ID: Vk9DQVJFVU1fTEFC" \
-H "EXTERNAL_CLIENT_TOKEN: ODkyNGRhYWQ1MzBkNzJlYWNhNzJkZTNjMzBjYzhhZWM" \
-X PUT https://app-ms.revature.com/apigateway/lab/vocareum/users/$VOC_USERID/parts/$VOC_PARTID >> $vocareumReportFile
