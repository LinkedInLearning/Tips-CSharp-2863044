using CourseLib.Cards;
using System;
using System.Collections.Generic;
using System.Text;

namespace CourseLib.Cards
{
	public class CardSource
	{
		private static List<Card> _cards;
		static CardSource()
		{
			_cards = new List<Card>();

			_cards.Add(new Monster
			{
				Name = "Mingle",
				EyeCount = 2,
				ListPrice = 5.99M,
				AskingPrice = 15.95M,
				Description = "Mingle excels at doing twice the work in half the time, with pinpoint accuracy.  These skills serve her well in her role as Senior Data Analyst for an international cloud computing company. She's also got a penchant for ballroom dance, line dancing, and pretty much any kind of activity that lets her groove to music.",

				Spikes = false,
				Antenna = false,

			});
			_cards.Add(new Monster
			{
				Name = "Yodel",
				EyeCount = 2,
				ListPrice = 5.99M,
				AskingPrice = 6.95M,
				Description = "Yodel grew up in a family of singers and loud talkers and could never get a word in edgewise. Then his vast talent for yodeling emerged. Now he performs to adoring fans throughout the world, and always has the loudest voice at the dinner table. Incidentally, he's also a loud proponent of net neutrality, and spends countless hours moderating an Internet forum devoted solely to that subject.",

				Spikes = false,
				Antenna = true,

			});

			_cards.Add(new Monster
			{

				Name = "Squido",

				EyeCount = 2,
				ListPrice = 5.99M,
				AskingPrice = 6.95M,
				Description = "Squido's got his hands or rather tentacles, in everything. First and foremost, he's a web designer with an eye for visual aesthetics, but he's also rather keen on UX design and making sure what he creates translates optimally to the end user. In his off-hours he's an avid nature photographer and bowler.",

				Spikes = false,
				Antenna = false,


			});

			_cards.Add(new Monster
			{
				Name = "Spook",
				ListPrice = 5.99M,
				AskingPrice = 23.95M,
				Description = "Cracking code and battling hackers is Spook's forte. She holds a prominent position as Head of Cyber Security for the Department of Monster Defense, where she thwarts attacks on government computer systems as often as she blinks. When not at work, Spook delights in serving up a fright at haunted mansions and ghost walks.",
				Spikes = false,
				Antenna = false,
				EyeCount = 5
			});

			_cards.Add(new Cyborg
			{

				Name = "Blade",
				ListPrice = 5.99M,
				AskingPrice = 42.50M,

				Description = "Blade freelances as a mobile app developer and has built some of the most popular mobile apps used in modern cyborg society, including the award-winning Battery Watcher ",
				BatteryLevel = 37,
			});

			_cards.Add(new Android
			{
				Name = "Drift",
				ListPrice = 5.99M,
				AskingPrice = 17.95M,

				Description = "After years of everyone saying her head was in the clouds, Drift found her calling as a software engineer developing a well-known cloud solution for the computing giant, Red30 Tech. After work, she prefers to unwind by catching wind in her sail and paragliding high in the sky.",
				BatteryLevel = 96,
			});
			
		}
		public static List<Card> GetCards()
		{

			return _cards;

		}
	}
}
