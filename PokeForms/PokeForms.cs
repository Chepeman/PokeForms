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

			Constants._ColorType.Add("normal", Constants.NormalType);
			Constants._ColorType.Add("fighting", Constants.FightingType);
			Constants._ColorType.Add("flying", Constants.FlyingType);
			Constants._ColorType.Add("poison", Constants.PoisonType);
			Constants._ColorType.Add("ground", Constants.GroundType);
			Constants._ColorType.Add("rock", Constants.RockType);
			Constants._ColorType.Add("bug", Constants.BugType);
			Constants._ColorType.Add("ghost", Constants.GhostType);
			Constants._ColorType.Add("steel", Constants.SteelType);
			Constants._ColorType.Add("fire", Constants.FireType);
			Constants._ColorType.Add("water", Constants.WaterType);
			Constants._ColorType.Add("grass", Constants.GrassType);
			Constants._ColorType.Add("electric", Constants.ElectricType);
			Constants._ColorType.Add("psychic", Constants.PsychicType);
			Constants._ColorType.Add("ice", Constants.IceType);
			Constants._ColorType.Add("dragon", Constants.DragonType);
			Constants._ColorType.Add("dark", Constants.DarkType);
			Constants._ColorType.Add("fairy", Constants.FairyType);

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

