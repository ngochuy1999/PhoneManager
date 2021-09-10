
namespace PhoneManager
{
    partial class InventoryForm
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
            System.Windows.Forms.Label label6;
            System.Windows.Forms.Label label5;
            this.panel1 = new System.Windows.Forms.Panel();
            this.cbProvider = new System.Windows.Forms.CheckBox();
            this.cbCategory = new System.Windows.Forms.CheckBox();
            this.providerComboBox = new System.Windows.Forms.ComboBox();
            this.providerBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.phoneShopDataSet = new PhoneManager.PhoneShopDataSet();
            this.categoryComboBox = new System.Windows.Forms.ComboBox();
            this.categoryBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.btnExport = new System.Windows.Forms.Button();
            this.sP_InventoryProductBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.sP_InventoryProductTableAdapter = new PhoneManager.PhoneShopDataSetTableAdapters.SP_InventoryProductTableAdapter();
            this.tableAdapterManager = new PhoneManager.PhoneShopDataSetTableAdapters.TableAdapterManager();
            this.sP_InventoryProductGridControl = new DevExpress.XtraGrid.GridControl();
            this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colproductId = new DevExpress.XtraGrid.Columns.GridColumn();
            this.coltitle = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colquantity = new DevExpress.XtraGrid.Columns.GridColumn();
            this.providerTableAdapter = new PhoneManager.PhoneShopDataSetTableAdapters.ProviderTableAdapter();
            this.categoryTableAdapter = new PhoneManager.PhoneShopDataSetTableAdapters.CategoryTableAdapter();
            label6 = new System.Windows.Forms.Label();
            label5 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.providerBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.phoneShopDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.categoryBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.sP_InventoryProductBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.sP_InventoryProductGridControl)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new System.Drawing.Point(56, 33);
            label6.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            label6.Name = "label6";
            label6.Size = new System.Drawing.Size(52, 13);
            label6.TabIndex = 75;
            label6.Text = "Category";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new System.Drawing.Point(476, 33);
            label5.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            label5.Name = "label5";
            label5.Size = new System.Drawing.Size(47, 13);
            label5.TabIndex = 76;
            label5.Text = "Provider";
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.cbProvider);
            this.panel1.Controls.Add(this.cbCategory);
            this.panel1.Controls.Add(this.providerComboBox);
            this.panel1.Controls.Add(this.categoryComboBox);
            this.panel1.Controls.Add(this.btnExport);
            this.panel1.Controls.Add(label6);
            this.panel1.Controls.Add(label5);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Margin = new System.Windows.Forms.Padding(2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1096, 67);
            this.panel1.TabIndex = 6;
            // 
            // cbProvider
            // 
            this.cbProvider.AutoSize = true;
            this.cbProvider.Location = new System.Drawing.Point(458, 33);
            this.cbProvider.Margin = new System.Windows.Forms.Padding(2);
            this.cbProvider.Name = "cbProvider";
            this.cbProvider.Size = new System.Drawing.Size(15, 14);
            this.cbProvider.TabIndex = 83;
            this.cbProvider.UseVisualStyleBackColor = true;
            this.cbProvider.CheckedChanged += new System.EventHandler(this.cbProvider_CheckedChanged);
            // 
            // cbCategory
            // 
            this.cbCategory.AutoSize = true;
            this.cbCategory.Location = new System.Drawing.Point(38, 34);
            this.cbCategory.Margin = new System.Windows.Forms.Padding(2);
            this.cbCategory.Name = "cbCategory";
            this.cbCategory.Size = new System.Drawing.Size(15, 14);
            this.cbCategory.TabIndex = 82;
            this.cbCategory.UseVisualStyleBackColor = true;
            this.cbCategory.CheckedChanged += new System.EventHandler(this.cbCategory_CheckedChanged);
            // 
            // providerComboBox
            // 
            this.providerComboBox.DataSource = this.providerBindingSource;
            this.providerComboBox.DisplayMember = "branchName";
            this.providerComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.providerComboBox.Location = new System.Drawing.Point(542, 31);
            this.providerComboBox.Margin = new System.Windows.Forms.Padding(2);
            this.providerComboBox.Name = "providerComboBox";
            this.providerComboBox.Size = new System.Drawing.Size(226, 21);
            this.providerComboBox.TabIndex = 81;
            this.providerComboBox.ValueMember = "providerId";
            this.providerComboBox.SelectedIndexChanged += new System.EventHandler(this.cbProvider_CheckedChanged);
            // 
            // providerBindingSource
            // 
            this.providerBindingSource.DataMember = "Provider";
            this.providerBindingSource.DataSource = this.phoneShopDataSet;
            // 
            // phoneShopDataSet
            // 
            this.phoneShopDataSet.DataSetName = "PhoneShopDataSet";
            this.phoneShopDataSet.EnforceConstraints = false;
            this.phoneShopDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // categoryComboBox
            // 
            this.categoryComboBox.DataSource = this.categoryBindingSource;
            this.categoryComboBox.DisplayMember = "name";
            this.categoryComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.categoryComboBox.Location = new System.Drawing.Point(121, 33);
            this.categoryComboBox.Margin = new System.Windows.Forms.Padding(2);
            this.categoryComboBox.Name = "categoryComboBox";
            this.categoryComboBox.Size = new System.Drawing.Size(226, 21);
            this.categoryComboBox.TabIndex = 81;
            this.categoryComboBox.ValueMember = "categoryId";
            this.categoryComboBox.SelectedIndexChanged += new System.EventHandler(this.cbCategory_CheckedChanged);
            // 
            // categoryBindingSource
            // 
            this.categoryBindingSource.DataMember = "Category";
            this.categoryBindingSource.DataSource = this.phoneShopDataSet;
            // 
            // btnExport
            // 
            this.btnExport.BackColor = System.Drawing.Color.White;
            this.btnExport.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnExport.ForeColor = System.Drawing.Color.ForestGreen;
            this.btnExport.Location = new System.Drawing.Point(863, 19);
            this.btnExport.Margin = new System.Windows.Forms.Padding(2);
            this.btnExport.Name = "btnExport";
            this.btnExport.Size = new System.Drawing.Size(142, 42);
            this.btnExport.TabIndex = 81;
            this.btnExport.Text = "Export";
            this.btnExport.UseVisualStyleBackColor = false;
            this.btnExport.Click += new System.EventHandler(this.btnExport_Click);
            // 
            // sP_InventoryProductBindingSource
            // 
            this.sP_InventoryProductBindingSource.DataMember = "SP_InventoryProduct";
            this.sP_InventoryProductBindingSource.DataSource = this.phoneShopDataSet;
            // 
            // sP_InventoryProductTableAdapter
            // 
            this.sP_InventoryProductTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.AccountTableAdapter = null;
            this.tableAdapterManager.AddressTableAdapter = null;
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.CategoryTableAdapter = null;
            this.tableAdapterManager.Connection = null;
            this.tableAdapterManager.CustomerTableAdapter = null;
            this.tableAdapterManager.DescriptionTableAdapter = null;
            this.tableAdapterManager.DetailTableAdapter = null;
            this.tableAdapterManager.EmployeeTableAdapter = null;
            this.tableAdapterManager.FavoriteProductTableAdapter = null;
            this.tableAdapterManager.ImageProductTableAdapter = null;
            this.tableAdapterManager.ImportCouponDetailTableAdapter = null;
            this.tableAdapterManager.ImportCouponTableAdapter = null;
            this.tableAdapterManager.InvoiceItemTableAdapter = null;
            this.tableAdapterManager.InvoiceStatusTableAdapter = null;
            this.tableAdapterManager.InvoiceTableAdapter = null;
            this.tableAdapterManager.ProductTableAdapter = null;
            this.tableAdapterManager.ProviderTableAdapter = null;
            this.tableAdapterManager.RoleTableAdapter = null;
            this.tableAdapterManager.ShopInfoTableAdapter = null;
            this.tableAdapterManager.SlideTableAdapter = null;
            this.tableAdapterManager.UpdateOrder = PhoneManager.PhoneShopDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // sP_InventoryProductGridControl
            // 
            this.sP_InventoryProductGridControl.DataSource = this.sP_InventoryProductBindingSource;
            this.sP_InventoryProductGridControl.Location = new System.Drawing.Point(0, 72);
            this.sP_InventoryProductGridControl.MainView = this.gridView1;
            this.sP_InventoryProductGridControl.Name = "sP_InventoryProductGridControl";
            this.sP_InventoryProductGridControl.Size = new System.Drawing.Size(1096, 340);
            this.sP_InventoryProductGridControl.TabIndex = 8;
            this.sP_InventoryProductGridControl.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView1});
            // 
            // gridView1
            // 
            this.gridView1.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colproductId,
            this.coltitle,
            this.colquantity});
            this.gridView1.GridControl = this.sP_InventoryProductGridControl;
            this.gridView1.Name = "gridView1";
            this.gridView1.OptionsBehavior.Editable = false;
            this.gridView1.OptionsView.ShowViewCaption = true;
            this.gridView1.ViewCaption = "INVENTORY";
            // 
            // colproductId
            // 
            this.colproductId.FieldName = "productId";
            this.colproductId.Name = "colproductId";
            this.colproductId.Visible = true;
            this.colproductId.VisibleIndex = 0;
            // 
            // coltitle
            // 
            this.coltitle.FieldName = "title";
            this.coltitle.Name = "coltitle";
            this.coltitle.Visible = true;
            this.coltitle.VisibleIndex = 1;
            // 
            // colquantity
            // 
            this.colquantity.FieldName = "quantity";
            this.colquantity.Name = "colquantity";
            this.colquantity.Visible = true;
            this.colquantity.VisibleIndex = 2;
            // 
            // providerTableAdapter
            // 
            this.providerTableAdapter.ClearBeforeFill = true;
            // 
            // categoryTableAdapter
            // 
            this.categoryTableAdapter.ClearBeforeFill = true;
            // 
            // InventoryForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1096, 415);
            this.Controls.Add(this.sP_InventoryProductGridControl);
            this.Controls.Add(this.panel1);
            this.Name = "InventoryForm";
            this.Text = "InventoryForm";
            this.Load += new System.EventHandler(this.InventoryForm_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.providerBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.phoneShopDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.categoryBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.sP_InventoryProductBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.sP_InventoryProductGridControl)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.CheckBox cbProvider;
        private System.Windows.Forms.CheckBox cbCategory;
        private System.Windows.Forms.ComboBox providerComboBox;
        private System.Windows.Forms.ComboBox categoryComboBox;
        private System.Windows.Forms.Button btnExport;
        private PhoneShopDataSet phoneShopDataSet;
        private System.Windows.Forms.BindingSource sP_InventoryProductBindingSource;
        private PhoneShopDataSetTableAdapters.SP_InventoryProductTableAdapter sP_InventoryProductTableAdapter;
        private PhoneShopDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private DevExpress.XtraGrid.GridControl sP_InventoryProductGridControl;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
        private DevExpress.XtraGrid.Columns.GridColumn colproductId;
        private DevExpress.XtraGrid.Columns.GridColumn coltitle;
        private DevExpress.XtraGrid.Columns.GridColumn colquantity;
        private System.Windows.Forms.BindingSource providerBindingSource;
        private PhoneShopDataSetTableAdapters.ProviderTableAdapter providerTableAdapter;
        private System.Windows.Forms.BindingSource categoryBindingSource;
        private PhoneShopDataSetTableAdapters.CategoryTableAdapter categoryTableAdapter;
    }
}