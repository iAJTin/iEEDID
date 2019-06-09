@ECHO OFF
CLS

..\src\.nuget\nuget Pack iEEID.1.0.0.nuspec -NoDefaultExcludes -NoPackageAnalysis -OutputDirectory ..\deployment\nuget



