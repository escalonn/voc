#! /bin/sh

echo VOC_NO_REPORT_OUTPUT > $vocareumReportFile 

cd assignment
cp -r $ASNLIB/PrimeService.Grader .

dotnet add ./PrimeService.Grader/PrimeService.Grader.csproj reference ./PrimeService/PrimeService.csproj
dotnet sln add ./PrimeService.Grader/PrimeService.Grader.csproj
dotnet test ./PrimeService.Grader | tee results.txt

fail=`egrep -i "failed|error" results.txt | wc -l`

echo "-------------------------------------------------------" >> $vocareumReportFile

if [ "$fail" == "0" ]; then
  echo "score", 5 >>  $vocareumGradeFile
  echo Good job. Your program passed. >> $vocareumReportFile
else
  echo "score", 0 >> $vocareumGradeFile
  echo Keep trying. Your program did not pass all our tests. >> $vocareumReportFile
  egrep -i "failed|error" results.txt >> $vocareumReportFile
fi

echo "-------------------------------------------------------" >> $vocareumReportFile

