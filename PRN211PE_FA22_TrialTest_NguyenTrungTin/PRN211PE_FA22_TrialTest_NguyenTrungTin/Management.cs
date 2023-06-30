using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Services.Models;
using Services.Services;

namespace PRN211PE_FA22_TrialTest_NguyenTrungTin
{
    public partial class Management : Form
    {
        ProductServices productServices;
        CategoryServices categoryServices;
        public Management()
        {
            InitializeComponent();
            productServices = new ProductServices();
            categoryServices = new CategoryServices();

            RefreshDataGridView();
            cboCategory.DataSource = categoryServices.GetAll();
            cboCategory.ValueMember = "Id";
            cboCategory.DisplayMember = "CategoryName";

        }

        private void RefreshDataGridView()
        {
            dgvManagement.DataSource = new BindingSource
            {
                DataSource = productServices.GetAll().ToList()
            };
            dgvManagement.ReadOnly = true;
        }
        private void btnSearch_Click(object sender, EventArgs e)
        {
            dgvManagement.DataSource = new BindingSource
            {
                DataSource = productServices.GetAll().Where(p => p.ProductCode.ToLower()
                .Contains(txtSeachValue.Text.ToLower()))
            };
        }

        private void dgvManagement_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {   
            if(e.RowIndex >= 0)
            {
                Product? selectedProduct = dgvManagement.Rows[e.RowIndex].DataBoundItem as Product;

                if(selectedProduct != null)
                {
                    txtProductName.Text = selectedProduct.ProductName.ToString();
                    txtProductCode.Text = selectedProduct.ProductCode.ToString();
                    txtPrice.Text = selectedProduct.Price.ToString();
                }
            }

        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (dgvManagement.SelectedRows.Count < 1)
            {
                MessageBox.Show("Please select product for delete!");
                return;
            }

            bool found = false;
            for (int i = 0; i <= dgvManagement.SelectedRows.Count; i++)
            {
                DataGridViewRow selectedRow = dgvManagement.SelectedRows[i];
                var productId = selectedRow.Cells["Id"].Value.ToString();

                var existedProduct = productServices.GetAll().Where(p => p.Id.ToString() == productId).FirstOrDefault();
                if (existedProduct != null)
                {
                    productServices.Delete(existedProduct);
                    found = true;
                    MessageBox.Show("Deleted");
                    RefreshDataGridView();
                }
            }
            if (!found)
            {
                MessageBox.Show("No product is found!");
                return;
            }
            else
            {
                return;
            }

        }

        private void btnCreate_Click(object sender, EventArgs e)
        {
            string productCode = txtProductCode.Text.ToUpper().Trim();
            if (productCode.Length != 4)
            {
                MessageBox.Show("Product code lenth must be 4 letter");
                return;
            }
            if (Decimal.TryParse(txtPrice.Text, out decimal price) || price <= 0)
            {
                MessageBox.Show("Price do not allow lower or than zero");
                return;
            }
            Product product = new Product();
            product.ProductName = txtProductName.Text;
            product.ProductCode = productCode;
            product.Price = price;
            product.DateCreate = DateTime.Now;
            if (cboCategory.SelectedValue is int categoryId)
            {
                product.CategoryId = categoryId;
            }
            else
            {
                MessageBox.Show("Invalid category selected.");
                return;
            }
            try
            {
                productServices.Create(product);
                MessageBox.Show("Create product successfully!");
                RefreshDataGridView();
            }
            catch (Exception)
            {
                MessageBox.Show("Faild to create product!");
            }
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            string productCode = txtProductCode.Text.ToUpper().Trim();
            if (productCode.Length != 4)
            {
                MessageBox.Show("Product code lenth must be 4 letter");
                return;
            }

            if (Decimal.TryParse(txtPrice.Text, out decimal price) || price <= 0)
            {
                MessageBox.Show("Price do not allow lower or than zero");
                return;
            }

            if (dgvManagement.SelectedRows.Count != 1)
            {
                MessageBox.Show("Please select just one product");
                return;
            }

            Product? selectedProduct = dgvManagement.SelectedRows[0].DataBoundItem as Product; 

            if (selectedProduct != null)
            {
                selectedProduct.ProductName = txtProductName.Text;
                selectedProduct.ProductCode = productCode;
                selectedProduct.Price = price;
            } else
            {
                MessageBox.Show("Pleas select a product for update");
                return;
            }

            try
            {
                productServices.Update(selectedProduct);
                MessageBox.Show("Update successfully!");
                RefreshDataGridView();
                return;
            }
            catch (Exception)
            {
                MessageBox.Show("Faild to update");
                return;
            }
        }
    }
}
