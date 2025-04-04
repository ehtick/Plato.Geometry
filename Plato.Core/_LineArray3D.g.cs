// Autogenerated file: DO NOT EDIT
// Created on 2025-04-03 1:53:19 AM

using System.Runtime.CompilerServices;
using System.Runtime.Serialization;
using System.Runtime.InteropServices;
using static System.Runtime.CompilerServices.MethodImplOptions;

namespace Plato
{
    [DataContract, StructLayout(LayoutKind.Sequential, Pack=1)]
    public partial struct LineArray3D: ILineArray3D
    {
        // Fields
        [DataMember] public readonly IArray<Line3D> Lines;

        // With functions 
        [MethodImpl(AggressiveInlining)] public LineArray3D WithLines(IArray<Line3D> lines) => new LineArray3D(lines);

        // Regular Constructor
        [MethodImpl(AggressiveInlining)] public LineArray3D(IArray<Line3D> lines) { Lines = lines; }

        // Static factory function
        [MethodImpl(AggressiveInlining)] public static LineArray3D Create(IArray<Line3D> lines) => new LineArray3D(lines);

        // Static default implementation
        public static readonly LineArray3D Default = default;

        // Implicit converters to/from single field

        // Object virtual function overrides: Equals, GetHashCode, ToString
        [MethodImpl(AggressiveInlining)] public Boolean Equals(LineArray3D other) => Lines.Equals(other.Lines);
        [MethodImpl(AggressiveInlining)] public Boolean NotEquals(LineArray3D other) => !Lines.Equals(other.Lines);
        [MethodImpl(AggressiveInlining)] public override bool Equals(object obj) => obj is LineArray3D other ? Equals(other) : false;
        [MethodImpl(AggressiveInlining)] public override int GetHashCode() => Intrinsics.CombineHashCodes(Lines);
        [MethodImpl(AggressiveInlining)] public override string ToString() => $"{{ \"Lines\" = {Lines} }}";

        // Explicit implementation of interfaces by forwarding properties to fields
        IArray<Line3D> ILineGeometry3D.Lines { [MethodImpl(AggressiveInlining)] get => Lines; }

        // Implemented interface functions
        [MethodImpl(AggressiveInlining)]  public LineArray3D Deform(System.Func<Vector3, Vector3> f){
            var _var166 = f;
            return new LineArray3D(this.Lines.Map((l)  => l.Deform(_var166)));
        }

public IArray<Integer> Indices { [MethodImpl(AggressiveInlining)] get  => this.Points.Indices(); } 
public IArray<Vector3> Points { [MethodImpl(AggressiveInlining)] get  => this.Lines.FlatMap((x)  => x.Points); } 
[MethodImpl(AggressiveInlining)]  public Vector3 Vertex(Integer n) => this.Points.At(this.Indices.At(n));
[MethodImpl(AggressiveInlining)]  public IArray<Vector3> FaceVertices(Integer f){
            var _var167 = this;
            return this.FaceIndices.At(f).Components.Map((i)  => _var167.Vertex(i));
        }

public IArray2D<Vector3> AllFaceVertices { [MethodImpl(AggressiveInlining)] get {
            var _var168 = this;
            return this.AllFaceIndices.Map((x)  => _var168.Vertex(x));
        }
         } 
[MethodImpl(AggressiveInlining)]  public IArray<Vector3> Vertices(IArray<Integer> xs){
            var _var169 = this;
            return xs.Map((i)  => _var169.Vertex(i));
        }

public IArray<Vector3> AllVertices { [MethodImpl(AggressiveInlining)] get  => this.Vertices(this.Indices); } 
public Integer NumPrimitives { [MethodImpl(AggressiveInlining)] get  => this.Indices.Count.Divide(this.PrimitiveSize); } 
public Integer NumFaces { [MethodImpl(AggressiveInlining)] get  => this.NumPrimitives; } 
public IArray2D<Integer> AllFaceIndices { [MethodImpl(AggressiveInlining)] get  => this.Indices.Slices(this.PrimitiveSize); } 
public Integer PrimitiveSize { [MethodImpl(AggressiveInlining)] get  => ((Integer)2); } 
public IArray<Integer2> FaceIndices { [MethodImpl(AggressiveInlining)] get  => ArrayHelpers.Integer2Array(this.Indices); } 

        // Unimplemented interface functions
        public IArray<Vector3> Corners => throw new NotImplementedException();
}
}
