using System;
using System.Collections.Generic;
using System.Text;

namespace TipsConsole
{
	public class ImmutableRayPoint
	{
		// change to read-only properties
		public int X { get; }
		public int Y { get; }
		public int Z { get; }

		// parameterized constructor
		public ImmutableRayPoint(int x, int y, int z)
		{
			X = x;
			Y = y;
			Z = z;
		}
		public ImmutableRayPoint Update(int updatedX, int updatedY, int updatedZ)
		{
			return new ImmutableRayPoint(updatedX, updatedY, updatedZ);
		}
	}
}
