using System;
using Xamarin.Forms;

namespace PokeForms.Pages
{
	

	public partial class PokemonListPage : ContentPage
	{
		protected Grid _PokemonGrid;
		protected ScrollView _ScrollView;


		public void Layout(){
			_PokemonGrid = new Grid () {
				HorizontalOptions = LayoutOptions.FillAndExpand,
				Padding = new Thickness(10,10,10,0),
				RowSpacing = 0,
				ColumnSpacing = 0,
			};

			_ScrollView = new ScrollView () {
				BackgroundColor = Color.Transparent,
				//VerticalOptions = LayoutOptions.FillAndExpand,
				HorizontalOptions = LayoutOptions.FillAndExpand,
				Content = _PokemonGrid,
				IsClippedToBounds = true,
			};

			_ScrollView.Scrolled += async (sender, e) => {
				var difference = _PokemonGrid.Height - _ScrollView.Height;

				if(((int)difference) == ((int)e.ScrollY)){
					if(PokeCounter >= PokemonMax) 
						return;
					int counterDiff = PokemonMax - PokeCounter;
					if(counterDiff < 9)
						await LoadPokemon(PokeCounter, PokeCounter + counterDiff);
					else
						await LoadPokemon(PokeCounter, PokeCounter + 9);
				}
			};

			Content = _ScrollView;

		}

	}
}

