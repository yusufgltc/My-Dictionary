using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace My_Turkish_English_Dictionary.forms
{
    public partial class Detail_form : Form
    {
        public Detail_form()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void Detail_form_Load(object sender, EventArgs e)
        {
            this.lbl_companyname.Text = Application.CompanyName;
            this.lbl_productname.Text ="Product name :"+Application.ProductName;
            lbl_version.Text = "Version name :" + Application.ProductVersion;
            this.label6.Text = "Mail :"+My_Turkish_English_Dictionary.Properties.Settings.Default.company_mail;
            this.label5.Text = My_Turkish_English_Dictionary.Properties.Settings.Default.production_year;
        }
    }
}
