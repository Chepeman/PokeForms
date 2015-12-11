using System;
using Xamarin.Forms;
using PokeForms.ViewModels;

namespace PokeForms.Pages
{
	public partial class RegionsPage : ContentPage
	{
		private RegionsViewModel ViewModel
		{
			get
			{
				return BindingContext as RegionsViewModel;
			}
		}

		public RegionsPage ()
		{
			var vieModel = new RegionsViewModel (this);
			BindingContext = ViewModel;
			Title = "Choose Your Region";
			BackgroundColor = Color.FromHex ("eaeaea");
			Layout ();
		}

		protected override async void OnAppearing ()
		{
			base.OnAppearing ();
			var result = await PokeForms.Helpers.PokeApiData.Default.GetPokemonData (1);
		}

		protected async void HandleTap(int SelectedRegion)
		{
			PokemonListPage Page;
			switch (SelectedRegion) {
			case 0:
				Page = new PokemonListPage (Constants.KantoMax, Constants.KantoMin);
				break;
			case 1:
				Page = new PokemonListPage (Constants.JohtoMax, Constants.JohtoMin);
				break;
			case 2:
				Page = new PokemonListPage (Constants.HoennMax, Constants.HoennMin);
				break;
			case 3:
				Page = new PokemonListPage (Constants.SinnohMax, Constants.SinnohMin);
				break;
			case 4:
				Page = new PokemonListPage (Constants.UnovaMax, Constants.UnovaMax);
				break;
			case 5:
				Page = new PokemonListPage (Constants.KalosMax, Constants.KalosMin);
				break;
			default:
				return;
				break;
			};
			await this.Navigation.PushAsync (Page);

		}
	}
}

