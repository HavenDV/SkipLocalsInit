#if !NET6_0_OR_GREATER

namespace System.Runtime.CompilerServices;

/// <summary>
/// Used to indicate to the compiler that the <c>.locals init</c> flag should not be set in method headers.
/// </summary>
/// <remarks>Internal copy of the .NET 5 attribute.</remarks>
[global::System.AttributeUsage(
    global::System.AttributeTargets.Module |
    global::System.AttributeTargets.Class |
    global::System.AttributeTargets.Struct |
    global::System.AttributeTargets.Interface |
    global::System.AttributeTargets.Constructor |
    global::System.AttributeTargets.Method |
    global::System.AttributeTargets.Property |
    global::System.AttributeTargets.Event,
    Inherited = false)]
internal sealed class SkipLocalsInitAttribute : global::System.Attribute
{
}

#endif