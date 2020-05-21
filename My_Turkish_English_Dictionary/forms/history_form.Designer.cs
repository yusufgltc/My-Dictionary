namespace My_Turkish_English_Dictionary.forms
{
    partial class history_form
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
            this.tr_En_DictionaryDataSet_history = new My_Turkish_English_Dictionary.Tr_En_DictionaryDataSet_history();
            this.historyBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.historyTableAdapter = new My_Turkish_English_Dictionary.Tr_En_DictionaryDataSet_historyTableAdapters.historyTableAdapter();
            this.tableAdapterManager = new My_Turkish_English_Dictionary.Tr_En_DictionaryDataSet_historyTableAdapters.TableAdapterManager();
            this.historyDataGridView = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.tr_En_DictionaryDataSet_history)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.historyBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.historyDataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // tr_En_DictionaryDataSet_history
            // 
            this.tr_En_DictionaryDataSet_history.DataSetName = "Tr_En_DictionaryDataSet_history";
            this.tr_En_DictionaryDataSet_history.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // historyBindingSource
            // 
            this.historyBindingSource.DataMember = "history";
            this.historyBindingSource.DataSource = this.tr_En_DictionaryDataSet_history;
            // 
            // historyTableAdapter
            // 
            this.historyTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.historyTableAdapter = this.historyTableAdapter;
            this.tableAdapterManager.UpdateOrder = My_Turkish_English_Dictionary.Tr_En_DictionaryDataSet_historyTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // historyDataGridView
            // 
            this.historyDataGridView.AutoGenerateColumns = false;
            this.historyDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.historyDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2});
            this.historyDataGridView.DataSource = this.historyBindingSource;
            this.historyDataGridView.Location = new System.Drawing.Point(0, 2);
            this.historyDataGridView.Name = "historyDataGridView";
            this.historyDataGridView.Size = new System.Drawing.Size(344, 450);
            this.historyDataGridView.TabIndex = 1;
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.DataPropertyName = "name";
            this.dataGridViewTextBoxColumn1.HeaderText = "name";
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
            // history_form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(340, 449);
            this.Controls.Add(this.historyDataGridView);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "history_form";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "history_form";
            this.Load += new System.EventHandler(this.history_form_Load);
            ((System.ComponentModel.ISupportInitialize)(this.tr_En_DictionaryDataSet_history)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.historyBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.historyDataGridView)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Tr_En_DictionaryDataSet_history tr_En_DictionaryDataSet_history;
        private System.Windows.Forms.BindingSource historyBindingSource;
        private Tr_En_DictionaryDataSet_historyTableAdapters.historyTableAdapter historyTableAdapter;
        private Tr_En_DictionaryDataSet_historyTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.DataGridView historyDataGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
    }
}