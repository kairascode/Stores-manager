namespace AlpStores
{
    partial class resetpass
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.uid = new System.Windows.Forms.TextBox();
            this.oldcode = new System.Windows.Forms.TextBox();
            this.newcode = new System.Windows.Forms.TextBox();
            this.confirmcode = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.outputer = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label1.Font = new System.Drawing.Font("Cambria", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.DarkBlue;
            this.label1.Location = new System.Drawing.Point(70, 24);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(218, 24);
            this.label1.TabIndex = 0;
            this.label1.Text = "RESET USERCODE PANE";
            this.label1.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Cambria", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Red;
            this.label2.Location = new System.Drawing.Point(101, 100);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(69, 19);
            this.label2.TabIndex = 1;
            this.label2.Text = "USER ID";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Cambria", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.Red;
            this.label3.Location = new System.Drawing.Point(47, 140);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(123, 19);
            this.label3.TabIndex = 2;
            this.label3.Text = "OLD USERCODE";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Cambria", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.Red;
            this.label4.Location = new System.Drawing.Point(43, 187);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(127, 19);
            this.label4.TabIndex = 3;
            this.label4.Text = "NEW USERCODE";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Cambria", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.Red;
            this.label5.Location = new System.Drawing.Point(7, 233);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(163, 19);
            this.label5.TabIndex = 4;
            this.label5.Text = "CONFIRM USERCODE";
            // 
            // uid
            // 
            this.uid.Location = new System.Drawing.Point(177, 97);
            this.uid.MaxLength = 15;
            this.uid.Name = "uid";
            this.uid.Size = new System.Drawing.Size(154, 20);
            this.uid.TabIndex = 5;
            // 
            // oldcode
            // 
            this.oldcode.Location = new System.Drawing.Point(177, 137);
            this.oldcode.MaxLength = 8;
            this.oldcode.Name = "oldcode";
            this.oldcode.PasswordChar = '*';
            this.oldcode.Size = new System.Drawing.Size(154, 20);
            this.oldcode.TabIndex = 6;
            // 
            // newcode
            // 
            this.newcode.Location = new System.Drawing.Point(181, 184);
            this.newcode.MaxLength = 8;
            this.newcode.Name = "newcode";
            this.newcode.PasswordChar = '*';
            this.newcode.Size = new System.Drawing.Size(150, 20);
            this.newcode.TabIndex = 7;
            // 
            // confirmcode
            // 
            this.confirmcode.Location = new System.Drawing.Point(182, 230);
            this.confirmcode.MaxLength = 8;
            this.confirmcode.Name = "confirmcode";
            this.confirmcode.PasswordChar = '*';
            this.confirmcode.Size = new System.Drawing.Size(149, 20);
            this.confirmcode.TabIndex = 8;
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.DeepSkyBlue;
            this.button1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.button1.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.button1.FlatAppearance.BorderSize = 5;
            this.button1.Location = new System.Drawing.Point(182, 273);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(149, 23);
            this.button1.TabIndex = 9;
            this.button1.Text = "RESET USERCODE";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // outputer
            // 
            this.outputer.AutoSize = true;
            this.outputer.Location = new System.Drawing.Point(86, 64);
            this.outputer.Name = "outputer";
            this.outputer.Size = new System.Drawing.Size(0, 13);
            this.outputer.TabIndex = 10;
            // 
            // resetpass
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(357, 314);
            this.Controls.Add(this.outputer);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.confirmcode);
            this.Controls.Add(this.newcode);
            this.Controls.Add(this.oldcode);
            this.Controls.Add(this.uid);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "resetpass";
            this.Text = "NRBSMS-RESET";
            this.TransparencyKey = System.Drawing.Color.RosyBrown;
            this.Load += new System.EventHandler(this.resetpass_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox uid;
        private System.Windows.Forms.TextBox oldcode;
        private System.Windows.Forms.TextBox newcode;
        private System.Windows.Forms.TextBox confirmcode;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label outputer;
    }
}