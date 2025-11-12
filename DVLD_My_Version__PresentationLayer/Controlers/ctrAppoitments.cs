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
using DVLD_My_Version_BusinessLayer;

namespace DVLD_My_Version__PresentationLayer.Controlers
{
    public partial class ctrAppoitments : UserControl
    {

        public ctrAppoitments()
        {
            InitializeComponent();
            _FillctrWithInfo();
            _FillReTakeBox();
            _SaveMode();

        }

        private void _SaveMode()
        {
            if (clsTestAppointment._Mode == clsTestAppointment.enMode.Add)
            {
                btnSave.Text = "Save";

            }
            else if (clsTestAppointment._Mode == clsTestAppointment.enMode.Update)
            {
                btnSave.Text = "Update";

            }
        }

        private void _FillctrWithInfo()
        {
            if (this.DesignMode)
                return; // لا ننفذ أي كود في وضع التصميم

            int value = clsPeople.CurrentValue;

            // جلب بيانات الشخص بناءً على القيمة الحالية
            DataTable dt = clsApplication.GetPersonInfoByApplicationID(value);

            // إذا لم يكن هناك أي بيانات
            if (dt == null || dt.Rows.Count == 0)
                return;

            // جلب أول صف من البيانات
            DataRow row = dt.Rows[0];

            LDLAPPID.Text = row["LDLAppID"]?.ToString() ?? "[????]";
            DClass.Text = row["Driving Class"]?.ToString() ?? "[????]";
            LDLAppName.Text = row["FULL Name"]?.ToString() ?? "[????]";
            Trail.Text = row["Passed Tests"]?.ToString() ?? "[????]";
            Fees.Text = row["PaidFees"]?.ToString() ?? "[????]";
            TotalFees.Text = row["PaidFees"]?.ToString() ?? "[????]";


        }

        private void _FillReTakeBox()
        {
            int ReTake = clsTests.CheckIsLocked(clsPeople.CurrentValue);
            int Number = 0;
            int Counter = 0;
            if (ReTake > 0)
            {
                for (int i = 0; i < ReTake; i++)
                {
                    Counter = Counter + 5;
                }

                RTestFees.Text = Counter.ToString();
                Number = Convert.ToInt16(TotalFees.Text);
                Number += Counter;
                TotalFees.Text = Number.ToString();
            }
            else
            {
                gbRetakeTest.Enabled = false;
            }
        }

        private void AddTestAppointment()
        {
            // التحقق من القيم قبل التحويل
            if (!int.TryParse(LDLAPPID.Text, out int localAppID))
            {

                return;
            }

            if (!decimal.TryParse(Fees.Text, out decimal paidFees))
            {
                MessageBox.Show("الرسوم غير صالحة!");
                return;
            }

            int testTypeID = clsTests.GetTestTypeIDFromName(clsTestAppointment.TestTypesStrings());
            int createdByUserID = clsUsers.GetUserIDFromNameAndPassword(
                                      Properties.Settings.Default.SavedUserName,
                                      Properties.Settings.Default.SavedPassword);



            // إنشاء الكائن
            clsTestAppointment TestAppointment = new clsTestAppointment();

            TestAppointment.LocalDrivingLicenseApplicationID = localAppID;
            TestAppointment.TestTypeID = testTypeID;
            TestAppointment.AppointmentDate = dtAppointemnt.Value;
            TestAppointment.PaidFees = paidFees;
            TestAppointment.CreatedByUserID = createdByUserID;
            TestAppointment.IsLocked = false;
            TestAppointment.RetakeTestApplicationID = null;

            // الحفظ
            if (TestAppointment.Save())
                MessageBox.Show("تمت إضافة موعد الاختبار بنجاح ✅");
            else
                MessageBox.Show("فشل في إضافة موعد الاختبار ❌");
        }

        private void UpdateAppointment()
        {


            clsTestAppointment testAppointment = new clsTestAppointment
            {
                LocalDrivingLicenseApplicationID = Convert.ToInt32(LDLAPPID.Text),
                AppointmentDate = dtAppointemnt.Value

            };

            if (testAppointment.UpdateTestAppointmentDate())
                MessageBox.Show("Updated Is Succcfuly!");
            else
                MessageBox.Show("Updated Failed");
        }


        private void btnSave_Click(object sender, EventArgs e)
        {
            if (clsTestAppointment._Mode == clsTestAppointment.enMode.Add)
            {
                btnSave.Text = "Save";
                AddTestAppointment();
            }
            else if (clsTestAppointment._Mode == clsTestAppointment.enMode.Update)
            {
                btnSave.Text = "Update";
                UpdateAppointment();
            }
        }
    }
}
