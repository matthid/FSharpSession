namespace FileOrdering

type SomeClass private (d : SomeDataType) =
  // privates, order matters
  let transform () =
    SomeLogic.transform d
    |> SomeClass

  // members, order doesnt matter and they can reference each other
  member __.Transform (* : SomeClass *) = transform()
  member x.TransformTwice = x.Transform.Transform // Try to move me up
  static member Create (s : string) = SomeClass { Data = s } 
