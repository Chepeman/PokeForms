using System;
using Xamarin.Forms;
using PokeForms.Views;

namespace PokeForms.Pages
{
	public partial class RegionsPage : ContentPage
	{
		Grid RegionsGrid;
		RegionCard KantoCard;
		RegionCard JohtoCard;
		RegionCard HoennCard;
		RegionCard SinnohCard;
		RegionCard UnovaCard;
		RegionCard KalosCard;


		public void Layout(){
			TapGestureRecognizer tapGestureRecognizer;
			RegionsGrid = new Grid ();

			KantoCard = new RegionCard (150) {
				Source = ImageSource.FromFile("Kanto.png"),
				RegionTitle = "Kanto"
			};

			tapGestureRecognizer = new TapGestureRecognizer
			{
				Command = new Command(() =>
				{
					HandleTap(0);
				}),
				NumberOfTapsRequired = 1,
			};
			KantoCard.GestureRecognizers.Add(tapGestureRecognizer);

			JohtoCard = new RegionCard (150) {
				Source = ImageSource.FromFile("Johto.png"),
				RegionTitle = "Johto"
			};

			tapGestureRecognizer = new TapGestureRecognizer();
			tapGestureRecognizer.Tapped += (s, e) => {
				HandleTap(1);
			};
			JohtoCard.GestureRecognizers.Add(tapGestureRecognizer);

			HoennCard = new RegionCard (150) {
				Source = ImageSource.FromFile("Hoenn.png"),
				RegionTitle = "Hoenn"
			};

			tapGestureRecognizer = new TapGestureRecognizer();
			tapGestureRecognizer.Tapped += (s, e) => {
				HandleTap(2);
			};
			HoennCard.GestureRecognizers.Add(tapGestureRecognizer);

			SinnohCard = new RegionCard (150) {
				Source = ImageSource.FromFile("Sinnoh.png"),
				RegionTitle = "Sinnoh"
			};

			tapGestureRecognizer = new TapGestureRecognizer();
			tapGestureRecognizer.Tapped += (s, e) => {
				HandleTap(3);
			};
			SinnohCard.GestureRecognizers.Add(tapGestureRecognizer);


			UnovaCard = new RegionCard (150) {
				Source = ImageSource.FromFile("Unova.png"),
				RegionTitle = "Unova"
			};

			tapGestureRecognizer = new TapGestureRecognizer();
			tapGestureRecognizer.Tapped += (s, e) => {
				HandleTap(4);
			};
			UnovaCard.GestureRecognizers.Add(tapGestureRecognizer);


			KalosCard = new RegionCard (150) {
				Source = ImageSource.FromFile("Kalos.png"),
				RegionTitle = "Kalos"
			};

			tapGestureRecognizer = new TapGestureRecognizer();
			tapGestureRecognizer.Tapped += (s, e) => {
				HandleTap(5);
			};
			KalosCard.GestureRecognizers.Add(tapGestureRecognizer);
					
					
			var RegionsColumn1 = new StackLayout () {
				HorizontalOptions = LayoutOptions.StartAndExpand,
				VerticalOptions = LayoutOptions.FillAndExpand,
				Padding = new Thickness(20,10,20,10),
				Children = {
					KantoCard,
					HoennCard,
					UnovaCard
				},
			};

			var RegionsColumn2 = new StackLayout () {
				HorizontalOptions = LayoutOptions.EndAndExpand,
				VerticalOptions = LayoutOptions.FillAndExpand,
				Padding = new Thickness(20,10,20,10),
				Children = {
					JohtoCard,
					SinnohCard,
					KalosCard
				},
			};

			RegionsGrid.Children.Add (RegionsColumn1, 0, 0);
			RegionsGrid.Children.Add (RegionsColumn2, 1, 0);
			Content = RegionsGrid;
		}
	}
}

