using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.Entity;

namespace Project2_EntityFrameworkDbFirstProduct
{
    public partial class frmCategory : Form
    {
        public frmCategory()
        {
            InitializeComponent();
        }
        Db2Project20Entities db = new Db2Project20Entities();

        void categoryList()
        {
            dataGridView1.DataSource = db.tblCategory.ToList();
        }
        private void btnList_Click(object sender, EventArgs e)
        {
            categoryList();
        }

        private void btnCreate_Click(object sender, EventArgs e)
        {
            tblCategory category = new tblCategory();
            category.CategoryName = txtCategoryName.Text;
            db.tblCategory.Add(category);
            db.SaveChanges();
            categoryList();
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            int id = Convert.ToInt32(txtCategoryId.Text);
            var value = db.tblCategory.Find(id);
            db.tblCategory.Remove(value);
            db.SaveChanges();
            categoryList();
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            int id = Convert.ToInt32(txtCategoryId.Text);
            var value = db.tblCategory.Find(id);
            value.CategoryName = txtCategoryName.Text;
            db.SaveChanges();
            categoryList();
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {

        }
    }
}
