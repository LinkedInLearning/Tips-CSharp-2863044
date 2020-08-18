using System;
using System.Collections.Generic;
using System.Text;

namespace CourseLib
{
	public class ColorSource
	{
		public static List<WebColor> GetColors()
		{
			var temp = new List<WebColor>();
			temp.Add(new WebColor
			{
				ColorName = "DarkRed",
				HexValue = "8B0000",
				RedValue = 139,
				GreenValue = 0,
				BlueValue = 0,

				HSL = new HSL { Hue = 0, Saturation = 100, Lightness = 27 },
				ColorFamily = ColorFamily.Red
			});

			temp.Add(new WebColor
			{
				ColorName = "FireBrick",
				HexValue = "B22222",
				RedValue = 178,
				GreenValue = 34,
				BlueValue = 34,
				HSL = new HSL
				{
					Hue = 0,
					Saturation = 68,
					Lightness = 42
				},
				ColorFamily = ColorFamily.Red
			});

			temp.Add(new WebColor
			{
				ColorName = "IndianRed",
				HexValue = "CD5C5C",
				RedValue = 205,
				GreenValue = 92,
				BlueValue = 92,
				HSL = new HSL
				{
					Hue = 0,
					Saturation = 53,
					Lightness = 58
				},
				ColorFamily = ColorFamily.Red
			});

			temp.Add(new WebColor
			{
				ColorName = "Crimson",
				HexValue = "DC143C",
				RedValue = 220,
				GreenValue = 20,
				BlueValue = 60,
				HSL = new HSL
				{
					Hue = 348,
					Saturation = 83,
					Lightness = 47
				},
				ColorFamily = ColorFamily.Red
			});
			temp.Add(new WebColor
			{
				ColorName = "DarkSalmon",
				HexValue = "E9967A",
				RedValue = 233,
				GreenValue = 150,
				BlueValue = 122,
				HSL = new HSL
				{
					Hue = 15,
					Saturation = 72,
					Lightness = 70
				},
				ColorFamily = ColorFamily.Red
			});
			temp.Add(new WebColor
			{
				ColorName = "LightCoral",
				HexValue = "F08080",
				RedValue = 240,
				GreenValue = 128,
				BlueValue = 128,
				HSL = new HSL
				{
					Hue = 0,
					Saturation = 79,
					Lightness = 72
				},
				ColorFamily = ColorFamily.Red
			});

			temp.Add(new WebColor
			{
				ColorName = "Salmon",
				HexValue = "FA8072",
				RedValue = 250,
				GreenValue = 128,
				BlueValue = 114,
				HSL = new HSL
				{
					Hue = 6,
					Saturation = 93,
					Lightness = 71
				},
				ColorFamily = ColorFamily.Red
			});

			temp.Add(new WebColor
			{
				ColorName = "Red",
				HexValue = "FF0000",
				RedValue = 255,
				GreenValue = 0,
				BlueValue = 0,
				HSL = new HSL
				{
					Hue = 0,
					Saturation = 100,
					Lightness = 50
				},
				ColorFamily = ColorFamily.Red
			});
			temp.Add(new WebColor
			{
				ColorName = "LightSalmon",
				HexValue = "FFA07A",
				RedValue = 255,
				GreenValue = 160,
				BlueValue = 122,
				HSL = new HSL
				{
					Hue = 17,
					Saturation = 100,
					Lightness = 74
				},
				ColorFamily = ColorFamily.Red
			});

			temp.Add(new WebColor
			{
				ColorName = "DarkKhaki",
				HexValue = "BDB76B",
				RedValue = 189,
				GreenValue = 183,
				BlueValue = 107,
				HSL = new HSL
				{
					Hue = 56,
					Saturation = 38,
					Lightness = 58
				},
				ColorFamily = ColorFamily.Yellow
			});

			temp.Add(new WebColor
			{
				ColorName = "PaleGoldenrod",
				HexValue = "EEE8AA",
				RedValue = 238,
				GreenValue = 232,
				BlueValue = 170,
				HSL = new HSL
				{
					Hue = 55,
					Saturation = 67,
					Lightness = 80
				},
				ColorFamily = ColorFamily.Yellow
			});
			temp.Add(new WebColor
			{
				ColorName = "Khaki",
				HexValue = "F0E68C",
				RedValue = 240,
				GreenValue = 230,
				BlueValue = 140,
				HSL = new HSL
				{
					Hue = 54,
					Saturation = 77,
					Lightness = 75
				},
				ColorFamily = ColorFamily.Yellow
			});

			temp.Add(new WebColor
			{
				ColorName = "LightGoldenrodYellow",
				HexValue = "FAFAD2",
				RedValue = 250,
				GreenValue = 250,
				BlueValue = 210,
				HSL = new HSL
				{
					Hue = 60,
					Saturation = 80,
					Lightness = 90
				},
				ColorFamily = ColorFamily.Yellow
			});
			temp.Add(new WebColor
			{
				ColorName = "PeachPuff",
				HexValue = "FFDAB9",
				RedValue = 255,
				GreenValue = 218,
				BlueValue = 185,
				HSL = new HSL
				{
					Hue = 28,
					Saturation = 100,
					Lightness = 86
				},
				ColorFamily = ColorFamily.Yellow
			});

			temp.Add(new WebColor
			{
				ColorName = "Moccasin",
				HexValue = "FFE4B5",
				RedValue = 255,
				GreenValue = 228,
				BlueValue = 181,
				HSL = new HSL
				{
					Hue = 38,
					Saturation = 100,
					Lightness = 85
				},
				ColorFamily = ColorFamily.Yellow
			});

			temp.Add(new WebColor
			{
				ColorName = "PapayaWhip",
				HexValue = "FFEFD5",
				RedValue = 255,
				GreenValue = 239,
				BlueValue = 213,
				HSL = new HSL
				{
					Hue = 37,
					Saturation = 100,
					Lightness = 92
				},
				ColorFamily = ColorFamily.Yellow
			});
			temp.Add(new WebColor
			{
				ColorName = "LemonChiffon",
				HexValue = "FFFACD",
				RedValue = 255,
				GreenValue = 250,
				BlueValue = 205,
				HSL = new HSL
				{
					Hue = 54,
					Saturation = 100,
					Lightness = 90
				},
				ColorFamily = ColorFamily.Yellow
			});
			temp.Add(new WebColor
			{
				ColorName = "Yellow",
				HexValue = "FFFF00",
				RedValue = 255,
				GreenValue = 255,
				BlueValue = 0,
				HSL = new HSL
				{
					Hue = 60,
					Saturation = 100,
					Lightness = 50
				},
				ColorFamily = ColorFamily.Yellow
			});
			temp.Add(new WebColor
			{
				ColorName = "LightYellow",
				HexValue = "FFFFE0",
				RedValue = 255,
				GreenValue = 255,
				BlueValue = 224,
				HSL = new HSL
				{
					Hue = 60,
					Saturation = 100,
					Lightness = 94
				},
				ColorFamily = ColorFamily.Yellow
			});

			temp.Add(new WebColor
			{
				ColorName = "OrangeRed",
				HexValue = "FF4500",
				RedValue = 255,
				GreenValue = 69,
				BlueValue = 0,
				HSL = new HSL
				{
					Hue = 16,
					Saturation = 100,
					Lightness = 50
				},
				ColorFamily = ColorFamily.Orange
			});
			temp.Add(new WebColor
			{
				ColorName = "Tomato",
				HexValue = "FF6347",
				RedValue = 255,
				GreenValue = 99,
				BlueValue = 71,
				HSL = new HSL
				{
					Hue = 9,
					Saturation = 100,
					Lightness = 64
				},
				ColorFamily = ColorFamily.Orange
			});

			temp.Add(new WebColor
			{
				ColorName = "Coral",
				HexValue = "FF7F50",
				RedValue = 255,
				GreenValue = 127,
				BlueValue = 80,
				HSL = new HSL
				{
					Hue = 16,
					Saturation = 100,
					Lightness = 66
				},
				ColorFamily = ColorFamily.Orange
			});

			temp.Add(new WebColor
			{
				ColorName = "DarkOrange",
				HexValue = "FF8C00",
				RedValue = 255,
				GreenValue = 140,
				BlueValue = 0,
				HSL = new HSL
				{
					Hue = 33,
					Saturation = 100,
					Lightness = 50
				},
				ColorFamily = ColorFamily.Orange
			});

			temp.Add(new WebColor
			{
				ColorName = "Orange",
				HexValue = "FFA500",
				RedValue = 255,
				GreenValue = 165,
				BlueValue = 0,
				HSL = new HSL
				{
					Hue = 39,
					Saturation = 100,
					Lightness = 50
				},
				ColorFamily = ColorFamily.Orange
			});
			temp.Add(new WebColor
			{
				ColorName = "Gold",
				HexValue = "FFD700",
				RedValue = 255,
				GreenValue = 215,
				BlueValue = 0,
				HSL = new HSL
				{
					Hue = 51,
					Saturation = 100,
					Lightness = 50
				},
				ColorFamily = ColorFamily.Orange
			});

			temp.Add(new WebColor
			{
				ColorName = "MediumVioletRed",
				HexValue = "C71585",
				RedValue = 199,
				GreenValue = 21,
				BlueValue = 133,
				HSL = new HSL
				{
					Hue = 322,
					Saturation = 81,
					Lightness = 43
				},
				ColorFamily = ColorFamily.Pink
			});
			temp.Add(new WebColor
			{
				ColorName = "PaleVioletRed",
				HexValue = "DB7093",
				RedValue = 219,
				GreenValue = 112,
				BlueValue = 147,
				HSL = new HSL
				{
					Hue = 340,
					Saturation = 60,
					Lightness = 65
				},
				ColorFamily = ColorFamily.Pink
			});

			temp.Add(new WebColor
			{
				ColorName = "DeepPink",
				HexValue = "FF1493",
				RedValue = 255,
				GreenValue = 20,
				BlueValue = 147,
				HSL = new HSL
				{
					Hue = 328,
					Saturation = 100,
					Lightness = 54
				},
				ColorFamily = ColorFamily.Pink
			});
			temp.Add(new WebColor
			{
				ColorName = "HotPink",
				HexValue = "FF69B4",
				RedValue = 255,
				GreenValue = 105,
				BlueValue = 180,
				HSL = new HSL
				{
					Hue = 330,
					Saturation = 100,
					Lightness = 71
				},
				ColorFamily = ColorFamily.Pink
			});
			temp.Add(new WebColor
			{
				ColorName = "LightPink",
				HexValue = "FFB6C1",
				RedValue = 255,
				GreenValue = 192,
				BlueValue = 203,
				HSL = new HSL
				{
					Hue = 350,
					Saturation = 100,
					Lightness = 88
				},
				ColorFamily = ColorFamily.Pink
			});

			temp.Add(new WebColor
			{
				ColorName = "Pink",
				HexValue = "FFC0CB",
				RedValue = 255,
				GreenValue = 192,
				BlueValue = 203,
				HSL = new HSL
				{
					Hue = 350,
					Saturation = 100,
					Lightness = 88
				},
				ColorFamily = ColorFamily.Pink
			});

			temp.Add(new WebColor
			{
				ColorName = "DarkGreen",
				HexValue = "006400",
				RedValue = 0,
				GreenValue = 100,
				BlueValue = 0,
				HSL = new HSL
				{
					Hue = 120,
					Saturation = 100,
					Lightness = 20
				},
				ColorFamily = ColorFamily.Green
			});

			temp.Add(new WebColor
			{
				ColorName = "Green",
				HexValue = "008000",
				RedValue = 0,
				GreenValue = 128,
				BlueValue = 0,
				HSL = new HSL
				{
					Hue = 120,
					Saturation = 100,
					Lightness = 25
				},
				ColorFamily = ColorFamily.Green
			});


			temp.Add(new WebColor
			{
				ColorName = "MediumSpringGreen",
				HexValue = "00FA9A",
				RedValue = 0,
				GreenValue = 250,
				BlueValue = 154,
				HSL = new HSL
				{
					Hue = 157,
					Saturation = 100,
					Lightness = 49
				},
				ColorFamily = ColorFamily.Green
			});


			temp.Add(new WebColor
			{
				ColorName = "Lime",
				HexValue = "00FF00",
				RedValue = 0,
				GreenValue = 255,
				BlueValue = 0,
				HSL = new HSL
				{
					Hue = 120,
					Saturation = 100,
					Lightness = 50
				},
				ColorFamily = ColorFamily.Green
			});


			temp.Add(new WebColor
			{
				ColorName = "SpringGreen",
				HexValue = "00FF7F",
				RedValue = 0,
				GreenValue = 255,
				BlueValue = 127,
				HSL = new HSL
				{
					Hue = 150,
					Saturation = 100,
					Lightness = 50
				},
				ColorFamily = ColorFamily.Green
			});


			temp.Add(new WebColor
			{
				ColorName = "ForestGreen",
				HexValue = "228B22",
				RedValue = 34,
				GreenValue = 139,
				BlueValue = 34,
				HSL = new HSL
				{
					Hue = 120,
					Saturation = 61,
					Lightness = 34
				},
				ColorFamily = ColorFamily.Green
			});


			temp.Add(new WebColor
			{
				ColorName = "SeaGreen",
				HexValue = "2E8B57",
				RedValue = 46,
				GreenValue = 139,
				BlueValue = 87,
				HSL = new HSL
				{
					Hue = 146,
					Saturation = 50,
					Lightness = 36
				},
				ColorFamily = ColorFamily.Green
			});

			temp.Add(new WebColor
			{
				ColorName = "LimeGreen",
				HexValue = "32CD32",
				RedValue = 50,
				GreenValue = 205,
				BlueValue = 50,
				HSL = new HSL
				{
					Hue = 120,
					Saturation = 61,
					Lightness = 50
				},
				ColorFamily = ColorFamily.Green
			});


			temp.Add(new WebColor
			{
				ColorName = "MediumSeaGreen",
				HexValue = "3CB371",
				RedValue = 60,
				GreenValue = 179,
				BlueValue = 113,
				HSL = new HSL
				{
					Hue = 147,
					Saturation = 50,
					Lightness = 47
				},
				ColorFamily = ColorFamily.Green
			});

			temp.Add(new WebColor
			{
				ColorName = "DarkOliveGreen",
				HexValue = "556B2F",
				RedValue = 85,
				GreenValue = 107,
				BlueValue = 47,
				HSL = new HSL
				{
					Hue = 82,
					Saturation = 39,
					Lightness = 30
				},
				ColorFamily = ColorFamily.Green
			});


			temp.Add(new WebColor
			{
				ColorName = "OliveDrab",
				HexValue = "6B8E23",
				RedValue = 107,
				GreenValue = 142,
				BlueValue = 35,
				HSL = new HSL
				{
					Hue = 80,
					Saturation = 6,
					Lightness = 35
				},
				ColorFamily = ColorFamily.Green
			});

			temp.Add(new WebColor
			{
				ColorName = "LawnGreen",
				HexValue = "7CFC00",
				RedValue = 124,
				GreenValue = 252,
				BlueValue = 0,
				HSL = new HSL
				{
					Hue = 90,
					Saturation = 100,
					Lightness = 49
				},
				ColorFamily = ColorFamily.Green
			});

			temp.Add(new WebColor
			{
				ColorName = "Chartreuse",
				HexValue = "7FFF00",
				RedValue = 127,
				GreenValue = 255,
				BlueValue = 0,
				HSL = new HSL
				{
					Hue = 90,
					Saturation = 100,
					Lightness = 50
				},
				ColorFamily = ColorFamily.Green
			});

			temp.Add(new WebColor
			{
				ColorName = "Olive",
				HexValue = "808000",
				RedValue = 128,
				GreenValue = 128,
				BlueValue = 0,
				HSL = new HSL
				{
					Hue = 60,
					Saturation = 100,
					Lightness = 25
				},
				ColorFamily = ColorFamily.Green
			});

			temp.Add(new WebColor
			{
				ColorName = "DarkSeaGreen",
				HexValue = "8FBC8F",
				RedValue = 143,
				GreenValue = 188,
				BlueValue = 143,
				HSL = new HSL
				{
					Hue = 120,
					Saturation = 25,
					Lightness = 65
				},
				ColorFamily = ColorFamily.Green
			});

			temp.Add(new WebColor
			{
				ColorName = "LightGreen",
				HexValue = "90EE90",
				RedValue = 144,
				GreenValue = 238,
				BlueValue = 144,
				HSL = new HSL
				{
					Hue = 120,
					Saturation = 73,
					Lightness = 75
				},
				ColorFamily = ColorFamily.Green
			});

			temp.Add(new WebColor
			{
				ColorName = "PaleGreen",
				HexValue = "98FB98",
				RedValue = 152,
				GreenValue = 251,
				BlueValue = 152,
				HSL = new HSL
				{
					Hue = 120,
					Saturation = 93,
					Lightness = 79
				},
				ColorFamily = ColorFamily.Green
			});

			temp.Add(new WebColor
			{
				ColorName = "YellowGreen",
				HexValue = "9ACD32",
				RedValue = 154,
				GreenValue = 205,
				BlueValue = 50,
				HSL = new HSL
				{
					Hue = 80,
					Saturation = 61,
					Lightness = 50
				},
				ColorFamily = ColorFamily.Green
			});

			temp.Add(new WebColor
			{
				ColorName = "GreenYellow",
				HexValue = "ADFF2F",
				RedValue = 173,
				GreenValue = 255,
				BlueValue = 47,
				HSL = new HSL
				{
					Hue = 84,
					Saturation = 100,
					Lightness = 59
				},
				ColorFamily = ColorFamily.Green
			});

			temp.Add(new WebColor
			{
				ColorName = "Navy",
				HexValue = "000080",
				RedValue = 0,
				GreenValue = 0,
				BlueValue = 128,
				HSL = new HSL
				{
					Hue = 240,
					Saturation = 100,
					Lightness = 25
				},
				ColorFamily = ColorFamily.Blue
			});

			temp.Add(new WebColor
			{
				ColorName = "DarkBlue",
				HexValue = "00008B",
				RedValue = 0,
				GreenValue = 0,
				BlueValue = 139,
				HSL = new HSL
				{
					Hue = 240,
					Saturation = 100,
					Lightness = 27
				},
				ColorFamily = ColorFamily.Blue
			});


			temp.Add(new WebColor
			{
				ColorName = "MediumBlue",
				HexValue = "0000CD",
				RedValue = 0,
				GreenValue = 0,
				BlueValue = 205,
				HSL = new HSL
				{
					Hue = 240,
					Saturation = 100,
					Lightness = 40
				},
				ColorFamily = ColorFamily.Blue
			});


			temp.Add(new WebColor
			{
				ColorName = "Blue",
				HexValue = "0000FF",
				RedValue = 0,
				GreenValue = 0,
				BlueValue = 0255,
				HSL = new HSL
				{
					Hue = 240,
					Saturation = 100,
					Lightness = 50
				},
				ColorFamily = ColorFamily.Blue
			});

			temp.Add(new WebColor
			{
				ColorName = "DeepSkyBlue",
				HexValue = "00BFFF",
				RedValue = 0,
				GreenValue = 91,
				BlueValue = 255,
				HSL = new HSL
				{
					Hue = 195,
					Saturation = 10,
					Lightness = 50
				},
				ColorFamily = ColorFamily.Blue
			});


			temp.Add(new WebColor
			{
				ColorName = "MidnightBlue",
				HexValue = "191970",
				RedValue = 25,
				GreenValue = 25,
				BlueValue = 112,
				HSL = new HSL
				{
					Hue = 240,
					Saturation = 64,
					Lightness = 27
				},
				ColorFamily = ColorFamily.Blue
			});


			temp.Add(new WebColor
			{
				ColorName = "DodgerBlue",
				HexValue = "1E90FF",
				RedValue = 30,
				GreenValue = 144,
				BlueValue = 255,
				HSL = new HSL
				{
					Hue = 210,
					Saturation = 100,
					Lightness = 56
				},
				ColorFamily = ColorFamily.Blue
			});

			temp.Add(new WebColor
			{
				ColorName = "RoyalBlue",
				HexValue = "4169E1",
				RedValue = 65,
				GreenValue = 105,
				BlueValue = 225,
				HSL = new HSL
				{
					Hue = 225,
					Saturation = 73,
					Lightness = 57
				},
				ColorFamily = ColorFamily.Blue
			});


			temp.Add(new WebColor
			{
				ColorName = "SteelBlue",
				HexValue = "4682B4",
				RedValue = 70,
				GreenValue = 130,
				BlueValue = 180,
				HSL = new HSL
				{
					Hue = 207,
					Saturation = 44,
					Lightness = 49
				},
				ColorFamily = ColorFamily.Blue
			});

			temp.Add(new WebColor
			{
				ColorName = "DarkSlateBlue",
				HexValue = "483D8B",
				RedValue = 72,
				GreenValue = 61,
				BlueValue = 139,
				HSL = new HSL
				{
					Hue = 248,
					Saturation = 39,
					Lightness = 39
				},
				ColorFamily = ColorFamily.Blue
			});


			temp.Add(new WebColor
			{
				ColorName = "CornflowerBlue",
				HexValue = "6495ED",
				RedValue = 100,
				GreenValue = 149,
				BlueValue = 237,
				HSL = new HSL
				{
					Hue = 219,
					Saturation = 79,
					Lightness = 66
				},
				ColorFamily = ColorFamily.Blue
			});

			temp.Add(new WebColor
			{
				ColorName = "SlateBlue",
				HexValue = "6A5ACD",
				RedValue = 106,
				GreenValue = 90,
				BlueValue = 205,
				HSL = new HSL
				{
					Hue = 248,
					Saturation = 53,
					Lightness = 58
				},
				ColorFamily = ColorFamily.Blue
			});

			// this color has a incorrect character in HexValue
			temp.Add(new WebColor
			{
				ColorName = "MediumSlateBlue",
				HexValue = "7BR8EE",
				RedValue = 123,
				GreenValue = 104,
				BlueValue = 238,
				HSL = new HSL
				{
					Hue = 249,
					Saturation = 80,
					Lightness = 67
				},
				ColorFamily = ColorFamily.Blue
			});

			temp.Add(new WebColor
			{
				ColorName = "SkyBlue",
				HexValue = "87CEEB",
				RedValue = 135,
				GreenValue = 206,
				BlueValue = 235,
				HSL = new HSL
				{
					Hue = 197,
					Saturation = 71,
					Lightness = 73
				},
				ColorFamily = ColorFamily.Blue
			});

			temp.Add(new WebColor
			{
				ColorName = "LightSkyBlue",
				HexValue = "87CEFA",
				RedValue = 135,
				GreenValue = 206,
				BlueValue = 250,
				HSL = new HSL
				{
					Hue = 203,
					Saturation = 92,
					Lightness = 75
				},
				ColorFamily = ColorFamily.Blue
			});

			temp.Add(new WebColor
			{
				ColorName = "LightBlue",
				HexValue = "ADD8E6",
				RedValue = 173,
				GreenValue = 216,
				BlueValue = 230,
				HSL = new HSL
				{
					Hue = 195,
					Saturation = 53,
					Lightness = 79
				},
				ColorFamily = ColorFamily.Blue
			});

			temp.Add(new WebColor
			{
				ColorName = "LightSteelBlue",
				HexValue = "B0C4DE",
				RedValue = 176,
				GreenValue = 196,
				BlueValue = 222,
				HSL = new HSL
				{
					Hue = 214,
					Saturation = 41,
					Lightness = 78
				},
				ColorFamily = ColorFamily.Blue
			});


			temp.Add(new WebColor
			{
				ColorName = "PowderBlue",
				HexValue = "B0E0E6",
				RedValue = 176,
				GreenValue = 224,
				BlueValue = 230,
				HSL = new HSL
				{
					Hue = 187,
					Saturation = 52,
					Lightness = 80
				},
				ColorFamily = ColorFamily.Blue
			});


			temp.Add(new WebColor
			{
				ColorName = "Teal",
				HexValue = "008080",
				RedValue = 0,
				GreenValue = 128,
				BlueValue = 128,
				HSL = new HSL
				{
					Hue = 180,
					Saturation = 100,
					Lightness = 25
				},
				ColorFamily = ColorFamily.Cyan
			});


			temp.Add(new WebColor
			{
				ColorName = "DarkCyan",
				HexValue = "008B8B",
				RedValue = 0,
				GreenValue = 139,
				BlueValue = 139,
				HSL = new HSL
				{
					Hue = 180,
					Saturation = 100,
					Lightness = 27
				},
				ColorFamily = ColorFamily.Cyan
			});

			temp.Add(new WebColor
			{
				ColorName = "DarkTurquoise",
				HexValue = "00CED1",
				RedValue = 0,
				GreenValue = 206,
				BlueValue = 209,
				HSL = new HSL
				{
					Hue = 181,
					Saturation = 100,
					Lightness = 41
				},
				ColorFamily = ColorFamily.Cyan
			});


			temp.Add(new WebColor
			{
				ColorName = "Cyan",
				HexValue = "00FFFF",
				RedValue = 0,
				GreenValue = 255,
				BlueValue = 255,
				HSL = new HSL
				{
					Hue = 180,
					Saturation = 100,
					Lightness = 50
				},
				ColorFamily = ColorFamily.Cyan
			});

			temp.Add(new WebColor
			{
				ColorName = "Aqua",
				HexValue = "00FFFF",
				RedValue = 0,
				GreenValue = 255,
				BlueValue = 255,
				HSL = new HSL
				{
					Hue = 180,
					Saturation = 100,
					Lightness = 50
				},
				ColorFamily = ColorFamily.Cyan
			});

			temp.Add(new WebColor
			{
				ColorName = "LightSeaGreen",
				HexValue = "20B2AA",
				RedValue = 32,
				GreenValue = 178,
				BlueValue = 170,
				HSL = new HSL
				{
					Hue = 177,
					Saturation = 70,
					Lightness = 41
				},
				ColorFamily = ColorFamily.Cyan
			});


			temp.Add(new WebColor
			{
				ColorName = "Turquoise",
				HexValue = "40E0D0",
				RedValue = 64,
				GreenValue = 224,
				BlueValue = 208,
				HSL = new HSL
				{
					Hue = 174,
					Saturation = 72,
					Lightness = 56
				},
				ColorFamily = ColorFamily.Cyan
			});

			temp.Add(new WebColor
			{
				ColorName = "MediumTurquoise",
				HexValue = "48D1CC",
				RedValue = 72,
				GreenValue = 209,
				BlueValue = 204,
				HSL = new HSL
				{
					Hue = 178,
					Saturation = 60,
					Lightness = 55
				},
				ColorFamily = ColorFamily.Cyan
			});

			temp.Add(new WebColor
			{
				ColorName = "Cadetblue",
				HexValue = "5F9EA0",
				RedValue = 95,
				GreenValue = 158,
				BlueValue = 160,
				HSL = new HSL
				{
					Hue = 182,
					Saturation = 25,
					Lightness = 50
				},
				ColorFamily = ColorFamily.Cyan
			});

			temp.Add(new WebColor
			{
				ColorName = "MediumAquamarine",
				HexValue = "66CDAA",
				RedValue = 102,
				GreenValue = 205,
				BlueValue = 170,
				HSL = new HSL
				{
					Hue = 160,
					Saturation = 51,
					Lightness = 60
				},
				ColorFamily = ColorFamily.Cyan
			});


			temp.Add(new WebColor
			{
				ColorName = "Aquamarine",
				HexValue = "7FFFD4",
				RedValue = 127,
				GreenValue = 255,
				BlueValue = 212,
				HSL = new HSL
				{
					Hue = 160,
					Saturation = 100,
					Lightness = 75
				},
				ColorFamily = ColorFamily.Cyan
			});


			temp.Add(new WebColor
			{
				ColorName = "PaleTurquoise",
				HexValue = "AFEEEE",
				RedValue = 175,
				GreenValue = 238,
				BlueValue = 238,
				HSL = new HSL
				{
					Hue = 180,
					Saturation = 65,
					Lightness = 81
				},
				ColorFamily = ColorFamily.Cyan
			});


			temp.Add(new WebColor
			{
				ColorName = "LightCyan",
				HexValue = "E0FFFF",
				RedValue = 224,
				GreenValue = 255,
				BlueValue = 255,
				HSL = new HSL
				{
					Hue = 180,
					Saturation = 100,
					Lightness = 94
				},
				ColorFamily = ColorFamily.Cyan
			});

			// this color has a incorrect character in HexValue
			temp.Add(new WebColor
			{
				ColorName = "Indigo",
				HexValue = "4B008H",
				RedValue = 75,
				GreenValue = 0,
				BlueValue = 130,
				HSL = new HSL
				{
					Hue = 275,
					Saturation = 100,
					Lightness = 25
				},
				ColorFamily = ColorFamily.Purple
			});

			temp.Add(new WebColor
			{
				ColorName = "Purple",
				HexValue = "800080",
				RedValue = 128,
				GreenValue = 0,
				BlueValue = 128,
				HSL = new HSL
				{
					Hue = 300,
					Saturation = 100,
					Lightness = 25
				},
				ColorFamily = ColorFamily.Purple
			});

			temp.Add(new WebColor
			{
				ColorName = "BlueViolet",
				HexValue = "8A2BE2",
				RedValue = 138,
				GreenValue = 43,
				BlueValue = 226,
				HSL = new HSL
				{
					Hue = 271,
					Saturation = 76,
					Lightness = 53
				},
				ColorFamily = ColorFamily.Purple
			});

			temp.Add(new WebColor
			{
				ColorName = "Dark-Magenta",
				HexValue = "8B008B",
				RedValue = 139,
				GreenValue = 0,
				BlueValue = 139,
				HSL = new HSL
				{
					Hue = 300,
					Saturation = 100,
					Lightness = 27
				},
				ColorFamily = ColorFamily.Purple
			});


			temp.Add(new WebColor
			{
				ColorName = "MediumPurple",
				HexValue = "9370DB",
				RedValue = 147,
				GreenValue = 112,
				BlueValue = 219,
				HSL = new HSL
				{
					Hue = 260,
					Saturation = 60,
					Lightness = 65
				},
				ColorFamily = ColorFamily.Purple
			});


			temp.Add(new WebColor
			{
				ColorName = "DarkViolet",
				HexValue = "9400D3",
				RedValue = 148,
				GreenValue = 0,
				BlueValue = 211,
				HSL = new HSL
				{
					Hue = 282,
					Saturation = 100,
					Lightness = 41
				},
				ColorFamily = ColorFamily.Purple
			});

			temp.Add(new WebColor
			{
				ColorName = "DarkOrchid",
				HexValue = "9932CC",
				RedValue = 153,
				GreenValue = 50,
				BlueValue = 204,
				HSL = new HSL
				{
					Hue = 280,
					Saturation = 61,
					Lightness = 50
				},
				ColorFamily = ColorFamily.Purple
			});

			temp.Add(new WebColor
			{
				ColorName = "MediumOrchid",
				HexValue = "BA55D3",
				RedValue = 186,
				GreenValue = 85,
				BlueValue = 211,
				HSL = new HSL
				{
					Hue = 288,
					Saturation = 59,
					Lightness = 58
				},
				ColorFamily = ColorFamily.Purple
			});

			temp.Add(new WebColor
			{
				ColorName = "Thistle",
				HexValue = "D8BFD8",
				RedValue = 216,
				GreenValue = 191,
				BlueValue = 216,
				HSL = new HSL
				{
					Hue = 300,
					Saturation = 25,
					Lightness = 80
				},
				ColorFamily = ColorFamily.Purple
			});

			temp.Add(new WebColor
			{
				ColorName = "Orchid",
				HexValue = "DA70D6",
				RedValue = 218,
				GreenValue = 112,
				BlueValue = 214,
				HSL = new HSL
				{
					Hue = 302,
					Saturation = 59,
					Lightness = 65
				},
				ColorFamily = ColorFamily.Purple
			});

			temp.Add(new WebColor
			{
				ColorName = "Plum",
				HexValue = "DDA0DD",
				RedValue = 221,
				GreenValue = 160,
				BlueValue = 221,
				HSL = new HSL
				{
					Hue = 300,
					Saturation = 47,
					Lightness = 75
				},
				ColorFamily = ColorFamily.Purple
			});

			temp.Add(new WebColor
			{
				ColorName = "Lavender",
				HexValue = "E6E6FA",
				RedValue = 230,
				GreenValue = 230,
				BlueValue = 250,
				HSL = new HSL
				{
					Hue = 240,
					Saturation = 67,
					Lightness = 94
				},
				ColorFamily = ColorFamily.Purple
			});

			temp.Add(new WebColor
			{
				ColorName = "Violet",
				HexValue = "EE82EE",
				RedValue = 238,
				GreenValue = 130,
				BlueValue = 238,
				HSL = new HSL
				{
					Hue = 30,
					Saturation = 76,
					Lightness = 72
				},
				ColorFamily = ColorFamily.Purple
			});

			temp.Add(new WebColor
			{
				ColorName = "Fuchsia",
				HexValue = "FF00FF",
				RedValue = 255,
				GreenValue = 0,
				BlueValue = 255,
				HSL = new HSL
				{
					Hue = 30,
					Saturation = 100,
					Lightness = 50
				},
				ColorFamily = ColorFamily.Purple
			});
			temp.Add(new WebColor
			{
				ColorName = "Magenta",
				HexValue = "FF00FF",
				RedValue = 255,
				GreenValue = 0,
				BlueValue = 255,
				HSL = new HSL
				{
					Hue = 30,
					Saturation = 100,
					Lightness = 50
				},
				ColorFamily = ColorFamily.Purple
			});


			temp.Add(new WebColor
			{
				ColorName = "AliceBlue",
				HexValue = "F0F8FF",
				RedValue = 240,
				GreenValue = 248,
				BlueValue = 255,
				HSL = new HSL
				{
					Hue = 208,
					Saturation = 100,
					Lightness = 97
				},
				ColorFamily = ColorFamily.Pale
			});

			temp.Add(new WebColor
			{
				ColorName = "Honeydew",
				HexValue = "F0FFF0",
				RedValue = 240,
				GreenValue = 255,
				BlueValue = 240,
				HSL = new HSL
				{
					Hue = 120,
					Saturation = 100,
					Lightness = 97
				},
				ColorFamily = ColorFamily.Pale
			});


			temp.Add(new WebColor
			{
				ColorName = "Azure",
				HexValue = "F0FFFF",
				RedValue = 240,
				GreenValue = 255,
				BlueValue = 255,
				HSL = new HSL
				{
					Hue = 180,
					Saturation = 100,
					Lightness = 97
				},
				ColorFamily = ColorFamily.Pale
			});


			temp.Add(new WebColor
			{
				ColorName = "Beige",
				HexValue = "F5F5DC",
				RedValue = 245,
				GreenValue = 245,
				BlueValue = 220,
				HSL = new HSL
				{
					Hue = 60,
					Saturation = 56,
					Lightness = 91
				},
				ColorFamily = ColorFamily.Pale
			});

			temp.Add(new WebColor
			{
				ColorName = "WhiteSmoke",
				HexValue = "F5F5F5",
				RedValue = 245,
				GreenValue = 245,
				BlueValue = 245,
				HSL = new HSL
				{
					Hue = 0,
					Saturation = 0,
					Lightness = 96
				},
				ColorFamily = ColorFamily.Pale
			});


			temp.Add(new WebColor
			{
				ColorName = "Mint-Cream",
				HexValue = "F5FFFA",
				RedValue = 245,
				GreenValue = 255,
				BlueValue = 250,
				HSL = new HSL
				{
					Hue = 150,
					Saturation = 100,
					Lightness = 98
				},
				ColorFamily = ColorFamily.Pale
			});

			temp.Add(new WebColor
			{
				ColorName = "GhostWhite",
				HexValue = "F8F8FF",
				RedValue = 248,
				GreenValue = 248,
				BlueValue = 255,
				HSL = new HSL
				{
					Hue = 240,
					Saturation = 100,
					Lightness = 99
				},
				ColorFamily = ColorFamily.Pale
			});


			temp.Add(new WebColor
			{
				ColorName = "AntiqueWhite",
				HexValue = "FAEBD7",
				RedValue = 250,
				GreenValue = 235,
				BlueValue = 205,
				HSL = new HSL
				{
					Hue = 34,
					Saturation = 78,
					Lightness = 90
				},
				ColorFamily = ColorFamily.Pale
			});


			temp.Add(new WebColor
			{
				ColorName = "Linen",
				HexValue = "FAF0E6",
				RedValue = 250,
				GreenValue = 240,
				BlueValue = 230,
				HSL = new HSL
				{
					Hue = 3,
					Saturation = 67,
					Lightness = 94
				},
				ColorFamily = ColorFamily.Pale
			});


			temp.Add(new WebColor
			{
				ColorName = "OldLace",
				HexValue = "FDF5E6",
				RedValue = 253,
				GreenValue = 245,
				BlueValue = 230,
				HSL = new HSL
				{
					Hue = 39,
					Saturation = 85,
					Lightness = 95
				},
				ColorFamily = ColorFamily.Pale
			});


			temp.Add(new WebColor
			{
				ColorName = "MistyRose",
				HexValue = "FFE4E1",
				RedValue = 255,
				GreenValue = 228,
				BlueValue = 225,
				HSL = new HSL
				{
					Hue = 6,
					Saturation = 100,
					Lightness = 94
				},
				ColorFamily = ColorFamily.Pale
			});


			temp.Add(new WebColor
			{
				ColorName = "LavenderBlush",
				HexValue = "FFF0F5",
				RedValue = 255,
				GreenValue = 240,
				BlueValue = 245,
				HSL = new HSL
				{
					Hue = 340,
					Saturation = 100,
					Lightness = 97
				},
				ColorFamily = ColorFamily.Pale
			});


			temp.Add(new WebColor
			{
				ColorName = "Seashell",
				HexValue = "FFF5EE",
				RedValue = 255,
				GreenValue = 245,
				BlueValue = 238,
				HSL = new HSL
				{
					Hue = 25,
					Saturation = 100,
					Lightness = 97
				},
				ColorFamily = ColorFamily.Pale
			});


			temp.Add(new WebColor
			{
				ColorName = "FloralWhite",
				HexValue = "FFFAF0",
				RedValue = 255,
				GreenValue = 250,
				BlueValue = 240,
				HSL = new HSL
				{
					Hue = 40,
					Saturation = 100,
					Lightness = 97
				},
				ColorFamily = ColorFamily.Pale
			});


			temp.Add(new WebColor
			{
				ColorName = "Snow",
				HexValue = "FFFAFA",
				RedValue = 255,
				GreenValue = 250,
				BlueValue = 250,
				HSL = new HSL
				{
					Hue = 0,
					Saturation = 100,
					Lightness = 99
				},
				ColorFamily = ColorFamily.Pale
			});

			temp.Add(new WebColor
			{
				ColorName = "Ivory",
				HexValue = "FFFFF0",
				RedValue = 255,
				GreenValue = 255,
				BlueValue = 240,
				HSL = new HSL
				{
					Hue = 60,
					Saturation = 100,
					Lightness = 97
				},
				ColorFamily = ColorFamily.Pale
			});


			temp.Add(new WebColor
			{
				ColorName = "White",
				HexValue = "FFFFFF",
				RedValue = 255,
				GreenValue = 255,
				BlueValue = 255,
				HSL = new HSL
				{
					Hue = 0,
					Saturation = 0,
					Lightness = 100
				},
				ColorFamily = ColorFamily.Pale
			});


			temp.Add(new WebColor
			{
				ColorName = "Maroon",
				HexValue = "800000",
				RedValue = 128,
				GreenValue = 0,
				BlueValue = 0,
				HSL = new HSL
				{
					Hue = 0,
					Saturation = 100,
					Lightness = 25
				},
				ColorFamily = ColorFamily.Brown
			});


			temp.Add(new WebColor
			{
				ColorName = "SaddleBrown",
				HexValue = "8B4513",
				RedValue = 139,
				GreenValue = 69,
				BlueValue = 19,
				HSL = new HSL
				{
					Hue = 25,
					Saturation = 76,
					Lightness = 31
				},
				ColorFamily = ColorFamily.Brown
			});

			temp.Add(new WebColor
			{
				ColorName = "Sienna",
				HexValue = "A0522D",
				RedValue = 160,
				GreenValue = 82,
				BlueValue = 45,
				HSL = new HSL
				{
					Hue = 19,
					Saturation = 56,
					Lightness = 40
				},
				ColorFamily = ColorFamily.Brown
			});


			temp.Add(new WebColor
			{
				ColorName = "Brown",
				HexValue = "A52A2A",
				RedValue = 165,
				GreenValue = 42,
				BlueValue = 42,
				HSL = new HSL
				{
					Hue = 0,
					Saturation = 59,
					Lightness = 41
				},
				ColorFamily = ColorFamily.Brown
			});


			temp.Add(new WebColor
			{
				ColorName = "Rosy-Brown",
				HexValue = "BC8F8F",
				RedValue = 188,
				GreenValue = 143,
				BlueValue = 143,
				HSL = new HSL
				{
					Hue = 0,
					Saturation = 25,
					Lightness = 65
				},
				ColorFamily = ColorFamily.Brown
			});


			temp.Add(new WebColor
			{
				ColorName = "Peru",
				HexValue = "CD853F",
				RedValue = 205,
				GreenValue = 133,
				BlueValue = 63,
				HSL = new HSL
				{
					Hue = 31,
					Saturation = 59,
					Lightness = 53
				},
				ColorFamily = ColorFamily.Brown
			});


			temp.Add(new WebColor
			{
				ColorName = "Chocolate",
				HexValue = "D2691E",
				RedValue = 21,
				GreenValue = 105,
				BlueValue = 30,
				HSL = new HSL
				{
					Hue = 25,
					Saturation = 75,
					Lightness = 47
				},
				ColorFamily = ColorFamily.Brown
			});

			temp.Add(new WebColor
			{
				ColorName = "Tan",
				HexValue = "D2B48C",
				RedValue = 210,
				GreenValue = 180,
				BlueValue = 140,
				HSL = new HSL
				{
					Hue = 34,
					Saturation = 44,
					Lightness = 69
				},
				ColorFamily = ColorFamily.Brown
			});


			temp.Add(new WebColor
			{
				ColorName = "Goldenrod",
				HexValue = "DAA520",
				RedValue = 218,
				GreenValue = 165,
				BlueValue = 32,
				HSL = new HSL
				{
					Hue = 43,
					Saturation = 74,
					Lightness = 49
				},
				ColorFamily = ColorFamily.Brown
			});

			temp.Add(new WebColor
			{
				ColorName = "BurlyWood",
				HexValue = "DEB887",
				RedValue = 222,
				GreenValue = 184,
				BlueValue = 135,
				HSL = new HSL
				{
					Hue = 34,
					Saturation = 57,
					Lightness = 70
				},
				ColorFamily = ColorFamily.Brown
			});


			temp.Add(new WebColor
			{
				ColorName = "SandyBrown",
				HexValue = "F4A460",
				RedValue = 244,
				GreenValue = 164,
				BlueValue = 96,
				HSL = new HSL
				{
					Hue = 28,
					Saturation = 87,
					Lightness = 67
				},
				ColorFamily = ColorFamily.Brown
			});

			temp.Add(new WebColor
			{
				ColorName = "Wheat",
				HexValue = "F5DEB3",
				RedValue = 245,
				GreenValue = 222,
				BlueValue = 179,
				HSL = new HSL
				{
					Hue = 39,
					Saturation = 77,
					Lightness = 83
				},
				ColorFamily = ColorFamily.Brown
			});


			temp.Add(new WebColor
			{
				ColorName = "NavajoWhite",
				HexValue = "FFDEAD",
				RedValue = 255,
				GreenValue = 222,
				BlueValue = 173,
				HSL = new HSL
				{
					Hue = 36,
					Saturation = 100,
					Lightness = 84
				},
				ColorFamily = ColorFamily.Brown
			});


			temp.Add(new WebColor
			{
				ColorName = "Bisque",
				HexValue = "FFE4C4",
				RedValue = 255,
				GreenValue = 228,
				BlueValue = 196,
				HSL = new HSL
				{
					Hue = 33,
					Saturation = 100,
					Lightness = 88
				},
				ColorFamily = ColorFamily.Brown
			});


			temp.Add(new WebColor
			{
				ColorName = "BlanchedAlmond",
				HexValue = "FFEBCD",
				RedValue = 255,
				GreenValue = 235,
				BlueValue = 205,
				HSL = new HSL
				{
					Hue = 36,
					Saturation = 10,
					Lightness = 90
				},
				ColorFamily = ColorFamily.Brown
			});


			temp.Add(new WebColor
			{
				ColorName = "CornSilk",
				HexValue = "FFF8DC",
				RedValue = 255,
				GreenValue = 248,
				BlueValue = 220,
				HSL = new HSL
				{
					Hue = 48,
					Saturation = 100,
					Lightness = 93
				},
				ColorFamily = ColorFamily.Brown
			});


			temp.Add(new WebColor
			{
				ColorName = "DarkGoldenRod",
				HexValue = "B8860B",
				RedValue = 184,
				GreenValue = 134,
				BlueValue = 11,
				HSL = new HSL
				{
					Hue = 42,
					Saturation = 89,
					Lightness = 38
				},
				ColorFamily = ColorFamily.Brown
			});

			temp.Add(new WebColor
			{
				ColorName = "Black",
				HexValue = "000000",
				RedValue = 0,
				GreenValue = 0,
				BlueValue = 0,
				HSL = new HSL
				{
					Hue = 0,
					Saturation = 0,
					Lightness = 0
				},
				ColorFamily = ColorFamily.Gray
			});

			temp.Add(new WebColor
			{
				ColorName = "DarkSlateGray",
				HexValue = "2F4F4F",
				RedValue = 47,
				GreenValue = 79,
				BlueValue = 79,
				HSL = new HSL
				{
					Hue = 180,
					Saturation = 25,
					Lightness = 25
				},
				ColorFamily = ColorFamily.Gray
			});


			temp.Add(new WebColor
			{
				ColorName = "DimGray",
				HexValue = "696969",
				RedValue = 105,
				GreenValue = 105,
				BlueValue = 105,
				HSL = new HSL
				{
					Hue = 0,
					Saturation = 0,
					Lightness = 41
				},
				ColorFamily = ColorFamily.Gray
			});

			temp.Add(new WebColor
			{
				ColorName = "SlateGray",
				HexValue = "708090",
				RedValue = 112,
				GreenValue = 128,
				BlueValue = 144,
				HSL = new HSL
				{
					Hue = 210,
					Saturation = 13,
					Lightness = 50
				},
				ColorFamily = ColorFamily.Gray
			});


			temp.Add(new WebColor
			{
				ColorName = "LightSlateGray",
				HexValue = "778899",
				RedValue = 119,
				GreenValue = 136,
				BlueValue = 153,
				HSL = new HSL
				{
					Hue = 210,
					Saturation = 14,
					Lightness = 53
				},
				ColorFamily = ColorFamily.Gray
			});

			temp.Add(new WebColor
			{
				ColorName = "Gray",
				HexValue = "808080",
				RedValue = 128,
				GreenValue = 128,
				BlueValue = 128,
				HSL = new HSL
				{
					Hue = 0,
					Saturation = 0,
					Lightness = 50
				},
				ColorFamily = ColorFamily.Gray
			});


			temp.Add(new WebColor
			{
				ColorName = "DarkGray",
				HexValue = "A9A9A9",
				RedValue = 169,
				GreenValue = 169,
				BlueValue = 169,
				HSL = new HSL
				{
					Hue = 0,
					Saturation = 0,
					Lightness = 66
				},
				ColorFamily = ColorFamily.Gray
			});

			temp.Add(new WebColor
			{
				ColorName = "Silver",
				HexValue = "C0C0C0",
				RedValue = 192,
				GreenValue = 192,
				BlueValue = 192,
				HSL = new HSL
				{
					Hue = 0,
					Saturation = 0,
					Lightness = 75
				},
				ColorFamily = ColorFamily.Gray
			});

			temp.Add(new WebColor
			{
				ColorName = "LightGray",
				HexValue = "D3D3D3",
				RedValue = 211,
				GreenValue = 211,
				BlueValue = 211,
				HSL = new HSL
				{
					Hue = 0,
					Saturation = 0,
					Lightness = 83
				},
				ColorFamily = ColorFamily.Gray
			});

			temp.Add(new WebColor
			{
				ColorName = "Gainsboro",
				HexValue = "DCDCDC",
				RedValue = 220,
				GreenValue = 220,
				BlueValue = 220,
				HSL = new HSL
				{
					Hue = 0,
					Saturation = 0,
					Lightness = 86
				},
				ColorFamily = ColorFamily.Gray
			});


			return temp;
		}

	}
}
