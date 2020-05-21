namespace My_Turkish_English_Dictionary
{
    partial class FormLogin
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormLogin));
            this.btn_login = new System.Windows.Forms.Button();
            this.btn_singup = new System.Windows.Forms.Button();
            this.txtbox_login_username = new System.Windows.Forms.TextBox();
            this.txtbox_login_password = new System.Windows.Forms.TextBox();
            this.btn_showpassword = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btn_login
            // 
            this.btn_login.BackColor = System.Drawing.Color.Black;
            this.btn_login.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btn_login.ForeColor = System.Drawing.Color.White;
            this.btn_login.Location = new System.Drawing.Point(0, 362);
            this.btn_login.Name = "btn_login";
            this.btn_login.Size = new System.Drawing.Size(410, 54);
            this.btn_login.TabIndex = 0;
            this.btn_login.Text = "Login";
            this.btn_login.UseVisualStyleBackColor = false;
            this.btn_login.Click += new System.EventHandler(this.btn_login_Click);
            // 
            // btn_singup
            // 
            this.btn_singup.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btn_singup.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btn_singup.ForeColor = System.Drawing.Color.White;
            this.btn_singup.Location = new System.Drawing.Point(0, 480);
            this.btn_singup.Name = "btn_singup";
            this.btn_singup.Size = new System.Drawing.Size(410, 47);
            this.btn_singup.TabIndex = 1;
            this.btn_singup.Text = "Sing Up";
            this.btn_singup.UseVisualStyleBackColor = false;
            this.btn_singup.Click += new System.EventHandler(this.btn_singup_Click);
            // 
            // txtbox_login_username
            // 
            this.txtbox_login_username.BackColor = System.Drawing.SystemColors.MenuBar;
            this.txtbox_login_username.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtbox_login_username.ForeColor = System.Drawing.Color.DimGray;
            this.txtbox_login_username.Location = new System.Drawing.Point(86, 180);
            this.txtbox_login_username.Multiline = true;
            this.txtbox_login_username.Name = "txtbox_login_username";
            this.txtbox_login_username.Size = new System.Drawing.Size(244, 33);
            this.txtbox_login_username.TabIndex = 4;
            this.txtbox_login_username.Text = "Username";
            this.txtbox_login_username.Click += new System.EventHandler(this.txtbox_login_username_Click);
            this.txtbox_login_username.TextChanged += new System.EventHandler(this.txtbox_login_username_TextChanged);
            this.txtbox_login_username.Enter += new System.EventHandler(this.txtbox_login_username_Enter);
            this.txtbox_login_username.Leave += new System.EventHandler(this.txtbox_login_username_Leave);
            // 
            // txtbox_login_password
            // 
            this.txtbox_login_password.BackColor = System.Drawing.SystemColors.MenuBar;
            this.txtbox_login_password.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtbox_login_password.ForeColor = System.Drawing.Color.DimGray;
            this.txtbox_login_password.Location = new System.Drawing.Point(86, 256);
            this.txtbox_login_password.Multiline = true;
            this.txtbox_login_password.Name = "txtbox_login_password";
            this.txtbox_login_password.PasswordChar = '*';
            this.txtbox_login_password.Size = new System.Drawing.Size(244, 33);
            this.txtbox_login_password.TabIndex = 5;
            this.txtbox_login_password.Text = "Password";
            this.txtbox_login_password.Click += new System.EventHandler(this.txtbox_login_password_Click);
            this.txtbox_login_password.Enter += new System.EventHandler(this.txtbox_login_password_Enter);
            this.txtbox_login_password.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtbox_login_password_KeyDown);
            this.txtbox_login_password.Leave += new System.EventHandler(this.txtbox_login_password_Leave);
            // 
            // btn_showpassword
            // 
            this.btn_showpassword.Image = ((System.Drawing.Image)(resources.GetObject("btn_showpassword.Image")));
            this.btn_showpassword.Location = new System.Drawing.Point(353, 256);
            this.btn_showpassword.Name = "btn_showpassword";
            this.btn_showpassword.Size = new System.Drawing.Size(33, 33);
            this.btn_showpassword.TabIndex = 7;
            this.btn_showpassword.UseVisualStyleBackColor = true;
            this.btn_showpassword.Click += new System.EventHandler(this.btn_showpassword_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Palatino Linotype", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(111, 32);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(196, 65);
            this.label1.TabIndex = 8;
            this.label1.Text = "LOGIN";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(165, 446);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(79, 13);
            this.label2.TabIndex = 9;
            this.label2.Text = "Not a member?";
            // 
            // FormLogin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(410, 528);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btn_showpassword);
            this.Controls.Add(this.txtbox_login_password);
            this.Controls.Add(this.txtbox_login_username);
            this.Controls.Add(this.btn_singup);
            this.Controls.Add(this.btn_login);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FormLogin";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Login";
            this.Load += new System.EventHandler(this.FormLogin_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn_login;
        private System.Windows.Forms.Button btn_singup;
        private System.Windows.Forms.TextBox txtbox_login_username;
        private System.Windows.Forms.TextBox txtbox_login_password;
        private System.Windows.Forms.Button btn_showpassword;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
    }
}

