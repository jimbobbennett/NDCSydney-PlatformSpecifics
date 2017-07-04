using Xamarin.Forms;

namespace PlatformSpecifics.Effects
{
    public class LightFontEffect : RoutingEffect
    {
        public FontType FontType { get; set; }

        public LightFontEffect()
            : base("JimBobBennett.LightFontEffect")
        {
        }
    }
}
