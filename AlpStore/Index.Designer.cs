namespace AlpStores
{
    partial class Index
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
            this.login = new System.Windows.Forms.GroupBox();
            this.newUser = new System.Windows.Forms.LinkLabel();
            this.lgnbtn = new System.Windows.Forms.Button();
            this.usercode = new System.Windows.Forms.TextBox();
            this.userid = new System.Windows.Forms.TextBox();
            this.usecode = new System.Windows.Forms.Label();
            this.usename = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.login.SuspendLayout();
            this.SuspendLayout();
            // 
            // login
            // 
            this.login.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.login.Controls.Add(this.newUser);
            this.login.Controls.Add(this.lgnbtn);
            this.login.Controls.Add(this.usercode);
            this.login.Controls.Add(this.userid);
            this.login.Controls.Add(this.usecode);
            this.login.Controls.Add(this.usename);
            this.login.Location = new System.Drawing.Point(24, 113);
            this.login.Margin = new System.Windows.Forms.Padding(6, 5, 6, 5);
            this.login.Name = "login";
            this.login.Padding = new System.Windows.Forms.Padding(6, 5, 6, 5);
            this.login.Size = new System.Drawing.Size(706, 308);
            this.login.TabIndex = 0;
            this.login.TabStop = false;
            this.login.Text = "LOGIN";
            // 
            // newUser
            // 
            this.newUser.AutoSize = true;
            this.newUser.Location = new System.Drawing.Point(304, 249);
            this.newUser.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.newUser.Name = "newUser";
            this.newUser.Size = new System.Drawing.Size(315, 22);
            this.newUser.TabIndex = 5;
            this.newUser.TabStop = true;
            this.newUser.Text = "Forgot Password? Click me to reset";
            this.newUser.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.newUser_LinkClicked);
            // 
            // lgnbtn
            // 
            this.lgnbtn.Location = new System.Drawing.Point(365, 164);
            this.lgnbtn.Margin = new System.Windows.Forms.Padding(6, 5, 6, 5);
            this.lgnbtn.Name = "lgnbtn";
            this.lgnbtn.Size = new System.Drawing.Size(257, 39);
            this.lgnbtn.TabIndex = 4;
            this.lgnbtn.Text = "ACCESS SYSTEM";
            this.lgnbtn.UseVisualStyleBackColor = true;
            this.lgnbtn.Click += new System.EventHandler(this.lgnbtn_Click);
            // 
            // usercode
            // 
            this.usercode.Location = new System.Drawing.Point(288, 98);
            this.usercode.Margin = new System.Windows.Forms.Padding(6, 5, 6, 5);
            this.usercode.MaxLength = 8;
            this.usercode.Name = "usercode";
            this.usercode.PasswordChar = '*';
            this.usercode.Size = new System.Drawing.Size(330, 30);
            this.usercode.TabIndex = 3;
            this.usercode.TextChanged += new System.EventHandler(this.usercode_TextChanged);
            // 
            // userid
            // 
            this.userid.Location = new System.Drawing.Point(288, 30);
            this.userid.Margin = new System.Windows.Forms.Padding(6, 5, 6, 5);
            this.userid.MaxLength = 15;
            this.userid.Name = "userid";
            this.userid.Size = new System.Drawing.Size(330, 30);
            this.userid.TabIndex = 2;
            this.userid.TextChanged += new System.EventHandler(this.userid_TextChanged);
            // 
            // usecode
            // 
            this.usecode.AutoSize = true;
            this.usecode.Location = new System.Drawing.Point(59, 110);
            this.usecode.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.usecode.Name = "usecode";
            this.usecode.Size = new System.Drawing.Size(109, 22);
            this.usecode.TabIndex = 1;
            this.usecode.Text = "USER CODE";
            // 
            // usename
            // 
            this.usename.AutoSize = true;
            this.usename.Location = new System.Drawing.Point(59, 44);
            this.usename.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.usename.Name = "usename";
            this.usename.Size = new System.Drawing.Size(81, 22);
            this.usename.TabIndex = 0;
            this.usename.Text = "USER ID";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label1.ForeColor = System.Drawing.Color.MediumBlue;
            this.label1.Location = new System.Drawing.Point(209, 15);
            this.label1.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(316, 24);
            this.label1.TabIndex = 0;
            this.label1.Text = "NATIONAL REGISTRATION BUREAU";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label2.ForeColor = System.Drawing.Color.DarkBlue;
            this.label2.Location = new System.Drawing.Point(216, 68);
            this.label2.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(286, 24);
            this.label2.TabIndex = 1;
            this.label2.Text = "STORES MANAGEMENT SYSTEM";
            this.label2.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // Index
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 22F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(752, 442);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.login);
            this.Font = new System.Drawing.Font("Cambria", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(6, 5, 6, 5);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Index";
            this.Text = "NRBSMS";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Index_FormClosing);
            this.Load += new System.EventHandler(this.Index_Load);
            this.login.ResumeLayout(false);
            this.login.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox login;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.LinkLabel newUser;
        private System.Windows.Forms.Button lgnbtn;
        private System.Windows.Forms.TextBox usercode;
        private System.Windows.Forms.TextBox userid;
        private System.Windows.Forms.Label usecode;
        private System.Windows.Forms.Label usename;
        private System.Windows.Forms.Label label2;
    }
}