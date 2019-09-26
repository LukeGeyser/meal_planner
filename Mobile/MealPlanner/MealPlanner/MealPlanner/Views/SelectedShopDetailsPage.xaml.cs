using MealPlanner.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace MealPlanner.Views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class SelectedShopDetailsPage : ContentPage
    {
        public DisplayStoreInfoViewModel storeInfoViewModel { get; set; }
        public SelectedShopDetailsPage(DisplayStoreInfoViewModel viewModel)
        {
            InitializeComponent();
            storeInfoViewModel = viewModel;

            BindingContext = this;
        }
    }
}