
namespace PhoneManager
{
    partial class SubFormImportDetail
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
            System.Windows.Forms.Label couponIdLabel;
            System.Windows.Forms.Label productIdLabel;
            System.Windows.Forms.Label quantityLabel;
            System.Windows.Forms.Label priceLabel;
            this.phoneShopDataSet = new PhoneManager.PhoneShopDataSet();
            this.importCouponDetailBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.importCouponDetailTableAdapter = new PhoneManager.PhoneShopDataSetTableAdapters.ImportCouponDetailTableAdapter();
            this.tableAdapterManager = new PhoneManager.PhoneShopDataSetTableAdapters.TableAdapterManager();
            this.productTableAdapter = new PhoneManager.PhoneShopDataSetTableAdapters.ProductTableAdapter();
            this.couponIdSpinEdit = new DevExpress.XtraEditors.SpinEdit();
            this.productIdSpinEdit = new DevExpress.XtraEditors.SpinEdit();
            this.quantitySpinEdit = new DevExpress.XtraEditors.SpinEdit();
            this.priceSpinEdit = new DevExpress.XtraEditors.SpinEdit();
            this.productBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.productGridControl = new DevExpress.XtraGrid.GridControl();
            this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colproductId = new DevExpress.XtraGrid.Columns.GridColumn();
            this.coltitle = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colquantity = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colcolor = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colprice = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colcategoryId = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colprovideId = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colisNew = new DevExpress.XtraGrid.Columns.GridColumn();
            this.coladdDate = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colsale = new DevExpress.XtraGrid.Columns.GridColumn();
            this.button1 = new System.Windows.Forms.Button();
            couponIdLabel = new System.Windows.Forms.Label();
            productIdLabel = new System.Windows.Forms.Label();
            quantityLabel = new System.Windows.Forms.Label();
            priceLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.phoneShopDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.importCouponDetailBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.couponIdSpinEdit.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.productIdSpinEdit.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.quantitySpinEdit.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.priceSpinEdit.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.productBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.productGridControl)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // couponIdLabel
            // 
            couponIdLabel.AutoSize = true;
            couponIdLabel.Location = new System.Drawing.Point(57, 57);
            couponIdLabel.Name = "couponIdLabel";
            couponIdLabel.Size = new System.Drawing.Size(59, 13);
            couponIdLabel.TabIndex = 1;
            couponIdLabel.Text = "coupon Id:";
            // 
            // productIdLabel
            // 
            productIdLabel.AutoSize = true;
            productIdLabel.Location = new System.Drawing.Point(55, 97);
            productIdLabel.Name = "productIdLabel";
            productIdLabel.Size = new System.Drawing.Size(61, 13);
            productIdLabel.TabIndex = 2;
            productIdLabel.Text = "product Id:";
            // 
            // quantityLabel
            // 
            quantityLabel.AutoSize = true;
            quantityLabel.Location = new System.Drawing.Point(65, 134);
            quantityLabel.Name = "quantityLabel";
            quantityLabel.Size = new System.Drawing.Size(51, 13);
            quantityLabel.TabIndex = 4;
            quantityLabel.Text = "quantity:";
            // 
            // priceLabel
            // 
            priceLabel.AutoSize = true;
            priceLabel.Location = new System.Drawing.Point(82, 169);
            priceLabel.Name = "priceLabel";
            priceLabel.Size = new System.Drawing.Size(34, 13);
            priceLabel.TabIndex = 6;
            priceLabel.Text = "price:";
            // 
            // phoneShopDataSet
            // 
            this.phoneShopDataSet.DataSetName = "PhoneShopDataSet";
            this.phoneShopDataSet.EnforceConstraints = false;
            this.phoneShopDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // importCouponDetailBindingSource
            // 
            this.importCouponDetailBindingSource.DataMember = "ImportCouponDetail";
            this.importCouponDetailBindingSource.DataSource = this.phoneShopDataSet;
            // 
            // importCouponDetailTableAdapter
            // 
            this.importCouponDetailTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.AccountTableAdapter = null;
            this.tableAdapterManager.AddressTableAdapter = null;
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.CategoryTableAdapter = null;
            this.tableAdapterManager.CustomerTableAdapter = null;
            this.tableAdapterManager.DescriptionTableAdapter = null;
            this.tableAdapterManager.DetailTableAdapter = null;
            this.tableAdapterManager.EmployeeTableAdapter = null;
            this.tableAdapterManager.FavoriteProductTableAdapter = null;
            this.tableAdapterManager.ImageProductTableAdapter = null;
            this.tableAdapterManager.ImportCouponDetailTableAdapter = this.importCouponDetailTableAdapter;
            this.tableAdapterManager.ImportCouponTableAdapter = null;
            this.tableAdapterManager.InvoiceItemTableAdapter = null;
            this.tableAdapterManager.InvoiceStatusTableAdapter = null;
            this.tableAdapterManager.InvoiceTableAdapter = null;
            this.tableAdapterManager.ProductTableAdapter = this.productTableAdapter;
            this.tableAdapterManager.ProviderTableAdapter = null;
            this.tableAdapterManager.RoleTableAdapter = null;
            this.tableAdapterManager.ShopInfoTableAdapter = null;
            this.tableAdapterManager.SlideTableAdapter = null;
            this.tableAdapterManager.UpdateOrder = PhoneManager.PhoneShopDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // productTableAdapter
            // 
            this.productTableAdapter.ClearBeforeFill = true;
            // 
            // couponIdSpinEdit
            // 
            this.couponIdSpinEdit.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.importCouponDetailBindingSource, "couponId", true));
            this.couponIdSpinEdit.EditValue = new decimal(new int[] {
            0,
            0,
            0,
            0});
            this.couponIdSpinEdit.Location = new System.Drawing.Point(122, 54);
            this.couponIdSpinEdit.Name = "couponIdSpinEdit";
            this.couponIdSpinEdit.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.couponIdSpinEdit.Size = new System.Drawing.Size(114, 20);
            this.couponIdSpinEdit.TabIndex = 2;
            // 
            // productIdSpinEdit
            // 
            this.productIdSpinEdit.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.importCouponDetailBindingSource, "productId", true));
            this.productIdSpinEdit.EditValue = new decimal(new int[] {
            0,
            0,
            0,
            0});
            this.productIdSpinEdit.Location = new System.Drawing.Point(122, 94);
            this.productIdSpinEdit.Name = "productIdSpinEdit";
            this.productIdSpinEdit.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.productIdSpinEdit.Size = new System.Drawing.Size(114, 20);
            this.productIdSpinEdit.TabIndex = 3;
            // 
            // quantitySpinEdit
            // 
            this.quantitySpinEdit.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.importCouponDetailBindingSource, "quantity", true));
            this.quantitySpinEdit.EditValue = new decimal(new int[] {
            0,
            0,
            0,
            0});
            this.quantitySpinEdit.Location = new System.Drawing.Point(122, 131);
            this.quantitySpinEdit.Name = "quantitySpinEdit";
            this.quantitySpinEdit.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.quantitySpinEdit.Size = new System.Drawing.Size(114, 20);
            this.quantitySpinEdit.TabIndex = 5;
            // 
            // priceSpinEdit
            // 
            this.priceSpinEdit.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.importCouponDetailBindingSource, "price", true));
            this.priceSpinEdit.EditValue = new decimal(new int[] {
            0,
            0,
            0,
            0});
            this.priceSpinEdit.Location = new System.Drawing.Point(122, 166);
            this.priceSpinEdit.Name = "priceSpinEdit";
            this.priceSpinEdit.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.priceSpinEdit.Size = new System.Drawing.Size(114, 20);
            this.priceSpinEdit.TabIndex = 7;
            // 
            // productBindingSource
            // 
            this.productBindingSource.DataMember = "Product";
            this.productBindingSource.DataSource = this.phoneShopDataSet;
            // 
            // productGridControl
            // 
            this.productGridControl.DataSource = this.productBindingSource;
            this.productGridControl.Location = new System.Drawing.Point(302, 12);
            this.productGridControl.MainView = this.gridView1;
            this.productGridControl.Name = "productGridControl";
            this.productGridControl.Size = new System.Drawing.Size(606, 308);
            this.productGridControl.TabIndex = 8;
            this.productGridControl.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView1});
            // 
            // gridView1
            // 
            this.gridView1.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colproductId,
            this.coltitle,
            this.colquantity,
            this.colcolor,
            this.colprice,
            this.colcategoryId,
            this.colprovideId,
            this.colisNew,
            this.coladdDate,
            this.colsale});
            this.gridView1.GridControl = this.productGridControl;
            this.gridView1.Name = "gridView1";
            this.gridView1.OptionsBehavior.Editable = false;
            this.gridView1.OptionsView.ShowViewCaption = true;
            this.gridView1.ViewCaption = "PRODUCT";
            this.gridView1.RowClick += new DevExpress.XtraGrid.Views.Grid.RowClickEventHandler(this.gridViewVatTu_RowClick);
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
            // colcolor
            // 
            this.colcolor.FieldName = "color";
            this.colcolor.Name = "colcolor";
            this.colcolor.Visible = true;
            this.colcolor.VisibleIndex = 3;
            // 
            // colprice
            // 
            this.colprice.FieldName = "price";
            this.colprice.Name = "colprice";
            this.colprice.Visible = true;
            this.colprice.VisibleIndex = 4;
            // 
            // colcategoryId
            // 
            this.colcategoryId.FieldName = "categoryId";
            this.colcategoryId.Name = "colcategoryId";
            this.colcategoryId.Visible = true;
            this.colcategoryId.VisibleIndex = 5;
            // 
            // colprovideId
            // 
            this.colprovideId.FieldName = "provideId";
            this.colprovideId.Name = "colprovideId";
            this.colprovideId.Visible = true;
            this.colprovideId.VisibleIndex = 6;
            // 
            // colisNew
            // 
            this.colisNew.FieldName = "isNew";
            this.colisNew.Name = "colisNew";
            this.colisNew.Visible = true;
            this.colisNew.VisibleIndex = 7;
            // 
            // coladdDate
            // 
            this.coladdDate.FieldName = "addDate";
            this.coladdDate.Name = "coladdDate";
            this.coladdDate.Visible = true;
            this.coladdDate.VisibleIndex = 8;
            // 
            // colsale
            // 
            this.colsale.FieldName = "sale";
            this.colsale.Name = "colsale";
            this.colsale.Visible = true;
            this.colsale.VisibleIndex = 9;
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.Turquoise;
            this.button1.Location = new System.Drawing.Point(122, 254);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 12;
            this.button1.Text = "OK";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.buttonOK_Click);
            // 
            // SubFormImportDetail
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(937, 365);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.productGridControl);
            this.Controls.Add(priceLabel);
            this.Controls.Add(this.priceSpinEdit);
            this.Controls.Add(quantityLabel);
            this.Controls.Add(this.quantitySpinEdit);
            this.Controls.Add(productIdLabel);
            this.Controls.Add(this.productIdSpinEdit);
            this.Controls.Add(couponIdLabel);
            this.Controls.Add(this.couponIdSpinEdit);
            this.Name = "SubFormImportDetail";
            this.Text = "SubFormImportDetail";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.SubFormPhieuNhap_FormClosing);
            this.Load += new System.EventHandler(this.SubFormImportDetail_Load);
            this.Shown += new System.EventHandler(this.SubFormCTPS_Shown);
            ((System.ComponentModel.ISupportInitialize)(this.phoneShopDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.importCouponDetailBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.couponIdSpinEdit.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.productIdSpinEdit.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.quantitySpinEdit.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.priceSpinEdit.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.productBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.productGridControl)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private PhoneShopDataSet phoneShopDataSet;
        private System.Windows.Forms.BindingSource importCouponDetailBindingSource;
        private PhoneShopDataSetTableAdapters.ImportCouponDetailTableAdapter importCouponDetailTableAdapter;
        private PhoneShopDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private DevExpress.XtraEditors.SpinEdit couponIdSpinEdit;
        private PhoneShopDataSetTableAdapters.ProductTableAdapter productTableAdapter;
        private DevExpress.XtraEditors.SpinEdit productIdSpinEdit;
        private DevExpress.XtraEditors.SpinEdit quantitySpinEdit;
        private DevExpress.XtraEditors.SpinEdit priceSpinEdit;
        private System.Windows.Forms.BindingSource productBindingSource;
        private DevExpress.XtraGrid.GridControl productGridControl;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
        private DevExpress.XtraGrid.Columns.GridColumn colproductId;
        private DevExpress.XtraGrid.Columns.GridColumn coltitle;
        private DevExpress.XtraGrid.Columns.GridColumn colquantity;
        private DevExpress.XtraGrid.Columns.GridColumn colcolor;
        private DevExpress.XtraGrid.Columns.GridColumn colprice;
        private DevExpress.XtraGrid.Columns.GridColumn colcategoryId;
        private DevExpress.XtraGrid.Columns.GridColumn colprovideId;
        private DevExpress.XtraGrid.Columns.GridColumn colisNew;
        private DevExpress.XtraGrid.Columns.GridColumn coladdDate;
        private DevExpress.XtraGrid.Columns.GridColumn colsale;
        private System.Windows.Forms.Button button1;
    }
}