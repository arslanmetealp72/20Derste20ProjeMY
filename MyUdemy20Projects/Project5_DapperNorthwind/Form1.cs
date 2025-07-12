using Dapper;
using Project5_DapperNorthwind.Dtos.CategoryDtos;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Project5_DapperNorthwind
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
         
        SqlConnection connection = new SqlConnection("Server=METE\\SQLEXPRESS;initial catalog=Db5Project20;integrated security=true");

        private async void  btnCategoryList_Click(object sender, EventArgs e)
        {
            string query = "SELECT * FROM Categories";
            var values = await connection.QueryAsync<ResultCategoryDto>(query);
            dataGridView1.DataSource = values;

        }

        private async void Form1_Load(object sender, EventArgs e)
        {
            // kategori sayısı
            string query = "SELECT Count(*) FROM Categories";
            var count = await connection.ExecuteScalarAsync<int>(query);
            lblCategoryCount.Text = "Toplam Kategori Sayısı: " + count;

            // ürün sayısı
            string query2 = "SELECT Count(*) FROM Products";
            var productCount = await connection.ExecuteScalarAsync<int>(query2);
            lblProductCount.Text = "Toplam Ürün Sayısı: " + productCount;

            // ortalama ürün stok sayısı
            string query3 = "SELECT AVG(UnitsInStock) FROM Products";
            var averageStock = await connection.ExecuteScalarAsync<int>(query3);
            lblAverageProductStock.Text = "Ortalama Ürün Stok Sayısı: " + averageStock;

            // deniz ürünleri toplam fiyatı
            string query4 = "SELECT SUM(UnitPrice) FROM Products WHERE CategoryId = (SELECT CategoryId FROM Categories WHERE CategoryName = 'Seafood')";
            var seafoodTotalPrice = await connection.ExecuteScalarAsync<decimal>(query4);
            lblSeafoodProductTotalPrice.Text = "Deniz Ürünleri Toplam Fiyatı: " + seafoodTotalPrice;

        }

        private async void BtnCreateCategory(object sender, EventArgs e)
        {
            string sql = "INSERT INTO Categories (CategoryName, Description) VALUES (@CategoryName, @Description)";
            var parameters = new DynamicParameters();
            parameters.Add("CategoryName", txtCategoryName.Text);
            parameters.Add("Description", txtCategoryDescription.Text);
            await connection.ExecuteAsync(sql, parameters);
            MessageBox.Show("Kategori Eklendi");
        }

        private async void btnCategoryDelete_Click(object sender, EventArgs e)
        {
            string query = "DELETE FROM Categories WHERE CategoryId = @CategoryId";
            var parameters = new DynamicParameters();
            parameters.Add("CategoryId", Convert.ToInt32(txtCategoryId.Text));
            await connection.ExecuteAsync(query, parameters);
            MessageBox.Show("Kategori Silindi");
        }

        private async void btnCategoryUpdate_Click(object sender, EventArgs e)
        {
            string query = "UPDATE Categories SET CategoryName = @CategoryName, Description = @Description WHERE CategoryId = @CategoryId";
            var parameters = new DynamicParameters();
            parameters.Add("CategoryId", Convert.ToInt32(txtCategoryId.Text));
            parameters.Add("CategoryName", txtCategoryName.Text);
            parameters.Add("Description", txtCategoryDescription.Text);
            await connection.ExecuteAsync(query, parameters);
            MessageBox.Show("Kategori Güncellendi");


        }
    }
}
