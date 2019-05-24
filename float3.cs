namespace RodMath
{
	public struct float3
	{
		public float x, y, z;

		public float3(float x, float y, float z)
		{
			this.x = x;
			this.y = y;
			this.z = z;
		}

		public float3(float x)
		{
			this.x = x;
			this.y = x;
			this.z = x;
		}
	}

	public static partial class math
	{
		public static float3 float3(float x, float y, float z) => new float3(x, y, z);
		public static float3 float3(float x) => new float3(x);
	}
}