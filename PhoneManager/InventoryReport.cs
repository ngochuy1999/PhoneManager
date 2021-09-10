using DevExpress.XtraReports.UI;
using System;
using System.Collections;
using System.ComponentModel;
using System.Drawing;

namespace PhoneManager
{
    public partial class InventoryReport : DevExpress.XtraReports.UI.XtraReport
    {
        public InventoryReport(Nullable<int> categoryId, Nullable<int> providerId)
        {
            InitializeComponent();
            phoneShopDataSet1.EnforceConstraints = false;
            this.sP_InventoryProductTableAdapter.Fill(this.phoneShopDataSet1.SP_InventoryProduct,
                categoryId, providerId);
        }

    }
}
