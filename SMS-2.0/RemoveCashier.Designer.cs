﻿namespace SMS_2._0
{
    partial class RemoveCashier
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(RemoveCashier));
            this.idTXTBOX = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.RemoveCashierBttn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // idTXTBOX
            // 
            this.idTXTBOX.Location = new System.Drawing.Point(158, 113);
            this.idTXTBOX.Name = "idTXTBOX";
            this.idTXTBOX.Size = new System.Drawing.Size(372, 40);
            this.idTXTBOX.TabIndex = 16;
            this.idTXTBOX.TextChanged += new System.EventHandler(this.idTXTBOX_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(88, 116);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(41, 32);
            this.label1.TabIndex = 14;
            this.label1.Text = "id:";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // RemoveCashierBttn
            // 
            this.RemoveCashierBttn.BackColor = System.Drawing.Color.AliceBlue;
            this.RemoveCashierBttn.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.RemoveCashierBttn.Location = new System.Drawing.Point(327, 213);
            this.RemoveCashierBttn.Name = "RemoveCashierBttn";
            this.RemoveCashierBttn.Size = new System.Drawing.Size(269, 65);
            this.RemoveCashierBttn.TabIndex = 13;
            this.RemoveCashierBttn.Text = "Remove cashier";
            this.RemoveCashierBttn.UseVisualStyleBackColor = false;
            this.RemoveCashierBttn.Click += new System.EventHandler(this.RemoveCashierBttn_Click);
            // 
            // RemoveCashier
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(15F, 32F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(623, 339);
            this.Controls.Add(this.idTXTBOX);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.RemoveCashierBttn);
            this.Font = new System.Drawing.Font("Palatino Linotype", 12F, System.Drawing.FontStyle.Bold);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.Name = "RemoveCashier";
            this.Text = "RemoveCashier";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox idTXTBOX;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button RemoveCashierBttn;
    }
}