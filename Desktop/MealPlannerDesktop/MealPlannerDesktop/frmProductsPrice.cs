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
    public partial class frmProductsPrice : Form
    {
        public frmProductsPrice()
        {
            InitializeComponent();
        }

        private void frmProductsPrice_Load(object sender, EventArgs e)
        {
            try
            {
                this.Size = new Size(881, 294);
            }
            catch (Exception err)
            {
                MessageBox.Show(err.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnBack_Click(object sender, EventArgs e)
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
        
        //finds the prices for the specified product and displays the prices with the corresponding shop name
        //all product information is also displayed
        private void btnSearch_Click(object sender, EventArgs e)
        {
            try
            {
                List<Products> allproduct = DataHandler.GetAllProducts();
                List<Products> found = new List<Products>();
                List<ShopsPrices> shops = new List<ShopsPrices>();
                foreach (var item in allproduct)
                {
                    if (item.ProductName.ToLower() == txtProdName.Text.ToLower())
                    {
                        this.Size = new Size(881, 575);
                        shops = DataHandler.GetPriceComparison(item.ProductID);
                        found.Add(item);
                        break;
                    }
                }
                lstPrices.DataSource = shops;
                lstPrices.Columns["Productprice"].DefaultCellStyle.Format = "c";
                lblProductName.DataBindings.Clear();
                txtCategory.DataBindings.Clear();
                txtDescription.DataBindings.Clear();
                txtValue.DataBindings.Clear();
                picProductImage.DataBindings.Clear();
                picProductImage.DataBindings.Add("ImageLocation", found, "ProductImage");
                lblProductName.DataBindings.Add("Text", found, "ProductName");
                txtCategory.DataBindings.Add("Text", found, "Category");
                txtDescription.DataBindings.Add("Text", found, "Description");
                txtValue.DataBindings.Add("Text", found, "NutritionalValue");
            }
            catch (Exception err)
            {
                MessageBox.Show(err.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }
    }
}
