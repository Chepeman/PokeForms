using System;
using Xamarin.Forms;

namespace PokeForms
{
	public class Constants
	{
		public static Color NavigationBarColor {get { return Color.FromHex("#F44336");}}

		public static int KantoMax = 151;
		public static int KantoMin = 1;

		public static int HoennMax = 251;
		public static int HoennMin = 152;

		public static int JohtoMax = 386;
		public static int JohtoMin = 252;
	
		public static int SinnohMax = 493;
		public static int SinnohMin = 387;

		public static int UnovaMax = 649;
		public static int UnovaMin = 494;

		public static int KalosMax = 721;
		public static int KalosMin = 650;

		public static string EndPoint = "http://pokeapi.co/api/v1/";
		public static string EndPointImages = "http://pokeapi.co/media/img/";

		public static Color NormalType = Color.FromHex("A8A878");
		public static Color FightingType = Color.FromHex("C03028");
		public static Color FlyingType = Color.FromHex("A890F0");
		public static Color PoisonType = Color.FromHex("A040A0");
		public static Color GroundType = Color.FromHex("E0C068");
		public static Color RockType = Color.FromHex("B8A038");
		public static Color BugType = Color.FromHex("A8B820");
		public static Color GhostType = Color.FromHex("705898");
		public static Color SteelType = Color.FromHex("B8B8D0");
		public static Color FireType = Color.FromHex("F08030");
		public static Color WaterType = Color.FromHex("6890F0");
		public static Color GrassType = Color.FromHex("78C850");
		public static Color ElectricType = Color.FromHex("F8D030");
		public static Color PsychicType = Color.FromHex("F85888");
		public static Color IceType = Color.FromHex("98D8D8");
		public static Color DragonType = Color.FromHex("7038F8");
		public static Color DarkType = Color.FromHex("705848");
		public static Color FairyType = Color.FromHex("EE99AC");
	}
}

