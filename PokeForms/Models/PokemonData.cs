using System;
using System.Collections.Generic;

namespace PokeForms
{
	public class Ability
	{
		public string name { get; set; }
		public string resource_uri { get; set; }
	}

	public class Description
	{
		public string name { get; set; }
		public string resource_uri { get; set; }
	}

	public class EggGroup
	{
		public string name { get; set; }
		public string resource_uri { get; set; }
	}

	public class Evolution
	{
		public int level { get; set; }
		public string method { get; set; }
		public string resource_uri { get; set; }
		public string to { get; set; }
	}

	public class Move
	{
		public string learn_type { get; set; }
		public string name { get; set; }
		public string resource_uri { get; set; }
		public int? level { get; set; }
	}

	public class Sprite
	{
		public string name { get; set; }
		public string resource_uri { get; set; }
	}

	public class Type
	{
		public string name { get; set; }
		public string resource_uri { get; set; }
	}

	public class PokemonData
	{
		public List<Ability> abilities { get; set; }
		public int attack { get; set; }
		public int catch_rate { get; set; }
		public string created { get; set; }
		public int defense { get; set; }
		public List<Description> descriptions { get; set; }
		public int egg_cycles { get; set; }
		public List<EggGroup> egg_groups { get; set; }
		public string ev_yield { get; set; }
		public List<Evolution> evolutions { get; set; }
		public int exp { get; set; }
		public string growth_rate { get; set; }
		public int happiness { get; set; }
		public string height { get; set; }
		public int hp { get; set; }
		public string male_female_ratio { get; set; }
		public string modified { get; set; }
		public List<Move> moves { get; set; }
		public string name { get; set; }
		public int national_id { get; set; }
		public int pkdx_id { get; set; }
		public string resource_uri { get; set; }
		public int sp_atk { get; set; }
		public int sp_def { get; set; }
		public string species { get; set; }
		public int speed { get; set; }
		public List<Sprite> sprites { get; set; }
		public int total { get; set; }
		public List<Type> types { get; set; }
		public string weight { get; set; }
	}
}

