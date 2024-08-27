   



Function Check-RunAsAdministrator()
{
  #Get current user context
  $CurrentUser = New-Object Security.Principal.WindowsPrincipal $([Security.Principal.WindowsIdentity]::GetCurrent())
  
  #Check user is running the script is member of Administrator Group
  if($CurrentUser.IsInRole([Security.Principal.WindowsBuiltinRole]::Administrator))
  {
       Write-host "Script is running with Administrator privileges!"
  }
  else
    {
       #Create a new Elevated process to Start PowerShell
       $ElevatedProcess = New-Object System.Diagnostics.ProcessStartInfo "PowerShell";
 
       # Specify the current script path and name as a parameter
       $ElevatedProcess.Arguments = "& '" + $script:MyInvocation.MyCommand.Path + "'"
 
       #Set the Process to elevated
       $ElevatedProcess.Verb = "runas"
 
       #Start the new elevated process
       [System.Diagnostics.Process]::Start($ElevatedProcess)
 
       #Exit from the current, unelevated, process
       Exit
 
    }
}
 
#Check Script is running with Elevated Privileges
Check-RunAsAdministrator
 
 

#Read more: https://www.sharepointdiary.com/2015/01/run-powershell-script-as-administrator-automatically.html#ixzz8k7xsMiXq





# Use MSBuild to build the installer
# $build = "C:\Windows\Microsoft.NET\Framework\v4.0.30319\MSBuild.exe" + " C:\CICDTest\DemoDICDPipleineForVS\Deployment\Deployment.btdfproj" 


 
# Build the installer
# Invoke-Expression $build

# $verbosity = " /v:q "


 
