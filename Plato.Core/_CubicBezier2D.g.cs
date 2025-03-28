// Autogenerated file: DO NOT EDIT
// Created on 2025-03-18 2:15:23 PM

using System.Runtime.CompilerServices;
using System.Runtime.Serialization;
using System.Runtime.InteropServices;
using static System.Runtime.CompilerServices.MethodImplOptions;

namespace Plato
{
    [DataContract, StructLayout(LayoutKind.Sequential, Pack=1)]
    public partial struct CubicBezier2D: IArray<Vector2>, IOpenCurve2D
    {
        // Fields
        [DataMember] public readonly Vector2 A;
        [DataMember] public readonly Vector2 B;
        [DataMember] public readonly Vector2 C;
        [DataMember] public readonly Vector2 D;

        // With functions 
        [MethodImpl(AggressiveInlining)] public CubicBezier2D WithA(Vector2 a) => new CubicBezier2D(a, B, C, D);
        [MethodImpl(AggressiveInlining)] public CubicBezier2D WithB(Vector2 b) => new CubicBezier2D(A, b, C, D);
        [MethodImpl(AggressiveInlining)] public CubicBezier2D WithC(Vector2 c) => new CubicBezier2D(A, B, c, D);
        [MethodImpl(AggressiveInlining)] public CubicBezier2D WithD(Vector2 d) => new CubicBezier2D(A, B, C, d);

        // Regular Constructor
        [MethodImpl(AggressiveInlining)] public CubicBezier2D(Vector2 a, Vector2 b, Vector2 c, Vector2 d) { A = a; B = b; C = c; D = d; }

        // Static factory function
        [MethodImpl(AggressiveInlining)] public static CubicBezier2D Create(Vector2 a, Vector2 b, Vector2 c, Vector2 d) => new CubicBezier2D(a, b, c, d);

        // Implicit converters to/from value-tuples and deconstructor
        [MethodImpl(AggressiveInlining)] public static implicit operator (Vector2, Vector2, Vector2, Vector2)(CubicBezier2D self) => (self.A, self.B, self.C, self.D);
        [MethodImpl(AggressiveInlining)] public static implicit operator CubicBezier2D((Vector2, Vector2, Vector2, Vector2) value) => new(value.Item1, value.Item2, value.Item3, value.Item4);
        [MethodImpl(AggressiveInlining)] public void Deconstruct(out Vector2 a, out Vector2 b, out Vector2 c, out Vector2 d) { a = A; b = B; c = C; d = D;  }

        // Object virtual function overrides: Equals, GetHashCode, ToString
        [MethodImpl(AggressiveInlining)] public Boolean Equals(CubicBezier2D other) => A.Equals(other.A) && B.Equals(other.B) && C.Equals(other.C) && D.Equals(other.D);
        [MethodImpl(AggressiveInlining)] public Boolean NotEquals(CubicBezier2D other) => !A.Equals(other.A) && B.Equals(other.B) && C.Equals(other.C) && D.Equals(other.D);
        [MethodImpl(AggressiveInlining)] public override bool Equals(object obj) => obj is CubicBezier2D other ? Equals(other) : false;
        [MethodImpl(AggressiveInlining)] public override int GetHashCode() => Intrinsics.CombineHashCodes(A, B, C, D);
        [MethodImpl(AggressiveInlining)] public override string ToString() => $"{{ \"A\" = {A}, \"B\" = {B}, \"C\" = {C}, \"D\" = {D} }}";

        // Explicit implementation of interfaces by forwarding properties to fields

        // Array predefined functions
        [MethodImpl(AggressiveInlining)] public CubicBezier2D(IReadOnlyList<Vector2> xs) : this(xs[0], xs[1], xs[2], xs[3]) { }
        [MethodImpl(AggressiveInlining)] public CubicBezier2D(Vector2[] xs) : this(xs[0], xs[1], xs[2], xs[3]) { }
        [MethodImpl(AggressiveInlining)] public static CubicBezier2D Create(IReadOnlyList<Vector2> xs) => new CubicBezier2D(xs);
        // Implementation of IReadOnlyList
        [MethodImpl(AggressiveInlining)] public System.Collections.Generic.IEnumerator<Vector2> GetEnumerator() => new ArrayEnumerator<Vector2>(this);
        [MethodImpl(AggressiveInlining)] System.Collections.IEnumerator System.Collections.IEnumerable.GetEnumerator() => GetEnumerator();
        Vector2 System.Collections.Generic.IReadOnlyList<Vector2>.this[int n] { [MethodImpl(AggressiveInlining)] get => At(n); }
        int System.Collections.Generic.IReadOnlyCollection<Vector2>.Count { [MethodImpl(AggressiveInlining)] get => this.Count; }

        // Implemented interface functions
        [MethodImpl(AggressiveInlining)]  public Vector2 Eval(Number t) => t.QuadraticBezier(this.A, this.B, this.C);
[MethodImpl(AggressiveInlining)]  public _T0 Sample<_T0>(Integer numPoints) where _T0 : IArray<_T0>{
            var _var57 = this;
            return numPoints.LinearSpace.Map((x)  => _var57.Eval(x));
        }

[MethodImpl(AggressiveInlining)]  public PolyLine2D ToPolyLine2D(Integer numPoints) => (this.Sample(numPoints), this.Closed);
public Boolean Closed { [MethodImpl(AggressiveInlining)] get  => ((Boolean)false); } 

        // Unimplemented concept functions
        public Integer Count { [MethodImpl(AggressiveInlining)] get => 4; }
        [MethodImpl(AggressiveInlining)]  public Vector2 At(Integer n) => n == 0 ? A : n == 1 ? B : n == 2 ? C : n == 3 ? D : throw new System.IndexOutOfRangeException();
        public Vector2 this[Integer n] { [MethodImpl(AggressiveInlining)] get => At(n); }
    }
}
