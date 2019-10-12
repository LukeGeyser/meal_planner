using System.Diagnostics;
using Xamarin.Forms;

namespace MealPlanner.Custom_Renderer
{
    public class NestedScroll : ListView
    {
        public static readonly BindableProperty IsNestedScrollProperty = BindableProperty.Create(
            propertyName: "IsNestedScroll",
            returnType: typeof(bool),
            declaringType: typeof(NestedScroll),
            defaultValue: false
            );

        public bool IsNestedScroll
        {
            get
            {
                return (bool)GetValue(IsNestedScrollProperty);
            }
            set
            {
                SetValue(IsNestedScrollProperty, value);
                Debug.WriteLine(IsNestedScrollProperty);
            }
        }
    }
}
