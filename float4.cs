namespace RodMath
{
	public struct float4
	{
		public float x, y, z, w;

		public float4(float x, float y, float z, float w)
		{
			this.x = x;
			this.y = y;
			this.z = z;
			this.w = w;
		}

		public float4(float x)
		{
			this.x = x;
			this.y = x;
			this.z = x;
			this.w = x;
		}
	}

	public static partial class math
	{
		public static float4 float4(float x, float y, float z, float w) => new float4(x, y, z, w);
		public static float4 float4(float x) => new float4(x);
	}
}