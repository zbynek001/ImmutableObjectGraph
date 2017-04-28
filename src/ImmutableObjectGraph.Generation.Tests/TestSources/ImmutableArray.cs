namespace ImmutableObjectGraph.Generation.Tests.TestSources
{
    using System.Collections.Immutable;

    [GenerateImmutable]
    partial class Node2
    {
        readonly ImmutableArray<Node2> children;
    }
}
