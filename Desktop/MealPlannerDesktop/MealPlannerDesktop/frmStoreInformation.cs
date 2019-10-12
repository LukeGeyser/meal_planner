﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MealPlannerDesktop
{
    public partial class frmStoreInformation : Form
    {
        public DisplayStoreInfoViewModel storeInfoViewModel { get; set; }

        public string RatingString { get; set; }

        public string PriceRating { get; set; }

        public string PriceRatingHex { get; set; }

        Shops Shops { get; set; }

        string[] StoreImages = { "woolworthsStore.jpg", "picknpayStore.jpeg", "sparStore.jpg"
                ,"checkersStore.jpg" };

        public frmStoreInformation(DisplayStoreInfoViewModel viewModel)
        {
            InitializeComponent();
            storeInfoViewModel = viewModel;

            Shops = new DataHandler().GetShopsDetails(storeInfoViewModel.StoreID);


            RatingString = storeInfoViewModel.Rating == 0 ? "No Ratings For This Store..." : $"Rating: {storeInfoViewModel.Rating}";
            //Display Rating Stars
            #region
            if (storeInfoViewModel.Rating == 5)
            {
                picRatingStars.ImageLocation = "5Stars.png";
            }
            else if(storeInfoViewModel.Rating > 4 && storeInfoViewModel.Rating < 5)
            {
                picRatingStars.ImageLocation = "4_5Star.png";
            }
            else if(storeInfoViewModel.Rating == 4)
            {
                picRatingStars.ImageLocation = "4Stars.png";
            }
            else if(storeInfoViewModel.Rating > 3 && storeInfoViewModel.Rating < 4)
            {
                picRatingStars.ImageLocation = "3_4Star.png";
            }
            else if(storeInfoViewModel.Rating == 3)
            {
                picRatingStars.ImageLocation = "3Stars.png";
            }
            else if(storeInfoViewModel.Rating > 2 && storeInfoViewModel.Rating < 3)
            {
                picRatingStars.ImageLocation = "2_3Star.png";
            }
            else if(storeInfoViewModel.Rating == 2)
            {
                picRatingStars.ImageLocation = "2Stars.png";
            }
            else if(storeInfoViewModel.Rating > 1 && storeInfoViewModel.Rating < 2)
            {
                picRatingStars.ImageLocation = "1_2Star.png";
            }
            else if(storeInfoViewModel.Rating == 1)
            {
                picRatingStars.ImageLocation = "1Star.png";
            }
            else if(storeInfoViewModel.Rating > 0 && storeInfoViewModel.Rating < 1)
            {
                picRatingStars.ImageLocation = "0_1Star.png";
            }
            else
            {
                picRatingStars.ImageLocation = "0Star.png";
            }
            #endregion 
            lblRatingText.Text = RatingString;
            lblOpen.Text = storeInfoViewModel.open_Text;
            switch (lblOpen.Text)
            {
                case "Open Now": lblOpen.ForeColor = Color.Green;
                    break;
                default: lblOpen.ForeColor = Color.Red;
                    break;
            }

            lblLatitude.Text = storeInfoViewModel.Lat.ToString();
            lblLongitude.Text = storeInfoViewModel.Lng.ToString();


            storeInfoViewModel.Vicinity = "Near " + storeInfoViewModel.Vicinity;
            lblNear.Text = storeInfoViewModel.Vicinity;

            if (storeInfoViewModel.Price_Level == 0)
            {
                PriceRating = "Price Rating Unavailable";
                PriceRatingHex = "#2d2d2d";
            }
            else if (storeInfoViewModel.Price_Level == 1)
            {
                PriceRating = "1   (Inexpensive)";
                PriceRatingHex = "#669e2f";
            }
            else if (storeInfoViewModel.Price_Level == 2)
            {
                PriceRating = "2   (Moderate)";
                PriceRatingHex = "#ffcb3b";
            }
            else if (storeInfoViewModel.Price_Level == 3)
            {
                PriceRating = "3   (Expensive)";
                PriceRatingHex = "#ffb73b";
            }
            else if (storeInfoViewModel.Price_Level == 4)
            {
                PriceRating = "4   (Very Expensive)";
                PriceRatingHex = "#db5151";
            }

            lblPriceRatingValue.Text = PriceRating;
            lblPriceRatingValue.ForeColor = ColorTranslator.FromHtml(PriceRatingHex);

            lblDistance.Text = storeInfoViewModel.Distance;
        }

       

        private void FrmStoreInformation_Load(object sender, EventArgs e)
        {

        }

        private void BtnBack_Click(object sender, EventArgs e)
        {
            try
            {
                frmFindShops find = new frmFindShops();
                find.Show();
                this.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void PicPhone_Click(object sender, EventArgs e)
        {
            try
            {
                MessageBox.Show("Contact Number: " + Shops.Phone + "."
                    , "Phone", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception) { }
        }

        private void PicEmail_Click(object sender, EventArgs e)
        {
            //Still trying to figure out how to open in mail application

            try
            {
                MessageBox.Show("Email Address: " + Shops.Email + "."
                    , "Email", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception) { }
        }

        private void PicInternet_Click(object sender, EventArgs e)
        {
            //Still trying to figure out how to open on internet browser.

            try
            {
                MessageBox.Show("Web Site: " + Shops.Website + "."
                    , "Internet", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception) { }
        }
    }
}
