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
using DVLD_My_Version__PresentationLayer.Properties;
using DVLD_My_Version_BusinessLayer;

namespace DVLD_My_Version__PresentationLayer.Controlers
{
    public partial class ctrTest : UserControl
    {
        public ctrTest()
        {
            InitializeComponent();
            _ChangePictureWithTestType();
            _FillctrWithInfo();
        }

        private enum _enTestMode
        {
            Failed = 2,
            Passed = 3
        }

        private _enTestMode _Mode = _enTestMode.Failed;

        private int n = clsTestAppointment.SelectTestAppoimentIDByLDLAppID(clsPeople.CurrentValue);


        private void _ChangePictureWithTestType()
        {
            if (clsTestAppointment.TestsTypes == clsTestAppointment.enTestsTypes.VisionTest)
            {
                pbTestTypePicture.Image = Resources.Vision_512;
                lblTestTitle.Text = "Vision Test";
                gbTitle.Text = "Vision Test";
            }
            else if (clsTestAppointment.TestsTypes == clsTestAppointment.enTestsTypes.WritenTest)
            {
                pbTestTypePicture.Image = Resources.Written_Test_512;
                lblTestTitle.Text = "Writen Test";
                gbTitle.Text = "Writen Test";
            }
            else if (clsTestAppointment.TestsTypes == clsTestAppointment.enTestsTypes.StreetTest)
            {
                pbTestTypePicture.Image = Resources.Schedule_Test_321;
                lblTestTitle.Text = "Street Test";
                gbTitle.Text = "Street Test";
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
            Date.Text = clsTestAppointment.GetAppointmentDate(value)?.ToString() ?? "[????]";

        }

        private void _AddNewTest()
        {
            int Value = clsPeople.CurrentValue;
            bool Result = rbPassed.Checked ? true : false;

            if (rbPassed.Checked == false && rbPassed.Checked == false)
                MessageBox.Show("Error", "You Can't Add Test Before Check Pass Or Fail", MessageBoxButtons.OK);

            if (Value > 0 && Result != false)
            {
                clsTests Test = new clsTests(clsTestAppointment.SelectTestAppoimentIDByLDLAppID(Value), Result, txtNote.Text, clsUsers.GetUserIDFromNameAndPassword(Properties.Settings.Default.SavedUserName, Properties.Settings.Default.SavedPassword));
                TestID.Text = Test.CreateNewTest().ToString();
            }


        }

        private int _TestModePassedOrFailed()
        {
            if (rbPassed.Checked)
                return (int)_enTestMode.Passed;
            else if (rbFail.CanFocus)
                return (int)_enTestMode.Failed;

            return (int)_enTestMode.Failed;

        }

        private void btnSave_Click(object sender, EventArgs e)
        {

            if (clsTestAppointment.UpdateLockedTestAppointment(clsPeople.CurrentValue))
            {
                _AddNewTest();
                clsApplication.UpdateApplicationStatus(clsPeople.CurrentValue, _TestModePassedOrFailed());
            }
            MessageBox.Show("✅ تم حفظ الاختبار بنجاح!", "نجاح", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }


    }
}
