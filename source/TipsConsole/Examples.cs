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
			
			MutableStateExample();
			ImmutableStateExample();
		}

		private void MutableStateExample()
		{
			Console.WriteLine("Mutable Point");
			var shapePoints = PointSource.GetShapePoints();
			PrintShape(shapePoints);
			Console.WriteLine();
			MoveShape(delta: 10, shapePoints: shapePoints);
			PrintShape(shapePoints);
			Console.WriteLine("");
		}

		public void ImmutableStateExample()
		{
			Console.WriteLine("Immutable Point");
			var immutableShapePoints = PointSource.GetImmutableShapePoints();
			PrintShape(immutableShapePoints);
			Console.WriteLine();
			MoveImmutableShape(delta: 10, shapePoints: immutableShapePoints);
			PrintShape(immutableShapePoints);
		}


		
		public void MoveShape(int delta, List<RayPoint> shapePoints)
		{
			// changing shared state
			foreach (var point in shapePoints)
			{
				point.X += delta;
				point.Y += delta;
				point.Z += delta;
			}


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
		private void PrintShape(IEnumerable<RayPoint> shapePoints)
		{
			foreach (var point in shapePoints)
			{
				Console.WriteLine($"X: {point.X}, Y:{point.Y}, Z:{point.Z}");
			}
		}

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
