@ECHO OFF
CLS

rmdir ..\documentation /s /q

xmldocmd ..\src\lib\net\iTin.Hardware\iTin.Hardware.Specification\iTin.Hardware.Specification.Eedid\bin\Release\net461\iTin.Hardware.Specification.Eedid.dll ..\documentation

PAUSE
