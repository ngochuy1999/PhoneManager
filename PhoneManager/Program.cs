﻿using DevExpress.Skins;
using DevExpress.UserSkins;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Net;
using System.Windows.Forms;

namespace PhoneManager
{
    static class Program
    {
        public static LoginForm frmLogin;
        public static SqlConnection conn = new SqlConnection();
        public static String connstr;
        public static SqlDataReader myReader;

        public static MainForm mainForm;
        public static ImportCuponForm importCuponForm;
        public static SubFormImportDetail subFormImportDetail;
        public static SubFormDetailPro subFormDetailPro;
        public static SubFormImageProduct subFormImageProduct;
        public static SubFormDescriptionPro subFormDescription; 
        public static Form form;
        public static ProductForm productForm;
        public static InvoiceForm invoiceForm;
        public static EmployeeForm employeeForm;
        public static ProfitForm profitForm;
        public static RevenueForm revenueForm;
        public static InventoryForm inventoryForm;


        public static AccountLogin accountLogin;

        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]

        static void Main()
        {
            ServicePointManager.SecurityProtocol = (SecurityProtocolType)3072;
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);

            BonusSkins.Register();
            Application.Run(new LoginForm());
        }

        public static int ExecSqlNonQuery(String strlenh, String connectionString, String errStr)
        {
            conn = new SqlConnection(connectionString);
            if (conn.State == ConnectionState.Closed) conn.Open();
            SqlCommand Sqlcmd = new SqlCommand(strlenh, conn);
            Sqlcmd.CommandType = CommandType.Text;
            Sqlcmd.CommandTimeout = 600;// 10 phut 
            try
            {
                Sqlcmd.ExecuteNonQuery();
                conn.Close();
                return 0;
            }
            catch (SqlException ex)
            {
                MessageBox.Show(errStr + "\n" + ex.Message);
                conn.Close();
                return ex.State; // trang thai lỗi gởi từ RAISERROR trong SQL Server qua
            }
        }

        public static void showToastSave()
        {
            CustomToast toast = new CustomToast("Save success!", System.Drawing.Color.FromArgb(12, 120, 120));
            toast.Show();
        }

        public static void showToast(String message, System.Drawing.Color bgColor)
        {
            CustomToast toast = new CustomToast(message, bgColor);
            toast.Show();
        }

        public static void showToastUpdate()
        {
            CustomToast toast = new CustomToast("Update success!", System.Drawing.Color.FromArgb(248, 43, 43));
            toast.Show();
        }

        public static void showToastDel()
        {
            CustomToast toast = new CustomToast("Delete item success!", System.Drawing.Color.FromArgb(168, 0, 0));
            toast.Show();
        }
        public static void showToastReload()
        {
            CustomToast toast = new CustomToast("All data updated", System.Drawing.Color.FromArgb(7, 82, 139));
            toast.Show();
        }
        public static int ExecSqlNonQuery(String strlenh)
        {
            if (conn.State == ConnectionState.Closed) conn.Open();
            SqlCommand Sqlcmd = new SqlCommand(strlenh, conn);
            Sqlcmd.CommandType = CommandType.Text;
            Sqlcmd.CommandTimeout = 600;// 10 phut 
            try
            {
                Sqlcmd.ExecuteNonQuery();

                return 0;

            }
            catch (SqlException ex)
            {
                MessageBox.Show(ex.Message);
                conn.Close();
                return ex.State; // trang thai lỗi gởi từ RAISERROR trong SQL Server qua
            }
        }

        public static System.Drawing.Image resizeImage(System.Drawing.Image imgToResize, System.Drawing.Size size)
        {
            return (System.Drawing.Image)(new Bitmap(imgToResize, size));
        }

        public static int KetNoi()
        {
            if (Program.conn != null && Program.conn.State == ConnectionState.Open)
                Program.conn.Close();
            try
            {
                Program.connstr = "Data Source=DESKTOP-IH5MME4;Initial Catalog=PhoneShop;Persist Security Info=True;User ID=sa;Password=123";
                Program.conn.ConnectionString = Program.connstr;
                Program.conn.Open();
                return 1;
            }

            catch (Exception e)
            {
                MessageBox.Show("Lỗi kết nối cơ sở dữ liệu.\nBạn xem lại user name và password.\n "
                    + e.Message, "", MessageBoxButtons.OK);
                return 0;
            }
        }

        public static SqlDataReader ExecSqlDataReader(String strLenh)
        {
            if (myReader != null)
                myReader.Close();
            SqlCommand sqlcmd = new SqlCommand(strLenh, Program.conn);
            sqlcmd.CommandType = CommandType.Text;
            //tối đa cho đợi 10p, tgian tính bằng s
            sqlcmd.CommandTimeout = 600;
            // Kiểm tra trạng thái đóng hay mở
            if (Program.conn.State == ConnectionState.Closed) Program.conn.Open();
            try
            {
                myReader = sqlcmd.ExecuteReader(); return myReader;

            }
            catch (SqlException ex)
            {
                Program.conn.Close();
                MessageBox.Show(ex.Message);
                return null;
            }
        }

        public static SqlDataReader ExecSqlDataReader1(String strLenh)
        {
            SqlDataReader myreader;
            SqlCommand sqlcmd = new SqlCommand(strLenh, Program.conn);
            sqlcmd.CommandType = CommandType.Text;
            //tối đa cho đợi 10p, tgian tính bằng s
            sqlcmd.CommandTimeout = 600;
            // Kiểm tra trạng thái đóng hay mở
            if (Program.conn.State == ConnectionState.Closed) Program.conn.Open();
            try
            {
                myreader = sqlcmd.ExecuteReader(); return myreader;

            }
            catch (SqlException ex)
            {
                Program.conn.Close();
                MessageBox.Show(ex.Message);
                return null;
            }
        }

        public static DataTable ExecSqlDataTable(String cmd)
        {
            // Trả về datable
            DataTable dt = new DataTable();
            //Nếu đang đóng thì mở
            if (Program.conn.State == ConnectionState.Closed) Program.conn.Open();
            // Muốn gọi csdl phải thông qua SqlDataAdapter
            SqlDataAdapter da = new SqlDataAdapter(cmd, conn);
            // Chạy lệnh cmd
            da.Fill(dt);
            conn.Close();
            return dt;
        }

    }
}
