namespace SMS_2._0
{
    partial class MoreOfAdminView
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MoreOfAdminView));
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.smsDataSet4 = new SMS_2._0.smsDataSet4();
            this.removedstockBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.removedstockTableAdapter = new SMS_2._0.smsDataSet4TableAdapters.removedstockTableAdapter();
            this.dataGridView2 = new System.Windows.Forms.DataGridView();
            this.soldstockBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.soldstockTableAdapter = new SMS_2._0.smsDataSet4TableAdapters.soldstockTableAdapter();
            this.idDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.soldProductIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.quantityDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dateOfSaleDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.removedProductID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.quantityOfProduct = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dateOfRemoval = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridView3 = new System.Windows.Forms.DataGridView();
            this.dataGridView4 = new System.Windows.Forms.DataGridView();
            this.smsDataSet5 = new SMS_2._0.smsDataSet5();
            this.addedstockBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.addedstockTableAdapter = new SMS_2._0.smsDataSet5TableAdapters.addedstockTableAdapter();
            this.addedstockBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.smsDataSet5BindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.newdeliveryBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.newdeliveryTableAdapter = new SMS_2._0.smsDataSet5TableAdapters.newdeliveryTableAdapter();
            this.idDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.deliveryProductIdDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.quantityDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dateDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.addedProductId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.quantity = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.date = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.smsDataSet4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.removedstockBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.soldstockBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.smsDataSet5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.addedstockBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.addedstockBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.smsDataSet5BindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.newdeliveryBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.id,
            this.removedProductID,
            this.quantityOfProduct,
            this.dateOfRemoval});
            this.dataGridView1.DataSource = this.removedstockBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(12, 12);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RowHeadersWidth = 62;
            this.dataGridView1.RowTemplate.Height = 28;
            this.dataGridView1.Size = new System.Drawing.Size(511, 303);
            this.dataGridView1.TabIndex = 0;
            // 
            // smsDataSet4
            // 
            this.smsDataSet4.DataSetName = "smsDataSet4";
            this.smsDataSet4.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // removedstockBindingSource
            // 
            this.removedstockBindingSource.DataMember = "removedstock";
            this.removedstockBindingSource.DataSource = this.smsDataSet4;
            // 
            // removedstockTableAdapter
            // 
            this.removedstockTableAdapter.ClearBeforeFill = true;
            // 
            // dataGridView2
            // 
            this.dataGridView2.AllowUserToAddRows = false;
            this.dataGridView2.AllowUserToDeleteRows = false;
            this.dataGridView2.AutoGenerateColumns = false;
            this.dataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView2.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idDataGridViewTextBoxColumn1,
            this.soldProductIDDataGridViewTextBoxColumn,
            this.quantityDataGridViewTextBoxColumn,
            this.dateOfSaleDataGridViewTextBoxColumn});
            this.dataGridView2.DataSource = this.soldstockBindingSource;
            this.dataGridView2.Location = new System.Drawing.Point(12, 345);
            this.dataGridView2.Name = "dataGridView2";
            this.dataGridView2.ReadOnly = true;
            this.dataGridView2.RowHeadersWidth = 62;
            this.dataGridView2.RowTemplate.Height = 28;
            this.dataGridView2.Size = new System.Drawing.Size(511, 287);
            this.dataGridView2.TabIndex = 1;
            // 
            // soldstockBindingSource
            // 
            this.soldstockBindingSource.DataMember = "soldstock";
            this.soldstockBindingSource.DataSource = this.smsDataSet4;
            // 
            // soldstockTableAdapter
            // 
            this.soldstockTableAdapter.ClearBeforeFill = true;
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
            // soldProductIDDataGridViewTextBoxColumn
            // 
            this.soldProductIDDataGridViewTextBoxColumn.DataPropertyName = "soldProductID";
            this.soldProductIDDataGridViewTextBoxColumn.HeaderText = "soldProductID";
            this.soldProductIDDataGridViewTextBoxColumn.MinimumWidth = 8;
            this.soldProductIDDataGridViewTextBoxColumn.Name = "soldProductIDDataGridViewTextBoxColumn";
            this.soldProductIDDataGridViewTextBoxColumn.ReadOnly = true;
            this.soldProductIDDataGridViewTextBoxColumn.Width = 150;
            // 
            // quantityDataGridViewTextBoxColumn
            // 
            this.quantityDataGridViewTextBoxColumn.DataPropertyName = "quantity";
            this.quantityDataGridViewTextBoxColumn.HeaderText = "quantity";
            this.quantityDataGridViewTextBoxColumn.MinimumWidth = 8;
            this.quantityDataGridViewTextBoxColumn.Name = "quantityDataGridViewTextBoxColumn";
            this.quantityDataGridViewTextBoxColumn.ReadOnly = true;
            this.quantityDataGridViewTextBoxColumn.Width = 150;
            // 
            // dateOfSaleDataGridViewTextBoxColumn
            // 
            this.dateOfSaleDataGridViewTextBoxColumn.DataPropertyName = "dateOfSale";
            this.dateOfSaleDataGridViewTextBoxColumn.HeaderText = "dateOfSale";
            this.dateOfSaleDataGridViewTextBoxColumn.MinimumWidth = 8;
            this.dateOfSaleDataGridViewTextBoxColumn.Name = "dateOfSaleDataGridViewTextBoxColumn";
            this.dateOfSaleDataGridViewTextBoxColumn.ReadOnly = true;
            this.dateOfSaleDataGridViewTextBoxColumn.Width = 150;
            // 
            // id
            // 
            this.id.DataPropertyName = "id";
            this.id.HeaderText = "id";
            this.id.MinimumWidth = 8;
            this.id.Name = "id";
            this.id.ReadOnly = true;
            this.id.Width = 150;
            // 
            // removedProductID
            // 
            this.removedProductID.DataPropertyName = "removedProductID";
            this.removedProductID.HeaderText = "removedProductID";
            this.removedProductID.MinimumWidth = 8;
            this.removedProductID.Name = "removedProductID";
            this.removedProductID.ReadOnly = true;
            this.removedProductID.Width = 150;
            // 
            // quantityOfProduct
            // 
            this.quantityOfProduct.DataPropertyName = "quantityOfProduct";
            this.quantityOfProduct.HeaderText = "quantityOfProduct";
            this.quantityOfProduct.MinimumWidth = 8;
            this.quantityOfProduct.Name = "quantityOfProduct";
            this.quantityOfProduct.ReadOnly = true;
            this.quantityOfProduct.Width = 150;
            // 
            // dateOfRemoval
            // 
            this.dateOfRemoval.DataPropertyName = "dateOfRemoval";
            this.dateOfRemoval.HeaderText = "dateOfRemoval";
            this.dateOfRemoval.MinimumWidth = 8;
            this.dateOfRemoval.Name = "dateOfRemoval";
            this.dateOfRemoval.ReadOnly = true;
            this.dateOfRemoval.Width = 150;
            // 
            // dataGridView3
            // 
            this.dataGridView3.AllowUserToAddRows = false;
            this.dataGridView3.AllowUserToDeleteRows = false;
            this.dataGridView3.AutoGenerateColumns = false;
            this.dataGridView3.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView3.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.addedProductId,
            this.quantity,
            this.date});
            this.dataGridView3.DataSource = this.addedstockBindingSource;
            this.dataGridView3.Location = new System.Drawing.Point(539, 12);
            this.dataGridView3.Name = "dataGridView3";
            this.dataGridView3.ReadOnly = true;
            this.dataGridView3.RowHeadersWidth = 62;
            this.dataGridView3.RowTemplate.Height = 28;
            this.dataGridView3.Size = new System.Drawing.Size(511, 303);
            this.dataGridView3.TabIndex = 2;
            // 
            // dataGridView4
            // 
            this.dataGridView4.AllowUserToAddRows = false;
            this.dataGridView4.AllowUserToDeleteRows = false;
            this.dataGridView4.AutoGenerateColumns = false;
            this.dataGridView4.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView4.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idDataGridViewTextBoxColumn,
            this.deliveryProductIdDataGridViewTextBoxColumn,
            this.quantityDataGridViewTextBoxColumn1,
            this.dateDataGridViewTextBoxColumn});
            this.dataGridView4.DataSource = this.newdeliveryBindingSource;
            this.dataGridView4.Location = new System.Drawing.Point(539, 345);
            this.dataGridView4.Name = "dataGridView4";
            this.dataGridView4.ReadOnly = true;
            this.dataGridView4.RowHeadersWidth = 62;
            this.dataGridView4.RowTemplate.Height = 28;
            this.dataGridView4.Size = new System.Drawing.Size(511, 287);
            this.dataGridView4.TabIndex = 3;
            // 
            // smsDataSet5
            // 
            this.smsDataSet5.DataSetName = "smsDataSet5";
            this.smsDataSet5.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // addedstockBindingSource
            // 
            this.addedstockBindingSource.DataMember = "addedstock";
            this.addedstockBindingSource.DataSource = this.smsDataSet5;
            // 
            // addedstockTableAdapter
            // 
            this.addedstockTableAdapter.ClearBeforeFill = true;
            // 
            // addedstockBindingSource1
            // 
            this.addedstockBindingSource1.DataMember = "addedstock";
            this.addedstockBindingSource1.DataSource = this.smsDataSet5;
            // 
            // smsDataSet5BindingSource
            // 
            this.smsDataSet5BindingSource.DataSource = this.smsDataSet5;
            this.smsDataSet5BindingSource.Position = 0;
            // 
            // newdeliveryBindingSource
            // 
            this.newdeliveryBindingSource.DataMember = "newdelivery";
            this.newdeliveryBindingSource.DataSource = this.smsDataSet5BindingSource;
            // 
            // newdeliveryTableAdapter
            // 
            this.newdeliveryTableAdapter.ClearBeforeFill = true;
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
            // deliveryProductIdDataGridViewTextBoxColumn
            // 
            this.deliveryProductIdDataGridViewTextBoxColumn.DataPropertyName = "deliveryProductId";
            this.deliveryProductIdDataGridViewTextBoxColumn.HeaderText = "deliveryProductId";
            this.deliveryProductIdDataGridViewTextBoxColumn.MinimumWidth = 8;
            this.deliveryProductIdDataGridViewTextBoxColumn.Name = "deliveryProductIdDataGridViewTextBoxColumn";
            this.deliveryProductIdDataGridViewTextBoxColumn.ReadOnly = true;
            this.deliveryProductIdDataGridViewTextBoxColumn.Width = 150;
            // 
            // quantityDataGridViewTextBoxColumn1
            // 
            this.quantityDataGridViewTextBoxColumn1.DataPropertyName = "quantity";
            this.quantityDataGridViewTextBoxColumn1.HeaderText = "quantity";
            this.quantityDataGridViewTextBoxColumn1.MinimumWidth = 8;
            this.quantityDataGridViewTextBoxColumn1.Name = "quantityDataGridViewTextBoxColumn1";
            this.quantityDataGridViewTextBoxColumn1.ReadOnly = true;
            this.quantityDataGridViewTextBoxColumn1.Width = 150;
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
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.DataPropertyName = "id";
            this.dataGridViewTextBoxColumn1.HeaderText = "id";
            this.dataGridViewTextBoxColumn1.MinimumWidth = 8;
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.ReadOnly = true;
            this.dataGridViewTextBoxColumn1.Width = 150;
            // 
            // addedProductId
            // 
            this.addedProductId.DataPropertyName = "addedProductId";
            this.addedProductId.HeaderText = "addedProductId";
            this.addedProductId.MinimumWidth = 8;
            this.addedProductId.Name = "addedProductId";
            this.addedProductId.ReadOnly = true;
            this.addedProductId.Width = 150;
            // 
            // quantity
            // 
            this.quantity.DataPropertyName = "quantity";
            this.quantity.HeaderText = "quantity";
            this.quantity.MinimumWidth = 8;
            this.quantity.Name = "quantity";
            this.quantity.ReadOnly = true;
            this.quantity.Width = 150;
            // 
            // date
            // 
            this.date.DataPropertyName = "date";
            this.date.HeaderText = "date";
            this.date.MinimumWidth = 8;
            this.date.Name = "date";
            this.date.ReadOnly = true;
            this.date.Width = 150;
            // 
            // MoreOfAdminView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(15F, 32F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(1078, 644);
            this.Controls.Add(this.dataGridView4);
            this.Controls.Add(this.dataGridView3);
            this.Controls.Add(this.dataGridView2);
            this.Controls.Add(this.dataGridView1);
            this.Font = new System.Drawing.Font("Palatino Linotype", 12F, System.Drawing.FontStyle.Bold);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.Name = "MoreOfAdminView";
            this.Text = "More of admin view";
            this.Load += new System.EventHandler(this.MoreOfAdminView_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.smsDataSet4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.removedstockBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.soldstockBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.smsDataSet5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.addedstockBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.addedstockBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.smsDataSet5BindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.newdeliveryBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private smsDataSet4 smsDataSet4;
        private System.Windows.Forms.BindingSource removedstockBindingSource;
        private smsDataSet4TableAdapters.removedstockTableAdapter removedstockTableAdapter;
        private System.Windows.Forms.DataGridView dataGridView2;
        private System.Windows.Forms.BindingSource soldstockBindingSource;
        private smsDataSet4TableAdapters.soldstockTableAdapter soldstockTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn idDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn soldProductIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn quantityDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn dateOfSaleDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn id;
        private System.Windows.Forms.DataGridViewTextBoxColumn removedProductID;
        private System.Windows.Forms.DataGridViewTextBoxColumn quantityOfProduct;
        private System.Windows.Forms.DataGridViewTextBoxColumn dateOfRemoval;
        private System.Windows.Forms.DataGridView dataGridView3;
        private System.Windows.Forms.DataGridView dataGridView4;
        private smsDataSet5 smsDataSet5;
        private System.Windows.Forms.BindingSource addedstockBindingSource;
        private smsDataSet5TableAdapters.addedstockTableAdapter addedstockTableAdapter;
        private System.Windows.Forms.BindingSource smsDataSet5BindingSource;
        private System.Windows.Forms.BindingSource addedstockBindingSource1;
        private System.Windows.Forms.BindingSource newdeliveryBindingSource;
        private smsDataSet5TableAdapters.newdeliveryTableAdapter newdeliveryTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn addedProductId;
        private System.Windows.Forms.DataGridViewTextBoxColumn quantity;
        private System.Windows.Forms.DataGridViewTextBoxColumn date;
        private System.Windows.Forms.DataGridViewTextBoxColumn idDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn deliveryProductIdDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn quantityDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dateDataGridViewTextBoxColumn;
    }
}