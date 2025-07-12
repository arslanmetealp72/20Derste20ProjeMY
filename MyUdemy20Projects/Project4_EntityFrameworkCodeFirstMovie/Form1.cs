using Project4_EntityFrameworkCodeFirstMovie.DAL.Context;
using Project4_EntityFrameworkCodeFirstMovie.DAL.Entities;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.Remoting.Contexts;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Project4_EntityFrameworkCodeFirstMovie
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        MovieContext context = new MovieContext();

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            Category category = new Category();
            category.CategoryName = txtName.Text;
            context.Categories.Add(category);
            context.SaveChanges();
            MessageBox.Show("Kategori Eklendi");
        }

        private void btnList_Click(object sender, EventArgs e)
        {
            var values = context.Categories.ToList();
            dataGridView1.DataSource = values;
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            Category category = new Category();
            var value = context.Categories.Find(Convert.ToInt32(txtId.Text));
            value.CategoryName = txtName.Text;
            context.SaveChanges();
            MessageBox.Show("Kategori Güncellendi");

        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            var value = context.Categories.Find(Convert.ToInt32(txtId.Text));
            context.Categories.Remove(value);
            context.SaveChanges();
            MessageBox.Show("Kategori Silindi");
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            var value = context.Categories.Where(x => x.CategoryName.Contains(txtName.Text)).ToList();
            dataGridView1.DataSource = value;
        }
    }
}
