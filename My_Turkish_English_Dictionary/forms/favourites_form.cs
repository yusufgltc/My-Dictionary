using System;
using System.Data;
using System.Windows.Forms;
using System.Data.SqlClient;


namespace My_Turkish_English_Dictionary.forms
{
    public partial class FavouritesForm : Form
    {
        SqlConnection con = new SqlConnection("Data Source=ZACKBOOK;Initial Catalog=Tr_En_Dictionary;Integrated Security=True");
        public FavouritesForm()
        {
            InitializeComponent();
        }

        private void fav_vocBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.fav_vocBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.tr_En_DictionaryDataSet_fav);

        }

        private void favourites_form_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'tr_En_DictionaryDataSet_fav.fav_voc' table. You can move, or remove it, as needed.
            this.fav_vocTableAdapter.FillByFav(this.tr_En_DictionaryDataSet_fav.fav_voc);
            fav_vocDataGridView.MouseClick += Fav_vocDataGridView_MouseClick;

        }

        private void Fav_vocDataGridView_MouseClick(object sender, MouseEventArgs e)
        {
            int selectedCount = fav_vocDataGridView.SelectedRows.Count;
            while (selectedCount > 0)
            {
                if (!fav_vocDataGridView.SelectedRows[0].IsNewRow)
                    fav_vocDataGridView.Rows.RemoveAt(fav_vocDataGridView.SelectedRows[0].Index);
                selectedCount--;
            }


        }
        private void Delete_word_for_favorite_list(DataGridViewRow word, DataGridViewRow meaning)
        {
            SqlCommand cmd = new SqlCommand("DELETE FROM fav_voc WHERE word = @Word AND meaning = @Meaning", con);
            cmd.Connection = con;
            cmd.Parameters.Remove(new SqlParameter("@Word", SqlDbType.VarChar));
            cmd.Parameters.Remove(new SqlParameter("@Meaning", SqlDbType.VarChar));
            con.Open();
            foreach (DataGridViewRow row in fav_vocDataGridView.Rows)
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
        public void deleteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DialogResult cevap;
            cevap = MessageBox.Show("Kaydı Silmek İstediğinizden Eminmisiniz ?", "Uyarı", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (cevap == DialogResult.Yes)
            {
                con.Open();
                SqlCommand cmd = new SqlCommand("DELETE FROM fav_voc WHERE word = @Word AND meaning = @Meaning", con);
                if (fav_vocDataGridView.CurrentRow != null)
                    cmd.CommandText = "DELETE FROM fav_voc WHERE word='" +
                                      fav_vocDataGridView.CurrentRow.Cells[0].Value.ToString() + "'";
                cmd.ExecuteNonQuery();
                con.Close();


            }
            foreach (DataGridViewCell oneCell in fav_vocDataGridView.SelectedCells)
            {
                if (oneCell.Selected)
                    fav_vocDataGridView.Rows.RemoveAt(oneCell.RowIndex);
            }
        }

        private void deleteToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            DialogResult cevap;
            cevap = MessageBox.Show("Kaydı Silmek İstediğinizden Eminmisiniz ?", "Uyarı", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (cevap == DialogResult.Yes)
            {
                con.Open();
                SqlCommand cmd = new SqlCommand("DELETE FROM fav_voc WHERE word = @Word AND meaning = @Meaning", con);
                cmd.CommandText = "DELETE FROM fav_voc WHERE word='" + fav_vocDataGridView.CurrentRow.Cells[0].Value.ToString() + "'";
                cmd.ExecuteNonQuery();
                con.Close();
            }


            foreach (DataGridViewCell oneCell in fav_vocDataGridView.SelectedCells)
            {
                if (oneCell.Selected)
                    fav_vocDataGridView.Rows.RemoveAt(oneCell.RowIndex);
            }
        }
    }
}
