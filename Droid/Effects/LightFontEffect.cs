using System.Linq;
using Android.Graphics;
using Android.Runtime;
using Android.Widget;
using PlatformSpecifics.Droid.Effects;
using PlatformSpecifics.Effects;
using Xamarin.Forms;
using Xamarin.Forms.Platform.Android;

[assembly: ResolutionGroupName("JimBobBennett")]
[assembly: ExportEffect(typeof(LightFontEffectDroid), "LightFontEffect")]

namespace PlatformSpecifics.Droid.Effects
{
	[Preserve(AllMembers = true)]
	public class LightFontEffectDroid : PlatformEffect
	{
		protected override void OnAttached()
		{
			if (Control is TextView text)
			{
				var effect = Element.Effects.OfType<LightFontEffect>()
									.First();

				switch (effect.FontType)
				{
					case FontType.Light:
						text.SetTypeface(Typeface.Create("sans-serif-light", TypefaceStyle.Normal),
									 TypefaceStyle.Normal);
						break;
					case FontType.Black:
						text.SetTypeface(Typeface.Create("sans-serif-black", TypefaceStyle.Normal),
									 TypefaceStyle.Normal);
						break;
				}
			}
		}

		protected override void OnDetached()
		{
		}
	}
}