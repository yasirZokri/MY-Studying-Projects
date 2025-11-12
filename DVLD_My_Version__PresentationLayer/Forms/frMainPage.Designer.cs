namespace DVLD_My_Version__PresentationLayer
{
    partial class frMainPage
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.peopleToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.applicationToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.drivingLicenceToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.newDrivingLicenseToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.localLicenseToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.internationalLicenseToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.renewDrivingLicenseToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.replaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.releceToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.retakeTestToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.manageApplicationToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.manageLocalDriverLicenseApplicationToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.managIntToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.detainLicenseToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.manageApplicationTypesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ManageTestTypes = new System.Windows.Forms.ToolStripMenuItem();
            this.driversToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.usersToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.accountSettingToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.currentUserInfoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.changeUserPasswordToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem2 = new System.Windows.Forms.ToolStripSeparator();
            this.logOutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(239)))), ((int)(((byte)(224)))));
            this.menuStrip1.Font = new System.Drawing.Font("Segoe UI Semibold", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.menuStrip1.GripMargin = new System.Windows.Forms.Padding(2, 2, 0, 2);
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.applicationToolStripMenuItem,
            this.peopleToolStripMenuItem,
            this.driversToolStripMenuItem,
            this.usersToolStripMenuItem,
            this.accountSettingToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(922, 36);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // peopleToolStripMenuItem
            // 
            this.peopleToolStripMenuItem.Image = global::DVLD_My_Version__PresentationLayer.Properties.Resources.team;
            this.peopleToolStripMenuItem.Name = "peopleToolStripMenuItem";
            this.peopleToolStripMenuItem.Size = new System.Drawing.Size(114, 32);
            this.peopleToolStripMenuItem.Text = "People";
            this.peopleToolStripMenuItem.Click += new System.EventHandler(this.peopleToolStripMenuItem_Click);
            // 
            // applicationToolStripMenuItem
            // 
            this.applicationToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.drivingLicenceToolStripMenuItem,
            this.manageApplicationToolStripMenuItem,
            this.detainLicenseToolStripMenuItem,
            this.manageApplicationTypesToolStripMenuItem,
            this.ManageTestTypes});
            this.applicationToolStripMenuItem.Image = global::DVLD_My_Version__PresentationLayer.Properties.Resources.personal_data;
            this.applicationToolStripMenuItem.Name = "applicationToolStripMenuItem";
            this.applicationToolStripMenuItem.Size = new System.Drawing.Size(154, 32);
            this.applicationToolStripMenuItem.Text = "Application";
            // 
            // drivingLicenceToolStripMenuItem
            // 
            this.drivingLicenceToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.newDrivingLicenseToolStripMenuItem,
            this.renewDrivingLicenseToolStripMenuItem,
            this.replaToolStripMenuItem,
            this.releceToolStripMenuItem,
            this.retakeTestToolStripMenuItem});
            this.drivingLicenceToolStripMenuItem.Image = global::DVLD_My_Version__PresentationLayer.Properties.Resources.PersonLicenseHistory_32;
            this.drivingLicenceToolStripMenuItem.Name = "drivingLicenceToolStripMenuItem";
            this.drivingLicenceToolStripMenuItem.Size = new System.Drawing.Size(353, 36);
            this.drivingLicenceToolStripMenuItem.Text = "Driving License Services";
            // 
            // newDrivingLicenseToolStripMenuItem
            // 
            this.newDrivingLicenseToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.localLicenseToolStripMenuItem,
            this.internationalLicenseToolStripMenuItem});
            this.newDrivingLicenseToolStripMenuItem.Image = global::DVLD_My_Version__PresentationLayer.Properties.Resources.Renew_Driving_License_32;
            this.newDrivingLicenseToolStripMenuItem.Name = "newDrivingLicenseToolStripMenuItem";
            this.newDrivingLicenseToolStripMenuItem.Size = new System.Drawing.Size(318, 36);
            this.newDrivingLicenseToolStripMenuItem.Text = "New Driving License";
            // 
            // localLicenseToolStripMenuItem
            // 
            this.localLicenseToolStripMenuItem.Image = global::DVLD_My_Version__PresentationLayer.Properties.Resources.Driver_License_48;
            this.localLicenseToolStripMenuItem.Name = "localLicenseToolStripMenuItem";
            this.localLicenseToolStripMenuItem.Size = new System.Drawing.Size(303, 36);
            this.localLicenseToolStripMenuItem.Text = "Local License";
            this.localLicenseToolStripMenuItem.Click += new System.EventHandler(this.localLicenseToolStripMenuItem_Click);
            // 
            // internationalLicenseToolStripMenuItem
            // 
            this.internationalLicenseToolStripMenuItem.Image = global::DVLD_My_Version__PresentationLayer.Properties.Resources.International_32;
            this.internationalLicenseToolStripMenuItem.Name = "internationalLicenseToolStripMenuItem";
            this.internationalLicenseToolStripMenuItem.Size = new System.Drawing.Size(303, 36);
            this.internationalLicenseToolStripMenuItem.Text = "International License";
            // 
            // renewDrivingLicenseToolStripMenuItem
            // 
            this.renewDrivingLicenseToolStripMenuItem.Name = "renewDrivingLicenseToolStripMenuItem";
            this.renewDrivingLicenseToolStripMenuItem.Size = new System.Drawing.Size(318, 36);
            this.renewDrivingLicenseToolStripMenuItem.Text = "Renew Driving License";
            // 
            // replaToolStripMenuItem
            // 
            this.replaToolStripMenuItem.Name = "replaToolStripMenuItem";
            this.replaToolStripMenuItem.Size = new System.Drawing.Size(318, 36);
            this.replaToolStripMenuItem.Text = "Replacement";
            this.replaToolStripMenuItem.Click += new System.EventHandler(this.replaToolStripMenuItem_Click);
            // 
            // releceToolStripMenuItem
            // 
            this.releceToolStripMenuItem.Name = "releceToolStripMenuItem";
            this.releceToolStripMenuItem.Size = new System.Drawing.Size(318, 36);
            this.releceToolStripMenuItem.Text = "Releace Detained";
            // 
            // retakeTestToolStripMenuItem
            // 
            this.retakeTestToolStripMenuItem.Name = "retakeTestToolStripMenuItem";
            this.retakeTestToolStripMenuItem.Size = new System.Drawing.Size(318, 36);
            this.retakeTestToolStripMenuItem.Text = "Retake Test";
            // 
            // manageApplicationToolStripMenuItem
            // 
            this.manageApplicationToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.manageLocalDriverLicenseApplicationToolStripMenuItem,
            this.managIntToolStripMenuItem});
            this.manageApplicationToolStripMenuItem.Name = "manageApplicationToolStripMenuItem";
            this.manageApplicationToolStripMenuItem.Size = new System.Drawing.Size(353, 36);
            this.manageApplicationToolStripMenuItem.Text = "Manage Application";
            // 
            // manageLocalDriverLicenseApplicationToolStripMenuItem
            // 
            this.manageLocalDriverLicenseApplicationToolStripMenuItem.Image = global::DVLD_My_Version__PresentationLayer.Properties.Resources.Driver_License_48;
            this.manageLocalDriverLicenseApplicationToolStripMenuItem.Name = "manageLocalDriverLicenseApplicationToolStripMenuItem";
            this.manageLocalDriverLicenseApplicationToolStripMenuItem.Size = new System.Drawing.Size(559, 36);
            this.manageLocalDriverLicenseApplicationToolStripMenuItem.Text = "Manage Local Driving License Applications";
            this.manageLocalDriverLicenseApplicationToolStripMenuItem.Click += new System.EventHandler(this.manageLocalDriverLicenseApplicationToolStripMenuItem_Click);
            // 
            // managIntToolStripMenuItem
            // 
            this.managIntToolStripMenuItem.Image = global::DVLD_My_Version__PresentationLayer.Properties.Resources.International_32;
            this.managIntToolStripMenuItem.Name = "managIntToolStripMenuItem";
            this.managIntToolStripMenuItem.Size = new System.Drawing.Size(559, 36);
            this.managIntToolStripMenuItem.Text = "Manag International Driving License Applications";
            // 
            // detainLicenseToolStripMenuItem
            // 
            this.detainLicenseToolStripMenuItem.Name = "detainLicenseToolStripMenuItem";
            this.detainLicenseToolStripMenuItem.Size = new System.Drawing.Size(353, 36);
            this.detainLicenseToolStripMenuItem.Text = "Detain License";
            // 
            // manageApplicationTypesToolStripMenuItem
            // 
            this.manageApplicationTypesToolStripMenuItem.Image = global::DVLD_My_Version__PresentationLayer.Properties.Resources.account_settings_64;
            this.manageApplicationTypesToolStripMenuItem.Name = "manageApplicationTypesToolStripMenuItem";
            this.manageApplicationTypesToolStripMenuItem.Size = new System.Drawing.Size(353, 36);
            this.manageApplicationTypesToolStripMenuItem.Text = "Manage Application Types";
            this.manageApplicationTypesToolStripMenuItem.Click += new System.EventHandler(this.manageApplicationTypesToolStripMenuItem_Click);
            // 
            // ManageTestTypes
            // 
            this.ManageTestTypes.Name = "ManageTestTypes";
            this.ManageTestTypes.Size = new System.Drawing.Size(353, 36);
            this.ManageTestTypes.Text = "Manage Test Types";
            this.ManageTestTypes.Click += new System.EventHandler(this.ManageTestTypes_Click);
            // 
            // driversToolStripMenuItem
            // 
            this.driversToolStripMenuItem.Image = global::DVLD_My_Version__PresentationLayer.Properties.Resources.driver;
            this.driversToolStripMenuItem.Name = "driversToolStripMenuItem";
            this.driversToolStripMenuItem.Size = new System.Drawing.Size(115, 32);
            this.driversToolStripMenuItem.Text = "Drivers";
            // 
            // usersToolStripMenuItem
            // 
            this.usersToolStripMenuItem.Image = global::DVLD_My_Version__PresentationLayer.Properties.Resources.personal_information;
            this.usersToolStripMenuItem.Name = "usersToolStripMenuItem";
            this.usersToolStripMenuItem.Size = new System.Drawing.Size(102, 32);
            this.usersToolStripMenuItem.Text = "Users";
            this.usersToolStripMenuItem.Click += new System.EventHandler(this.usersToolStripMenuItem_Click);
            // 
            // accountSettingToolStripMenuItem
            // 
            this.accountSettingToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.currentUserInfoToolStripMenuItem,
            this.changeUserPasswordToolStripMenuItem,
            this.toolStripMenuItem2,
            this.logOutToolStripMenuItem});
            this.accountSettingToolStripMenuItem.Image = global::DVLD_My_Version__PresentationLayer.Properties.Resources.control;
            this.accountSettingToolStripMenuItem.Name = "accountSettingToolStripMenuItem";
            this.accountSettingToolStripMenuItem.Size = new System.Drawing.Size(197, 32);
            this.accountSettingToolStripMenuItem.Text = "Account Setting";
            // 
            // currentUserInfoToolStripMenuItem
            // 
            this.currentUserInfoToolStripMenuItem.Image = global::DVLD_My_Version__PresentationLayer.Properties.Resources.Man_32;
            this.currentUserInfoToolStripMenuItem.Name = "currentUserInfoToolStripMenuItem";
            this.currentUserInfoToolStripMenuItem.Size = new System.Drawing.Size(321, 36);
            this.currentUserInfoToolStripMenuItem.Text = "Current User Info";
            this.currentUserInfoToolStripMenuItem.Click += new System.EventHandler(this.currentUserInfoToolStripMenuItem_Click);
            // 
            // changeUserPasswordToolStripMenuItem
            // 
            this.changeUserPasswordToolStripMenuItem.Image = global::DVLD_My_Version__PresentationLayer.Properties.Resources.account_settings_64;
            this.changeUserPasswordToolStripMenuItem.Name = "changeUserPasswordToolStripMenuItem";
            this.changeUserPasswordToolStripMenuItem.Size = new System.Drawing.Size(321, 36);
            this.changeUserPasswordToolStripMenuItem.Text = "Change User Password";
            this.changeUserPasswordToolStripMenuItem.Click += new System.EventHandler(this.changeUserPasswordToolStripMenuItem_Click);
            // 
            // toolStripMenuItem2
            // 
            this.toolStripMenuItem2.Name = "toolStripMenuItem2";
            this.toolStripMenuItem2.Size = new System.Drawing.Size(318, 6);
            // 
            // logOutToolStripMenuItem
            // 
            this.logOutToolStripMenuItem.Image = global::DVLD_My_Version__PresentationLayer.Properties.Resources.sign_out_32__2;
            this.logOutToolStripMenuItem.Name = "logOutToolStripMenuItem";
            this.logOutToolStripMenuItem.Size = new System.Drawing.Size(321, 36);
            this.logOutToolStripMenuItem.Text = "Sing Out";
            this.logOutToolStripMenuItem.Click += new System.EventHandler(this.logOutToolStripMenuItem_Click);
            // 
            // frMainPage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(239)))), ((int)(((byte)(225)))));
            this.ClientSize = new System.Drawing.Size(922, 450);
            this.Controls.Add(this.menuStrip1);
            this.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "frMainPage";
            this.Text = "MainPage";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.frMainPage_FormClosed);
            this.Load += new System.EventHandler(this.MainPage_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ToolStripMenuItem applicationToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem drivingLicenceToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem newDrivingLicenseToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem localLicenseToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem internationalLicenseToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem renewDrivingLicenseToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem replaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem releceToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem retakeTestToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem manageApplicationToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem detainLicenseToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem manageApplicationTypesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ManageTestTypes;
        private System.Windows.Forms.ToolStripMenuItem peopleToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem driversToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem usersToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem accountSettingToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem currentUserInfoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem changeUserPasswordToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripMenuItem2;
        private System.Windows.Forms.ToolStripMenuItem logOutToolStripMenuItem;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem manageLocalDriverLicenseApplicationToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem managIntToolStripMenuItem;
    }
}