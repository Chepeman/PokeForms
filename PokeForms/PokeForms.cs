using System;

using Xamarin.Forms;
using PokeForms.Dependencies;

namespace PokeForms
{
	public class App : Application
	{
		public static App Instance { get; private set;}

		public IHudManager HudManager { get; private set; }

		public App ()
		{
			Instance = this;

			HudManager = DependencyService.Get<IHudManager> ();

			var page = new NavigationPage(new Pages.RegionsPage ());
			NavigationPage.SetHasNavigationBar(page, true);
			page.BarBackgroundColor = Constants.NavigationBarColor;
			page.BarTextColor = Color.White;
			MainPage = page;
		}

		protected override void OnStart ()
		{
			// Handle when your app starts
		}

		protected override void OnSleep ()
		{
			// Handle when your app sleeps
		}

		protected override void OnResume ()
		{
			// Handle when your app resumes
		}
	}
}

