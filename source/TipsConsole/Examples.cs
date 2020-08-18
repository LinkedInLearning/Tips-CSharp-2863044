using CourseLib;
using CourseLib.Cards;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;

namespace TipsConsole
{
	internal class Examples
	{
		public void ShowExample()
		{
			SwitchOldSyntax();
			// SwitchOnType();
			// SwitchWithWhen();
		}

		private void SwitchOldSyntax()
		{
			// C# 7 added the Case pattern
			// now switch statement are not limited to core types
			// like integers and strings.
			int number = 23;
			//  old style
			switch (number)
			{
				case 0:

					break;
				case 10:
					break;
				case 20:
					break;
				case 21:
					break;
				case 22:
					break;
				case 23:
					Console.WriteLine("23 is the winning number!");
					break;
				case 24:
					break;
				case 30:
					break;
				default:
					break;
			}
		}

		public void SwitchOnType()
		{

			var cards = CardSource.GetCards();
			foreach (var card in cards)
			{
				Console.ForegroundColor = ConsoleColor.Green;
				Console.Write($"{card.Name} - \t");
				switch (card)
				{
					case Robot myRobot:
						Console.ForegroundColor = ConsoleColor.Yellow;
						Console.WriteLine($"This card is a robot card.");
						Console.WriteLine($"\t\tBattery level is {myRobot.BatteryLevel}");
						// include expression based on type

						if (myRobot.BatteryLevel < 50)
						{
							Console.ForegroundColor = ConsoleColor.Red;
							Console.WriteLine($"\t\tbattery low");
						}
						break;
					case Creature myCreature:
						Console.WriteLine($"This card is a creature card.");
						Console.WriteLine($"\t\teyecount: {myCreature.EyeCount}");
						break;
					case null:
						Console.WriteLine($"No card, null.");
						break;
					default:
						Console.ForegroundColor = ConsoleColor.Green;
						Console.WriteLine($" a standard trading card.");
						break;
				}
			}


		}


		private void SwitchWithWhen()
		{
			// case statements are not mutually exclusive anymore
			// use when to specify additional conditions
			var numbers = Enumerable.Range(1, 110);
			string message;
			var eighties = new List<int> { 80, 81, 82, 83, 84, 85, 86, 87, 88, 89 };
			foreach (var number in numbers)
			{
				message = string.Empty;
				switch (number)
				{
					case 42:
						message += "Meaning Of Life,";
						break;
					case var candidate when (candidate % 20 == 0):
						message += "Mod 20,";
						break;
					case var candidate when (eighties.Contains(candidate)):
						message += "Eighties,";
						break;
					default:
						break;
				}
				Console.WriteLine($"{number:D2}: {message}");
			}

		}
	}

}
