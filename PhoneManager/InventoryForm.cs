using DevExpress.XtraEditors;
using DevExpress.XtraReports.UI;
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
    public partial class InventoryForm : DevExpress.XtraEditors.XtraForm
    {
        public InventoryForm()
        {
            InitializeComponent();
        }

        private void InventoryForm_Load(object sender, EventArgs e)
        {
            loadDataForm();

        }

        private void cbCategory_CheckedChanged(object sender, EventArgs e)
        {
            getData();
        }

        private void cbProvider_CheckedChanged(object sender, EventArgs e)
        {
            getData();
        }

        private void categoryComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cbCategory.Checked) getData();
        }

        private void providerComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cbProvider.Checked) getData();
        }

        private void btnExport_Click(object sender, EventArgs e)
        {

            if (sP_InventoryProductBindingSource.Count <= 0)
            {
                MessageBox.Show("Không có dữ liệu để xuất file", "Lỗi", MessageBoxButtons.OK);

            }
            else
            {
                Nullable<int> categoryId = null, providerID = null;
                if (cbCategory.Checked)
                    categoryId = int.Parse(categoryComboBox.SelectedValue.ToString());
                if (cbProvider.Checked)
                    providerID = int.Parse(providerComboBox.SelectedValue.ToString());

                InventoryReport report = new InventoryReport(categoryId,providerID);
                report.lbNhanVien.Text = "Nhân viên tạo phiếu: " + Program.accountLogin.name;
                string title = "";
                if (providerID == null && categoryId == null)
                    title = "Danh sách tất cả sản phẩm trong kho";
                else if (providerID != null && categoryId == null)
                    title = "Danh sách tất cả sản phẩm trong kho của nhà cung cấp " + providerComboBox.Text;
                else if (providerID == null && categoryId != null)
                    title = "Danh sách tất cả " + categoryComboBox.Text + " trong kho ";
                else if (providerID != null && categoryId != null)
                    title = "Danh sách tất cả " + categoryComboBox.Text + " trong kho của nhà cung cấp " + providerComboBox.Text;
                report.lbTitle.Text = title;
                ReportPrintTool reportTool = new ReportPrintTool(report);
                reportTool.ShowPreviewDialog();
            }
        }

        private void getData()
        {
            try
            {
                Nullable<int> categoryId = null, providerID = null;
                if (cbCategory.Checked)
                    categoryId = int.Parse(categoryComboBox.SelectedValue.ToString());
                if (cbProvider.Checked)
                    providerID = int.Parse(providerComboBox.SelectedValue.ToString());
                this.sP_InventoryProductTableAdapter.Fill(this.phoneShopDataSet.SP_InventoryProduct, categoryId, providerID);
            }
            catch (System.Exception ex)
            {
                MessageBox.Show("Error " + ex.Message, "Error", MessageBoxButtons.OK);

            }
        }

        private void loadDataForm()
        {
            // TODO: This line of code loads data into the 'phoneShopDataSet.Category' table. You can move, or remove it, as needed.
            this.categoryTableAdapter.Fill(this.phoneShopDataSet.Category);
            // TODO: This line of code loads data into the 'phoneShopDataSet.Provider' table. You can move, or remove it, as needed.
            this.providerTableAdapter.Fill(this.phoneShopDataSet.Provider);
            getData();
        }

        private void btnCloseForm_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            this.Close();
        }

        private void btnReloadProvider_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            loadDataForm();
            Program.showToastReload();
        }
    }
}