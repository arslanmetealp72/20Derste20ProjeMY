using Project12_JwtToken.Jwt;
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
using System.Collections.Generic;
using System.IdentityModel.Tokens.Jwt;
using System.Security.Claims;
using System.Text;
using Microsoft.IdentityModel.Tokens;


namespace Project12_JwtToken
{
    public partial class frmLogin : Form
    {
        public frmLogin()
        {
            InitializeComponent();
        }
        SqlConnection sqlConnection = new SqlConnection("Server=METE\\SQLEXPRESS;initial catalog=Db12Project20;integrated security=true");
        private void btnLogin_Click(object sender, EventArgs e)
        {
            tokenGenerator tokenGenerator = new tokenGenerator();
            sqlConnection.Open();
            SqlCommand sqlCommand = new SqlCommand("SELECT * FROM tblUser where Username=@username and Password=@password", sqlConnection);
            sqlCommand.Parameters.AddWithValue("@username", txtUserName.Text);
            sqlCommand.Parameters.AddWithValue("@password", txtPassword.Text);
            SqlDataReader sqlDataReader = sqlCommand.ExecuteReader();
            if (sqlDataReader.Read())
            {
                string token = tokenGenerator.GenerateJwtToken2(txtUserName.Text);
                MessageBox.Show(token);
                frmEmployee frmEmployee = new frmEmployee();
                frmEmployee.token = token;
                frmEmployee.Show();
            }
            else
            {
                MessageBox.Show("Kullanıcı Adı veya Şifre Hatalı");
                txtPassword.Clear();
                txtUserName.Clear();
                txtUserName.Focus();
            }
            sqlConnection.Close();

        }
    }
}
