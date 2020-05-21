using System;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.Text.RegularExpressions;


namespace My_Turkish_English_Dictionary
{
    public partial class SingupForm : Form
    {
        public SingupForm()
        {
            InitializeComponent();
        }
        SqlConnection con = new SqlConnection("Data Source=ZACKBOOK;Initial Catalog=registration;Integrated Security=True");

        private void Add_new_user(TextBox name, TextBox surname, TextBox password, TextBox emaıl, TextBox bırtday, TextBox phonenumer, TextBox adress)
        {
            con.Open();
            SqlCommand cmd = new SqlCommand("INSERT INTO users_dic (user_name,user_surname,user_password,user_email,user_birthdate,user_phonenumber,user_adress) VALUES(@UserName,@UserSurname,@UserPassword,@Useremail,@UserBirthdate,@UserPhone,@UserAdress)", con);
            cmd.Parameters.AddWithValue("@UserName", name.Text);
            cmd.Parameters.AddWithValue("@UserSurname", surname.Text);
            cmd.Parameters.AddWithValue("@UserPassword", password.Text);
            ///password comfirm
            cmd.Parameters.AddWithValue("@Useremail", emaıl.Text);
            cmd.Parameters.AddWithValue("@UserBirthdate", Convert.ToDateTime(bırtday.Text));
            cmd.Parameters.AddWithValue("@UserPhone", (phonenumer.Text));
            cmd.Parameters.AddWithValue("@UserAdress", adress.Text);

            cmd.Connection = con;
            SqlDataReader dr = cmd.ExecuteReader();
            con.Close();

        }
        private void singup_form_Load(object sender, EventArgs e)
        {

        }

        private void btn_create_Click(object sender, EventArgs e)
        {
            
            if (txtbox_username.Text=="" || txtbox_surname.Text=="" || txtbox_password.Text=="" || txtbox_email.Text=="" || txtbox_birthdate.Text==""|| txtbox_phonenumber.Text=="" || txtbox_adress.Text=="")
            {
                MessageBox.Show("Please fill the essential fields");
            }
            else
            {      Add_new_user(txtbox_username, txtbox_surname, txtbox_password, txtbox_email, txtbox_birthdate, txtbox_phonenumber, txtbox_adress);
                   MessageBox.Show("Done!! You are in now :)");
                   this.Close(); 
            }
            
        }

        private void txtbox_adress_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode==Keys.Enter)
            {
                btn_create.PerformClick();
            }
        }

        private void txtbox_email_Leave(object sender, EventArgs e)
        {
            string pattern = "^([0-9a-zA-Z]([-\\.\\w]*[0-9a-zA-Z])*@([0-9a-zA-Z][-\\w]*[0-9a-zA-Z]\\.)+[a-zA-Z]{2,9})$";
            if (Regex.IsMatch(txtbox_email.Text,pattern))
            {
                errorProvider1.Clear();
            }
            else
            {
                errorProvider1.SetError(this.txtbox_email,"Please provide valid mail adress");
                return;
            }
        }

        private void txtbox_username_TextChanged(object sender, EventArgs e)
        {
            this.txtbox_username.MaxLength = 10;
        }
    }
}
