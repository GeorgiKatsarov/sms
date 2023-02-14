namespace SMS_2._0
{
    partial class AdminView
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AdminView));
            this.addStockBttn = new System.Windows.Forms.Button();
            this.addCashierBttn = new System.Windows.Forms.Button();
            this.refreshBttn = new System.Windows.Forms.Button();
            this.removeStockBttn = new System.Windows.Forms.Button();
            this.removeCashierBttn = new System.Windows.Forms.Button();
            this.StockDataGridView = new System.Windows.Forms.DataGridView();
            this.idDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Name = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Quantity = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Price = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.stockBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.smsDataSet2 = new SMS_2._0.smsDataSet2();
            this.CashierDataGridView = new System.Windows.Forms.DataGridView();
            this.idDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.firstNameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.lastNameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cashiersBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.smsDataSet1 = new SMS_2._0.smsDataSet1();
            this.stockTableAdapter = new SMS_2._0.smsDataSet2TableAdapters.stockTableAdapter();
            this.cashiersTableAdapter = new SMS_2._0.smsDataSet1TableAdapters.cashiersTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.StockDataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.stockBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.smsDataSet2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.CashierDataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cashiersBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.smsDataSet1)).BeginInit();
            this.SuspendLayout();
            // 
            // addStockBttn
            // 
            this.addStockBttn.BackColor = System.Drawing.Color.AliceBlue;
            this.addStockBttn.Location = new System.Drawing.Point(12, 131);
            this.addStockBttn.Name = "addStockBttn";
            this.addStockBttn.Size = new System.Drawing.Size(143, 113);
            this.addStockBttn.TabIndex = 0;
            this.addStockBttn.Text = "Add stock";
            this.addStockBttn.UseVisualStyleBackColor = false;
            // 
            // addCashierBttn
            // 
            this.addCashierBttn.BackColor = System.Drawing.Color.AliceBlue;
            this.addCashierBttn.Location = new System.Drawing.Point(12, 250);
            this.addCashierBttn.Name = "addCashierBttn";
            this.addCashierBttn.Size = new System.Drawing.Size(143, 113);
            this.addCashierBttn.TabIndex = 1;
            this.addCashierBttn.Text = "Add cashier";
            this.addCashierBttn.UseVisualStyleBackColor = false;
            // 
            // refreshBttn
            // 
            this.refreshBttn.BackColor = System.Drawing.Color.AliceBlue;
            this.refreshBttn.Location = new System.Drawing.Point(12, 12);
            this.refreshBttn.Name = "refreshBttn";
            this.refreshBttn.Size = new System.Drawing.Size(143, 113);
            this.refreshBttn.TabIndex = 4;
            this.refreshBttn.Text = "Refresh";
            this.refreshBttn.UseVisualStyleBackColor = false;
            this.refreshBttn.Click += new System.EventHandler(this.refreshBttn_Click);
            // 
            // removeStockBttn
            // 
            this.removeStockBttn.BackColor = System.Drawing.Color.AliceBlue;
            this.removeStockBttn.Location = new System.Drawing.Point(12, 369);
            this.removeStockBttn.Name = "removeStockBttn";
            this.removeStockBttn.Size = new System.Drawing.Size(143, 113);
            this.removeStockBttn.TabIndex = 6;
            this.removeStockBttn.Text = "Remove stock";
            this.removeStockBttn.UseVisualStyleBackColor = false;
            // 
            // removeCashierBttn
            // 
            this.removeCashierBttn.BackColor = System.Drawing.Color.AliceBlue;
            this.removeCashierBttn.Location = new System.Drawing.Point(12, 488);
            this.removeCashierBttn.Name = "removeCashierBttn";
            this.removeCashierBttn.Size = new System.Drawing.Size(143, 113);
            this.removeCashierBttn.TabIndex = 7;
            this.removeCashierBttn.Text = "Remove cashier";
            this.removeCashierBttn.UseVisualStyleBackColor = false;
            // 
            // StockDataGridView
            // 
            this.StockDataGridView.AllowUserToAddRows = false;
            this.StockDataGridView.AllowUserToDeleteRows = false;
            this.StockDataGridView.AutoGenerateColumns = false;
            this.StockDataGridView.BackgroundColor = System.Drawing.Color.AliceBlue;
            this.StockDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.StockDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idDataGridViewTextBoxColumn,
            this.Name,
            this.Quantity,
            this.Price});
            this.StockDataGridView.DataSource = this.stockBindingSource;
            this.StockDataGridView.Location = new System.Drawing.Point(216, 25);
            this.StockDataGridView.Name = "StockDataGridView";
            this.StockDataGridView.ReadOnly = true;
            this.StockDataGridView.RowHeadersWidth = 62;
            this.StockDataGridView.RowTemplate.Height = 28;
            this.StockDataGridView.Size = new System.Drawing.Size(664, 272);
            this.StockDataGridView.TabIndex = 8;
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
            // Name
            // 
            this.Name.DataPropertyName = "name";
            this.Name.HeaderText = "Name";
            this.Name.MinimumWidth = 8;
            this.Name.Name = "Name";
            this.Name.ReadOnly = true;
            this.Name.Width = 150;
            // 
            // Quantity
            // 
            this.Quantity.DataPropertyName = "quantity";
            this.Quantity.HeaderText = "Quantity";
            this.Quantity.MinimumWidth = 8;
            this.Quantity.Name = "Quantity";
            this.Quantity.ReadOnly = true;
            this.Quantity.Width = 150;
            // 
            // Price
            // 
            this.Price.DataPropertyName = "price";
            this.Price.HeaderText = "Price";
            this.Price.MinimumWidth = 8;
            this.Price.Name = "Price";
            this.Price.ReadOnly = true;
            this.Price.Width = 150;
            // 
            // stockBindingSource
            // 
            this.stockBindingSource.DataMember = "stock";
            this.stockBindingSource.DataSource = this.smsDataSet2;
            // 
            // smsDataSet2
            // 
            this.smsDataSet2.DataSetName = "smsDataSet2";
            this.smsDataSet2.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // CashierDataGridView
            // 
            this.CashierDataGridView.AllowUserToAddRows = false;
            this.CashierDataGridView.AllowUserToDeleteRows = false;
            this.CashierDataGridView.AutoGenerateColumns = false;
            this.CashierDataGridView.BackgroundColor = System.Drawing.Color.AliceBlue;
            this.CashierDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.CashierDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idDataGridViewTextBoxColumn1,
            this.firstNameDataGridViewTextBoxColumn,
            this.lastNameDataGridViewTextBoxColumn});
            this.CashierDataGridView.DataSource = this.cashiersBindingSource;
            this.CashierDataGridView.Location = new System.Drawing.Point(216, 320);
            this.CashierDataGridView.Name = "CashierDataGridView";
            this.CashierDataGridView.ReadOnly = true;
            this.CashierDataGridView.RowHeadersWidth = 62;
            this.CashierDataGridView.RowTemplate.Height = 28;
            this.CashierDataGridView.Size = new System.Drawing.Size(516, 261);
            this.CashierDataGridView.TabIndex = 9;
            // 
            // idDataGridViewTextBoxColumn1
            // 
            this.idDataGridViewTextBoxColumn1.DataPropertyName = "id";
            this.idDataGridViewTextBoxColumn1.HeaderText = "id";
            this.idDataGridViewTextBoxColumn1.MinimumWidth = 8;
            this.idDataGridViewTextBoxColumn1.Name = "idDataGridViewTextBoxColumn1";
            this.idDataGridViewTextBoxColumn1.ReadOnly = true;
            this.idDataGridViewTextBoxColumn1.Width = 150;
            // 
            // firstNameDataGridViewTextBoxColumn
            // 
            this.firstNameDataGridViewTextBoxColumn.DataPropertyName = "firstName";
            this.firstNameDataGridViewTextBoxColumn.HeaderText = "First name";
            this.firstNameDataGridViewTextBoxColumn.MinimumWidth = 8;
            this.firstNameDataGridViewTextBoxColumn.Name = "firstNameDataGridViewTextBoxColumn";
            this.firstNameDataGridViewTextBoxColumn.ReadOnly = true;
            this.firstNameDataGridViewTextBoxColumn.Width = 150;
            // 
            // lastNameDataGridViewTextBoxColumn
            // 
            this.lastNameDataGridViewTextBoxColumn.DataPropertyName = "lastName";
            this.lastNameDataGridViewTextBoxColumn.HeaderText = "Last name";
            this.lastNameDataGridViewTextBoxColumn.MinimumWidth = 8;
            this.lastNameDataGridViewTextBoxColumn.Name = "lastNameDataGridViewTextBoxColumn";
            this.lastNameDataGridViewTextBoxColumn.ReadOnly = true;
            this.lastNameDataGridViewTextBoxColumn.Width = 150;
            // 
            // cashiersBindingSource
            // 
            this.cashiersBindingSource.DataMember = "cashiers";
            this.cashiersBindingSource.DataSource = this.smsDataSet1;
            // 
            // smsDataSet1
            // 
            this.smsDataSet1.DataSetName = "smsDataSet1";
            this.smsDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // stockTableAdapter
            // 
            this.stockTableAdapter.ClearBeforeFill = true;
            // 
            // cashiersTableAdapter
            // 
            this.cashiersTableAdapter.ClearBeforeFill = true;
            // 
            // AdminView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(15F, 32F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(959, 615);
            this.Controls.Add(this.CashierDataGridView);
            this.Controls.Add(this.StockDataGridView);
            this.Controls.Add(this.removeCashierBttn);
            this.Controls.Add(this.removeStockBttn);
            this.Controls.Add(this.refreshBttn);
            this.Controls.Add(this.addCashierBttn);
            this.Controls.Add(this.addStockBttn);
            this.Font = new System.Drawing.Font("Palatino Linotype", 12F, System.Drawing.FontStyle.Bold);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(5);
            this.MaximumSize = new System.Drawing.Size(981, 671);
            this.MinimumSize = new System.Drawing.Size(981, 671);
            this.Load += new System.EventHandler(this.AdminView_Load);
            ((System.ComponentModel.ISupportInitialize)(this.StockDataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.stockBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.smsDataSet2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.CashierDataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cashiersBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.smsDataSet1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button addStockBttn;
        private System.Windows.Forms.Button addCashierBttn;
        private System.Windows.Forms.Button refreshBttn;
        private System.Windows.Forms.Button removeStockBttn;
        private System.Windows.Forms.Button removeCashierBttn;
        private System.Windows.Forms.DataGridView StockDataGridView;
        private System.Windows.Forms.DataGridView CashierDataGridView;
        private smsDataSet2 smsDataSet2;
        private System.Windows.Forms.BindingSource stockBindingSource;
        private smsDataSet2TableAdapters.stockTableAdapter stockTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn idDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn Name;
        private System.Windows.Forms.DataGridViewTextBoxColumn Quantity;
        private System.Windows.Forms.DataGridViewTextBoxColumn Price;
        private smsDataSet1 smsDataSet1;
        private System.Windows.Forms.BindingSource cashiersBindingSource;
        private smsDataSet1TableAdapters.cashiersTableAdapter cashiersTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn idDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn firstNameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn lastNameDataGridViewTextBoxColumn;
    }
}