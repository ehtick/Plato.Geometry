// Autogenerated file: DO NOT EDIT
// Created on 2025-04-07 9:26:07 AM

using System.Runtime.CompilerServices;
using System.Runtime.Serialization;
using System.Runtime.InteropServices;
using static System.Runtime.CompilerServices.MethodImplOptions;

namespace Plato
{
    [DataContract, StructLayout(LayoutKind.Sequential, Pack=1)]
    public partial struct Size3D: IValue
    {
        // Fields
        [DataMember] public readonly Size2D Base;
        [DataMember] public readonly Number Height;

        // With functions 
        [MethodImpl(AggressiveInlining)] public Size3D WithBase(Size2D _Base) => new Size3D(_Base, Height);
        [MethodImpl(AggressiveInlining)] public Size3D WithHeight(Number height) => new Size3D(Base, height);

        // Regular Constructor
        [MethodImpl(AggressiveInlining)] public Size3D(Size2D _Base, Number height) { Base = _Base; Height = height; }

        // Static factory function
        [MethodImpl(AggressiveInlining)] public static Size3D Create(Size2D _Base, Number height) => new Size3D(_Base, height);

        // Static default implementation
        public static readonly Size3D Default = default;

        // Implicit converters to/from value-tuples and deconstructor
        [MethodImpl(AggressiveInlining)] public static implicit operator (Size2D, Number)(Size3D self) => (self.Base, self.Height);
        [MethodImpl(AggressiveInlining)] public static implicit operator Size3D((Size2D, Number) value) => new Size3D(value.Item1, value.Item2);
        [MethodImpl(AggressiveInlining)] public void Deconstruct(out Size2D _Base, out Number height) { _Base = Base; height = Height;  }

        // Object virtual function overrides: Equals, GetHashCode, ToString
        [MethodImpl(AggressiveInlining)] public Boolean Equals(Size3D other) => Base.Equals(other.Base) && Height.Equals(other.Height);
        [MethodImpl(AggressiveInlining)] public Boolean NotEquals(Size3D other) => !Base.Equals(other.Base) && Height.Equals(other.Height);
        [MethodImpl(AggressiveInlining)] public override bool Equals(object obj) => obj is Size3D other ? Equals(other).Value : false;
        [MethodImpl(AggressiveInlining)] public override int GetHashCode() => Intrinsics.CombineHashCodes(Base, Height);
        [MethodImpl(AggressiveInlining)] public override string ToString() => $"{{ \"Base\" = {Base}, \"Height\" = {Height} }}";

        // Explicit implementation of interfaces by forwarding properties to fields

        // Implemented interface functions
        public Vector3 Vector3 { [MethodImpl(AggressiveInlining)] get  => (this.Base.Width, this.Base.Height, this.Height); } 
[MethodImpl(AggressiveInlining)]  public static implicit operator Vector3(Size3D x) => x.Vector3;

        // Unimplemented interface functions
    }
}
