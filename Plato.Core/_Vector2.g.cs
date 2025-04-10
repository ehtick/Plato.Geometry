// Autogenerated file: DO NOT EDIT
// Created on 2025-04-08 12:25:04 AM

using System.Runtime.CompilerServices;
using System.Runtime.Serialization;
using System.Runtime.InteropServices;
using static System.Runtime.CompilerServices.MethodImplOptions;

namespace Plato
{
    [StructLayout(LayoutKind.Sequential, Pack=1)]
    public partial struct Vector2: IVector<Vector2>
    {
        // Static factory function
        [MethodImpl(AggressiveInlining)] public static Vector2 Create(Number x, Number y) => new Vector2(x, y);

        // Static default implementation
        public static readonly Vector2 Default = default;

        // Implicit converters to/from value-tuples and deconstructor
        [MethodImpl(AggressiveInlining)] public static implicit operator (Number, Number)(Vector2 self) => (self.X, self.Y);
        [MethodImpl(AggressiveInlining)] public static implicit operator Vector2((Number, Number) value) => new Vector2(value.Item1, value.Item2);
        [MethodImpl(AggressiveInlining)] public void Deconstruct(out Number x, out Number y) { x = X; y = Y;  }

        // Object virtual function overrides: Equals, GetHashCode, ToString
        [MethodImpl(AggressiveInlining)] public Boolean Equals(Vector2 other) => Value.Equals(other.Value);
        [MethodImpl(AggressiveInlining)] public Boolean NotEquals(Vector2 other) => !Value.Equals(other.Value);
        [MethodImpl(AggressiveInlining)] public override bool Equals(object obj) => obj is Vector2 other ? Equals(other) : false;
        [MethodImpl(AggressiveInlining)] public static Boolean operator==(Vector2 a, Vector2 b) => a.Equals(b);
        [MethodImpl(AggressiveInlining)] public static Boolean operator!=(Vector2 a, Vector2 b) => !a.Equals(b);
        [MethodImpl(AggressiveInlining)] public override int GetHashCode() => Value.GetHashCode();
        [MethodImpl(AggressiveInlining)] public override string ToString() => Value.ToString();

        // Explicit implementation of interfaces by forwarding properties to fields

        // IArrayLike predefined functions
        public Integer NumComponents { [MethodImpl(AggressiveInlining)] get => 2; }
        public IArray<Number> Components { [MethodImpl(AggressiveInlining)] get => Intrinsics.MakeArray<Number>(X, Y); }
        [MethodImpl(AggressiveInlining)] public static Vector2 CreateFromComponents(IArray<Number> numbers) => new Vector2(numbers[0], numbers[1]);

        [MethodImpl(AggressiveInlining)] public static Vector2 CreateFromComponent(Number x) => new Vector2(x, x);

        // Implemented interface functions
        public Point2D Point2D { [MethodImpl(AggressiveInlining)] get  => (this.X, this.Y); } 
[MethodImpl(AggressiveInlining)]  public static implicit operator Point2D(Vector2 x) => x.Point2D;
        public Ray2D Ray2D { [MethodImpl(AggressiveInlining)] get  => (Constants.Origin2D, this); } 
[MethodImpl(AggressiveInlining)]  public static implicit operator Ray2D(Vector2 v) => v.Ray2D;
        public Vector3 To3D { [MethodImpl(AggressiveInlining)] get  => (this.X, this.Y, ((Integer)0)); } 
[MethodImpl(AggressiveInlining)]  public Vector2 Add(Vector2 right) => this + right;
        [MethodImpl(AggressiveInlining)]  public Vector2 Subtract(Vector2 right) => this - right;
        [MethodImpl(AggressiveInlining)]  public Vector2 Multiply(Vector2 right) => this * right;
        [MethodImpl(AggressiveInlining)]  public Vector2 Multiply(Number scalar) => this * scalar;
        [MethodImpl(AggressiveInlining)]  public Vector2 Divide(Vector2 right) => this / right;
        [MethodImpl(AggressiveInlining)]  public Vector2 Divide(Number scalar) => this / scalar;
        public Vector2 Negative { [MethodImpl(AggressiveInlining)] get => -this; }
        public Vector3 Vector3 { [MethodImpl(AggressiveInlining)] get  => this.ToVector3(((Number)0)); } 
[MethodImpl(AggressiveInlining)]  public static implicit operator Vector3(Vector2 v) => v.Vector3;
        public Vector4 Vector4 { [MethodImpl(AggressiveInlining)] get  => this.ToVector4(((Number)0), ((Number)0)); } 
[MethodImpl(AggressiveInlining)]  public static implicit operator Vector4(Vector2 v) => v.Vector4;
        [MethodImpl(AggressiveInlining)]  public Vector3 ToVector3(Number z) => (this.X, this.Y, z);
[MethodImpl(AggressiveInlining)]  public Vector4 ToVector4(Number z, Number w) => (this.X, this.Y, z, w);
public static Vector2 UnitX { [MethodImpl(AggressiveInlining)] get  => (((Number)1), ((Number)0)); } 
public static Vector2 UnitY { [MethodImpl(AggressiveInlining)] get  => (((Number)0), ((Number)1)); } 
[MethodImpl(AggressiveInlining)]  public Vector2 Project(Vector2 other) => other.Multiply(this.Dot(other));
[MethodImpl(AggressiveInlining)]  public Angle Angle(Vector2 b) => this.Dot(b).Divide(this.Magnitude.Multiply(b.Magnitude)).Acos;
[MethodImpl(AggressiveInlining)]  public Boolean IsParallel(Vector2 b) => this.Dot(b).Abs.GreaterThanOrEquals(((Number)1).Subtract(Constants.Epsilon));
public Vector2 PlusOne { [MethodImpl(AggressiveInlining)] get  => this.Add(One); } 
public Vector2 MinusOne { [MethodImpl(AggressiveInlining)] get  => this.Subtract(One); } 
// AMBIGUOUS FUNCTIONS 2
        public Vector2 FromOne { [MethodImpl(AggressiveInlining)] get  => this.Add(One).Negative; } 
[MethodImpl(AggressiveInlining)]  public Vector2 Barycentric(Vector2 v2, Vector2 v3, Vector2 uv) => this.Add(v2.Subtract(this)).Multiply(uv.X).Add(v3.Subtract(this).Multiply(uv.Y));
[MethodImpl(AggressiveInlining)]  public Vector2 Linear(Vector2 b, Number x) => this.Multiply(x).Add(b);
[MethodImpl(AggressiveInlining)]  public Vector2 Quadratic(Vector2 b, Vector2 c, Number x) => this.Multiply(x.Sqr).Add(b.Multiply(x).Add(c));
[MethodImpl(AggressiveInlining)]  public Vector2 Cubic(Vector2 b, Vector2 c, Vector2 d, Number x) => this.Multiply(x.Pow3).Add(b.Multiply(x.Sqr).Add(c.Multiply(x).Add(d)));
[MethodImpl(AggressiveInlining)]  public Vector2 Quartic(Vector2 b, Vector2 c, Vector2 d, Vector2 e, Number x) => this.Multiply(x.Pow(((Integer)4))).Add(b.Multiply(x.Pow3).Add(c.Multiply(x.Sqr).Add(d.Multiply(x).Add(e))));
[MethodImpl(AggressiveInlining)]  public Vector2 LinearDerivative(Vector2 b, Number x) => this;
[MethodImpl(AggressiveInlining)]  public Vector2 LinearSecondDerivative(Vector2 b, Number x) => default;
[MethodImpl(AggressiveInlining)]  public Vector2 QuadraticDerivative(Vector2 b, Vector2 c, Number x) => this.Multiply(((Number)2)).Multiply(x).Add(b);
[MethodImpl(AggressiveInlining)]  public Vector2 QuadraticSecondDerivative(Vector2 b, Vector2 c, Number x) => this.Multiply(((Number)2));
[MethodImpl(AggressiveInlining)]  public Vector2 CubicDerivative(Vector2 b, Vector2 c, Vector2 d, Number x) => this.Multiply(((Number)3)).Multiply(x.Sqr).Add(b.Multiply(((Number)2)).Multiply(x).Add(c));
[MethodImpl(AggressiveInlining)]  public Vector2 CubicSecondDerivative(Vector2 b, Vector2 c, Vector2 d, Number x) => this.Multiply(((Number)6)).Multiply(x).Add(b.Multiply(((Number)2)));
[MethodImpl(AggressiveInlining)]  public Vector2 QuarticSecondDerivative(Vector2 b, Vector2 c, Vector2 d, Vector2 e, Number x) => this.Multiply(((Number)12)).Multiply(x.Sqr).Add(b.Multiply(((Number)6)).Multiply(x).Add(c.Multiply(((Number)2))));
[MethodImpl(AggressiveInlining)]  public Vector2 CubicBezier(Vector2 b, Vector2 c, Vector2 d, Number t) => this.Multiply(((Number)1).Subtract(t).Pow3).Add(b.Multiply(((Number)3).Multiply(((Number)1).Subtract(t).Sqr.Multiply(t))).Add(c.Multiply(((Number)3).Multiply(((Number)1).Subtract(t).Multiply(t.Sqr))).Add(d.Multiply(t.Pow3))));
[MethodImpl(AggressiveInlining)]  public Vector2 CubicBezierDerivative(Vector2 b, Vector2 c, Vector2 d, Number t) => b.Subtract(this).Multiply(((Number)3).Multiply(((Number)1).Subtract(t).Sqr)).Add(c.Subtract(b).Multiply(((Number)6).Multiply(((Number)1).Subtract(t).Multiply(t))).Add(d.Subtract(c).Multiply(((Number)3).Multiply(t.Sqr))));
[MethodImpl(AggressiveInlining)]  public Vector2 CubicBezierSecondDerivative(Vector2 b, Vector2 c, Vector2 d, Number t) => c.Subtract(b.Multiply(((Number)2)).Add(this)).Multiply(((Number)6).Multiply(((Number)1).Subtract(t))).Add(d.Subtract(c.Multiply(((Number)2)).Add(b)).Multiply(((Number)6).Multiply(t)));
[MethodImpl(AggressiveInlining)]  public Vector2 QuadraticBezier(Vector2 b, Vector2 c, Number t) => this.Multiply(((Number)1).Subtract(t).Sqr).Add(b.Multiply(((Number)2).Multiply(((Number)1).Subtract(t).Multiply(t))).Add(c.Multiply(t.Sqr)));
[MethodImpl(AggressiveInlining)]  public Vector2 QuadraticBezierDerivative(Vector2 b, Vector2 c, Number t) => b.Subtract(this).Multiply(((Number)2).Multiply(((Number)1).Subtract(t))).Add(c.Subtract(b).Multiply(((Number)2).Multiply(t)));
[MethodImpl(AggressiveInlining)]  public Vector2 QuadraticBezierSecondDerivative(Vector2 b, Vector2 c, Number t) => ((Number)2).Multiply(this.Subtract(b.Multiply(((Number)2)).Add(c)));
[MethodImpl(AggressiveInlining)]  public Vector2 Hermite(Vector2 p1, Vector2 m0, Vector2 m1, Number t) => this.Multiply(((Number)2).Multiply(t.Pow3).Subtract(((Number)3).Multiply(t.Sqr).Add(((Number)1)))).Add(m0.Multiply(t.Pow3.Subtract(((Number)2).Multiply(t.Sqr).Add(t))).Add(p1.Multiply(((Number)2).Multiply(t.Pow3).Add(((Number)3).Multiply(t.Sqr)).Negative).Add(m1.Multiply(t.Pow3.Subtract(t.Sqr)))));
[MethodImpl(AggressiveInlining)]  public Vector2 HermiteDerivative(Vector2 p1, Vector2 m0, Vector2 m1, Number t) => this.Multiply(((Number)6).Multiply(t.Sqr).Subtract(((Number)6).Multiply(t))).Add(m0.Multiply(((Number)3).Multiply(t.Sqr).Subtract(((Number)4).Multiply(t).Add(((Number)1)))).Add(p1.Multiply(((Number)6).Multiply(t.Sqr).Add(((Number)6).Multiply(t)).Negative).Add(m1.Multiply(((Number)3).Multiply(t.Sqr).Subtract(((Number)2).Multiply(t))))));
[MethodImpl(AggressiveInlining)]  public Vector2 CatmullRom(Vector2 p1, Vector2 p2, Vector2 p3, Number t) => ((Number)0.5).Multiply(p1.Multiply(((Number)2)).Add(p2.Subtract(this).Multiply(t).Add(this.Multiply(((Number)2)).Subtract(p1.Multiply(((Number)5)).Add(p2.Multiply(((Number)4)).Subtract(p3))).Multiply(t.Sqr).Add(this.Add(p1.Multiply(((Number)3)).Subtract(p2.Multiply(((Number)3)).Add(p3))).Negative.Multiply(t.Pow3)))));
[MethodImpl(AggressiveInlining)]  public Vector2 CatmullRomDerivative(Vector2 p1, Vector2 p2, Vector2 p3, Number t) => ((Number)0.5).Multiply(p2.Subtract(this).Add(((Number)2).Multiply(this.Multiply(((Number)2)).Subtract(p1.Multiply(((Number)5)).Add(p2.Multiply(((Number)4)).Subtract(p3))).Multiply(t)).Add(((Number)3).Multiply(this.Add(p1.Multiply(((Number)3)).Subtract(p2.Multiply(((Number)3)).Add(p3))).Negative.Multiply(t.Sqr)))));
public Vector2 SmoothStep { [MethodImpl(AggressiveInlining)] get  => this.Sqr.Multiply(this.Twice.Add(((Number)3)).Negative); } 
public Vector2 SmootherStep { [MethodImpl(AggressiveInlining)] get  => this.Pow3.Multiply(this.Multiply(((Number)6)).Subtract(((Number)15))).Add(((Number)10)); } 
public static Vector2 Zero { [MethodImpl(AggressiveInlining)] get  => Vector2.CreateFromComponent(((Number)0)); } 
public static Vector2 One { [MethodImpl(AggressiveInlining)] get  => Vector2.CreateFromComponent(((Number)1)); } 
public static Vector2 MinValue { [MethodImpl(AggressiveInlining)] get  => Vector2.CreateFromComponent(Number.MinValue); } 
public static Vector2 MaxValue { [MethodImpl(AggressiveInlining)] get  => Vector2.CreateFromComponent(Number.MaxValue); } 
[MethodImpl(AggressiveInlining)]  public Number Reduce(Number initial, System.Func<Number, Number, Number> f) => this.Components.Reduce(initial, f);
public Number MinComponent { [MethodImpl(AggressiveInlining)] get  => this.Reduce(this.At(((Integer)0)), (a, b)  => a.Min(b)); } 
public Number MaxComponent { [MethodImpl(AggressiveInlining)] get  => this.Reduce(this.At(((Integer)0)), (a, b)  => a.Max(b)); } 
public Number SumComponents { [MethodImpl(AggressiveInlining)] get  => this.Reduce(((Number)0), (a, b)  => a.Add(b)); } 
public Number SumSqrComponents { [MethodImpl(AggressiveInlining)] get  => this.Reduce(((Number)0), (a, b)  => a.Add(b.Multiply(b))); } 
public Number AvgComponent { [MethodImpl(AggressiveInlining)] get  => this.SumComponents.Divide(this.NumComponents); } 
public Number Magnitude { [MethodImpl(AggressiveInlining)] get  => this.MagnitudeSquared.Sqrt; } 
public Number MagnitudeSquared { [MethodImpl(AggressiveInlining)] get  => this.SumSqrComponents.Divide(this.NumComponents); } 
public Vector2 BitDecrement { [MethodImpl(AggressiveInlining)] get  => this.MapComponents((x)  => x.BitDecrement); } 
public Vector2 BitIncrement { [MethodImpl(AggressiveInlining)] get  => this.MapComponents((x)  => x.BitIncrement); } 
public Vector2 Cbrt { [MethodImpl(AggressiveInlining)] get  => this.MapComponents((x)  => x.Cbrt); } 
[MethodImpl(AggressiveInlining)]  public Vector2 CopySign(Vector2 y) => this.ZipComponents(y, (a, b)  => a.CopySign(b));
[MethodImpl(AggressiveInlining)]  public Vector2 FusedMultiplyAdd(Vector2 y, Vector2 z) => this.ZipComponents(y, z, (a, b, c)  => a.FusedMultiplyAdd(b, c));
public Vector2 ILogB { [MethodImpl(AggressiveInlining)] get  => this.MapComponents((x)  => x.ILogB); } 
[MethodImpl(AggressiveInlining)]  public Vector2 IEEERemainder(Vector2 y) => this.ZipComponents(y, (a, b)  => a.IEEERemainder(b));
public Vector2 Log10 { [MethodImpl(AggressiveInlining)] get  => this.MapComponents((x)  => x.Log10); } 
[MethodImpl(AggressiveInlining)]  public Vector2 MinMagnitude(Vector2 other) => this.ZipComponents(other, (a, b)  => a.MinMagnitude(b));
[MethodImpl(AggressiveInlining)]  public Vector2 MaxMagnitude(Vector2 other) => this.ZipComponents(other, (a, b)  => a.MaxMagnitude(b));
public Vector2 NaturalLog { [MethodImpl(AggressiveInlining)] get  => this.MapComponents((x)  => x.NaturalLog); } 
[MethodImpl(AggressiveInlining)]  public Vector2 Pow(Vector2 power) => this.ZipComponents(power, (a, b)  => a.Pow(b));
public Vector2 Reciprocal { [MethodImpl(AggressiveInlining)] get  => this.MapComponents((x)  => x.Reciprocal); } 
public Vector2 ReciprocalEstimate { [MethodImpl(AggressiveInlining)] get  => this.MapComponents((x)  => x.ReciprocalEstimate); } 
public Vector2 ReciprocalSquareRootEstimate { [MethodImpl(AggressiveInlining)] get  => this.MapComponents((x)  => x.ReciprocalSquareRootEstimate); } 
[MethodImpl(AggressiveInlining)]  public Vector2 RoundToZero(Integer digits){
            var _var194 = digits;
            return this.MapComponents((x)  => x.RoundToZero(_var194));
        }

[MethodImpl(AggressiveInlining)]  public Vector2 ScaleB(Integer n){
            var _var195 = n;
            return this.MapComponents((x)  => x.ScaleB(_var195));
        }

public Vector2 Square { [MethodImpl(AggressiveInlining)] get  => this.MapComponents((x)  => x.Sqr); } 
[MethodImpl(AggressiveInlining)]  public Boolean AlmostEqual(Vector2 y) => this.AllZipComponents(y, (a, b)  => a.AlmostEqual(b));
public Boolean AlmostZero { [MethodImpl(AggressiveInlining)] get  => this.AllComponents((x)  => x.AlmostZero); } 
// AMBIGUOUS FUNCTIONS 2
        [MethodImpl(AggressiveInlining)]  public Vector2 Average(Vector2 y) => this.Lerp(y, ((Number)0.5));
[MethodImpl(AggressiveInlining)]  public Boolean Between(Vector2 a, Vector2 b) => this.AllZipComponents(a, b, (x1, a1, b1)  => x1.Between(a1, b1));
public Boolean Between01 { [MethodImpl(AggressiveInlining)] get  => this.AllComponents((x1)  => x1.Between01); } 
public Vector2 ClampZeroOne { [MethodImpl(AggressiveInlining)] get  => this.MapComponents((x1)  => x1.ClampZeroOne); } 
public Vector2 Fract { [MethodImpl(AggressiveInlining)] get  => this.MapComponents((x1)  => x1.Fract); } 
[MethodImpl(AggressiveInlining)]  public Vector2 InversePow(Vector2 y) => this.ZipComponents(y, (x1, y1)  => x1.InversePow(y1));
[MethodImpl(AggressiveInlining)]  public Vector2 Lerp(Vector2 b, Number t){
            var _var196 = t;
            return this.ZipComponents(b, (a1, b1)  => a1.Lerp(b1, _var196));
        }

[MethodImpl(AggressiveInlining)]  public Vector2 MultiplyEpsilon(Vector2 y) => this.ZipComponents(y, (x1, y1)  => x1.MultiplyEpsilon(y1));
public Vector2 Pow2 { [MethodImpl(AggressiveInlining)] get  => this.MapComponents((x1)  => x1.Pow2); } 
public Vector2 Pow3 { [MethodImpl(AggressiveInlining)] get  => this.MapComponents((x1)  => x1.Pow3); } 
public Vector2 Pow4 { [MethodImpl(AggressiveInlining)] get  => this.MapComponents((x1)  => x1.Pow4); } 
public Vector2 Pow5 { [MethodImpl(AggressiveInlining)] get  => this.MapComponents((x1)  => x1.Pow5); } 
public Vector2 Sqr { [MethodImpl(AggressiveInlining)] get  => this.MapComponents((x1)  => x1.Sqr); } 
[MethodImpl(AggressiveInlining)]  public IArray<Vector2> Sample(Vector2 b, Integer n){
            var _var198 = b;
            {
                var _var197 = this;
                return n.LinearSpace.Map((i)  => _var197.Lerp(_var198, i));
            }
        }

public Vector2 Half { [MethodImpl(AggressiveInlining)] get  => this.Divide(((Number)2)); } 
public Vector2 Quarter { [MethodImpl(AggressiveInlining)] get  => this.Divide(((Number)4)); } 
public Vector2 Eight { [MethodImpl(AggressiveInlining)] get  => this.Divide(((Number)8)); } 
public Vector2 Sixteenth { [MethodImpl(AggressiveInlining)] get  => this.Divide(((Number)16)); } 
public Vector2 Tenth { [MethodImpl(AggressiveInlining)] get  => this.Divide(((Number)10)); } 
public Vector2 Twice { [MethodImpl(AggressiveInlining)] get  => this.Multiply(((Number)2)); } 
public Vector2 Hundred { [MethodImpl(AggressiveInlining)] get  => this.Multiply(((Number)100)); } 
public Vector2 Thousand { [MethodImpl(AggressiveInlining)] get  => this.Multiply(((Number)1000)); } 
public Vector2 Million { [MethodImpl(AggressiveInlining)] get  => this.Thousand.Thousand; } 
public Vector2 Billion { [MethodImpl(AggressiveInlining)] get  => this.Thousand.Million; } 
public Vector2 Hundredth { [MethodImpl(AggressiveInlining)] get  => this.Divide(((Number)100)); } 
public Vector2 Thousandth { [MethodImpl(AggressiveInlining)] get  => this.Divide(((Number)1000)); } 
public Vector2 Millionth { [MethodImpl(AggressiveInlining)] get  => this.Thousandth.Thousandth; } 
public Vector2 Billionth { [MethodImpl(AggressiveInlining)] get  => this.Thousandth.Millionth; } 
[MethodImpl(AggressiveInlining)]  public Number At(Integer n) => this.Components.At(n);
public Number this[Integer n] { [MethodImpl(AggressiveInlining)]  get => At(n); }
        [MethodImpl(AggressiveInlining)]  public Vector2 MapComponents(System.Func<Number, Number> f) => Vector2.CreateFromComponents(this.Components.Map(f));
[MethodImpl(AggressiveInlining)]  public Vector2 ZipComponents(Vector2 b, System.Func<Number, Number, Number> f) => Vector2.CreateFromComponents(this.Components.Zip(b.Components, f));
[MethodImpl(AggressiveInlining)]  public Vector2 ZipComponents(Vector2 b, Vector2 c, System.Func<Number, Number, Number, Number> f) => Vector2.CreateFromComponents(this.Components.Zip(b.Components, c.Components, f));
[MethodImpl(AggressiveInlining)]  public Boolean AllZipComponents(Vector2 b, System.Func<Number, Number, Boolean> f) => this.Components.Zip(b.Components, f).All((x)  => x);
[MethodImpl(AggressiveInlining)]  public Boolean AllZipComponents(Vector2 b, Vector2 c, System.Func<Number, Number, Number, Boolean> f) => this.Components.Zip(b.Components, c.Components, f).All((x)  => x);
[MethodImpl(AggressiveInlining)]  public Boolean AnyZipComponents(Vector2 b, System.Func<Number, Number, Boolean> f) => this.Components.Zip(b.Components, f).Any((x)  => x);
[MethodImpl(AggressiveInlining)]  public Boolean AnyZipComponents(Vector2 b, Vector2 c, System.Func<Number, Number, Number, Boolean> f) => this.Components.Zip(b.Components, c.Components, f).Any((x)  => x);
[MethodImpl(AggressiveInlining)]  public Boolean AllComponents(System.Func<Number, Boolean> predicate) => this.Components.All(predicate);
[MethodImpl(AggressiveInlining)]  public Boolean AnyComponent(System.Func<Number, Boolean> predicate) => this.Components.Any(predicate);

        // Unimplemented interface functions
        [MethodImpl(AggressiveInlining)]  public Vector2 Modulo(Vector2 b) => this % b;
        [MethodImpl(AggressiveInlining)]  public Vector2 Modulo(Number other) => this % other;
    }
}
