namespace SMS_2._0
{
    partial class AddMore
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AddMore));
            this.quantityTXTBOX = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.idTXTBOX = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.RemoveStockBttn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // quantityTXTBOX
            // 
            this.quantityTXTBOX.Location = new System.Drawing.Point(152, 139);
            this.quantityTXTBOX.Name = "quantityTXTBOX";
            this.quantityTXTBOX.Size = new System.Drawing.Size(372, 40);
            this.quantityTXTBOX.TabIndex = 28;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(34, 147);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(112, 32);
            this.label2.TabIndex = 27;
            this.label2.Text = "quantity:";
            // 
            // idTXTBOX
            // 
            this.idTXTBOX.Location = new System.Drawing.Point(152, 71);
            this.idTXTBOX.Name = "idTXTBOX";
            this.idTXTBOX.Size = new System.Drawing.Size(372, 40);
            this.idTXTBOX.TabIndex = 26;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(105, 79);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(41, 32);
            this.label1.TabIndex = 25;
            this.label1.Text = "id:";
            // 
            // RemoveStockBttn
            // 
            this.RemoveStockBttn.BackColor = System.Drawing.Color.AliceBlue;
            this.RemoveStockBttn.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.RemoveStockBttn.Location = new System.Drawing.Point(319, 202);
            this.RemoveStockBttn.Name = "RemoveStockBttn";
            this.RemoveStockBttn.Size = new System.Drawing.Size(269, 65);
            this.RemoveStockBttn.TabIndex = 24;
            this.RemoveStockBttn.Text = "Add more";
            this.RemoveStockBttn.UseVisualStyleBackColor = false;
            this.RemoveStockBttn.Click += new System.EventHandler(this.RemoveStockBttn_Click);
            // 
            // AddMore
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
            this.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.Name = "AddMore";
            this.Text = "Add more of an existing product";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox quantityTXTBOX;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox idTXTBOX;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button RemoveStockBttn;
    }
}