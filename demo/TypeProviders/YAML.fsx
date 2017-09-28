

#r "../../packages/demotypeprovider/FSharp.Configuration/lib/net45/FSharp.Configuration.dll"

open FSharp.Configuration

type MyYamlConfig = YamlConfig<"Config.yaml">

let config = MyYamlConfig()

config.Mail.Smtp.Password
// config.DB.DefaultTimeout