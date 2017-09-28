
#r "System.Management.dll"
#r "../../packages/demotypeprovider/FSharp.Management/lib/net40/System.Management.Automation.dll"
#r "../../packages/demotypeprovider/FSharp.Management/lib/net40/FSharp.Management.dll"
#r "../../packages/demotypeprovider/FSharp.Management/lib/net40/FSharp.Management.PowerShell.dll"
#r "../../packages/demotypeprovider/FSharp.Management/lib/net40/FSharp.Management.PowerShell.ExternalRuntime.exe"
#r "../../packages/demotypeprovider/FSharp.Management/lib/net40/FSharp.Management.WMI.dll"
#r "../../packages/demotypeprovider/FSharp.Management/lib/net40/FSharp.Management.WMI.DesignTime.dll"

open FSharp.Management

let path = Registry.HKEY_CURRENT_USER.ControlPanel.Colors.Path
printfn "path: %s" path

