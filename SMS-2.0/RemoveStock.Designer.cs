namespace SMS_2._0
{
    partial class RemoveStock
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(RemoveStock));
            this.label1 = new System.Windows.Forms.Label();
            this.RemoveStockBttn = new System.Windows.Forms.Button();
            this.idTXTBOX = new System.Windows.Forms.TextBox();
            this.quantityTXTBOX = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(90, 107);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(41, 32);
            this.label1.TabIndex = 18;
            this.label1.Text = "id:";
            // 
            // RemoveStockBttn
            // 
            this.RemoveStockBttn.BackColor = System.Drawing.Color.AliceBlue;
            this.RemoveStockBttn.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.RemoveStockBttn.Location = new System.Drawing.Point(304, 230);
            this.RemoveStockBttn.Name = "RemoveStockBttn";
            this.RemoveStockBttn.Size = new System.Drawing.Size(269, 65);
            this.RemoveStockBttn.TabIndex = 17;
            this.RemoveStockBttn.Text = "Remove stock";
            this.RemoveStockBttn.UseVisualStyleBackColor = false;
            this.RemoveStockBttn.Click += new System.EventHandler(this.RemoveStockBttn_Click);
            // 
            // idTXTBOX
            // 
            this.idTXTBOX.Location = new System.Drawing.Point(137, 99);
            this.idTXTBOX.Name = "idTXTBOX";
            this.idTXTBOX.Size = new System.Drawing.Size(372, 40);
            this.idTXTBOX.TabIndex = 21;
            // 
            // quantityTXTBOX
            // 
            this.quantityTXTBOX.Location = new System.Drawing.Point(137, 167);
            this.quantityTXTBOX.Name = "quantityTXTBOX";
            this.quantityTXTBOX.Size = new System.Drawing.Size(372, 40);
            this.quantityTXTBOX.TabIndex = 23;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(19, 175);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(112, 32);
            this.label2.TabIndex = 22;
            this.label2.Text = "quantity:";
            // 
            // RemoveStock
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(15F, 32F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(623, 339);
            this.Controls.Add(this.quantityTXTBOX);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.idTXTBOX);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.RemoveStockBttn);
            this.Font = new System.Drawing.Font("Palatino Linotype", 12F, System.Drawing.FontStyle.Bold);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(5);
            this.Name = "RemoveStock";
            this.Text = "RemoveStock";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button RemoveStockBttn;
        private System.Windows.Forms.TextBox idTXTBOX;
        private System.Windows.Forms.TextBox quantityTXTBOX;
        private System.Windows.Forms.Label label2;
    }
}