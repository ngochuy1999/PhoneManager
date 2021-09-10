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
    public partial class EmployeeForm : DevExpress.XtraEditors.XtraForm
    {
        private bool isAdd = false;
        public EmployeeForm()
        {
            InitializeComponent();
        }

        private void employeeBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.employeeBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.phoneShopDataSet);

        }

        private void EmployeeForm_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'phoneShopDataSet.Role' table. You can move, or remove it, as needed.
            this.roleTableAdapter.Fill(this.phoneShopDataSet.Role);
            // TODO: This line of code loads data into the 'phoneShopDataSet.Account' table. You can move, or remove it, as needed.
            this.accountTableAdapter.Fill(this.phoneShopDataSet.Account);
            // TODO: This line of code loads data into the 'phoneShopDataSet.Account' table.You can move, or remove it, as needed.
            this.employeeTableAdapter.Fill(this.phoneShopDataSet.Employee);
        }

        private void loadData()
        {
            /// TODO: This line of code loads data into the 'phoneShopDataSet.Account' table. You can move, or remove it, as needed.
            this.accountTableAdapter.Fill(this.phoneShopDataSet.Account);
            // TODO: This line of code loads data into the 'phoneShopDataSet.Account' table.You can move, or remove it, as needed.
            this.employeeTableAdapter.Fill(this.phoneShopDataSet.Employee);
            setAvatar();
        }
        private void avatarTextEdit_EditValueChanged(object sender, EventArgs e)
        {

        }

        private void setAvatar()
        {
            if (String.IsNullOrEmpty(avatarTextEdit.Text))
            {
                picAvater.Image = Properties.Resources.no_image;
            }
            else
            {
                picAvater.ImageLocation = avatarTextEdit.Text;
            }
        }

        private void btnAddProvider_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            isAdd = true;
            accountBindingSource.AddNew();
            employeeBindingSource.AddNew();
        }

        private void btnCancelAddProvider_Click(object sender, EventArgs e)
        {
            try
            {
                isAdd = false;
                this.Validate();
                this.accountBindingSource.CancelEdit();
                this.employeeBindingSource.CancelEdit();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error " + ex.Message, "Error", MessageBoxButtons.OK);
            }
        }

        private void btnSaveAddProvider_Click(object sender, EventArgs e)
        {
            if (isAdd)
            {
                try
                {
                    String birthday = null, beginDate = null, endDate = null;
                    if (birthdayDateEdit.Text.Trim() == null)
                        birthday = "'null'";
                    else
                        birthday = "'" + birthdayDateEdit.EditValue.ToString() + "'";

                    if (String.IsNullOrEmpty(dateBeginDateEdit.Text))
                        beginDate = "'null'";
                    else
                        beginDate = "'" + dateBeginDateEdit.EditValue.ToString() + "'";

                    if (String.IsNullOrEmpty(dateEndDateEdit.Text))
                        endDate = "'null'";
                    else
                        endDate = "'" + dateEndDateEdit.EditValue.ToString() + "'";

                    String sql = "EXEC SP_AddEmployee N'"
                        + firstNameTextEdit.Text.Trim() + "', N'"
                        + lastNameTextEdit.Text.Trim() + "', N'"
                        + phoneTextEdit.Text.Trim() + "', N'"
                        + addressTextEdit.Text.Trim() + "', N'"
                        + avatarTextEdit.Text.Trim() + "', "
                        + birthday + ", "
                        + beginDate + ","
                        + endDate + ", "
                        + Convert.ToInt32(isWorkingSpinEdit.Value) + ", N'"
                        + emailTextEdit.Text.Trim() + "',"
                        + roleIdSpinEdit.Text.Trim() + ", N'"
                        + passwordTextEdit.Text.Trim() + "', N'"
                        + usernameTextEdit.Text.Trim() + "'";
                    Program.myReader = Program.ExecSqlDataReader(sql);
                    if (Program.myReader == null) return;
                    Program.myReader.Read();
                    if (Program.myReader == null) return;
                    int statusEdit = Program.myReader.GetInt32(0);
                    String message = Program.myReader.GetString(1);
                    MessageBox.Show(statusEdit + " " + message, "THÔNG BÁO", MessageBoxButtons.OK);
                    Program.showToastSave();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error " + ex.Message, "Error", MessageBoxButtons.OK);
                }
            }
            else
            {
                try
                {

                    //String birthday = null, beginDate = null, endDate = null;
                    //if (birthdayDateEdit.Text.Trim() == null)
                    //    birthday = "'null'";
                    //else
                    //    birthday = "'" + birthdayDateEdit.EditValue.ToString() + "'";

                    //if (String.IsNullOrEmpty(dateBeginDateEdit.Text))
                    //    beginDate = "'null'";
                    //else
                    //    beginDate = "'" + dateBeginDateEdit.EditValue.ToString() + "'";

                    //if (String.IsNullOrEmpty(dateEndDateEdit.Text))
                    //    endDate = "'null'";
                    //else
                    //    endDate = "'" + dateEndDateEdit.EditValue.ToString() + "'";

                    //String sql = "EXEC SP_UpdateEmployee "
                    //    + Convert.ToInt32(idSpinEdit.Value) + ", N'"
                    //    + firstNameTextEdit.Text.Trim() + "', N'"
                    //    + lastNameTextEdit.Text.Trim() + "', N'"
                    //    + phoneTextEdit.Text.Trim() + "', N'"
                    //    + addressTextEdit.Text.Trim() + "', N'"
                    //    + avatarTextEdit.Text.Trim() + "', "
                    //    + birthday + ", "
                    //    + beginDate + ","
                    //    + endDate + ", "
                    //    + Convert.ToInt32(isWorkingSpinEdit.Value) + ", N'"
                    //    + emailTextEdit.Text.Trim() + "',"
                    //    + roleIdSpinEdit.Text.Trim() + ", N'"
                    //    + passwordTextEdit.Text.Trim() + "', N'"
                    //    + usernameTextEdit.Text.Trim();
                    //MessageBox.Show(sql, "sql", MessageBoxButtons.OK);
                    //Program.myReader = Program.ExecSqlDataReader(sql);
                    //if (Program.myReader == null) return;
                    //Program.myReader.Read();
                    //if (Program.myReader == null) return;
                    //int statusEdit = Program.myReader.GetInt32(0);
                    //String message = Program.myReader.GetString(1);
                    //MessageBox.Show(statusEdit + " " + message, "THÔNG BÁO", MessageBoxButtons.OK);
                    //Program.showToastUpdate();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error " + ex.Message, "Error", MessageBoxButtons.OK);
                }
            }
        }

        private void btnDelProvider_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (employeeBindingSource.Count == 0)
            {
                MessageBox.Show("Không có employee để xóa!", "THÔNG BÁO", MessageBoxButtons.OK);
                return;
            }
            else
            {
                if (MessageBox.Show("Bạn có chắc chắn muốn xóa " + ((DataRowView)this.employeeBindingSource.Current).Row["firstName"].ToString() + "?", "", MessageBoxButtons.YesNo) == DialogResult.Yes)
                {
                    try
                    {
                        String sql = "EXEC SP_DelEmployee " + Convert.ToInt32(idSpinEdit.Value);
                        Program.myReader = Program.ExecSqlDataReader(sql);
                        loadData();
                        Program.showToastDel();
                    }
                    catch (Exception)
                    {
                        MessageBox.Show("Error ", "Error", MessageBoxButtons.OK);
                    }

                }
            }
        }

        private void btnReloadProvider_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            isAdd = false;
            loadData();
            Program.showToastReload();
        }

        private void btnCloseForm_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            this.Close();
        }

        private void roleNameComboBox_SelectionChangeCommitted(object sender, EventArgs e)
        {
            if (roleBindingSource.Position != -1)
            {
                roleIdSpinEdit.Text = roleNameComboBox.SelectedValue.ToString();
            }
        }
    }
}