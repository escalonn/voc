#! /bin/sh

echo VOC_NO_REPORT_OUTPUT > $vocareumReportFile

cd assignment
cp -r $ASNLIB/ClientSide.Grader .
dotnet sln add ClientSide.Grader

nohup dotnet run -p ServerSide &
echo $! > serverside_pid.txt

dotnet test | tee results.txt

kill -9 `cat serverside_pid.txt`

fail=`egrep -i "failed|error" results.txt | wc -l`

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
-X PUT  https://qa-ms.revature.com/apigateway/lab/vocareum/users/$VOC_USERID/parts/$VOC_PARTID >> $vocareumReportFile
