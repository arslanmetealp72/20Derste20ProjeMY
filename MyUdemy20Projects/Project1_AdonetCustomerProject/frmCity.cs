using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Project1_AdonetCustomerProject
{
    public partial class frmCity : Form
    {
        public frmCity()
        {
            InitializeComponent();
        }
        SqlConnection sqlConnection = new SqlConnection("Server=METE\\SQLEXPRESS;initial catalog=DbCustomer;integrated security=true");
        private void btnList_Click(object sender, EventArgs e)
        {
            sqlConnection.Open();
            SqlCommand cmd = new SqlCommand("Select * From tblCity",sqlConnection);
            SqlDataAdapter adapter = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            adapter.Fill(dt);
            dataGridView1.DataSource = dt;
            sqlConnection.Close();
        }

        private void btnCreate_Click(object sender, EventArgs e)
        {
            sqlConnection.Open();
            SqlCommand cmd = new SqlCommand("insert into tblCity (CityName,CityCountry) values (@cityName,@cityCountry)",sqlConnection);
            cmd.Parameters.AddWithValue("@cityName",txtCityName.Text);
            cmd.Parameters.AddWithValue("@cityCountry",txtCityCountry.Text);
            cmd.ExecuteNonQuery();
            sqlConnection.Close();
            MessageBox.Show("Şehir Başarıyla Eklendi");
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            sqlConnection.Open();
            SqlCommand cmd = new SqlCommand("Delete From tblCity where CityId=@cityId", sqlConnection);
            cmd.Parameters.AddWithValue("@cityId", txtCityId.Text);
            cmd.ExecuteNonQuery();
            sqlConnection.Close();
            MessageBox.Show("Şehir Başarıyla Silindi","Uyarı!",MessageBoxButtons.OK,MessageBoxIcon.Information);
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            sqlConnection.Open();
            SqlCommand cmd = new SqlCommand("Update tblCity set CityName=@cityName,CityCountry=@cityCountry where CityId=@cityId", sqlConnection);
            cmd.Parameters.AddWithValue("@cityName", txtCityName.Text);
            cmd.Parameters.AddWithValue("@cityCountry", txtCityCountry.Text);
            cmd.Parameters.AddWithValue("@cityId", txtCityId.Text);
            cmd.ExecuteNonQuery();
            sqlConnection.Close();
            MessageBox.Show("Şehir Başarıyla Güncellendi","Uyarı!",MessageBoxButtons.OK,MessageBoxIcon.Information);
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            sqlConnection.Open();
            SqlCommand cmd = new SqlCommand("Select * From tblCity where CityName=@cityName", sqlConnection);
            cmd.Parameters.AddWithValue("@cityName", txtCityName.Text);
            SqlDataAdapter adapter = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            adapter.Fill(dt);
            if (dt.Rows.Count > 0)
            {
                dataGridView1.DataSource = dt;
            }
            else
            {
                MessageBox.Show("Aradığınız şehir bulunamadı.", "Uyarı!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            sqlConnection.Close(); 

        }
    }
}
