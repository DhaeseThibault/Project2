using Xamarin.Forms;
using Xamarin.Forms.Platform.Android;
using BikeGates;
using BikeGates.Droid;
using Android.Graphics;
using Android.Graphics.Drawables;
using BikeGates.Models;

#pragma warning disable CS0612 // Type or member is obsolete
[assembly: ExportRenderer(typeof(CustomSlider), typeof(CustomSliderRenderer))]
#pragma warning restore CS0612 // Type or member is obsolete
namespace BikeGates.Droid
{
    [System.Obsolete]
    public class CustomSliderRenderer : SliderRenderer
    {
        protected override void
                 OnElementChanged(ElementChangedEventArgs<Slider> e)
        {
            base.OnElementChanged(e);

            if (e.NewElement != null)
            {
                // Set custom drawable resource
                Control.SetProgressDrawableTiled(
                Resources.GetDrawable(
                Resource.Drawable.custom_progressbar_style,
                (this.Context).Theme));

                //Control.Thumb = new ColorDrawable(Android.Graphics.Color.Yellow);
                //Control.Thumb.SetColorFilter(Xamarin.Forms.Color.FromHex("#FEB95A").ToAndroid(), PorterDuff.Mode.SrcIn);

            }

        }
    }
}