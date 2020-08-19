using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Text;

namespace TipsConsole
{
	public static class PointSource
	{

		public static List<ImmutableRayPoint> GetShape	()
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

		public static ImmutableList<ImmutableRayPoint> GetShapeBetter()
		{
			ImmutableList<ImmutableRayPoint> shape ;
			shape = ImmutableList.Create( new ImmutableRayPoint(x: 2, y: 5, z: 100)); // one point
			shape = shape.Add( new ImmutableRayPoint(x: 4, y: 15, z: 200)); // two points
			shape = shape.Add (new ImmutableRayPoint(x: 6, y: 25, z: 300)); // three points
		
			return shape;
		}
	}
}
