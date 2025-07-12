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

namespace Project18_DashboardSuperStoreDataset
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        SqlConnection sqlConnection = new SqlConnection("Server=METE\\SQLEXPRESS;initial catalog=Db17Project20;integrated security=true");
        private void Form1_Load(object sender, EventArgs e)
        {
            #region widgets

            sqlConnection.Open();
            SqlCommand command = new SqlCommand("SELECT count(*) FROM superstore", sqlConnection);
            SqlDataReader reader = command.ExecuteReader();
            while(reader.Read())
            {
                lblProductCount.Text = reader[0].ToString();
            }
            sqlConnection.Close();

            sqlConnection.Open();
            SqlCommand command2 = new SqlCommand("SELECT count(distinct(state)) FROM superstore ", sqlConnection);
            SqlDataReader reader2 = command2.ExecuteReader();
            while (reader2.Read())
            {
                lblCityCount.Text = reader2[0].ToString();
            }
            sqlConnection.Close();

            sqlConnection.Open();
            SqlCommand command3 = new SqlCommand("SELECT count(*) FROM superstore where country='turkey' ", sqlConnection);
            SqlDataReader reader3 = command3.ExecuteReader();
            while (reader3.Read())
            {
                lblOrderCountByTurkiye.Text = reader3[0].ToString();
            }
            sqlConnection.Close();

            sqlConnection.Open();
            SqlCommand command4 = new SqlCommand("SELECT sum(quantity) FROM superstore  ", sqlConnection);
            SqlDataReader reader4 = command4.ExecuteReader();
            while (reader4.Read())
            {
                lblProductOrderQuantity.Text = reader4[0].ToString();
            }
            sqlConnection.Close();

            #endregion

            #region charts

            sqlConnection.Open();
            SqlCommand command5 = new SqlCommand("select top(7) country, count(*) from superstore group by country order by count(*) desc", sqlConnection);
            SqlDataReader reader5 = command5.ExecuteReader();
            while (reader5.Read())
                {
                chart1.Series["Series1"].Points.AddXY(reader5[0], reader5[1]);
            }
            sqlConnection.Close();

            sqlConnection.Open();
            SqlCommand command6 = new SqlCommand("select top(3) country, sum(quantity) from superstore group by country order by sum(quantity) desc", sqlConnection);
            SqlDataReader reader6 = command6.ExecuteReader();
            while (reader6.Read())
            {
                chart2.Series["Series1"].Points.AddXY(reader6[0], reader6[1]);
            }
            sqlConnection.Close();

            sqlConnection.Open();
            SqlCommand command7 = new SqlCommand("select Order_Priority,count(*) from superstore group by Order_Priority order by Order_Priority desc", sqlConnection);
            SqlDataReader reader7 = command7.ExecuteReader();
            while (reader7.Read())
            {
                chart3.Series["Series1"].Points.AddXY(reader7[0], reader7[1]);
            }
            sqlConnection.Close();

            #endregion

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }
    }
}
