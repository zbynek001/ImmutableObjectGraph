namespace RoslynDemo
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;
    using ImmutableObjectGraph.Generation;

    [ImmutableObjectGraph.Generation.GenerateImmutable(DefineInterface = true)]
    public partial class Test1
    {
        private readonly int id;
    }

    [ImmutableObjectGraph.Generation.GenerateImmutable(DefineInterface = false)]
    public partial class Test2 : Test1
    {
        private readonly string name;
    }

    [ImmutableObjectGraph.Generation.GenerateImmutable(DefineInterface = true)]
    public partial class Test3 : Test2
    {
        private readonly string name3;
    }
}
