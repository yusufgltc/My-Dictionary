namespace My_Turkish_English_Dictionary.forms
{
    partial class Detail_form
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
            this.lbl_companyname = new System.Windows.Forms.Label();
            this.lbl_productname = new System.Windows.Forms.Label();
            this.lbl_version = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.SuspendLayout();
            // 
            // lbl_companyname
            // 
            this.lbl_companyname.AutoSize = true;
            this.lbl_companyname.Font = new System.Drawing.Font("Mistral", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lbl_companyname.Location = new System.Drawing.Point(125, 46);
            this.lbl_companyname.Name = "lbl_companyname";
            this.lbl_companyname.Size = new System.Drawing.Size(97, 33);
            this.lbl_companyname.TabIndex = 0;
            this.lbl_companyname.Text = "Gültaçlar";
            this.lbl_companyname.Click += new System.EventHandler(this.label1_Click);
            // 
            // lbl_productname
            // 
            this.lbl_productname.AutoSize = true;
            this.lbl_productname.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lbl_productname.Location = new System.Drawing.Point(27, 140);
            this.lbl_productname.Name = "lbl_productname";
            this.lbl_productname.Size = new System.Drawing.Size(107, 20);
            this.lbl_productname.TabIndex = 1;
            this.lbl_productname.Text = "product name";
            // 
            // lbl_version
            // 
            this.lbl_version.AutoSize = true;
            this.lbl_version.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lbl_version.Location = new System.Drawing.Point(27, 185);
            this.lbl_version.Name = "lbl_version";
            this.lbl_version.Size = new System.Drawing.Size(59, 20);
            this.lbl_version.TabIndex = 2;
            this.lbl_version.Text = "version";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(128, 374);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(100, 13);
            this.label4.TabIndex = 3;
            this.label4.Text = "All Rights Reserved";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(151, 344);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(58, 13);
            this.label5.TabIndex = 4;
            this.label5.Text = "2019-2020";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label6.Location = new System.Drawing.Point(27, 226);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(200, 20);
            this.label6.TabIndex = 5;
            this.label6.Text = "turendictionary@gmail.com";
            // 
            // panel1
            // 
            this.panel1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Location = new System.Drawing.Point(-14, 321);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(394, 1);
            this.panel1.TabIndex = 6;
            // 
            // Detail_form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Wheat;
            this.ClientSize = new System.Drawing.Size(367, 450);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.lbl_version);
            this.Controls.Add(this.lbl_productname);
            this.Controls.Add(this.lbl_companyname);
            this.Name = "Detail_form";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "About Us";
            this.Load += new System.EventHandler(this.Detail_form_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbl_companyname;
        private System.Windows.Forms.Label lbl_productname;
        private System.Windows.Forms.Label lbl_version;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Panel panel1;
    }
}