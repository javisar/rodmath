namespace RodMath
{
	public struct float2
	{
		public float x, y;

		public float2(float x, float y)
		{
			this.x = x;
			this.y = y;
		}

		public float2(float x)
		{
			this.x = x;
			this.y = x;
		}
	}

	public static partial class math
	{
		public static float2 float2(float x, float y) => new float2(x, y);
		public static float2 float2(float x) => new float2(x);
	}
}