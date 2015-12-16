namespace ImmutableObjectGraph.CodeGeneration.Tests.TestSources
{
    using System.Collections.Immutable;
    using ImmutableObjectGraph;

    [ImmutableObjectGraph.GenerateImmutable(GenerateBuilder = true, Delta = true, DefineRootedStruct = true, DefineWithMethodsPerProperty = true)]
    abstract partial class FileSystemEntry
    {
        [Required]
        readonly string pathSegment;

        readonly RichData data;
    }

    [ImmutableObjectGraph.GenerateImmutable(GenerateBuilder = true, Delta = true, DefineRootedStruct = true, DefineWithMethodsPerProperty = true)]
    partial class FileSystemFile : FileSystemEntry
    {
        readonly ImmutableHashSet<string> attributes;
    }

    [ImmutableObjectGraph.GenerateImmutable(GenerateBuilder = true, Delta = true, DefineRootedStruct = true, DefineWithMethodsPerProperty = true)]
    partial class FileSystemDirectory : FileSystemEntry
    {
        readonly ImmutableSortedSet<FileSystemEntry> children;
    }

    [ImmutableObjectGraph.GenerateImmutable(GenerateBuilder = true, Delta = true, DefineWithMethodsPerProperty = true)]
    partial class RichData
    {
        readonly int someCoolProperty;
    }
}