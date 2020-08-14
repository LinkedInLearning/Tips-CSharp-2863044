using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Drawing;
using System.Runtime.InteropServices;
using System.Text;

namespace TipsConsole
{
	internal class Example
	{
		public void ShowExample()
		{


		}

		public void CasePattern()
		{
			// walt note: rewrite this to use the trading cards types, that
			// makes it easier to demonstrate types in case statements.
			// C# 7 added the Case pattern
			// 
			// now switch statement are not limited to core types
			// like integers and strings.
			int number = 25;
			//  old style
			switch (number)
			{
				case 0:

					break;
				case 10:
					break;
				case 20:
					break;
				case 30:
					break;
				default:
					break;
			}
			var card = new Card { Suit = Suit.Clubs, Value = CardValue.Ace }
			switch (card)
			{
				case 0:
					break;
				case int x:
					// include variables and expressions 
					if (x >= 10 & x < 20)
					{

					}
					break;
				case 20:
					break;
				case 30:
					break;
				default:
					break;
			}

		}



	}
	public struct Card
	{
		public Suit Suit { get; set; }
		public CardValue Value { get; set; }
	}
	public enum Suit
	{
		Clubs,
		Spades,
		Hearts,
		Diamonds
	}
	public enum CardValue
	{
		Ace,
		Two,
		Three,
		Four,
		Five,
		Six,
		Seven,
		Eight,
		Nine,
		Ten,
		Jack,
		Queen,
		King
	}
}
