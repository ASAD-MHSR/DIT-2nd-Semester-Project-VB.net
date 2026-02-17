@echo off
echo Building Contact Manager...
echo.

dotnet build -c Release

if %ERRORLEVEL% EQU 0 (
    echo.
    echo Build successful!
    echo.
    echo EXE file location: bin\Release\net6.0-windows\ContactManager.exe
    echo.
    echo To run the application, navigate to the bin\Release\net6.0-windows folder and double-click ContactManager.exe
    echo.
    pause
) else (
    echo.
    echo Build failed! Please make sure .NET SDK is installed.
    echo Download from: https://dotnet.microsoft.com/download
    echo.
    pause
)
