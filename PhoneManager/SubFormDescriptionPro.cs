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
    public partial class SubFormDescriptionPro : DevExpress.XtraEditors.XtraForm
    {
        private bool flagSuccess = false;
        public SubFormDescriptionPro()
        {
            InitializeComponent();
        }

        private void SubFormDescriptionPro_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'phoneShopDataSet.Description' table. You can move, or remove it, as needed.
            this.descriptionTableAdapter.Fill(this.phoneShopDataSet.Description);

        }

        private void SubFormDetailPro_Shown(object sender, EventArgs e)
        {
            this.descriptionBindingSource.AddNew();

            BindingSource tempProduct = Program.productForm.getProductBDS();
            string valueProductId = getDataRow(tempProduct, "productId");
            idTextBox.Text = valueProductId;

        }

        private string getDataRow(BindingSource bindingSource, string column)
        {
            return ((DataRowView)bindingSource[bindingSource.Position])[column].ToString().Trim();
        }

        private void SubFormPhieuNhap_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (flagSuccess == false) descriptionBindingSource.CancelEdit();
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
            if (imageUrlTextEdit.Text == null || picImage.Image == null || picImage.Image == Properties.Resources.no_image)
            {
                MessageBox.Show("Chưa có hình ảnh, không thể upload", "THÔNG BÁO", MessageBoxButtons.OK);
                return;
            }
            var stream = new System.IO.MemoryStream();
            picImage.Image.Save(stream, ImageFormat.Jpeg);
            stream.Position = 0;
            var task = new FirebaseStorage("product-7475d.appspot.com")
                            .Child("imgdesproduct_" + idTextBox.Text + ".jpg")
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
                imageUrlTextEdit.Text = downloadUrl;
                MessageBox.Show("Upload thành công!\n Link: " + downloadUrl, "THÔNG BÁO", MessageBoxButtons.OK);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Err: " + ex.Message, "THÔNG BÁO", MessageBoxButtons.OK);

            }
        }
        private void buttonOK_Click(object sender, EventArgs e)
        {

            if (!checkValidate(idTextBox, "Mã Sản phẩm is not empty!")) return;

            if (!checkValidate(des1RichTextBox, "Mô tả 1 Not empty!")) return;

            if (!checkValidate(des2RichTextBox, "Mô tả 2 Not empty!")) return;

            if (!checkValidate(imageUrlTextEdit, "Hình ảnh Not empty!")) return;

            DialogResult dr = MessageBox.Show("Bạn có chắc muốn ghi dữ liệu vào Database?", "Thông báo",
                MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
            if (dr == DialogResult.OK)
            {
                try
                {
                    this.descriptionBindingSource.EndEdit();
                    this.descriptionTableAdapter.Update(this.phoneShopDataSet.Description);

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
        private bool checkValidate(TextBox tb, string str)
        {
            if (tb.Text.Trim().Equals(""))
            {
                MessageBox.Show(str, "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                tb.Focus();
                return false;
            }
            return true;
        }
        private bool checkValidate(RichTextBox tb, string str)
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