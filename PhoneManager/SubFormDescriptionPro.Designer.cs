
namespace PhoneManager
{
    partial class SubFormDescriptionPro
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
            System.Windows.Forms.Label idLabel;
            System.Windows.Forms.Label imageUrlLabel;
            System.Windows.Forms.Label des1Label;
            System.Windows.Forms.Label des2Label;
            this.btnSaveImg = new System.Windows.Forms.Button();
            this.btnChangeImg = new System.Windows.Forms.LinkLabel();
            this.idTextBox = new System.Windows.Forms.TextBox();
            this.picImage = new System.Windows.Forms.PictureBox();
            this.phoneShopDataSet = new PhoneManager.PhoneShopDataSet();
            this.descriptionBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.descriptionTableAdapter = new PhoneManager.PhoneShopDataSetTableAdapters.DescriptionTableAdapter();
            this.tableAdapterManager = new PhoneManager.PhoneShopDataSetTableAdapters.TableAdapterManager();
            this.imageUrlTextEdit = new DevExpress.XtraEditors.TextEdit();
            this.des1RichTextBox = new System.Windows.Forms.RichTextBox();
            this.des2RichTextBox = new System.Windows.Forms.RichTextBox();
            this.button1 = new System.Windows.Forms.Button();
            idLabel = new System.Windows.Forms.Label();
            imageUrlLabel = new System.Windows.Forms.Label();
            des1Label = new System.Windows.Forms.Label();
            des2Label = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.picImage)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.phoneShopDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.descriptionBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.imageUrlTextEdit.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // btnSaveImg
            // 
            this.btnSaveImg.BackColor = System.Drawing.Color.White;
            this.btnSaveImg.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSaveImg.ForeColor = System.Drawing.Color.DarkBlue;
            this.btnSaveImg.Location = new System.Drawing.Point(578, 330);
            this.btnSaveImg.Margin = new System.Windows.Forms.Padding(2);
            this.btnSaveImg.Name = "btnSaveImg";
            this.btnSaveImg.Size = new System.Drawing.Size(110, 42);
            this.btnSaveImg.TabIndex = 69;
            this.btnSaveImg.Text = "Save and get link";
            this.btnSaveImg.UseVisualStyleBackColor = false;
            this.btnSaveImg.Click += new System.EventHandler(this.btnSaveImg_Click);
            // 
            // btnChangeImg
            // 
            this.btnChangeImg.AutoSize = true;
            this.btnChangeImg.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnChangeImg.LinkColor = System.Drawing.SystemColors.MenuHighlight;
            this.btnChangeImg.Location = new System.Drawing.Point(396, 330);
            this.btnChangeImg.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.btnChangeImg.Name = "btnChangeImg";
            this.btnChangeImg.Size = new System.Drawing.Size(123, 20);
            this.btnChangeImg.TabIndex = 68;
            this.btnChangeImg.TabStop = true;
            this.btnChangeImg.Text = "Choose image";
            this.btnChangeImg.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.btnChangeImg_LinkClicked);
            // 
            // idLabel
            // 
            idLabel.AutoSize = true;
            idLabel.Location = new System.Drawing.Point(27, 71);
            idLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            idLabel.Name = "idLabel";
            idLabel.Size = new System.Drawing.Size(18, 13);
            idLabel.TabIndex = 66;
            idLabel.Text = "ID";
            // 
            // idTextBox
            // 
            this.idTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.descriptionBindingSource, "productId", true));
            this.idTextBox.Enabled = false;
            this.idTextBox.Location = new System.Drawing.Point(68, 68);
            this.idTextBox.Margin = new System.Windows.Forms.Padding(2);
            this.idTextBox.Name = "idTextBox";
            this.idTextBox.Size = new System.Drawing.Size(76, 21);
            this.idTextBox.TabIndex = 67;
            // 
            // picImage
            // 
            this.picImage.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.picImage.Location = new System.Drawing.Point(400, 27);
            this.picImage.Margin = new System.Windows.Forms.Padding(2);
            this.picImage.Name = "picImage";
            this.picImage.Size = new System.Drawing.Size(299, 263);
            this.picImage.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picImage.TabIndex = 65;
            this.picImage.TabStop = false;
            // 
            // phoneShopDataSet
            // 
            this.phoneShopDataSet.DataSetName = "PhoneShopDataSet";
            this.phoneShopDataSet.EnforceConstraints = false;
            this.phoneShopDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // descriptionBindingSource
            // 
            this.descriptionBindingSource.DataMember = "Description";
            this.descriptionBindingSource.DataSource = this.phoneShopDataSet;
            // 
            // descriptionTableAdapter
            // 
            this.descriptionTableAdapter.ClearBeforeFill = true;
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
            this.tableAdapterManager.ProductTableAdapter = null;
            this.tableAdapterManager.ProviderTableAdapter = null;
            this.tableAdapterManager.RoleTableAdapter = null;
            this.tableAdapterManager.ShopInfoTableAdapter = null;
            this.tableAdapterManager.SlideTableAdapter = null;
            this.tableAdapterManager.UpdateOrder = PhoneManager.PhoneShopDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // imageUrlLabel
            // 
            imageUrlLabel.AutoSize = true;
            imageUrlLabel.Location = new System.Drawing.Point(410, 391);
            imageUrlLabel.Name = "imageUrlLabel";
            imageUrlLabel.Size = new System.Drawing.Size(55, 13);
            imageUrlLabel.TabIndex = 70;
            imageUrlLabel.Text = "image Url:";
            // 
            // imageUrlTextEdit
            // 
            this.imageUrlTextEdit.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.descriptionBindingSource, "imageUrl", true));
            this.imageUrlTextEdit.Enabled = false;
            this.imageUrlTextEdit.Location = new System.Drawing.Point(486, 388);
            this.imageUrlTextEdit.Name = "imageUrlTextEdit";
            this.imageUrlTextEdit.Size = new System.Drawing.Size(202, 20);
            this.imageUrlTextEdit.TabIndex = 71;
            // 
            // des1Label
            // 
            des1Label.AutoSize = true;
            des1Label.Location = new System.Drawing.Point(11, 115);
            des1Label.Name = "des1Label";
            des1Label.Size = new System.Drawing.Size(34, 13);
            des1Label.TabIndex = 71;
            des1Label.Text = "des1:";
            // 
            // des1RichTextBox
            // 
            this.des1RichTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.descriptionBindingSource, "des1", true));
            this.des1RichTextBox.Location = new System.Drawing.Point(68, 112);
            this.des1RichTextBox.Name = "des1RichTextBox";
            this.des1RichTextBox.Size = new System.Drawing.Size(288, 96);
            this.des1RichTextBox.TabIndex = 72;
            this.des1RichTextBox.Text = "";
            // 
            // des2Label
            // 
            des2Label.AutoSize = true;
            des2Label.Location = new System.Drawing.Point(11, 229);
            des2Label.Name = "des2Label";
            des2Label.Size = new System.Drawing.Size(34, 13);
            des2Label.TabIndex = 72;
            des2Label.Text = "des2:";
            // 
            // des2RichTextBox
            // 
            this.des2RichTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.descriptionBindingSource, "des2", true));
            this.des2RichTextBox.Location = new System.Drawing.Point(68, 231);
            this.des2RichTextBox.Name = "des2RichTextBox";
            this.des2RichTextBox.Size = new System.Drawing.Size(288, 96);
            this.des2RichTextBox.TabIndex = 73;
            this.des2RichTextBox.Text = "";
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.Turquoise;
            this.button1.Location = new System.Drawing.Point(157, 367);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(114, 41);
            this.button1.TabIndex = 74;
            this.button1.Text = "OK";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.buttonOK_Click);
            // 
            // SubFormDescriptionPro
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(714, 441);
            this.Controls.Add(this.button1);
            this.Controls.Add(des2Label);
            this.Controls.Add(this.des2RichTextBox);
            this.Controls.Add(des1Label);
            this.Controls.Add(this.des1RichTextBox);
            this.Controls.Add(imageUrlLabel);
            this.Controls.Add(this.imageUrlTextEdit);
            this.Controls.Add(this.btnSaveImg);
            this.Controls.Add(this.btnChangeImg);
            this.Controls.Add(idLabel);
            this.Controls.Add(this.idTextBox);
            this.Controls.Add(this.picImage);
            this.Name = "SubFormDescriptionPro";
            this.Text = "SubFormDescriptionPro";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.SubFormPhieuNhap_FormClosing);
            this.Load += new System.EventHandler(this.SubFormDescriptionPro_Load);
            this.Shown += new System.EventHandler(this.SubFormDetailPro_Shown);
            ((System.ComponentModel.ISupportInitialize)(this.picImage)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.phoneShopDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.descriptionBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.imageUrlTextEdit.Properties)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnSaveImg;
        private System.Windows.Forms.LinkLabel btnChangeImg;
        private System.Windows.Forms.TextBox idTextBox;
        private System.Windows.Forms.PictureBox picImage;
        private PhoneShopDataSet phoneShopDataSet;
        private System.Windows.Forms.BindingSource descriptionBindingSource;
        private PhoneShopDataSetTableAdapters.DescriptionTableAdapter descriptionTableAdapter;
        private PhoneShopDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private DevExpress.XtraEditors.TextEdit imageUrlTextEdit;
        private System.Windows.Forms.RichTextBox des1RichTextBox;
        private System.Windows.Forms.RichTextBox des2RichTextBox;
        private System.Windows.Forms.Button button1;
    }
}