#! /bin/sh

echo VOC_NO_REPORT_OUTPUT > $vocareumReportFile 

cd assignment
cp -r $ASNLIB/StringManipulationChallenge.Tests .
cp $ASNLIB/1_StringManipulationChallenge.sln .


dotnet test ./StringManipulationChallenge.Tests | tee results.txt

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

