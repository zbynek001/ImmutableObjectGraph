﻿namespace ImmutableObjectGraph.Generation.Tests.TestSources
{
    using System;
    using System.Collections.Generic;
    using System.Collections.Immutable;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;

    [GenerateImmutable(DefineRootedStruct = true)]
    public partial class Tree3
    {
        readonly ImmutableSortedSet<Tree3> children;
    }
}
