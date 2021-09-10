
namespace PhoneManager
{
    partial class ImportCuponForm
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
            System.Windows.Forms.Label dateAddLabel;
            System.Windows.Forms.Label employeeIdLabel;
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
            this.employeeBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.phoneShopDataSet = new PhoneManager.PhoneShopDataSet();
            this.panel2 = new System.Windows.Forms.Panel();
            this.importCouponDetailGridControl = new DevExpress.XtraGrid.GridControl();
            this.importCouponDetailBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.importCouponBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.gridView2 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colcouponId = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colproductId = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colquantity = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colprice = new DevExpress.XtraGrid.Columns.GridColumn();
            this.importCouponGridControl = new DevExpress.XtraGrid.GridControl();
            this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colcouponId1 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.coldateAdd = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colemployeeId = new DevExpress.XtraGrid.Columns.GridColumn();
            this.panel3 = new System.Windows.Forms.Panel();
            this.panel4 = new System.Windows.Forms.Panel();
            this.btnCancelImport = new System.Windows.Forms.Button();
            this.btnSaveIport = new System.Windows.Forms.Button();
            this.employeeIdSpinEdit = new DevExpress.XtraEditors.SpinEdit();
            this.dateAddDateEdit = new DevExpress.XtraEditors.DateEdit();
            this.employeeTableAdapter = new PhoneManager.PhoneShopDataSetTableAdapters.EmployeeTableAdapter();
            this.tableAdapterManager = new PhoneManager.PhoneShopDataSetTableAdapters.TableAdapterManager();
            this.importCouponTableAdapter = new PhoneManager.PhoneShopDataSetTableAdapters.ImportCouponTableAdapter();
            this.importCouponDetailTableAdapter = new PhoneManager.PhoneShopDataSetTableAdapters.ImportCouponDetailTableAdapter();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.addImportCouponItemToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.contextMenuStrip2 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.addImportCuponItemToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.deleteItemToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            dateAddLabel = new System.Windows.Forms.Label();
            employeeIdLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.barManager1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.employeeBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.phoneShopDataSet)).BeginInit();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.importCouponDetailGridControl)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.importCouponDetailBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.importCouponBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.importCouponGridControl)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
            this.panel3.SuspendLayout();
            this.panel4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.employeeIdSpinEdit.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dateAddDateEdit.Properties.CalendarTimeProperties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dateAddDateEdit.Properties)).BeginInit();
            this.contextMenuStrip1.SuspendLayout();
            this.contextMenuStrip2.SuspendLayout();
            this.SuspendLayout();
            // 
            // dateAddLabel
            // 
            dateAddLabel.AutoSize = true;
            dateAddLabel.Location = new System.Drawing.Point(708, 59);
            dateAddLabel.Name = "dateAddLabel";
            dateAddLabel.Size = new System.Drawing.Size(52, 13);
            dateAddLabel.TabIndex = 2;
            dateAddLabel.Text = "Date Add";
            // 
            // employeeIdLabel
            // 
            employeeIdLabel.AutoSize = true;
            employeeIdLabel.Location = new System.Drawing.Point(418, 59);
            employeeIdLabel.Name = "employeeIdLabel";
            employeeIdLabel.Size = new System.Drawing.Size(66, 13);
            employeeIdLabel.TabIndex = 4;
            employeeIdLabel.Text = "Employee Id";
            employeeIdLabel.Click += new System.EventHandler(this.employeeIdLabel_Click);
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
            this.barDockControlTop.Size = new System.Drawing.Size(1331, 27);
            // 
            // barDockControlBottom
            // 
            this.barDockControlBottom.CausesValidation = false;
            this.barDockControlBottom.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.barDockControlBottom.Location = new System.Drawing.Point(0, 537);
            this.barDockControlBottom.Manager = this.barManager1;
            this.barDockControlBottom.Size = new System.Drawing.Size(1331, 0);
            // 
            // barDockControlLeft
            // 
            this.barDockControlLeft.CausesValidation = false;
            this.barDockControlLeft.Dock = System.Windows.Forms.DockStyle.Left;
            this.barDockControlLeft.Location = new System.Drawing.Point(0, 27);
            this.barDockControlLeft.Manager = this.barManager1;
            this.barDockControlLeft.Size = new System.Drawing.Size(0, 510);
            // 
            // barDockControlRight
            // 
            this.barDockControlRight.CausesValidation = false;
            this.barDockControlRight.Dock = System.Windows.Forms.DockStyle.Right;
            this.barDockControlRight.Location = new System.Drawing.Point(1331, 27);
            this.barDockControlRight.Manager = this.barManager1;
            this.barDockControlRight.Size = new System.Drawing.Size(0, 510);
            // 
            // employeeBindingSource
            // 
            this.employeeBindingSource.DataMember = "Employee";
            this.employeeBindingSource.DataSource = this.phoneShopDataSet;
            // 
            // phoneShopDataSet
            // 
            this.phoneShopDataSet.DataSetName = "PhoneShopDataSet";
            this.phoneShopDataSet.EnforceConstraints = false;
            this.phoneShopDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.importCouponDetailGridControl);
            this.panel2.Controls.Add(this.importCouponGridControl);
            this.panel2.Location = new System.Drawing.Point(0, 33);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1319, 324);
            this.panel2.TabIndex = 5;
            // 
            // importCouponDetailGridControl
            // 
            this.importCouponDetailGridControl.DataSource = this.importCouponDetailBindingSource;
            this.importCouponDetailGridControl.Location = new System.Drawing.Point(785, 6);
            this.importCouponDetailGridControl.MainView = this.gridView2;
            this.importCouponDetailGridControl.MenuManager = this.barManager1;
            this.importCouponDetailGridControl.Name = "importCouponDetailGridControl";
            this.importCouponDetailGridControl.Size = new System.Drawing.Size(531, 264);
            this.importCouponDetailGridControl.TabIndex = 1;
            this.importCouponDetailGridControl.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView2});
            this.importCouponDetailGridControl.MouseHover += new System.EventHandler(this.gcCTPN_MouseHover);
            // 
            // importCouponDetailBindingSource
            // 
            this.importCouponDetailBindingSource.DataMember = "FK_ImportCouponDetail_ImportCoupon";
            this.importCouponDetailBindingSource.DataSource = this.importCouponBindingSource;
            // 
            // importCouponBindingSource
            // 
            this.importCouponBindingSource.DataMember = "FK_ImportCoupon_Employee";
            this.importCouponBindingSource.DataSource = this.employeeBindingSource;
            // 
            // gridView2
            // 
            this.gridView2.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colcouponId,
            this.colproductId,
            this.colquantity,
            this.colprice});
            this.gridView2.GridControl = this.importCouponDetailGridControl;
            this.gridView2.Name = "gridView2";
            this.gridView2.OptionsBehavior.Editable = false;
            this.gridView2.OptionsView.ShowViewCaption = true;
            this.gridView2.ViewCaption = "IMPORT COUPON ITEM";
            // 
            // colcouponId
            // 
            this.colcouponId.FieldName = "couponId";
            this.colcouponId.Name = "colcouponId";
            this.colcouponId.Visible = true;
            this.colcouponId.VisibleIndex = 0;
            // 
            // colproductId
            // 
            this.colproductId.FieldName = "productId";
            this.colproductId.Name = "colproductId";
            this.colproductId.Visible = true;
            this.colproductId.VisibleIndex = 1;
            // 
            // colquantity
            // 
            this.colquantity.FieldName = "quantity";
            this.colquantity.Name = "colquantity";
            this.colquantity.Visible = true;
            this.colquantity.VisibleIndex = 2;
            // 
            // colprice
            // 
            this.colprice.FieldName = "price";
            this.colprice.Name = "colprice";
            this.colprice.Visible = true;
            this.colprice.VisibleIndex = 3;
            // 
            // importCouponGridControl
            // 
            this.importCouponGridControl.DataSource = this.importCouponBindingSource;
            this.importCouponGridControl.Location = new System.Drawing.Point(0, 6);
            this.importCouponGridControl.MainView = this.gridView1;
            this.importCouponGridControl.MenuManager = this.barManager1;
            this.importCouponGridControl.Name = "importCouponGridControl";
            this.importCouponGridControl.Size = new System.Drawing.Size(779, 264);
            this.importCouponGridControl.TabIndex = 0;
            this.importCouponGridControl.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView1});
            this.importCouponGridControl.MouseHover += new System.EventHandler(this.gcPhieuNhap_MouseHover);
            // 
            // gridView1
            // 
            this.gridView1.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colcouponId1,
            this.coldateAdd,
            this.colemployeeId});
            this.gridView1.GridControl = this.importCouponGridControl;
            this.gridView1.Name = "gridView1";
            this.gridView1.OptionsBehavior.Editable = false;
            this.gridView1.OptionsView.ShowViewCaption = true;
            this.gridView1.ViewCaption = "IMPORT COUPON";
            // 
            // colcouponId1
            // 
            this.colcouponId1.FieldName = "couponId";
            this.colcouponId1.Name = "colcouponId1";
            this.colcouponId1.Visible = true;
            this.colcouponId1.VisibleIndex = 0;
            // 
            // coldateAdd
            // 
            this.coldateAdd.FieldName = "dateAdd";
            this.coldateAdd.Name = "coldateAdd";
            this.coldateAdd.Visible = true;
            this.coldateAdd.VisibleIndex = 1;
            // 
            // colemployeeId
            // 
            this.colemployeeId.FieldName = "employeeId";
            this.colemployeeId.Name = "colemployeeId";
            this.colemployeeId.Visible = true;
            this.colemployeeId.VisibleIndex = 2;
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.panel4);
            this.panel3.Location = new System.Drawing.Point(0, 315);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(1329, 216);
            this.panel3.TabIndex = 0;
            // 
            // panel4
            // 
            this.panel4.AutoScroll = true;
            this.panel4.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel4.Controls.Add(this.btnCancelImport);
            this.panel4.Controls.Add(this.btnSaveIport);
            this.panel4.Controls.Add(employeeIdLabel);
            this.panel4.Controls.Add(this.employeeIdSpinEdit);
            this.panel4.Controls.Add(dateAddLabel);
            this.panel4.Controls.Add(this.dateAddDateEdit);
            this.panel4.Location = new System.Drawing.Point(0, 0);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(1326, 210);
            this.panel4.TabIndex = 0;
            // 
            // btnCancelImport
            // 
            this.btnCancelImport.BackColor = System.Drawing.Color.White;
            this.btnCancelImport.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCancelImport.ForeColor = System.Drawing.Color.Crimson;
            this.btnCancelImport.Location = new System.Drawing.Point(692, 127);
            this.btnCancelImport.Margin = new System.Windows.Forms.Padding(2);
            this.btnCancelImport.Name = "btnCancelImport";
            this.btnCancelImport.Size = new System.Drawing.Size(92, 42);
            this.btnCancelImport.TabIndex = 60;
            this.btnCancelImport.Text = "Cancel";
            this.btnCancelImport.UseVisualStyleBackColor = false;
            this.btnCancelImport.Click += new System.EventHandler(this.btnCancelAddProvider_Click_1);
            // 
            // btnSaveIport
            // 
            this.btnSaveIport.BackColor = System.Drawing.Color.White;
            this.btnSaveIport.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSaveIport.ForeColor = System.Drawing.Color.ForestGreen;
            this.btnSaveIport.Location = new System.Drawing.Point(537, 127);
            this.btnSaveIport.Margin = new System.Windows.Forms.Padding(2);
            this.btnSaveIport.Name = "btnSaveIport";
            this.btnSaveIport.Size = new System.Drawing.Size(92, 42);
            this.btnSaveIport.TabIndex = 59;
            this.btnSaveIport.Text = "Save";
            this.btnSaveIport.UseVisualStyleBackColor = false;
            this.btnSaveIport.Click += new System.EventHandler(this.btnSaveIport_Click);
            // 
            // employeeIdSpinEdit
            // 
            this.employeeIdSpinEdit.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.importCouponBindingSource, "employeeId", true));
            this.employeeIdSpinEdit.EditValue = new decimal(new int[] {
            0,
            0,
            0,
            0});
            this.employeeIdSpinEdit.Enabled = false;
            this.employeeIdSpinEdit.Location = new System.Drawing.Point(494, 55);
            this.employeeIdSpinEdit.MenuManager = this.barManager1;
            this.employeeIdSpinEdit.Name = "employeeIdSpinEdit";
            this.employeeIdSpinEdit.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.employeeIdSpinEdit.Size = new System.Drawing.Size(100, 20);
            this.employeeIdSpinEdit.TabIndex = 5;
            // 
            // dateAddDateEdit
            // 
            this.dateAddDateEdit.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.importCouponBindingSource, "dateAdd", true));
            this.dateAddDateEdit.EditValue = null;
            this.dateAddDateEdit.Location = new System.Drawing.Point(769, 55);
            this.dateAddDateEdit.MenuManager = this.barManager1;
            this.dateAddDateEdit.Name = "dateAddDateEdit";
            this.dateAddDateEdit.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.dateAddDateEdit.Properties.CalendarTimeProperties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.dateAddDateEdit.Size = new System.Drawing.Size(100, 20);
            this.dateAddDateEdit.TabIndex = 3;
            // 
            // employeeTableAdapter
            // 
            this.employeeTableAdapter.ClearBeforeFill = true;
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
            this.tableAdapterManager.EmployeeTableAdapter = this.employeeTableAdapter;
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
            // importCouponTableAdapter
            // 
            this.importCouponTableAdapter.ClearBeforeFill = true;
            // 
            // importCouponDetailTableAdapter
            // 
            this.importCouponDetailTableAdapter.ClearBeforeFill = true;
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.addImportCouponItemToolStripMenuItem});
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(209, 26);
            // 
            // addImportCouponItemToolStripMenuItem
            // 
            this.addImportCouponItemToolStripMenuItem.Image = global::PhoneManager.Properties.Resources.add;
            this.addImportCouponItemToolStripMenuItem.Name = "addImportCouponItemToolStripMenuItem";
            this.addImportCouponItemToolStripMenuItem.Size = new System.Drawing.Size(208, 22);
            this.addImportCouponItemToolStripMenuItem.Text = "Add Import Coupon Item";
            this.addImportCouponItemToolStripMenuItem.Click += new System.EventHandler(this.smiAddCTPN_Click);
            // 
            // contextMenuStrip2
            // 
            this.contextMenuStrip2.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.addImportCuponItemToolStripMenuItem,
            this.deleteItemToolStripMenuItem});
            this.contextMenuStrip2.Name = "contextMenuStrip2";
            this.contextMenuStrip2.Size = new System.Drawing.Size(202, 70);
            // 
            // addImportCuponItemToolStripMenuItem
            // 
            this.addImportCuponItemToolStripMenuItem.Image = global::PhoneManager.Properties.Resources.add;
            this.addImportCuponItemToolStripMenuItem.Name = "addImportCuponItemToolStripMenuItem";
            this.addImportCuponItemToolStripMenuItem.Size = new System.Drawing.Size(201, 22);
            this.addImportCuponItemToolStripMenuItem.Text = "Add Import Cupon Item";
            this.addImportCuponItemToolStripMenuItem.Click += new System.EventHandler(this.smiAddCTPN_Click);
            // 
            // deleteItemToolStripMenuItem
            // 
            this.deleteItemToolStripMenuItem.Image = global::PhoneManager.Properties.Resources.delete__1_;
            this.deleteItemToolStripMenuItem.Name = "deleteItemToolStripMenuItem";
            this.deleteItemToolStripMenuItem.Size = new System.Drawing.Size(201, 22);
            this.deleteItemToolStripMenuItem.Text = "Delete Item";
            this.deleteItemToolStripMenuItem.Click += new System.EventHandler(this.menuDeleteCTPN_Click);
            // 
            // ImportCuponForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.ClientSize = new System.Drawing.Size(1331, 537);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.barDockControlLeft);
            this.Controls.Add(this.barDockControlRight);
            this.Controls.Add(this.barDockControlBottom);
            this.Controls.Add(this.barDockControlTop);
            this.Name = "ImportCuponForm";
            this.Text = "ImportCouponForm";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.ImportCouponForm_Load);
            this.Shown += new System.EventHandler(this.ImportCuponForm_Shown);
            ((System.ComponentModel.ISupportInitialize)(this.barManager1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.employeeBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.phoneShopDataSet)).EndInit();
            this.panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.importCouponDetailGridControl)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.importCouponDetailBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.importCouponBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.importCouponGridControl)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            this.panel3.ResumeLayout(false);
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.employeeIdSpinEdit.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dateAddDateEdit.Properties.CalendarTimeProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dateAddDateEdit.Properties)).EndInit();
            this.contextMenuStrip1.ResumeLayout(false);
            this.contextMenuStrip2.ResumeLayout(false);
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
        private System.Windows.Forms.BindingSource employeeBindingSource;
        private PhoneShopDataSet phoneShopDataSet;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Panel panel2;
        private PhoneShopDataSetTableAdapters.EmployeeTableAdapter employeeTableAdapter;
        private PhoneShopDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.BindingSource importCouponBindingSource;
        private PhoneShopDataSetTableAdapters.ImportCouponTableAdapter importCouponTableAdapter;
        private DevExpress.XtraGrid.GridControl importCouponGridControl;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
        private System.Windows.Forms.BindingSource importCouponDetailBindingSource;
        private PhoneShopDataSetTableAdapters.ImportCouponDetailTableAdapter importCouponDetailTableAdapter;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Button btnCancelImport;
        private System.Windows.Forms.Button btnSaveIport;
        private DevExpress.XtraEditors.SpinEdit employeeIdSpinEdit;
        private DevExpress.XtraEditors.DateEdit dateAddDateEdit;
        private DevExpress.XtraGrid.Columns.GridColumn colcouponId1;
        private DevExpress.XtraGrid.Columns.GridColumn coldateAdd;
        private DevExpress.XtraGrid.Columns.GridColumn colemployeeId;
        private DevExpress.XtraBars.BarButtonItem barButtonItem1;
        private DevExpress.XtraBars.BarButtonItem barButtonItem2;
        private DevExpress.XtraBars.BarButtonItem barButtonItem3;
        private DevExpress.XtraBars.BarButtonItem barButtonItem4;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip2;
        private System.Windows.Forms.ToolStripMenuItem addImportCouponItemToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem addImportCuponItemToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem deleteItemToolStripMenuItem;
        private DevExpress.XtraGrid.GridControl importCouponDetailGridControl;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView2;
        private DevExpress.XtraGrid.Columns.GridColumn colcouponId;
        private DevExpress.XtraGrid.Columns.GridColumn colproductId;
        private DevExpress.XtraGrid.Columns.GridColumn colquantity;
        private DevExpress.XtraGrid.Columns.GridColumn colprice;
    }
}