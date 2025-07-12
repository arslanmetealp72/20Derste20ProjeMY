using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Project16_MailRegister
{
    public partial class frmMailConfirm : Form
    {
        public frmMailConfirm()
        {
            InitializeComponent();
        }
        Db16Project20Entities context = new Db16Project20Entities();
        public string email;

        private void btnConfirm_Click(object sender, EventArgs e)
        {
            
            var value = context.tblUser
                .Where(x => x.Email == txtEmail.Text)
                .Select(x => x.ConfirmCode)
                .FirstOrDefault();


            if (value == null)
            {
                MessageBox.Show("Bu email adresi kayıtlı değil.", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (txtConfirmCode.Text == value.ToString())
            {
                var user = context.tblUser
                    .Where(x => x.Email == txtEmail.Text)
                    .FirstOrDefault();
                user.İsConfirm = true;
                context.SaveChanges();
                MessageBox.Show("Email Adresiniz Doğrulandı");
            }
            else
            {
                MessageBox.Show("Doğrulama Kodu Hatalı", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        private void frmMailConfirm_Load(object sender, EventArgs e)
        {
            txtEmail.Text = email;
        }
    }
}
