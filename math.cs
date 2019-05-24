namespace RodMath
{
	// meant to be used with C# using static
	// like this:
	// using static RodMath.math;
	public static partial class math
	{
		const float pi   = 3.14159265f;
		const float π    = 3.14159265f;
		const float e    = 2.18281828f;
		const float sq_2 = 1.41421356f;
		const float rs_2 = 0.70710678f;
		const float ln_2 = 0.69314718f;

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

		static float  trunc(float  a) => (float) System.Math.Truncate(a);
		static float2 trunc(float2 a) => float2(trunc(a.x), trunc(a.y));
		static float3 trunc(float3 a) => float3(trunc(a.x), trunc(a.y), trunc(a.z));
		static float4 trunc(float4 a) => float4(trunc(a.x), trunc(a.y), trunc(a.z), trunc(a.w));

		static float  frac(float  a) => a - floor(a);
		static float2 frac(float2 a) => a - floor(a);
		static float3 frac(float3 a) => a - floor(a);
		static float4 frac(float4 a) => a - floor(a);

		static float3 cross(float3 a, float3 b) => float3(a.x*b.y - a.y*b.x, a.y*b.z - a.z*b.y, a.z*b.x - a.x*b.z);

		static int dot(int  a, int  b) => a * b;
		static int dot(int2 a, int2 b) => a.x*b.x + a.y*b.y;
		static int dot(int3 a, int3 b) => a.x*b.x + a.y*b.y + a.z*b.z;
		static int dot(int4 a, int4 b) => a.x*b.x + a.y*b.y + a.z*b.z + a.w*b.w;

		static uint dot(uint  a, uint  b) => a * b;
		static uint dot(uint2 a, uint2 b) => a.x*b.x + a.y*b.y;
		static uint dot(uint3 a, uint3 b) => a.x*b.x + a.y*b.y + a.z*b.z;
		static uint dot(uint4 a, uint4 b) => a.x*b.x + a.y*b.y + a.z*b.z + a.w*b.w;

		static float dot(float  a, float  b) => a * b;
		static float dot(float2 a, float2 b) => a.x*b.x + a.y*b.y;
		static float dot(float3 a, float3 b) => a.x*b.x + a.y*b.y + a.z*b.z;
		static float dot(float4 a, float4 b) => a.x*b.x + a.y*b.y + a.z*b.z + a.w*b.w;

		static float  reflect(float  a, float  b) => a - 2.0f * b * dot(a, b);
		static float2 reflect(float2 a, float2 b) => a - 2.0f * b * dot(a, b);
		static float3 reflect(float3 a, float3 b) => a - 2.0f * b * dot(a, b);
		static float4 reflect(float4 a, float4 b) => a - 2.0f * b * dot(a, b);

		static int  reflect(int  a, int  b) => a - 2 * b * dot(a, b);
		static int2 reflect(int2 a, int2 b) => a - 2 * b * dot(a, b);
		static int3 reflect(int3 a, int3 b) => a - 2 * b * dot(a, b);
		static int4 reflect(int4 a, int4 b) => a - 2 * b * dot(a, b);

		static float  exp (float  a) => (float) System.Math.Exp(a);
		static float2 exp (float2 a) => float2(exp(a.x), exp(a.y));
		static float3 exp (float3 a) => float3(exp(a.x), exp(a.y), exp(a.z));
		static float4 exp (float4 a) => float4(exp(a.x), exp(a.y), exp(a.z), exp(a.w));

		static float  exp2(float  a) => (float) System.Math.Exp(a * ln_2);
		static float2 exp2(float2 a) => float2(exp2(a.x), exp2(a.y));
		static float3 exp2(float3 a) => float3(exp2(a.x), exp2(a.y), exp2(a.z));
		static float4 exp2(float4 a) => float4(exp2(a.x), exp2(a.y), exp2(a.z), exp2(a.w));

		static float  log (float  a) => (float) System.Math.Log(a);
		static float2 log (float2 a) => float2(log(a.x), log(a.y));
		static float3 log (float3 a) => float3(log(a.x), log(a.y), log(a.z));
		static float4 log (float4 a) => float4(log(a.x), log(a.y), log(a.z), log(a.w));

		static float  log2(float  a) => (float) System.Math.Log(a, 2.0f);
		static float2 log2(float2 a) => float2(log2(a.x), log2(a.y));
		static float3 log2(float3 a) => float3(log2(a.x), log2(a.y), log2(a.z));
		static float4 log2(float4 a) => float4(log2(a.x), log2(a.y), log2(a.z), log2(a.w));

		static float  sqrt(float  a) => (float) System.Math.Sqrt(a);
		static float2 sqrt(float2 a) => float2(sqrt(a.x), sqrt(a.y));
		static float3 sqrt(float3 a) => float3(sqrt(a.x), sqrt(a.y), sqrt(a.z));
		static float4 sqrt(float4 a) => float4(sqrt(a.x), sqrt(a.y), sqrt(a.z), sqrt(a.w));

		static float  rsqrt(float  a) => 1.0f / (float) System.Math.Sqrt(a);
		static float2 rsqrt(float2 a) => float2(rsqrt(a.x), rsqrt(a.y));
		static float3 rsqrt(float3 a) => float3(rsqrt(a.x), rsqrt(a.y), rsqrt(a.z));
		static float4 rsqrt(float4 a) => float4(rsqrt(a.x), rsqrt(a.y), rsqrt(a.z), rsqrt(a.w));

		static float  rcp (float  a) => 1.0f / a;
		static float2 rcp (float2 a) => float2(rcp(a.x), rcp(a.y));
		static float3 rcp (float3 a) => float3(rcp(a.x), rcp(a.y), rcp(a.z));
		static float4 rcp (float4 a) => float4(rcp(a.x), rcp(a.y), rcp(a.z), rcp(a.w));

		static float  pow (float  a, float  b) => (float) System.Math.Pow(a, b);
		static float2 pow (float2 a, float2 b) => float2(pow(a.x, b.x), pow(a.y, b.y));
		static float3 pow (float3 a, float3 b) => float3(pow(a.x, b.x), pow(a.y, b.y), pow(a.z, b.z));
		static float4 pow (float4 a, float4 b) => float4(pow(a.x, b.x), pow(a.y, b.y), pow(a.z, b.z), pow(a.w, b.w));

		static float  sin (float  a) => (float) System.Math.Sin(a);
		static float2 sin (float2 a) => float2(sin(a.x), sin(a.y));
		static float3 sin (float3 a) => float3(sin(a.x), sin(a.y), sin(a.z));
		static float4 sin (float4 a) => float4(sin(a.x), sin(a.y), sin(a.z), sin(a.w));

		static float  sinh(float  a) => (float) System.Math.Sinh(a);
		static float2 sinh(float2 a) => float2(sinh(a.x), sinh(a.y));
		static float3 sinh(float3 a) => float3(sinh(a.x), sinh(a.y), sinh(a.z));
		static float4 sinh(float4 a) => float4(sinh(a.x), sinh(a.y), sinh(a.z), sinh(a.w));

		static float  asin(float  a) => (float) System.Math.Asin(a);
		static float2 asin(float2 a) => float2(asin(a.x), asin(a.y));
		static float3 asin(float3 a) => float3(asin(a.x), asin(a.y), asin(a.z));
		static float4 asin(float4 a) => float4(asin(a.x), asin(a.y), asin(a.z), asin(a.w));

		static float  cos (float  a) => (float) System.Math.Cos(a);
		static float2 cos (float2 a) => float2(cos(a.x), cos(a.y));
		static float3 cos (float3 a) => float3(cos(a.x), cos(a.y), cos(a.z));
		static float4 cos (float4 a) => float4(cos(a.x), cos(a.y), cos(a.z), cos(a.w));

		static float  cosh(float  a) => (float) System.Math.Cosh(a);
		static float2 cosh(float2 a) => float2(cosh(a.x), cosh(a.y));
		static float3 cosh(float3 a) => float3(cosh(a.x), cosh(a.y), cosh(a.z));
		static float4 cosh(float4 a) => float4(cosh(a.x), cosh(a.y), cosh(a.z), cosh(a.w));

		static float  acos(float  a) => (float) System.Math.Acos(a);
		static float2 acos(float2 a) => float2(acos(a.x), acos(a.y));
		static float3 acos(float3 a) => float3(acos(a.x), acos(a.y), acos(a.z));
		static float4 acos(float4 a) => float4(acos(a.x), acos(a.y), acos(a.z), acos(a.w));

		static float  tan (float  a) => (float) System.Math.Tan(a);
		static float2 tan (float2 a) => float2(tan(a.x), tan(a.y));
		static float3 tan (float3 a) => float3(tan(a.x), tan(a.y), tan(a.z));
		static float4 tan (float4 a) => float4(tan(a.x), tan(a.y), tan(a.z), tan(a.w));

		static float  tanh(float  a) => (float) System.Math.Tanh(a);
		static float2 tanh(float2 a) => float2(tanh(a.x), tanh(a.y));
		static float3 tanh(float3 a) => float3(tanh(a.x), tanh(a.y), tanh(a.z));
		static float4 tanh(float4 a) => float4(tanh(a.x), tanh(a.y), tanh(a.z), tanh(a.w));

		static float  atan(float  a) => (float) System.Math.Atan(a);
		static float2 atan(float2 a) => float2(atan(a.x), atan(a.y));
		static float3 atan(float3 a) => float3(atan(a.x), atan(a.y), atan(a.z));
		static float4 atan(float4 a) => float4(atan(a.x), atan(a.y), atan(a.z), atan(a.w));

		static float  atan2(float  a, float  b) => (float) System.Math.Atan2(a, b);
		static float2 atan2(float2 a, float2 b) => float2(atan2(a.x, b.x), atan2(a.y, b.y));
		static float3 atan2(float3 a, float3 b) => float3(atan2(a.x, b.x), atan2(a.y, b.y), atan2(a.z, b.z));
		static float4 atan2(float4 a, float4 b) => float4(atan2(a.x, b.x), atan2(a.y, b.y), atan2(a.z, b.z), atan2(a.w, b.w));

		static float  mad(float  a, float  b, float  c) => a*b + c;
		static float2 mad(float2 a, float2 b, float2 c) => float2(mad(a.x, b.x, c.x), mad(a.y, b.y, c.y));
		static float3 mad(float3 a, float3 b, float3 c) => float3(mad(a.x, b.x, c.x), mad(a.y, b.y, c.y), mad(a.z, b.z, c.z));
		static float4 mad(float4 a, float4 b, float4 c) => float4(mad(a.x, b.x, c.x), mad(a.y, b.y, c.y), mad(a.z, b.z, c.z), mad(a.w, b.w, c.w));

		static float  lerp(float  a, float  b, float  c) => a + c * (b - a);
		static float2 lerp(float2 a, float2 b, float2 c) => float2(lerp(a.x, b.x, c.x), lerp(a.y, b.y, c.y));
		static float3 lerp(float3 a, float3 b, float3 c) => float3(lerp(a.x, b.x, c.x), lerp(a.y, b.y, c.y), lerp(a.z, b.z, c.z));
		static float4 lerp(float4 a, float4 b, float4 c) => float4(lerp(a.x, b.x, c.x), lerp(a.y, b.y, c.y), lerp(a.z, b.z, c.z), lerp(a.w, b.w, c.w));

		static float  sign(float  a) => a > 0.0f ? 1.0f : a < 0.0f ? -1.0f : 0.0f;
		static float2 sign(float2 a) => float2(sign(a.x), sign(a.y));
		static float3 sign(float3 a) => float3(sign(a.x), sign(a.y), sign(a.z));
		static float4 sign(float4 a) => float4(sign(a.x), sign(a.y), sign(a.z), sign(a.w));

		static float  step(float  a, float  b) => a >= b ? 1.0f : 0.0f;
		static float2 step(float2 a, float2 b) => float2(step(a.x, b.x), step(a.y, b.y));
		static float3 step(float3 a, float3 b) => float3(step(a.x, b.x), step(a.y, b.y), step(a.z, b.z));
		static float4 step(float4 a, float4 b) => float4(step(a.x, b.x), step(a.y, b.y), step(a.z, b.z), step(a.w, b.w));
	}
}