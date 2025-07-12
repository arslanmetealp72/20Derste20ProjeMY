using MailKit.Net.Smtp;
using MimeKit;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net.Mail;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using SmtpClient = MailKit.Net.Smtp.SmtpClient;

namespace Project16_MailRegister
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        Db16Project20Entities context = new Db16Project20Entities(); 

        private void btnRegister_Click(object sender, EventArgs e)
        {
            Random rnd = new Random();

            int confirmCode = rnd.Next(100000, 999999);


            tblUser user = new tblUser();

            user.Name = txtName.Text;
            user.Surname = txtSurname.Text;
            user.Email = txtEmail.Text;
            user.Password = txtPassword.Text;
            user.İsConfirm = false;
            user.ConfirmCode = confirmCode.ToString();

            context.tblUser.Add(user);
            context.SaveChanges();

            #region mailKodları

            MimeMessage mimeMessage = new MimeMessage();

            MailboxAddress mailboxAddressFrom = new MailboxAddress("Admin Register" , "arslanmetealp72@gmail.com");
            mimeMessage.From.Add(mailboxAddressFrom);

            MailboxAddress mailboxAddressTo = new MailboxAddress("User", txtEmail.Text);
            mimeMessage.To.Add(mailboxAddressTo);

            var bodyBuilder = new BodyBuilder();
            bodyBuilder.TextBody = "Email Adresinizin Doğrulama Kodu: " + confirmCode;
            mimeMessage.Body = bodyBuilder.ToMessageBody();

            mimeMessage.Subject = "Register Confirmation Code";

            SmtpClient  smtpClient = new SmtpClient();
            smtpClient.Connect("smtp.gmail.com", 587, false); 
            smtpClient.Authenticate("arslanmetealp72@gmail.com", "eucmniodqwqmvook");
            smtpClient.Send(mimeMessage);
            smtpClient.Disconnect(true);

            MessageBox.Show("Kayıt Başarılı. Lütfen Email Adresinizi Kontrol Ediniz.", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);

            frmMailConfirm frm = new frmMailConfirm();
            frm.email = txtEmail.Text;
            frm.Show();

            #endregion
        }
    }
}
