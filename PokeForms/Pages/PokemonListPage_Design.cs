using System;
using Xamarin.Forms;

namespace PokeForms.Pages
{
	

	public partial class PokemonListPage : ContentPage
	{
		protected ListView _pokemonList;


		public void Layout(){

			var template = new DataTemplate(typeof(PokemonCell));

			_pokemonList = new ListView();
			_pokemonList.ItemsSource = PokemonList;
			_pokemonList.ItemTemplate = template;
			_pokemonList.RowHeight = 250;
			_pokemonList.ItemAppearing += _pokemonList_ItemAppearing;
			_pokemonList.SeparatorVisibility = SeparatorVisibility.Default;
			Content = _pokemonList;
		}



		async void _pokemonList_ItemAppearing(object sender, ItemVisibilityEventArgs e)
		{
			if (PokemonList != null &&  e.Item == PokemonList[PokemonList.Count - 1])
       		{
				if (PokeCounter >= PokemonMax)
					return;
				int counterDiff = PokemonMax - PokeCounter;
				if (counterDiff < 9)
					await LoadPokemon(PokeCounter, PokeCounter + counterDiff);
				else
					await LoadPokemon(PokeCounter, PokeCounter + 9);
			}
		}
	}
}

