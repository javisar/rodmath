namespace RodMath
{
	public struct bool2
	{
		public bool x, y;

		public bool2(bool x, bool y)
		{
			this.x = x;
			this.y = y;
		}

		public bool2(bool x)
		{
			this.x = x;
			this.y = x;
		}
	}
}