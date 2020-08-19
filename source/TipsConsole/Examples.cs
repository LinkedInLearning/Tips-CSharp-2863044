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
			MutableListExample();
			ImmutableListExample();
		}

		public void MutableListExample()
		{
			Console.WriteLine("List<T>");
			var shape = PointSource.GetShape();
			PrintShape(shape);
			Console.WriteLine();
			ExpandShape(shape);
			PrintShape(shape);
			Console.WriteLine();
		}

		public void ImmutableListExample()
		{
			Console.WriteLine("ImmutableList<T>");
			var shape = PointSource.GetShapeBetter();
			PrintShape(shape);
			Console.WriteLine();
			shape = ExpandShapeBetter(shape);
			
			PrintShape(shape);
		}

		public void ExpandShape(List<ImmutableRayPoint> shapePoints) {
			// ImmutableRayPoint is immutable
			// but the List<T> is not.
			// Therefore it is not thread safe.  
			// Another thread could alter collection

			// add points to list
			shapePoints.Add(new ImmutableRayPoint(1000, 2000, 3000)); 
			shapePoints.Add(new ImmutableRayPoint(-17, -27, -37));
			
		}
		public void ReduceShapePoints(List<ImmutableRayPoint> shapePoints)
		{
			// List<T> is not thread safe.  
			// Another thread could alter collection
			shapePoints.RemoveAt(0); // remove point
		}

			public ImmutableList<ImmutableRayPoint> ExpandShapeBetter(ImmutableList<ImmutableRayPoint> shapePoints)
		{
			// ImmutableList changes result in a new ImmutableList instance

			// prior example
			// shapePoints = shapePoints.Add(new ImmutableRayPoint(1000, 2000, 3000)); 
			return shapePoints.Add(new ImmutableRayPoint(1000, 2000, 3000)); 
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
