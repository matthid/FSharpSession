namespace FileOrdering

// Layer for some logic on the basic data structures.
module SomeLogic =

  // "Pattern matching" / Record deconstruction on parameter
  let transform { Data = d } = { Data = "transformed_" + d }

  // "More complicated functionality" after the "simple" reusable functions
  let transformTwice d =
    d |> transform |> transform