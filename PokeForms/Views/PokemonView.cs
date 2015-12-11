using System;
using ImageCircle.Forms.Plugin.Abstractions;
using Xamarin.Forms;

namespace PokeForms.Views
{
	public class PokemonView : StackLayout
	{
		protected CircleImage _Image;
		protected CircleImage _ImageAlternative;
		protected Label _Text;


		public PokemonView (int size, Color borderColor, Color SecundaryBorderColor)
		{
			Grid ImagesGrid = new Grid ();

			_Image = new CircleImage () 
			{
				BorderThickness = 6,
				HeightRequest = size,
				WidthRequest = size,
				Aspect = Aspect.AspectFit,
				HorizontalOptions = LayoutOptions.Center,
				BorderColor = borderColor
				
			};

			_ImageAlternative = new CircleImage () 
			{
				BorderThickness = 4,
				HeightRequest = size - 3,
				WidthRequest = size - 3,
				Aspect = Aspect.AspectFill,
				HorizontalOptions = LayoutOptions.Center,
				BorderColor = SecundaryBorderColor
			};
				
			_Text = new Label () {
				TextColor = Color.Black,
				FontSize = 15,
				FontAttributes = FontAttributes.Bold,
				HorizontalTextAlignment = TextAlignment.Center,
			};

			//Padding = new Thickness (0, 10, 0, 0);
			ImagesGrid.Children.Add (_Image,0,0);
			ImagesGrid.Children.Add (_ImageAlternative,0,0);

			Children.Add (ImagesGrid);
			Children.Add (_Text);
			VerticalOptions = LayoutOptions.Start;
		}
			

		public string Text
		{
			set
			{
				_Text.Text = value;
			}
		}

		public ImageSource Source
		{
			set{
				_Image.Source = value;
			}
		}
	}
}

