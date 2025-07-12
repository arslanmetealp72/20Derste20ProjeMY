using Project12_JwtToken.Jwt;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.IdentityModel.Tokens.Jwt;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Project12_JwtToken
{
    public partial class frmEmployee : Form
    {
        public frmEmployee()
        {
            InitializeComponent();
        }

        SqlConnection sqlConnection = new SqlConnection("Server=METE\\SQLEXPRESS;initial catalog=Db12Project20;integrated security=true");
        public string token;
        private void frmEmployee_Load(object sender, EventArgs e)
        {
            tokenValidator tokenValidator = new tokenValidator();

            var princibal = tokenValidator.ValidateJwtToken(token);

            if (princibal != null)
            {
                string username = princibal.FindFirst(JwtRegisteredClaimNames.Sub)?.Value;
                MessageBox.Show("Hoşgeldiniz " + username);

                sqlConnection.Open();
                SqlCommand sqlCommand = new SqlCommand("SELECT * FROM tblEmployee", sqlConnection);
                SqlDataAdapter sqlDataAdapter = new SqlDataAdapter(sqlCommand);
                DataTable dataTable = new DataTable();
                sqlDataAdapter.Fill(dataTable);
                dataGridView1.DataSource = dataTable;
                sqlConnection.Close();
            }

            else
            {
                MessageBox.Show("Token Geçersiz");
                this.Close();
            }
        }
    }
}
