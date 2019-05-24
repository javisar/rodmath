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
}