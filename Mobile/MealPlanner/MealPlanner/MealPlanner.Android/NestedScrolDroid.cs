using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using Android.App;
using Android.Content;
using Android.OS;
using Android.Runtime;
using Android.Views;
using Android.Widget;
using Xamarin.Forms;
using Xamarin.Forms.Platform.Android;

[assembly: ExportRenderer(typeof(MealPlanner.Custom_Renderer.NestedScroll),
    typeof(MealPlanner.Droid.NestedScrolDroid))]
namespace MealPlanner.Droid
{
    class NestedScrolDroid : ListViewRenderer
    {
        public NestedScrolDroid(Android.Content.Context context) : base(context)
        {

        }
        protected override void OnElementChanged(ElementChangedEventArgs<Xamarin.Forms.ListView> e)
        {
            base.OnElementChanged(e);
            if (e.NewElement != null)
            {
                var listview = this.Control as Android.Widget.ListView;
                listview.NestedScrollingEnabled = true;
            }
        }
    }
}