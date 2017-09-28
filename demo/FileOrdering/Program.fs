open FileOrdering

[<EntryPoint>]
let main args =
    let s = SomeClass.Create("Data")
    let transformed = s.TransformMultiple.Transform
    printfn "%s" transformed.Data
    0