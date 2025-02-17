// Autogenerated file: DO NOT EDIT
// Created on 2025-01-29 8:54:01 AM

using System.Runtime.CompilerServices;
using System.Runtime.Serialization;
using System.Runtime.InteropServices;
using static System.Runtime.CompilerServices.MethodImplOptions;

namespace Plato
{
    [DataContract, StructLayout(LayoutKind.Sequential, Pack=1)]
    public partial struct Ray3D: IValue, IDeformable3D<Ray3D>
    {
        // Fields
        [DataMember] public readonly Vector3 Origin;
        [DataMember] public readonly Vector3 Direction;

        // With functions 
        [MethodImpl(AggressiveInlining)] public Ray3D WithOrigin(Vector3 origin) => new Ray3D(origin, Direction);
        [MethodImpl(AggressiveInlining)] public Ray3D WithDirection(Vector3 direction) => new Ray3D(Origin, direction);

        // Regular Constructor
        [MethodImpl(AggressiveInlining)] public Ray3D(Vector3 origin, Vector3 direction) { Origin = origin; Direction = direction; }

        // Static factory function
        [MethodImpl(AggressiveInlining)] public static Ray3D Create(Vector3 origin, Vector3 direction) => new Ray3D(origin, direction);

        // Implicit converters to/from value-tuples and deconstructor
        [MethodImpl(AggressiveInlining)] public static implicit operator (Vector3, Vector3)(Ray3D self) => (self.Origin, self.Direction);
        [MethodImpl(AggressiveInlining)] public static implicit operator Ray3D((Vector3, Vector3) value) => new(value.Item1, value.Item2);
        [MethodImpl(AggressiveInlining)] public void Deconstruct(out Vector3 origin, out Vector3 direction) { origin = Origin; direction = Direction;  }

        // Object virtual function overrides: Equals, GetHashCode, ToString
        [MethodImpl(AggressiveInlining)] public Boolean Equals(Ray3D other) => Origin.Equals(other.Origin) && Direction.Equals(other.Direction);
        [MethodImpl(AggressiveInlining)] public Boolean NotEquals(Ray3D other) => !Origin.Equals(other.Origin) && Direction.Equals(other.Direction);
        [MethodImpl(AggressiveInlining)] public override bool Equals(object obj) => obj is Ray3D other ? Equals(other) : false;
        [MethodImpl(AggressiveInlining)] public override int GetHashCode() => Intrinsics.CombineHashCodes(Origin, Direction);
        [MethodImpl(AggressiveInlining)] public override string ToString() => $"{{ \"Origin\" = {Origin}, \"Direction\" = {Direction} }}";

        // Explicit implementation of interfaces by forwarding properties to fields

        // Implemented concept functions and type functions
        [MethodImpl(AggressiveInlining)]  public Angle Angle(Ray3D b) => this.Direction.Angle(b.Direction);
        public Line3D Line3D { [MethodImpl(AggressiveInlining)] get  => (this.Origin, this.Origin.Add(this.Direction)); } 
        [MethodImpl(AggressiveInlining)]  public static implicit operator Line3D(Ray3D r) => r.Line3D;
        public Ray3D Reverse { [MethodImpl(AggressiveInlining)] get  => (this.Origin, this.Direction.Negative); } 

        // Unimplemented concept functions
        [MethodImpl(AggressiveInlining)]  public Ray3D Deform(System.Func<Vector3, Vector3> f) => throw new NotImplementedException();
    }
}
