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

        private void LinkData()
        {
            bs.DataSource = products;
            lblProductName.DataBindings.Add("Text", bs, "ProductName");
            txtCategory.DataBindings.Add("Text", bs, "Category");
            txtDescription.DataBindings.Add("Text", bs, "Description");
            txtValue.DataBindings.Add("Text", bs, "NutritionalValue");
            picProductImage.DataBindings.Add("ImageLocation", bs, "ProductImage");
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
            LinkData();
            ShowComparison();
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



    }
}
