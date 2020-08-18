using System;
using System.Collections.Generic;
using System.Diagnostics;

namespace CourseLib
{
	//[DebuggerDisplay("{DebuggerDisplayForClass,nq}")]
	public class WebColor
	{
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		private string DebuggerDisplayForClass
		{
			get
			{
				return $"{ColorName}: \t( R{RedValue}, G{GreenValue}, B{BlueValue} )";
			}
		}
		//DebuggerDisplayAttribute formats how an object, property, or field 
		// is displayed in the debugger variable windows (watch, locals, auto, tooltips).

		// Microsoft best practice guidance is to create a private member
		// responsible for display and format.

		public string ColorName { get; set; }
		public string HexValue { get; set; }
		public int RedValue { get; set; }
		
		public Single RedPercent
		{
			get
			{
				return RedValue / 255.0F;
			}
		}
	
		public int GreenValue { get; set; }
		public Single GreenPercent
		{
			get
			{
				return GreenValue / 255.0F;
			}
		}
		public int BlueValue { get; set; }
		public Single BluePercent
		{

			get
			{
				return BlueValue / 255F;
			}
		}
		public HSL HSL { get; set; }
		public ColorFamily ColorFamily { get; set; }

	}
	//[DebuggerDisplay("{DebuggerDisplay,nq}")]
	public struct HSL
	{

		public int Hue;
		public int Saturation;
		public int Lightness;
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		private string DebuggerDisplay
		{
			get
			{
				return $"Hue: {Hue}, Saturation {Saturation}, Lightness {Lightness}%";
			}
		}
	}

	public enum ColorFamily
	{
		Red,
		Yellow,
		Orange,
		Pink,
		Green,
		Blue,
		Cyan,
		Purple,
		Pale,
		Brown,
		Gray,

	}

}
