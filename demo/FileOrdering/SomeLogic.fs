﻿namespace FileOrdering

module SomeLogic =
  
  // "Pattern matching" / Record deconstruction on parameter
  let transform { Data = d } = { Data = "transformed_" + d }

  // "More complicated functionalty" after the "simple" reusable functions
  let transformTwice d = 
    d |> transform |> transform