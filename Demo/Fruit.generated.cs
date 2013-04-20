﻿// ------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     ImmutableTree Version: 0.0.0.1
//  
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
// ------------------------------------------------------------------------------

namespace Demo {
	using System.Diagnostics;

	
	public partial class Basket {
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		private static readonly Basket DefaultInstance = GetDefaultTemplate();
	
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		private readonly System.Int32 size;
	
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		private readonly System.Collections.Immutable.ImmutableList<Fruit> contents;
	
		/// <summary>Initializes a new instance of the Basket class.</summary>
		private Basket()
		{
		}
	
		/// <summary>Initializes a new instance of the Basket class.</summary>
		private Basket(System.Int32 size, System.Collections.Immutable.ImmutableList<Fruit> contents)
		{
			this.size = size;
			this.contents = contents;
			this.Validate();
		}
	
		public static Basket Create(
			ImmutableObjectGraph.Optional<System.Int32> size = default(ImmutableObjectGraph.Optional<System.Int32>), 
			ImmutableObjectGraph.Optional<System.Collections.Immutable.ImmutableList<Fruit>> contents = default(ImmutableObjectGraph.Optional<System.Collections.Immutable.ImmutableList<Fruit>>)) {
			return DefaultInstance.With(
				size.IsDefined ? size : ImmutableObjectGraph.Optional.For(DefaultInstance.size), 
				contents.IsDefined ? contents : ImmutableObjectGraph.Optional.For(DefaultInstance.contents));
		}
	
		public System.Int32 Size {
			get { return this.size; }
		}
	
		public Basket WithSize(System.Int32 value) {
			if (value == this.Size) {
				return this;
			}
	
			return new Basket(value, this.Contents);
		}
	
		public System.Collections.Immutable.ImmutableList<Fruit> Contents {
			get { return this.contents; }
		}
	
		public Basket WithContents(System.Collections.Immutable.ImmutableList<Fruit> value) {
			if (value == this.Contents) {
				return this;
			}
	
			return new Basket(this.Size, value);
		}
	
		/// <summary>Returns a new instance of this object with any number of properties changed.</summary>
		public Basket With(
			ImmutableObjectGraph.Optional<System.Int32> size = default(ImmutableObjectGraph.Optional<System.Int32>), 
			ImmutableObjectGraph.Optional<System.Collections.Immutable.ImmutableList<Fruit>> contents = default(ImmutableObjectGraph.Optional<System.Collections.Immutable.ImmutableList<Fruit>>)) {
			if (
				(size.IsDefined && size.Value != this.Size) || 
				(contents.IsDefined && contents.Value != this.Contents)) {
				return new Basket(
					size.IsDefined ? size.Value : this.Size,
					contents.IsDefined ? contents.Value : this.Contents);
			} else {
				return this;
			}
		}
	
		public Builder ToBuilder() {
			return new Builder(this);
		}
	
		/// <summary>Normalizes and/or validates all properties on this object.</summary>
		/// <exception type="ArgumentException">Thrown if any properties have disallowed values.</exception>
		partial void Validate();
	
		/// <summary>Provides defaults for fields.</summary>
		/// <param name="template">The struct to set default values on.</param>
		static partial void CreateDefaultTemplate(ref Template template);
	
		/// <summary>Returns a newly instantiated Basket whose fields are initialized with default values.</summary>
		private static Basket GetDefaultTemplate() {
			var template = new Template();
			CreateDefaultTemplate(ref template);
			return new Basket(
				template.Size, 
				template.Contents);
		}
	
		public partial class Builder {
			[DebuggerBrowsable(DebuggerBrowsableState.Never)]
			private Basket immutable;
	
			[DebuggerBrowsable(DebuggerBrowsableState.Never)]
			private System.Int32 size;
	
			[DebuggerBrowsable(DebuggerBrowsableState.Never)]
			private ImmutableObjectGraph.Optional<System.Collections.Immutable.ImmutableList<Fruit>.Builder> contents;
	
			internal Builder(Basket immutable) {
				this.immutable = immutable;
	
				this.size = immutable.Size;
			}
	
			public System.Int32 Size {
				get {
					return this.size;
				}
	
				set {
					this.size = value;
				}
			}
	
			public System.Collections.Immutable.ImmutableList<Fruit>.Builder Contents {
				get {
					if (!this.contents.IsDefined) {
						this.contents = this.immutable.contents != null ? this.immutable.contents.ToBuilder() : null;
					}
	
					return this.contents.Value;
				}
	
				set {
					this.contents = value;
				}
			}
	
			public Basket ToImmutable() {
				var contents = this.contents.IsDefined ? (this.contents.Value != null ? this.contents.Value.ToImmutable() : null) : this.immutable.contents;
				return this.immutable = this.immutable.With(
					ImmutableObjectGraph.Optional.For(this.size),
					ImmutableObjectGraph.Optional.For(contents));
			}
		}
	
		/// <summary>A struct with all the same fields as the containing type for use in describing default values for new instances of the class.</summary>
		private struct Template {
			internal System.Int32 Size { get; set; }
	
			internal System.Collections.Immutable.ImmutableList<Fruit> Contents { get; set; }
		}
	}
	
	public partial class Fruit {
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		private static readonly Fruit DefaultInstance = GetDefaultTemplate();
	
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		private readonly System.String color;
	
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		private readonly System.Int32 skinThickness;
	
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		private readonly System.ICloneable growsOn;
	
		/// <summary>Initializes a new instance of the Fruit class.</summary>
		private Fruit()
		{
		}
	
		/// <summary>Initializes a new instance of the Fruit class.</summary>
		private Fruit(System.String color, System.Int32 skinThickness, System.ICloneable growsOn)
		{
			this.color = color;
			this.skinThickness = skinThickness;
			this.growsOn = growsOn;
			this.Validate();
		}
	
		public static Fruit Create(
			ImmutableObjectGraph.Optional<System.String> color = default(ImmutableObjectGraph.Optional<System.String>), 
			ImmutableObjectGraph.Optional<System.Int32> skinThickness = default(ImmutableObjectGraph.Optional<System.Int32>), 
			ImmutableObjectGraph.Optional<System.ICloneable> growsOn = default(ImmutableObjectGraph.Optional<System.ICloneable>)) {
			return DefaultInstance.With(
				color.IsDefined ? color : ImmutableObjectGraph.Optional.For(DefaultInstance.color), 
				skinThickness.IsDefined ? skinThickness : ImmutableObjectGraph.Optional.For(DefaultInstance.skinThickness), 
				growsOn.IsDefined ? growsOn : ImmutableObjectGraph.Optional.For(DefaultInstance.growsOn));
		}
	
		public System.String Color {
			get { return this.color; }
		}
	
		public Fruit WithColor(System.String value) {
			if (value == this.Color) {
				return this;
			}
	
			return new Fruit(value, this.SkinThickness, this.GrowsOn);
		}
	
		public System.Int32 SkinThickness {
			get { return this.skinThickness; }
		}
	
		public Fruit WithSkinThickness(System.Int32 value) {
			if (value == this.SkinThickness) {
				return this;
			}
	
			return new Fruit(this.Color, value, this.GrowsOn);
		}
	
		public System.ICloneable GrowsOn {
			get { return this.growsOn; }
		}
	
		public Fruit WithGrowsOn(System.ICloneable value) {
			if (value == this.GrowsOn) {
				return this;
			}
	
			return new Fruit(this.Color, this.SkinThickness, value);
		}
	
		/// <summary>Returns a new instance of this object with any number of properties changed.</summary>
		public Fruit With(
			ImmutableObjectGraph.Optional<System.String> color = default(ImmutableObjectGraph.Optional<System.String>), 
			ImmutableObjectGraph.Optional<System.Int32> skinThickness = default(ImmutableObjectGraph.Optional<System.Int32>), 
			ImmutableObjectGraph.Optional<System.ICloneable> growsOn = default(ImmutableObjectGraph.Optional<System.ICloneable>)) {
			if (
				(color.IsDefined && color.Value != this.Color) || 
				(skinThickness.IsDefined && skinThickness.Value != this.SkinThickness) || 
				(growsOn.IsDefined && growsOn.Value != this.GrowsOn)) {
				return new Fruit(
					color.IsDefined ? color.Value : this.Color,
					skinThickness.IsDefined ? skinThickness.Value : this.SkinThickness,
					growsOn.IsDefined ? growsOn.Value : this.GrowsOn);
			} else {
				return this;
			}
		}
	
		public Builder ToBuilder() {
			return new Builder(this);
		}
	
		/// <summary>Normalizes and/or validates all properties on this object.</summary>
		/// <exception type="ArgumentException">Thrown if any properties have disallowed values.</exception>
		partial void Validate();
	
		/// <summary>Provides defaults for fields.</summary>
		/// <param name="template">The struct to set default values on.</param>
		static partial void CreateDefaultTemplate(ref Template template);
	
		/// <summary>Returns a newly instantiated Fruit whose fields are initialized with default values.</summary>
		private static Fruit GetDefaultTemplate() {
			var template = new Template();
			CreateDefaultTemplate(ref template);
			return new Fruit(
				template.Color, 
				template.SkinThickness, 
				template.GrowsOn);
		}
	
		public partial class Builder {
			[DebuggerBrowsable(DebuggerBrowsableState.Never)]
			private Fruit immutable;
	
			[DebuggerBrowsable(DebuggerBrowsableState.Never)]
			private System.String color;
	
			[DebuggerBrowsable(DebuggerBrowsableState.Never)]
			private System.Int32 skinThickness;
	
			[DebuggerBrowsable(DebuggerBrowsableState.Never)]
			private System.ICloneable growsOn;
	
			internal Builder(Fruit immutable) {
				this.immutable = immutable;
	
				this.color = immutable.Color;
				this.skinThickness = immutable.SkinThickness;
				this.growsOn = immutable.GrowsOn;
			}
	
			public System.String Color {
				get {
					return this.color;
				}
	
				set {
					this.color = value;
				}
			}
	
			public System.Int32 SkinThickness {
				get {
					return this.skinThickness;
				}
	
				set {
					this.skinThickness = value;
				}
			}
	
			public System.ICloneable GrowsOn {
				get {
					return this.growsOn;
				}
	
				set {
					this.growsOn = value;
				}
			}
	
			public Fruit ToImmutable() {
				return this.immutable = this.immutable.With(
					ImmutableObjectGraph.Optional.For(this.color),
					ImmutableObjectGraph.Optional.For(this.skinThickness),
					ImmutableObjectGraph.Optional.For(this.growsOn));
			}
		}
	
		/// <summary>A struct with all the same fields as the containing type for use in describing default values for new instances of the class.</summary>
		private struct Template {
			internal System.String Color { get; set; }
	
			internal System.Int32 SkinThickness { get; set; }
	
			internal System.ICloneable GrowsOn { get; set; }
		}
	}
}

