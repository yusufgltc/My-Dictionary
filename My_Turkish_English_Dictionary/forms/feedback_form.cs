using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Net.Mail;


namespace My_Turkish_English_Dictionary.forms
{
    public partial class feedback_form : Form
    {
        public feedback_form()
        {
            InitializeComponent();
        }

        private void feedback_form_Load(object sender, EventArgs e)
        {

        }

        private void txtbox_to_Click(object sender, EventArgs e)
        {
            txtbox_to.Text = "";
        }

        private void txtbox_subject_Click(object sender, EventArgs e)
        {
            txtbox_subject.Text = "";
        }

        private void txtbox_mail_Click(object sender, EventArgs e)
        {
            txtbox_mail.Text = "";
        }

        private void btn_send_Click(object sender, EventArgs e)
        {
            if (txtbox_to.Text=="To"||txtbox_subject.Text=="Subject"||txtbox_mail.Text=="Mail"||txtbox_to.Text==""||txtbox_subject.Text==""||txtbox_mail.Text=="")
            {
                MessageBox.Show("Please fill the essential fields");
            }
            else
            {
                MailMessage message = new MailMessage();
                SmtpClient smtp = new SmtpClient();
                smtp.Credentials = new System.Net.NetworkCredential("turendictionary@gmail.com","12345ASDFG");
                smtp.Port = 587;
                smtp.Host = "smtp.gmail.com";
                smtp.EnableSsl = true;
                message.To.Add(txtbox_to.Text);
                message.From= new MailAddress("turendictionary@gmail.com");
                message.Subject = txtbox_subject.Text;
                message.Body = txtbox_mail.Text;
                smtp.Send(message);
                MessageBox.Show("Thank you for your advice");
                this.Hide();    
            }
           
        }
    }
}
