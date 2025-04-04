// Autogenerated file: DO NOT EDIT
// Created on 2025-04-03 1:53:19 AM

using System.Runtime.CompilerServices;
using System.Runtime.Serialization;
using System.Runtime.InteropServices;
using static System.Runtime.CompilerServices.MethodImplOptions;

namespace Plato
{
    [DataContract, StructLayout(LayoutKind.Sequential, Pack=1)]
    public partial struct Circle: IAngularCurve2D, IClosedCurve2D
    {
        // Fields
        [DataMember] public readonly Vector2 Center;
        [DataMember] public readonly Number Radius;

        // With functions 
        [MethodImpl(AggressiveInlining)] public Circle WithCenter(Vector2 center) => new Circle(center, Radius);
        [MethodImpl(AggressiveInlining)] public Circle WithRadius(Number radius) => new Circle(Center, radius);

        // Regular Constructor
        [MethodImpl(AggressiveInlining)] public Circle(Vector2 center, Number radius) { Center = center; Radius = radius; }

        // Static factory function
        [MethodImpl(AggressiveInlining)] public static Circle Create(Vector2 center, Number radius) => new Circle(center, radius);

        // Static default implementation
        public static readonly Circle Default = default;

        // Implicit converters to/from value-tuples and deconstructor
        [MethodImpl(AggressiveInlining)] public static implicit operator (Vector2, Number)(Circle self) => (self.Center, self.Radius);
        [MethodImpl(AggressiveInlining)] public static implicit operator Circle((Vector2, Number) value) => new(value.Item1, value.Item2);
        [MethodImpl(AggressiveInlining)] public void Deconstruct(out Vector2 center, out Number radius) { center = Center; radius = Radius;  }

        // Object virtual function overrides: Equals, GetHashCode, ToString
        [MethodImpl(AggressiveInlining)] public Boolean Equals(Circle other) => Center.Equals(other.Center) && Radius.Equals(other.Radius);
        [MethodImpl(AggressiveInlining)] public Boolean NotEquals(Circle other) => !Center.Equals(other.Center) && Radius.Equals(other.Radius);
        [MethodImpl(AggressiveInlining)] public override bool Equals(object obj) => obj is Circle other ? Equals(other) : false;
        [MethodImpl(AggressiveInlining)] public override int GetHashCode() => Intrinsics.CombineHashCodes(Center, Radius);
        [MethodImpl(AggressiveInlining)] public override string ToString() => $"{{ \"Center\" = {Center}, \"Radius\" = {Radius} }}";

        // Explicit implementation of interfaces by forwarding properties to fields

        // Implemented interface functions
        [MethodImpl(AggressiveInlining)]  public Vector2 Eval(Angle t) => t.Circle(this.Center, this.Radius);
[MethodImpl(AggressiveInlining)]  public Vector2 Eval(Number t) => this.Eval(t.Turns);
[MethodImpl(AggressiveInlining)]  public IArray<Vector2> Sample(Integer numPoints){
            var _var58 = this;
            return numPoints.LinearSpace.Map((x)  => _var58.Eval(x));
        }

[MethodImpl(AggressiveInlining)]  public PolyLine2D ToPolyLine2D(Integer numPoints) => (this.Sample(numPoints), this.Closed);
public Boolean Closed { [MethodImpl(AggressiveInlining)] get  => ((Boolean)true); } 

        // Unimplemented interface functions
    }
}
