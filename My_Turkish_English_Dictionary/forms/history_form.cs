using System;
using System.Windows.Forms;

namespace My_Turkish_English_Dictionary.forms
{
    public partial class history_form : Form
    {
        public history_form()
        {
            InitializeComponent();
        }

        private void historyBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.historyBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.tr_En_DictionaryDataSet_history);

        }

        private void history_form_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'tr_En_DictionaryDataSet_history.history' table. You can move, or remove it, as needed.
            this.historyTableAdapter.Fill(this.tr_En_DictionaryDataSet_history.history);

        }
    }
}
