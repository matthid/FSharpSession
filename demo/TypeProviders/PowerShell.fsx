
#r "../../packages/demo/FSharp.Management/lib/net40/System.Management.Automation.dll"
#r "../../packages/demo/FSharp.Management/lib/net40/FSharp.Management.dll"
#r "../../packages/demo/FSharp.Management/lib/net40/FSharp.Management.PowerShell.dll"
#r "../../packages/demo/FSharp.Management/lib/net40/FSharp.Management.PowerShell.ExternalRuntime.exe"
#r "System.ServiceProcess"
#r "System.Management"

open FSharp.Management

type PS = PowerShellProvider< "Microsoft.PowerShell.Management;Microsoft.PowerShell.Core" >

let searchService =
  match PS.``Get-Service``(name=[|"Windows Search"|]) with
  | Success services when services.Length = 1 ->
    services.Head
  | _ -> failwith "Choice ambiguous"

// PS.``Test-Connection``

let [<Literal>] ModuleFile = 
  __SOURCE_DIRECTORY__ + @"\PowerShellScript.psm1"

// Needs "set-executionpolicy remotesigned" in x86 powershell!
type PSScript = PowerShellProvider< ModuleFile >

module MyScriptLib =
  let doSomething parameter =
    match PSScript.doSomething(test=parameter) with
    | Success s when s.Length = 1 -> s.[0]
    | _ -> failwith "script failed"