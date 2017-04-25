namespace ImmutableObjectGraph
{
	using System.Diagnostics;

	public static class Optional {
		[DebuggerStepThrough]
		public static Optional<T> For<T>(T value) {
			return value;
		}

        [DebuggerStepThrough]
        public static Optional<T> ToOptional<T>(this T value)
        {
            return value;
        }
    }
}
