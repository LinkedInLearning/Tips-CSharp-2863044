using System;
using System.Collections.Generic;
using System.Dynamic;
using System.Runtime.Serialization;
using System.Text;

namespace CourseLib.Cards
{
	// defined for fantasy card game

	public class Card
	{
		public string Name { get; set; }
		public string Description { get; set; }
		public decimal ListPrice { get; set; }
		public decimal AskingPrice { get; set; }
		public decimal Discount { get { return AskingPrice * .45M; } }
		public decimal SalePrice { get { return AskingPrice - Discount; } }

		public string TypeName
		{
			get { return this.GetType().FullName; }
		}
	}
	public class Creature : Card
	{

		public int EyeCount { get; set; }
		public bool Spikes { get; set; }
		public bool Antenna { get; set; }
		
	}
	public class Monster : Creature
	{
		
	}


	public class Robot : Card , ISerializable
	{

		public decimal BatteryLevel { get; set; }
		public void GetObjectData(SerializationInfo info, StreamingContext context)
		{
			throw new NotImplementedException();
		}
	}
	public class Cyborg : Robot
	{

	}
	public class Android : Robot
	{ }
}
