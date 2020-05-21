namespace My_Turkish_English_Dictionary.forms
{
    partial class FavouritesForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.tr_En_DictionaryDataSet_fav = new My_Turkish_English_Dictionary.Tr_En_DictionaryDataSet_fav();
            this.fav_vocBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.fav_vocTableAdapter = new My_Turkish_English_Dictionary.Tr_En_DictionaryDataSet_favTableAdapters.fav_vocTableAdapter();
            this.tableAdapterManager = new My_Turkish_English_Dictionary.Tr_En_DictionaryDataSet_favTableAdapters.TableAdapterManager();
            this.fav_vocDataGridView = new System.Windows.Forms.DataGridView();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.addToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.deleteToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.tr_En_DictionaryDataSet_fav)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fav_vocBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fav_vocDataGridView)).BeginInit();
            this.contextMenuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // tr_En_DictionaryDataSet_fav
            // 
            this.tr_En_DictionaryDataSet_fav.DataSetName = "Tr_En_DictionaryDataSet_fav";
            this.tr_En_DictionaryDataSet_fav.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // fav_vocBindingSource
            // 
            this.fav_vocBindingSource.DataMember = "fav_voc";
            this.fav_vocBindingSource.DataSource = this.tr_En_DictionaryDataSet_fav;
            // 
            // fav_vocTableAdapter
            // 
            this.fav_vocTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.fav_vocTableAdapter = this.fav_vocTableAdapter;
            this.tableAdapterManager.UpdateOrder = My_Turkish_English_Dictionary.Tr_En_DictionaryDataSet_favTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // fav_vocDataGridView
            // 
            this.fav_vocDataGridView.AutoGenerateColumns = false;
            this.fav_vocDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.fav_vocDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2});
            this.fav_vocDataGridView.ContextMenuStrip = this.contextMenuStrip1;
            this.fav_vocDataGridView.DataSource = this.fav_vocBindingSource;
            this.fav_vocDataGridView.Location = new System.Drawing.Point(-1, 2);
            this.fav_vocDataGridView.Name = "fav_vocDataGridView";
            this.fav_vocDataGridView.Size = new System.Drawing.Size(344, 448);
            this.fav_vocDataGridView.TabIndex = 1;
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.addToolStripMenuItem,
            this.deleteToolStripMenuItem});
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(107, 48);
            // 
            // addToolStripMenuItem
            // 
            this.addToolStripMenuItem.Name = "addToolStripMenuItem";
            this.addToolStripMenuItem.Size = new System.Drawing.Size(106, 22);
            this.addToolStripMenuItem.Text = "add";
            // 
            // deleteToolStripMenuItem
            // 
            this.deleteToolStripMenuItem.Name = "deleteToolStripMenuItem";
            this.deleteToolStripMenuItem.Size = new System.Drawing.Size(106, 22);
            this.deleteToolStripMenuItem.Text = "delete";
            this.deleteToolStripMenuItem.Click += new System.EventHandler(this.deleteToolStripMenuItem_Click_1);
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.DataPropertyName = "word";
            this.dataGridViewTextBoxColumn1.HeaderText = "word";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.Width = 150;
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.DataPropertyName = "meaning";
            this.dataGridViewTextBoxColumn2.HeaderText = "meaning";
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            this.dataGridViewTextBoxColumn2.Width = 150;
            // 
            // FavouritesForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(344, 450);
            this.Controls.Add(this.fav_vocDataGridView);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FavouritesForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "favoruties_form";
            this.Load += new System.EventHandler(this.favourites_form_Load);
            ((System.ComponentModel.ISupportInitialize)(this.tr_En_DictionaryDataSet_fav)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fav_vocBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fav_vocDataGridView)).EndInit();
            this.contextMenuStrip1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private Tr_En_DictionaryDataSet_fav tr_En_DictionaryDataSet_fav;
        private System.Windows.Forms.BindingSource fav_vocBindingSource;
        private Tr_En_DictionaryDataSet_favTableAdapters.fav_vocTableAdapter fav_vocTableAdapter;
        private Tr_En_DictionaryDataSet_favTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.DataGridView fav_vocDataGridView;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ToolStripMenuItem addToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem deleteToolStripMenuItem;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
    }
}