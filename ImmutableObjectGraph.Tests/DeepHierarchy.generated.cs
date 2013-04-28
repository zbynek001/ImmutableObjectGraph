﻿// ------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     ImmutableTree Version: 0.0.0.1
//  
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
// ------------------------------------------------------------------------------

namespace ImmutableObjectGraph.Tests {
	using System.Diagnostics;
	using ImmutableObjectGraph;

	
	public interface IA {
		System.Int32 Field1 { get; }
	}
	
	public partial class A : IA {
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		private static readonly A DefaultInstance = GetDefaultTemplate();
	
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		private readonly System.Int32 field1;
	
		/// <summary>Initializes a new instance of the A class.</summary>
		protected A()
		{
		}
	
		/// <summary>Initializes a new instance of the A class.</summary>
		protected A(System.Int32 field1)
			: base()
		{
			this.field1 = field1;
			this.Validate();
		}
	
		public static A Create(
			ImmutableObjectGraph.Optional<System.Int32> field1 = default(ImmutableObjectGraph.Optional<System.Int32>)) {
			return DefaultInstance.With(
				field1.IsDefined ? field1 : ImmutableObjectGraph.Optional.For(DefaultInstance.Field1));
		}
	
		public System.Int32 Field1 {
			get { return this.field1; }
		}
		/// <summary>Returns a new instance with the Field1 property set to the specified value.</summary>
		public A WithField1(System.Int32 value) {
			if (value == this.Field1) {
				return this;
			}
	
			return this.With(field1: value);
		}
	
		/// <summary>Returns a new instance of this object with any number of properties changed.</summary>
		public virtual A With(
			ImmutableObjectGraph.Optional<System.Int32> field1 = default(ImmutableObjectGraph.Optional<System.Int32>)) {
			if (
				(field1.IsDefined && field1.Value != this.Field1)) {
				return new A(
					field1.IsDefined ? field1.Value : this.Field1);
			} else {
				return this;
			}
		}
	
	
		public Builder ToBuilder() {
			return new Builder(this);
		}
	
		public B ToB(
			ImmutableObjectGraph.Optional<System.Int32> field2 = default(ImmutableObjectGraph.Optional<System.Int32>)) {
			throw new System.NotImplementedException();
		}
		public C1 ToC1(
			ImmutableObjectGraph.Optional<System.Int32> field2 = default(ImmutableObjectGraph.Optional<System.Int32>),
			ImmutableObjectGraph.Optional<System.Int32> field3 = default(ImmutableObjectGraph.Optional<System.Int32>)) {
			throw new System.NotImplementedException();
		}
		public C2 ToC2(
			ImmutableObjectGraph.Optional<System.Int32> field2 = default(ImmutableObjectGraph.Optional<System.Int32>),
			ImmutableObjectGraph.Optional<System.Int32> field3 = default(ImmutableObjectGraph.Optional<System.Int32>)) {
			throw new System.NotImplementedException();
		}
	
	 
		/// <summary>Normalizes and/or validates all properties on this object.</summary>
		/// <exception type="ArgumentException">Thrown if any properties have disallowed values.</exception>
		partial void Validate();
	
		/// <summary>Provides defaults for fields.</summary>
		/// <param name="template">The struct to set default values on.</param>
		static partial void CreateDefaultTemplate(ref Template template);
	
		/// <summary>Returns a newly instantiated A whose fields are initialized with default values.</summary>
		private static A GetDefaultTemplate() {
			var template = new Template();
			CreateDefaultTemplate(ref template);
			return new A(
				template.Field1);
		}
	
		public partial class Builder {
			[DebuggerBrowsable(DebuggerBrowsableState.Never)]
			private A immutable;
	
			[DebuggerBrowsable(DebuggerBrowsableState.Never)]
			protected System.Int32 field1;
	
			internal Builder(A immutable) {
				this.immutable = immutable;
	
				this.field1 = immutable.Field1;
			}
	
			public System.Int32 Field1 {
				get {
					return this.field1;
				}
	
				set {
					this.field1 = value;
				}
			}
	
			public A ToImmutable() {
				return this.immutable = this.immutable.With(
					ImmutableObjectGraph.Optional.For(this.Field1));
			}
		}
	
		/// <summary>A struct with all the same fields as the containing type for use in describing default values for new instances of the class.</summary>
		private struct Template {
			internal System.Int32 Field1 { get; set; }
		}
	}
	
	public interface IB : IA {
		System.Int32 Field2 { get; }
	}
	
	public partial class B : A, IB {
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		private static readonly B DefaultInstance = GetDefaultTemplate();
	
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		private readonly System.Int32 field2;
	
		/// <summary>Initializes a new instance of the B class.</summary>
		protected B()
		{
		}
	
		/// <summary>Initializes a new instance of the B class.</summary>
		protected B(System.Int32 field1, System.Int32 field2)
			: base(field1)
		{
			this.field2 = field2;
			this.Validate();
		}
	
		public static B Create(
			ImmutableObjectGraph.Optional<System.Int32> field1 = default(ImmutableObjectGraph.Optional<System.Int32>), 
			ImmutableObjectGraph.Optional<System.Int32> field2 = default(ImmutableObjectGraph.Optional<System.Int32>)) {
			return DefaultInstance.With(
				field1.IsDefined ? field1 : ImmutableObjectGraph.Optional.For(DefaultInstance.Field1), 
				field2.IsDefined ? field2 : ImmutableObjectGraph.Optional.For(DefaultInstance.Field2));
		}
	
		public System.Int32 Field2 {
			get { return this.field2; }
		}
		/// <summary>Returns a new instance with the Field1 property set to the specified value.</summary>
		public new B WithField1(System.Int32 value) {
			return (B)base.WithField1(value);
		}
		/// <summary>Returns a new instance with the Field2 property set to the specified value.</summary>
		public B WithField2(System.Int32 value) {
			if (value == this.Field2) {
				return this;
			}
	
			return this.With(field2: value);
		}
	
		/// <summary>Returns a new instance of this object with any number of properties changed.</summary>
		public override A With(
			ImmutableObjectGraph.Optional<System.Int32> field1 = default(ImmutableObjectGraph.Optional<System.Int32>)) {
			return this.With(
				field1: field1, 
				field2: default(ImmutableObjectGraph.Optional<System.Int32>));
		}
		
		/// <summary>Returns a new instance of this object with any number of properties changed.</summary>
		public virtual B With(
			ImmutableObjectGraph.Optional<System.Int32> field1 = default(ImmutableObjectGraph.Optional<System.Int32>), 
			ImmutableObjectGraph.Optional<System.Int32> field2 = default(ImmutableObjectGraph.Optional<System.Int32>)) {
			if (
				(field1.IsDefined && field1.Value != this.Field1) || 
				(field2.IsDefined && field2.Value != this.Field2)) {
				return new B(
					field1.IsDefined ? field1.Value : this.Field1,
					field2.IsDefined ? field2.Value : this.Field2);
			} else {
				return this;
			}
		}
	
	
		public new Builder ToBuilder() {
			return new Builder(this);
		}
	
		public A ToA() {
			throw new System.NotImplementedException();
		}
		public C1 ToC1(
			ImmutableObjectGraph.Optional<System.Int32> field3 = default(ImmutableObjectGraph.Optional<System.Int32>)) {
			throw new System.NotImplementedException();
		}
		public C2 ToC2(
			ImmutableObjectGraph.Optional<System.Int32> field3 = default(ImmutableObjectGraph.Optional<System.Int32>)) {
			throw new System.NotImplementedException();
		}
	
	 
		/// <summary>Normalizes and/or validates all properties on this object.</summary>
		/// <exception type="ArgumentException">Thrown if any properties have disallowed values.</exception>
		partial void Validate();
	
		/// <summary>Provides defaults for fields.</summary>
		/// <param name="template">The struct to set default values on.</param>
		static partial void CreateDefaultTemplate(ref Template template);
	
		/// <summary>Returns a newly instantiated B whose fields are initialized with default values.</summary>
		private static B GetDefaultTemplate() {
			var template = new Template();
			CreateDefaultTemplate(ref template);
			return new B(
				template.Field1, 
				template.Field2);
		}
	
		public new partial class Builder : A.Builder {
			[DebuggerBrowsable(DebuggerBrowsableState.Never)]
			private B immutable;
	
			[DebuggerBrowsable(DebuggerBrowsableState.Never)]
			protected System.Int32 field2;
	
			internal Builder(B immutable) : base(immutable) {
				this.immutable = immutable;
	
				this.field2 = immutable.Field2;
			}
	
			public System.Int32 Field2 {
				get {
					return this.field2;
				}
	
				set {
					this.field2 = value;
				}
			}
	
			public new B ToImmutable() {
				return this.immutable = this.immutable.With(
					ImmutableObjectGraph.Optional.For(this.Field1),
					ImmutableObjectGraph.Optional.For(this.Field2));
			}
		}
	
		/// <summary>A struct with all the same fields as the containing type for use in describing default values for new instances of the class.</summary>
		private struct Template {
			internal System.Int32 Field1 { get; set; }
	
			internal System.Int32 Field2 { get; set; }
		}
	}
	
	public interface IC1 : IB {
		System.Int32 Field3 { get; }
	}
	
	public partial class C1 : B, IC1 {
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		private static readonly C1 DefaultInstance = GetDefaultTemplate();
	
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		private readonly System.Int32 field3;
	
		/// <summary>Initializes a new instance of the C1 class.</summary>
		protected C1()
		{
		}
	
		/// <summary>Initializes a new instance of the C1 class.</summary>
		protected C1(System.Int32 field1, System.Int32 field2, System.Int32 field3)
			: base(field1,field2)
		{
			this.field3 = field3;
			this.Validate();
		}
	
		public static C1 Create(
			ImmutableObjectGraph.Optional<System.Int32> field1 = default(ImmutableObjectGraph.Optional<System.Int32>), 
			ImmutableObjectGraph.Optional<System.Int32> field2 = default(ImmutableObjectGraph.Optional<System.Int32>), 
			ImmutableObjectGraph.Optional<System.Int32> field3 = default(ImmutableObjectGraph.Optional<System.Int32>)) {
			return DefaultInstance.With(
				field1.IsDefined ? field1 : ImmutableObjectGraph.Optional.For(DefaultInstance.Field1), 
				field2.IsDefined ? field2 : ImmutableObjectGraph.Optional.For(DefaultInstance.Field2), 
				field3.IsDefined ? field3 : ImmutableObjectGraph.Optional.For(DefaultInstance.Field3));
		}
	
		public System.Int32 Field3 {
			get { return this.field3; }
		}
		/// <summary>Returns a new instance with the Field1 property set to the specified value.</summary>
		public new C1 WithField1(System.Int32 value) {
			return (C1)base.WithField1(value);
		}
		/// <summary>Returns a new instance with the Field2 property set to the specified value.</summary>
		public new C1 WithField2(System.Int32 value) {
			return (C1)base.WithField2(value);
		}
		/// <summary>Returns a new instance with the Field3 property set to the specified value.</summary>
		public C1 WithField3(System.Int32 value) {
			if (value == this.Field3) {
				return this;
			}
	
			return this.With(field3: value);
		}
	
		/// <summary>Returns a new instance of this object with any number of properties changed.</summary>
		public override B With(
			ImmutableObjectGraph.Optional<System.Int32> field1 = default(ImmutableObjectGraph.Optional<System.Int32>), 
			ImmutableObjectGraph.Optional<System.Int32> field2 = default(ImmutableObjectGraph.Optional<System.Int32>)) {
			return this.With(
				field1: field1, 
				field2: field2, 
				field3: default(ImmutableObjectGraph.Optional<System.Int32>));
		}
		
		/// <summary>Returns a new instance of this object with any number of properties changed.</summary>
		public virtual C1 With(
			ImmutableObjectGraph.Optional<System.Int32> field1 = default(ImmutableObjectGraph.Optional<System.Int32>), 
			ImmutableObjectGraph.Optional<System.Int32> field2 = default(ImmutableObjectGraph.Optional<System.Int32>), 
			ImmutableObjectGraph.Optional<System.Int32> field3 = default(ImmutableObjectGraph.Optional<System.Int32>)) {
			if (
				(field1.IsDefined && field1.Value != this.Field1) || 
				(field2.IsDefined && field2.Value != this.Field2) || 
				(field3.IsDefined && field3.Value != this.Field3)) {
				return new C1(
					field1.IsDefined ? field1.Value : this.Field1,
					field2.IsDefined ? field2.Value : this.Field2,
					field3.IsDefined ? field3.Value : this.Field3);
			} else {
				return this;
			}
		}
	
	
		public new Builder ToBuilder() {
			return new Builder(this);
		}
	
		public B ToB() {
			throw new System.NotImplementedException();
		}
	
	 
		/// <summary>Normalizes and/or validates all properties on this object.</summary>
		/// <exception type="ArgumentException">Thrown if any properties have disallowed values.</exception>
		partial void Validate();
	
		/// <summary>Provides defaults for fields.</summary>
		/// <param name="template">The struct to set default values on.</param>
		static partial void CreateDefaultTemplate(ref Template template);
	
		/// <summary>Returns a newly instantiated C1 whose fields are initialized with default values.</summary>
		private static C1 GetDefaultTemplate() {
			var template = new Template();
			CreateDefaultTemplate(ref template);
			return new C1(
				template.Field1, 
				template.Field2, 
				template.Field3);
		}
	
		public new partial class Builder : B.Builder {
			[DebuggerBrowsable(DebuggerBrowsableState.Never)]
			private C1 immutable;
	
			[DebuggerBrowsable(DebuggerBrowsableState.Never)]
			protected System.Int32 field3;
	
			internal Builder(C1 immutable) : base(immutable) {
				this.immutable = immutable;
	
				this.field3 = immutable.Field3;
			}
	
			public System.Int32 Field3 {
				get {
					return this.field3;
				}
	
				set {
					this.field3 = value;
				}
			}
	
			public new C1 ToImmutable() {
				return this.immutable = this.immutable.With(
					ImmutableObjectGraph.Optional.For(this.Field1),
					ImmutableObjectGraph.Optional.For(this.Field2),
					ImmutableObjectGraph.Optional.For(this.Field3));
			}
		}
	
		/// <summary>A struct with all the same fields as the containing type for use in describing default values for new instances of the class.</summary>
		private struct Template {
			internal System.Int32 Field1 { get; set; }
	
			internal System.Int32 Field2 { get; set; }
	
			internal System.Int32 Field3 { get; set; }
		}
	}
	
	public interface IC2 : IB {
		System.Int32 Field3 { get; }
	}
	
	public partial class C2 : B, IC2 {
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		private static readonly C2 DefaultInstance = GetDefaultTemplate();
	
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		private readonly System.Int32 field3;
	
		/// <summary>Initializes a new instance of the C2 class.</summary>
		protected C2()
		{
		}
	
		/// <summary>Initializes a new instance of the C2 class.</summary>
		protected C2(System.Int32 field1, System.Int32 field2, System.Int32 field3)
			: base(field1,field2)
		{
			this.field3 = field3;
			this.Validate();
		}
	
		public static C2 Create(
			ImmutableObjectGraph.Optional<System.Int32> field1 = default(ImmutableObjectGraph.Optional<System.Int32>), 
			ImmutableObjectGraph.Optional<System.Int32> field2 = default(ImmutableObjectGraph.Optional<System.Int32>), 
			ImmutableObjectGraph.Optional<System.Int32> field3 = default(ImmutableObjectGraph.Optional<System.Int32>)) {
			return DefaultInstance.With(
				field1.IsDefined ? field1 : ImmutableObjectGraph.Optional.For(DefaultInstance.Field1), 
				field2.IsDefined ? field2 : ImmutableObjectGraph.Optional.For(DefaultInstance.Field2), 
				field3.IsDefined ? field3 : ImmutableObjectGraph.Optional.For(DefaultInstance.Field3));
		}
	
		public System.Int32 Field3 {
			get { return this.field3; }
		}
		/// <summary>Returns a new instance with the Field1 property set to the specified value.</summary>
		public new C2 WithField1(System.Int32 value) {
			return (C2)base.WithField1(value);
		}
		/// <summary>Returns a new instance with the Field2 property set to the specified value.</summary>
		public new C2 WithField2(System.Int32 value) {
			return (C2)base.WithField2(value);
		}
		/// <summary>Returns a new instance with the Field3 property set to the specified value.</summary>
		public C2 WithField3(System.Int32 value) {
			if (value == this.Field3) {
				return this;
			}
	
			return this.With(field3: value);
		}
	
		/// <summary>Returns a new instance of this object with any number of properties changed.</summary>
		public override B With(
			ImmutableObjectGraph.Optional<System.Int32> field1 = default(ImmutableObjectGraph.Optional<System.Int32>), 
			ImmutableObjectGraph.Optional<System.Int32> field2 = default(ImmutableObjectGraph.Optional<System.Int32>)) {
			return this.With(
				field1: field1, 
				field2: field2, 
				field3: default(ImmutableObjectGraph.Optional<System.Int32>));
		}
		
		/// <summary>Returns a new instance of this object with any number of properties changed.</summary>
		public virtual C2 With(
			ImmutableObjectGraph.Optional<System.Int32> field1 = default(ImmutableObjectGraph.Optional<System.Int32>), 
			ImmutableObjectGraph.Optional<System.Int32> field2 = default(ImmutableObjectGraph.Optional<System.Int32>), 
			ImmutableObjectGraph.Optional<System.Int32> field3 = default(ImmutableObjectGraph.Optional<System.Int32>)) {
			if (
				(field1.IsDefined && field1.Value != this.Field1) || 
				(field2.IsDefined && field2.Value != this.Field2) || 
				(field3.IsDefined && field3.Value != this.Field3)) {
				return new C2(
					field1.IsDefined ? field1.Value : this.Field1,
					field2.IsDefined ? field2.Value : this.Field2,
					field3.IsDefined ? field3.Value : this.Field3);
			} else {
				return this;
			}
		}
	
	
		public new Builder ToBuilder() {
			return new Builder(this);
		}
	
		public B ToB() {
			throw new System.NotImplementedException();
		}
	
	 
		/// <summary>Normalizes and/or validates all properties on this object.</summary>
		/// <exception type="ArgumentException">Thrown if any properties have disallowed values.</exception>
		partial void Validate();
	
		/// <summary>Provides defaults for fields.</summary>
		/// <param name="template">The struct to set default values on.</param>
		static partial void CreateDefaultTemplate(ref Template template);
	
		/// <summary>Returns a newly instantiated C2 whose fields are initialized with default values.</summary>
		private static C2 GetDefaultTemplate() {
			var template = new Template();
			CreateDefaultTemplate(ref template);
			return new C2(
				template.Field1, 
				template.Field2, 
				template.Field3);
		}
	
		public new partial class Builder : B.Builder {
			[DebuggerBrowsable(DebuggerBrowsableState.Never)]
			private C2 immutable;
	
			[DebuggerBrowsable(DebuggerBrowsableState.Never)]
			protected System.Int32 field3;
	
			internal Builder(C2 immutable) : base(immutable) {
				this.immutable = immutable;
	
				this.field3 = immutable.Field3;
			}
	
			public System.Int32 Field3 {
				get {
					return this.field3;
				}
	
				set {
					this.field3 = value;
				}
			}
	
			public new C2 ToImmutable() {
				return this.immutable = this.immutable.With(
					ImmutableObjectGraph.Optional.For(this.Field1),
					ImmutableObjectGraph.Optional.For(this.Field2),
					ImmutableObjectGraph.Optional.For(this.Field3));
			}
		}
	
		/// <summary>A struct with all the same fields as the containing type for use in describing default values for new instances of the class.</summary>
		private struct Template {
			internal System.Int32 Field1 { get; set; }
	
			internal System.Int32 Field2 { get; set; }
	
			internal System.Int32 Field3 { get; set; }
		}
	}
}

