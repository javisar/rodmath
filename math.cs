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

		static unsafe float  abs(float  a) { uint  b = (*(uint *) &a) & 0x7FFFFFFF; return *(float *) &b; }
		static unsafe float2 abs(float2 a) { uint2 b = (*(uint2*) &a) & 0x7FFFFFFF; return *(float2*) &b; }
		static unsafe float3 abs(float3 a) { uint3 b = (*(uint3*) &a) & 0x7FFFFFFF; return *(float3*) &b; }
		static unsafe float4 abs(float4 a) { uint4 b = (*(uint4*) &a) & 0x7FFFFFFF; return *(float4*) &b; }

		static int  abs(int  a) => (a + (a >> 31)) ^ (a >> 31);
		static int2 abs(int2 a) => (a + (a >> 31)) ^ (a >> 31);
		static int3 abs(int3 a) => (a + (a >> 31)) ^ (a >> 31);
		static int4 abs(int4 a) => (a + (a >> 31)) ^ (a >> 31);

	}
}