namespace SMS_2._0
{
    partial class Accounting
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Accounting));
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.smsDataSet6 = new SMS_2._0.smsDataSet6();
            this.profitsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.profitsTableAdapter = new SMS_2._0.smsDataSet6TableAdapters.profitsTableAdapter();
            this.idDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.salesDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.netProfitDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.profitPercentageDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dateDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.calculateProfitsBttn = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.smsDataSet6)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.profitsBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idDataGridViewTextBoxColumn,
            this.salesDataGridViewTextBoxColumn,
            this.netProfitDataGridViewTextBoxColumn,
            this.profitPercentageDataGridViewTextBoxColumn,
            this.dateDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.profitsBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(21, 27);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RowHeadersWidth = 62;
            this.dataGridView1.RowTemplate.Height = 28;
            this.dataGridView1.Size = new System.Drawing.Size(815, 623);
            this.dataGridView1.TabIndex = 0;
            // 
            // smsDataSet6
            // 
            this.smsDataSet6.DataSetName = "smsDataSet6";
            this.smsDataSet6.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // profitsBindingSource
            // 
            this.profitsBindingSource.DataMember = "profits";
            this.profitsBindingSource.DataSource = this.smsDataSet6;
            // 
            // profitsTableAdapter
            // 
            this.profitsTableAdapter.ClearBeforeFill = true;
            // 
            // idDataGridViewTextBoxColumn
            // 
            this.idDataGridViewTextBoxColumn.DataPropertyName = "id";
            this.idDataGridViewTextBoxColumn.HeaderText = "id";
            this.idDataGridViewTextBoxColumn.MinimumWidth = 8;
            this.idDataGridViewTextBoxColumn.Name = "idDataGridViewTextBoxColumn";
            this.idDataGridViewTextBoxColumn.ReadOnly = true;
            this.idDataGridViewTextBoxColumn.Width = 150;
            // 
            // salesDataGridViewTextBoxColumn
            // 
            this.salesDataGridViewTextBoxColumn.DataPropertyName = "sales";
            this.salesDataGridViewTextBoxColumn.HeaderText = "sales";
            this.salesDataGridViewTextBoxColumn.MinimumWidth = 8;
            this.salesDataGridViewTextBoxColumn.Name = "salesDataGridViewTextBoxColumn";
            this.salesDataGridViewTextBoxColumn.ReadOnly = true;
            this.salesDataGridViewTextBoxColumn.Width = 150;
            // 
            // netProfitDataGridViewTextBoxColumn
            // 
            this.netProfitDataGridViewTextBoxColumn.DataPropertyName = "netProfit";
            this.netProfitDataGridViewTextBoxColumn.HeaderText = "netProfit";
            this.netProfitDataGridViewTextBoxColumn.MinimumWidth = 8;
            this.netProfitDataGridViewTextBoxColumn.Name = "netProfitDataGridViewTextBoxColumn";
            this.netProfitDataGridViewTextBoxColumn.ReadOnly = true;
            this.netProfitDataGridViewTextBoxColumn.Width = 150;
            // 
            // profitPercentageDataGridViewTextBoxColumn
            // 
            this.profitPercentageDataGridViewTextBoxColumn.DataPropertyName = "profitPercentage";
            this.profitPercentageDataGridViewTextBoxColumn.HeaderText = "profitPercentage";
            this.profitPercentageDataGridViewTextBoxColumn.MinimumWidth = 8;
            this.profitPercentageDataGridViewTextBoxColumn.Name = "profitPercentageDataGridViewTextBoxColumn";
            this.profitPercentageDataGridViewTextBoxColumn.ReadOnly = true;
            this.profitPercentageDataGridViewTextBoxColumn.Width = 150;
            // 
            // dateDataGridViewTextBoxColumn
            // 
            this.dateDataGridViewTextBoxColumn.DataPropertyName = "date";
            this.dateDataGridViewTextBoxColumn.HeaderText = "date";
            this.dateDataGridViewTextBoxColumn.MinimumWidth = 8;
            this.dateDataGridViewTextBoxColumn.Name = "dateDataGridViewTextBoxColumn";
            this.dateDataGridViewTextBoxColumn.ReadOnly = true;
            this.dateDataGridViewTextBoxColumn.Width = 150;
            // 
            // calculateProfitsBttn
            // 
            this.calculateProfitsBttn.BackColor = System.Drawing.Color.AliceBlue;
            this.calculateProfitsBttn.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.calculateProfitsBttn.Location = new System.Drawing.Point(851, 27);
            this.calculateProfitsBttn.Name = "calculateProfitsBttn";
            this.calculateProfitsBttn.Size = new System.Drawing.Size(245, 150);
            this.calculateProfitsBttn.TabIndex = 1;
            this.calculateProfitsBttn.Text = "Calculate profits";
            this.calculateProfitsBttn.UseVisualStyleBackColor = false;
            this.calculateProfitsBttn.Click += new System.EventHandler(this.calculateProfitsBttn_Click);
            // 
            // Accounting
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(15F, 32F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(1108, 673);
            this.Controls.Add(this.calculateProfitsBttn);
            this.Controls.Add(this.dataGridView1);
            this.Font = new System.Drawing.Font("Palatino Linotype", 12F, System.Drawing.FontStyle.Bold);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(5);
            this.Name = "Accounting";
            this.Text = "Accounting";
            this.Load += new System.EventHandler(this.Accounting_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.smsDataSet6)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.profitsBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private smsDataSet6 smsDataSet6;
        private System.Windows.Forms.BindingSource profitsBindingSource;
        private smsDataSet6TableAdapters.profitsTableAdapter profitsTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn idDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn salesDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn netProfitDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn profitPercentageDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn dateDataGridViewTextBoxColumn;
        private System.Windows.Forms.Button calculateProfitsBttn;
    }
}