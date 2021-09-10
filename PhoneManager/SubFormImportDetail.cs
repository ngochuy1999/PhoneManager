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
    public partial class SubFormImportDetail : DevExpress.XtraEditors.XtraForm
    {
        private bool flagSuccess = false;
        public SubFormImportDetail()
        {
            InitializeComponent();
        }

        private void importCouponDetailBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.importCouponDetailBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.phoneShopDataSet);

        }

        private void SubFormImportDetail_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'phoneShopDataSet.Product' table. You can move, or remove it, as needed.
            this.productTableAdapter.Fill(this.phoneShopDataSet.Product);
            // TODO: This line of code loads data into the 'phoneShopDataSet.ImportCouponDetail' table. You can move, or remove it, as needed.
            this.importCouponDetailTableAdapter.Fill(this.phoneShopDataSet.ImportCouponDetail);

        }

        private void SubFormCTPS_Shown(object sender, EventArgs e)
        {
            ////Đặt trong Event Load thì Thread kết thúc sớm hơn Fill nên không đồng bộ, nên dùng Event có thứ tự sau
            this.importCouponDetailBindingSource.AddNew();

            /* 
             * Không hiểu sao không cập nhật MasoDDH trong CTDDH mà lại tự sinh ra MasoDDH,
             * nên chỗ này nếu ta set MasoDDH lần nữa thì sẽ phát sinh lỗi EndEdit không được      
            */
            BindingSource tempDDH = Program.importCuponForm.getPSBDS();
            string valueMasoDDH = getDataRow(tempDDH, "couponId");
            couponIdSpinEdit.Text = valueMasoDDH;

        }

        private string getDataRow(BindingSource bindingSource, string column)
        {
            return ((DataRowView)bindingSource[bindingSource.Position])[column].ToString().Trim();
        }



        private void gridViewVatTu_RowClick(object sender, DevExpress.XtraGrid.Views.Grid.RowClickEventArgs e)
        {
        
            if (productBindingSource.Position != -1)
            {
                productIdSpinEdit.Text = gridView1.GetRowCellValue(productBindingSource.Position, "productId").ToString().Trim();
            }
        }


        private void SubFormPhieuNhap_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (flagSuccess == false) importCouponDetailBindingSource.CancelEdit();
            Program.mainForm.Enabled = true;
        }


        private void buttonOK_Click(object sender, EventArgs e)
        {

            if (!checkValidate(couponIdSpinEdit, "Mã Phiếu is not empty!")) return;
            if (!checkValidate(productIdSpinEdit, "Mã Vật Tư is not empty!")) return;
            if (quantitySpinEdit.Value == 0)    //Trường hợp khi vừa Load vật tư số lượng tồn còn 0
            {
                MessageBox.Show("Số lượng phải > 0!", "Thông báo",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            DialogResult dr = MessageBox.Show("Bạn có chắc muốn ghi dữ liệu vào Database?", "Thông báo",
                MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
            if (dr == DialogResult.OK)
            {
                try
                {
                    this.importCouponDetailBindingSource.EndEdit();
                    this.importCouponDetailTableAdapter.Update(this.phoneShopDataSet.ImportCouponDetail);

                    Program.importCuponForm.refresh();
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