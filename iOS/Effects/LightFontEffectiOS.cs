using System;
using System.Linq;
using Foundation;
using PlatformSpecifics.Effects;
using PlatformSpecifics.iOS.Effects;
using UIKit;
using Xamarin.Forms;
using Xamarin.Forms.Platform.iOS;


[assembly: ResolutionGroupName("JimBobBennett")]
[assembly: ExportEffect(typeof(LightFontEffectiOS), "LightFontEffect")]

namespace PlatformSpecifics.iOS.Effects
{
	[Preserve(AllMembers = true)]
    public class LightFontEffectiOS : PlatformEffect
	{
        protected override void OnElementPropertyChanged(System.ComponentModel.PropertyChangedEventArgs args)
        {
            base.OnElementPropertyChanged(args);
        }

		protected override void OnAttached()
		{
			if (Control is UILabel label)
				label.Font = CreateFont(label.Font);
			else if (Control is UITextField textField)
				textField.Font = CreateFont(textField.Font);
		}

		private UIFont CreateFont(UIFont old)
		{
            var effect = Element.Effects.OfType<LightFontEffect>().Single();
            var font = effect.FontType == FontType.Black ?
                             UIFontWeight.Black : UIFontWeight.UltraLight;

			return UIFont.SystemFontOfSize(old.PointSize, 
                                           font);
		}

        protected override void OnDetached()
        {
        }
    }
}
