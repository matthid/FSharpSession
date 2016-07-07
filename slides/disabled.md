
---

### Layout: Structure

```csharp
public ResultType MyClevermethod(
    int firstArg,
    string secondArg,
    string thirdArg)
{
    var localVar =
        AnotherCleverMethod(firstArg, secondArg);
    if (localVar.IsSomething(
        thirdArg, MY_CONSTANT))
    {
        DoSomething(localVar);
    }
    return localVar.GetSomething();
}
```

---

### Layout: Structure

```
XXXXXX XXXXXXXXXX XXXXXXXXXXXXXXX
    XXX XXXXXXXXX
    XXXXXX XXXXXXXXXX
    XXXXXX XXXXXXXXX

    XXX XXXXXXXX 
        XXXXXXXXXXXXXXXXXXXXXXXXXXXXX XXXXXXXXXXX
    XX XXXXXXXXX XXXXXXXXXXXX
        XXXXXXXXX XXXXXXXXXXXXX
    
        XXXXXXXXXXXXXXXXXXXXXX
    
    XXXXXX XXXXXXXXX XXXXXXXXXXXXXX
```

' Single characters are removed
' Where does the body start?
' What about incorrect whitespace?
' Mixed tabs and spaces?

---

### Layout: Structure

```fsharp
let myClevermethod x y y =
    let localVar = anotherCleverMethod x y

    if localVar.IsSomething z MY_CONSTANT then
        doSomething localVar
    
    localVar.GetSomething
```

---

### Layout: Structure

```
XXX XXXXXXXXXXXXXX
    XXX XXXXXXXX XXXXXXXXXXXXXXXXXXX

    XX XXXXXXXX XXXXXXXXXXX XXXXXXXX XXXXXXXXXXX XXXX
        XXXXXXXXXXX XXXXXXXX

    XXXXXXXX XXXXXXXXXXXX
```

' Code blocks can be seen -> enforced by the compiler
' return value is the last line (no return within the function code)
