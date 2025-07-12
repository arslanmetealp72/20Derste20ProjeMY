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
    public partial class frmCustomer : Form
    {
        public frmCustomer()
        {
            InitializeComponent();
        }
        SqlConnection sqlConnection = new SqlConnection("Server=METE\\SQLEXPRESS;initial catalog=DbCustomer;integrated security=true");
        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void btnList_Click(object sender, EventArgs e)
        {
            sqlConnection.Open();
            SqlCommand cmd = new SqlCommand("select CustomerId,CustomerName,CustomerSurname,CustomerBalance,CustomerStatus,CityName from tblCustomer inner join tblCity on tblCity.CityId=tblCustomer.CustomerCity", sqlConnection);
            SqlDataAdapter adapter = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            adapter.Fill(dt);
            dataGridView1.DataSource = dt;
            sqlConnection.Close();
        }

        private void btnCreate_Click(object sender, EventArgs e)
        {
            sqlConnection.Open();
            SqlCommand cmd = new SqlCommand("insert into tblCustomer (CustomerName,CustomerSurname,CustomerCity,CustomerBalance,CustomerStatus) values (@customerName,@customerSurname,@customerCity,@customerBalance,@customerStatus)", sqlConnection);
            cmd.Parameters.AddWithValue("@customerName", txtCustomerName.Text);
            cmd.Parameters.AddWithValue("@customerSurname", txtCustomerSurname.Text);
            cmd.Parameters.AddWithValue("@customerCity", cmbCity.SelectedValue);
            cmd.Parameters.AddWithValue("@customerBalance", txtCustomerBalance.Text);
            if (rdbActive.Checked)
            {
                cmd.Parameters.AddWithValue("@customerStatus", true);
            }
            else
            {
                cmd.Parameters.AddWithValue("@customerStatus", false);
            }
            cmd.ExecuteNonQuery();
            sqlConnection.Close();
            MessageBox.Show("Müşteri Başarıyla Eklendi", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void frmCustomer_Load(object sender, EventArgs e)
        {
            sqlConnection.Open();
            SqlCommand cmd = new SqlCommand("select * from tblCity", sqlConnection);
            SqlDataAdapter adapter = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            adapter.Fill(dt);
            cmbCity.ValueMember = "CityId";
            cmbCity.DisplayMember = "CityName";
            cmbCity.DataSource = dt;
            sqlConnection.Close();
        }

        private void btnProcedure_Click(object sender, EventArgs e)
        {
            sqlConnection.Open();
            SqlCommand cmd = new SqlCommand("execute CustomerListWithCity   ", sqlConnection);
            SqlDataAdapter adapter = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            adapter.Fill(dt);
            dataGridView1.DataSource = dt;
            sqlConnection.Close();
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            sqlConnection.Open();
            SqlCommand cmd = new SqlCommand("Delete From tblCustomer where CustomerId=@customerId", sqlConnection);
            cmd.Parameters.AddWithValue("@customerId", txtCustomerId.Text);
            cmd.ExecuteNonQuery();
            sqlConnection.Close();
            MessageBox.Show("Müşteri Başarıyla Silindi", "Uyarı!", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            sqlConnection.Open();
            SqlCommand cmd = new SqlCommand("Update tblCustomer set CustomerName=@customerName,CustomerSurname=@customerSurname,CustomerCity=@customerCity,CustomerBalance=@customerBalance,CustomerStatus=@customerStatus where CustomerId=@customerId", sqlConnection);
            cmd.Parameters.AddWithValue("@customerName", txtCustomerName.Text);
            cmd.Parameters.AddWithValue("@customerSurname", txtCustomerSurname.Text);
            cmd.Parameters.AddWithValue("@customerCity", cmbCity.SelectedValue);
            cmd.Parameters.AddWithValue("@customerBalance", txtCustomerBalance.Text);
            if (rdbActive.Checked)
            {
                cmd.Parameters.AddWithValue("@customerStatus", true);
            }
            else
            {
                cmd.Parameters.AddWithValue("@customerStatus", false);
            }
            cmd.Parameters.AddWithValue("@customerId", txtCustomerId.Text);
            cmd.ExecuteNonQuery();
            sqlConnection.Close();
            MessageBox.Show("Müşteri Başarıyla Güncellendi", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);


        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            sqlConnection.Open();
            SqlCommand cmd = new SqlCommand("select CustomerId,CustomerName,CustomerSurname,CustomerBalance,CustomerStatus,CityName from tblCustomer inner join tblCity on tblCity.CityId=tblCustomer.CustomerCity where CustomerName=@customerName", sqlConnection);
            cmd.Parameters.AddWithValue("@customerName", txtCustomerName.Text);
            SqlDataAdapter adapter = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            adapter.Fill(dt);
            dataGridView1.DataSource = dt;
            sqlConnection.Close();



        }
    }
}
