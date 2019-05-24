namespace RodMath
{
	public struct bool3
	{
		public bool x, y, z;

		public bool3(bool x, bool y, bool z)
		{
			this.x = x;
			this.y = y;
			this.z = z;
		}

		public bool3(bool x)
		{
			this.x = x;
			this.y = x;
			this.z = x;
		}
	}
}