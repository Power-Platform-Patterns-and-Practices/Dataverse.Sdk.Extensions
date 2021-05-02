@echo off

SET OUTPUT_FORMAT=Html
SET NO_SHOW=0

:loop
IF NOT "%1"=="" (
    IF "%1"=="-format" (
        SET OUTPUT_FORMAT=%2
        SHIFT
    )
    IF "%1"=="-no-show" (
        SET NO_SHOW=%2
        SHIFT
    )
    SHIFT
    GOTO :loop
)

SET OPEN_COVER=
for /D %%D in ("packages\opencover*") do (
    SET OPEN_COVER=%%~D\tools\OpenCover.Console.exe
)

SET REPORT_GENERATOR=
for /D %%D in ("packages\ReportGenerator*") do (
    SET REPORT_GENERATOR=%%~D\tools\net47\ReportGenerator.exe
)

SET XUNIT_RUNNER=
for /D %%D in ("packages\xunit.runner.console*") do (
    SET XUNIT_RUNNER=%%~D\tools\net46\xunit.console.exe
)

IF "%OPEN_COVER%"=="" (
	ECHO Could not find OpenCover. Make sure to restore NuGet packages 1>&2
	EXIT 1
)

IF "%REPORT_GENERATOR%"=="" (
	ECHO Could not find Report Generator. Make sure to restore NuGet packages 1>&2
	EXIT 1
)

IF "%XUNIT_RUNNER%"=="" (
	ECHO Could not find xunit.runner.console. Make sure to restore NuGet packages 1>&2
	EXIT 1
)

"%OPEN_COVER%" -target:"%XUNIT_RUNNER%" -targetargs:"""Dataverse.Sdk.Extensions.Tests\bin\Debug\Dataverse.Sdk.Extensions.Tests.dll"" -noshadow"  -output:"..\.coverage\Dataverse.Sdk.Extensions.Coverage.xml" -register:Path64 -filter:"+[Dataverse.Sdk.Extensions]* -[Dataverse.Sdk.Extensions.Tests]*"
"%REPORT_GENERATOR%" -reports:"../.coverage/Dataverse.Sdk.Extensions.Coverage.xml" -targetdir:"..\.coverage\report" -reporttypes:"%OUTPUT_FORMAT%"

IF "%NO_SHOW%"=="0" (
	start ..\.coverage\report\index.htm
)