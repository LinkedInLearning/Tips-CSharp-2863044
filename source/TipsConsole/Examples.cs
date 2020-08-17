using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;

namespace TipsConsole
{
	internal class Examples
	{
		public void ShowExample()
		{


			//MutableListExample();
			ImmutableListExample();
		}


		public void MutableListExample()
		{
			Console.WriteLine("List<T>");
			var immutableShapePoints = PointSource.GetImmutableShapePoints();
			PrintShape(immutableShapePoints);
			Console.WriteLine();
			ExpandShapePoints(immutableShapePoints);
			MoveImmutableShape(delta: 10, shapePoints: immutableShapePoints);
			PrintShape(immutableShapePoints);
		}

		public void ImmutableListExample()
		{
			Console.WriteLine("ImmutableList<T>");
			var immutableShapePoints = PointSource.GetImmutableShapePointsAndCollection();
			PrintShape(immutableShapePoints);
			Console.WriteLine();
			immutableShapePoints = ExpandShapeWithImmutable(immutableShapePoints);
			//MoveImmutableShape(delta: 10, shapePoints: immutableShapePoints);
			PrintShape(immutableShapePoints);
		}

		public void ExpandShapePoints(List<ImmutableRayPoint> shapePoints) {
			// ImmutableRayPoint is immutable
			// but the List<T> is not.
			// Therefore it is not thread safe.  Another thread could alter collection

			shapePoints.Add(new ImmutableRayPoint(1000, 2000, 3000)); // add point to list
			shapePoints.Add(new ImmutableRayPoint(-17, -27, -37)); // add point to list
			
		}
		public void ReduceShapePoints(List<ImmutableRayPoint> shapePoints)
		{
			// List<T> is not thread safe.  Another thread could alter collection
			shapePoints.RemoveAt(0); // remove point
		}

			public ImmutableList<ImmutableRayPoint> ExpandShapeWithImmutable(ImmutableList<ImmutableRayPoint> shapePoints)
		{
			// ImmutableList changes result in a new ImmutableList instance

			// shapePoints = shapePoints.Add(new ImmutableRayPoint(1000, 2000, 3000)); /// add point to list
			return shapePoints.Add(new ImmutableRayPoint(1000, 2000, 3000)); /// add point to list
		}



		public void MoveImmutableShape(int delta, List<ImmutableRayPoint> shapePoints)
		{
			// changing shared state
			for (int counter = 0; counter < shapePoints.Count(); counter++)
			{
				//point.X += delta;
				//point.Y += delta;
				//point.Z += delta;
					var point = shapePoints[counter];
				 shapePoints[counter] = point.Update(point.X + delta, point.Y + delta, point.Z + delta);
			
			}
		}


	
		#region PrintToConsole
	

		private void PrintShape(IEnumerable<ImmutableRayPoint> shapePoints)
		{
			foreach (var point in shapePoints)
			{
				Console.WriteLine($"X: {point.X}, Y:{point.Y}, Z:{point.Z}");
			}
		}
		#endregion
	}

	
}
