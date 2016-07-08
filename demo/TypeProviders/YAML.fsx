

#r "../../packages/demo/FSharp.Configuration/lib/net40/FSharp.Configuration.dll"

open FSharp.Configuration

type MyYamlConfig = YamlConfig<"Config.yaml">

let config = MyYamlConfig()
config.Mail.Pop3.
// config.DB.DefaultTimeout