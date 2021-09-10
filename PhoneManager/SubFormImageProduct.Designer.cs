
namespace PhoneManager
{
    partial class SubFormImageProduct
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
            System.Windows.Forms.Label imageUrl1Label;
            System.Windows.Forms.Label imageUrl2Label;
            System.Windows.Forms.Label imageUrl3Label;
            System.Windows.Forms.Label imageUrl4Label;
            System.Windows.Forms.Label imageUrl5Label;
            this.btnSaveImg = new System.Windows.Forms.Button();
            this.btnChangeImg = new System.Windows.Forms.LinkLabel();
            this.picImage = new System.Windows.Forms.PictureBox();
            this.button1 = new System.Windows.Forms.Button();
            this.linkLabel1 = new System.Windows.Forms.LinkLabel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.button2 = new System.Windows.Forms.Button();
            this.linkLabel2 = new System.Windows.Forms.LinkLabel();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.button3 = new System.Windows.Forms.Button();
            this.linkLabel3 = new System.Windows.Forms.LinkLabel();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.button4 = new System.Windows.Forms.Button();
            this.linkLabel4 = new System.Windows.Forms.LinkLabel();
            this.pictureBox4 = new System.Windows.Forms.PictureBox();
            this.phoneShopDataSet = new PhoneManager.PhoneShopDataSet();
            this.imageProductBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.imageProductTableAdapter = new PhoneManager.PhoneShopDataSetTableAdapters.ImageProductTableAdapter();
            this.tableAdapterManager = new PhoneManager.PhoneShopDataSetTableAdapters.TableAdapterManager();
            this.productIdSpinEdit = new DevExpress.XtraEditors.SpinEdit();
            this.imageUrl1TextEdit = new DevExpress.XtraEditors.TextEdit();
            this.imageUrl2TextEdit = new DevExpress.XtraEditors.TextEdit();
            this.imageUrl3TextEdit = new DevExpress.XtraEditors.TextEdit();
            this.imageUrl4TextEdit = new DevExpress.XtraEditors.TextEdit();
            this.imageUrl5TextEdit = new DevExpress.XtraEditors.TextEdit();
            this.button5 = new System.Windows.Forms.Button();
            productIdLabel = new System.Windows.Forms.Label();
            imageUrl1Label = new System.Windows.Forms.Label();
            imageUrl2Label = new System.Windows.Forms.Label();
            imageUrl3Label = new System.Windows.Forms.Label();
            imageUrl4Label = new System.Windows.Forms.Label();
            imageUrl5Label = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.picImage)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.phoneShopDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.imageProductBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.productIdSpinEdit.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.imageUrl1TextEdit.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.imageUrl2TextEdit.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.imageUrl3TextEdit.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.imageUrl4TextEdit.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.imageUrl5TextEdit.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // productIdLabel
            // 
            productIdLabel.AutoSize = true;
            productIdLabel.Location = new System.Drawing.Point(658, 451);
            productIdLabel.Name = "productIdLabel";
            productIdLabel.Size = new System.Drawing.Size(61, 13);
            productIdLabel.TabIndex = 80;
            productIdLabel.Text = "product Id:";
            // 
            // imageUrl1Label
            // 
            imageUrl1Label.AutoSize = true;
            imageUrl1Label.Location = new System.Drawing.Point(22, 313);
            imageUrl1Label.Name = "imageUrl1Label";
            imageUrl1Label.Size = new System.Drawing.Size(61, 13);
            imageUrl1Label.TabIndex = 81;
            imageUrl1Label.Text = "image Url1:";
            // 
            // imageUrl2Label
            // 
            imageUrl2Label.AutoSize = true;
            imageUrl2Label.Location = new System.Drawing.Point(321, 313);
            imageUrl2Label.Name = "imageUrl2Label";
            imageUrl2Label.Size = new System.Drawing.Size(61, 13);
            imageUrl2Label.TabIndex = 82;
            imageUrl2Label.Text = "image Url2:";
            // 
            // imageUrl3Label
            // 
            imageUrl3Label.AutoSize = true;
            imageUrl3Label.Location = new System.Drawing.Point(612, 313);
            imageUrl3Label.Name = "imageUrl3Label";
            imageUrl3Label.Size = new System.Drawing.Size(61, 13);
            imageUrl3Label.TabIndex = 83;
            imageUrl3Label.Text = "image Url3:";
            // 
            // imageUrl4Label
            // 
            imageUrl4Label.AutoSize = true;
            imageUrl4Label.Location = new System.Drawing.Point(22, 680);
            imageUrl4Label.Name = "imageUrl4Label";
            imageUrl4Label.Size = new System.Drawing.Size(61, 13);
            imageUrl4Label.TabIndex = 84;
            imageUrl4Label.Text = "image Url4:";
            // 
            // imageUrl5Label
            // 
            imageUrl5Label.AutoSize = true;
            imageUrl5Label.Location = new System.Drawing.Point(321, 680);
            imageUrl5Label.Name = "imageUrl5Label";
            imageUrl5Label.Size = new System.Drawing.Size(61, 13);
            imageUrl5Label.TabIndex = 85;
            imageUrl5Label.Text = "image Url5:";
            // 
            // btnSaveImg
            // 
            this.btnSaveImg.BackColor = System.Drawing.Color.White;
            this.btnSaveImg.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSaveImg.ForeColor = System.Drawing.Color.DarkBlue;
            this.btnSaveImg.Location = new System.Drawing.Point(169, 237);
            this.btnSaveImg.Margin = new System.Windows.Forms.Padding(2);
            this.btnSaveImg.Name = "btnSaveImg";
            this.btnSaveImg.Size = new System.Drawing.Size(110, 42);
            this.btnSaveImg.TabIndex = 67;
            this.btnSaveImg.Text = "Save and get link";
            this.btnSaveImg.UseVisualStyleBackColor = false;
            this.btnSaveImg.Click += new System.EventHandler(this.btnSaveImg_Click);
            // 
            // btnChangeImg
            // 
            this.btnChangeImg.AutoSize = true;
            this.btnChangeImg.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnChangeImg.LinkColor = System.Drawing.SystemColors.MenuHighlight;
            this.btnChangeImg.Location = new System.Drawing.Point(36, 246);
            this.btnChangeImg.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.btnChangeImg.Name = "btnChangeImg";
            this.btnChangeImg.Size = new System.Drawing.Size(123, 20);
            this.btnChangeImg.TabIndex = 66;
            this.btnChangeImg.TabStop = true;
            this.btnChangeImg.Text = "Choose image";
            this.btnChangeImg.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.btnChangeImg_LinkClicked);
            // 
            // picImage
            // 
            this.picImage.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.picImage.Location = new System.Drawing.Point(67, 25);
            this.picImage.Margin = new System.Windows.Forms.Padding(2);
            this.picImage.Name = "picImage";
            this.picImage.Size = new System.Drawing.Size(172, 196);
            this.picImage.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picImage.TabIndex = 65;
            this.picImage.TabStop = false;
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.White;
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.Color.DarkBlue;
            this.button1.Location = new System.Drawing.Point(453, 237);
            this.button1.Margin = new System.Windows.Forms.Padding(2);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(110, 42);
            this.button1.TabIndex = 70;
            this.button1.Text = "Save and get link";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.btnSaveImg1_Click);
            // 
            // linkLabel1
            // 
            this.linkLabel1.AutoSize = true;
            this.linkLabel1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.linkLabel1.LinkColor = System.Drawing.SystemColors.MenuHighlight;
            this.linkLabel1.Location = new System.Drawing.Point(320, 246);
            this.linkLabel1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.linkLabel1.Name = "linkLabel1";
            this.linkLabel1.Size = new System.Drawing.Size(123, 20);
            this.linkLabel1.TabIndex = 69;
            this.linkLabel1.TabStop = true;
            this.linkLabel1.Text = "Choose image";
            this.linkLabel1.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.btnChangeImg1_LinkClicked);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pictureBox1.Location = new System.Drawing.Point(351, 25);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(2);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(172, 196);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 68;
            this.pictureBox1.TabStop = false;
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.White;
            this.button2.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.ForeColor = System.Drawing.Color.DarkBlue;
            this.button2.Location = new System.Drawing.Point(744, 237);
            this.button2.Margin = new System.Windows.Forms.Padding(2);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(110, 42);
            this.button2.TabIndex = 73;
            this.button2.Text = "Save and get link";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.btnSaveImg2_Click);
            // 
            // linkLabel2
            // 
            this.linkLabel2.AutoSize = true;
            this.linkLabel2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.linkLabel2.LinkColor = System.Drawing.SystemColors.MenuHighlight;
            this.linkLabel2.Location = new System.Drawing.Point(611, 246);
            this.linkLabel2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.linkLabel2.Name = "linkLabel2";
            this.linkLabel2.Size = new System.Drawing.Size(123, 20);
            this.linkLabel2.TabIndex = 72;
            this.linkLabel2.TabStop = true;
            this.linkLabel2.Text = "Choose image";
            this.linkLabel2.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.btnChangeImg2_LinkClicked);
            // 
            // pictureBox2
            // 
            this.pictureBox2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pictureBox2.Location = new System.Drawing.Point(642, 25);
            this.pictureBox2.Margin = new System.Windows.Forms.Padding(2);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(172, 196);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 71;
            this.pictureBox2.TabStop = false;
            // 
            // button3
            // 
            this.button3.BackColor = System.Drawing.Color.White;
            this.button3.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button3.ForeColor = System.Drawing.Color.DarkBlue;
            this.button3.Location = new System.Drawing.Point(154, 600);
            this.button3.Margin = new System.Windows.Forms.Padding(2);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(110, 42);
            this.button3.TabIndex = 76;
            this.button3.Text = "Save and get link";
            this.button3.UseVisualStyleBackColor = false;
            this.button3.Click += new System.EventHandler(this.btnSaveImg3_Click);
            // 
            // linkLabel3
            // 
            this.linkLabel3.AutoSize = true;
            this.linkLabel3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.linkLabel3.LinkColor = System.Drawing.SystemColors.MenuHighlight;
            this.linkLabel3.Location = new System.Drawing.Point(21, 609);
            this.linkLabel3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.linkLabel3.Name = "linkLabel3";
            this.linkLabel3.Size = new System.Drawing.Size(123, 20);
            this.linkLabel3.TabIndex = 75;
            this.linkLabel3.TabStop = true;
            this.linkLabel3.Text = "Choose image";
            this.linkLabel3.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.btnChangeImg3_LinkClicked);
            // 
            // pictureBox3
            // 
            this.pictureBox3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pictureBox3.Location = new System.Drawing.Point(52, 388);
            this.pictureBox3.Margin = new System.Windows.Forms.Padding(2);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(172, 196);
            this.pictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox3.TabIndex = 74;
            this.pictureBox3.TabStop = false;
            // 
            // button4
            // 
            this.button4.BackColor = System.Drawing.Color.White;
            this.button4.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button4.ForeColor = System.Drawing.Color.DarkBlue;
            this.button4.Location = new System.Drawing.Point(453, 600);
            this.button4.Margin = new System.Windows.Forms.Padding(2);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(110, 42);
            this.button4.TabIndex = 79;
            this.button4.Text = "Save and get link";
            this.button4.UseVisualStyleBackColor = false;
            this.button4.Click += new System.EventHandler(this.btnSaveImg4_Click);
            // 
            // linkLabel4
            // 
            this.linkLabel4.AutoSize = true;
            this.linkLabel4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.linkLabel4.LinkColor = System.Drawing.SystemColors.MenuHighlight;
            this.linkLabel4.Location = new System.Drawing.Point(320, 609);
            this.linkLabel4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.linkLabel4.Name = "linkLabel4";
            this.linkLabel4.Size = new System.Drawing.Size(123, 20);
            this.linkLabel4.TabIndex = 78;
            this.linkLabel4.TabStop = true;
            this.linkLabel4.Text = "Choose image";
            this.linkLabel4.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.btnChangeImg4_LinkClicked);
            // 
            // pictureBox4
            // 
            this.pictureBox4.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pictureBox4.Location = new System.Drawing.Point(351, 388);
            this.pictureBox4.Margin = new System.Windows.Forms.Padding(2);
            this.pictureBox4.Name = "pictureBox4";
            this.pictureBox4.Size = new System.Drawing.Size(172, 196);
            this.pictureBox4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox4.TabIndex = 77;
            this.pictureBox4.TabStop = false;
            // 
            // phoneShopDataSet
            // 
            this.phoneShopDataSet.DataSetName = "PhoneShopDataSet";
            this.phoneShopDataSet.EnforceConstraints = false;
            this.phoneShopDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // imageProductBindingSource
            // 
            this.imageProductBindingSource.DataMember = "ImageProduct";
            this.imageProductBindingSource.DataSource = this.phoneShopDataSet;
            // 
            // imageProductTableAdapter
            // 
            this.imageProductTableAdapter.ClearBeforeFill = true;
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
            this.tableAdapterManager.ImageProductTableAdapter = this.imageProductTableAdapter;
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
            this.productIdSpinEdit.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.imageProductBindingSource, "productId", true));
            this.productIdSpinEdit.EditValue = new decimal(new int[] {
            0,
            0,
            0,
            0});
            this.productIdSpinEdit.Enabled = false;
            this.productIdSpinEdit.Location = new System.Drawing.Point(725, 448);
            this.productIdSpinEdit.Name = "productIdSpinEdit";
            this.productIdSpinEdit.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.productIdSpinEdit.Size = new System.Drawing.Size(100, 20);
            this.productIdSpinEdit.TabIndex = 81;
            // 
            // imageUrl1TextEdit
            // 
            this.imageUrl1TextEdit.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.imageProductBindingSource, "imageUrl1", true));
            this.imageUrl1TextEdit.Enabled = false;
            this.imageUrl1TextEdit.Location = new System.Drawing.Point(94, 310);
            this.imageUrl1TextEdit.Name = "imageUrl1TextEdit";
            this.imageUrl1TextEdit.Size = new System.Drawing.Size(185, 20);
            this.imageUrl1TextEdit.TabIndex = 82;
            // 
            // imageUrl2TextEdit
            // 
            this.imageUrl2TextEdit.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.imageProductBindingSource, "imageUrl2", true));
            this.imageUrl2TextEdit.Enabled = false;
            this.imageUrl2TextEdit.Location = new System.Drawing.Point(388, 310);
            this.imageUrl2TextEdit.Name = "imageUrl2TextEdit";
            this.imageUrl2TextEdit.Size = new System.Drawing.Size(175, 20);
            this.imageUrl2TextEdit.TabIndex = 83;
            // 
            // imageUrl3TextEdit
            // 
            this.imageUrl3TextEdit.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.imageProductBindingSource, "imageUrl3", true));
            this.imageUrl3TextEdit.Enabled = false;
            this.imageUrl3TextEdit.Location = new System.Drawing.Point(679, 310);
            this.imageUrl3TextEdit.Name = "imageUrl3TextEdit";
            this.imageUrl3TextEdit.Size = new System.Drawing.Size(175, 20);
            this.imageUrl3TextEdit.TabIndex = 84;
            // 
            // imageUrl4TextEdit
            // 
            this.imageUrl4TextEdit.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.imageProductBindingSource, "imageUrl4", true));
            this.imageUrl4TextEdit.Enabled = false;
            this.imageUrl4TextEdit.Location = new System.Drawing.Point(94, 677);
            this.imageUrl4TextEdit.Name = "imageUrl4TextEdit";
            this.imageUrl4TextEdit.Size = new System.Drawing.Size(170, 20);
            this.imageUrl4TextEdit.TabIndex = 85;
            // 
            // imageUrl5TextEdit
            // 
            this.imageUrl5TextEdit.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.imageProductBindingSource, "imageUrl5", true));
            this.imageUrl5TextEdit.Enabled = false;
            this.imageUrl5TextEdit.Location = new System.Drawing.Point(388, 677);
            this.imageUrl5TextEdit.Name = "imageUrl5TextEdit";
            this.imageUrl5TextEdit.Size = new System.Drawing.Size(175, 20);
            this.imageUrl5TextEdit.TabIndex = 86;
            // 
            // button5
            // 
            this.button5.BackColor = System.Drawing.Color.Turquoise;
            this.button5.Location = new System.Drawing.Point(725, 543);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(100, 41);
            this.button5.TabIndex = 87;
            this.button5.Text = "OK";
            this.button5.UseVisualStyleBackColor = false;
            this.button5.Click += new System.EventHandler(this.buttonOK_Click);
            // 
            // SubFormImageProduct
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(923, 756);
            this.Controls.Add(this.button5);
            this.Controls.Add(imageUrl5Label);
            this.Controls.Add(this.imageUrl5TextEdit);
            this.Controls.Add(imageUrl4Label);
            this.Controls.Add(this.imageUrl4TextEdit);
            this.Controls.Add(imageUrl3Label);
            this.Controls.Add(this.imageUrl3TextEdit);
            this.Controls.Add(imageUrl2Label);
            this.Controls.Add(this.imageUrl2TextEdit);
            this.Controls.Add(imageUrl1Label);
            this.Controls.Add(this.imageUrl1TextEdit);
            this.Controls.Add(productIdLabel);
            this.Controls.Add(this.productIdSpinEdit);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.linkLabel4);
            this.Controls.Add(this.pictureBox4);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.linkLabel3);
            this.Controls.Add(this.pictureBox3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.linkLabel2);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.linkLabel1);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.btnSaveImg);
            this.Controls.Add(this.btnChangeImg);
            this.Controls.Add(this.picImage);
            this.Name = "SubFormImageProduct";
            this.Text = "SubFormImageProduct";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.SubFormPhieuNhap_FormClosing);
            this.Load += new System.EventHandler(this.SubFormImageProduct_Load);
            this.Shown += new System.EventHandler(this.SubFormDetailPro_Shown);
            ((System.ComponentModel.ISupportInitialize)(this.picImage)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.phoneShopDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.imageProductBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.productIdSpinEdit.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.imageUrl1TextEdit.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.imageUrl2TextEdit.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.imageUrl3TextEdit.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.imageUrl4TextEdit.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.imageUrl5TextEdit.Properties)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnSaveImg;
        private System.Windows.Forms.LinkLabel btnChangeImg;
        private System.Windows.Forms.PictureBox picImage;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.LinkLabel linkLabel1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.LinkLabel linkLabel2;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.LinkLabel linkLabel3;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.LinkLabel linkLabel4;
        private System.Windows.Forms.PictureBox pictureBox4;
        private PhoneShopDataSet phoneShopDataSet;
        private System.Windows.Forms.BindingSource imageProductBindingSource;
        private PhoneShopDataSetTableAdapters.ImageProductTableAdapter imageProductTableAdapter;
        private PhoneShopDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private DevExpress.XtraEditors.SpinEdit productIdSpinEdit;
        private DevExpress.XtraEditors.TextEdit imageUrl1TextEdit;
        private DevExpress.XtraEditors.TextEdit imageUrl2TextEdit;
        private DevExpress.XtraEditors.TextEdit imageUrl3TextEdit;
        private DevExpress.XtraEditors.TextEdit imageUrl4TextEdit;
        private DevExpress.XtraEditors.TextEdit imageUrl5TextEdit;
        private System.Windows.Forms.Button button5;
    }
}