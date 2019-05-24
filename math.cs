namespace RodMath
{
	// meant to be used with C# using static
	// like this:
	// using static RodMath.math;
	public static partial class math
	{
		static bool all(bool  a) => a;
		static bool all(bool2 a) => a.x & a.y;
		static bool all(bool3 a) => a.x & a.y & a.z;
		static bool all(bool4 a) => a.x & a.y & a.z & a.w;

		static bool any(bool  a) => a;
		static bool any(bool2 a) => a.x | a.y;
		static bool any(bool3 a) => a.x | a.y | a.z;
		static bool any(bool4 a) => a.x | a.y | a.z | a.w;
	}
}