
namespace PhoneManager
{
    partial class InvoiceForm
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
            System.Windows.Forms.Label statusIdLabel;
            System.Windows.Forms.Label invoiceIdLabel;
            System.Windows.Forms.Label updateDateLabel;
            System.Windows.Forms.Label buyDateLabel;
            System.Windows.Forms.Label deliveryDateLabel;
            System.Windows.Forms.Label nameLabel;
            System.Windows.Forms.Label phoneLabel;
            System.Windows.Forms.Label addressLabel;
            System.Windows.Forms.Label noteLabel;
            System.Windows.Forms.Label totalPriceLabel;
            System.Windows.Forms.Label userIdLabel;
            System.Windows.Forms.Label employeeIdLabel;
            System.Windows.Forms.Label statusOderIDLabel;
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(InvoiceForm));
            this.barManager1 = new DevExpress.XtraBars.BarManager(this.components);
            this.bar2 = new DevExpress.XtraBars.Bar();
            this.barButtonItem1 = new DevExpress.XtraBars.BarButtonItem();
            this.barButtonItem2 = new DevExpress.XtraBars.BarButtonItem();
            this.barDockControlTop = new DevExpress.XtraBars.BarDockControl();
            this.barDockControlBottom = new DevExpress.XtraBars.BarDockControl();
            this.barDockControlLeft = new DevExpress.XtraBars.BarDockControl();
            this.barDockControlRight = new DevExpress.XtraBars.BarDockControl();
            this.panel1 = new System.Windows.Forms.Panel();
            this.statusIdComboBox = new System.Windows.Forms.ComboBox();
            this.invoiceStatusBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.phoneShopDataSet = new PhoneManager.PhoneShopDataSet();
            this.invoiceStatusTableAdapter = new PhoneManager.PhoneShopDataSetTableAdapters.InvoiceStatusTableAdapter();
            this.tableAdapterManager = new PhoneManager.PhoneShopDataSetTableAdapters.TableAdapterManager();
            this.panel2 = new System.Windows.Forms.Panel();
            this.invoiceGridControl = new DevExpress.XtraGrid.GridControl();
            this.invoiceBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colinvoiceId = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colupdateDate = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colbuyDate = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colname = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colphone = new DevExpress.XtraGrid.Columns.GridColumn();
            this.coladdress = new DevExpress.XtraGrid.Columns.GridColumn();
            this.coltotalPrice = new DevExpress.XtraGrid.Columns.GridColumn();
            this.coluserId = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colstatusOderID = new DevExpress.XtraGrid.Columns.GridColumn();
            this.coldeliveryDate = new DevExpress.XtraGrid.Columns.GridColumn();
            this.panel3 = new System.Windows.Forms.Panel();
            this.invoiceItemGridControl = new DevExpress.XtraGrid.GridControl();
            this.invoiceItemBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.gridView2 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colinvoiceId1 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colproductId = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colquantity = new DevExpress.XtraGrid.Columns.GridColumn();
            this.invoiceTableAdapter = new PhoneManager.PhoneShopDataSetTableAdapters.InvoiceTableAdapter();
            this.invoiceItemTableAdapter = new PhoneManager.PhoneShopDataSetTableAdapters.InvoiceItemTableAdapter();
            this.invoiceStatusBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.panel4 = new System.Windows.Forms.Panel();
            this.statusOderIDSpinEdit = new DevExpress.XtraEditors.SpinEdit();
            this.statusNameLabel1 = new System.Windows.Forms.Label();
            this.invoiceStatusBindingSource2 = new System.Windows.Forms.BindingSource(this.components);
            this.btnCancelAddProvider = new System.Windows.Forms.Button();
            this.btnSaveAddProvider = new System.Windows.Forms.Button();
            this.employeeIdSpinEdit = new DevExpress.XtraEditors.SpinEdit();
            this.userIdSpinEdit = new DevExpress.XtraEditors.SpinEdit();
            this.totalPriceSpinEdit = new DevExpress.XtraEditors.SpinEdit();
            this.noteTextEdit = new DevExpress.XtraEditors.TextEdit();
            this.addressTextEdit = new DevExpress.XtraEditors.TextEdit();
            this.phoneTextEdit = new DevExpress.XtraEditors.TextEdit();
            this.nameTextEdit = new DevExpress.XtraEditors.TextEdit();
            this.deliveryDateDateEdit = new DevExpress.XtraEditors.DateEdit();
            this.buyDateDateEdit = new DevExpress.XtraEditors.DateEdit();
            this.updateDateDateEdit = new DevExpress.XtraEditors.DateEdit();
            this.invoiceIdSpinEdit = new DevExpress.XtraEditors.SpinEdit();
            this.productBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.productTableAdapter = new PhoneManager.PhoneShopDataSetTableAdapters.ProductTableAdapter();
            statusIdLabel = new System.Windows.Forms.Label();
            invoiceIdLabel = new System.Windows.Forms.Label();
            updateDateLabel = new System.Windows.Forms.Label();
            buyDateLabel = new System.Windows.Forms.Label();
            deliveryDateLabel = new System.Windows.Forms.Label();
            nameLabel = new System.Windows.Forms.Label();
            phoneLabel = new System.Windows.Forms.Label();
            addressLabel = new System.Windows.Forms.Label();
            noteLabel = new System.Windows.Forms.Label();
            totalPriceLabel = new System.Windows.Forms.Label();
            userIdLabel = new System.Windows.Forms.Label();
            employeeIdLabel = new System.Windows.Forms.Label();
            statusOderIDLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.barManager1)).BeginInit();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.invoiceStatusBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.phoneShopDataSet)).BeginInit();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.invoiceGridControl)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.invoiceBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.invoiceItemGridControl)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.invoiceItemBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.invoiceStatusBindingSource1)).BeginInit();
            this.panel4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.statusOderIDSpinEdit.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.invoiceStatusBindingSource2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.employeeIdSpinEdit.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.userIdSpinEdit.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.totalPriceSpinEdit.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.noteTextEdit.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.addressTextEdit.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.phoneTextEdit.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nameTextEdit.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.deliveryDateDateEdit.Properties.CalendarTimeProperties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.deliveryDateDateEdit.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.buyDateDateEdit.Properties.CalendarTimeProperties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.buyDateDateEdit.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.updateDateDateEdit.Properties.CalendarTimeProperties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.updateDateDateEdit.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.invoiceIdSpinEdit.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.productBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // statusIdLabel
            // 
            statusIdLabel.AutoSize = true;
            statusIdLabel.Location = new System.Drawing.Point(24, 13);
            statusIdLabel.Name = "statusIdLabel";
            statusIdLabel.Size = new System.Drawing.Size(69, 13);
            statusIdLabel.TabIndex = 2;
            statusIdLabel.Text = "Status Order";
            // 
            // invoiceIdLabel
            // 
            invoiceIdLabel.AutoSize = true;
            invoiceIdLabel.Location = new System.Drawing.Point(39, 42);
            invoiceIdLabel.Name = "invoiceIdLabel";
            invoiceIdLabel.Size = new System.Drawing.Size(57, 13);
            invoiceIdLabel.TabIndex = 0;
            invoiceIdLabel.Text = "invoice Id:";
            // 
            // updateDateLabel
            // 
            updateDateLabel.AutoSize = true;
            updateDateLabel.Location = new System.Drawing.Point(272, 42);
            updateDateLabel.Name = "updateDateLabel";
            updateDateLabel.Size = new System.Drawing.Size(71, 13);
            updateDateLabel.TabIndex = 2;
            updateDateLabel.Text = "update Date:";
            updateDateLabel.Click += new System.EventHandler(this.updateDateLabel_Click);
            // 
            // buyDateLabel
            // 
            buyDateLabel.AutoSize = true;
            buyDateLabel.Location = new System.Drawing.Point(532, 43);
            buyDateLabel.Name = "buyDateLabel";
            buyDateLabel.Size = new System.Drawing.Size(55, 13);
            buyDateLabel.TabIndex = 4;
            buyDateLabel.Text = "buy Date:";
            buyDateLabel.Click += new System.EventHandler(this.buyDateLabel_Click);
            // 
            // deliveryDateLabel
            // 
            deliveryDateLabel.AutoSize = true;
            deliveryDateLabel.Location = new System.Drawing.Point(758, 43);
            deliveryDateLabel.Name = "deliveryDateLabel";
            deliveryDateLabel.Size = new System.Drawing.Size(75, 13);
            deliveryDateLabel.TabIndex = 6;
            deliveryDateLabel.Text = "delivery Date:";
            deliveryDateLabel.Click += new System.EventHandler(this.deliveryDateLabel_Click);
            // 
            // nameLabel
            // 
            nameLabel.AutoSize = true;
            nameLabel.Location = new System.Drawing.Point(39, 84);
            nameLabel.Name = "nameLabel";
            nameLabel.Size = new System.Drawing.Size(37, 13);
            nameLabel.TabIndex = 8;
            nameLabel.Text = "name:";
            // 
            // phoneLabel
            // 
            phoneLabel.AutoSize = true;
            phoneLabel.Location = new System.Drawing.Point(302, 80);
            phoneLabel.Name = "phoneLabel";
            phoneLabel.Size = new System.Drawing.Size(41, 13);
            phoneLabel.TabIndex = 10;
            phoneLabel.Text = "phone:";
            // 
            // addressLabel
            // 
            addressLabel.AutoSize = true;
            addressLabel.Location = new System.Drawing.Point(538, 84);
            addressLabel.Name = "addressLabel";
            addressLabel.Size = new System.Drawing.Size(49, 13);
            addressLabel.TabIndex = 12;
            addressLabel.Text = "address:";
            // 
            // noteLabel
            // 
            noteLabel.AutoSize = true;
            noteLabel.Location = new System.Drawing.Point(882, 80);
            noteLabel.Name = "noteLabel";
            noteLabel.Size = new System.Drawing.Size(33, 13);
            noteLabel.TabIndex = 14;
            noteLabel.Text = "note:";
            // 
            // totalPriceLabel
            // 
            totalPriceLabel.AutoSize = true;
            totalPriceLabel.Location = new System.Drawing.Point(39, 172);
            totalPriceLabel.Name = "totalPriceLabel";
            totalPriceLabel.Size = new System.Drawing.Size(59, 13);
            totalPriceLabel.TabIndex = 16;
            totalPriceLabel.Text = "total Price:";
            // 
            // userIdLabel
            // 
            userIdLabel.AutoSize = true;
            userIdLabel.Location = new System.Drawing.Point(39, 125);
            userIdLabel.Name = "userIdLabel";
            userIdLabel.Size = new System.Drawing.Size(45, 13);
            userIdLabel.TabIndex = 18;
            userIdLabel.Text = "user Id:";
            // 
            // employeeIdLabel
            // 
            employeeIdLabel.AutoSize = true;
            employeeIdLabel.Location = new System.Drawing.Point(273, 125);
            employeeIdLabel.Name = "employeeIdLabel";
            employeeIdLabel.Size = new System.Drawing.Size(70, 13);
            employeeIdLabel.TabIndex = 20;
            employeeIdLabel.Text = "employee Id:";
            // 
            // statusOderIDLabel
            // 
            statusOderIDLabel.AutoSize = true;
            statusOderIDLabel.Location = new System.Drawing.Point(261, 171);
            statusOderIDLabel.Name = "statusOderIDLabel";
            statusOderIDLabel.Size = new System.Drawing.Size(82, 13);
            statusOderIDLabel.TabIndex = 22;
            statusOderIDLabel.Text = "status Oder ID:";
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
            this.barButtonItem2});
            this.barManager1.MainMenu = this.bar2;
            this.barManager1.MaxItemId = 2;
            // 
            // bar2
            // 
            this.bar2.BarName = "Main menu";
            this.bar2.DockCol = 0;
            this.bar2.DockRow = 0;
            this.bar2.DockStyle = DevExpress.XtraBars.BarDockStyle.Top;
            this.bar2.LinksPersistInfo.AddRange(new DevExpress.XtraBars.LinkPersistInfo[] {
            new DevExpress.XtraBars.LinkPersistInfo(this.barButtonItem1),
            new DevExpress.XtraBars.LinkPersistInfo(this.barButtonItem2)});
            this.bar2.OptionsBar.MultiLine = true;
            this.bar2.OptionsBar.UseWholeRow = true;
            this.bar2.Text = "Main menu";
            // 
            // barButtonItem1
            // 
            this.barButtonItem1.Caption = "Reload";
            this.barButtonItem1.Id = 0;
            this.barButtonItem1.ImageOptions.Image = global::PhoneManager.Properties.Resources.exchange;
            this.barButtonItem1.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("barButtonItem1.ImageOptions.LargeImage")));
            this.barButtonItem1.Name = "barButtonItem1";
            this.barButtonItem1.PaintStyle = DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph;
            this.barButtonItem1.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnReloadProvider_ItemClick);
            // 
            // barButtonItem2
            // 
            this.barButtonItem2.Caption = "Close Form";
            this.barButtonItem2.Id = 1;
            this.barButtonItem2.ImageOptions.Image = global::PhoneManager.Properties.Resources.close;
            this.barButtonItem2.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("barButtonItem2.ImageOptions.LargeImage")));
            this.barButtonItem2.Name = "barButtonItem2";
            this.barButtonItem2.PaintStyle = DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph;
            this.barButtonItem2.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnCloseForm_ItemClick);
            // 
            // barDockControlTop
            // 
            this.barDockControlTop.CausesValidation = false;
            this.barDockControlTop.Dock = System.Windows.Forms.DockStyle.Top;
            this.barDockControlTop.Location = new System.Drawing.Point(0, 0);
            this.barDockControlTop.Manager = this.barManager1;
            this.barDockControlTop.Size = new System.Drawing.Size(1332, 27);
            // 
            // barDockControlBottom
            // 
            this.barDockControlBottom.CausesValidation = false;
            this.barDockControlBottom.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.barDockControlBottom.Location = new System.Drawing.Point(0, 569);
            this.barDockControlBottom.Manager = this.barManager1;
            this.barDockControlBottom.Size = new System.Drawing.Size(1332, 0);
            // 
            // barDockControlLeft
            // 
            this.barDockControlLeft.CausesValidation = false;
            this.barDockControlLeft.Dock = System.Windows.Forms.DockStyle.Left;
            this.barDockControlLeft.Location = new System.Drawing.Point(0, 27);
            this.barDockControlLeft.Manager = this.barManager1;
            this.barDockControlLeft.Size = new System.Drawing.Size(0, 542);
            // 
            // barDockControlRight
            // 
            this.barDockControlRight.CausesValidation = false;
            this.barDockControlRight.Dock = System.Windows.Forms.DockStyle.Right;
            this.barDockControlRight.Location = new System.Drawing.Point(1332, 27);
            this.barDockControlRight.Manager = this.barManager1;
            this.barDockControlRight.Size = new System.Drawing.Size(0, 542);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(statusIdLabel);
            this.panel1.Controls.Add(this.statusIdComboBox);
            this.panel1.Location = new System.Drawing.Point(0, 27);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1332, 42);
            this.panel1.TabIndex = 4;
            // 
            // statusIdComboBox
            // 
            this.statusIdComboBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.invoiceStatusBindingSource, "statusId", true));
            this.statusIdComboBox.DataSource = this.invoiceStatusBindingSource;
            this.statusIdComboBox.DisplayMember = "statusName";
            this.statusIdComboBox.Location = new System.Drawing.Point(108, 10);
            this.statusIdComboBox.Name = "statusIdComboBox";
            this.statusIdComboBox.Size = new System.Drawing.Size(266, 21);
            this.statusIdComboBox.TabIndex = 3;
            this.statusIdComboBox.ValueMember = "statusName";
            this.statusIdComboBox.SelectionChangeCommitted += new System.EventHandler(this.statusIdComboBox_SelectionChangeCommitted);
            // 
            // invoiceStatusBindingSource
            // 
            this.invoiceStatusBindingSource.DataMember = "InvoiceStatus";
            this.invoiceStatusBindingSource.DataSource = this.phoneShopDataSet;
            // 
            // phoneShopDataSet
            // 
            this.phoneShopDataSet.DataSetName = "PhoneShopDataSet";
            this.phoneShopDataSet.EnforceConstraints = false;
            this.phoneShopDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // invoiceStatusTableAdapter
            // 
            this.invoiceStatusTableAdapter.ClearBeforeFill = true;
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
            this.tableAdapterManager.ImportCouponDetailTableAdapter = null;
            this.tableAdapterManager.ImportCouponTableAdapter = null;
            this.tableAdapterManager.InvoiceItemTableAdapter = null;
            this.tableAdapterManager.InvoiceStatusTableAdapter = this.invoiceStatusTableAdapter;
            this.tableAdapterManager.InvoiceTableAdapter = null;
            this.tableAdapterManager.ProductTableAdapter = null;
            this.tableAdapterManager.ProviderTableAdapter = null;
            this.tableAdapterManager.RoleTableAdapter = null;
            this.tableAdapterManager.ShopInfoTableAdapter = null;
            this.tableAdapterManager.SlideTableAdapter = null;
            this.tableAdapterManager.UpdateOrder = PhoneManager.PhoneShopDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.invoiceGridControl);
            this.panel2.Location = new System.Drawing.Point(0, 64);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(774, 235);
            this.panel2.TabIndex = 10;
            // 
            // invoiceGridControl
            // 
            this.invoiceGridControl.DataSource = this.invoiceBindingSource;
            this.invoiceGridControl.Location = new System.Drawing.Point(3, 6);
            this.invoiceGridControl.MainView = this.gridView1;
            this.invoiceGridControl.MenuManager = this.barManager1;
            this.invoiceGridControl.Name = "invoiceGridControl";
            this.invoiceGridControl.Size = new System.Drawing.Size(768, 226);
            this.invoiceGridControl.TabIndex = 0;
            this.invoiceGridControl.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView1});
            // 
            // invoiceBindingSource
            // 
            this.invoiceBindingSource.DataMember = "FK_Invoice_InvoiceStatus";
            this.invoiceBindingSource.DataSource = this.invoiceStatusBindingSource;
            // 
            // gridView1
            // 
            this.gridView1.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colinvoiceId,
            this.colupdateDate,
            this.colbuyDate,
            this.colname,
            this.colphone,
            this.coladdress,
            this.coltotalPrice,
            this.coluserId,
            this.colstatusOderID,
            this.coldeliveryDate});
            this.gridView1.GridControl = this.invoiceGridControl;
            this.gridView1.Name = "gridView1";
            this.gridView1.OptionsBehavior.Editable = false;
            this.gridView1.OptionsView.ShowViewCaption = true;
            this.gridView1.ViewCaption = "INVOICE";
            // 
            // colinvoiceId
            // 
            this.colinvoiceId.FieldName = "invoiceId";
            this.colinvoiceId.Name = "colinvoiceId";
            this.colinvoiceId.Visible = true;
            this.colinvoiceId.VisibleIndex = 0;
            // 
            // colupdateDate
            // 
            this.colupdateDate.FieldName = "updateDate";
            this.colupdateDate.Name = "colupdateDate";
            this.colupdateDate.Visible = true;
            this.colupdateDate.VisibleIndex = 1;
            // 
            // colbuyDate
            // 
            this.colbuyDate.FieldName = "buyDate";
            this.colbuyDate.Name = "colbuyDate";
            this.colbuyDate.Visible = true;
            this.colbuyDate.VisibleIndex = 2;
            // 
            // colname
            // 
            this.colname.FieldName = "name";
            this.colname.Name = "colname";
            this.colname.Visible = true;
            this.colname.VisibleIndex = 3;
            // 
            // colphone
            // 
            this.colphone.FieldName = "phone";
            this.colphone.Name = "colphone";
            this.colphone.Visible = true;
            this.colphone.VisibleIndex = 4;
            // 
            // coladdress
            // 
            this.coladdress.FieldName = "address";
            this.coladdress.Name = "coladdress";
            this.coladdress.Visible = true;
            this.coladdress.VisibleIndex = 5;
            // 
            // coltotalPrice
            // 
            this.coltotalPrice.FieldName = "totalPrice";
            this.coltotalPrice.Name = "coltotalPrice";
            this.coltotalPrice.Visible = true;
            this.coltotalPrice.VisibleIndex = 6;
            // 
            // coluserId
            // 
            this.coluserId.FieldName = "userId";
            this.coluserId.Name = "coluserId";
            this.coluserId.Visible = true;
            this.coluserId.VisibleIndex = 7;
            // 
            // colstatusOderID
            // 
            this.colstatusOderID.FieldName = "statusOderID";
            this.colstatusOderID.Name = "colstatusOderID";
            this.colstatusOderID.Visible = true;
            this.colstatusOderID.VisibleIndex = 8;
            // 
            // coldeliveryDate
            // 
            this.coldeliveryDate.FieldName = "deliveryDate";
            this.coldeliveryDate.Name = "coldeliveryDate";
            this.coldeliveryDate.Visible = true;
            this.coldeliveryDate.VisibleIndex = 9;
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.invoiceItemGridControl);
            this.panel3.Location = new System.Drawing.Point(780, 64);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(552, 235);
            this.panel3.TabIndex = 11;
            // 
            // invoiceItemGridControl
            // 
            this.invoiceItemGridControl.DataSource = this.invoiceItemBindingSource;
            this.invoiceItemGridControl.Location = new System.Drawing.Point(3, 6);
            this.invoiceItemGridControl.MainView = this.gridView2;
            this.invoiceItemGridControl.MenuManager = this.barManager1;
            this.invoiceItemGridControl.Name = "invoiceItemGridControl";
            this.invoiceItemGridControl.Size = new System.Drawing.Size(546, 229);
            this.invoiceItemGridControl.TabIndex = 0;
            this.invoiceItemGridControl.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView2});
            // 
            // invoiceItemBindingSource
            // 
            this.invoiceItemBindingSource.DataMember = "FK_InvoiceItem_Invoice";
            this.invoiceItemBindingSource.DataSource = this.invoiceBindingSource;
            // 
            // gridView2
            // 
            this.gridView2.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colinvoiceId1,
            this.colproductId,
            this.colquantity});
            this.gridView2.GridControl = this.invoiceItemGridControl;
            this.gridView2.Name = "gridView2";
            this.gridView2.OptionsBehavior.Editable = false;
            this.gridView2.OptionsView.ShowViewCaption = true;
            this.gridView2.ViewCaption = "INVOICE ITEM";
            // 
            // colinvoiceId1
            // 
            this.colinvoiceId1.FieldName = "invoiceId";
            this.colinvoiceId1.Name = "colinvoiceId1";
            this.colinvoiceId1.Visible = true;
            this.colinvoiceId1.VisibleIndex = 0;
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
            // invoiceTableAdapter
            // 
            this.invoiceTableAdapter.ClearBeforeFill = true;
            // 
            // invoiceItemTableAdapter
            // 
            this.invoiceItemTableAdapter.ClearBeforeFill = true;
            // 
            // invoiceStatusBindingSource1
            // 
            this.invoiceStatusBindingSource1.DataMember = "InvoiceStatus";
            this.invoiceStatusBindingSource1.DataSource = this.phoneShopDataSet;
            // 
            // panel4
            // 
            this.panel4.AutoScroll = true;
            this.panel4.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel4.Controls.Add(this.statusOderIDSpinEdit);
            this.panel4.Controls.Add(this.statusNameLabel1);
            this.panel4.Controls.Add(this.btnCancelAddProvider);
            this.panel4.Controls.Add(statusOderIDLabel);
            this.panel4.Controls.Add(this.btnSaveAddProvider);
            this.panel4.Controls.Add(employeeIdLabel);
            this.panel4.Controls.Add(this.employeeIdSpinEdit);
            this.panel4.Controls.Add(userIdLabel);
            this.panel4.Controls.Add(this.userIdSpinEdit);
            this.panel4.Controls.Add(totalPriceLabel);
            this.panel4.Controls.Add(this.totalPriceSpinEdit);
            this.panel4.Controls.Add(noteLabel);
            this.panel4.Controls.Add(this.noteTextEdit);
            this.panel4.Controls.Add(addressLabel);
            this.panel4.Controls.Add(this.addressTextEdit);
            this.panel4.Controls.Add(phoneLabel);
            this.panel4.Controls.Add(this.phoneTextEdit);
            this.panel4.Controls.Add(nameLabel);
            this.panel4.Controls.Add(this.nameTextEdit);
            this.panel4.Controls.Add(deliveryDateLabel);
            this.panel4.Controls.Add(this.deliveryDateDateEdit);
            this.panel4.Controls.Add(buyDateLabel);
            this.panel4.Controls.Add(this.buyDateDateEdit);
            this.panel4.Controls.Add(updateDateLabel);
            this.panel4.Controls.Add(this.updateDateDateEdit);
            this.panel4.Controls.Add(invoiceIdLabel);
            this.panel4.Controls.Add(this.invoiceIdSpinEdit);
            this.panel4.Location = new System.Drawing.Point(0, 302);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(1329, 267);
            this.panel4.TabIndex = 2;
            this.panel4.Paint += new System.Windows.Forms.PaintEventHandler(this.panel4_Paint);
            // 
            // statusOderIDSpinEdit
            // 
            this.statusOderIDSpinEdit.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.invoiceBindingSource, "statusOderID", true));
            this.statusOderIDSpinEdit.EditValue = new decimal(new int[] {
            0,
            0,
            0,
            0});
            this.statusOderIDSpinEdit.Enabled = false;
            this.statusOderIDSpinEdit.Location = new System.Drawing.Point(520, 169);
            this.statusOderIDSpinEdit.MenuManager = this.barManager1;
            this.statusOderIDSpinEdit.Name = "statusOderIDSpinEdit";
            this.statusOderIDSpinEdit.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.statusOderIDSpinEdit.Size = new System.Drawing.Size(43, 20);
            this.statusOderIDSpinEdit.TabIndex = 62;
            // 
            // statusNameLabel1
            // 
            this.statusNameLabel1.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.invoiceStatusBindingSource2, "statusName", true));
            this.statusNameLabel1.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.statusNameLabel1.ForeColor = System.Drawing.Color.SteelBlue;
            this.statusNameLabel1.Location = new System.Drawing.Point(364, 169);
            this.statusNameLabel1.Name = "statusNameLabel1";
            this.statusNameLabel1.Size = new System.Drawing.Size(150, 23);
            this.statusNameLabel1.TabIndex = 61;
            this.statusNameLabel1.Text = "label1";
            // 
            // invoiceStatusBindingSource2
            // 
            this.invoiceStatusBindingSource2.DataMember = "InvoiceStatus";
            this.invoiceStatusBindingSource2.DataSource = this.phoneShopDataSet;
            // 
            // btnCancelAddProvider
            // 
            this.btnCancelAddProvider.BackColor = System.Drawing.Color.White;
            this.btnCancelAddProvider.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCancelAddProvider.ForeColor = System.Drawing.Color.Crimson;
            this.btnCancelAddProvider.Location = new System.Drawing.Point(630, 203);
            this.btnCancelAddProvider.Margin = new System.Windows.Forms.Padding(2);
            this.btnCancelAddProvider.Name = "btnCancelAddProvider";
            this.btnCancelAddProvider.Size = new System.Drawing.Size(92, 42);
            this.btnCancelAddProvider.TabIndex = 60;
            this.btnCancelAddProvider.Text = "Cancel";
            this.btnCancelAddProvider.UseVisualStyleBackColor = false;
            this.btnCancelAddProvider.Click += new System.EventHandler(this.btnCancelAddProvider_Click_1);
            // 
            // btnSaveAddProvider
            // 
            this.btnSaveAddProvider.BackColor = System.Drawing.Color.White;
            this.btnSaveAddProvider.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSaveAddProvider.ForeColor = System.Drawing.Color.ForestGreen;
            this.btnSaveAddProvider.Location = new System.Drawing.Point(438, 203);
            this.btnSaveAddProvider.Margin = new System.Windows.Forms.Padding(2);
            this.btnSaveAddProvider.Name = "btnSaveAddProvider";
            this.btnSaveAddProvider.Size = new System.Drawing.Size(92, 42);
            this.btnSaveAddProvider.TabIndex = 59;
            this.btnSaveAddProvider.Text = "Confirm";
            this.btnSaveAddProvider.UseVisualStyleBackColor = false;
            this.btnSaveAddProvider.Click += new System.EventHandler(this.btnSaveAddProvider_Click_1);
            // 
            // employeeIdSpinEdit
            // 
            this.employeeIdSpinEdit.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.invoiceBindingSource, "employeeId", true));
            this.employeeIdSpinEdit.EditValue = new decimal(new int[] {
            0,
            0,
            0,
            0});
            this.employeeIdSpinEdit.Enabled = false;
            this.employeeIdSpinEdit.Location = new System.Drawing.Point(364, 122);
            this.employeeIdSpinEdit.MenuManager = this.barManager1;
            this.employeeIdSpinEdit.Name = "employeeIdSpinEdit";
            this.employeeIdSpinEdit.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.employeeIdSpinEdit.Size = new System.Drawing.Size(100, 20);
            this.employeeIdSpinEdit.TabIndex = 21;
            // 
            // userIdSpinEdit
            // 
            this.userIdSpinEdit.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.invoiceBindingSource, "userId", true));
            this.userIdSpinEdit.EditValue = new decimal(new int[] {
            0,
            0,
            0,
            0});
            this.userIdSpinEdit.Enabled = false;
            this.userIdSpinEdit.Location = new System.Drawing.Point(120, 121);
            this.userIdSpinEdit.MenuManager = this.barManager1;
            this.userIdSpinEdit.Name = "userIdSpinEdit";
            this.userIdSpinEdit.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.userIdSpinEdit.Size = new System.Drawing.Size(100, 20);
            this.userIdSpinEdit.TabIndex = 19;
            // 
            // totalPriceSpinEdit
            // 
            this.totalPriceSpinEdit.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.invoiceBindingSource, "totalPrice", true));
            this.totalPriceSpinEdit.EditValue = new decimal(new int[] {
            0,
            0,
            0,
            0});
            this.totalPriceSpinEdit.Enabled = false;
            this.totalPriceSpinEdit.Location = new System.Drawing.Point(120, 168);
            this.totalPriceSpinEdit.MenuManager = this.barManager1;
            this.totalPriceSpinEdit.Name = "totalPriceSpinEdit";
            this.totalPriceSpinEdit.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.totalPriceSpinEdit.Size = new System.Drawing.Size(100, 20);
            this.totalPriceSpinEdit.TabIndex = 17;
            // 
            // noteTextEdit
            // 
            this.noteTextEdit.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.invoiceBindingSource, "note", true));
            this.noteTextEdit.Enabled = false;
            this.noteTextEdit.Location = new System.Drawing.Point(949, 77);
            this.noteTextEdit.MenuManager = this.barManager1;
            this.noteTextEdit.Name = "noteTextEdit";
            this.noteTextEdit.Size = new System.Drawing.Size(265, 20);
            this.noteTextEdit.TabIndex = 15;
            // 
            // addressTextEdit
            // 
            this.addressTextEdit.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.invoiceBindingSource, "address", true));
            this.addressTextEdit.Enabled = false;
            this.addressTextEdit.Location = new System.Drawing.Point(613, 77);
            this.addressTextEdit.MenuManager = this.barManager1;
            this.addressTextEdit.Name = "addressTextEdit";
            this.addressTextEdit.Size = new System.Drawing.Size(202, 20);
            this.addressTextEdit.TabIndex = 13;
            // 
            // phoneTextEdit
            // 
            this.phoneTextEdit.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.invoiceBindingSource, "phone", true));
            this.phoneTextEdit.Enabled = false;
            this.phoneTextEdit.Location = new System.Drawing.Point(364, 76);
            this.phoneTextEdit.MenuManager = this.barManager1;
            this.phoneTextEdit.Name = "phoneTextEdit";
            this.phoneTextEdit.Size = new System.Drawing.Size(121, 20);
            this.phoneTextEdit.TabIndex = 11;
            // 
            // nameTextEdit
            // 
            this.nameTextEdit.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.invoiceBindingSource, "name", true));
            this.nameTextEdit.Enabled = false;
            this.nameTextEdit.Location = new System.Drawing.Point(120, 80);
            this.nameTextEdit.MenuManager = this.barManager1;
            this.nameTextEdit.Name = "nameTextEdit";
            this.nameTextEdit.Size = new System.Drawing.Size(100, 20);
            this.nameTextEdit.TabIndex = 9;
            // 
            // deliveryDateDateEdit
            // 
            this.deliveryDateDateEdit.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.invoiceBindingSource, "deliveryDate", true));
            this.deliveryDateDateEdit.EditValue = null;
            this.deliveryDateDateEdit.Enabled = false;
            this.deliveryDateDateEdit.Location = new System.Drawing.Point(839, 39);
            this.deliveryDateDateEdit.MenuManager = this.barManager1;
            this.deliveryDateDateEdit.Name = "deliveryDateDateEdit";
            this.deliveryDateDateEdit.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.deliveryDateDateEdit.Properties.CalendarTimeProperties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.deliveryDateDateEdit.Size = new System.Drawing.Size(100, 20);
            this.deliveryDateDateEdit.TabIndex = 7;
            this.deliveryDateDateEdit.EditValueChanged += new System.EventHandler(this.deliveryDateDateEdit_EditValueChanged);
            // 
            // buyDateDateEdit
            // 
            this.buyDateDateEdit.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.invoiceBindingSource, "buyDate", true));
            this.buyDateDateEdit.EditValue = null;
            this.buyDateDateEdit.Enabled = false;
            this.buyDateDateEdit.Location = new System.Drawing.Point(613, 39);
            this.buyDateDateEdit.MenuManager = this.barManager1;
            this.buyDateDateEdit.Name = "buyDateDateEdit";
            this.buyDateDateEdit.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.buyDateDateEdit.Properties.CalendarTimeProperties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.buyDateDateEdit.Size = new System.Drawing.Size(100, 20);
            this.buyDateDateEdit.TabIndex = 5;
            this.buyDateDateEdit.EditValueChanged += new System.EventHandler(this.buyDateDateEdit_EditValueChanged);
            // 
            // updateDateDateEdit
            // 
            this.updateDateDateEdit.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.invoiceBindingSource, "updateDate", true));
            this.updateDateDateEdit.EditValue = null;
            this.updateDateDateEdit.Enabled = false;
            this.updateDateDateEdit.Location = new System.Drawing.Point(364, 39);
            this.updateDateDateEdit.MenuManager = this.barManager1;
            this.updateDateDateEdit.Name = "updateDateDateEdit";
            this.updateDateDateEdit.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.updateDateDateEdit.Properties.CalendarTimeProperties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.updateDateDateEdit.Size = new System.Drawing.Size(121, 20);
            this.updateDateDateEdit.TabIndex = 3;
            this.updateDateDateEdit.EditValueChanged += new System.EventHandler(this.updateDateDateEdit_EditValueChanged);
            // 
            // invoiceIdSpinEdit
            // 
            this.invoiceIdSpinEdit.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.invoiceBindingSource, "invoiceId", true));
            this.invoiceIdSpinEdit.EditValue = new decimal(new int[] {
            0,
            0,
            0,
            0});
            this.invoiceIdSpinEdit.Enabled = false;
            this.invoiceIdSpinEdit.Location = new System.Drawing.Point(120, 39);
            this.invoiceIdSpinEdit.MenuManager = this.barManager1;
            this.invoiceIdSpinEdit.Name = "invoiceIdSpinEdit";
            this.invoiceIdSpinEdit.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.invoiceIdSpinEdit.Size = new System.Drawing.Size(100, 20);
            this.invoiceIdSpinEdit.TabIndex = 1;
            // 
            // productBindingSource
            // 
            this.productBindingSource.DataMember = "Product";
            this.productBindingSource.DataSource = this.phoneShopDataSet;
            // 
            // productTableAdapter
            // 
            this.productTableAdapter.ClearBeforeFill = true;
            // 
            // InvoiceForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.ClientSize = new System.Drawing.Size(1332, 569);
            this.Controls.Add(this.panel4);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.barDockControlLeft);
            this.Controls.Add(this.barDockControlRight);
            this.Controls.Add(this.barDockControlBottom);
            this.Controls.Add(this.barDockControlTop);
            this.Name = "InvoiceForm";
            this.Text = "InvoiceForm";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.InvoiceForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.barManager1)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.invoiceStatusBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.phoneShopDataSet)).EndInit();
            this.panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.invoiceGridControl)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.invoiceBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            this.panel3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.invoiceItemGridControl)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.invoiceItemBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.invoiceStatusBindingSource1)).EndInit();
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.statusOderIDSpinEdit.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.invoiceStatusBindingSource2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.employeeIdSpinEdit.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.userIdSpinEdit.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.totalPriceSpinEdit.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.noteTextEdit.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.addressTextEdit.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.phoneTextEdit.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nameTextEdit.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.deliveryDateDateEdit.Properties.CalendarTimeProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.deliveryDateDateEdit.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.buyDateDateEdit.Properties.CalendarTimeProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.buyDateDateEdit.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.updateDateDateEdit.Properties.CalendarTimeProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.updateDateDateEdit.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.invoiceIdSpinEdit.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.productBindingSource)).EndInit();
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
        private System.Windows.Forms.BindingSource invoiceStatusBindingSource;
        private PhoneShopDataSet phoneShopDataSet;
        private System.Windows.Forms.Panel panel1;
        private PhoneShopDataSetTableAdapters.InvoiceStatusTableAdapter invoiceStatusTableAdapter;
        private PhoneShopDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.BindingSource invoiceBindingSource;
        private PhoneShopDataSetTableAdapters.InvoiceTableAdapter invoiceTableAdapter;
        private DevExpress.XtraGrid.GridControl invoiceGridControl;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
        private System.Windows.Forms.BindingSource invoiceItemBindingSource;
        private PhoneShopDataSetTableAdapters.InvoiceItemTableAdapter invoiceItemTableAdapter;
        private DevExpress.XtraGrid.GridControl invoiceItemGridControl;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView2;
        private DevExpress.XtraGrid.Columns.GridColumn colinvoiceId1;
        private DevExpress.XtraGrid.Columns.GridColumn colproductId;
        private DevExpress.XtraGrid.Columns.GridColumn colquantity;
        private DevExpress.XtraGrid.Columns.GridColumn colinvoiceId;
        private DevExpress.XtraGrid.Columns.GridColumn colupdateDate;
        private DevExpress.XtraGrid.Columns.GridColumn colbuyDate;
        private DevExpress.XtraGrid.Columns.GridColumn colname;
        private DevExpress.XtraGrid.Columns.GridColumn colphone;
        private DevExpress.XtraGrid.Columns.GridColumn coladdress;
        private DevExpress.XtraGrid.Columns.GridColumn coltotalPrice;
        private DevExpress.XtraGrid.Columns.GridColumn coluserId;
        private DevExpress.XtraGrid.Columns.GridColumn colstatusOderID;
        private DevExpress.XtraGrid.Columns.GridColumn coldeliveryDate;
        private System.Windows.Forms.ComboBox statusIdComboBox;
        private System.Windows.Forms.BindingSource invoiceStatusBindingSource1;
        private System.Windows.Forms.Panel panel4;
        private DevExpress.XtraEditors.SpinEdit employeeIdSpinEdit;
        private DevExpress.XtraEditors.SpinEdit userIdSpinEdit;
        private DevExpress.XtraEditors.SpinEdit totalPriceSpinEdit;
        private DevExpress.XtraEditors.TextEdit noteTextEdit;
        private DevExpress.XtraEditors.TextEdit addressTextEdit;
        private DevExpress.XtraEditors.TextEdit phoneTextEdit;
        private DevExpress.XtraEditors.TextEdit nameTextEdit;
        private DevExpress.XtraEditors.DateEdit deliveryDateDateEdit;
        private DevExpress.XtraEditors.DateEdit buyDateDateEdit;
        private DevExpress.XtraEditors.DateEdit updateDateDateEdit;
        private DevExpress.XtraEditors.SpinEdit invoiceIdSpinEdit;
        private System.Windows.Forms.Button btnCancelAddProvider;
        private System.Windows.Forms.Button btnSaveAddProvider;
        private System.Windows.Forms.BindingSource productBindingSource;
        private PhoneShopDataSetTableAdapters.ProductTableAdapter productTableAdapter;
        private DevExpress.XtraBars.BarButtonItem barButtonItem1;
        private DevExpress.XtraBars.BarButtonItem barButtonItem2;
        private System.Windows.Forms.BindingSource invoiceStatusBindingSource2;
        private System.Windows.Forms.Label statusNameLabel1;
        private DevExpress.XtraEditors.SpinEdit statusOderIDSpinEdit;
    }
}