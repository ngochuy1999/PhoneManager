using DevExpress.XtraEditors;
using Firebase.Storage;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Imaging;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PhoneManager
{
    public partial class SubFormImageProduct : DevExpress.XtraEditors.XtraForm
    {
        private bool flagSuccess = false;
        public SubFormImageProduct()
        {
            InitializeComponent();
        }

        private void imageProductBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.imageProductBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.phoneShopDataSet);

        }

        private void SubFormImageProduct_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'phoneShopDataSet.ImageProduct' table. You can move, or remove it, as needed.
            this.imageProductTableAdapter.Fill(this.phoneShopDataSet.ImageProduct);

        }
        private void SubFormDetailPro_Shown(object sender, EventArgs e)
        {
            this.imageProductBindingSource.AddNew();

            BindingSource tempProduct = Program.productForm.getProductBDS();
            string valueProductId = getDataRow(tempProduct, "productId");
            productIdSpinEdit.Text = valueProductId;

        }

        private string getDataRow(BindingSource bindingSource, string column)
        {
            return ((DataRowView)bindingSource[bindingSource.Position])[column].ToString().Trim();
        }

        private void SubFormPhieuNhap_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (flagSuccess == false) imageProductBindingSource.CancelEdit();
            Program.mainForm.Enabled = true;
        }

        private void btnChangeImg_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
                OpenFileDialog ofd = new OpenFileDialog();
                ofd.Title = "Select image";
                ofd.Filter = "Image Files(*.jpg|*.jpg|*.png|*.jpeg";
                if (ofd.ShowDialog() == DialogResult.OK)
                {
                    System.Drawing.Image img = new Bitmap(ofd.FileName);
                    picImage.Image = img.GetThumbnailImage(351, 469, null, new IntPtr());
                }
            
        }

        private async void btnSaveImg_Click(object sender, EventArgs e)
        {
            if (imageUrl1TextEdit.Text == null || picImage.Image == null || picImage.Image == Properties.Resources.no_image)
            {
                MessageBox.Show("Chưa có hình ảnh, không thể upload", "THÔNG BÁO", MessageBoxButtons.OK);
                return;
            }
            var stream = new System.IO.MemoryStream();
            picImage.Image.Save(stream, ImageFormat.Jpeg);
            stream.Position = 0;
            var task = new FirebaseStorage("product-7475d.appspot.com")
                            .Child("product_1_" + productIdSpinEdit.Text + ".jpg")
                            .PutAsync(stream);
            // Track progress of the upload
            task.Progress.ProgressChanged += (s, ex) =>
            {
                Console.WriteLine($"Progress: {ex.Percentage} %");
            };

            // await the task to wait until upload completes and get the download url
            try
            {
                var downloadUrl = await task;
                imageUrl1TextEdit.Text = downloadUrl;
                MessageBox.Show("Upload thành công!\n Link: " + downloadUrl, "THÔNG BÁO", MessageBoxButtons.OK);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Err: " + ex.Message, "THÔNG BÁO", MessageBoxButtons.OK);

            }
        }
        private void btnChangeImg1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            OpenFileDialog ofd = new OpenFileDialog();
            ofd.Title = "Select image";
            ofd.Filter = "Image Files(*.jpg|*.jpg|*.png|*.jpeg";
            if (ofd.ShowDialog() == DialogResult.OK)
            {
                System.Drawing.Image img = new Bitmap(ofd.FileName);
                pictureBox1.Image = img.GetThumbnailImage(351, 469, null, new IntPtr());
            }

        }

        private async void btnSaveImg1_Click(object sender, EventArgs e)
        {
            if (imageUrl1TextEdit.Text == null || pictureBox1.Image == null || pictureBox1.Image == Properties.Resources.no_image)
            {
                MessageBox.Show("Chưa có hình ảnh, không thể upload", "THÔNG BÁO", MessageBoxButtons.OK);
                return;
            }
            var stream = new System.IO.MemoryStream();
            pictureBox1.Image.Save(stream, ImageFormat.Jpeg);
            stream.Position = 0;
            var task = new FirebaseStorage("product-7475d.appspot.com")
                            .Child("product_2_" + productIdSpinEdit.Text + ".jpg")
                            .PutAsync(stream);
            // Track progress of the upload
            task.Progress.ProgressChanged += (s, ex) =>
            {
                Console.WriteLine($"Progress: {ex.Percentage} %");
            };

            // await the task to wait until upload completes and get the download url
            try
            {
                var downloadUrl = await task;
                imageUrl2TextEdit.Text = downloadUrl;
                MessageBox.Show("Upload thành công!\n Link: " + downloadUrl, "THÔNG BÁO", MessageBoxButtons.OK);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Err: " + ex.Message, "THÔNG BÁO", MessageBoxButtons.OK);

            }
        }
        private void btnChangeImg2_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            OpenFileDialog ofd = new OpenFileDialog();
            ofd.Title = "Select image";
            ofd.Filter = "Image Files(*.jpg|*.jpg|*.png|*.jpeg";
            if (ofd.ShowDialog() == DialogResult.OK)
            {
                System.Drawing.Image img = new Bitmap(ofd.FileName);
                pictureBox2.Image = img.GetThumbnailImage(351, 469, null, new IntPtr());
            }

        }

        private async void btnSaveImg2_Click(object sender, EventArgs e)
        {
            if (imageUrl1TextEdit.Text == null || pictureBox2.Image == null || pictureBox2.Image == Properties.Resources.no_image)
            {
                MessageBox.Show("Chưa có hình ảnh, không thể upload", "THÔNG BÁO", MessageBoxButtons.OK);
                return;
            }
            var stream = new System.IO.MemoryStream();
            pictureBox2.Image.Save(stream, ImageFormat.Jpeg);
            stream.Position = 0;
            var task = new FirebaseStorage("product-7475d.appspot.com")
                            .Child("product_3_" + productIdSpinEdit.Text + ".jpg")
                            .PutAsync(stream);
            // Track progress of the upload
            task.Progress.ProgressChanged += (s, ex) =>
            {
                Console.WriteLine($"Progress: {ex.Percentage} %");
            };

            // await the task to wait until upload completes and get the download url
            try
            {
                var downloadUrl = await task;
                imageUrl3TextEdit.Text = downloadUrl;
                MessageBox.Show("Upload thành công!\n Link: " + downloadUrl, "THÔNG BÁO", MessageBoxButtons.OK);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Err: " + ex.Message, "THÔNG BÁO", MessageBoxButtons.OK);

            }
        }
        private void btnChangeImg3_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            OpenFileDialog ofd = new OpenFileDialog();
            ofd.Title = "Select image";
            ofd.Filter = "Image Files(*.jpg|*.jpg|*.png|*.jpeg";
            if (ofd.ShowDialog() == DialogResult.OK)
            {
                System.Drawing.Image img = new Bitmap(ofd.FileName);
                pictureBox3.Image = img.GetThumbnailImage(351, 469, null, new IntPtr());
            }

        }

        private async void btnSaveImg3_Click(object sender, EventArgs e)
        {
            if (imageUrl1TextEdit.Text == null || pictureBox3.Image == null || pictureBox3.Image == Properties.Resources.no_image)
            {
                MessageBox.Show("Chưa có hình ảnh, không thể upload", "THÔNG BÁO", MessageBoxButtons.OK);
                return;
            }
            var stream = new System.IO.MemoryStream();
            pictureBox3.Image.Save(stream, ImageFormat.Jpeg);
            stream.Position = 0;
            var task = new FirebaseStorage("product-7475d.appspot.com")
                            .Child("product_4_" + productIdSpinEdit.Text + ".jpg")
                            .PutAsync(stream);
            // Track progress of the upload
            task.Progress.ProgressChanged += (s, ex) =>
            {
                Console.WriteLine($"Progress: {ex.Percentage} %");
            };

            // await the task to wait until upload completes and get the download url
            try
            {
                var downloadUrl = await task;
                imageUrl4TextEdit.Text = downloadUrl;
                MessageBox.Show("Upload thành công!\n Link: " + downloadUrl, "THÔNG BÁO", MessageBoxButtons.OK);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Err: " + ex.Message, "THÔNG BÁO", MessageBoxButtons.OK);

            }
        }
        private void btnChangeImg4_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            OpenFileDialog ofd = new OpenFileDialog();
            ofd.Title = "Select image";
            ofd.Filter = "Image Files(*.jpg|*.jpg|*.png|*.jpeg";
            if (ofd.ShowDialog() == DialogResult.OK)
            {
                System.Drawing.Image img = new Bitmap(ofd.FileName);
                pictureBox4.Image = img.GetThumbnailImage(351, 469, null, new IntPtr());
            }

        }

        private async void btnSaveImg4_Click(object sender, EventArgs e)
        {
            if (imageUrl1TextEdit.Text == null || pictureBox4.Image == null || pictureBox4.Image == Properties.Resources.no_image)
            {
                MessageBox.Show("Chưa có hình ảnh, không thể upload", "THÔNG BÁO", MessageBoxButtons.OK);
                return;
            }
            var stream = new System.IO.MemoryStream();
            pictureBox4.Image.Save(stream, ImageFormat.Jpeg);
            stream.Position = 0;
            var task = new FirebaseStorage("product-7475d.appspot.com")
                            .Child("product_5_" + productIdSpinEdit.Text + ".jpg")
                            .PutAsync(stream);
            // Track progress of the upload
            task.Progress.ProgressChanged += (s, ex) =>
            {
                Console.WriteLine($"Progress: {ex.Percentage} %");
            };

            // await the task to wait until upload completes and get the download url
            try
            {
                var downloadUrl = await task;
                imageUrl5TextEdit.Text = downloadUrl;
                MessageBox.Show("Upload thành công!\n Link: " + downloadUrl, "THÔNG BÁO", MessageBoxButtons.OK);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Err: " + ex.Message, "THÔNG BÁO", MessageBoxButtons.OK);

            }
        }

        private void buttonOK_Click(object sender, EventArgs e)
        {

            if (!checkValidate(productIdSpinEdit, "Mã Sản phẩm is not empty!")) return;

            if (!checkValidate(imageUrl1TextEdit, "Not empty!")) return;

            DialogResult dr = MessageBox.Show("Bạn có chắc muốn ghi dữ liệu vào Database?", "Thông báo",
                MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
            if (dr == DialogResult.OK)
            {
                try
                {
                    this.imageProductBindingSource.EndEdit();
                    this.imageProductTableAdapter.Update(this.phoneShopDataSet.ImageProduct);

                    Program.productForm.refresh();
                    flagSuccess = true;
                    this.Close();

                }
                catch (Exception ex)
                {
                    MessageBox.Show("Ghi dữ liệu thất lại. Vui lòng kiểm tra lại!\n" + ex.Message, "Error",
                        MessageBoxButtons.OK, MessageBoxIcon.Error);
                }

            }

        }
        private bool checkValidate(TextEdit tb, string str)
        {
            if (tb.Text.Trim().Equals(""))
            {
                MessageBox.Show(str, "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                tb.Focus();
                return false;
            }
            return true;
        }
    }
}