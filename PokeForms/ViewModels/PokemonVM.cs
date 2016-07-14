using System;
using Xamarin.Forms;
using System.Collections.Generic;

namespace PokeForms.ViewModels
{
	public class PokemonVM : BaseViewModel
	{
		PokemonData PokemonData;
		public PokemonVM(PokemonData pokemonData)
		{
			this.PokemonData = pokemonData;
		}


		public ImageSource PokemonImageUrl
		{
			get 
			{
				return Constants.EndPointImages + this.PokemonData.national_id + ".png";
			}
		}

		public string PokemonName
		{
			get
			{
				return PokemonData.name;
			}
		}

		public List<Type> PokemonTypes
		{
			get
			{
				return PokemonData.types;
			}
		}
	}
}

