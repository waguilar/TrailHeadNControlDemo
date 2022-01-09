using Android.Content;
using TrailHeadNControlDemo.Controls;
using TrailHeadNControlDemo.Droid.Renderer;
using Xamarin.Forms;
using Xamarin.Forms.Platform.Android;

[assembly: ExportRenderer(typeof(MyCustomCircularButton), typeof(MyCustomCircularButtonRenderer))]
namespace TrailHeadNControlDemo.Droid.Renderer
{
    class MyCustomCircularButtonRenderer : ButtonRenderer
    {
        public MyCustomCircularButtonRenderer(Context context) : base(context)
        {
        }

        protected override void OnElementChanged(ElementChangedEventArgs<Xamarin.Forms.Button> e)
        {
            base.OnElementChanged(e);

            if (Control != null)
            {
                //Control.SetBackgroundDrawable(Control.Context.GetDrawable(Resource.Drawable.custom_renderer_shape)); //deprecated!
                //Control.SetBackground(Control.Context.GetDrawable(Resource.Drawable.custom_renderer_shape)); //Not recomended as it is not fully supported
                Control.Background = Control.Context.GetDrawable(Resource.Drawable.custom_renderer_shape);
            }
        }

    }
}