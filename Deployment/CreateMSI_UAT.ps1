
# Use MSBuild to build the installer
$build = "C:\Windows\Microsoft.NET\Framework\v4.0.30319\MSBuild.exe" + " C:\CICDTest\DemoDICDPipleineForVS\Deployment\Deployment.btdfproj" 


 
# Build the installer
Invoke-Expression $build

$verbosity = " /v:q "


 
