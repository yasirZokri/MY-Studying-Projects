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
    public partial class ctrApplicationBasicInfo : UserControl
    {
        public ctrApplicationBasicInfo()
        {
            InitializeComponent();
            _FillWithApplicationInfo();
        }

        private void _FillWithApplicationInfo()
        {
            DataTable ApplicationInfo = clsApplication.GetPersonInfoByApplicationID(clsPeople.CurrentValue);
            if (ApplicationInfo.Rows.Count > 0)
            {
                DataRow row = ApplicationInfo.Rows[0];

                if (row != null)
                {
                    // بيانات الشخص
                    lblApplicationPersonID.Text = row["PersonID"].ToString();
                    lblPersonName.Text = row["FULL Name"].ToString();
                    lblApplicationType.Text = row["Driving Class"].ToString();

                    // البيانات المالية
                    lblApplicationFees.Text = row["PaidFees"].ToString();

                    // حالة الطلب
                    lblStatus.Text = row["Passed Tests"].ToString(); // أو أي عمود يصف الحالة
                    lblStatusDate.Text = DateTime.Now.ToString("yyyy/MM/dd"); // أو إذا لديك تاريخ حالة في الـ SELECT

                    // معلومات إضافية
                    lblTodayDate.Text = DateTime.Now.ToString("yyyy/MM/dd");
                    lblCreatedBy.Text = Properties.Settings.Default.SavedUserName;
                }


            }
        }
    }
}
