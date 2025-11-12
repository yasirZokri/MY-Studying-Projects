namespace DVLD_My_Version__PresentationLayer.Controlers
{
    partial class ctrSearchPerson
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.button2 = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnSearch = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.txtSearchPerson = new System.Windows.Forms.TextBox();
            this.cbPeopleColumns = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.Picture = new System.Windows.Forms.PictureBox();
            this.Country = new System.Windows.Forms.Label();
            this.Phone = new System.Windows.Forms.Label();
            this.DateOfBirht = new System.Windows.Forms.Label();
            this.label31 = new System.Windows.Forms.Label();
            this.label32 = new System.Windows.Forms.Label();
            this.label33 = new System.Windows.Forms.Label();
            this.NationalNo = new System.Windows.Forms.Label();
            this.Gendor = new System.Windows.Forms.Label();
            this.Email = new System.Windows.Forms.Label();
            this.Address = new System.Windows.Forms.Label();
            this.PersonName = new System.Windows.Forms.Label();
            this.PersonID = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.Save = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Picture)).BeginInit();
            this.SuspendLayout();
            // 
            // button2
            // 
            this.button2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.button2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.Image = global::DVLD_My_Version__PresentationLayer.Properties.Resources.Next_32;
            this.button2.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button2.Location = new System.Drawing.Point(848, 412);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(131, 49);
            this.button2.TabIndex = 9;
            this.button2.Text = "Next";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnSearch);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.txtSearchPerson);
            this.groupBox1.Controls.Add(this.cbPeopleColumns);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(36, 19);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(934, 80);
            this.groupBox1.TabIndex = 7;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Fillter";
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
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(402, 35);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(129, 20);
            this.label3.TabIndex = 5;
            this.label3.Text = "search Person:";
            // 
            // txtSearchPerson
            // 
            this.txtSearchPerson.Location = new System.Drawing.Point(563, 32);
            this.txtSearchPerson.Name = "txtSearchPerson";
            this.txtSearchPerson.Size = new System.Drawing.Size(191, 26);
            this.txtSearchPerson.TabIndex = 4;
            this.txtSearchPerson.TextChanged += new System.EventHandler(this.txtSearchPerson_TextChanged);
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
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(7, 35);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(84, 20);
            this.label2.TabIndex = 0;
            this.label2.Text = "Fillter By:";
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
            this.groupBox2.Location = new System.Drawing.Point(36, 122);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(934, 268);
            this.groupBox2.TabIndex = 8;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Person Information";
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
            // label31
            // 
            this.label31.AutoSize = true;
            this.label31.Location = new System.Drawing.Point(461, 153);
            this.label31.Name = "label31";
            this.label31.Size = new System.Drawing.Size(65, 20);
            this.label31.TabIndex = 20;
            this.label31.Text = "Phone:";
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
            // label33
            // 
            this.label33.AutoSize = true;
            this.label33.Location = new System.Drawing.Point(461, 120);
            this.label33.Name = "label33";
            this.label33.Size = new System.Drawing.Size(117, 20);
            this.label33.TabIndex = 18;
            this.label33.Text = "Date of Birth:";
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
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(7, 87);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(60, 20);
            this.label9.TabIndex = 5;
            this.label9.Text = "Name:";
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
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(7, 153);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(74, 20);
            this.label7.TabIndex = 3;
            this.label7.Text = "Gendor:";
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
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(7, 219);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(80, 20);
            this.label5.TabIndex = 1;
            this.label5.Text = "Address:";
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
            // Save
            // 
            this.Save.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Save.Image = global::DVLD_My_Version__PresentationLayer.Properties.Resources.Save_32;
            this.Save.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.Save.Location = new System.Drawing.Point(866, 523);
            this.Save.Name = "Save";
            this.Save.Size = new System.Drawing.Size(131, 49);
            this.Save.TabIndex = 11;
            this.Save.Text = "Save";
            this.Save.UseVisualStyleBackColor = true;
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Image = global::DVLD_My_Version__PresentationLayer.Properties.Resources.Close_32;
            this.button1.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button1.Location = new System.Drawing.Point(729, 523);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(131, 49);
            this.button1.TabIndex = 10;
            this.button1.Text = "Cancle";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // ctrSearchPerson
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.button2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.Save);
            this.Controls.Add(this.button1);
            this.Name = "ctrSearchPerson";
            this.Size = new System.Drawing.Size(1014, 581);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Picture)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

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
        private System.Windows.Forms.Button Save;
        private System.Windows.Forms.Button button1;
    }
}
