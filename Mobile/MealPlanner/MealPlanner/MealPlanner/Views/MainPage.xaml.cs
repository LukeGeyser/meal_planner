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
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();

            CenterLabels();
        }

        #region Private Helpers

        private void CenterLabels()
        {
            Func<RelativeLayout, double> getVegWidth = (parent) => Veg.Measure(parent.Width, parent.Height).Request.Width;
            Func<RelativeLayout, double> getVegHeight = (parent) => Veg.Measure(parent.Width, parent.Height).Request.Height;

            Func<RelativeLayout, double> getPescWidth = (parent) => Pesc.Measure(parent.Width, parent.Height).Request.Width;
            Func<RelativeLayout, double> getPescHeight = (parent) => Pesc.Measure(parent.Width, parent.Height).Request.Height;

            Func<RelativeLayout, double> getWeightLossWidth = (parent) => WeightLoss.Measure(parent.Width, parent.Height).Request.Width;
            Func<RelativeLayout, double> getWeightLossHeight = (parent) => WeightLoss.Measure(parent.Width, parent.Height).Request.Height;

            Func<RelativeLayout, double> getWeightGainWidth = (parent) => WeightGain.Measure(parent.Width, parent.Height).Request.Width;
            Func<RelativeLayout, double> getWeightGainHeight = (parent) => WeightGain.Measure(parent.Width, parent.Height).Request.Height;

            first.Children.Add(Veg, Constraint.RelativeToParent(parent => parent.Width / 2 - getVegWidth(parent) / 2),
                Constraint.RelativeToParent(parent => parent.Height / 2 - getVegHeight(parent) / 2));

            second.Children.Add(Pesc, Constraint.RelativeToParent(parent => parent.Width / 2 - getPescWidth(parent) / 2),
                Constraint.RelativeToParent(parent => parent.Height / 2 - getPescHeight(parent) / 2));

            third.Children.Add(WeightLoss, Constraint.RelativeToParent(parent => parent.Width / 2 - getWeightLossWidth(parent) / 2),
                Constraint.RelativeToParent(parent => parent.Height / 2 - getWeightLossHeight(parent) / 2));

            fourth.Children.Add(WeightGain, Constraint.RelativeToParent(parent => parent.Width / 2 - getWeightGainWidth(parent) / 2),
                Constraint.RelativeToParent(parent => parent.Height / 2 - getWeightGainHeight(parent) / 2));
        }

        #endregion

    }
}