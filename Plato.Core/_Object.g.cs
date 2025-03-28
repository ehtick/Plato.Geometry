// Autogenerated file: DO NOT EDIT
// Created on 2025-03-18 2:15:23 PM

using System.Runtime.CompilerServices;
using System.Runtime.Serialization;
using System.Runtime.InteropServices;
using static System.Runtime.CompilerServices.MethodImplOptions;

namespace Plato
{
    [DataContract, StructLayout(LayoutKind.Sequential, Pack=1)]
    public partial struct Object: IValue
    {
        // Fields

        // With functions 

        // Regular Constructor

        // Static factory function
        [MethodImpl(AggressiveInlining)] public static Object Create() => new Object();

        // Object virtual function overrides: Equals, GetHashCode, ToString
        [MethodImpl(AggressiveInlining)] public override bool Equals(object obj) => obj is Object;
        [MethodImpl(AggressiveInlining)] public Boolean Equals(Object other) => true;
        [MethodImpl(AggressiveInlining)] public Boolean NotEquals(Object other) => false;
        [MethodImpl(AggressiveInlining)] public static Boolean operator==(Object a, Object b) => true;
        [MethodImpl(AggressiveInlining)] public static Boolean operator!=(Object a, Object b) => false;
        [MethodImpl(AggressiveInlining)] public override int GetHashCode() => Intrinsics.CombineHashCodes();
        [MethodImpl(AggressiveInlining)] public override string ToString() => $"{{  }}";

        // Explicit implementation of interfaces by forwarding properties to fields

        // Implemented interface functions

        // Unimplemented concept functions
    }
}
