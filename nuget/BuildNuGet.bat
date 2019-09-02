@ECHO OFF
CLS

..\src\.nuget\nuget Pack iEEDID.1.0.3.nuspec -NoDefaultExcludes -NoPackageAnalysis -OutputDirectory ..\deployment\nuget

pause

