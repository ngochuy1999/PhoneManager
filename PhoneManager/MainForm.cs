using DevExpress.XtraBars;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace PhoneManager
{
    public partial class MainForm : DevExpress.XtraBars.Ribbon.RibbonForm
    {
     
        public MainForm()
        {
            InitializeComponent();
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            FormBorderStyle = FormBorderStyle.None;
            Left = Top = 0;
            Width = Screen.PrimaryScreen.WorkingArea.Width;
            Height = Screen.PrimaryScreen.WorkingArea.Height;
        }

        private void btnProduct_ItemClick(object sender, ItemClickEventArgs e)
        {
            Program.form = this.CheckExists(typeof(ProductForm));
            if (Program.form == null)
            {
                IsMdiContainer = true;
                Program.productForm = new ProductForm();
                Program.productForm.MdiParent = this;
                Program.productForm.Show();
            }
            else Program.form.Activate();
        }

        private Form CheckExists(Type ftype)
        {
            foreach (Form f in this.MdiChildren)
                if (f.GetType() == ftype)
                    return f;
            return null;
        }

        private void btnInvoice_ItemClick(object sender, ItemClickEventArgs e)
        {
            Program.form = this.CheckExists(typeof(InvoiceForm));
            if (Program.form == null)
            {
                IsMdiContainer = true;
                Program.invoiceForm = new InvoiceForm();
                Program.invoiceForm.MdiParent = this;
                Program.invoiceForm.Show();
            }
            else Program.form.Activate();
        }


        private void btnEmloyee_ItemClick(object sender, ItemClickEventArgs e)
        {
            Program.form = this.CheckExists(typeof(EmployeeForm));
            if (Program.form == null)
            {
                IsMdiContainer = true;
                Program.employeeForm = new EmployeeForm();
                Program.employeeForm.MdiParent = this;
                Program.employeeForm.Show();
            }
            else Program.form.Activate();
        }

        private void tvAvatar_EditValueChanged(object sender, EventArgs e)
        {

        }

     
        private void barButtonItem4_ItemClick(object sender, ItemClickEventArgs e)
        {
            Program.form = this.CheckExists(typeof(ImportCuponForm));
            if (Program.form == null)
            {
                IsMdiContainer = true;
                Program.importCuponForm = new ImportCuponForm();
                Program.importCuponForm.MdiParent = this;
                Program.importCuponForm.Show();
            }
            else Program.form.Activate();
        }

 

        private void btnEmployee_ItemClick(object sender, ItemClickEventArgs e)
        {
            Program.form = this.CheckExists(typeof(EmployeeForm));
            if (Program.form == null)
            {
                IsMdiContainer = true;
                Program.employeeForm = new EmployeeForm();
                Program.employeeForm.MdiParent = this;
                Program.employeeForm.Show();
            }
            else Program.form.Activate();
        }


        private void btnProfit_ItemClick(object sender, ItemClickEventArgs e)
        {

            Program.form = this.CheckExists(typeof(ProfitForm));
            if (Program.form == null)
            {
                IsMdiContainer = true;
                Program.profitForm = new ProfitForm();
                Program.profitForm.MdiParent = this;
                Program.profitForm.Show();
            }
            else Program.form.Activate();
        }

        private void btnRevenue_ItemClick(object sender, ItemClickEventArgs e)
        {
            Program.form = this.CheckExists(typeof(RevenueForm));
            if (Program.form == null)
            {
                IsMdiContainer = true;
                Program.revenueForm = new RevenueForm();
                Program.revenueForm.MdiParent = this;
                Program.revenueForm.Show();
            }
            else Program.form.Activate();
        }

        private void btnWareHouse1_ItemClick(object sender, ItemClickEventArgs e)
        {
            Program.form = this.CheckExists(typeof(InventoryForm));
            if (Program.form == null)
            {
                IsMdiContainer = true;
                Program.inventoryForm = new InventoryForm();
                Program.inventoryForm.MdiParent = this;
                Program.inventoryForm.Show();
            }
            else Program.form.Activate();
        }

        private void barButtonItem15_ItemClick(object sender, ItemClickEventArgs e)
        {

            DialogResult dr = MessageBox.Show("Are you sure you want to sign out?", "Warning", MessageBoxButtons.OKCancel);
            if (dr == DialogResult.OK)
            {
                Program.mainForm.Hide();
                Program.frmLogin = new LoginForm();
                Invoke((Action)(() => { Program.frmLogin.ShowDialog(); }));
                this.Close();
            }

        }
    }
}
