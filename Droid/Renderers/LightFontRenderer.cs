using System.ComponentModel;
using Android.Graphics;
using PlatformSpecifics.Controls;
using PlatformSpecifics.Droid.Renderers;
using Xamarin.Forms;
using Xamarin.Forms.Platform.Android;

[assembly: ExportRenderer(typeof(Button), typeof(LightButtonRenderer))]

namespace PlatformSpecifics.Droid.Renderers
{
	public class LightButtonRenderer : ButtonRenderer
	{
		protected override void OnElementChanged(ElementChangedEventArgs<Button> e)
		{
			base.OnElementChanged(e);
			SetFont();
		}

		protected override void OnElementPropertyChanged(object sender, PropertyChangedEventArgs e)
		{
			base.OnElementPropertyChanged(sender, e);
			SetFont();
		}

		private void SetFont()
		{
			if (Element == null) return;

			switch ((FontType)Element.GetValue(AttachedProperties.FontTypeProperty))
			{
				case FontType.Light:
					Control.SetTypeface(Typeface.Create("sans-serif-light", TypefaceStyle.Normal),
													TypefaceStyle.Normal);
					break;
				case FontType.Black:
					Control.SetTypeface(Typeface.Create("sans-serif-black", TypefaceStyle.Normal),
													TypefaceStyle.Normal);
					break;
			}
		}
	}
}