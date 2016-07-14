using System;
using Xamarin.Forms;
using PokeForms.Views;
using System.Collections.Generic;
using System.Threading.Tasks;
using PokeForms.ViewModels;
using System.Collections.ObjectModel;

namespace PokeForms.Pages
{
	public partial class PokemonListPage : ContentPage
	{
		int i = 0,j = 0, PokeCounter = 1;
		bool isLoading = false;
		int PokemonMax, PokemonMin;

		ObservableCollection<PokemonVM> PokemonList= new ObservableCollection<PokemonVM>();

		private PokemonVM ViewModel
		{
			get
			{
				return BindingContext as PokemonVM;
			}
		}

		public PokemonListPage (int PokemonMax, int PokemonMin) 
		{
			this.PokemonMax = PokemonMax;
			this.PokemonMin = PokemonMin;
			PokeCounter = this.PokemonMin;
			Layout();
			LoadPokemon(PokemonMin, PokemonMin + 18);
		}

		protected override async void OnAppearing ()
		{
			base.OnAppearing ();
		}

		public async Task LoadPokemon (int begin, int end)
		{
			if (isLoading == true)
				return;
			//App.Instance.HudManager.ShowHud ();
			isLoading = true;
			for (int k = begin; k <= end; k++) {
				var pokemonData = await PokeForms.Helpers.PokeApiData.Default.GetPokemonData (k);
				var pokemonVM = new PokemonVM(pokemonData);
				Device.BeginInvokeOnMainThread(() =>
				{
					PokemonList.Add(pokemonVM);
				});
			}
			PokeCounter = PokemonList.Count;
			isLoading = false;
			//App.Instance.HudManager.HideHud ();
		}

		static string UppercaseFirst(string s)
		{
			if (string.IsNullOrEmpty(s))
			{
				return string.Empty;
			}
			char[] a = s.ToCharArray();
			a[0] = char.ToUpper(a[0]);
			return new string(a);
		}
	}
}

