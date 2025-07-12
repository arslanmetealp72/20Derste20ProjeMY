using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Project2_EntityFrameworkDbFirstProduct
{
    public partial class frmProduct : Form
    {
        public frmProduct()
        {
            InitializeComponent();
        }

        Db2Project20Entities db = new Db2Project20Entities();

        void ProductList()
        {
            dataGridView1.DataSource = db.tblProduct.ToList();
        }   
        private void btnList_Click(object sender, EventArgs e)
        {
            ProductList();
        }

        private void btnCreate_Click(object sender, EventArgs e)
        {
            tblProduct product = new tblProduct();
            product.ProductPrice = Convert.ToDecimal(txtProductPrice.Text);
            product.ProductName = txtProductName.Text;
            product.ProductStock = Convert.ToInt32(txtProductStock.Text);
            product.CategoryId = Convert.ToInt32(cmbCategory.SelectedValue);
            db.tblProduct.Add(product);
            db.SaveChanges();
            ProductList();

        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            var value = db.tblProduct.Find(Convert.ToInt32(txtProductId.Text));
            db.tblProduct.Remove(value);
            db.SaveChanges();
            ProductList();
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            var value = db.tblProduct.Find(Convert.ToInt32(txtProductId.Text));
            value.ProductName = txtProductName.Text;
            value.ProductStock = Convert.ToInt32(txtProductStock.Text);
            value.ProductPrice = Convert.ToDecimal(txtProductPrice.Text);
            value.CategoryId = Convert.ToInt32(cmbCategory.SelectedValue);
            db.SaveChanges();
            ProductList();
        }

        private void frmProduct_Load(object sender, EventArgs e)
        {
            var values = db.tblCategory.ToList();
            cmbCategory.DisplayMember = "CategoryName";
            cmbCategory.ValueMember = "CategoryId";
            cmbCategory.DataSource = values;
        }

        private void btnProductListWithCategory_Click(object sender, EventArgs e)
        {
            var values = db.tblProduct.Join(db.tblCategory, 
              product=> product.CategoryId,
                category => category.CategoryId,
                (product, category) => new
                {
                    ProductId = product.ProductId,
                    ProductName = product.ProductName,
                    ProductStock = product.ProductStock,
                    ProductPrice = product.ProductPrice,
                    CategoryId = category.CategoryId,
                    CategoryName = category.CategoryName


                }
                 


                ).ToList();
            dataGridView1.DataSource = values;
        }
    }
}
