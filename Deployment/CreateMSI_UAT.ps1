
 if (!([Security.Principal.WindowsPrincipal][Security.Principal.WindowsIdentity]::GetCurrent()).IsInRole([Security.Principal.WindowsBuiltInRole] "Administrator")) { Start-Process powershell.exe "-NoProfile -ExecutionPolicy Bypass -File `"$PSCommandPath`"" -Verb RunAs; exit } 

# Use MSBuild to build the installer
$build = "C:\Windows\Microsoft.NET\Framework\v4.0.30319\MSBuild.exe" + " C:\CICDTest\DemoDICDPipleineForVS\Deployment\Deployment.btdfproj" 


 
# Build the installer
Invoke-Expression $build

$verbosity = " /v:q "


 
