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

		static int  max(int  a, int  b) => (a + b + abs(a - b)) >> 1;
		static int2 max(int2 a, int2 b) => (a + b + abs(a - b)) >> 1;
		static int3 max(int3 a, int3 b) => (a + b + abs(a - b)) >> 1;
		static int4 max(int4 a, int4 b) => (a + b + abs(a - b)) >> 1;

		static uint  max(uint  a, uint  b) => a > b ? a : b;
		static uint2 max(uint2 a, uint2 b) => uint2(max(a.x,b.x),max(a.y,b.y));
		static uint3 max(uint3 a, uint3 b) => uint3(max(a.x,b.x),max(a.y,b.y),max(a.z,b.z));
		static uint4 max(uint4 a, uint4 b) => uint4(max(a.x,b.x),max(a.y,b.y),max(a.z,b.z),max(a.w,b.w));

		static float  max(float  a, float  b) => (a + b + abs(a - b)) * 0.5f;
		static float2 max(float2 a, float2 b) => (a + b + abs(a - b)) * 0.5f;
		static float3 max(float3 a, float3 b) => (a + b + abs(a - b)) * 0.5f;
		static float4 max(float4 a, float4 b) => (a + b + abs(a - b)) * 0.5f;

		static int  min(int  a, int  b) => (a + b - abs(a - b)) >> 1;
		static int2 min(int2 a, int2 b) => (a + b - abs(a - b)) >> 1;
		static int3 min(int3 a, int3 b) => (a + b - abs(a - b)) >> 1;
		static int4 min(int4 a, int4 b) => (a + b - abs(a - b)) >> 1;

		static uint  min(uint  a, uint  b) => a > b ? b : a;
		static uint2 min(uint2 a, uint2 b) => uint2(min(a.x,b.x),min(a.y,b.y));
		static uint3 min(uint3 a, uint3 b) => uint3(min(a.x,b.x),min(a.y,b.y),min(a.z,b.z));
		static uint4 min(uint4 a, uint4 b) => uint4(min(a.x,b.x),min(a.y,b.y),min(a.z,b.z),min(a.w,b.w));

		static float  min(float  a, float  b) => (a + b - abs(a - b)) * 0.5f;
		static float2 min(float2 a, float2 b) => (a + b - abs(a - b)) * 0.5f;
		static float3 min(float3 a, float3 b) => (a + b - abs(a - b)) * 0.5f;
		static float4 min(float4 a, float4 b) => (a + b - abs(a - b)) * 0.5f;

		public static int    clamp(int  v, int  a, int  b) => max(a, min(b, v));
		public static int2   clamp(int2 v, int2 a, int2 b) => max(a, min(b, v));
		public static int3   clamp(int3 v, int3 a, int3 b) => max(a, min(b, v));
		public static int4   clamp(int4 v, int4 a, int4 b) => max(a, min(b, v));

		public static uint   clamp(uint  v, uint  a, uint  b) => max(a, min(b, v));
		public static uint2  clamp(uint2 v, uint2 a, uint2 b) => max(a, min(b, v));
		public static uint3  clamp(uint3 v, uint3 a, uint3 b) => max(a, min(b, v));
		public static uint4  clamp(uint4 v, uint4 a, uint4 b) => max(a, min(b, v));

		public static float  clamp(float  v, float  a, float  b) => max(a, min(b, v));
		public static float2 clamp(float2 v, float2 a, float2 b) => max(a, min(b, v));
		public static float3 clamp(float3 v, float3 a, float3 b) => max(a, min(b, v));
		public static float4 clamp(float4 v, float4 a, float4 b) => max(a, min(b, v));

		public static float  saturate(float  a) => clamp(a, 0.0f, 1.0f);
		public static float2 saturate(float2 a) => clamp(a, float2(0.0f), float2(1.0f));
		public static float3 saturate(float3 a) => clamp(a, float3(0.0f), float3(1.0f));
		public static float4 saturate(float4 a) => clamp(a, float4(0.0f), float4(1.0f));

		static bool  isfinite(float  a) => abs(a) < float.PositiveInfinity;
		static bool2 isfinite(float2 a) => abs(a) < float.PositiveInfinity;
		static bool3 isfinite(float3 a) => abs(a) < float.PositiveInfinity;
		static bool4 isfinite(float4 a) => abs(a) < float.PositiveInfinity;

		static bool  isinf(float  a) => abs(a) == float.PositiveInfinity;
		static bool2 isinf(float2 a) => abs(a) == float.PositiveInfinity;
		static bool3 isinf(float3 a) => abs(a) == float.PositiveInfinity;
		static bool4 isinf(float4 a) => abs(a) == float.PositiveInfinity;

		static unsafe bool  isnan(float  a) => ((*(uint *) &a) & 0x7FFFFFFF) > 0x7F800000;
		static unsafe bool2 isnan(float2 a) => ((*(uint2*) &a) & 0x7FFFFFFF) > 0x7F800000;
		static unsafe bool3 isnan(float3 a) => ((*(uint3*) &a) & 0x7FFFFFFF) > 0x7F800000;
		static unsafe bool4 isnan(float4 a) => ((*(uint4*) &a) & 0x7FFFFFFF) > 0x7F800000;

		static float  floor(float  a) => (float) System.Math.Floor(a);
		static float2 floor(float2 a) => float2(floor(a.x), floor(a.y));
		static float3 floor(float3 a) => float3(floor(a.x), floor(a.y), floor(a.z));
		static float4 floor(float4 a) => float4(floor(a.x), floor(a.y), floor(a.z), floor(a.w));

		static float  ceil(float  a) => (float) System.Math.Ceiling(a);
		static float2 ceil(float2 a) => float2(ceil(a.x), ceil(a.y));
		static float3 ceil(float3 a) => float3(ceil(a.x), ceil(a.y), ceil(a.z));
		static float4 ceil(float4 a) => float4(ceil(a.x), ceil(a.y), ceil(a.z), ceil(a.w));

		static float  round(float  a) => (float) System.Math.Round(a);
		static float2 round(float2 a) => float2(round(a.x), round(a.y));
		static float3 round(float3 a) => float3(round(a.x), round(a.y), round(a.z));
		static float4 round(float4 a) => float4(round(a.x), round(a.y), round(a.z), round(a.w));
	}
}