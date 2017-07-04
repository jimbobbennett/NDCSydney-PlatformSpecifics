using Xamarin.Forms;

namespace PlatformSpecifics.Controls
{
    public static class AttachedProperties
    {
        public static BindableProperty FontTypeProperty =
            BindableProperty.CreateAttached("FontType",
                                            typeof(FontType),
                                            typeof(Element),
                                            FontType.Light,
                                            BindingMode.OneWay);

        public static FontType GetFontType(BindableObject target)
        {
            return (FontType)target.GetValue(FontTypeProperty);
        }
    }
}
