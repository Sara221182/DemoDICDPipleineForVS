
If (-NOT ([Security.Principal.WindowsPrincipal][Security.Principal.WindowsIdentity]::GetCurrent()).IsInRole([Security.Principal.WindowsBuiltInRole] "Administrator"))
{   
  $arguments = "& '" + $myinvocation.mycommand.definition + "'"
  Start-Process powershell -Verb runAs -ArgumentList $arguments
  Break
}

Set-Location $PSScriptRoot
# Use MSBuild to build the installer
$build = "C:\Windows\Microsoft.NET\Framework\v4.0.30319\MSBuild.exe" + " C:\CICDTest\DemoDICDPipleineForVS\Deployment\Deployment.btdfproj" 


 
# Build the installer
Invoke-Expression $build

$verbosity = " /v:q "


 
