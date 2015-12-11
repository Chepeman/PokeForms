using System;
using BigTed;
using PokeForms.Dependencies;
using PokeForms.iOS.Dependencies;

[assembly: Xamarin.Forms.Dependency (typeof (HudManager_iOS))]
namespace PokeForms.iOS.Dependencies
{
    public class HudManager_iOS : IHudManager
    {
        #region IHudManager implementation

        public void ShowHud()
        {
            Xamarin.Forms.Device.BeginInvokeOnMainThread(() =>
                {
                    BTProgressHUD.Show(maskType: ProgressHUD.MaskType.Black);
                });
        }

        public void HideHud()
        {
            Xamarin.Forms.Device.BeginInvokeOnMainThread(() =>
                {
                    BTProgressHUD.Dismiss();
                });
        }

        #endregion
    }
}

