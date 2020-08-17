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
			Int32 result = new Int32();
			Int32 calculatedTotal = 0;
			var d1 = new Dictionary<string, int>();
			d1.Add("ten", 10);
			d1.Add("twenty", 20);
			d1.Add("thirty", 30);
			
			// avoid race conditions when checking whether an item exists in a dictionary.

			//  Don't write this code
			if (d1.ContainsKey("thirty"))
			{
				// another thread could have removed the item
				// before this code runs
				result = d1["thirty"];
				// do additional work here...
				calculatedTotal = result * 5;
			}

			// use this code instead.
			// checks the value, assigns to the out parameter if it exists in dictionary.
			if (d1.TryGetValue("twenty", out result))
			{
				calculatedTotal = result * 5;
				Console.WriteLine($"Result: {result}");
			}
			else {
				Console.WriteLine("key does not exist");
			}

		}
		
	}
	
}
