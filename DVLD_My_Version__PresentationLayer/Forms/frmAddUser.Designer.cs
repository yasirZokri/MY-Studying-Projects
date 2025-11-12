namespace DVLD_My_Version__PresentationLayer.Forms
{
    partial class frmAddUser
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.pgAddUser = new System.Windows.Forms.TabPage();
            this.txtUserName = new System.Windows.Forms.TextBox();
            this.txtAgainPassword = new System.Windows.Forms.TextBox();
            this.txtPassword = new System.Windows.Forms.TextBox();
            this.lblPersonID = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.isActive = new System.Windows.Forms.CheckBox();
            this.pgFindUser = new System.Windows.Forms.TabPage();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.PersonID = new System.Windows.Forms.Label();
            this.PersonName = new System.Windows.Forms.Label();
            this.Address = new System.Windows.Forms.Label();
            this.Email = new System.Windows.Forms.Label();
            this.Gendor = new System.Windows.Forms.Label();
            this.NationalNo = new System.Windows.Forms.Label();
            this.label33 = new System.Windows.Forms.Label();
            this.label32 = new System.Windows.Forms.Label();
            this.label31 = new System.Windows.Forms.Label();
            this.DateOfBirht = new System.Windows.Forms.Label();
            this.Phone = new System.Windows.Forms.Label();
            this.Country = new System.Windows.Forms.Label();
            this.Picture = new System.Windows.Forms.PictureBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label2 = new System.Windows.Forms.Label();
            this.cbPeopleColumns = new System.Windows.Forms.ComboBox();
            this.txtSearchPerson = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.btnSearch = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.tcFindUserInfoAndConectedWithPerson = new System.Windows.Forms.TabControl();
            this.button1 = new System.Windows.Forms.Button();
            this.Save = new System.Windows.Forms.Button();
            this.pgAddUser.SuspendLayout();
            this.pgFindUser.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Picture)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.tcFindUserInfoAndConectedWithPerson.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.CadetBlue;
            this.label1.Location = new System.Drawing.Point(303, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(289, 46);
            this.label1.TabIndex = 0;
            this.label1.Text = "Add New User";
            // 
            // pgAddUser
            // 
            this.pgAddUser.Controls.Add(this.isActive);
            this.pgAddUser.Controls.Add(this.label13);
            this.pgAddUser.Controls.Add(this.label12);
            this.pgAddUser.Controls.Add(this.label11);
            this.pgAddUser.Controls.Add(this.label10);
            this.pgAddUser.Controls.Add(this.lblPersonID);
            this.pgAddUser.Controls.Add(this.txtPassword);
            this.pgAddUser.Controls.Add(this.txtAgainPassword);
            this.pgAddUser.Controls.Add(this.txtUserName);
            this.pgAddUser.Location = new System.Drawing.Point(4, 29);
            this.pgAddUser.Name = "pgAddUser";
            this.pgAddUser.Padding = new System.Windows.Forms.Padding(3);
            this.pgAddUser.Size = new System.Drawing.Size(983, 462);
            this.pgAddUser.TabIndex = 1;
            this.pgAddUser.Text = "AddUser";
            this.pgAddUser.UseVisualStyleBackColor = true;
            // 
            // txtUserName
            // 
            this.txtUserName.Location = new System.Drawing.Point(288, 162);
            this.txtUserName.Name = "txtUserName";
            this.txtUserName.Size = new System.Drawing.Size(170, 26);
            this.txtUserName.TabIndex = 0;
            // 
            // txtAgainPassword
            // 
            this.txtAgainPassword.Location = new System.Drawing.Point(288, 326);
            this.txtAgainPassword.Name = "txtAgainPassword";
            this.txtAgainPassword.Size = new System.Drawing.Size(170, 26);
            this.txtAgainPassword.TabIndex = 2;
            // 
            // txtPassword
            // 
            this.txtPassword.Location = new System.Drawing.Point(288, 244);
            this.txtPassword.Name = "txtPassword";
            this.txtPassword.Size = new System.Drawing.Size(170, 26);
            this.txtPassword.TabIndex = 3;
            // 
            // lblPersonID
            // 
            this.lblPersonID.AutoSize = true;
            this.lblPersonID.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPersonID.Location = new System.Drawing.Point(306, 86);
            this.lblPersonID.Name = "lblPersonID";
            this.lblPersonID.Size = new System.Drawing.Size(59, 20);
            this.lblPersonID.TabIndex = 4;
            this.lblPersonID.Text = "[????]";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.ForeColor = System.Drawing.Color.DarkCyan;
            this.label10.Location = new System.Drawing.Point(54, 86);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(135, 29);
            this.label10.TabIndex = 5;
            this.label10.Text = "Person ID:";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.Location = new System.Drawing.Point(54, 158);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(151, 29);
            this.label11.TabIndex = 6;
            this.label11.Text = "User Name:";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.Location = new System.Drawing.Point(54, 322);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(208, 29);
            this.label12.TabIndex = 7;
            this.label12.Text = "Password Again:";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label13.Location = new System.Drawing.Point(54, 240);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(135, 29);
            this.label13.TabIndex = 8;
            this.label13.Text = "Password:";
            // 
            // isActive
            // 
            this.isActive.AutoSize = true;
            this.isActive.CheckAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.isActive.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.isActive.Location = new System.Drawing.Point(288, 380);
            this.isActive.Name = "isActive";
            this.isActive.Size = new System.Drawing.Size(104, 24);
            this.isActive.TabIndex = 10;
            this.isActive.Text = "Is Active";
            this.isActive.UseVisualStyleBackColor = true;
            // 
            // pgFindUser
            // 
            this.pgFindUser.Controls.Add(this.button2);
            this.pgFindUser.Controls.Add(this.groupBox1);
            this.pgFindUser.Controls.Add(this.groupBox2);
            this.pgFindUser.Location = new System.Drawing.Point(4, 29);
            this.pgFindUser.Name = "pgFindUser";
            this.pgFindUser.Padding = new System.Windows.Forms.Padding(3);
            this.pgFindUser.Size = new System.Drawing.Size(983, 462);
            this.pgFindUser.TabIndex = 0;
            this.pgFindUser.Text = "FindUser";
            this.pgFindUser.UseVisualStyleBackColor = true;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.Picture);
            this.groupBox2.Controls.Add(this.Country);
            this.groupBox2.Controls.Add(this.Phone);
            this.groupBox2.Controls.Add(this.DateOfBirht);
            this.groupBox2.Controls.Add(this.label31);
            this.groupBox2.Controls.Add(this.label32);
            this.groupBox2.Controls.Add(this.label33);
            this.groupBox2.Controls.Add(this.NationalNo);
            this.groupBox2.Controls.Add(this.Gendor);
            this.groupBox2.Controls.Add(this.Email);
            this.groupBox2.Controls.Add(this.Address);
            this.groupBox2.Controls.Add(this.PersonName);
            this.groupBox2.Controls.Add(this.PersonID);
            this.groupBox2.Controls.Add(this.label9);
            this.groupBox2.Controls.Add(this.label8);
            this.groupBox2.Controls.Add(this.label7);
            this.groupBox2.Controls.Add(this.label6);
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox2.Location = new System.Drawing.Point(22, 117);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(934, 268);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Person Information";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(7, 54);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(94, 20);
            this.label4.TabIndex = 0;
            this.label4.Text = "Person ID:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(7, 219);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(80, 20);
            this.label5.TabIndex = 1;
            this.label5.Text = "Address:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(7, 186);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(58, 20);
            this.label6.TabIndex = 2;
            this.label6.Text = "Email:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(7, 153);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(74, 20);
            this.label7.TabIndex = 3;
            this.label7.Text = "Gendor:";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(7, 120);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(102, 20);
            this.label8.TabIndex = 4;
            this.label8.Text = "National No";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(7, 87);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(60, 20);
            this.label9.TabIndex = 5;
            this.label9.Text = "Name:";
            // 
            // PersonID
            // 
            this.PersonID.AutoSize = true;
            this.PersonID.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PersonID.Location = new System.Drawing.Point(115, 54);
            this.PersonID.Name = "PersonID";
            this.PersonID.Size = new System.Drawing.Size(36, 20);
            this.PersonID.TabIndex = 6;
            this.PersonID.Text = "___";
            // 
            // PersonName
            // 
            this.PersonName.AutoSize = true;
            this.PersonName.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PersonName.ForeColor = System.Drawing.Color.DarkCyan;
            this.PersonName.Location = new System.Drawing.Point(115, 87);
            this.PersonName.Name = "PersonName";
            this.PersonName.Size = new System.Drawing.Size(39, 20);
            this.PersonName.TabIndex = 7;
            this.PersonName.Text = "___";
            // 
            // Address
            // 
            this.Address.AutoSize = true;
            this.Address.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Address.Location = new System.Drawing.Point(115, 219);
            this.Address.Name = "Address";
            this.Address.Size = new System.Drawing.Size(36, 20);
            this.Address.TabIndex = 8;
            this.Address.Text = "___";
            // 
            // Email
            // 
            this.Email.AutoSize = true;
            this.Email.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Email.Location = new System.Drawing.Point(115, 185);
            this.Email.Name = "Email";
            this.Email.Size = new System.Drawing.Size(36, 20);
            this.Email.TabIndex = 9;
            this.Email.Text = "___";
            // 
            // Gendor
            // 
            this.Gendor.AutoSize = true;
            this.Gendor.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Gendor.Location = new System.Drawing.Point(115, 152);
            this.Gendor.Name = "Gendor";
            this.Gendor.Size = new System.Drawing.Size(36, 20);
            this.Gendor.TabIndex = 10;
            this.Gendor.Text = "___";
            // 
            // NationalNo
            // 
            this.NationalNo.AutoSize = true;
            this.NationalNo.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.NationalNo.Location = new System.Drawing.Point(118, 120);
            this.NationalNo.Name = "NationalNo";
            this.NationalNo.Size = new System.Drawing.Size(36, 20);
            this.NationalNo.TabIndex = 11;
            this.NationalNo.Text = "___";
            // 
            // label33
            // 
            this.label33.AutoSize = true;
            this.label33.Location = new System.Drawing.Point(461, 120);
            this.label33.Name = "label33";
            this.label33.Size = new System.Drawing.Size(117, 20);
            this.label33.TabIndex = 18;
            this.label33.Text = "Date of Birth:";
            // 
            // label32
            // 
            this.label32.AutoSize = true;
            this.label32.Location = new System.Drawing.Point(461, 186);
            this.label32.Name = "label32";
            this.label32.Size = new System.Drawing.Size(76, 20);
            this.label32.TabIndex = 19;
            this.label32.Text = "Country:";
            // 
            // label31
            // 
            this.label31.AutoSize = true;
            this.label31.Location = new System.Drawing.Point(461, 153);
            this.label31.Name = "label31";
            this.label31.Size = new System.Drawing.Size(65, 20);
            this.label31.TabIndex = 20;
            this.label31.Text = "Phone:";
            // 
            // DateOfBirht
            // 
            this.DateOfBirht.AutoSize = true;
            this.DateOfBirht.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DateOfBirht.Location = new System.Drawing.Point(584, 120);
            this.DateOfBirht.Name = "DateOfBirht";
            this.DateOfBirht.Size = new System.Drawing.Size(36, 20);
            this.DateOfBirht.TabIndex = 21;
            this.DateOfBirht.Text = "___";
            // 
            // Phone
            // 
            this.Phone.AutoSize = true;
            this.Phone.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Phone.ForeColor = System.Drawing.Color.DarkCyan;
            this.Phone.Location = new System.Drawing.Point(581, 152);
            this.Phone.Name = "Phone";
            this.Phone.Size = new System.Drawing.Size(39, 20);
            this.Phone.TabIndex = 22;
            this.Phone.Text = "___";
            // 
            // Country
            // 
            this.Country.AutoSize = true;
            this.Country.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Country.Location = new System.Drawing.Point(581, 185);
            this.Country.Name = "Country";
            this.Country.Size = new System.Drawing.Size(36, 20);
            this.Country.TabIndex = 23;
            this.Country.Text = "___";
            // 
            // Picture
            // 
            this.Picture.Image = global::DVLD_My_Version__PresentationLayer.Properties.Resources.Male_512;
            this.Picture.Location = new System.Drawing.Point(757, 97);
            this.Picture.Name = "Picture";
            this.Picture.Size = new System.Drawing.Size(132, 119);
            this.Picture.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.Picture.TabIndex = 24;
            this.Picture.TabStop = false;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnSearch);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.txtSearchPerson);
            this.groupBox1.Controls.Add(this.cbPeopleColumns);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(22, 14);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(934, 80);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Fillter";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(7, 35);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(84, 20);
            this.label2.TabIndex = 0;
            this.label2.Text = "Fillter By:";
            // 
            // cbPeopleColumns
            // 
            this.cbPeopleColumns.BackColor = System.Drawing.SystemColors.MenuBar;
            this.cbPeopleColumns.FormattingEnabled = true;
            this.cbPeopleColumns.Location = new System.Drawing.Point(119, 32);
            this.cbPeopleColumns.Name = "cbPeopleColumns";
            this.cbPeopleColumns.Size = new System.Drawing.Size(186, 28);
            this.cbPeopleColumns.TabIndex = 1;
            // 
            // txtSearchPerson
            // 
            this.txtSearchPerson.Location = new System.Drawing.Point(563, 32);
            this.txtSearchPerson.Name = "txtSearchPerson";
            this.txtSearchPerson.Size = new System.Drawing.Size(191, 26);
            this.txtSearchPerson.TabIndex = 4;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(402, 35);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(129, 20);
            this.label3.TabIndex = 5;
            this.label3.Text = "search Person:";
            // 
            // btnSearch
            // 
            this.btnSearch.BackgroundImage = global::DVLD_My_Version__PresentationLayer.Properties.Resources.SearchPerson;
            this.btnSearch.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnSearch.Location = new System.Drawing.Point(782, 28);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(39, 34);
            this.btnSearch.TabIndex = 6;
            this.btnSearch.UseVisualStyleBackColor = true;
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // button2
            // 
            this.button2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.button2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.Image = global::DVLD_My_Version__PresentationLayer.Properties.Resources.Next_32;
            this.button2.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button2.Location = new System.Drawing.Point(834, 407);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(131, 49);
            this.button2.TabIndex = 3;
            this.button2.Text = "Next";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // tcFindUserInfoAndConectedWithPerson
            // 
            this.tcFindUserInfoAndConectedWithPerson.Controls.Add(this.pgFindUser);
            this.tcFindUserInfoAndConectedWithPerson.Controls.Add(this.pgAddUser);
            this.tcFindUserInfoAndConectedWithPerson.Location = new System.Drawing.Point(-3, 77);
            this.tcFindUserInfoAndConectedWithPerson.Name = "tcFindUserInfoAndConectedWithPerson";
            this.tcFindUserInfoAndConectedWithPerson.SelectedIndex = 0;
            this.tcFindUserInfoAndConectedWithPerson.Size = new System.Drawing.Size(991, 495);
            this.tcFindUserInfoAndConectedWithPerson.TabIndex = 1;
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Image = global::DVLD_My_Version__PresentationLayer.Properties.Resources.Close_32;
            this.button1.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button1.Location = new System.Drawing.Point(656, 578);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(131, 49);
            this.button1.TabIndex = 2;
            this.button1.Text = "Cancle";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // Save
            // 
            this.Save.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Save.Image = global::DVLD_My_Version__PresentationLayer.Properties.Resources.Save_32;
            this.Save.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.Save.Location = new System.Drawing.Point(835, 578);
            this.Save.Name = "Save";
            this.Save.Size = new System.Drawing.Size(131, 49);
            this.Save.TabIndex = 3;
            this.Save.Text = "Save";
            this.Save.UseVisualStyleBackColor = true;
            this.Save.Click += new System.EventHandler(this.Save_Click);
            // 
            // frmAddUser
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(986, 639);
            this.Controls.Add(this.Save);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.tcFindUserInfoAndConectedWithPerson);
            this.Controls.Add(this.label1);
            this.Name = "frmAddUser";
            this.Text = "frmAddUser";
            this.pgAddUser.ResumeLayout(false);
            this.pgAddUser.PerformLayout();
            this.pgFindUser.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Picture)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.tcFindUserInfoAndConectedWithPerson.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TabPage pgAddUser;
        private System.Windows.Forms.CheckBox isActive;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label lblPersonID;
        private System.Windows.Forms.TextBox txtPassword;
        private System.Windows.Forms.TextBox txtAgainPassword;
        private System.Windows.Forms.TextBox txtUserName;
        private System.Windows.Forms.TabPage pgFindUser;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtSearchPerson;
        private System.Windows.Forms.ComboBox cbPeopleColumns;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.PictureBox Picture;
        private System.Windows.Forms.Label Country;
        private System.Windows.Forms.Label Phone;
        private System.Windows.Forms.Label DateOfBirht;
        private System.Windows.Forms.Label label31;
        private System.Windows.Forms.Label label32;
        private System.Windows.Forms.Label label33;
        private System.Windows.Forms.Label NationalNo;
        private System.Windows.Forms.Label Gendor;
        private System.Windows.Forms.Label Email;
        private System.Windows.Forms.Label Address;
        private System.Windows.Forms.Label PersonName;
        private System.Windows.Forms.Label PersonID;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TabControl tcFindUserInfoAndConectedWithPerson;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button Save;
    }
}