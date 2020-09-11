#! /bin/sh

echo VOC_NO_REPORT_OUTPUT > $vocareumReportFile

cd assignment
cp -r $ASNLIB/Assignment.Grader .
dotnet sln add Assignment.Grader

dotnet test --filter Requires!=Server | tee results.txt

nohup dotnet run -p ServerSide &
echo $! > serverside_pid.txt

dotnet test --filter Requires=Server | tee results.txt

kill -9 `cat serverside_pid.txt`

fail=`egrep -i "failed|error" results.txt | wc -l`

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
