using System;
using System.Collections.Generic;
using System.Text;

namespace TipsConsole
{
	public static class PointSource
	{
		public static List<RayPoint> GetShapePoints()
		{
			var shape = new List<RayPoint>();
			var point = new RayPoint { X = 2, Y = 5, Z = 100 };
			shape.Add(point);
			point = new RayPoint { X = 4, Y = 15, Z = 200 };
			shape.Add(point);
			point = new RayPoint { X = 6, Y = 25, Z = 300 };
			shape.Add(point);
			return shape;
		}

		public static List<ImmutableRayPoint> GetImmutableShapePoints()
		{
			var shape = new List<ImmutableRayPoint>();
			var point = new ImmutableRayPoint(x: 2, y: 5, z: 100);
			shape.Add(point);
			point = new ImmutableRayPoint(x: 4, y: 15, z: 200);
			shape.Add(point);
			point = new ImmutableRayPoint(x: 6, y: 25, z: 300);
			shape.Add(point);
			return shape;
		}
	}
}
