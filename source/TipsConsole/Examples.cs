using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;

namespace TipsConsole
{
	internal class Examples
	{ 
		public void ShowExample()
		{

			var allColors = CourseLib.ColorSource.GetColors();
			var webColor = allColors.ElementAt(4);

			var redValue = webColor.RedValue;
			var redPercent = webColor.RedPercent;

			var hsl = webColor.HSL;
			var hex = webColor.HexValue;
		}
		
	}
	
}
