using System.ComponentModel;
using PlatformSpecifics.Controls;
using PlatformSpecifics.iOS.Renderers;
using UIKit;
using Xamarin.Forms;
using Xamarin.Forms.Platform.iOS;

[assembly: ExportRenderer(typeof(Button),
                         typeof(LightButtonRenderer))]

namespace PlatformSpecifics.iOS.Renderers
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
                    Control.TitleLabel.Font = UIFont.SystemFontOfSize(Control.Font.PointSize,
                                                                      UIFontWeight.UltraLight);
                    break;
                case FontType.Black:
                    Control.TitleLabel.Font = UIFont.SystemFontOfSize(Control.Font.PointSize,
                                                                      UIFontWeight.Black);
                    break;
            }
        }
    }
}
