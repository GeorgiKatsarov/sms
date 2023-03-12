namespace SMS_2._0
{
    partial class AddStock
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AddStock));
            this.addStockBttn = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.nameTXTBOX = new System.Windows.Forms.TextBox();
            this.quantityTXTBOX = new System.Windows.Forms.TextBox();
            this.priceTXTBOX = new System.Windows.Forms.TextBox();
            this.deliveryPriceTXTBOX = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // addStockBttn
            // 
            this.addStockBttn.BackColor = System.Drawing.Color.AliceBlue;
            this.addStockBttn.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.addStockBttn.Location = new System.Drawing.Point(338, 265);
            this.addStockBttn.Name = "addStockBttn";
            this.addStockBttn.Size = new System.Drawing.Size(269, 65);
            this.addStockBttn.TabIndex = 0;
            this.addStockBttn.Text = "Add stock";
            this.addStockBttn.UseVisualStyleBackColor = false;
            this.addStockBttn.Click += new System.EventHandler(this.addStockBttn_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(65, 43);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(85, 32);
            this.label1.TabIndex = 1;
            this.label1.Text = "Name:";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(32, 111);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(118, 32);
            this.label2.TabIndex = 2;
            this.label2.Text = "Quantity:";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(65, 169);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(74, 32);
            this.label3.TabIndex = 3;
            this.label3.Text = "Price:";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // nameTXTBOX
            // 
            this.nameTXTBOX.Location = new System.Drawing.Point(173, 40);
            this.nameTXTBOX.Name = "nameTXTBOX";
            this.nameTXTBOX.Size = new System.Drawing.Size(372, 40);
            this.nameTXTBOX.TabIndex = 4;
            this.nameTXTBOX.TextChanged += new System.EventHandler(this.nameTXTBOX_TextChanged);
            // 
            // quantityTXTBOX
            // 
            this.quantityTXTBOX.Location = new System.Drawing.Point(173, 108);
            this.quantityTXTBOX.Name = "quantityTXTBOX";
            this.quantityTXTBOX.Size = new System.Drawing.Size(372, 40);
            this.quantityTXTBOX.TabIndex = 5;
            this.quantityTXTBOX.TextChanged += new System.EventHandler(this.quantityTXTBOX_TextChanged);
            // 
            // priceTXTBOX
            // 
            this.priceTXTBOX.Location = new System.Drawing.Point(173, 166);
            this.priceTXTBOX.Name = "priceTXTBOX";
            this.priceTXTBOX.Size = new System.Drawing.Size(372, 40);
            this.priceTXTBOX.TabIndex = 6;
            this.priceTXTBOX.TextChanged += new System.EventHandler(this.priceTXTBOX_TextChanged);
            // 
            // deliveryPriceTXTBOX
            // 
            this.deliveryPriceTXTBOX.Location = new System.Drawing.Point(173, 219);
            this.deliveryPriceTXTBOX.Name = "deliveryPriceTXTBOX";
            this.deliveryPriceTXTBOX.Size = new System.Drawing.Size(372, 40);
            this.deliveryPriceTXTBOX.TabIndex = 8;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(-5, 219);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(172, 32);
            this.label4.TabIndex = 7;
            this.label4.Text = "Delivery price:";
            // 
            // AddStock
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(15F, 32F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoValidate = System.Windows.Forms.AutoValidate.EnableAllowFocusChange;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(623, 339);
            this.Controls.Add(this.deliveryPriceTXTBOX);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.priceTXTBOX);
            this.Controls.Add(this.quantityTXTBOX);
            this.Controls.Add(this.nameTXTBOX);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.addStockBttn);
            this.Font = new System.Drawing.Font("Palatino Linotype", 12F, System.Drawing.FontStyle.Bold);
            this.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(5);
            this.Name = "AddStock";
            this.Text = "Add stock";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button addStockBttn;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox nameTXTBOX;
        private System.Windows.Forms.TextBox quantityTXTBOX;
        private System.Windows.Forms.TextBox priceTXTBOX;
        private System.Windows.Forms.TextBox deliveryPriceTXTBOX;
        private System.Windows.Forms.Label label4;
    }
}