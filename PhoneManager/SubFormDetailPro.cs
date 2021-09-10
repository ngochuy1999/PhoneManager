using DevExpress.XtraEditors;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PhoneManager
{
    public partial class SubFormDetailPro : DevExpress.XtraEditors.XtraForm
    {
        private bool flagSuccess = false;
        public SubFormDetailPro()
        {
            InitializeComponent();
        }

        private void detailBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.detailBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.phoneShopDataSet);

        }

        private void SubFormDetailPro_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'phoneShopDataSet.Detail' table. You can move, or remove it, as needed.
            this.detailTableAdapter.Fill(this.phoneShopDataSet.Detail);

        }
        private void SubFormDetailPro_Shown(object sender, EventArgs e)
        {
            this.detailBindingSource.AddNew();

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
            if (flagSuccess == false) detailBindingSource.CancelEdit();
            Program.mainForm.Enabled = true;
        }


        private void buttonOK_Click(object sender, EventArgs e)
        {

            if (!checkValidate(productIdSpinEdit, "Mã Sản phẩm is not empty!")) return;

            if (!checkValidate(oSTextEdit, " not empty!")) return;

            if (!checkValidate(displayTextEdit, "Not empty!")) return;

            if (!checkValidate(pixelTextEdit, " Not empty!")) return;

            if (!checkValidate(inchTextEdit, " Not empty!")) return;

            if (!checkValidate(cpuTextEdit, "Not empty!")) return;

            if (!checkValidate(rAMTextEdit, " Not empty!")) return;

            if (!checkValidate(rOMTextEdit, "Not empty!")) return;

            if (!checkValidate(batteryTextEdit, "Not empty!")) return;

            DialogResult dr = MessageBox.Show("Bạn có chắc muốn ghi dữ liệu vào Database?", "Thông báo",
                MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
            if (dr == DialogResult.OK)
            {
                try
                {
                    this.detailBindingSource.EndEdit();
                    this.detailTableAdapter.Update(this.phoneShopDataSet.Detail);

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