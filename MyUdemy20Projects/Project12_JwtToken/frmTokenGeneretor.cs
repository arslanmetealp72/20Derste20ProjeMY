using Project12_JwtToken.Jwt;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Project12_JwtToken
{
    public partial class frmTokenGeneretor : Form
    {
        public frmTokenGeneretor()
        {
            InitializeComponent();
        }

        private void btnCreateToken_Click(object sender, EventArgs e)
        {   
            string userName = txtUserName.Text;
            string email = txtEmail.Text;
            string name = txtName.Text;
            string surname = txtSurname.Text;
            tokenGenerator tokenGenerator = new tokenGenerator();
            string token = tokenGenerator.GenerateJwtToken(userName,email,name,surname);
            richTextBox1.Text = token; 
        }

        private void frmTokenGeneretor_Load(object sender, EventArgs e)
        {

        }
    }
}
