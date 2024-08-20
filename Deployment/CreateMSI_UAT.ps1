
Write-Host("Building MSI from scrip") -Fore Cyan
# Build mode for building the BizTalk applications, can be Release or Debug
$mode = "Debug"

# Directory where the finished MSI installers will be placed
$installersDir = "C:\Users\sbhosekar\Documents\Visual Studio 2012\Projects\DemoProjectForGitHubCICDPipeline\DemoDICDPipleineForVS\MSI1"

 
# Use MSBuild to build the installer
$build = "C:\Windows\Microsoft.NET\Framework\v4.0.30319\MSBuild.exe " + "`"C:\Users\sbhosekar\Documents\Visual Studio 2012\Projects\DemoProjectForGitHubCICDPipeline\DemoDICDPipleineForVS\Deployment\Deployment.btdfproj`"" + " /nologo /t:Installer /p:Configuration=" + "Debug"
 

 
# Build the installer

Invoke-Expression $build

Copy-Item ("C:\ShashankWork\TestMSI\TESTMSI\Deployment\bin\Debug" + "*.msi") $installersDir -Force

$verbosity = " /v:q "

 

 