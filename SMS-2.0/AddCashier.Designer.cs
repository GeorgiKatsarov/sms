﻿namespace SMS_2._0
{
    partial class AddCashier
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AddCashier));
            this.lastNameTXTBOX = new System.Windows.Forms.TextBox();
            this.firstNameTXTBOX = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.addCashierBttn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lastNameTXTBOX
            // 
            this.lastNameTXTBOX.Location = new System.Drawing.Point(160, 155);
            this.lastNameTXTBOX.Name = "lastNameTXTBOX";
            this.lastNameTXTBOX.Size = new System.Drawing.Size(372, 40);
            this.lastNameTXTBOX.TabIndex = 12;
            // 
            // firstNameTXTBOX
            // 
            this.firstNameTXTBOX.Location = new System.Drawing.Point(160, 90);
            this.firstNameTXTBOX.Name = "firstNameTXTBOX";
            this.firstNameTXTBOX.Size = new System.Drawing.Size(372, 40);
            this.firstNameTXTBOX.TabIndex = 11;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(30, 158);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(132, 32);
            this.label2.TabIndex = 9;
            this.label2.Text = "Last name:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(30, 90);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(134, 32);
            this.label1.TabIndex = 8;
            this.label1.Text = "First name:";
            // 
            // addCashierBttn
            // 
            this.addCashierBttn.BackColor = System.Drawing.Color.AliceBlue;
            this.addCashierBttn.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.addCashierBttn.Location = new System.Drawing.Point(330, 242);
            this.addCashierBttn.Name = "addCashierBttn";
            this.addCashierBttn.Size = new System.Drawing.Size(269, 65);
            this.addCashierBttn.TabIndex = 7;
            this.addCashierBttn.Text = "Add cashier";
            this.addCashierBttn.UseVisualStyleBackColor = false;
            this.addCashierBttn.Click += new System.EventHandler(this.addCashierBttn_Click);
            // 
            // AddCashier
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(15F, 32F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(623, 339);
            this.Controls.Add(this.lastNameTXTBOX);
            this.Controls.Add(this.firstNameTXTBOX);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.addCashierBttn);
            this.Font = new System.Drawing.Font("Palatino Linotype", 12F, System.Drawing.FontStyle.Bold);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.Name = "AddCashier";
            this.Text = "AddCashier";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox lastNameTXTBOX;
        private System.Windows.Forms.TextBox firstNameTXTBOX;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button addCashierBttn;
    }
}