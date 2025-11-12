namespace DVLD_My_Version__PresentationLayer.Forms
{
    partial class frmNewLocalDrivingLicenseAppliacation
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
            this.tabDrivingLicenseApp = new System.Windows.Forms.TabControl();
            this.tabPersonInfo = new System.Windows.Forms.TabPage();
            this.linkLabel1 = new System.Windows.Forms.LinkLabel();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.tabAddNewDrivingLicense = new System.Windows.Forms.TabPage();
            this.cbLicenseClass = new System.Windows.Forms.ComboBox();
            this.ApplicationID = new System.Windows.Forms.Label();
            this.ApplicatoinDate = new System.Windows.Forms.Label();
            this.ApplicationFees = new System.Windows.Forms.Label();
            this.CreatedBy = new System.Windows.Forms.Label();
            this.ctrSearchPerson1 = new DVLD_My_Version__PresentationLayer.Controlers.ctrSearchPerson();
            this.btnSave = new System.Windows.Forms.Button();
            this.btnClose = new System.Windows.Forms.Button();
            this.tabDrivingLicenseApp.SuspendLayout();
            this.tabPersonInfo.SuspendLayout();
            this.tabAddNewDrivingLicense.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabDrivingLicenseApp
            // 
            this.tabDrivingLicenseApp.Controls.Add(this.tabPersonInfo);
            this.tabDrivingLicenseApp.Controls.Add(this.tabAddNewDrivingLicense);
            this.tabDrivingLicenseApp.Location = new System.Drawing.Point(22, 12);
            this.tabDrivingLicenseApp.Name = "tabDrivingLicenseApp";
            this.tabDrivingLicenseApp.SelectedIndex = 0;
            this.tabDrivingLicenseApp.Size = new System.Drawing.Size(1174, 705);
            this.tabDrivingLicenseApp.TabIndex = 0;
            // 
            // tabPersonInfo
            // 
            this.tabPersonInfo.Controls.Add(this.linkLabel1);
            this.tabPersonInfo.Controls.Add(this.ctrSearchPerson1);
            this.tabPersonInfo.Location = new System.Drawing.Point(4, 29);
            this.tabPersonInfo.Name = "tabPersonInfo";
            this.tabPersonInfo.Padding = new System.Windows.Forms.Padding(3);
            this.tabPersonInfo.Size = new System.Drawing.Size(1166, 672);
            this.tabPersonInfo.TabIndex = 0;
            this.tabPersonInfo.Text = "Person Info";
            this.tabPersonInfo.UseVisualStyleBackColor = true;
            // 
            // linkLabel1
            // 
            this.linkLabel1.AutoSize = true;
            this.linkLabel1.Location = new System.Drawing.Point(858, 205);
            this.linkLabel1.Name = "linkLabel1";
            this.linkLabel1.Size = new System.Drawing.Size(116, 20);
            this.linkLabel1.TabIndex = 4;
            this.linkLabel1.TabStop = true;
            this.linkLabel1.Text = "Update Person";
            this.linkLabel1.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabel1_LinkClicked_1);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(179, 146);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(192, 25);
            this.label1.TabIndex = 0;
            this.label1.Text = "D.L Application ID:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(179, 373);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(192, 25);
            this.label2.TabIndex = 1;
            this.label2.Text = "Applaication Fees:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(179, 296);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(155, 25);
            this.label3.TabIndex = 2;
            this.label3.Text = "License Class:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(179, 223);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(177, 25);
            this.label4.TabIndex = 3;
            this.label4.Text = "Application Date:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(179, 448);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(127, 25);
            this.label5.TabIndex = 4;
            this.label5.Text = "Created By:";
            // 
            // tabAddNewDrivingLicense
            // 
            this.tabAddNewDrivingLicense.Controls.Add(this.btnClose);
            this.tabAddNewDrivingLicense.Controls.Add(this.btnSave);
            this.tabAddNewDrivingLicense.Controls.Add(this.CreatedBy);
            this.tabAddNewDrivingLicense.Controls.Add(this.ApplicationFees);
            this.tabAddNewDrivingLicense.Controls.Add(this.ApplicatoinDate);
            this.tabAddNewDrivingLicense.Controls.Add(this.ApplicationID);
            this.tabAddNewDrivingLicense.Controls.Add(this.cbLicenseClass);
            this.tabAddNewDrivingLicense.Controls.Add(this.label5);
            this.tabAddNewDrivingLicense.Controls.Add(this.label4);
            this.tabAddNewDrivingLicense.Controls.Add(this.label3);
            this.tabAddNewDrivingLicense.Controls.Add(this.label2);
            this.tabAddNewDrivingLicense.Controls.Add(this.label1);
            this.tabAddNewDrivingLicense.Location = new System.Drawing.Point(4, 29);
            this.tabAddNewDrivingLicense.Name = "tabAddNewDrivingLicense";
            this.tabAddNewDrivingLicense.Padding = new System.Windows.Forms.Padding(3);
            this.tabAddNewDrivingLicense.Size = new System.Drawing.Size(1166, 672);
            this.tabAddNewDrivingLicense.TabIndex = 1;
            this.tabAddNewDrivingLicense.Text = "App Info";
            this.tabAddNewDrivingLicense.UseVisualStyleBackColor = true;
            // 
            // cbLicenseClass
            // 
            this.cbLicenseClass.FormattingEnabled = true;
            this.cbLicenseClass.Location = new System.Drawing.Point(404, 297);
            this.cbLicenseClass.Name = "cbLicenseClass";
            this.cbLicenseClass.Size = new System.Drawing.Size(180, 28);
            this.cbLicenseClass.TabIndex = 5;
            this.cbLicenseClass.SelectedIndexChanged += new System.EventHandler(this.cbLicenseClass_SelectedIndexChanged);
            // 
            // ApplicationID
            // 
            this.ApplicationID.AutoSize = true;
            this.ApplicationID.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ApplicationID.Location = new System.Drawing.Point(399, 146);
            this.ApplicationID.Name = "ApplicationID";
            this.ApplicationID.Size = new System.Drawing.Size(74, 25);
            this.ApplicationID.TabIndex = 6;
            this.ApplicationID.Text = "[????]";
            // 
            // ApplicatoinDate
            // 
            this.ApplicatoinDate.AutoSize = true;
            this.ApplicatoinDate.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ApplicatoinDate.Location = new System.Drawing.Point(399, 223);
            this.ApplicatoinDate.Name = "ApplicatoinDate";
            this.ApplicatoinDate.Size = new System.Drawing.Size(74, 25);
            this.ApplicatoinDate.TabIndex = 7;
            this.ApplicatoinDate.Text = "[????]";
            // 
            // ApplicationFees
            // 
            this.ApplicationFees.AutoSize = true;
            this.ApplicationFees.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ApplicationFees.Location = new System.Drawing.Point(399, 373);
            this.ApplicationFees.Name = "ApplicationFees";
            this.ApplicationFees.Size = new System.Drawing.Size(74, 25);
            this.ApplicationFees.TabIndex = 8;
            this.ApplicationFees.Text = "[????]";
            // 
            // CreatedBy
            // 
            this.CreatedBy.AutoSize = true;
            this.CreatedBy.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CreatedBy.Location = new System.Drawing.Point(399, 448);
            this.CreatedBy.Name = "CreatedBy";
            this.CreatedBy.Size = new System.Drawing.Size(74, 25);
            this.CreatedBy.TabIndex = 9;
            this.CreatedBy.Text = "[????]";
            // 
            // ctrSearchPerson1
            // 
            this.ctrSearchPerson1.Location = new System.Drawing.Point(55, 32);
            this.ctrSearchPerson1.Name = "ctrSearchPerson1";
            this.ctrSearchPerson1.Size = new System.Drawing.Size(1066, 397);
            this.ctrSearchPerson1.TabIndex = 3;
            // 
            // btnSave
            // 
            this.btnSave.Image = global::DVLD_My_Version__PresentationLayer.Properties.Resources.Save_32;
            this.btnSave.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnSave.Location = new System.Drawing.Point(829, 599);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(140, 54);
            this.btnSave.TabIndex = 10;
            this.btnSave.Text = "Save";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // btnClose
            // 
            this.btnClose.Image = global::DVLD_My_Version__PresentationLayer.Properties.Resources.Close_32;
            this.btnClose.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnClose.Location = new System.Drawing.Point(996, 599);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(140, 54);
            this.btnClose.TabIndex = 11;
            this.btnClose.Text = "Close";
            this.btnClose.UseVisualStyleBackColor = true;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // frmNewLocalDrivingLicenseAppliacation
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1199, 729);
            this.Controls.Add(this.tabDrivingLicenseApp);
            this.Name = "frmNewLocalDrivingLicenseAppliacation";
            this.Text = "frmNewLocalDrivingLicenseAppliacation";
            this.tabDrivingLicenseApp.ResumeLayout(false);
            this.tabPersonInfo.ResumeLayout(false);
            this.tabPersonInfo.PerformLayout();
            this.tabAddNewDrivingLicense.ResumeLayout(false);
            this.tabAddNewDrivingLicense.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabDrivingLicenseApp;
        private System.Windows.Forms.TabPage tabPersonInfo;
        private System.Windows.Forms.LinkLabel linkLabel1;
        private Controlers.ctrSearchPerson ctrSearchPerson1;
        private System.Windows.Forms.TabPage tabAddNewDrivingLicense;
        private System.Windows.Forms.Label CreatedBy;
        private System.Windows.Forms.Label ApplicationFees;
        private System.Windows.Forms.Label ApplicatoinDate;
        private System.Windows.Forms.Label ApplicationID;
        private System.Windows.Forms.ComboBox cbLicenseClass;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.Button btnSave;
    }
}