// Autogenerated file: DO NOT EDIT
// Created on 2025-01-29 8:54:01 AM

using System.Runtime.CompilerServices;
using System.Runtime.Serialization;
using System.Runtime.InteropServices;
using static System.Runtime.CompilerServices.MethodImplOptions;

namespace Plato
{
    [StructLayout(LayoutKind.Sequential, Pack=1)]
    public partial struct Integer: IWholeNumber<Integer>
    {
        // Static factory function
        [MethodImpl(AggressiveInlining)] public static Integer Create() => new Integer();

        // Object virtual function overrides: Equals, GetHashCode, ToString
        [MethodImpl(AggressiveInlining)] public Boolean Equals(Integer other) => Value.Equals(other.Value);
        [MethodImpl(AggressiveInlining)] public Boolean NotEquals(Integer other) => !Value.Equals(other.Value);
        [MethodImpl(AggressiveInlining)] public override bool Equals(object obj) => obj is Integer other ? Equals(other) : false;
        [MethodImpl(AggressiveInlining)] public static Boolean operator==(Integer a, Integer b) => a.Equals(b);
        [MethodImpl(AggressiveInlining)] public static Boolean operator!=(Integer a, Integer b) => !a.Equals(b);
        [MethodImpl(AggressiveInlining)] public override int GetHashCode() => Value.GetHashCode();
        [MethodImpl(AggressiveInlining)] public override string ToString() => Value.ToString();

        // Explicit implementation of interfaces by forwarding properties to fields

        // Implemented concept functions and type functions
        public Angle Turns { [MethodImpl(AggressiveInlining)] get  => this.Number.Turns; } 
        public Angle Degrees { [MethodImpl(AggressiveInlining)] get  => this.Number.Turns; } 
        public Angle Gradians { [MethodImpl(AggressiveInlining)] get  => this.Number.Gradians; } 
        public Angle ArcMinutes { [MethodImpl(AggressiveInlining)] get  => this.Number.ArcMinutes; } 
        public Angle ArcSeconds { [MethodImpl(AggressiveInlining)] get  => this.Number.ArcSeconds; } 
        public Array<Integer> Range { [MethodImpl(AggressiveInlining)] get  => this.MapRange((i) => i); } 
        public IArray<Vector2> CirclePoints { [MethodImpl(AggressiveInlining)] get  => this.Fractions.Map((x) => x.Turns.UnitCircle); } 
        public Number Number { [MethodImpl(AggressiveInlining)] get  => this; } 
        [MethodImpl(AggressiveInlining)]  public static implicit operator Number(Integer x) => x.Number;
        public Integer PlusOne { [MethodImpl(AggressiveInlining)] get  => this.Add(((Integer)1)); } 
        public Integer MinusOne { [MethodImpl(AggressiveInlining)] get  => this.Subtract(((Integer)1)); } 
        public Integer FromOne { [MethodImpl(AggressiveInlining)] get  => ((Integer)1).Subtract(this); } 
        [MethodImpl(AggressiveInlining)]  public Number FloatDivision(Integer y) => this.Number.Divide(y.Number);
        public IArray<Number> Fractions { [MethodImpl(AggressiveInlining)] get {
            var _var89 = this;
            return this.Range.Map((i) => i.FloatDivision(_var89.Subtract(((Integer)1))));
        }
         } 
        public IArray<Number> FractionsExclusive { [MethodImpl(AggressiveInlining)] get {
            var _var90 = this;
            return this.Range.Map((i) => i.FloatDivision(_var90));
        }
         } 
        public IArray<Number> LinearSpace { [MethodImpl(AggressiveInlining)] get  => this.Fractions; } 
        public IArray<Number> LinearSpaceExclusive { [MethodImpl(AggressiveInlining)] get  => this.FractionsExclusive; } 
        public IArray<Number> GeometricSpace { [MethodImpl(AggressiveInlining)] get  => this.LinearSpace.Map((x) => ((Number)1).Pow(x)); } 
        public IArray<Number> GeometricSpaceExclusive { [MethodImpl(AggressiveInlining)] get  => this.LinearSpaceExclusive.Map((x) => ((Number)1).Pow(x)); } 
        public IArray<NumberInterval> Intervals { [MethodImpl(AggressiveInlining)] get  => this.Add(((Integer)1)).LinearSpace.WithNext((a, b) => new NumberInterval(a, b)); } 
        [MethodImpl(AggressiveInlining)]  public Integer Add(Integer b) => this + b;
        [MethodImpl(AggressiveInlining)]  public Integer Subtract(Integer b) => this - b;
        [MethodImpl(AggressiveInlining)]  public Integer Multiply(Integer b) => this * b;
        [MethodImpl(AggressiveInlining)]  public Integer Divide(Integer b) => this / b;
        [MethodImpl(AggressiveInlining)]  public Integer Modulo(Integer b) => this % b;
        public Integer Negative { [MethodImpl(AggressiveInlining)] get => -this; }
        [MethodImpl(AggressiveInlining)]  public Boolean LessThan(Integer b) => this < b;
        [MethodImpl(AggressiveInlining)]  public Boolean LessThanOrEquals(Integer b) => this <= b;
        [MethodImpl(AggressiveInlining)]  public Boolean GreaterThan(Integer b) => this > b;
        [MethodImpl(AggressiveInlining)]  public Boolean GreaterThanOrEquals(Integer b) => this >= b;
        [MethodImpl(AggressiveInlining)]  public Integer Lesser(Integer b) => this.LessThanOrEquals(b) ? this : b;
        [MethodImpl(AggressiveInlining)]  public Integer Greater(Integer b) => this.GreaterThanOrEquals(b) ? this : b;

        // Unimplemented concept functions
    }
}
