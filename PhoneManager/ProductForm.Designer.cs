
namespace PhoneManager
{
    partial class ProductForm
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
            System.Windows.Forms.Label titleLabel;
            System.Windows.Forms.Label quantityLabel;
            System.Windows.Forms.Label colorLabel;
            System.Windows.Forms.Label priceLabel;
            System.Windows.Forms.Label categoryIdLabel;
            System.Windows.Forms.Label provideIdLabel;
            System.Windows.Forms.Label isNewLabel;
            System.Windows.Forms.Label addDateLabel;
            System.Windows.Forms.Label saleLabel;
            System.Windows.Forms.Label activeLabel;
            this.barManager1 = new DevExpress.XtraBars.BarManager(this.components);
            this.bar2 = new DevExpress.XtraBars.Bar();
            this.barButtonItem1 = new DevExpress.XtraBars.BarButtonItem();
            this.barButtonItem2 = new DevExpress.XtraBars.BarButtonItem();
            this.barButtonItem3 = new DevExpress.XtraBars.BarButtonItem();
            this.barButtonItem4 = new DevExpress.XtraBars.BarButtonItem();
            this.barDockControlTop = new DevExpress.XtraBars.BarDockControl();
            this.barDockControlBottom = new DevExpress.XtraBars.BarDockControl();
            this.barDockControlLeft = new DevExpress.XtraBars.BarDockControl();
            this.barDockControlRight = new DevExpress.XtraBars.BarDockControl();
            this.panel1 = new System.Windows.Forms.Panel();
            this.productGridControl = new DevExpress.XtraGrid.GridControl();
            this.productBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.phoneShopDataSet = new PhoneManager.PhoneShopDataSet();
            this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colproductId = new DevExpress.XtraGrid.Columns.GridColumn();
            this.coltitle = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colquantity = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colcolor = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colprice = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colisNew = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colsale = new DevExpress.XtraGrid.Columns.GridColumn();
            this.panel2 = new System.Windows.Forms.Panel();
            this.branchNameComboBox = new System.Windows.Forms.ComboBox();
            this.providerBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.nameComboBox = new System.Windows.Forms.ComboBox();
            this.categoryBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.provideIdTextEdit = new DevExpress.XtraEditors.TextEdit();
            this.categoryIdTextEdit = new DevExpress.XtraEditors.TextEdit();
            this.button2 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.btnImageList = new System.Windows.Forms.Button();
            this.btnCancelAddProvider = new System.Windows.Forms.Button();
            this.btnSaveAddProvider = new System.Windows.Forms.Button();
            this.activeSpinEdit = new DevExpress.XtraEditors.SpinEdit();
            this.saleSpinEdit = new DevExpress.XtraEditors.SpinEdit();
            this.addDateDateEdit = new DevExpress.XtraEditors.DateEdit();
            this.isNewSpinEdit = new DevExpress.XtraEditors.SpinEdit();
            this.priceSpinEdit = new DevExpress.XtraEditors.SpinEdit();
            this.colorTextEdit = new DevExpress.XtraEditors.TextEdit();
            this.quantitySpinEdit = new DevExpress.XtraEditors.SpinEdit();
            this.titleTextEdit = new DevExpress.XtraEditors.TextEdit();
            this.descriptionBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.productTableAdapter = new PhoneManager.PhoneShopDataSetTableAdapters.ProductTableAdapter();
            this.tableAdapterManager = new PhoneManager.PhoneShopDataSetTableAdapters.TableAdapterManager();
            this.descriptionTableAdapter = new PhoneManager.PhoneShopDataSetTableAdapters.DescriptionTableAdapter();
            this.categoryTableAdapter = new PhoneManager.PhoneShopDataSetTableAdapters.CategoryTableAdapter();
            this.providerTableAdapter = new PhoneManager.PhoneShopDataSetTableAdapters.ProviderTableAdapter();
            titleLabel = new System.Windows.Forms.Label();
            quantityLabel = new System.Windows.Forms.Label();
            colorLabel = new System.Windows.Forms.Label();
            priceLabel = new System.Windows.Forms.Label();
            categoryIdLabel = new System.Windows.Forms.Label();
            provideIdLabel = new System.Windows.Forms.Label();
            isNewLabel = new System.Windows.Forms.Label();
            addDateLabel = new System.Windows.Forms.Label();
            saleLabel = new System.Windows.Forms.Label();
            activeLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.barManager1)).BeginInit();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.productGridControl)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.productBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.phoneShopDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.providerBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.categoryBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.provideIdTextEdit.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.categoryIdTextEdit.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.activeSpinEdit.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.saleSpinEdit.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.addDateDateEdit.Properties.CalendarTimeProperties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.addDateDateEdit.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.isNewSpinEdit.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.priceSpinEdit.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.colorTextEdit.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.quantitySpinEdit.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.titleTextEdit.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.descriptionBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // titleLabel
            // 
            titleLabel.AutoSize = true;
            titleLabel.Location = new System.Drawing.Point(45, 39);
            titleLabel.Name = "titleLabel";
            titleLabel.Size = new System.Drawing.Size(29, 13);
            titleLabel.TabIndex = 0;
            titleLabel.Text = "title:";
            // 
            // quantityLabel
            // 
            quantityLabel.AutoSize = true;
            quantityLabel.Location = new System.Drawing.Point(23, 137);
            quantityLabel.Name = "quantityLabel";
            quantityLabel.Size = new System.Drawing.Size(51, 13);
            quantityLabel.TabIndex = 2;
            quantityLabel.Text = "quantity:";
            // 
            // colorLabel
            // 
            colorLabel.AutoSize = true;
            colorLabel.Location = new System.Drawing.Point(40, 181);
            colorLabel.Name = "colorLabel";
            colorLabel.Size = new System.Drawing.Size(34, 13);
            colorLabel.TabIndex = 4;
            colorLabel.Text = "color:";
            // 
            // priceLabel
            // 
            priceLabel.AutoSize = true;
            priceLabel.Location = new System.Drawing.Point(277, 141);
            priceLabel.Name = "priceLabel";
            priceLabel.Size = new System.Drawing.Size(34, 13);
            priceLabel.TabIndex = 6;
            priceLabel.Text = "price:";
            // 
            // categoryIdLabel
            // 
            categoryIdLabel.AutoSize = true;
            categoryIdLabel.Location = new System.Drawing.Point(7, 69);
            categoryIdLabel.Name = "categoryIdLabel";
            categoryIdLabel.Size = new System.Drawing.Size(67, 13);
            categoryIdLabel.TabIndex = 8;
            categoryIdLabel.Text = "category Id:";
            // 
            // provideIdLabel
            // 
            provideIdLabel.AutoSize = true;
            provideIdLabel.Location = new System.Drawing.Point(14, 103);
            provideIdLabel.Name = "provideIdLabel";
            provideIdLabel.Size = new System.Drawing.Size(60, 13);
            provideIdLabel.TabIndex = 10;
            provideIdLabel.Text = "provide Id:";
            // 
            // isNewLabel
            // 
            isNewLabel.AutoSize = true;
            isNewLabel.Location = new System.Drawing.Point(32, 218);
            isNewLabel.Name = "isNewLabel";
            isNewLabel.Size = new System.Drawing.Size(42, 13);
            isNewLabel.TabIndex = 12;
            isNewLabel.Text = "is New:";
            // 
            // addDateLabel
            // 
            addDateLabel.AutoSize = true;
            addDateLabel.Location = new System.Drawing.Point(256, 177);
            addDateLabel.Name = "addDateLabel";
            addDateLabel.Size = new System.Drawing.Size(55, 13);
            addDateLabel.TabIndex = 14;
            addDateLabel.Text = "add Date:";
            // 
            // saleLabel
            // 
            saleLabel.AutoSize = true;
            saleLabel.Location = new System.Drawing.Point(277, 222);
            saleLabel.Name = "saleLabel";
            saleLabel.Size = new System.Drawing.Size(30, 13);
            saleLabel.TabIndex = 16;
            saleLabel.Text = "sale:";
            // 
            // activeLabel
            // 
            activeLabel.AutoSize = true;
            activeLabel.Location = new System.Drawing.Point(34, 259);
            activeLabel.Name = "activeLabel";
            activeLabel.Size = new System.Drawing.Size(40, 13);
            activeLabel.TabIndex = 18;
            activeLabel.Text = "active:";
            // 
            // barManager1
            // 
            this.barManager1.Bars.AddRange(new DevExpress.XtraBars.Bar[] {
            this.bar2});
            this.barManager1.DockControls.Add(this.barDockControlTop);
            this.barManager1.DockControls.Add(this.barDockControlBottom);
            this.barManager1.DockControls.Add(this.barDockControlLeft);
            this.barManager1.DockControls.Add(this.barDockControlRight);
            this.barManager1.Form = this;
            this.barManager1.Items.AddRange(new DevExpress.XtraBars.BarItem[] {
            this.barButtonItem1,
            this.barButtonItem2,
            this.barButtonItem3,
            this.barButtonItem4});
            this.barManager1.MainMenu = this.bar2;
            this.barManager1.MaxItemId = 4;
            // 
            // bar2
            // 
            this.bar2.BarName = "Main menu";
            this.bar2.DockCol = 0;
            this.bar2.DockRow = 0;
            this.bar2.DockStyle = DevExpress.XtraBars.BarDockStyle.Top;
            this.bar2.LinksPersistInfo.AddRange(new DevExpress.XtraBars.LinkPersistInfo[] {
            new DevExpress.XtraBars.LinkPersistInfo(this.barButtonItem1),
            new DevExpress.XtraBars.LinkPersistInfo(this.barButtonItem2),
            new DevExpress.XtraBars.LinkPersistInfo(this.barButtonItem3),
            new DevExpress.XtraBars.LinkPersistInfo(this.barButtonItem4)});
            this.bar2.OptionsBar.MultiLine = true;
            this.bar2.OptionsBar.UseWholeRow = true;
            this.bar2.Text = "Main menu";
            // 
            // barButtonItem1
            // 
            this.barButtonItem1.Caption = "Add New";
            this.barButtonItem1.Id = 0;
            this.barButtonItem1.ImageOptions.Image = global::PhoneManager.Properties.Resources.add;
            this.barButtonItem1.Name = "barButtonItem1";
            this.barButtonItem1.PaintStyle = DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph;
            this.barButtonItem1.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnAddProvider_ItemClick);
            // 
            // barButtonItem2
            // 
            this.barButtonItem2.Caption = "Delete";
            this.barButtonItem2.Id = 1;
            this.barButtonItem2.ImageOptions.Image = global::PhoneManager.Properties.Resources.delete__1_;
            this.barButtonItem2.Name = "barButtonItem2";
            this.barButtonItem2.PaintStyle = DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph;
            this.barButtonItem2.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnDelProvider_ItemClick);
            // 
            // barButtonItem3
            // 
            this.barButtonItem3.Caption = "Reload";
            this.barButtonItem3.Id = 2;
            this.barButtonItem3.ImageOptions.Image = global::PhoneManager.Properties.Resources.exchange;
            this.barButtonItem3.Name = "barButtonItem3";
            this.barButtonItem3.PaintStyle = DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph;
            this.barButtonItem3.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnReloadProvider_ItemClick);
            // 
            // barButtonItem4
            // 
            this.barButtonItem4.Caption = "Close";
            this.barButtonItem4.Id = 3;
            this.barButtonItem4.ImageOptions.Image = global::PhoneManager.Properties.Resources.close;
            this.barButtonItem4.Name = "barButtonItem4";
            this.barButtonItem4.PaintStyle = DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph;
            this.barButtonItem4.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnCloseForm_ItemClick);
            // 
            // barDockControlTop
            // 
            this.barDockControlTop.CausesValidation = false;
            this.barDockControlTop.Dock = System.Windows.Forms.DockStyle.Top;
            this.barDockControlTop.Location = new System.Drawing.Point(0, 0);
            this.barDockControlTop.Manager = this.barManager1;
            this.barDockControlTop.Size = new System.Drawing.Size(1337, 27);
            // 
            // barDockControlBottom
            // 
            this.barDockControlBottom.CausesValidation = false;
            this.barDockControlBottom.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.barDockControlBottom.Location = new System.Drawing.Point(0, 412);
            this.barDockControlBottom.Manager = this.barManager1;
            this.barDockControlBottom.Size = new System.Drawing.Size(1337, 0);
            // 
            // barDockControlLeft
            // 
            this.barDockControlLeft.CausesValidation = false;
            this.barDockControlLeft.Dock = System.Windows.Forms.DockStyle.Left;
            this.barDockControlLeft.Location = new System.Drawing.Point(0, 27);
            this.barDockControlLeft.Manager = this.barManager1;
            this.barDockControlLeft.Size = new System.Drawing.Size(0, 385);
            // 
            // barDockControlRight
            // 
            this.barDockControlRight.CausesValidation = false;
            this.barDockControlRight.Dock = System.Windows.Forms.DockStyle.Right;
            this.barDockControlRight.Location = new System.Drawing.Point(1337, 27);
            this.barDockControlRight.Manager = this.barManager1;
            this.barDockControlRight.Size = new System.Drawing.Size(0, 385);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.productGridControl);
            this.panel1.Location = new System.Drawing.Point(0, 28);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(571, 370);
            this.panel1.TabIndex = 4;
            // 
            // productGridControl
            // 
            this.productGridControl.DataSource = this.productBindingSource;
            this.productGridControl.Location = new System.Drawing.Point(3, 3);
            this.productGridControl.MainView = this.gridView1;
            this.productGridControl.MenuManager = this.barManager1;
            this.productGridControl.Name = "productGridControl";
            this.productGridControl.Size = new System.Drawing.Size(565, 367);
            this.productGridControl.TabIndex = 0;
            this.productGridControl.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView1});
            // 
            // productBindingSource
            // 
            this.productBindingSource.DataMember = "Product";
            this.productBindingSource.DataSource = this.phoneShopDataSet;
            // 
            // phoneShopDataSet
            // 
            this.phoneShopDataSet.DataSetName = "PhoneShopDataSet";
            this.phoneShopDataSet.EnforceConstraints = false;
            this.phoneShopDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // gridView1
            // 
            this.gridView1.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colproductId,
            this.coltitle,
            this.colquantity,
            this.colcolor,
            this.colprice,
            this.colisNew,
            this.colsale});
            this.gridView1.GridControl = this.productGridControl;
            this.gridView1.Name = "gridView1";
            this.gridView1.OptionsBehavior.Editable = false;
            this.gridView1.OptionsView.ShowViewCaption = true;
            this.gridView1.ViewCaption = "PRODUCT";
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
            // colisNew
            // 
            this.colisNew.FieldName = "isNew";
            this.colisNew.Name = "colisNew";
            this.colisNew.Visible = true;
            this.colisNew.VisibleIndex = 5;
            // 
            // colsale
            // 
            this.colsale.FieldName = "sale";
            this.colsale.Name = "colsale";
            this.colsale.Visible = true;
            this.colsale.VisibleIndex = 6;
            // 
            // panel2
            // 
            this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel2.Controls.Add(this.branchNameComboBox);
            this.panel2.Controls.Add(this.nameComboBox);
            this.panel2.Controls.Add(this.provideIdTextEdit);
            this.panel2.Controls.Add(this.categoryIdTextEdit);
            this.panel2.Controls.Add(this.button2);
            this.panel2.Controls.Add(this.button1);
            this.panel2.Controls.Add(this.btnImageList);
            this.panel2.Controls.Add(this.btnCancelAddProvider);
            this.panel2.Controls.Add(this.btnSaveAddProvider);
            this.panel2.Controls.Add(activeLabel);
            this.panel2.Controls.Add(this.activeSpinEdit);
            this.panel2.Controls.Add(saleLabel);
            this.panel2.Controls.Add(this.saleSpinEdit);
            this.panel2.Controls.Add(addDateLabel);
            this.panel2.Controls.Add(this.addDateDateEdit);
            this.panel2.Controls.Add(isNewLabel);
            this.panel2.Controls.Add(this.isNewSpinEdit);
            this.panel2.Controls.Add(provideIdLabel);
            this.panel2.Controls.Add(categoryIdLabel);
            this.panel2.Controls.Add(priceLabel);
            this.panel2.Controls.Add(this.priceSpinEdit);
            this.panel2.Controls.Add(colorLabel);
            this.panel2.Controls.Add(this.colorTextEdit);
            this.panel2.Controls.Add(quantityLabel);
            this.panel2.Controls.Add(this.quantitySpinEdit);
            this.panel2.Controls.Add(titleLabel);
            this.panel2.Controls.Add(this.titleTextEdit);
            this.panel2.Location = new System.Drawing.Point(577, 28);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(760, 370);
            this.panel2.TabIndex = 5;
            // 
            // branchNameComboBox
            // 
            this.branchNameComboBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.providerBindingSource, "branchName", true));
            this.branchNameComboBox.DataSource = this.providerBindingSource;
            this.branchNameComboBox.DisplayMember = "branchName";
            this.branchNameComboBox.Location = new System.Drawing.Point(85, 99);
            this.branchNameComboBox.Name = "branchNameComboBox";
            this.branchNameComboBox.Size = new System.Drawing.Size(227, 21);
            this.branchNameComboBox.TabIndex = 73;
            this.branchNameComboBox.ValueMember = "providerId";
            this.branchNameComboBox.SelectionChangeCommitted += new System.EventHandler(this.branchNameComboBox_SelectionChangeCommitted);
            // 
            // providerBindingSource
            // 
            this.providerBindingSource.DataMember = "Provider";
            this.providerBindingSource.DataSource = this.phoneShopDataSet;
            // 
            // nameComboBox
            // 
            this.nameComboBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.categoryBindingSource, "name", true));
            this.nameComboBox.DataSource = this.categoryBindingSource;
            this.nameComboBox.DisplayMember = "name";
            this.nameComboBox.Location = new System.Drawing.Point(85, 66);
            this.nameComboBox.Name = "nameComboBox";
            this.nameComboBox.Size = new System.Drawing.Size(227, 21);
            this.nameComboBox.TabIndex = 72;
            this.nameComboBox.ValueMember = "categoryId";
            this.nameComboBox.SelectionChangeCommitted += new System.EventHandler(this.nameComboBox_SelectionChangeCommitted);
            // 
            // categoryBindingSource
            // 
            this.categoryBindingSource.DataMember = "Category";
            this.categoryBindingSource.DataSource = this.phoneShopDataSet;
            // 
            // provideIdTextEdit
            // 
            this.provideIdTextEdit.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.productBindingSource, "provideId", true));
            this.provideIdTextEdit.Enabled = false;
            this.provideIdTextEdit.Location = new System.Drawing.Point(397, 99);
            this.provideIdTextEdit.MenuManager = this.barManager1;
            this.provideIdTextEdit.Name = "provideIdTextEdit";
            this.provideIdTextEdit.Size = new System.Drawing.Size(25, 20);
            this.provideIdTextEdit.TabIndex = 71;
            this.provideIdTextEdit.EditValueChanged += new System.EventHandler(this.provideIdTextEdit_EditValueChanged);
            // 
            // categoryIdTextEdit
            // 
            this.categoryIdTextEdit.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.productBindingSource, "categoryId", true));
            this.categoryIdTextEdit.Enabled = false;
            this.categoryIdTextEdit.Location = new System.Drawing.Point(398, 66);
            this.categoryIdTextEdit.MenuManager = this.barManager1;
            this.categoryIdTextEdit.Name = "categoryIdTextEdit";
            this.categoryIdTextEdit.Size = new System.Drawing.Size(24, 20);
            this.categoryIdTextEdit.TabIndex = 70;
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.White;
            this.button2.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.ForeColor = System.Drawing.Color.DarkGreen;
            this.button2.ImageAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.button2.Location = new System.Drawing.Point(561, 44);
            this.button2.Margin = new System.Windows.Forms.Padding(2);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(128, 51);
            this.button2.TabIndex = 69;
            this.button2.Text = "Detail";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.White;
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.Color.DarkGreen;
            this.button1.ImageAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.button1.Location = new System.Drawing.Point(561, 118);
            this.button1.Margin = new System.Windows.Forms.Padding(2);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(128, 51);
            this.button1.TabIndex = 68;
            this.button1.Text = "Description";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // btnImageList
            // 
            this.btnImageList.BackColor = System.Drawing.Color.White;
            this.btnImageList.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnImageList.ForeColor = System.Drawing.Color.DarkGreen;
            this.btnImageList.ImageAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnImageList.Location = new System.Drawing.Point(561, 184);
            this.btnImageList.Margin = new System.Windows.Forms.Padding(2);
            this.btnImageList.Name = "btnImageList";
            this.btnImageList.Size = new System.Drawing.Size(128, 51);
            this.btnImageList.TabIndex = 67;
            this.btnImageList.Text = "Image list";
            this.btnImageList.UseVisualStyleBackColor = false;
            this.btnImageList.Click += new System.EventHandler(this.btnImageList_Click);
            // 
            // btnCancelAddProvider
            // 
            this.btnCancelAddProvider.BackColor = System.Drawing.Color.White;
            this.btnCancelAddProvider.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCancelAddProvider.ForeColor = System.Drawing.Color.Crimson;
            this.btnCancelAddProvider.Location = new System.Drawing.Point(293, 304);
            this.btnCancelAddProvider.Margin = new System.Windows.Forms.Padding(2);
            this.btnCancelAddProvider.Name = "btnCancelAddProvider";
            this.btnCancelAddProvider.Size = new System.Drawing.Size(92, 42);
            this.btnCancelAddProvider.TabIndex = 65;
            this.btnCancelAddProvider.Text = "Cancel";
            this.btnCancelAddProvider.UseVisualStyleBackColor = false;
            this.btnCancelAddProvider.Click += new System.EventHandler(this.btnCancelAddProvider_Click);
            // 
            // btnSaveAddProvider
            // 
            this.btnSaveAddProvider.BackColor = System.Drawing.Color.White;
            this.btnSaveAddProvider.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSaveAddProvider.ForeColor = System.Drawing.Color.ForestGreen;
            this.btnSaveAddProvider.Location = new System.Drawing.Point(129, 304);
            this.btnSaveAddProvider.Margin = new System.Windows.Forms.Padding(2);
            this.btnSaveAddProvider.Name = "btnSaveAddProvider";
            this.btnSaveAddProvider.Size = new System.Drawing.Size(92, 42);
            this.btnSaveAddProvider.TabIndex = 64;
            this.btnSaveAddProvider.Text = "Save";
            this.btnSaveAddProvider.UseVisualStyleBackColor = false;
            this.btnSaveAddProvider.Click += new System.EventHandler(this.btnSaveAddProvider_Click_1);
            // 
            // activeSpinEdit
            // 
            this.activeSpinEdit.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.productBindingSource, "active", true));
            this.activeSpinEdit.EditValue = new decimal(new int[] {
            0,
            0,
            0,
            0});
            this.activeSpinEdit.Location = new System.Drawing.Point(85, 256);
            this.activeSpinEdit.MenuManager = this.barManager1;
            this.activeSpinEdit.Name = "activeSpinEdit";
            this.activeSpinEdit.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.activeSpinEdit.Size = new System.Drawing.Size(100, 20);
            this.activeSpinEdit.TabIndex = 19;
            // 
            // saleSpinEdit
            // 
            this.saleSpinEdit.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.productBindingSource, "sale", true));
            this.saleSpinEdit.EditValue = new decimal(new int[] {
            0,
            0,
            0,
            0});
            this.saleSpinEdit.Location = new System.Drawing.Point(322, 219);
            this.saleSpinEdit.MenuManager = this.barManager1;
            this.saleSpinEdit.Name = "saleSpinEdit";
            this.saleSpinEdit.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.saleSpinEdit.Size = new System.Drawing.Size(100, 20);
            this.saleSpinEdit.TabIndex = 17;
            // 
            // addDateDateEdit
            // 
            this.addDateDateEdit.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.productBindingSource, "addDate", true));
            this.addDateDateEdit.EditValue = null;
            this.addDateDateEdit.Location = new System.Drawing.Point(322, 174);
            this.addDateDateEdit.MenuManager = this.barManager1;
            this.addDateDateEdit.Name = "addDateDateEdit";
            this.addDateDateEdit.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.addDateDateEdit.Properties.CalendarTimeProperties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.addDateDateEdit.Size = new System.Drawing.Size(100, 20);
            this.addDateDateEdit.TabIndex = 15;
            // 
            // isNewSpinEdit
            // 
            this.isNewSpinEdit.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.productBindingSource, "isNew", true));
            this.isNewSpinEdit.EditValue = new decimal(new int[] {
            0,
            0,
            0,
            0});
            this.isNewSpinEdit.Location = new System.Drawing.Point(85, 215);
            this.isNewSpinEdit.MenuManager = this.barManager1;
            this.isNewSpinEdit.Name = "isNewSpinEdit";
            this.isNewSpinEdit.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.isNewSpinEdit.Size = new System.Drawing.Size(100, 20);
            this.isNewSpinEdit.TabIndex = 13;
            // 
            // priceSpinEdit
            // 
            this.priceSpinEdit.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.productBindingSource, "price", true));
            this.priceSpinEdit.EditValue = new decimal(new int[] {
            0,
            0,
            0,
            0});
            this.priceSpinEdit.Location = new System.Drawing.Point(322, 134);
            this.priceSpinEdit.MenuManager = this.barManager1;
            this.priceSpinEdit.Name = "priceSpinEdit";
            this.priceSpinEdit.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.priceSpinEdit.Size = new System.Drawing.Size(100, 20);
            this.priceSpinEdit.TabIndex = 7;
            // 
            // colorTextEdit
            // 
            this.colorTextEdit.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.productBindingSource, "color", true));
            this.colorTextEdit.Location = new System.Drawing.Point(85, 174);
            this.colorTextEdit.MenuManager = this.barManager1;
            this.colorTextEdit.Name = "colorTextEdit";
            this.colorTextEdit.Size = new System.Drawing.Size(100, 20);
            this.colorTextEdit.TabIndex = 5;
            // 
            // quantitySpinEdit
            // 
            this.quantitySpinEdit.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.productBindingSource, "quantity", true));
            this.quantitySpinEdit.EditValue = new decimal(new int[] {
            0,
            0,
            0,
            0});
            this.quantitySpinEdit.Location = new System.Drawing.Point(85, 134);
            this.quantitySpinEdit.MenuManager = this.barManager1;
            this.quantitySpinEdit.Name = "quantitySpinEdit";
            this.quantitySpinEdit.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.quantitySpinEdit.Size = new System.Drawing.Size(103, 20);
            this.quantitySpinEdit.TabIndex = 3;
            // 
            // titleTextEdit
            // 
            this.titleTextEdit.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.productBindingSource, "title", true));
            this.titleTextEdit.Location = new System.Drawing.Point(85, 36);
            this.titleTextEdit.MenuManager = this.barManager1;
            this.titleTextEdit.Name = "titleTextEdit";
            this.titleTextEdit.Size = new System.Drawing.Size(339, 20);
            this.titleTextEdit.TabIndex = 1;
            // 
            // descriptionBindingSource
            // 
            this.descriptionBindingSource.DataMember = "FK_Description_Product";
            this.descriptionBindingSource.DataSource = this.productBindingSource;
            // 
            // productTableAdapter
            // 
            this.productTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.AccountTableAdapter = null;
            this.tableAdapterManager.AddressTableAdapter = null;
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.CategoryTableAdapter = null;
            this.tableAdapterManager.CustomerTableAdapter = null;
            this.tableAdapterManager.DescriptionTableAdapter = this.descriptionTableAdapter;
            this.tableAdapterManager.DetailTableAdapter = null;
            this.tableAdapterManager.EmployeeTableAdapter = null;
            this.tableAdapterManager.FavoriteProductTableAdapter = null;
            this.tableAdapterManager.ImageProductTableAdapter = null;
            this.tableAdapterManager.ImportCouponDetailTableAdapter = null;
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
            // descriptionTableAdapter
            // 
            this.descriptionTableAdapter.ClearBeforeFill = true;
            // 
            // categoryTableAdapter
            // 
            this.categoryTableAdapter.ClearBeforeFill = true;
            // 
            // providerTableAdapter
            // 
            this.providerTableAdapter.ClearBeforeFill = true;
            // 
            // ProductForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.ClientSize = new System.Drawing.Size(1337, 412);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.barDockControlLeft);
            this.Controls.Add(this.barDockControlRight);
            this.Controls.Add(this.barDockControlBottom);
            this.Controls.Add(this.barDockControlTop);
            this.Name = "ProductForm";
            this.Text = "ProductForm";
            this.Load += new System.EventHandler(this.ProductForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.barManager1)).EndInit();
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.productGridControl)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.productBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.phoneShopDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.providerBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.categoryBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.provideIdTextEdit.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.categoryIdTextEdit.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.activeSpinEdit.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.saleSpinEdit.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.addDateDateEdit.Properties.CalendarTimeProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.addDateDateEdit.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.isNewSpinEdit.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.priceSpinEdit.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.colorTextEdit.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.quantitySpinEdit.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.titleTextEdit.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.descriptionBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraBars.BarManager barManager1;
        private DevExpress.XtraBars.Bar bar2;
        private DevExpress.XtraBars.BarDockControl barDockControlTop;
        private DevExpress.XtraBars.BarDockControl barDockControlBottom;
        private DevExpress.XtraBars.BarDockControl barDockControlLeft;
        private DevExpress.XtraBars.BarDockControl barDockControlRight;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.BindingSource productBindingSource;
        private PhoneShopDataSet phoneShopDataSet;
        private PhoneShopDataSetTableAdapters.ProductTableAdapter productTableAdapter;
        private PhoneShopDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private DevExpress.XtraEditors.SpinEdit activeSpinEdit;
        private DevExpress.XtraEditors.SpinEdit saleSpinEdit;
        private DevExpress.XtraEditors.DateEdit addDateDateEdit;
        private DevExpress.XtraEditors.SpinEdit isNewSpinEdit;
        private DevExpress.XtraEditors.SpinEdit priceSpinEdit;
        private DevExpress.XtraEditors.TextEdit colorTextEdit;
        private DevExpress.XtraEditors.SpinEdit quantitySpinEdit;
        private DevExpress.XtraEditors.TextEdit titleTextEdit;
        private PhoneShopDataSetTableAdapters.DescriptionTableAdapter descriptionTableAdapter;
        private System.Windows.Forms.BindingSource descriptionBindingSource;
        private System.Windows.Forms.Button btnImageList;
        private System.Windows.Forms.Button btnCancelAddProvider;
        private System.Windows.Forms.Button btnSaveAddProvider;
        private System.Windows.Forms.BindingSource categoryBindingSource;
        private PhoneShopDataSetTableAdapters.CategoryTableAdapter categoryTableAdapter;
        private System.Windows.Forms.BindingSource providerBindingSource;
        private PhoneShopDataSetTableAdapters.ProviderTableAdapter providerTableAdapter;
        private DevExpress.XtraBars.BarButtonItem barButtonItem1;
        private DevExpress.XtraBars.BarButtonItem barButtonItem2;
        private DevExpress.XtraBars.BarButtonItem barButtonItem3;
        private DevExpress.XtraBars.BarButtonItem barButtonItem4;
        private DevExpress.XtraGrid.GridControl productGridControl;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
        private DevExpress.XtraGrid.Columns.GridColumn colproductId;
        private DevExpress.XtraGrid.Columns.GridColumn coltitle;
        private DevExpress.XtraGrid.Columns.GridColumn colquantity;
        private DevExpress.XtraGrid.Columns.GridColumn colcolor;
        private DevExpress.XtraGrid.Columns.GridColumn colprice;
        private DevExpress.XtraGrid.Columns.GridColumn colisNew;
        private DevExpress.XtraGrid.Columns.GridColumn colsale;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.ComboBox branchNameComboBox;
        private System.Windows.Forms.ComboBox nameComboBox;
        private DevExpress.XtraEditors.TextEdit provideIdTextEdit;
        private DevExpress.XtraEditors.TextEdit categoryIdTextEdit;
    }
}