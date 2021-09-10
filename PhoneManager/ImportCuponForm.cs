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
using DevExpress.XtraGrid.Menu;
using DevExpress.XtraGrid.Views.Grid;
using DevExpress.Utils.Menu;
using System.Data.SqlClient;

namespace PhoneManager
{
    public partial class ImportCuponForm : DevExpress.XtraEditors.XtraForm
    {
        public ImportCuponForm()
        {
            InitializeComponent();
        }

        private void employeeBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.employeeBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.phoneShopDataSet);

        }

        private void ImportCouponForm_Load(object sender, EventArgs e)
        {
   
            // TODO: This line of code loads data into the 'phoneShopDataSet.ImportCouponDetail' table. You can move, or remove it, as needed.
            this.importCouponDetailTableAdapter.Fill(this.phoneShopDataSet.ImportCouponDetail);
            // TODO: This line of code loads data into the 'phoneShopDataSet.ImportCoupon' table. You can move, or remove it, as needed.
            this.importCouponTableAdapter.Fill(this.phoneShopDataSet.ImportCoupon);
            // TODO: This line of code loads data into the 'phoneShopDataSet.ImportCoupon' table. You can move, or remove it, as needed.
            this.importCouponTableAdapter.Fill(this.phoneShopDataSet.ImportCoupon);
            // TODO: This line of code loads data into the 'phoneShopDataSet.Employee' table. You can move, or remove it, as needed.
            this.employeeTableAdapter.Fill(this.phoneShopDataSet.Employee);


        }

        private void btnAddProvider_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            importCouponBindingSource.AddNew();
            employeeIdSpinEdit.EditValue = Program.accountLogin.idEmployee;
        }

        private void btnDelProvider_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (importCouponBindingSource.Count == 0)
            {
                MessageBox.Show("Không có phiếu nhập để xóa!", "THÔNG BÁO", MessageBoxButtons.OK);
                return;
            }
            else
            {
                if (importCouponDetailBindingSource.Count > 0)
                {
                    MessageBox.Show("Phiếu nhập đã có chi tiết, không thể xóa, category sẽ được chuyển qua trạng thái đã xóa", "", MessageBoxButtons.OK);
                    return;
                }

                if (MessageBox.Show("Bạn có chắc chắn muốn xóa phiếu nhập này?", "", MessageBoxButtons.YesNo) == DialogResult.Yes)
                {
                    try
                    {
                        //phải chạy lệnh del from where mới chính xác
                        importCouponBindingSource.RemoveCurrent();
                        //đẩy dữ liệu về adapter
                        this.importCouponTableAdapter.Update(this.phoneShopDataSet.ImportCoupon);
                        Program.showToastDel();
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Lỗi xóa phiếu nhập" + ex.Message, "", MessageBoxButtons.OK);
                    }
                }
            }
        }
        private void btnSaveIport_Click(object sender, EventArgs e)
        {
            if (dateAddDateEdit.Text.ToString() == "")
            {
                MessageBox.Show("Please select an import date", "Error", MessageBoxButtons.OK);
                return;
            }
            else if (employeeIdSpinEdit.Text.ToString() == "")
            {
                MessageBox.Show("Can't load employee id, please choose an employeee!", "Error", MessageBoxButtons.OK);
                return;
            }
            else
            {
                try
                {
                    this.Validate();
                    this.importCouponBindingSource.EndEdit();
                    this.importCouponTableAdapter.Update(this.phoneShopDataSet.ImportCoupon);
                    this.tableAdapterManager.UpdateAll(this.phoneShopDataSet);
                    Program.showToastSave();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error import cupon " + ex.Message, "", MessageBoxButtons.OK);

                }
            }
        }
        private void btnCancelAddProvider_Click_1(object sender, EventArgs e)
        {
            try
            {
                this.importCouponBindingSource.CancelEdit();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error ", "Error", MessageBoxButtons.OK);
            }
        }
        private void btnCloseForm_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            this.Close();
        }

        private void btnReloadProvider_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            loadData();
            Program.showToastReload();
        }
        private void loadData()
        {
            // TODO: This line of code loads data into the 'phoneShopDataSet.ImportCouponDetail' table. You can move, or remove it, as needed.
            this.importCouponDetailTableAdapter.Fill(this.phoneShopDataSet.ImportCouponDetail);
            // TODO: This line of code loads data into the 'phoneShopDataSet.ImportCoupon' table. You can move, or remove it, as needed.
            this.importCouponTableAdapter.Fill(this.phoneShopDataSet.ImportCoupon);
            // TODO: This line of code loads data into the 'phoneShopDataSet.ImportCoupon' table. You can move, or remove it, as needed.
            this.importCouponTableAdapter.Fill(this.phoneShopDataSet.ImportCoupon);
        }


        //===========================Khu vực Xử Lý Phát Sinh===========================

        private void gvPhieuNhap_PopupMenuShowing(object sender, PopupMenuShowingEventArgs e)
        {

            if (e.MenuType == GridMenuType.Row)
            {
                GridViewMenu menu = e.Menu;
                DXMenuItem menuAddCTPN = createMenuItem("Add Import Cupon Item", Properties.Resources.add);
                menuAddCTPN.Click += new EventHandler(menuAddCTPN_Click);
                menu.Items.Add(menuAddCTPN);
            }
        }
    
        private void gcPhieuNhap_MouseHover(object sender, EventArgs e)
        {

            importCouponGridControl.ContextMenuStrip = contextMenuStrip1;

        }




        //===========================Khu vực Xử Lý Chi Tiết Phát Sinh==================
        private void gvCTPN_PopupMenuShowing(object sender, PopupMenuShowingEventArgs e)
        {

            if (e.MenuType == GridMenuType.Row)
            {
                GridViewMenu menu = e.Menu;
                DXMenuItem menuAddCTPN = createMenuItem("Thêm chi tiết Phát Sinh", Properties.Resources.add);
                menuAddCTPN.Click += new EventHandler(menuAddCTPN_Click);
                menu.Items.Add(menuAddCTPN);

                DXMenuItem menuDeleteCTPN = createMenuItem("Xóa chi tiết Phát Sinh", Properties.Resources.delete__1_);
                //menuDeleteCTPN.Click += new EventHandler(menuDeleteCTPN_Click);
                menu.Items.Add(menuDeleteCTPN);
            }

        }
        private void menuAddCTPN_Click(object sender, EventArgs e)
        {
            Program.subFormImportDetail = new SubFormImportDetail();
            Program.subFormImportDetail.Show();
            Program.mainForm.Enabled = false;
        }


        private void menuDeleteCTPN_Click(object sender, EventArgs e)
        {

            int importCouponId ;
            int productId ;
          
            DialogResult dr1 = MessageBox.Show("Bạn có thực sự muốn xóa chi tiết phiếu nhập này?", "Xác nhận",
                                                     MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
            if (dr1 == DialogResult.OK)
            {
                try
                {
                    importCouponId = int.Parse(getDataRow(importCouponDetailBindingSource, "couponId"));
                    productId = int.Parse(getDataRow(importCouponDetailBindingSource, "productId"));

                    String sql = "EXEC SP_DelImportItem "
                            + productId + " , "
                            + importCouponId;
                    Program.myReader = Program.ExecSqlDataReader(sql);
                    loadData();
                    Program.showToastDel();
                }
                catch (Exception)
                {
                    MessageBox.Show("Error ", "Error", MessageBoxButtons.OK);
                }

            }   

            this.importCouponDetailTableAdapter.Fill(this.phoneShopDataSet.ImportCouponDetail);
            //bdsNV.Position = bdsNV.Find("MANV", manv);
        }
        private void smiAddCTPN_Click(object sender, EventArgs e)
        {

            Program.subFormImportDetail = new SubFormImportDetail();
            Program.subFormImportDetail.Show();
            Program.mainForm.Enabled = false;
        }
        private void gcCTPN_MouseHover(object sender, EventArgs e)
        {

            //cT_PHATSINHGridControl.ContextMenuStrip = (cT_PHATSINHBindingSource.Count == 0) ? cmsCTPS : null;
            importCouponDetailGridControl.ContextMenuStrip = contextMenuStrip2;
        }


        //================Các Method hỗ trợ================

        private DXMenuItem createMenuItem(string caption, Bitmap image)
        {
            DXMenuItem menuItem = new DXMenuItem();
            menuItem.Image = image;
            menuItem.Caption = caption;
            return menuItem;
        }
        private string getDataRow(BindingSource bindingSource, string column)
        {
            return ((DataRowView)bindingSource[bindingSource.Position])[column].ToString().Trim();
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
        private bool checkValidatesp(SpinEdit spinEdit, string str)
        {
            if (spinEdit.Value == 0)
            {
                MessageBox.Show(str, "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                spinEdit.Focus();
                return false;
            }
            return true;
        }


        //Getter-Setter các DataSet và BindingSource
        
        public BindingSource getPSBDS()
        {
            return this.importCouponBindingSource;
        }
        public BindingSource getCTPSBDS()
        {
            return this.importCouponDetailBindingSource;
        }

        public PhoneShopDataSet getDataSet()
        {
            return this.phoneShopDataSet;
        }

        public void refresh()
        {
            this.importCouponDetailTableAdapter.Fill(this.phoneShopDataSet.ImportCouponDetail);

        }

        private void ImportCuponForm_Shown(object sender, EventArgs e)
        {
            employeeIdSpinEdit.Text = Program.accountLogin.idEmployee.ToString();
        }

        private void employeeIdLabel_Click(object sender, EventArgs e)
        {

        }
    }
}