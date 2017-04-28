[ImmutableObjectGraph.Generation.GenerateImmutable(GenerateBuilder = true)]
partial class Fruit2
{
    readonly int seeds;
}

[ImmutableObjectGraph.Generation.GenerateImmutable(GenerateBuilder = true)]
partial class Apple2 : Fruit2
{
    readonly string color;
}