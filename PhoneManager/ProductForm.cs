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
    public partial class ProductForm : DevExpress.XtraEditors.XtraForm
    {
        public ProductForm()
        {
            InitializeComponent();
        }

        private void productBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.productBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.phoneShopDataSet);

        }

        private void ProductForm_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'phoneShopDataSet.Provider' table. You can move, or remove it, as needed.
            this.providerTableAdapter.Fill(this.phoneShopDataSet.Provider);
            // TODO: This line of code loads data into the 'phoneShopDataSet.Category' table. You can move, or remove it, as needed.
            this.categoryTableAdapter.Fill(this.phoneShopDataSet.Category);
            // TODO: This line of code loads data into the 'phoneShopDataSet.Description' table. You can move, or remove it, as needed.
            this.descriptionTableAdapter.Fill(this.phoneShopDataSet.Description);
            // TODO: This line of code loads data into the 'phoneShopDataSet.Product' table. You can move, or remove it, as needed.
            this.productTableAdapter.Fill(this.phoneShopDataSet.Product);

        }

        private void btnCloseForm_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            this.Close();
        }

        private void btnReloadProvider_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            loadDataProduct();
            Program.showToastReload();
        }

        private void loadDataProduct()
        {
            // TODO: This line of code loads data into the 'phoneShopDataSet.Product' table. You can move, or remove it, as needed.
            this.productTableAdapter.Fill(this.phoneShopDataSet.Product);

        }

        private void btnAddProvider_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            productBindingSource.AddNew();
            activeSpinEdit.Text = "1";
            saleSpinEdit.Text = "0";
            DateTime dateTime = DateTime.UtcNow.Date;
            addDateDateEdit.Text = dateTime.ToString("yyyy-MM-dd");
        }

        private void btnSaveAddProvider_Click_1(object sender, EventArgs e)
        {
            if (activeSpinEdit.Text == "") activeSpinEdit.Text = "1";
            try
            {
                this.Validate();
                this.productBindingSource.EndEdit();
                this.productTableAdapter.Update(this.phoneShopDataSet.Product);
                this.tableAdapterManager.UpdateAll(this.phoneShopDataSet);
                Program.showToastSave();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error add product: " + ex.Message, "Error", MessageBoxButtons.OK);
            }
        }

        private void btnDelProvider_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (productBindingSource.Count == 0)
            {
                MessageBox.Show("Không có employee để xóa!", "THÔNG BÁO", MessageBoxButtons.OK);
                return;
            }
            else
            {
                if (MessageBox.Show("Bạn có chắc chắn muốn xóa " + ((DataRowView)this.productBindingSource.Current).Row["title"].ToString() + "?", "", MessageBoxButtons.YesNo) == DialogResult.Yes)
                {
                    try
                    {
                        String sql = "EXEC SP_DelProduct " + int.Parse(getDataRow(productBindingSource, "productId"));
                        Program.myReader = Program.ExecSqlDataReader(sql);
                        // TODO: This line of code loads data into the 'phoneShopDataSet.Product' table. You can move, or remove it, as needed.
                        this.productTableAdapter.Fill(this.phoneShopDataSet.Product);
                        Program.showToastDel();
                    }
                    catch (Exception)
                    {
                        MessageBox.Show("Error ", "Error", MessageBoxButtons.OK);
                    }

                }
            }
        }

        private string getDataRow(BindingSource bindingSource, string column)
        {
            return ((DataRowView)bindingSource[bindingSource.Position])[column].ToString().Trim();
        }

        private void provideIdTextEdit_EditValueChanged(object sender, EventArgs e)
        {

        }


        private void button2_Click(object sender, EventArgs e)
        {
            Program.subFormDetailPro = new SubFormDetailPro();
            Program.subFormDetailPro.Show();
            Program.mainForm.Enabled = false;
        }

        public BindingSource getProductBDS()
        {
            return this.productBindingSource;
        }

        public PhoneShopDataSet getDataSet()
        {
            return this.phoneShopDataSet;
        }

        public void refresh()
        {
            this.productTableAdapter.Fill(this.phoneShopDataSet.Product);

        }

        private void btnImageList_Click(object sender, EventArgs e)
        {
            Program.subFormImageProduct = new SubFormImageProduct();
            Program.subFormImageProduct.Show();
            Program.mainForm.Enabled = false;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Program.subFormDescription = new SubFormDescriptionPro();
            Program.subFormDescription.Show();
            Program.mainForm.Enabled = false;
        }

        private void btnCancelAddProvider_Click(object sender, EventArgs e)
        {
            try
            {
                this.productBindingSource.CancelEdit();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error ", "Error", MessageBoxButtons.OK);
            }
        }

        private void nameComboBox_SelectionChangeCommitted(object sender, EventArgs e)
        {
            if (categoryBindingSource.Position != -1)
            {
                categoryIdTextEdit.Text = nameComboBox.SelectedValue.ToString();
            }
        }

        private void branchNameComboBox_SelectionChangeCommitted(object sender, EventArgs e)
        {

            if (providerBindingSource.Position != -1)
            {
                provideIdTextEdit.Text = branchNameComboBox.SelectedValue.ToString();
            }
        }
    }
}