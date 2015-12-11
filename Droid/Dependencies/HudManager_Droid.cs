using System;
using AndroidHUD;
using PokeForms.Droid.Dependencies;
using PokeForms.Dependencies;

[assembly: Xamarin.Forms.Dependency (typeof (HudManager_Droid))]
namespace PokeForms.Droid.Dependencies
{
    public class HudManager_Droid : IHudManager
    {
        #region IHudManager implementation

        public void ShowHud()
        {
            Xamarin.Forms.Device.BeginInvokeOnMainThread(() =>
                {
                    AndHUD.Shared.Show(context: Xamarin.Forms.Forms.Context, maskType: MaskType.Black);
                });
        }

        public void HideHud()
        {
            Xamarin.Forms.Device.BeginInvokeOnMainThread(() =>
                {
                    AndHUD.Shared.Dismiss(context: Xamarin.Forms.Forms.Context);
                });
        }

        #endregion
    }
}

