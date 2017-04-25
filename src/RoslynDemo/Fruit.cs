﻿namespace RoslynDemo
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;
    using ImmutableObjectGraph.Generation;

    [GenerateImmutable(DefineInterface = true, GenerateBuilder = true)]
    partial class Fruit
    {
        readonly string color = "red";
        readonly int skinThickness;
    }
}
