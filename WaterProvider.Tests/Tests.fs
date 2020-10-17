module Tests

open System
open Xunit
open MyNamespace

[<Fact>]
let ``My test`` () =
    Assert.True(true)
    
[<Fact>]
let ``Default constructor should create instance`` () =
    Assert.Equal("My internal state", MyType().InnerState)

[<Fact>]
let ``Constructor with parameter should create instance`` () =
    Assert.Equal("override", MyType("override").InnerState)

[<Fact>]
let ``Method with ReflectedDefinition parameter should get its name`` () =
    let myValue = 2
    Assert.Equal("myValue", MyType.NameOf(myValue))

type Generative2 = WaterProvider.GenerativeProvider<2>
type Generative4 = WaterProvider.GenerativeProvider<4>
type Generative10 = WaterProvider.GenerativeProvider<10>

[<Fact>]
let ``Can access properties of generative provider 2`` () =
    let obj = Generative2()
    Assert.Equal(obj.Property1, 1)
    Assert.Equal(obj.Property2, 2)

[<Fact>]
let ``Can access properties of generative provider 4`` () =
    let obj = Generative4()
    Assert.Equal(obj.Property1, 1)
    Assert.Equal(obj.Property2, 2)
    Assert.Equal(obj.Property3, 3)
    Assert.Equal(obj.Property4, 4)

[<Fact>]
let ``Can access properties of generative provider 10`` () =
    let obj = Generative10()
    Assert.Equal(obj.Property1, 1)
    Assert.Equal(obj.Property2, 2)
    Assert.Equal(obj.Property3, 3)
    Assert.Equal(obj.Property4, 4)
    Assert.Equal(obj.Property10, 10)
    Assert.Equal(obj.AuxProperty5, 5)