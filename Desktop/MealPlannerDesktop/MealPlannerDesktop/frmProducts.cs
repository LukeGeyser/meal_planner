using System;
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

    public partial class frmProducts : Form
    {
        public static string filter = "";

        public frmProducts()
        {
            InitializeComponent();
        }

        private void BtnBack_Click(object sender, EventArgs e)
        {
            try
            {
                frmMainPage main = new frmMainPage();
                main.Show();
                this.Close();
            }
            catch (Exception err)
            {
                MessageBox.Show(err.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        List<Products> products = DataHandler.GetAllProducts();
        BindingSource bs = new BindingSource();
        List<Recipes> recipes = DataHandler.GetAllRecipes();
        List<RecipeProducts> FilteredProducts = null;

        private void DetermineDataSource()
        {
            if (cbxRecipeFilter.Text == "All Recipes" || cbxRecipeFilter.Text == "")
            {
                filter = "All";
                cbxRecipeFilter.Text = "All Recipes";
                bs.DataSource = products;
            }
            else
            {
                bool found = false;
                int count = 0;
                List<Products> filtered = new List<Products>();
                while (found == false && count < recipes.Count)
                {
                    if(filter == recipes[count].RecipeName)
                    {
                        found = true;
                        FilteredProducts = DataHandler.GetRecipeProducts(recipes[count].RecipeID);
                        foreach (Products p in products)
                        {
                            bool found2 = false;
                            int count2 = 0;
                            while(found2 == false && count2 < FilteredProducts.Count)
                            {
                                if(p.ProductID == FilteredProducts[count2].ProductID)
                                {
                                    found2 = true;
                                    filtered.Add(p);
                                }
                                else
                                {
                                    count2++;
                                }
                            }
                        }
                    }
                    else
                    {
                        count++;
                    }
                }

                bs.DataSource = filtered;
            }
        }

        private void LinkData()
        {
            DetermineDataSource();
            lblProductName.DataBindings.Clear();
            txtCategory.DataBindings.Clear();
            txtDescription.DataBindings.Clear();
            txtValue.DataBindings.Clear();
            picProductImage.DataBindings.Clear();
            lblProductName.DataBindings.Add("Text", bs, "ProductName");
            txtCategory.DataBindings.Add("Text", bs, "Category");
            txtDescription.DataBindings.Add("Text", bs, "Description");
            txtValue.DataBindings.Add("Text", bs, "NutritionalValue");
            picProductImage.DataBindings.Add("ImageLocation", bs, "ProductImage");

            lblProductsFound.Text = bs.Count + " products found.";
            filter = "";
        }

        private void ShowComparison()
        {
            var current = (Products)bs.Current;
            lstPrices.DataSource = null;
            List<ShopsPrices> prices = DataHandler.GetPriceComparison(current.ProductID);
            lstPrices.DataSource = prices;
            lstPrices.Columns["Productprice"].DefaultCellStyle.Format = "c";
        }

        private void FrmProducts_Load(object sender, EventArgs e)
        {
            cbxRecipeFilter.Text = filter;
            LinkData();
            ShowComparison();
            cbxRecipeFilter.Items.Clear();
            cbxRecipeFilter.Items.Add("All Recipes");
            for(int i = 0; i < recipes.Count; i++)
            {
                cbxRecipeFilter.Items.Add(recipes[i].RecipeName);
            }
        }

        private void BtnPrevious_Click(object sender, EventArgs e)
        {
            try
            {
                bs.MovePrevious();
                ShowComparison();
            }
            catch(Exception) { }
        }

        private void BtnNext_Click(object sender, EventArgs e)
        {
            try
            {
                bs.MoveNext();
                ShowComparison();
            }
            catch (Exception) { }
        }

        private void BtnShopAvailability_Click(object sender, EventArgs e)
        {
            try
            {
                frmFindShops shops = new frmFindShops();
                shops.Show();
                this.Close();
            }
            catch (Exception err)
            {
                MessageBox.Show(err.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void CbxRecipeFilter_SelectedIndexChanged(object sender, EventArgs e)
        {
            filter = cbxRecipeFilter.Items[cbxRecipeFilter.SelectedIndex].ToString();
            LinkData();
        }
    }
}
