del dist /Q

REM Install Visual Studio build tools https://visualstudio.microsoft.com/thank-you-downloading-visual-studio/?sku=BuildTools&rel=15
REM Add MSBuild.exe to PATH
MSBuild.exe MyFizzBuzz.sln /p:Configuration=Release

tools\NUnit.Console-3.8.0\nunit3-console.exe FizzBuzzLibTests\bin\Release\FizzBuzzLibTests.dll

copy FizzBuzzLib\bin\Release\FizzBuzzLib.dll dist
