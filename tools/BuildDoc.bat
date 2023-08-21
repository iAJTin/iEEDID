@ECHO OFF
CLS

rmdir ..\documentation /s /q

xmldocmd ..\src\lib\net\iTin.Hardware\iTin.Hardware.Specification.Eedid\bin\Debug\netstandard2.0\iTin.Hardware.Specification.Eedid.dll ..\documentation

PAUSE
