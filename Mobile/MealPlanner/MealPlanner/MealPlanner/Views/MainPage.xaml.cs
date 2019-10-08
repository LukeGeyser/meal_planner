﻿using MealPlanner.Services;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;
using Xamarin.Essentials;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;
using static MealPlanner.Models.MapResultDataWrapper;

namespace MealPlanner.Views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class MainPage : ContentPage
    {
        ViewCell lastCell;
        public MainPage()
        {
            InitializeComponent();

            Device.BeginInvokeOnMainThread(() =>
            {
                CenterLabels();
            });
            
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

        #region Public Events

        private void PescTapped_Tapped(object sender, EventArgs e)
        {
            DisplayAlert("Pesc", "TAPPED", "okay");
        }

        private void VegTapped_Tapped(object sender, EventArgs e)
        {
            DisplayAlert("Veg", "TAPPED", "okay");
        }

        private void LossTapped_Tapped(object sender, EventArgs e)
        {
            DisplayAlert("Loss", "TAPPED", "okay");
        }

        private void GainTapped_Tapped(object sender, EventArgs e)
        {
            DisplayAlert("Gain", "TAPPED", "okay");
        }

        #endregion

        private void ViewCell_Tapped(object sender, EventArgs e)
        {
            if (lastCell != null)
                lastCell.View.BackgroundColor = Color.Transparent;
            var viewCell = (ViewCell)sender;
            if (viewCell.View != null)
            {
                viewCell.View.BackgroundColor = Color.FromHex("#d4d4d4");
                lastCell = viewCell;
            }
        }
    }
}