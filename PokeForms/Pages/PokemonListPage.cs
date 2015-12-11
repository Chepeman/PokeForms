using System;
using Xamarin.Forms;
using PokeForms.Views;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace PokeForms.Pages
{
	public partial class PokemonListPage : ContentPage
	{
		Dictionary<string, Color> _ColorType = new Dictionary<string, Color>();
		int i = 0,j = 0, PokeCounter = 1;
		bool isLoading = false;
		int PokemonMax, PokemonMin;

		public PokemonListPage (int PokemonMax, int PokemonMin) 
		{
			this.PokemonMax = PokemonMax;
			this.PokemonMin = PokemonMin;
			PokeCounter = this.PokemonMin;
			this.SizeChanged += PokemonListPage_SizeChanged;
		}

		void PokemonListPage_SizeChanged (object sender, EventArgs e)
		{
			Layout ();
			LoadPokemon (PokemonMin, PokemonMin + 18);
			this.SizeChanged -= PokemonListPage_SizeChanged;
		}

		protected override async void OnAppearing ()
		{
			base.OnAppearing ();
			_ColorType.Add ("normal", Constants.NormalType);
			_ColorType.Add ("fighting", Constants.FightingType);
			_ColorType.Add ("flying", Constants.FlyingType);
			_ColorType.Add ("poison", Constants.PoisonType);
			_ColorType.Add ("ground", Constants.GroundType);
			_ColorType.Add ("rock", Constants.RockType);
			_ColorType.Add ("bug", Constants.BugType);
			_ColorType.Add ("ghost", Constants.GhostType);
			_ColorType.Add ("steel", Constants.SteelType);
			_ColorType.Add ("fire", Constants.FireType);
			_ColorType.Add ("water", Constants.WaterType);
			_ColorType.Add ("grass", Constants.GrassType);
			_ColorType.Add ("electric", Constants.ElectricType);
			_ColorType.Add ("psychic", Constants.PsychicType);
			_ColorType.Add ("ice", Constants.IceType);
			_ColorType.Add ("dragon", Constants.DragonType);
			_ColorType.Add ("dark", Constants.DarkType);
			_ColorType.Add ("fairy", Constants.FairyType);


		}

		public async Task LoadPokemon (int begin, int end)
		{
			if (isLoading == true)
				return;
			App.Instance.HudManager.ShowHud ();
			isLoading = true;
			for (int k = begin; k <= end; k++) {
				var PokemonData = await PokeForms.Helpers.PokeApiData.Default.GetPokemonData (k);
				PokemonView PokemonView;

				if (PokemonData.types.Count > 1) {
					PokemonView = new PokemonView (100, _ColorType [PokemonData.types [0].name], _ColorType [PokemonData.types [1].name]);
				} else {
					PokemonView = new PokemonView (100, _ColorType [PokemonData.types [0].name], Color.Transparent);
				}

				PokemonView.Text = PokemonData.name;
				Console.WriteLine (PokemonData.name + " " + PokemonData.types [0].name + " " + k);
				PokemonView.Source = Constants.EndPointImages + PokeCounter + ".png";

				_PokemonGrid.Children.Add (PokemonView, j, i);

				j++;
				PokeCounter++;
				if (j > 2) {
					i++;
					j = 0;
				}

			}

			PokeCounter = end + 1;
			isLoading = false;
			App.Instance.HudManager.HideHud ();
		}
	}
}

