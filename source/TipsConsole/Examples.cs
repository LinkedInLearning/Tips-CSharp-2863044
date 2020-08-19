using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Drawing;
using System.Text;

namespace TipsConsole
{
	internal class Examples
	{
		public void ShowExample()
		{
			int unusedVariable = 10;

			// the underscore can serve as the discards placeholder
			// think of discards as a temporary, dummy variables 
			// that are intentionally unused in application code. 
			// Discards are equivalent to unassigned variables; 
			// they do not have a value.


			// assign an expression to a discard.
			_ = 12 + 14;

			// var x = _ ;  // cannot do this 

			// available for
			// Calls to methods with out parameters.
			// tuple and object deconstruction
			// pattern matching with "is" and "switch".

			DiscardOutParam();
			// Deconstruct();

		}
		public void DiscardOutParam()
		{

			var inputs = new List<string> { "123", "234", "abc", "def" };

			foreach (string input in inputs)
			{
				if (int.TryParse(input, out _))
					Console.WriteLine($"'{input}': valid");
				else
					Console.WriteLine($"'{input}': invalid");
			}
		}

		public void Deconstruct()
		{
			var robot = new Robot { Name = "X632", 
															HasWheels = true, 
															SensorCount = 12 };
			var (a, b, c) = robot.GetStats();

			var (x, y, _) = robot.GetStats();

		}

	}
	public class Robot
	{
		public string Name { get; set; }
		public bool HasWheels { get; set; }
		public int SensorCount { get; set; }
		public (string, bool, int) GetStats()
		{
			return (Name, HasWheels, SensorCount);
		}
	}
}
