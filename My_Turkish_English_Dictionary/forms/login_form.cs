using System;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace My_Turkish_English_Dictionary
{
    public partial class FormLogin : Form
    {
        SqlConnection con;
        private SqlCommand _cmd;
        SqlDataReader dr;
        string text1 = "";
        string text2 = "";
        public FormLogin()
        {
            InitializeComponent();
            con = new SqlConnection("Data Source=ZACKBOOK;Initial Catalog=registration;Integrated Security=True");
            text1 = txtbox_login_username.Text;
            text2 = txtbox_login_password.Text;
        }

        private void btn_showpassword_Click(object sender, EventArgs e)
        {
            if (txtbox_login_password.PasswordChar.ToString() == "*")
            {
                txtbox_login_password.PasswordChar = char.Parse("\0");

            }
            else
            {
                txtbox_login_password.PasswordChar = char.Parse("*");

            }
        }

        private void btn_login_Click(object sender, EventArgs e)
        {
            string username = txtbox_login_username.Text;
            string password = txtbox_login_password.Text;
            _cmd = new SqlCommand();
            con.Open();
            _cmd.Connection = con;
            _cmd.CommandText = "SELECT * FROM users_dic where user_name='" + txtbox_login_username.Text + "' AND user_password='" + txtbox_login_password.Text + "'";
            dr = _cmd.ExecuteReader();
            if (dr.Read())
            {
                MessageBox.Show("Login successful!! Welcome to Homepage");
                this.Hide();
                My_Turkish_English_Dictionary.forms.Form1 form1 = new forms.Form1();
                form1.Show();
            }
            else
            {
                MessageBox.Show("Invalid Login!! Please check username or password");
            }
            con.Close();
        }

        private void btn_singup_Click(object sender, EventArgs e)
        {
            My_Turkish_English_Dictionary.SingupForm singup = new SingupForm();
            singup.Show();
        }

        private void txtbox_login_username_Click(object sender, EventArgs e)
        {
            txtbox_login_username.Text = "";
        }

        private void txtbox_login_username_Enter(object sender, EventArgs e)
        {
            if (txtbox_login_username.Text == Text)
            {
                txtbox_login_username.Text = "";
            }
        }

        private void txtbox_login_username_Leave(object sender, EventArgs e)
        {
            if (txtbox_login_username.Text == "")
            {
                txtbox_login_username.Text = text1;
            }
        }

        private void txtbox_login_password_Click(object sender, EventArgs e)
        {
            txtbox_login_password.Text = "";
        }

        private void txtbox_login_password_Enter(object sender, EventArgs e)
        {
            if (txtbox_login_password.Text == Text)
            {
                txtbox_login_password.Text = "";
            }
        }

        private void txtbox_login_password_Leave(object sender, EventArgs e)
        {
            if (txtbox_login_password.Text=="")
            {
                txtbox_login_password.Text = text2;
            }
        }

        private void txtbox_login_username_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtbox_login_password_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode==Keys.Enter)
            {
                btn_login.PerformClick();
            }
        }

        private void FormLogin_Load(object sender, EventArgs e)
        {

        }
    }
}
