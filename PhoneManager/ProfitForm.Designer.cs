
namespace PhoneManager
{
    partial class ProfitForm
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
            System.Windows.Forms.Label label8;
            System.Windows.Forms.Label label10;
            System.Windows.Forms.Label label7;
            System.Windows.Forms.Label totalInvoiceLabel;
            System.Windows.Forms.Label label2;
            System.Windows.Forms.Label label4;
            System.Windows.Forms.Label label3;
            System.Windows.Forms.Label label1;
            System.Windows.Forms.Label label6;
            System.Windows.Forms.Label label5;
            this.cbbYear = new System.Windows.Forms.ComboBox();
            this.cbbMonth = new System.Windows.Forms.ComboBox();
            this.totalPriceSpinEdit = new DevExpress.XtraEditors.SpinEdit();
            this.sP_ProfitDataMonthYearBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.phoneShopDataSet = new PhoneManager.PhoneShopDataSet();
            this.totalProductSpinEdit = new DevExpress.XtraEditors.SpinEdit();
            this.totalInvoiceSpinEdit = new DevExpress.XtraEditors.SpinEdit();
            this.radMonthYear = new System.Windows.Forms.RadioButton();
            this.rbDate = new System.Windows.Forms.RadioButton();
            this.dateEnd = new DevExpress.XtraEditors.DateEdit();
            this.dateBegin = new DevExpress.XtraEditors.DateEdit();
            this.cbProvider = new System.Windows.Forms.CheckBox();
            this.cbCategory = new System.Windows.Forms.CheckBox();
            this.providerComboBox = new System.Windows.Forms.ComboBox();
            this.providerBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.categoryComboBox = new System.Windows.Forms.ComboBox();
            this.categoryBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.btnExport = new System.Windows.Forms.Button();
            this.bar2 = new DevExpress.XtraBars.Bar();
            this.bar1 = new DevExpress.XtraBars.Bar();
            this.barManager1 = new DevExpress.XtraBars.BarManager(this.components);
            this.bar4 = new DevExpress.XtraBars.Bar();
            this.barButtonItem1 = new DevExpress.XtraBars.BarButtonItem();
            this.barButtonItem2 = new DevExpress.XtraBars.BarButtonItem();
            this.barDockControlTop = new DevExpress.XtraBars.BarDockControl();
            this.barDockControlBottom = new DevExpress.XtraBars.BarDockControl();
            this.barDockControlLeft = new DevExpress.XtraBars.BarDockControl();
            this.barDockControlRight = new DevExpress.XtraBars.BarDockControl();
            this.categoryTableAdapter = new PhoneManager.PhoneShopDataSetTableAdapters.CategoryTableAdapter();
            this.providerTableAdapter = new PhoneManager.PhoneShopDataSetTableAdapters.ProviderTableAdapter();
            this.sP_ProfitDataMonthYearTableAdapter = new PhoneManager.PhoneShopDataSetTableAdapters.SP_ProfitDataMonthYearTableAdapter();
            this.tableAdapterManager = new PhoneManager.PhoneShopDataSetTableAdapters.TableAdapterManager();
            label8 = new System.Windows.Forms.Label();
            label10 = new System.Windows.Forms.Label();
            label7 = new System.Windows.Forms.Label();
            totalInvoiceLabel = new System.Windows.Forms.Label();
            label2 = new System.Windows.Forms.Label();
            label4 = new System.Windows.Forms.Label();
            label3 = new System.Windows.Forms.Label();
            label1 = new System.Windows.Forms.Label();
            label6 = new System.Windows.Forms.Label();
            label5 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.totalPriceSpinEdit.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.sP_ProfitDataMonthYearBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.phoneShopDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.totalProductSpinEdit.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.totalInvoiceSpinEdit.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dateEnd.Properties.CalendarTimeProperties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dateEnd.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dateBegin.Properties.CalendarTimeProperties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dateBegin.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.providerBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.categoryBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.barManager1)).BeginInit();
            this.SuspendLayout();
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            label8.ForeColor = System.Drawing.Color.Navy;
            label8.Location = new System.Drawing.Point(35, 292);
            label8.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            label8.Name = "label8";
            label8.Size = new System.Drawing.Size(92, 24);
            label8.TabIndex = 125;
            label8.Text = "Products";
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            label10.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            label10.Location = new System.Drawing.Point(735, 248);
            label10.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            label10.Name = "label10";
            label10.Size = new System.Drawing.Size(34, 17);
            label10.TabIndex = 122;
            label10.Text = "vnd";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            label7.ForeColor = System.Drawing.Color.Navy;
            label7.Location = new System.Drawing.Point(428, 244);
            label7.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            label7.Name = "label7";
            label7.Size = new System.Drawing.Size(109, 24);
            label7.TabIndex = 121;
            label7.Text = "Total price";
            // 
            // totalInvoiceLabel
            // 
            totalInvoiceLabel.AutoSize = true;
            totalInvoiceLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            totalInvoiceLabel.ForeColor = System.Drawing.Color.Navy;
            totalInvoiceLabel.Location = new System.Drawing.Point(40, 244);
            totalInvoiceLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            totalInvoiceLabel.Name = "totalInvoiceLabel";
            totalInvoiceLabel.Size = new System.Drawing.Size(87, 24);
            totalInvoiceLabel.TabIndex = 120;
            totalInvoiceLabel.Text = "Invoices";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new System.Drawing.Point(416, 84);
            label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            label2.Name = "label2";
            label2.Size = new System.Drawing.Size(51, 13);
            label2.TabIndex = 114;
            label2.Text = "Date end";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new System.Drawing.Point(416, 126);
            label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            label4.Name = "label4";
            label4.Size = new System.Drawing.Size(29, 13);
            label4.TabIndex = 117;
            label4.Text = "Year";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new System.Drawing.Point(127, 126);
            label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            label3.Name = "label3";
            label3.Size = new System.Drawing.Size(37, 13);
            label3.TabIndex = 116;
            label3.Text = "Month";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new System.Drawing.Point(127, 84);
            label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            label1.Name = "label1";
            label1.Size = new System.Drawing.Size(59, 13);
            label1.TabIndex = 115;
            label1.Text = "Date begin";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new System.Drawing.Point(48, 172);
            label6.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            label6.Name = "label6";
            label6.Size = new System.Drawing.Size(52, 13);
            label6.TabIndex = 105;
            label6.Text = "Category";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new System.Drawing.Point(428, 175);
            label5.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            label5.Name = "label5";
            label5.Size = new System.Drawing.Size(47, 13);
            label5.TabIndex = 106;
            label5.Text = "Provider";
            // 
            // cbbYear
            // 
            this.cbbYear.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbbYear.FormattingEnabled = true;
            this.cbbYear.Location = new System.Drawing.Point(494, 126);
            this.cbbYear.Margin = new System.Windows.Forms.Padding(2);
            this.cbbYear.Name = "cbbYear";
            this.cbbYear.Size = new System.Drawing.Size(107, 21);
            this.cbbYear.TabIndex = 131;
            this.cbbYear.SelectedIndexChanged += new System.EventHandler(this.cbbYear_SelectedIndexChanged);
            // 
            // cbbMonth
            // 
            this.cbbMonth.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbbMonth.FormattingEnabled = true;
            this.cbbMonth.Location = new System.Drawing.Point(204, 126);
            this.cbbMonth.Margin = new System.Windows.Forms.Padding(2);
            this.cbbMonth.Name = "cbbMonth";
            this.cbbMonth.Size = new System.Drawing.Size(107, 21);
            this.cbbMonth.TabIndex = 130;
            this.cbbMonth.SelectedIndexChanged += new System.EventHandler(this.cbbMonth_SelectedIndexChanged);
            // 
            // totalPriceSpinEdit
            // 
            this.totalPriceSpinEdit.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.sP_ProfitDataMonthYearBindingSource, "totalPrice", true));
            this.totalPriceSpinEdit.EditValue = new decimal(new int[] {
            0,
            0,
            0,
            0});
            this.totalPriceSpinEdit.Enabled = false;
            this.totalPriceSpinEdit.Location = new System.Drawing.Point(549, 244);
            this.totalPriceSpinEdit.Margin = new System.Windows.Forms.Padding(2);
            this.totalPriceSpinEdit.Name = "totalPriceSpinEdit";
            this.totalPriceSpinEdit.Properties.Appearance.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.totalPriceSpinEdit.Properties.Appearance.Options.UseFont = true;
            this.totalPriceSpinEdit.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.totalPriceSpinEdit.Size = new System.Drawing.Size(170, 24);
            this.totalPriceSpinEdit.TabIndex = 128;
            // 
            // sP_ProfitDataMonthYearBindingSource
            // 
            this.sP_ProfitDataMonthYearBindingSource.DataMember = "SP_ProfitDataMonthYear";
            this.sP_ProfitDataMonthYearBindingSource.DataSource = this.phoneShopDataSet;
            // 
            // phoneShopDataSet
            // 
            this.phoneShopDataSet.DataSetName = "PhoneShopDataSet";
            this.phoneShopDataSet.EnforceConstraints = false;
            this.phoneShopDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // totalProductSpinEdit
            // 
            this.totalProductSpinEdit.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.sP_ProfitDataMonthYearBindingSource, "totalProduct", true));
            this.totalProductSpinEdit.EditValue = new decimal(new int[] {
            0,
            0,
            0,
            0});
            this.totalProductSpinEdit.Enabled = false;
            this.totalProductSpinEdit.Location = new System.Drawing.Point(145, 293);
            this.totalProductSpinEdit.Margin = new System.Windows.Forms.Padding(2);
            this.totalProductSpinEdit.Name = "totalProductSpinEdit";
            this.totalProductSpinEdit.Properties.Appearance.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.totalProductSpinEdit.Properties.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.totalProductSpinEdit.Properties.Appearance.Options.UseFont = true;
            this.totalProductSpinEdit.Properties.Appearance.Options.UseForeColor = true;
            this.totalProductSpinEdit.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.totalProductSpinEdit.Size = new System.Drawing.Size(94, 24);
            this.totalProductSpinEdit.TabIndex = 127;
            // 
            // totalInvoiceSpinEdit
            // 
            this.totalInvoiceSpinEdit.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.sP_ProfitDataMonthYearBindingSource, "totalInvoice", true));
            this.totalInvoiceSpinEdit.EditValue = new decimal(new int[] {
            0,
            0,
            0,
            0});
            this.totalInvoiceSpinEdit.Enabled = false;
            this.totalInvoiceSpinEdit.Location = new System.Drawing.Point(145, 245);
            this.totalInvoiceSpinEdit.Margin = new System.Windows.Forms.Padding(2);
            this.totalInvoiceSpinEdit.Name = "totalInvoiceSpinEdit";
            this.totalInvoiceSpinEdit.Properties.Appearance.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.totalInvoiceSpinEdit.Properties.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.totalInvoiceSpinEdit.Properties.Appearance.Options.UseFont = true;
            this.totalInvoiceSpinEdit.Properties.Appearance.Options.UseForeColor = true;
            this.totalInvoiceSpinEdit.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.totalInvoiceSpinEdit.Size = new System.Drawing.Size(94, 24);
            this.totalInvoiceSpinEdit.TabIndex = 126;
            // 
            // radMonthYear
            // 
            this.radMonthYear.AutoSize = true;
            this.radMonthYear.Location = new System.Drawing.Point(34, 124);
            this.radMonthYear.Margin = new System.Windows.Forms.Padding(2);
            this.radMonthYear.Name = "radMonthYear";
            this.radMonthYear.Size = new System.Drawing.Size(81, 17);
            this.radMonthYear.TabIndex = 119;
            this.radMonthYear.Text = "Month/Year";
            this.radMonthYear.UseVisualStyleBackColor = true;
            // 
            // rbDate
            // 
            this.rbDate.AutoSize = true;
            this.rbDate.Checked = true;
            this.rbDate.Location = new System.Drawing.Point(34, 83);
            this.rbDate.Margin = new System.Windows.Forms.Padding(2);
            this.rbDate.Name = "rbDate";
            this.rbDate.Size = new System.Drawing.Size(48, 17);
            this.rbDate.TabIndex = 118;
            this.rbDate.TabStop = true;
            this.rbDate.Text = "Date";
            this.rbDate.UseVisualStyleBackColor = true;
            this.rbDate.CheckedChanged += new System.EventHandler(this.rbDate_CheckedChanged);
            // 
            // dateEnd
            // 
            this.dateEnd.EditValue = new System.DateTime(2021, 9, 8, 0, 0, 0, 0);
            this.dateEnd.Location = new System.Drawing.Point(494, 82);
            this.dateEnd.Margin = new System.Windows.Forms.Padding(2);
            this.dateEnd.Name = "dateEnd";
            this.dateEnd.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.dateEnd.Properties.CalendarTimeProperties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.dateEnd.Properties.MinValue = new System.DateTime(2020, 9, 1, 0, 0, 0, 0);
            this.dateEnd.Size = new System.Drawing.Size(106, 20);
            this.dateEnd.TabIndex = 112;
            this.dateEnd.EditValueChanged += new System.EventHandler(this.dateEnd_EditValueChanged);
            // 
            // dateBegin
            // 
            this.dateBegin.EditValue = new System.DateTime(2021, 9, 2, 0, 0, 0, 0);
            this.dateBegin.Location = new System.Drawing.Point(204, 82);
            this.dateBegin.Margin = new System.Windows.Forms.Padding(2);
            this.dateBegin.Name = "dateBegin";
            this.dateBegin.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.dateBegin.Properties.CalendarTimeProperties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.dateBegin.Properties.MinValue = new System.DateTime(2020, 9, 1, 0, 0, 0, 0);
            this.dateBegin.Size = new System.Drawing.Size(106, 20);
            this.dateBegin.TabIndex = 113;
            this.dateBegin.EditValueChanged += new System.EventHandler(this.dateBegin_EditValueChanged);
            // 
            // cbProvider
            // 
            this.cbProvider.AutoSize = true;
            this.cbProvider.Location = new System.Drawing.Point(410, 175);
            this.cbProvider.Margin = new System.Windows.Forms.Padding(2);
            this.cbProvider.Name = "cbProvider";
            this.cbProvider.Size = new System.Drawing.Size(15, 14);
            this.cbProvider.TabIndex = 111;
            this.cbProvider.UseVisualStyleBackColor = true;
            this.cbProvider.CheckedChanged += new System.EventHandler(this.cbProvider_CheckedChanged);
            // 
            // cbCategory
            // 
            this.cbCategory.AutoSize = true;
            this.cbCategory.Location = new System.Drawing.Point(30, 173);
            this.cbCategory.Margin = new System.Windows.Forms.Padding(2);
            this.cbCategory.Name = "cbCategory";
            this.cbCategory.Size = new System.Drawing.Size(15, 14);
            this.cbCategory.TabIndex = 110;
            this.cbCategory.UseVisualStyleBackColor = true;
            this.cbCategory.CheckedChanged += new System.EventHandler(this.cbCategory_CheckedChanged);
            // 
            // providerComboBox
            // 
            this.providerComboBox.DataSource = this.providerBindingSource;
            this.providerComboBox.DisplayMember = "branchName";
            this.providerComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.providerComboBox.Location = new System.Drawing.Point(494, 173);
            this.providerComboBox.Margin = new System.Windows.Forms.Padding(2);
            this.providerComboBox.Name = "providerComboBox";
            this.providerComboBox.Size = new System.Drawing.Size(226, 21);
            this.providerComboBox.TabIndex = 109;
            this.providerComboBox.ValueMember = "providerId";
            this.providerComboBox.SelectedIndexChanged += new System.EventHandler(this.providerComboBox_SelectedIndexChanged);
            // 
            // providerBindingSource
            // 
            this.providerBindingSource.DataMember = "Provider";
            this.providerBindingSource.DataSource = this.phoneShopDataSet;
            // 
            // categoryComboBox
            // 
            this.categoryComboBox.DataSource = this.categoryBindingSource;
            this.categoryComboBox.DisplayMember = "name";
            this.categoryComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.categoryComboBox.Location = new System.Drawing.Point(113, 172);
            this.categoryComboBox.Margin = new System.Windows.Forms.Padding(2);
            this.categoryComboBox.Name = "categoryComboBox";
            this.categoryComboBox.Size = new System.Drawing.Size(226, 21);
            this.categoryComboBox.TabIndex = 108;
            this.categoryComboBox.ValueMember = "categoryId";
            this.categoryComboBox.SelectedIndexChanged += new System.EventHandler(this.categoryComboBox_SelectedIndexChanged);
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
            this.btnExport.Location = new System.Drawing.Point(723, 83);
            this.btnExport.Margin = new System.Windows.Forms.Padding(2);
            this.btnExport.Name = "btnExport";
            this.btnExport.Size = new System.Drawing.Size(142, 42);
            this.btnExport.TabIndex = 107;
            this.btnExport.Text = "Export";
            this.btnExport.UseVisualStyleBackColor = false;
            this.btnExport.Click += new System.EventHandler(this.btnExport_Click);
            // 
            // bar2
            // 
            this.bar2.BarName = "Main menu";
            this.bar2.DockCol = 0;
            this.bar2.DockRow = 0;
            this.bar2.DockStyle = DevExpress.XtraBars.BarDockStyle.Top;
            this.bar2.OptionsBar.MultiLine = true;
            this.bar2.OptionsBar.UseWholeRow = true;
            this.bar2.Text = "Main menu";
            // 
            // bar1
            // 
            this.bar1.BarName = "Main menu";
            this.bar1.DockCol = 0;
            this.bar1.DockRow = 0;
            this.bar1.DockStyle = DevExpress.XtraBars.BarDockStyle.Top;
            this.bar1.OptionsBar.MultiLine = true;
            this.bar1.OptionsBar.UseWholeRow = true;
            this.bar1.Text = "Main menu";
            // 
            // barManager1
            // 
            this.barManager1.Bars.AddRange(new DevExpress.XtraBars.Bar[] {
            this.bar4});
            this.barManager1.DockControls.Add(this.barDockControlTop);
            this.barManager1.DockControls.Add(this.barDockControlBottom);
            this.barManager1.DockControls.Add(this.barDockControlLeft);
            this.barManager1.DockControls.Add(this.barDockControlRight);
            this.barManager1.Form = this;
            this.barManager1.Items.AddRange(new DevExpress.XtraBars.BarItem[] {
            this.barButtonItem1,
            this.barButtonItem2});
            this.barManager1.MainMenu = this.bar4;
            this.barManager1.MaxItemId = 2;
            // 
            // bar4
            // 
            this.bar4.BarName = "Main menu";
            this.bar4.DockCol = 0;
            this.bar4.DockRow = 0;
            this.bar4.DockStyle = DevExpress.XtraBars.BarDockStyle.Top;
            this.bar4.LinksPersistInfo.AddRange(new DevExpress.XtraBars.LinkPersistInfo[] {
            new DevExpress.XtraBars.LinkPersistInfo(this.barButtonItem1),
            new DevExpress.XtraBars.LinkPersistInfo(this.barButtonItem2)});
            this.bar4.OptionsBar.MultiLine = true;
            this.bar4.OptionsBar.UseWholeRow = true;
            this.bar4.Text = "Main menu";
            // 
            // barButtonItem1
            // 
            this.barButtonItem1.Caption = "Reload";
            this.barButtonItem1.Id = 0;
            this.barButtonItem1.ImageOptions.Image = global::PhoneManager.Properties.Resources.exchange;
            this.barButtonItem1.Name = "barButtonItem1";
            this.barButtonItem1.PaintStyle = DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph;
            this.barButtonItem1.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnReloadProvider_ItemClick);
            // 
            // barButtonItem2
            // 
            this.barButtonItem2.Caption = "Close";
            this.barButtonItem2.Id = 1;
            this.barButtonItem2.ImageOptions.Image = global::PhoneManager.Properties.Resources.close;
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
            this.barDockControlTop.Size = new System.Drawing.Size(941, 27);
            // 
            // barDockControlBottom
            // 
            this.barDockControlBottom.CausesValidation = false;
            this.barDockControlBottom.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.barDockControlBottom.Location = new System.Drawing.Point(0, 374);
            this.barDockControlBottom.Manager = this.barManager1;
            this.barDockControlBottom.Size = new System.Drawing.Size(941, 0);
            // 
            // barDockControlLeft
            // 
            this.barDockControlLeft.CausesValidation = false;
            this.barDockControlLeft.Dock = System.Windows.Forms.DockStyle.Left;
            this.barDockControlLeft.Location = new System.Drawing.Point(0, 27);
            this.barDockControlLeft.Manager = this.barManager1;
            this.barDockControlLeft.Size = new System.Drawing.Size(0, 347);
            // 
            // barDockControlRight
            // 
            this.barDockControlRight.CausesValidation = false;
            this.barDockControlRight.Dock = System.Windows.Forms.DockStyle.Right;
            this.barDockControlRight.Location = new System.Drawing.Point(941, 27);
            this.barDockControlRight.Manager = this.barManager1;
            this.barDockControlRight.Size = new System.Drawing.Size(0, 347);
            // 
            // categoryTableAdapter
            // 
            this.categoryTableAdapter.ClearBeforeFill = true;
            // 
            // providerTableAdapter
            // 
            this.providerTableAdapter.ClearBeforeFill = true;
            // 
            // sP_ProfitDataMonthYearTableAdapter
            // 
            this.sP_ProfitDataMonthYearTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.AccountTableAdapter = null;
            this.tableAdapterManager.AddressTableAdapter = null;
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.CategoryTableAdapter = this.categoryTableAdapter;
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
            this.tableAdapterManager.ProviderTableAdapter = this.providerTableAdapter;
            this.tableAdapterManager.RoleTableAdapter = null;
            this.tableAdapterManager.ShopInfoTableAdapter = null;
            this.tableAdapterManager.SlideTableAdapter = null;
            this.tableAdapterManager.UpdateOrder = PhoneManager.PhoneShopDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // ProfitForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(941, 374);
            this.Controls.Add(this.cbbYear);
            this.Controls.Add(this.cbbMonth);
            this.Controls.Add(this.totalPriceSpinEdit);
            this.Controls.Add(this.totalProductSpinEdit);
            this.Controls.Add(this.totalInvoiceSpinEdit);
            this.Controls.Add(label8);
            this.Controls.Add(label10);
            this.Controls.Add(label7);
            this.Controls.Add(totalInvoiceLabel);
            this.Controls.Add(this.radMonthYear);
            this.Controls.Add(this.rbDate);
            this.Controls.Add(label2);
            this.Controls.Add(label4);
            this.Controls.Add(label3);
            this.Controls.Add(label1);
            this.Controls.Add(this.dateEnd);
            this.Controls.Add(this.dateBegin);
            this.Controls.Add(this.cbProvider);
            this.Controls.Add(this.cbCategory);
            this.Controls.Add(this.providerComboBox);
            this.Controls.Add(this.categoryComboBox);
            this.Controls.Add(this.btnExport);
            this.Controls.Add(label6);
            this.Controls.Add(label5);
            this.Controls.Add(this.barDockControlLeft);
            this.Controls.Add(this.barDockControlRight);
            this.Controls.Add(this.barDockControlBottom);
            this.Controls.Add(this.barDockControlTop);
            this.Name = "ProfitForm";
            this.Text = "ProfitForm";
            this.Load += new System.EventHandler(this.ProfitForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.totalPriceSpinEdit.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.sP_ProfitDataMonthYearBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.phoneShopDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.totalProductSpinEdit.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.totalInvoiceSpinEdit.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dateEnd.Properties.CalendarTimeProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dateEnd.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dateBegin.Properties.CalendarTimeProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dateBegin.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.providerBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.categoryBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.barManager1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox cbbYear;
        private System.Windows.Forms.ComboBox cbbMonth;
        private DevExpress.XtraEditors.SpinEdit totalPriceSpinEdit;
        private DevExpress.XtraEditors.SpinEdit totalProductSpinEdit;
        private DevExpress.XtraEditors.SpinEdit totalInvoiceSpinEdit;
        private System.Windows.Forms.RadioButton radMonthYear;
        private System.Windows.Forms.RadioButton rbDate;
        private DevExpress.XtraEditors.DateEdit dateEnd;
        private DevExpress.XtraEditors.DateEdit dateBegin;
        private System.Windows.Forms.CheckBox cbProvider;
        private System.Windows.Forms.CheckBox cbCategory;
        private System.Windows.Forms.ComboBox providerComboBox;
        private System.Windows.Forms.ComboBox categoryComboBox;
        private System.Windows.Forms.Button btnExport;
        private DevExpress.XtraBars.Bar bar2;
        private DevExpress.XtraBars.Bar bar1;
        private DevExpress.XtraBars.BarManager barManager1;
        private DevExpress.XtraBars.Bar bar4;
        private DevExpress.XtraBars.BarButtonItem barButtonItem1;
        private DevExpress.XtraBars.BarButtonItem barButtonItem2;
        private DevExpress.XtraBars.BarDockControl barDockControlTop;
        private DevExpress.XtraBars.BarDockControl barDockControlBottom;
        private DevExpress.XtraBars.BarDockControl barDockControlLeft;
        private DevExpress.XtraBars.BarDockControl barDockControlRight;
        private PhoneShopDataSet phoneShopDataSet;
        private System.Windows.Forms.BindingSource categoryBindingSource;
        private PhoneShopDataSetTableAdapters.CategoryTableAdapter categoryTableAdapter;
        private System.Windows.Forms.BindingSource providerBindingSource;
        private PhoneShopDataSetTableAdapters.ProviderTableAdapter providerTableAdapter;
        private System.Windows.Forms.BindingSource sP_ProfitDataMonthYearBindingSource;
        private PhoneShopDataSetTableAdapters.SP_ProfitDataMonthYearTableAdapter sP_ProfitDataMonthYearTableAdapter;
        private PhoneShopDataSetTableAdapters.TableAdapterManager tableAdapterManager;
    }
}