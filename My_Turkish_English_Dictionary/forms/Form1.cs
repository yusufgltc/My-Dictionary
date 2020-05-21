using System;
using System.Data;
using System.Drawing;
using System.Windows.Forms;
using System.IO;
using System.Net;
using System.Data.SqlClient;

namespace My_Turkish_English_Dictionary.forms
{
    public partial class Form1 : Form
    {
        string text3 = "";
        public Form1()
        {
            InitializeComponent();
            text3 = txtbox_seach.Text;
        }

        private void Form1_Load(object sender, EventArgs e)
        {

            // TODO: This line of code loads data into the 'tr_En_DictionaryDataSet.Turkish_English_Dictionary' table. You can move, or remove it, as needed.
            this.turkish_English_DictionaryTableAdapter.Fill(this.tr_En_DictionaryDataSet.Turkish_English_Dictionary);
           
            //*********Fill the word of the day******* 
            ServicePointManager.Expect100Continue = true;
            ServicePointManager.SecurityProtocol = SecurityProtocolType.Tls12;
            string adress = "https://www.merriam-webster.com/word-of-the-day#";
            WebRequest request = WebRequest.Create(adress);
            WebResponse response;
            response = request.GetResponse();
            StreamReader returninfo = new StreamReader(response.GetResponseStream());
            string arraving = returninfo.ReadToEnd();
            int startparagraph = arraving.IndexOf("<h1>") + 4;
            int endparagraph = arraving.Substring(startparagraph).IndexOf("</h1>");
            string paragraph = arraving.Substring(startparagraph, endparagraph);

            
            textBox1.Text = paragraph;
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
           
            this.turkish_English_DictionaryTableAdapter.FillBy(this.tr_En_DictionaryDataSet.Turkish_English_Dictionary, this.txtbox_seach.Text);

            History(txtbox_seach);
        }
        SqlConnection con = new SqlConnection("Data Source=ZACKBOOK;Initial Catalog=Tr_En_Dictionary;Integrated Security=True");
        private void Add_new_word_for_favorite_list(DataGridViewRow word, DataGridViewRow meaning)
        {
            SqlCommand cmd = new SqlCommand("INSERT INTO fav_voc (word,meaning) VALUES(@Word,@Meaning)", con);
            cmd.Connection = con;
            cmd.Parameters.Add(new SqlParameter("@Word", SqlDbType.VarChar));
            cmd.Parameters.Add(new SqlParameter("@Meaning", SqlDbType.VarChar));
            con.Open();
            foreach (DataGridViewRow row in turkish_English_DictionaryDataGridView.Rows)
            {

                if (!row.IsNewRow)
                {
                    cmd.Parameters["@Word"].Value = row.Cells[0].Value;
                    cmd.Parameters["@Meaning"].Value = row.Cells[1].Value;
                    cmd.ExecuteNonQuery();
                }
            }

            cmd.ExecuteReader();
            con.Close();
        }
        private void History(TextBox keyboard)
        {
            con.Open();

            SqlCommand cmd = new SqlCommand("INSERT INTO history (name) VALUES(@Keyboard)", con);
            cmd.Parameters.AddWithValue("@Keyboard", keyboard.Text);
            cmd.ExecuteNonQuery();

            con.Close();
        }

        private void toolStripButton1_Click(object sender, EventArgs e)
        {
            FavouritesForm favoriteform = new FavouritesForm();
            favoriteform.Show();
        }

        private void toolStripButton2_Click(object sender, EventArgs e)
        {
            history_form historyform = new history_form();
            historyform.Show();
        }

        private void toolStripButton4_Click(object sender, EventArgs e)
        {
            Detail_form detailForm = new Detail_form();
            detailForm.Show();
        }

        private void feedbackToolStripMenuItem_Click(object sender, EventArgs e)
        {
            feedback_form feedbackForm = new feedback_form();
            feedbackForm.Show();
        }

        private void addToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Add_new_word_for_favorite_list(turkish_English_DictionaryDataGridView.Rows[0], turkish_English_DictionaryDataGridView.Rows[1]);

            MessageBox.Show("Done :)");
        }

        private void txtbox_seach_Click(object sender, EventArgs e)
        {
            txtbox_seach.Text = "";
        }

        private void txtbox_seach_Enter(object sender, EventArgs e)
        {
            if (txtbox_seach.Text == Text)
            {
                txtbox_seach.Text = "";
            }
        }

        private void txtbox_seach_Leave(object sender, EventArgs e)
        {
            if (txtbox_seach.Text == "")
            {
                txtbox_seach.Text = text3;
            }
        }

        private void btn_NightMode_Click(object sender, EventArgs e)
        {
            if (this.BackColor == Color.White)
            {
                this.BackColor = Color.Black;
                this.txtbox_seach.BackColor = Color.DarkOliveGreen;
                this.textBox1.BackColor= Color.DarkOliveGreen;
                this.btn_search.BackColor = Color.OrangeRed;
                this.btn_NightMode.BackColor = Color.OrangeRed;
                this.turkish_English_DictionaryDataGridView.BackgroundColor = Color.Black;
                this.toolStrip1.BackColor = Color.Black;
                this.toolStripButton1.ForeColor = Color.White;
                this.toolStripButton2.ForeColor = Color.White;
                this.toolStripButton3.ForeColor = Color.White;
                this.toolStripButton4.ForeColor = Color.White;
                this.toolStripButton5.ForeColor = Color.White;
                this.toolStripSeparator1.ForeColor= Color.OrangeRed;
                this.toolStripSeparator2.ForeColor = Color.OrangeRed;
                this.toolStripSeparator3.ForeColor = Color.OrangeRed;
                this.toolStripSeparator4.ForeColor = Color.OrangeRed;
                this.toolStripSeparator5.ForeColor = Color.OrangeRed;
                this.toolStripSeparator6.ForeColor = Color.OrangeRed;
                this.toolStripSeparator7.ForeColor = Color.OrangeRed;
                this.toolStripSeparator8.ForeColor = Color.OrangeRed;
                this.label1.ForeColor= Color.OrangeRed;
                this.label2.ForeColor= Color.OrangeRed;
               

            }

            else
            {
                this.BackColor = Color.White;
                this.txtbox_seach.BackColor = Color.DarkGray;
                this.textBox1.BackColor = Color.DarkGray;
                this.btn_search.BackColor = Color.Gainsboro;
                this.btn_NightMode.BackColor = Color.LightGray;
                this.turkish_English_DictionaryDataGridView.BackgroundColor = Color.LightGray;
                this.toolStrip1.BackColor = Color.LightGray;
                this.toolStripButton1.ForeColor = Color.Black;
                this.toolStripButton2.ForeColor = Color.Black;
                this.toolStripButton3.ForeColor = Color.Black;
                this.toolStripButton4.ForeColor = Color.Black;
                this.toolStripButton5.ForeColor = Color.Black;
                this.toolStripSeparator1.ForeColor = Color.OrangeRed;
                this.toolStripSeparator2.ForeColor = Color.OrangeRed;
                this.toolStripSeparator3.ForeColor = Color.OrangeRed;
                this.toolStripSeparator4.ForeColor = Color.OrangeRed;
                this.toolStripSeparator5.ForeColor = Color.OrangeRed;
                this.toolStripSeparator6.ForeColor = Color.OrangeRed;
                this.toolStripSeparator7.ForeColor = Color.OrangeRed;
                this.toolStripSeparator8.ForeColor = Color.OrangeRed;
                this.label1.ForeColor = Color.Black;
                this.label2.ForeColor = Color.Black;

            }
        }

        private void txtbox_seach_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                btn_search.PerformClick();
            }
        }

        private void txtbox_seach_TextChanged(object sender, EventArgs e)
        {
          
        }

        private void toolStripButton3_Click(object sender, EventArgs e)
        {

        }

        private void toolStripButton5_Click(object sender, EventArgs e)
        {
           MessageBox.Show("Our service is out of service due to API related problems");
        }
    }

}
