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
using DVLD_My_Version__PresentationLayer.Forms;
using System.IO;

namespace DVLD_My_Version__PresentationLayer.Controlers
{
    public partial class ctrAddOrUpdateUserInfo : UserControl
    {
        public ctrAddOrUpdateUserInfo()
        {
            InitializeComponent();
            FillCountries();
            txtFirstName.Focus();
        }

        private void FillCountries()
        {
            var dt = clsCountries.GetAllCountries();
            cbCountries.DataSource = dt;
            cbCountries.DisplayMember = "CountryName";
            cbCountries.ValueMember = "CountryID";
        }

        private void _FillFormWithPersonData()
        {
            DataTable personData = clsPeople.GetPersonByID(clsPeople.CurrentValue);

            if (personData.Rows.Count > 0)
            {
                DataRow row = personData.Rows[0];
                lblPersonID.Text = row["PersonID"].ToString();
                txtFirstName.Text = row["FirstName"].ToString();
                txtSecondName.Text = row["SecondName"].ToString();
                txtThirdName.Text = row["ThirdName"].ToString();
                txtLastName.Text = row["LastName"].ToString();
                txtNationalNumber.Text = row["NationalNo"].ToString();
                txtAddress.Text = row["Address"].ToString();
                txtPhoneNumber.Text = row["Phone"].ToString();
                txtEmail.Text = row["Email"].ToString();
                dtpDateOfBirth.Value = Convert.ToDateTime(row["DateOfBirth"]);

                int gender = Convert.ToInt32(row["Gendor"]);
                if (gender == 0) rbMale.Checked = true;
                else rbFamle.Checked = true;

                cbCountries.SelectedValue = Convert.ToInt32(row["NationalityCountryID"]);

                string imagePath = row["ImagePath"].ToString();
                pbPersonImage.ImageLocation = string.IsNullOrEmpty(imagePath) ? null : imagePath;
            }
            else
            {
                MessageBox.Show("لم يتم العثور على بيانات الشخص.", "خطأ", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private bool _UpdatePerson()
        {
            // جلب المسار القديم من قاعدة البيانات
            string oldImagePath = clsPeople.GetPersonImagePathByID(Convert.ToInt32(lblPersonID.Text));

            string sourcePath = pbPersonImage.ImageLocation;
            string fileName = Path.GetFileName(sourcePath);
            string targetFolder = @"C:\DVLD_Person_And_Users_Images";
            Directory.CreateDirectory(targetFolder);

            string targetPath = Path.Combine(targetFolder, fileName);

            // إذا كانت الصورة تغيّرت
            if (!string.Equals(sourcePath, oldImagePath, StringComparison.OrdinalIgnoreCase))
            {
                // حذف الصورة القديمة
                if (File.Exists(oldImagePath))
                    File.Delete(oldImagePath);

                // نسخ الصورة الجديدة
                File.Copy(sourcePath, targetPath, true);
            }

            clsPeople UpdatePerson = new clsPeople
            {
                PersonID = Convert.ToInt32(lblPersonID.Text),
                FirstName = txtFirstName.Text.Trim(),
                SecondName = txtSecondName.Text.Trim(),
                ThirdName = txtThirdName.Text.Trim(),
                LastName = txtLastName.Text.Trim(),
                NationalNumber = txtNationalNumber.Text.Trim(),
                Address = txtAddress.Text.Trim(),
                PhoneNumber = txtPhoneNumber.Text.Trim(),
                Email = txtEmail.Text.Trim(),
                NationalityCountryID = Convert.ToInt32(cbCountries.SelectedValue),
                ImagePath = targetPath,
                DateOfBirth = dtpDateOfBirth.Value,
                enGendor = rbMale.Checked ? clsPeople.Gendor.Male : clsPeople.Gendor.Female
            };

            return UpdatePerson.Update();
        }



        private bool _SavePerson()
        {
            if (cbCountries.SelectedValue == null)
            {
                MessageBox.Show("يرجى اختيار الدولة.");
                return false;
            }

            string sourcePath = pbPersonImage.ImageLocation;
            string fileName = Path.GetFileName(sourcePath);
            string targetFolder = @"C:\DVLD_Person_And_Users_Images";
            Directory.CreateDirectory(targetFolder); // يتأكد من وجود المجلد

            string targetPath = Path.Combine(targetFolder, fileName);
            File.Copy(sourcePath, targetPath, true); // نسخ مع استبدال لو الصورة موجودة

            // عرض الصورة من المسار الجديد



            clsPeople Addperson = new clsPeople
            {
                FirstName = txtFirstName.Text.Trim(),
                SecondName = txtSecondName.Text.Trim(),
                ThirdName = txtThirdName.Text.Trim(),
                LastName = txtLastName.Text.Trim(),
                NationalNumber = txtNationalNumber.Text.Trim(),
                Address = txtAddress.Text.Trim(),
                PhoneNumber = txtPhoneNumber.Text.Trim(),
                Email = txtEmail.Text.Trim(),
                NationalityCountryID = Convert.ToInt32(cbCountries.SelectedValue),
                ImagePath = targetPath,
                DateOfBirth = dtpDateOfBirth.Value,
                enGendor = rbMale.Checked ? clsPeople.Gendor.Male : clsPeople.Gendor.Female
            };

            Addperson.Add();
            return true;
        }

        private void btnSaveData_Click(object sender, EventArgs e)
        {
            if (clsPeople.IsAdd())
            {
                if (_SavePerson())
                {
                    MessageBox.Show("تم الحفظ بنجاح");
                    FindForm().Close();
                }
            }
            else if (!clsPeople.IsAdd())
            {
                if (_UpdatePerson())
                {
                    MessageBox.Show("تم التحديث بنجاح");
                    FindForm().Close();
                }
            }

        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("هل تريد إغلاق النموذج؟", "تأكيد", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                FindForm().Close();
            }
        }

        private void txtNationalNumber_TextChanged(object sender, EventArgs e)
        {
            if (clsPeople.IsAdd())
            {
                if (clsPeople.ExistsByNationalNo(txtNationalNumber.Text.Trim()))
                {
                    errorProvider1.SetError(txtNationalNumber, "الرقم مستخدم");
                }
                else
                {
                    errorProvider1.SetError(txtNationalNumber, "");
                }
            }
            else
            {
                return;
            }

        }

        private void LLSetImage_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            OpenFileDialog dlg = new OpenFileDialog
            {
                Filter = "Images|*.jpg;*.jpeg;*.png",
                Title = "اختر صورة"
            };

            if (dlg.ShowDialog() == DialogResult.OK)
            {
                pbPersonImage.ImageLocation = dlg.FileName;
            }
        }

        private void ctrAddOrUpdateUserInfo_Load(object sender, EventArgs e)
        {
            if (!clsPeople.IsAdd())
            {
                _FillFormWithPersonData();
            }
        }
    }
}
