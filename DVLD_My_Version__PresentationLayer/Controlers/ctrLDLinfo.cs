using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DVLD_My_Version_BusinessLayer.Models;

namespace DVLD_My_Version__PresentationLayer.Controlers
{
    public partial class ctrLDLinfo : UserControl
    {
        public ctrLDLinfo()
        {
            InitializeComponent(); // لازم أول شيء
            _FillWithData();       // بعدين تعبي البيانات
        }

        private void _FillWithData()
        {
            int appID = clsPeople.CurrentValue;

            if (appID < 0)
            {
                MessageBox.Show("لا يوجد رقم طلب صالح.", "تنبيه", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            DataTable dt = clsApplication.GetPersonInfoByApplicationID(appID);

            if (dt == null || dt.Rows.Count == 0)
            {
                return;
            }

            DataRow row = dt.Rows[0];

            // التحقق من الأعمدة قبل العرض
            DLAppID.Text = row.Table.Columns.Contains("LDLAppID") ? row["LDLAppID"].ToString() : "N/A";
            DrivingClass.Text = row.Table.Columns.Contains("Driving Class") ? row["Driving Class"].ToString() : "N/A";
            PassedTests.Text = row.Table.Columns.Contains("Passed Tests") ? row["Passed Tests"].ToString() : "0";
        }
    }

}
