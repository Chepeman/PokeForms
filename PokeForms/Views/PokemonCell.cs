using System;
using Xamarin.Forms;
using PokeForms.ViewModels;
using System.Collections.Generic;

namespace PokeForms
{
	public class PokemonCell : ViewCell
	{
		StackLayout _typesStack;
		Image _pokemonImage;

		String weak, strong, zero = string.Empty;
		Label _strongAgainstTypesLabel, _weakAgainstTypesLabel, _zeroAgainstTypesLabel;

		public PokemonCell()
		{
			_typesStack = new StackLayout();
			_typesStack.WidthRequest = 30;
			_typesStack.Spacing = 0;
			_typesStack.VerticalOptions = LayoutOptions.FillAndExpand;

			_pokemonImage = new Image();
			_pokemonImage.WidthRequest = 100;
			_pokemonImage.HeightRequest = 100;
			_pokemonImage.SetBinding(Image.SourceProperty, nameof(PokemonVM.PokemonImageUrl));

			var informationStack = new StackLayout();
			informationStack.Padding = new Thickness(0, 5, 0, 5);

			var pokemonName = new Label();
			pokemonName.FontSize = 20;
			pokemonName.FontAttributes = FontAttributes.Bold;
			pokemonName.VerticalOptions = LayoutOptions.Start;
			pokemonName.SetBinding(Label.TextProperty, nameof(PokemonVM.PokemonName));

			var strongAgainstLabel = new Label();
			strongAgainstLabel.FontSize = 16;
			strongAgainstLabel.FontAttributes = FontAttributes.Bold;
			strongAgainstLabel.VerticalOptions = LayoutOptions.Start;
			strongAgainstLabel.Text = "Very Effective Against";

			_strongAgainstTypesLabel = new Label();
			_strongAgainstTypesLabel.FontSize = 16;
			_strongAgainstTypesLabel.VerticalOptions = LayoutOptions.Start;
			_strongAgainstTypesLabel.Text = strong;

			var weakAgainstLabel = new Label();
			weakAgainstLabel.FontSize = 16;
			weakAgainstLabel.FontAttributes = FontAttributes.Bold;
			weakAgainstLabel.VerticalOptions = LayoutOptions.Start;
			weakAgainstLabel.Text = "Less Effective Against";

			_weakAgainstTypesLabel = new Label();
			_weakAgainstTypesLabel.FontSize = 16;
			_weakAgainstTypesLabel.VerticalOptions = LayoutOptions.Start;
			_weakAgainstTypesLabel.Text = weak;

			var zeroAgainstLabel = new Label();
			zeroAgainstLabel.FontSize = 16;
			zeroAgainstLabel.FontAttributes = FontAttributes.Bold;
			zeroAgainstLabel.VerticalOptions = LayoutOptions.Start;
			zeroAgainstLabel.Text = "Zero Effective Against";

			_zeroAgainstTypesLabel = new Label();
			_zeroAgainstTypesLabel.FontSize = 16;
			_zeroAgainstTypesLabel.VerticalOptions = LayoutOptions.Start;
			_zeroAgainstTypesLabel.Text = zero;

			informationStack.Children.Add(pokemonName);
			informationStack.Children.Add(strongAgainstLabel);
			informationStack.Children.Add(_strongAgainstTypesLabel);
			informationStack.Children.Add(weakAgainstLabel);
			informationStack.Children.Add(_weakAgainstTypesLabel);
			informationStack.Children.Add(zeroAgainstLabel);
			informationStack.Children.Add(_zeroAgainstTypesLabel);


			var contentStack = new StackLayout();
			contentStack.Spacing = 10;
			contentStack.Padding = new Thickness(0, 0, 0, 0);
			contentStack.Orientation = StackOrientation.Horizontal;
			contentStack.Children.Add(_typesStack);
			contentStack.Children.Add(_pokemonImage);
			contentStack.Children.Add(informationStack);

			this.View = contentStack;
			this.View.HeightRequest = 250;

		}

		protected override void OnBindingContextChanged()
		{
			base.OnBindingContextChanged();

			var bindedObject = this.BindingContext as PokemonVM;
			if (bindedObject != null)
			{
				foreach (var type in bindedObject.PokemonTypes)
				{
					var typeView = new BoxView();
					typeView.BackgroundColor = Constants._ColorType[type.name];
					typeView.VerticalOptions = LayoutOptions.FillAndExpand;
					_typesStack.Children.Add(typeView);
				}

				ProcessTypes(bindedObject.PokemonTypes);
				_strongAgainstTypesLabel.Text = strong;
				_weakAgainstTypesLabel.Text = weak;
				_zeroAgainstTypesLabel.Text = zero;
			}
		}

		void ProcessTypes(List<Type> types)
		{
			HashSet<string> _zero = new HashSet<string>();
			HashSet<string> _strong = new HashSet<string>();
			HashSet<string> _weak = new HashSet<string>();
			foreach(var type in types) {
				switch (type.name)
				{
					case "normal":
						_weak.Add("rock");
						_weak.Add("steel");
						_zero.Add("ghost");
						break;
					case "fighting":
						_strong.Add("normal");
						_strong.Add("ice");
						_strong.Add("rock");
						_strong.Add("steel");
						_strong.Add("dark");
						_weak.Add("poison");
						_weak.Add("flying");
						_weak.Add("psychic");
						_weak.Add("bug");
						_weak.Add("fairy");
						_zero.Add("ghost");
						break;
					case "flying":
						_strong.Add("grass");
						_strong.Add("fighting");
						_strong.Add("bug");
						_weak.Add("electric");
						_weak.Add("rock");
						_weak.Add("steel");
						_zero.Add("ghost");
						break;
					case "poison":
						_strong.Add("grass");
						_strong.Add("fairy");
						_weak.Add("poison");
						_weak.Add("ground");
						_weak.Add("rock");
						_weak.Add("ghost");
						_zero.Add("steel");
						break;
					case "ground":
						_strong.Add("fire");
						_strong.Add("electric");
						_strong.Add("poison");
						_strong.Add("rock");
						_strong.Add("steel");
						_weak.Add("grass");
						_weak.Add("bug");
						_zero.Add("flying");
						break;
					case "rock":
						_strong.Add("fire");
						_strong.Add("ice");
						_strong.Add("flying");
						_strong.Add("bug");
						_weak.Add("fighting");
						_weak.Add("ground");
						_weak.Add("steel");
						break;
					case "bug":
						_strong.Add("grass");
						_strong.Add("psychic");
						_strong.Add("dark");
						_weak.Add("fire");
						_weak.Add("fighting");
						_weak.Add("poison");
						_weak.Add("flying");
						_weak.Add("ghost");
						_weak.Add("steel");
						_weak.Add("fairy");
						break;
					case "ghost":
						_strong.Add("psychic");
						_strong.Add("ghost");
						_weak.Add("dark");
						_zero.Add("normal");
						break;
					case "steel":
						_strong.Add("ice");
						_strong.Add("fairy");
						_weak.Add("fire");
						_weak.Add("water");
						_weak.Add("steel");
						_weak.Add("electric");
						break;
					case "fire":
						_strong.Add("grass");
						_strong.Add("ice");
						_strong.Add("bug");
						_strong.Add("steel");
						_weak.Add("fire");
						_weak.Add("water");
						_weak.Add("rock");
						_weak.Add("dragon");
						break;
					case "water":
						_strong.Add("fire");
						_strong.Add("ground");
						_strong.Add("rock");
						_weak.Add("water");
						_weak.Add("grass");
						break;
					case "grass":
						_strong.Add("water");
						_strong.Add("ground");
						_strong.Add("rock");
						_weak.Add("grass");
						_weak.Add("fire");
						_weak.Add("flying");
						_weak.Add("bug");
						_weak.Add("dragon");
						_weak.Add("steel");
						break;
					case "electric":
						_strong.Add("water");
						_strong.Add("flying");
						_weak.Add("electric");
						_weak.Add("grass");
						_weak.Add("dragon");
						_zero.Add("ground");
						break;
					case "psychic":
						_strong.Add("fighting");
						_strong.Add("poison");
						_weak.Add("psychic");
						_weak.Add("steel");
						_zero.Add("dark");
						break;
					case "ice":
						_strong.Add("grass");
						_strong.Add("ground");
						_strong.Add("flying");
						_strong.Add("dragon");
						_weak.Add("ice");
						_weak.Add("fire");
						_weak.Add("water");
						_weak.Add("steel");
						break;
					case "dragon":
						_strong.Add("dragon");
						_weak.Add("steel");
						_zero.Add("fairy");
						break;
					case "dark":
						_strong.Add("psychic");
						_strong.Add("ghost");
						_weak.Add("fighting");
						_weak.Add("dark");
						_weak.Add("fairy");
						_zero.Add("steel");
						break;
					case "fairy":
						_strong.Add("fighting");
						_strong.Add("dragon");
						_strong.Add("dark");
						_weak.Add("poison");
						_weak.Add("fire");
						_weak.Add("steel");
						break;
				}
			}

			zero = String.Join(" ", _zero);
			weak = String.Join(" ", _weak);
			strong = String.Join(" ", _strong);
		}
	}
}

