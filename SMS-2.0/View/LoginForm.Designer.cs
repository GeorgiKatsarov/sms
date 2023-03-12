namespace SMS_2._0
{
    partial class LoginForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(LoginForm));
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.usernameTXTBX = new System.Windows.Forms.TextBox();
            this.passwordTXTBX = new System.Windows.Forms.TextBox();
            this.userLoginBttn = new System.Windows.Forms.Button();
            this.adminLoginBttn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(20, 35);
            this.label1.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(252, 64);
            this.label1.TabIndex = 0;
            this.label1.Text = "WELCOME TO SMS \r\nPLEASE LOGIN\r\n";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(20, 161);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(137, 32);
            this.label2.TabIndex = 1;
            this.label2.Text = "Username :";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(27, 223);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(130, 32);
            this.label3.TabIndex = 2;
            this.label3.Text = "Password :";
            // 
            // usernameTXTBX
            // 
            this.usernameTXTBX.Location = new System.Drawing.Point(183, 161);
            this.usernameTXTBX.Name = "usernameTXTBX";
            this.usernameTXTBX.Size = new System.Drawing.Size(225, 40);
            this.usernameTXTBX.TabIndex = 3;
            // 
            // passwordTXTBX
            // 
            this.passwordTXTBX.Location = new System.Drawing.Point(183, 223);
            this.passwordTXTBX.Name = "passwordTXTBX";
            this.passwordTXTBX.Size = new System.Drawing.Size(225, 40);
            this.passwordTXTBX.TabIndex = 4;
            // 
            // userLoginBttn
            // 
            this.userLoginBttn.BackColor = System.Drawing.Color.AliceBlue;
            this.userLoginBttn.Location = new System.Drawing.Point(28, 319);
            this.userLoginBttn.Name = "userLoginBttn";
            this.userLoginBttn.Size = new System.Drawing.Size(171, 62);
            this.userLoginBttn.TabIndex = 5;
            this.userLoginBttn.Text = "Cashier";
            this.userLoginBttn.UseVisualStyleBackColor = false;
            this.userLoginBttn.Click += new System.EventHandler(this.userLoginBttn_Click);
            // 
            // adminLoginBttn
            // 
            this.adminLoginBttn.BackColor = System.Drawing.Color.AliceBlue;
            this.adminLoginBttn.Location = new System.Drawing.Point(237, 319);
            this.adminLoginBttn.Name = "adminLoginBttn";
            this.adminLoginBttn.Size = new System.Drawing.Size(171, 62);
            this.adminLoginBttn.TabIndex = 6;
            this.adminLoginBttn.Text = "Admin";
            this.adminLoginBttn.UseVisualStyleBackColor = false;
            this.adminLoginBttn.Click += new System.EventHandler(this.adminLoginBttn_Click);
            // 
            // LoginForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(15F, 32F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(439, 424);
            this.Controls.Add(this.adminLoginBttn);
            this.Controls.Add(this.userLoginBttn);
            this.Controls.Add(this.passwordTXTBX);
            this.Controls.Add(this.usernameTXTBX);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Cursor = System.Windows.Forms.Cursors.Default;
            this.Font = new System.Drawing.Font("Palatino Linotype", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(5);
            this.MaximumSize = new System.Drawing.Size(461, 480);
            this.MinimumSize = new System.Drawing.Size(461, 480);
            this.Name = "LoginForm";
            this.Text = "SMS";
            this.Load += new System.EventHandler(this.LoginForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox usernameTXTBX;
        private System.Windows.Forms.TextBox passwordTXTBX;
        private System.Windows.Forms.Button userLoginBttn;
        private System.Windows.Forms.Button adminLoginBttn;
    }
}

