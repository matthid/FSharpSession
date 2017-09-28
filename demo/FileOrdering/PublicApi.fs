namespace FileOrdering

// Nice "C#y" API for the outside world.
type SomeClass private (d : SomeDataType) =
  // privates, order matters
  let transform () =
    SomeLogic.transform d
    |> SomeClass  

  // members, order doesnt matter and they can reference each other
  member __.Transform (* : SomeClass *) = transform()
  member __.Data = d.Data
  member x.TransformMultiple = (SomeLogic.transformTwice d |> SomeClass).Transform // Try to move me up
  static member Create (s : string) = SomeClass { Data = s } 
