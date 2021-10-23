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
    public partial class frmProducts : Form
    {
        IProductRepository productRepository = new ProductRepository();
        BindingSource source;
        public frmProducts()
        {
            InitializeComponent();
        }
        private void frmProducts_Load(object sender, EventArgs e)
        {
            btnDelete.Enabled = false;
            LoadList(productRepository.GetProducts());
        }

        public void LoadList(IEnumerable<ProductObject> proList)
        {
            try
            {
                source = new BindingSource();
                source.DataSource = proList;

                txtProId.DataBindings.Clear();
                txtCategory.DataBindings.Clear();
                txtProName.DataBindings.Clear();
                txtWeight.DataBindings.Clear();
                txtPrice.DataBindings.Clear();
                txtStock.DataBindings.Clear();

                txtProId.DataBindings.Add("Text", source, "ProductID");
                txtCategory.DataBindings.Add("Text", source, "CategoryID");
                txtProName.DataBindings.Add("Text", source, "ProductName");
                txtWeight.DataBindings.Add("Text", source, "Weight");
                txtPrice.DataBindings.Add("Text", source, "UnitPrice");
                txtStock.DataBindings.Add("Text", source, "UnitsInStock");
                dgvProductList.DataSource = null;
                dgvProductList.DataSource = source;

                dgvProductList.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
                dgvProductList.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.None;

                if (proList.Count() == 0)
                {
                    ClearText();
                    btnDelete.Enabled = false;
                }
                else
                {
                    btnDelete.Enabled = true;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Load Product List");

            }
        }

        public void ClearText()
        {
            txtProId.Text = string.Empty;
            txtProName.Text = string.Empty;
            txtCategory.Text = string.Empty;
            txtPrice.Text = string.Empty;
            txtStock.Text = string.Empty;
            txtWeight.Text = string.Empty;
        }

        private void btnInsert_Click(object sender, EventArgs e)
        {
            try
            {
                frmProductDetails form = new frmProductDetails
                {
                    Text = "Add new Product",
                    InsertOrUpdate = false,
                    ProductRepository = productRepository
                };
                form.ShowDialog();
                LoadList(productRepository.GetProducts());
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message, "Insert Product");
            }
        }

        public ProductObject GetProductObject()
        {
            ProductObject pro = null;
            try
            {
                pro = new ProductObject
                {
                    ProductID = int.Parse(txtProId.Text),
                    ProductName = txtProName.Text,
                    Weight = txtWeight.Text,
                    UnitPrice = decimal.Parse(txtPrice.Text),
                    UnitsInStock = int.Parse(txtStock.Text),
                    CategoryID = int.Parse(txtCategory.Text),
                };
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message, "Get Product");
            }
            return pro;
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {

            try
            {
                DialogResult result = MessageBox.Show("Are you sure?", "Confirm Remove", MessageBoxButtons.YesNo);
                if (DialogResult.Yes == result)
                {
                    var pro = GetProductObject();
                    productRepository.DeletePro(pro.ProductID);
                    LoadList(productRepository.GetProducts());
                }
                else
                {
                    MessageBox.Show("Cancel", "Remove Member");
                }
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message, "Delete Product");
            }

        }

        private void dgvProductList_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            frmProductDetails form = new frmProductDetails
            {
                Text = "Update Product",
                InsertOrUpdate = true,
                ProInfo = GetProductObject(),
                ProductRepository = productRepository
            };
            form.ShowDialog();
            LoadList(productRepository.GetProducts());
        }

        private void btnSearchIDAndName_Click(object sender, EventArgs e)
        {
            try
            {
                LoadList(productRepository.SearchIDAndName(int.Parse(txtSearchID.Text), txtSearchName.Text));
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message, "Search ID and Name");
            }
        }

        private void btnSearchPrice_Click(object sender, EventArgs e)
        {
            try
            {
                if (decimal.Parse(txtMax.Text) < decimal.Parse(txtMin.Text))
                {
                    MessageBox.Show("Min Price > or = Max price", "Search Price");
                }
                else
                {
                    LoadList(productRepository.SearchPrice(decimal.Parse(txtMin.Text), decimal.Parse(txtMax.Text)));
                }
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message, "Search Price");
            }
        }

        private void btnSearchStock_Click(object sender, EventArgs e)
        {
            try
            {
                if (int.Parse(txtMaxStock.Text) < int.Parse(txtMinStock.Text))
                {
                    MessageBox.Show("Min > or = Max", "Search stock");
                }
                else
                {
                    LoadList(productRepository.SearchStock(int.Parse(txtMinStock.Text), int.Parse(txtMaxStock.Text)));
                }
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message, "Search stock");
            }
        }
    }
}
