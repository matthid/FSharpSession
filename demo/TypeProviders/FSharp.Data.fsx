

#r "../../packages/demo/FSharp.Data/lib/net40/FSharp.Data.dll"
open FSharp.Data

type Simple = JsonProvider<""" { "name":"John", "age":94 } """>
let simple = Simple.Parse(""" { "name":"Tomas", "age":4 } """)


simple.













type Sample = JsonProvider< "./jsonSample.json" >
let sample = Sample.Parse ("""{ "sample": "Blub", "Test": 4 } """)
















#r "System.Xml"
#r "System.Xml.Linq"
type AuthorAlt = XmlProvider<"<author><name>Karl Popper</name><born>1902</born></author>">
let doc = "<author><name>Paul Feyerabend</name><born>1924</born></author>"
let sampleAlt = AuthorAlt.Parse(doc)

