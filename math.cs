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

		public static bool all(bool  a) => a;
		public static bool all(bool2 a) => a.x & a.y;
		public static bool all(bool3 a) => a.x & a.y & a.z;
		public static bool all(bool4 a) => a.x & a.y & a.z & a.w;

		public static bool any(bool  a) => a;
		public static bool any(bool2 a) => a.x | a.y;
		public static bool any(bool3 a) => a.x | a.y | a.z;
		public static bool any(bool4 a) => a.x | a.y | a.z | a.w;

		public static unsafe float  abs(float  a) { uint  b = (*(uint *) &a) & 0x7FFFFFFF; return *(float *) &b; }
		public static unsafe float2 abs(float2 a) { uint2 b = (*(uint2*) &a) & 0x7FFFFFFF; return *(float2*) &b; }
		public static unsafe float3 abs(float3 a) { uint3 b = (*(uint3*) &a) & 0x7FFFFFFF; return *(float3*) &b; }
		public static unsafe float4 abs(float4 a) { uint4 b = (*(uint4*) &a) & 0x7FFFFFFF; return *(float4*) &b; }

		public static int  abs(int  a) => (a + (a >> 31)) ^ (a >> 31);
		public static int2 abs(int2 a) => (a + (a >> 31)) ^ (a >> 31);
		public static int3 abs(int3 a) => (a + (a >> 31)) ^ (a >> 31);
		public static int4 abs(int4 a) => (a + (a >> 31)) ^ (a >> 31);

		public static int  max(int  a, int  b) => (a + b + abs(a - b)) >> 1;
		public static int2 max(int2 a, int2 b) => (a + b + abs(a - b)) >> 1;
		public static int3 max(int3 a, int3 b) => (a + b + abs(a - b)) >> 1;
		public static int4 max(int4 a, int4 b) => (a + b + abs(a - b)) >> 1;

		public static uint  max(uint  a, uint  b) => a > b ? a : b;
		public static uint2 max(uint2 a, uint2 b) => uint2(max(a.x,b.x),max(a.y,b.y));
		public static uint3 max(uint3 a, uint3 b) => uint3(max(a.x,b.x),max(a.y,b.y),max(a.z,b.z));
		public static uint4 max(uint4 a, uint4 b) => uint4(max(a.x,b.x),max(a.y,b.y),max(a.z,b.z),max(a.w,b.w));

		public static float  max(float  a, float  b) => (a + b + abs(a - b)) * 0.5f;
		public static float2 max(float2 a, float2 b) => (a + b + abs(a - b)) * 0.5f;
		public static float3 max(float3 a, float3 b) => (a + b + abs(a - b)) * 0.5f;
		public static float4 max(float4 a, float4 b) => (a + b + abs(a - b)) * 0.5f;

		public static int  min(int  a, int  b) => (a + b - abs(a - b)) >> 1;
		public static int2 min(int2 a, int2 b) => (a + b - abs(a - b)) >> 1;
		public static int3 min(int3 a, int3 b) => (a + b - abs(a - b)) >> 1;
		public static int4 min(int4 a, int4 b) => (a + b - abs(a - b)) >> 1;

		public static uint  min(uint  a, uint  b) => a > b ? b : a;
		public static uint2 min(uint2 a, uint2 b) => uint2(min(a.x,b.x),min(a.y,b.y));
		public static uint3 min(uint3 a, uint3 b) => uint3(min(a.x,b.x),min(a.y,b.y),min(a.z,b.z));
		public static uint4 min(uint4 a, uint4 b) => uint4(min(a.x,b.x),min(a.y,b.y),min(a.z,b.z),min(a.w,b.w));

		public static float  min(float  a, float  b) => (a + b - abs(a - b)) * 0.5f;
		public static float2 min(float2 a, float2 b) => (a + b - abs(a - b)) * 0.5f;
		public static float3 min(float3 a, float3 b) => (a + b - abs(a - b)) * 0.5f;
		public static float4 min(float4 a, float4 b) => (a + b - abs(a - b)) * 0.5f;

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

		public static bool  isfinite(float  a) => abs(a) < float.PositiveInfinity;
		public static bool2 isfinite(float2 a) => abs(a) < float.PositiveInfinity;
		public static bool3 isfinite(float3 a) => abs(a) < float.PositiveInfinity;
		public static bool4 isfinite(float4 a) => abs(a) < float.PositiveInfinity;

		public static bool  isinf(float  a) => abs(a) == float.PositiveInfinity;
		public static bool2 isinf(float2 a) => abs(a) == float.PositiveInfinity;
		public static bool3 isinf(float3 a) => abs(a) == float.PositiveInfinity;
		public static bool4 isinf(float4 a) => abs(a) == float.PositiveInfinity;

		public static unsafe bool  isnan(float  a) => ((*(uint *) &a) & 0x7FFFFFFF) > 0x7F800000;
		public static unsafe bool2 isnan(float2 a) => ((*(uint2*) &a) & 0x7FFFFFFF) > 0x7F800000;
		public static unsafe bool3 isnan(float3 a) => ((*(uint3*) &a) & 0x7FFFFFFF) > 0x7F800000;
		public static unsafe bool4 isnan(float4 a) => ((*(uint4*) &a) & 0x7FFFFFFF) > 0x7F800000;

		public static float  floor(float  a) => (float) System.Math.Floor(a);
		public static float2 floor(float2 a) => float2(floor(a.x), floor(a.y));
		public static float3 floor(float3 a) => float3(floor(a.x), floor(a.y), floor(a.z));
		public static float4 floor(float4 a) => float4(floor(a.x), floor(a.y), floor(a.z), floor(a.w));

		public static float  ceil(float  a) => (float) System.Math.Ceiling(a);
		public static float2 ceil(float2 a) => float2(ceil(a.x), ceil(a.y));
		public static float3 ceil(float3 a) => float3(ceil(a.x), ceil(a.y), ceil(a.z));
		public static float4 ceil(float4 a) => float4(ceil(a.x), ceil(a.y), ceil(a.z), ceil(a.w));

		public static float  round(float  a) => (float) System.Math.Round(a);
		public static float2 round(float2 a) => float2(round(a.x), round(a.y));
		public static float3 round(float3 a) => float3(round(a.x), round(a.y), round(a.z));
		public static float4 round(float4 a) => float4(round(a.x), round(a.y), round(a.z), round(a.w));

		public static float  trunc(float  a) => (float) System.Math.Truncate(a);
		public static float2 trunc(float2 a) => float2(trunc(a.x), trunc(a.y));
		public static float3 trunc(float3 a) => float3(trunc(a.x), trunc(a.y), trunc(a.z));
		public static float4 trunc(float4 a) => float4(trunc(a.x), trunc(a.y), trunc(a.z), trunc(a.w));

		public static float  frac(float  a) => a - floor(a);
		public static float2 frac(float2 a) => a - floor(a);
		public static float3 frac(float3 a) => a - floor(a);
		public static float4 frac(float4 a) => a - floor(a);

		public static float3 cross(float3 a, float3 b) => float3(a.x*b.y - a.y*b.x, a.y*b.z - a.z*b.y, a.z*b.x - a.x*b.z);

		public static int dot(int  a, int  b) => a * b;
		public static int dot(int2 a, int2 b) => a.x*b.x + a.y*b.y;
		public static int dot(int3 a, int3 b) => a.x*b.x + a.y*b.y + a.z*b.z;
		public static int dot(int4 a, int4 b) => a.x*b.x + a.y*b.y + a.z*b.z + a.w*b.w;

		public static uint dot(uint  a, uint  b) => a * b;
		public static uint dot(uint2 a, uint2 b) => a.x*b.x + a.y*b.y;
		public static uint dot(uint3 a, uint3 b) => a.x*b.x + a.y*b.y + a.z*b.z;
		public static uint dot(uint4 a, uint4 b) => a.x*b.x + a.y*b.y + a.z*b.z + a.w*b.w;

		public static float dot(float  a, float  b) => a * b;
		public static float dot(float2 a, float2 b) => a.x*b.x + a.y*b.y;
		public static float dot(float3 a, float3 b) => a.x*b.x + a.y*b.y + a.z*b.z;
		public static float dot(float4 a, float4 b) => a.x*b.x + a.y*b.y + a.z*b.z + a.w*b.w;

		public static float  reflect(float  a, float  b) => a - 2.0f * b * dot(a, b);
		public static float2 reflect(float2 a, float2 b) => a - 2.0f * b * dot(a, b);
		public static float3 reflect(float3 a, float3 b) => a - 2.0f * b * dot(a, b);
		public static float4 reflect(float4 a, float4 b) => a - 2.0f * b * dot(a, b);

		public static int  reflect(int  a, int  b) => a - 2 * b * dot(a, b);
		public static int2 reflect(int2 a, int2 b) => a - 2 * b * dot(a, b);
		public static int3 reflect(int3 a, int3 b) => a - 2 * b * dot(a, b);
		public static int4 reflect(int4 a, int4 b) => a - 2 * b * dot(a, b);

		public static float  exp (float  a) => (float) System.Math.Exp(a);
		public static float2 exp (float2 a) => float2(exp(a.x), exp(a.y));
		public static float3 exp (float3 a) => float3(exp(a.x), exp(a.y), exp(a.z));
		public static float4 exp (float4 a) => float4(exp(a.x), exp(a.y), exp(a.z), exp(a.w));

		public static float  exp2(float  a) => (float) System.Math.Exp(a * ln_2);
		public static float2 exp2(float2 a) => float2(exp2(a.x), exp2(a.y));
		public static float3 exp2(float3 a) => float3(exp2(a.x), exp2(a.y), exp2(a.z));
		public static float4 exp2(float4 a) => float4(exp2(a.x), exp2(a.y), exp2(a.z), exp2(a.w));

		public static float  log (float  a) => (float) System.Math.Log(a);
		public static float2 log (float2 a) => float2(log(a.x), log(a.y));
		public static float3 log (float3 a) => float3(log(a.x), log(a.y), log(a.z));
		public static float4 log (float4 a) => float4(log(a.x), log(a.y), log(a.z), log(a.w));

		public static float  log2(float  a) => (float) System.Math.Log(a, 2.0f);
		public static float2 log2(float2 a) => float2(log2(a.x), log2(a.y));
		public static float3 log2(float3 a) => float3(log2(a.x), log2(a.y), log2(a.z));
		public static float4 log2(float4 a) => float4(log2(a.x), log2(a.y), log2(a.z), log2(a.w));

		public static float  sqrt(float  a) => (float) System.Math.Sqrt(a);
		public static float2 sqrt(float2 a) => float2(sqrt(a.x), sqrt(a.y));
		public static float3 sqrt(float3 a) => float3(sqrt(a.x), sqrt(a.y), sqrt(a.z));
		public static float4 sqrt(float4 a) => float4(sqrt(a.x), sqrt(a.y), sqrt(a.z), sqrt(a.w));

		public static float  rsqrt(float  a) => 1.0f / (float) System.Math.Sqrt(a);
		public static float2 rsqrt(float2 a) => float2(rsqrt(a.x), rsqrt(a.y));
		public static float3 rsqrt(float3 a) => float3(rsqrt(a.x), rsqrt(a.y), rsqrt(a.z));
		public static float4 rsqrt(float4 a) => float4(rsqrt(a.x), rsqrt(a.y), rsqrt(a.z), rsqrt(a.w));

		public static float  rcp (float  a) => 1.0f / a;
		public static float2 rcp (float2 a) => float2(rcp(a.x), rcp(a.y));
		public static float3 rcp (float3 a) => float3(rcp(a.x), rcp(a.y), rcp(a.z));
		public static float4 rcp (float4 a) => float4(rcp(a.x), rcp(a.y), rcp(a.z), rcp(a.w));

		public static float  pow (float  a, float  b) => (float) System.Math.Pow(a, b);
		public static float2 pow (float2 a, float2 b) => float2(pow(a.x, b.x), pow(a.y, b.y));
		public static float3 pow (float3 a, float3 b) => float3(pow(a.x, b.x), pow(a.y, b.y), pow(a.z, b.z));
		public static float4 pow (float4 a, float4 b) => float4(pow(a.x, b.x), pow(a.y, b.y), pow(a.z, b.z), pow(a.w, b.w));

		public static float  sin (float  a) => (float) System.Math.Sin(a);
		public static float2 sin (float2 a) => float2(sin(a.x), sin(a.y));
		public static float3 sin (float3 a) => float3(sin(a.x), sin(a.y), sin(a.z));
		public static float4 sin (float4 a) => float4(sin(a.x), sin(a.y), sin(a.z), sin(a.w));

		public static float  sinh(float  a) => (float) System.Math.Sinh(a);
		public static float2 sinh(float2 a) => float2(sinh(a.x), sinh(a.y));
		public static float3 sinh(float3 a) => float3(sinh(a.x), sinh(a.y), sinh(a.z));
		public static float4 sinh(float4 a) => float4(sinh(a.x), sinh(a.y), sinh(a.z), sinh(a.w));

		public static float  asin(float  a) => (float) System.Math.Asin(a);
		public static float2 asin(float2 a) => float2(asin(a.x), asin(a.y));
		public static float3 asin(float3 a) => float3(asin(a.x), asin(a.y), asin(a.z));
		public static float4 asin(float4 a) => float4(asin(a.x), asin(a.y), asin(a.z), asin(a.w));

		public static float  cos (float  a) => (float) System.Math.Cos(a);
		public static float2 cos (float2 a) => float2(cos(a.x), cos(a.y));
		public static float3 cos (float3 a) => float3(cos(a.x), cos(a.y), cos(a.z));
		public static float4 cos (float4 a) => float4(cos(a.x), cos(a.y), cos(a.z), cos(a.w));

		public static float  cosh(float  a) => (float) System.Math.Cosh(a);
		public static float2 cosh(float2 a) => float2(cosh(a.x), cosh(a.y));
		public static float3 cosh(float3 a) => float3(cosh(a.x), cosh(a.y), cosh(a.z));
		public static float4 cosh(float4 a) => float4(cosh(a.x), cosh(a.y), cosh(a.z), cosh(a.w));

		public static float  acos(float  a) => (float) System.Math.Acos(a);
		public static float2 acos(float2 a) => float2(acos(a.x), acos(a.y));
		public static float3 acos(float3 a) => float3(acos(a.x), acos(a.y), acos(a.z));
		public static float4 acos(float4 a) => float4(acos(a.x), acos(a.y), acos(a.z), acos(a.w));

		public static float  tan (float  a) => (float) System.Math.Tan(a);
		public static float2 tan (float2 a) => float2(tan(a.x), tan(a.y));
		public static float3 tan (float3 a) => float3(tan(a.x), tan(a.y), tan(a.z));
		public static float4 tan (float4 a) => float4(tan(a.x), tan(a.y), tan(a.z), tan(a.w));

		public static float  tanh(float  a) => (float) System.Math.Tanh(a);
		public static float2 tanh(float2 a) => float2(tanh(a.x), tanh(a.y));
		public static float3 tanh(float3 a) => float3(tanh(a.x), tanh(a.y), tanh(a.z));
		public static float4 tanh(float4 a) => float4(tanh(a.x), tanh(a.y), tanh(a.z), tanh(a.w));

		public static float  atan(float  a) => (float) System.Math.Atan(a);
		public static float2 atan(float2 a) => float2(atan(a.x), atan(a.y));
		public static float3 atan(float3 a) => float3(atan(a.x), atan(a.y), atan(a.z));
		public static float4 atan(float4 a) => float4(atan(a.x), atan(a.y), atan(a.z), atan(a.w));

		public static float  atan2(float  a, float  b) => (float) System.Math.Atan2(a, b);
		public static float2 atan2(float2 a, float2 b) => float2(atan2(a.x, b.x), atan2(a.y, b.y));
		public static float3 atan2(float3 a, float3 b) => float3(atan2(a.x, b.x), atan2(a.y, b.y), atan2(a.z, b.z));
		public static float4 atan2(float4 a, float4 b) => float4(atan2(a.x, b.x), atan2(a.y, b.y), atan2(a.z, b.z), atan2(a.w, b.w));

		public static float  mad(float  a, float  b, float  c) => a*b + c;
		public static float2 mad(float2 a, float2 b, float2 c) => a*b + c;
		public static float3 mad(float3 a, float3 b, float3 c) => a*b + c;
		public static float4 mad(float4 a, float4 b, float4 c) => a*b + c;

		public static int  mad(int  a, int  b, int  c) => a*b + c;
		public static int2 mad(int2 a, int2 b, int2 c) => a*b + c;
		public static int3 mad(int3 a, int3 b, int3 c) => a*b + c;
		public static int4 mad(int4 a, int4 b, int4 c) => a*b + c;

		public static uint  mad(uint  a, uint  b, uint  c) => a*b + c;
		public static uint2 mad(uint2 a, uint2 b, uint2 c) => a*b + c;
		public static uint3 mad(uint3 a, uint3 b, uint3 c) => a*b + c;
		public static uint4 mad(uint4 a, uint4 b, uint4 c) => a*b + c;

		public static float  lerp(float  a, float  b, float  c) => a + c * (b - a);
		public static float2 lerp(float2 a, float2 b, float2 c) => a + c * (b - a);
		public static float3 lerp(float3 a, float3 b, float3 c) => a + c * (b - a);
		public static float4 lerp(float4 a, float4 b, float4 c) => a + c * (b - a);

		public static int  lerp(int  a, int  b, int  c) => a + c * (b - a);
		public static int2 lerp(int2 a, int2 b, int2 c) => a + c * (b - a);
		public static int3 lerp(int3 a, int3 b, int3 c) => a + c * (b - a);
		public static int4 lerp(int4 a, int4 b, int4 c) => a + c * (b - a);

		public static uint  lerp(uint  a, uint  b, uint  c) => a + c * (b - a);
		public static uint2 lerp(uint2 a, uint2 b, uint2 c) => a + c * (b - a);
		public static uint3 lerp(uint3 a, uint3 b, uint3 c) => a + c * (b - a);
		public static uint4 lerp(uint4 a, uint4 b, uint4 c) => a + c * (b - a);

		public static float  sign(float  a) => a > 0.0f ? 1.0f : a < 0.0f ? -1.0f : 0.0f;
		public static float2 sign(float2 a) => float2(sign(a.x), sign(a.y));
		public static float3 sign(float3 a) => float3(sign(a.x), sign(a.y), sign(a.z));
		public static float4 sign(float4 a) => float4(sign(a.x), sign(a.y), sign(a.z), sign(a.w));

		public static int  sign(int  a) => a > 0 ? 1 : a < 0 ? -1 : 0;
		public static int2 sign(int2 a) => int2(sign(a.x), sign(a.y));
		public static int3 sign(int3 a) => int3(sign(a.x), sign(a.y), sign(a.z));
		public static int4 sign(int4 a) => int4(sign(a.x), sign(a.y), sign(a.z), sign(a.w));

		public static float  step(float  a, float  b) => a >= b ? 1.0f : 0.0f;
		public static float2 step(float2 a, float2 b) => float2(step(a.x, b.x), step(a.y, b.y));
		public static float3 step(float3 a, float3 b) => float3(step(a.x, b.x), step(a.y, b.y), step(a.z, b.z));
		public static float4 step(float4 a, float4 b) => float4(step(a.x, b.x), step(a.y, b.y), step(a.z, b.z), step(a.w, b.w));

		public static int  step(int  a, int  b) => a >= b ? 1 : 0;
		public static int2 step(int2 a, int2 b) => int2(step(a.x, b.x), step(a.y, b.y));
		public static int3 step(int3 a, int3 b) => int3(step(a.x, b.x), step(a.y, b.y), step(a.z, b.z));
		public static int4 step(int4 a, int4 b) => int4(step(a.x, b.x), step(a.y, b.y), step(a.z, b.z), step(a.w, b.w));

		public static uint  step(uint  a, uint  b) => a >= b ? 1u : 0u;
		public static uint2 step(uint2 a, uint2 b) => uint2(step(a.x, b.x), step(a.y, b.y));
		public static uint3 step(uint3 a, uint3 b) => uint3(step(a.x, b.x), step(a.y, b.y), step(a.z, b.z));
		public static uint4 step(uint4 a, uint4 b) => uint4(step(a.x, b.x), step(a.y, b.y), step(a.z, b.z), step(a.w, b.w));

		public static float  normalize(float  a) => sign(a);
		public static float2 normalize(float2 a) => a * rsqrt(dot(a, a));
		public static float3 normalize(float3 a) => a * rsqrt(dot(a, a));
		public static float4 normalize(float4 a) => a * rsqrt(dot(a, a));

		public static float length(float  a) => abs(a);
		public static float length(float2 a) => sqrt(dot(a, a));
		public static float length(float3 a) => sqrt(dot(a, a));
		public static float length(float4 a) => sqrt(dot(a, a));

		public static float distance(float  a, float  b) => length(a - b);
		public static float distance(float2 a, float2 b) => length(a - b);
		public static float distance(float3 a, float3 b) => length(a - b);
		public static float distance(float4 a, float4 b) => length(a - b);
	}
}