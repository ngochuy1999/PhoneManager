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
    public partial class InvoiceForm : DevExpress.XtraEditors.XtraForm
    {
        public InvoiceForm()
        {
            InitializeComponent();
        }

        private void invoiceStatusBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.invoiceStatusBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.phoneShopDataSet);

        }

        private void InvoiceForm_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'phoneShopDataSet.Product' table. You can move, or remove it, as needed.
            this.productTableAdapter.Fill(this.phoneShopDataSet.Product);
            // TODO: This line of code loads data into the 'phoneShopDataSet.InvoiceItem' table. You can move, or remove it, as needed.
            this.invoiceItemTableAdapter.Fill(this.phoneShopDataSet.InvoiceItem);
            // TODO: This line of code loads data into the 'phoneShopDataSet.Invoice' table. You can move, or remove it, as needed.
            this.invoiceTableAdapter.Fill(this.phoneShopDataSet.Invoice);
            // TODO: This line of code loads data into the 'phoneShopDataSet.InvoiceStatus' table. You can move, or remove it, as needed.
            this.invoiceStatusTableAdapter.Fill(this.phoneShopDataSet.InvoiceStatus);

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

        private void btnSaveAddProvider_Click_1(object sender, EventArgs e)
        {
            if (MessageBox.Show("Bạn có chắc chắn xác nhận đơn hàng ?", "", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                try
                {
                    updateDateDateEdit.DateTime = DateTime.Now;
                    statusOderIDSpinEdit.Value = 2;
                    this.Validate();
                    this.invoiceBindingSource.EndEdit();
                    this.invoiceTableAdapter.Update(this.phoneShopDataSet.Invoice);
                    Program.showToastSave();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error " + ex.Message, "Error", MessageBoxButtons.OK);

                }

            }

        }
        private void btnCancelAddProvider_Click_1(object sender, EventArgs e)
        {
            if (MessageBox.Show("Bạn có chắc chắn muốn hủy đơn hàng ?", "", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                try
                {
                    updateDateDateEdit.DateTime = DateTime.Now;
                    statusOderIDSpinEdit.Value = 5;
                    this.Validate();
                    this.invoiceBindingSource.EndEdit();
                    this.invoiceTableAdapter.Update(this.phoneShopDataSet.Invoice);
                    Program.showToastSave();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error " + ex.Message, "Error", MessageBoxButtons.OK);

                }
            }
        }


        private void loadData()
        {
            // TODO: This line of code loads data into the 'phoneShopDataSet.Product' table. You can move, or remove it, as needed.
            this.productTableAdapter.Fill(this.phoneShopDataSet.Product);
            // TODO: This line of code loads data into the 'phoneShopDataSet.InvoiceItem' table. You can move, or remove it, as needed.
            this.invoiceItemTableAdapter.Fill(this.phoneShopDataSet.InvoiceItem);
        }

        private void panel4_Paint(object sender, PaintEventArgs e)
        {

        }

        private void updateDateLabel_Click(object sender, EventArgs e)
        {

        }

        private void deliveryDateDateEdit_EditValueChanged(object sender, EventArgs e)
        {

        }

        private void buyDateLabel_Click(object sender, EventArgs e)
        {

        }

        private void buyDateDateEdit_EditValueChanged(object sender, EventArgs e)
        {

        }

        private void updateDateDateEdit_EditValueChanged(object sender, EventArgs e)
        {

        }

        private void deliveryDateLabel_Click(object sender, EventArgs e)
        {

        }


        private void statusIdComboBox_SelectionChangeCommitted(object sender, EventArgs e)
        {
            if (invoiceStatusBindingSource.Position != -1)
            {
                statusNameLabel1.Text = statusIdComboBox.SelectedValue.ToString();
                if (statusIdComboBox.SelectedValue.ToString() != "Chờ xác nhận")
                {
                    btnSaveAddProvider.Visible = false;
                    btnCancelAddProvider.Visible = false;
                }
                else
                {
                    btnSaveAddProvider.Visible = true;
                    btnCancelAddProvider.Visible = true;
                }
            }
        }
    }
}