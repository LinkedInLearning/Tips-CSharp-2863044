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

			// long sequences of numbers are more readable with separators.

			// 44772288335492449922


			// 4477-2288-3354-9244-9922
			// 44,772,288,335,492,449,922
			// 447 722 835 492 449 922

			long numA, numB, numC, numD;

		//	numA = 222,333,444,555; // nor allowed
			numA = long.Parse("222,333,444,555", System.Globalization.NumberStyles.Any); 
			// this works, but why have string to long conversion?

			// C# 7 introduces the "_" digit separator

			numB = 222_333_444_555;
			numC = 1122_2333_4445_55;
			numD = 1_2_3_4_5_4_3; // less useful example

			// useful for decimal, float and double types

			decimal bigNumber = 1432M * 135_795_632M;
			double d1 = 16.121_232_343_454_565e3;
			double d2 = 16.121_232_343_454_565e12;
			
			Console.WriteLine(d1 + d2);
			Console.WriteLine(bigNumber);

		}
	}

}
