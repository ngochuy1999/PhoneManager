
namespace PhoneManager
{
    partial class SubFormDetailPro
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
            System.Windows.Forms.Label productIdLabel;
            System.Windows.Forms.Label displayLabel;
            System.Windows.Forms.Label pixelLabel;
            System.Windows.Forms.Label inchLabel;
            System.Windows.Forms.Label cpuLabel;
            System.Windows.Forms.Label oSLabel;
            System.Windows.Forms.Label rAMLabel;
            System.Windows.Forms.Label rOMLabel;
            System.Windows.Forms.Label batteryLabel;
            this.phoneShopDataSet = new PhoneManager.PhoneShopDataSet();
            this.detailBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.detailTableAdapter = new PhoneManager.PhoneShopDataSetTableAdapters.DetailTableAdapter();
            this.tableAdapterManager = new PhoneManager.PhoneShopDataSetTableAdapters.TableAdapterManager();
            this.productIdSpinEdit = new DevExpress.XtraEditors.SpinEdit();
            this.displayTextEdit = new DevExpress.XtraEditors.TextEdit();
            this.pixelTextEdit = new DevExpress.XtraEditors.TextEdit();
            this.inchTextEdit = new DevExpress.XtraEditors.TextEdit();
            this.cpuTextEdit = new DevExpress.XtraEditors.TextEdit();
            this.oSTextEdit = new DevExpress.XtraEditors.TextEdit();
            this.rAMTextEdit = new DevExpress.XtraEditors.TextEdit();
            this.rOMTextEdit = new DevExpress.XtraEditors.TextEdit();
            this.batteryTextEdit = new DevExpress.XtraEditors.TextEdit();
            this.button1 = new System.Windows.Forms.Button();
            productIdLabel = new System.Windows.Forms.Label();
            displayLabel = new System.Windows.Forms.Label();
            pixelLabel = new System.Windows.Forms.Label();
            inchLabel = new System.Windows.Forms.Label();
            cpuLabel = new System.Windows.Forms.Label();
            oSLabel = new System.Windows.Forms.Label();
            rAMLabel = new System.Windows.Forms.Label();
            rOMLabel = new System.Windows.Forms.Label();
            batteryLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.phoneShopDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.detailBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.productIdSpinEdit.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.displayTextEdit.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pixelTextEdit.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.inchTextEdit.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cpuTextEdit.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.oSTextEdit.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.rAMTextEdit.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.rOMTextEdit.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.batteryTextEdit.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // productIdLabel
            // 
            productIdLabel.AutoSize = true;
            productIdLabel.Location = new System.Drawing.Point(60, 49);
            productIdLabel.Name = "productIdLabel";
            productIdLabel.Size = new System.Drawing.Size(61, 13);
            productIdLabel.TabIndex = 1;
            productIdLabel.Text = "product Id:";
            // 
            // displayLabel
            // 
            displayLabel.AutoSize = true;
            displayLabel.Location = new System.Drawing.Point(77, 92);
            displayLabel.Name = "displayLabel";
            displayLabel.Size = new System.Drawing.Size(44, 13);
            displayLabel.TabIndex = 3;
            displayLabel.Text = "display:";
            // 
            // pixelLabel
            // 
            pixelLabel.AutoSize = true;
            pixelLabel.Location = new System.Drawing.Point(88, 141);
            pixelLabel.Name = "pixelLabel";
            pixelLabel.Size = new System.Drawing.Size(33, 13);
            pixelLabel.TabIndex = 5;
            pixelLabel.Text = "pixel:";
            // 
            // inchLabel
            // 
            inchLabel.AutoSize = true;
            inchLabel.Location = new System.Drawing.Point(89, 185);
            inchLabel.Name = "inchLabel";
            inchLabel.Size = new System.Drawing.Size(32, 13);
            inchLabel.TabIndex = 7;
            inchLabel.Text = "Inch:";
            // 
            // cpuLabel
            // 
            cpuLabel.AutoSize = true;
            cpuLabel.Location = new System.Drawing.Point(93, 229);
            cpuLabel.Name = "cpuLabel";
            cpuLabel.Size = new System.Drawing.Size(28, 13);
            cpuLabel.TabIndex = 9;
            cpuLabel.Text = "cpu:";
            // 
            // oSLabel
            // 
            oSLabel.AutoSize = true;
            oSLabel.Location = new System.Drawing.Point(385, 92);
            oSLabel.Name = "oSLabel";
            oSLabel.Size = new System.Drawing.Size(25, 13);
            oSLabel.TabIndex = 11;
            oSLabel.Text = "OS:";
            // 
            // rAMLabel
            // 
            rAMLabel.AutoSize = true;
            rAMLabel.Location = new System.Drawing.Point(377, 136);
            rAMLabel.Name = "rAMLabel";
            rAMLabel.Size = new System.Drawing.Size(33, 13);
            rAMLabel.TabIndex = 13;
            rAMLabel.Text = "RAM:";
            // 
            // rOMLabel
            // 
            rOMLabel.AutoSize = true;
            rOMLabel.Location = new System.Drawing.Point(376, 183);
            rOMLabel.Name = "rOMLabel";
            rOMLabel.Size = new System.Drawing.Size(34, 13);
            rOMLabel.TabIndex = 15;
            rOMLabel.Text = "ROM:";
            // 
            // batteryLabel
            // 
            batteryLabel.AutoSize = true;
            batteryLabel.Location = new System.Drawing.Point(363, 229);
            batteryLabel.Name = "batteryLabel";
            batteryLabel.Size = new System.Drawing.Size(47, 13);
            batteryLabel.TabIndex = 17;
            batteryLabel.Text = "battery:";
            // 
            // phoneShopDataSet
            // 
            this.phoneShopDataSet.DataSetName = "PhoneShopDataSet";
            this.phoneShopDataSet.EnforceConstraints = false;
            this.phoneShopDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // detailBindingSource
            // 
            this.detailBindingSource.DataMember = "Detail";
            this.detailBindingSource.DataSource = this.phoneShopDataSet;
            // 
            // detailTableAdapter
            // 
            this.detailTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.AccountTableAdapter = null;
            this.tableAdapterManager.AddressTableAdapter = null;
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.CategoryTableAdapter = null;
            this.tableAdapterManager.CustomerTableAdapter = null;
            this.tableAdapterManager.DescriptionTableAdapter = null;
            this.tableAdapterManager.DetailTableAdapter = this.detailTableAdapter;
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
            // productIdSpinEdit
            // 
            this.productIdSpinEdit.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.detailBindingSource, "productId", true));
            this.productIdSpinEdit.EditValue = new decimal(new int[] {
            0,
            0,
            0,
            0});
            this.productIdSpinEdit.Enabled = false;
            this.productIdSpinEdit.Location = new System.Drawing.Point(140, 46);
            this.productIdSpinEdit.Name = "productIdSpinEdit";
            this.productIdSpinEdit.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.productIdSpinEdit.Size = new System.Drawing.Size(100, 20);
            this.productIdSpinEdit.TabIndex = 2;
            // 
            // displayTextEdit
            // 
            this.displayTextEdit.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.detailBindingSource, "display", true));
            this.displayTextEdit.Location = new System.Drawing.Point(140, 88);
            this.displayTextEdit.Name = "displayTextEdit";
            this.displayTextEdit.Size = new System.Drawing.Size(121, 20);
            this.displayTextEdit.TabIndex = 4;
            // 
            // pixelTextEdit
            // 
            this.pixelTextEdit.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.detailBindingSource, "pixel", true));
            this.pixelTextEdit.Location = new System.Drawing.Point(140, 138);
            this.pixelTextEdit.Name = "pixelTextEdit";
            this.pixelTextEdit.Size = new System.Drawing.Size(121, 20);
            this.pixelTextEdit.TabIndex = 6;
            // 
            // inchTextEdit
            // 
            this.inchTextEdit.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.detailBindingSource, "Inch", true));
            this.inchTextEdit.Location = new System.Drawing.Point(140, 182);
            this.inchTextEdit.Name = "inchTextEdit";
            this.inchTextEdit.Size = new System.Drawing.Size(121, 20);
            this.inchTextEdit.TabIndex = 8;
            // 
            // cpuTextEdit
            // 
            this.cpuTextEdit.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.detailBindingSource, "cpu", true));
            this.cpuTextEdit.Location = new System.Drawing.Point(140, 225);
            this.cpuTextEdit.Name = "cpuTextEdit";
            this.cpuTextEdit.Size = new System.Drawing.Size(121, 20);
            this.cpuTextEdit.TabIndex = 10;
            // 
            // oSTextEdit
            // 
            this.oSTextEdit.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.detailBindingSource, "OS", true));
            this.oSTextEdit.Location = new System.Drawing.Point(416, 88);
            this.oSTextEdit.Name = "oSTextEdit";
            this.oSTextEdit.Size = new System.Drawing.Size(111, 20);
            this.oSTextEdit.TabIndex = 12;
            // 
            // rAMTextEdit
            // 
            this.rAMTextEdit.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.detailBindingSource, "RAM", true));
            this.rAMTextEdit.Location = new System.Drawing.Point(416, 133);
            this.rAMTextEdit.Name = "rAMTextEdit";
            this.rAMTextEdit.Size = new System.Drawing.Size(111, 20);
            this.rAMTextEdit.TabIndex = 14;
            // 
            // rOMTextEdit
            // 
            this.rOMTextEdit.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.detailBindingSource, "ROM", true));
            this.rOMTextEdit.Location = new System.Drawing.Point(416, 180);
            this.rOMTextEdit.Name = "rOMTextEdit";
            this.rOMTextEdit.Size = new System.Drawing.Size(111, 20);
            this.rOMTextEdit.TabIndex = 16;
            // 
            // batteryTextEdit
            // 
            this.batteryTextEdit.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.detailBindingSource, "battery", true));
            this.batteryTextEdit.Location = new System.Drawing.Point(416, 225);
            this.batteryTextEdit.Name = "batteryTextEdit";
            this.batteryTextEdit.Size = new System.Drawing.Size(111, 20);
            this.batteryTextEdit.TabIndex = 18;
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.Turquoise;
            this.button1.Location = new System.Drawing.Point(270, 277);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 19;
            this.button1.Text = "OK";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.buttonOK_Click);
            // 
            // SubFormDetailPro
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(610, 330);
            this.Controls.Add(this.button1);
            this.Controls.Add(batteryLabel);
            this.Controls.Add(this.batteryTextEdit);
            this.Controls.Add(rOMLabel);
            this.Controls.Add(this.rOMTextEdit);
            this.Controls.Add(rAMLabel);
            this.Controls.Add(this.rAMTextEdit);
            this.Controls.Add(oSLabel);
            this.Controls.Add(this.oSTextEdit);
            this.Controls.Add(cpuLabel);
            this.Controls.Add(this.cpuTextEdit);
            this.Controls.Add(inchLabel);
            this.Controls.Add(this.inchTextEdit);
            this.Controls.Add(pixelLabel);
            this.Controls.Add(this.pixelTextEdit);
            this.Controls.Add(displayLabel);
            this.Controls.Add(this.displayTextEdit);
            this.Controls.Add(productIdLabel);
            this.Controls.Add(this.productIdSpinEdit);
            this.Name = "SubFormDetailPro";
            this.Text = "SubFormDetailPro";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.SubFormPhieuNhap_FormClosing);
            this.Load += new System.EventHandler(this.SubFormDetailPro_Load);
            this.Shown += new System.EventHandler(this.SubFormDetailPro_Shown);
            ((System.ComponentModel.ISupportInitialize)(this.phoneShopDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.detailBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.productIdSpinEdit.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.displayTextEdit.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pixelTextEdit.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.inchTextEdit.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cpuTextEdit.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.oSTextEdit.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.rAMTextEdit.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.rOMTextEdit.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.batteryTextEdit.Properties)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private PhoneShopDataSet phoneShopDataSet;
        private System.Windows.Forms.BindingSource detailBindingSource;
        private PhoneShopDataSetTableAdapters.DetailTableAdapter detailTableAdapter;
        private PhoneShopDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private DevExpress.XtraEditors.SpinEdit productIdSpinEdit;
        private DevExpress.XtraEditors.TextEdit displayTextEdit;
        private DevExpress.XtraEditors.TextEdit pixelTextEdit;
        private DevExpress.XtraEditors.TextEdit inchTextEdit;
        private DevExpress.XtraEditors.TextEdit cpuTextEdit;
        private DevExpress.XtraEditors.TextEdit oSTextEdit;
        private DevExpress.XtraEditors.TextEdit rAMTextEdit;
        private DevExpress.XtraEditors.TextEdit rOMTextEdit;
        private DevExpress.XtraEditors.TextEdit batteryTextEdit;
        private System.Windows.Forms.Button button1;
    }
}