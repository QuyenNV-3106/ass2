using BusinessObject;
using DataAccess.Repository;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SalesWinApp
{
    public partial class frmProductDetails : Form
    {
        public frmProductDetails()
        {
            InitializeComponent();
        }
        public IProductRepository ProductRepository { get; set; }
        public bool InsertOrUpdate { get; set; }
        public ProductObject ProInfo { get; set; }

        private void frmProductDetails_Load(object sender, EventArgs e)
        {
            txtProId.Enabled = !InsertOrUpdate;
            if (InsertOrUpdate)
            {
                txtProId.Text = ProInfo.ProductID.ToString();
                txtProName.Text = ProInfo.ProductName.ToString();
                txtCategory.Text = ProInfo.CategoryID.ToString();
                txtWeight.Text = ProInfo.Weight.ToString();
                txtPrice.Text = ProInfo.UnitPrice.ToString();
                txtStock.Text = ProInfo.UnitsInStock.ToString();
            }
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            try
            {
                var pro = new ProductObject
                {
                    ProductID = int.Parse(txtProId.Text),
                    ProductName = txtProName.Text,
                    CategoryID = int.Parse(txtCategory.Text),
                    Weight = txtWeight.Text,
                    UnitPrice = decimal.Parse(txtPrice.Text),
                    UnitsInStock = int.Parse(txtStock.Text)
                };
                if (InsertOrUpdate)
                {
                    ProductRepository.UpdatePro(pro);
                    MessageBox.Show("Success", "Update product");
                    this.Close();

                }
                else
                {
                    ProductRepository.InsertPro(pro);
                    MessageBox.Show("Success", "Insert new product");
                    txtProId.Clear();
                    txtProName.Clear();
                    txtCategory.Clear();
                    txtWeight.Clear();
                    txtPrice.Clear();
                    txtStock.Clear();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, InsertOrUpdate == true ? "Update product" : "Insert new product");
            }
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
