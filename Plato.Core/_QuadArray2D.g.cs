// Autogenerated file: DO NOT EDIT
// Created on 2025-04-03 1:53:19 AM

using System.Runtime.CompilerServices;
using System.Runtime.Serialization;
using System.Runtime.InteropServices;
using static System.Runtime.CompilerServices.MethodImplOptions;

namespace Plato
{
    [DataContract, StructLayout(LayoutKind.Sequential, Pack=1)]
    public partial struct QuadArray2D: IQuadArray2D
    {
        // Fields
        [DataMember] public readonly IArray<Quad2D> Quads;

        // With functions 
        [MethodImpl(AggressiveInlining)] public QuadArray2D WithQuads(IArray<Quad2D> quads) => new QuadArray2D(quads);

        // Regular Constructor
        [MethodImpl(AggressiveInlining)] public QuadArray2D(IArray<Quad2D> quads) { Quads = quads; }

        // Static factory function
        [MethodImpl(AggressiveInlining)] public static QuadArray2D Create(IArray<Quad2D> quads) => new QuadArray2D(quads);

        // Static default implementation
        public static readonly QuadArray2D Default = default;

        // Implicit converters to/from single field

        // Object virtual function overrides: Equals, GetHashCode, ToString
        [MethodImpl(AggressiveInlining)] public Boolean Equals(QuadArray2D other) => Quads.Equals(other.Quads);
        [MethodImpl(AggressiveInlining)] public Boolean NotEquals(QuadArray2D other) => !Quads.Equals(other.Quads);
        [MethodImpl(AggressiveInlining)] public override bool Equals(object obj) => obj is QuadArray2D other ? Equals(other) : false;
        [MethodImpl(AggressiveInlining)] public override int GetHashCode() => Intrinsics.CombineHashCodes(Quads);
        [MethodImpl(AggressiveInlining)] public override string ToString() => $"{{ \"Quads\" = {Quads} }}";

        // Explicit implementation of interfaces by forwarding properties to fields
        IArray<Quad2D> IQuadGeometry2D.Quads { [MethodImpl(AggressiveInlining)] get => Quads; }

        // Implemented interface functions
        public IArray<Integer> Indices { [MethodImpl(AggressiveInlining)] get  => this.Points.Indices(); } 
public IArray<Vector2> Points { [MethodImpl(AggressiveInlining)] get  => this.Quads.FlatMap((x)  => x.Points); } 
public IArray<Line2D> Lines { [MethodImpl(AggressiveInlining)] get  => this.Quads.FlatMap((x)  => x.Lines); } 
public IArray<Triangle2D> Triangles { [MethodImpl(AggressiveInlining)] get  => this.Quads.FlatMap((x)  => x.Triangles); } 
public IArray<Quad2D> Faces { [MethodImpl(AggressiveInlining)] get  => this.Quads; } 
[MethodImpl(AggressiveInlining)]  public Vector2 Vertex(Integer n) => this.Points.At(this.Indices.At(n));
[MethodImpl(AggressiveInlining)]  public IArray<Vector2> FaceVertices(Integer f){
            var _var177 = this;
            return this.FaceIndices.At(f).Components.Map((i)  => _var177.Vertex(i));
        }

public IArray2D<Vector2> AllFaceVertices { [MethodImpl(AggressiveInlining)] get {
            var _var178 = this;
            return this.AllFaceIndices.Map((x)  => _var178.Vertex(x));
        }
         } 
[MethodImpl(AggressiveInlining)]  public IArray<Vector2> Vertices(IArray<Integer> xs){
            var _var179 = this;
            return xs.Map((i)  => _var179.Vertex(i));
        }

public IArray<Vector2> AllVertices { [MethodImpl(AggressiveInlining)] get  => this.Vertices(this.Indices); } 
public Integer NumPrimitives { [MethodImpl(AggressiveInlining)] get  => this.Indices.Count.Divide(this.PrimitiveSize); } 
public Integer NumFaces { [MethodImpl(AggressiveInlining)] get  => this.NumPrimitives; } 
public IArray2D<Integer> AllFaceIndices { [MethodImpl(AggressiveInlining)] get  => this.Indices.Slices(this.PrimitiveSize); } 
public Integer PrimitiveSize { [MethodImpl(AggressiveInlining)] get  => ((Integer)4); } 
public IArray<Integer4> FaceIndices { [MethodImpl(AggressiveInlining)] get  => ArrayHelpers.Integer4Array(this.Indices); } 

        // Unimplemented interface functions
        public IArray<Vector2> Corners => throw new NotImplementedException();
}
}
