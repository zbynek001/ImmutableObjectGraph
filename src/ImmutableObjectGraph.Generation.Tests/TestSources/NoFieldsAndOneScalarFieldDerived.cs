[ImmutableObjectGraph.Generation.GenerateImmutable(GenerateBuilder = true)]
partial class Empty2
{
}

[ImmutableObjectGraph.Generation.GenerateImmutable(GenerateBuilder = true)]
partial class NotSoEmptyDerived2 : Empty2
{
    readonly bool oneField;
}
