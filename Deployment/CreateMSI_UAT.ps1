
Write-Host("Building MSI from script") -Fore Cyan

# Build mode for building the BizTalk applications, can be Release or Debug
$mode = "Debug"

# Directory where the finished MSI installers will be placed
$installersDir = "C:\Users\sbhosekar\Documents\Visual Studio 2012\Projects\DemoProjectForGitHubCICDPipeline\DemoDICDPipleineForVS\MSI1"

# Options used by MSBuild
$options = " /nologo /t:Installer /p:Configuration=" + $mode
 
# Use MSBuild to build the installer
$build = "C:\Windows\Microsoft.NET\Framework\v4.0.30319\MSBuild.exe" + " `"C:\actions-runner\DemoDICDPipleineForVS\DemoDICDPipleineForVS\Deployment\Deployment.btdfproj`"" + $options 


# Copy the installer to the directory containing all installation files

#Copy-Item ("C:\actions-runner\DemoDICDPipleineForVS\DemoDICDPipleineForVS\Deployment\bin\Debug\DemoProjectForGitHubCICDPipeline-1.0.0.msi") "C:\Users\sbhosekar\Documents\Visual Studio 2012\Projects\DemoProjectForGitHubCICDPipeline\DemoDICDPipleineForVS\MSI1" -Force

 
# Build the installer
Invoke-Expression $build

$verbosity = " /v:q "


 