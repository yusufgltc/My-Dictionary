namespace My_Turkish_English_Dictionary.forms
{
    partial class feedback_form
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
            this.txtbox_to = new System.Windows.Forms.TextBox();
            this.txtbox_subject = new System.Windows.Forms.TextBox();
            this.txtbox_mail = new System.Windows.Forms.TextBox();
            this.btn_send = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // txtbox_to
            // 
            this.txtbox_to.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtbox_to.ForeColor = System.Drawing.SystemColors.ActiveBorder;
            this.txtbox_to.Location = new System.Drawing.Point(46, 79);
            this.txtbox_to.Name = "txtbox_to";
            this.txtbox_to.Size = new System.Drawing.Size(304, 26);
            this.txtbox_to.TabIndex = 0;
            this.txtbox_to.Text = "To";
            this.txtbox_to.Click += new System.EventHandler(this.txtbox_to_Click);
            // 
            // txtbox_subject
            // 
            this.txtbox_subject.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtbox_subject.ForeColor = System.Drawing.SystemColors.ActiveBorder;
            this.txtbox_subject.Location = new System.Drawing.Point(46, 126);
            this.txtbox_subject.Name = "txtbox_subject";
            this.txtbox_subject.Size = new System.Drawing.Size(304, 26);
            this.txtbox_subject.TabIndex = 1;
            this.txtbox_subject.Text = "Subject";
            this.txtbox_subject.Click += new System.EventHandler(this.txtbox_subject_Click);
            // 
            // txtbox_mail
            // 
            this.txtbox_mail.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtbox_mail.ForeColor = System.Drawing.SystemColors.ActiveBorder;
            this.txtbox_mail.Location = new System.Drawing.Point(46, 171);
            this.txtbox_mail.Multiline = true;
            this.txtbox_mail.Name = "txtbox_mail";
            this.txtbox_mail.Size = new System.Drawing.Size(304, 211);
            this.txtbox_mail.TabIndex = 2;
            this.txtbox_mail.Text = "Mail";
            this.txtbox_mail.Click += new System.EventHandler(this.txtbox_mail_Click);
            // 
            // btn_send
            // 
            this.btn_send.BackColor = System.Drawing.Color.Crimson;
            this.btn_send.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_send.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btn_send.ForeColor = System.Drawing.SystemColors.Info;
            this.btn_send.Location = new System.Drawing.Point(129, 388);
            this.btn_send.Name = "btn_send";
            this.btn_send.Size = new System.Drawing.Size(149, 39);
            this.btn_send.TabIndex = 3;
            this.btn_send.Text = "Send";
            this.btn_send.UseVisualStyleBackColor = false;
            this.btn_send.Click += new System.EventHandler(this.btn_send_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.ForeColor = System.Drawing.SystemColors.WindowFrame;
            this.label1.Location = new System.Drawing.Point(40, 21);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(192, 31);
            this.label1.TabIndex = 4;
            this.label1.Text = "CONTACT US";
            // 
            // feedback_form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.SkyBlue;
            this.ClientSize = new System.Drawing.Size(394, 450);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btn_send);
            this.Controls.Add(this.txtbox_mail);
            this.Controls.Add(this.txtbox_subject);
            this.Controls.Add(this.txtbox_to);
            this.Name = "feedback_form";
            this.Text = "feedback_form";
            this.Load += new System.EventHandler(this.feedback_form_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtbox_to;
        private System.Windows.Forms.TextBox txtbox_subject;
        private System.Windows.Forms.TextBox txtbox_mail;
        private System.Windows.Forms.Button btn_send;
        private System.Windows.Forms.Label label1;
    }
}