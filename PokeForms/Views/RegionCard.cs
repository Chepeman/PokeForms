using System;
using Xamarin.Forms;

namespace PokeForms.Views
{
	public class RegionCard : Grid
	{
		protected Image _Image;
		protected Label _RegionName;
		protected StackLayout _InsideStack;
		protected ContentView _TitleView;
		protected ContentView _ShadowView;

		public RegionCard (int imageSize)
		{
			_Image = new Image () {
				WidthRequest = imageSize,
				HeightRequest = imageSize,
				Aspect = Aspect.AspectFill
			};

			_RegionName = new Label () {
				HorizontalOptions = LayoutOptions.Center,
				VerticalOptions = LayoutOptions.Center,
				HorizontalTextAlignment = TextAlignment.Start,
				TextColor = Color.Black,
			};

			_TitleView = new ContentView () {
				BackgroundColor = Color.White,
				Padding = new Thickness (10,0,0,0),
				Content = _RegionName,
			};

			_InsideStack = new StackLayout () {
				Spacing = 0,
				HorizontalOptions = LayoutOptions.FillAndExpand,
				VerticalOptions = LayoutOptions.FillAndExpand,
				BackgroundColor = Color.Transparent,
				Padding = new Thickness (1, 1, 1, 1),
			};

			_ShadowView = new ContentView () {
				BackgroundColor = Color.Black,
				Opacity = 0.1,
				HorizontalOptions = LayoutOptions.FillAndExpand,
				VerticalOptions = LayoutOptions.FillAndExpand,
			};

			_InsideStack.Children.Add (_Image);
			_InsideStack.Children.Add (_TitleView);

			Children.Add (_ShadowView, 0, 0);
			Children.Add (_InsideStack,0, 0);
			//
			//Opacity = 1;
			//BackgroundColor = Color.Black;

		}

		public ImageSource Source
		{
			set
			{
				_Image.Source = value;
			}
		}

		public string RegionTitle
		{
			set
			{
				_RegionName.Text = value;
			}
		}
	}
}

