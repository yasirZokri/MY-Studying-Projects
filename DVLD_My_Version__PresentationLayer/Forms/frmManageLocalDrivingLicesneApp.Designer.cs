namespace DVLD_My_Version__PresentationLayer.Forms
{
    partial class frmManageLocalDrivingLicesneApp
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
            this.components = new System.ComponentModel.Container();
            this.panel1 = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtbNumber = new System.Windows.Forms.TextBox();
            this.btnAddDriver = new System.Windows.Forms.Button();
            this.cbFilterBy = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.dgvLocalDrivers = new System.Windows.Forms.DataGridView();
            this.LDLMenu = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.showPersonInfoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.editApplicationToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.deleteApplicationToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.SechduleToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.sechduleVisionTest = new System.Windows.Forms.ToolStripMenuItem();
            this.sechduleWritenTest = new System.Windows.Forms.ToolStripMenuItem();
            this.sechduleStreatTest = new System.Windows.Forms.ToolStripMenuItem();
            this.CancleToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvLocalDrivers)).BeginInit();
            this.LDLMenu.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.txtbNumber);
            this.panel1.Controls.Add(this.btnAddDriver);
            this.panel1.Controls.Add(this.cbFilterBy);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Location = new System.Drawing.Point(12, 12);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1070, 594);
            this.panel1.TabIndex = 2;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::DVLD_My_Version__PresentationLayer.Properties.Resources.Manage_Applications_64;
            this.pictureBox1.Location = new System.Drawing.Point(436, 17);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(160, 114);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 12;
            this.pictureBox1.TabStop = false;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.SteelBlue;
            this.label2.Location = new System.Drawing.Point(359, 166);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(321, 32);
            this.label2.TabIndex = 11;
            this.label2.Text = "Local Driving Licenses";
            // 
            // txtbNumber
            // 
            this.txtbNumber.Location = new System.Drawing.Point(283, 261);
            this.txtbNumber.Name = "txtbNumber";
            this.txtbNumber.Size = new System.Drawing.Size(189, 26);
            this.txtbNumber.TabIndex = 10;
            this.txtbNumber.TextChanged += new System.EventHandler(this.txtbNumber_TextChanged);
            // 
            // btnAddDriver
            // 
            this.btnAddDriver.BackgroundImage = global::DVLD_My_Version__PresentationLayer.Properties.Resources.New_Application_64;
            this.btnAddDriver.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnAddDriver.Location = new System.Drawing.Point(942, 244);
            this.btnAddDriver.Name = "btnAddDriver";
            this.btnAddDriver.Size = new System.Drawing.Size(51, 41);
            this.btnAddDriver.TabIndex = 9;
            this.btnAddDriver.UseVisualStyleBackColor = true;
            this.btnAddDriver.Click += new System.EventHandler(this.btnAddDriver_Click);
            // 
            // cbFilterBy
            // 
            this.cbFilterBy.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.cbFilterBy.FormattingEnabled = true;
            this.cbFilterBy.Location = new System.Drawing.Point(135, 259);
            this.cbFilterBy.Name = "cbFilterBy";
            this.cbFilterBy.Size = new System.Drawing.Size(121, 28);
            this.cbFilterBy.TabIndex = 6;
            this.cbFilterBy.SelectedIndexChanged += new System.EventHandler(this.cbFilterBy_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(47, 265);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(82, 20);
            this.label1.TabIndex = 8;
            this.label1.Text = "Fillter by:";
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.dgvLocalDrivers);
            this.panel2.Location = new System.Drawing.Point(34, 293);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(973, 270);
            this.panel2.TabIndex = 7;
            // 
            // dgvLocalDrivers
            // 
            this.dgvLocalDrivers.AllowUserToAddRows = false;
            this.dgvLocalDrivers.AllowUserToDeleteRows = false;
            this.dgvLocalDrivers.AllowUserToOrderColumns = true;
            this.dgvLocalDrivers.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvLocalDrivers.ContextMenuStrip = this.LDLMenu;
            this.dgvLocalDrivers.Location = new System.Drawing.Point(17, 16);
            this.dgvLocalDrivers.Name = "dgvLocalDrivers";
            this.dgvLocalDrivers.ReadOnly = true;
            this.dgvLocalDrivers.RowHeadersWidth = 62;
            this.dgvLocalDrivers.RowTemplate.Height = 28;
            this.dgvLocalDrivers.Size = new System.Drawing.Size(942, 241);
            this.dgvLocalDrivers.TabIndex = 0;
            // 
            // LDLMenu
            // 
            this.LDLMenu.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.LDLMenu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.showPersonInfoToolStripMenuItem,
            this.toolStripSeparator1,
            this.editApplicationToolStripMenuItem,
            this.deleteApplicationToolStripMenuItem,
            this.toolStripSeparator2,
            this.SechduleToolStripMenuItem,
            this.CancleToolStripMenuItem});
            this.LDLMenu.Name = "contextMenuStrip1";
            this.LDLMenu.Size = new System.Drawing.Size(231, 176);
            this.LDLMenu.Opening += new System.ComponentModel.CancelEventHandler(this.LDLMenu_Opening);
            // 
            // showPersonInfoToolStripMenuItem
            // 
            this.showPersonInfoToolStripMenuItem.Name = "showPersonInfoToolStripMenuItem";
            this.showPersonInfoToolStripMenuItem.Size = new System.Drawing.Size(230, 32);
            this.showPersonInfoToolStripMenuItem.Text = "Show Person Info";
            this.showPersonInfoToolStripMenuItem.Click += new System.EventHandler(this.showPersonInfoToolStripMenuItem_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(227, 6);
            // 
            // editApplicationToolStripMenuItem
            // 
            this.editApplicationToolStripMenuItem.Name = "editApplicationToolStripMenuItem";
            this.editApplicationToolStripMenuItem.Size = new System.Drawing.Size(230, 32);
            this.editApplicationToolStripMenuItem.Text = "Edit Application";
            // 
            // deleteApplicationToolStripMenuItem
            // 
            this.deleteApplicationToolStripMenuItem.Name = "deleteApplicationToolStripMenuItem";
            this.deleteApplicationToolStripMenuItem.Size = new System.Drawing.Size(230, 32);
            this.deleteApplicationToolStripMenuItem.Text = "Delete Application";
            this.deleteApplicationToolStripMenuItem.Click += new System.EventHandler(this.deleteApplicationToolStripMenuItem_Click);
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(227, 6);
            // 
            // SechduleToolStripMenuItem
            // 
            this.SechduleToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.sechduleVisionTest,
            this.sechduleWritenTest,
            this.sechduleStreatTest});
            this.SechduleToolStripMenuItem.Name = "SechduleToolStripMenuItem";
            this.SechduleToolStripMenuItem.Size = new System.Drawing.Size(230, 32);
            this.SechduleToolStripMenuItem.Text = "Sechdule Test";
            // 
            // sechduleVisionTest
            // 
            this.sechduleVisionTest.Image = global::DVLD_My_Version__PresentationLayer.Properties.Resources.Vision_Test_32;
            this.sechduleVisionTest.Name = "sechduleVisionTest";
            this.sechduleVisionTest.Size = new System.Drawing.Size(277, 34);
            this.sechduleVisionTest.Text = "Sechdule Vision Test";
            this.sechduleVisionTest.Click += new System.EventHandler(this.sechduleVisionTest_Click);
            // 
            // sechduleWritenTest
            // 
            this.sechduleWritenTest.Image = global::DVLD_My_Version__PresentationLayer.Properties.Resources.Notes_32;
            this.sechduleWritenTest.Name = "sechduleWritenTest";
            this.sechduleWritenTest.Size = new System.Drawing.Size(277, 34);
            this.sechduleWritenTest.Text = "Sechdule Writen Test";
            this.sechduleWritenTest.Click += new System.EventHandler(this.sechduleWritenTest_Click);
            // 
            // sechduleStreatTest
            // 
            this.sechduleStreatTest.Image = global::DVLD_My_Version__PresentationLayer.Properties.Resources.Cars_48;
            this.sechduleStreatTest.Name = "sechduleStreatTest";
            this.sechduleStreatTest.Size = new System.Drawing.Size(277, 34);
            this.sechduleStreatTest.Text = "Sechdule Streat Test";
            this.sechduleStreatTest.Click += new System.EventHandler(this.sechduleStreatTest_Click);
            // 
            // CancleToolStripMenuItem
            // 
            this.CancleToolStripMenuItem.Name = "CancleToolStripMenuItem";
            this.CancleToolStripMenuItem.Size = new System.Drawing.Size(230, 32);
            this.CancleToolStripMenuItem.Text = "Cancal Application";
            this.CancleToolStripMenuItem.Click += new System.EventHandler(this.CancleToolStripMenuItem_Click);
            // 
            // frmManageLocalDrivingLicesneApp
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1113, 618);
            this.Controls.Add(this.panel1);
            this.Name = "frmManageLocalDrivingLicesneApp";
            this.Text = "frmManageLocalDrivingLicesneApp";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvLocalDrivers)).EndInit();
            this.LDLMenu.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtbNumber;
        private System.Windows.Forms.Button btnAddDriver;
        private System.Windows.Forms.ComboBox cbFilterBy;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.DataGridView dgvLocalDrivers;
        private System.Windows.Forms.ContextMenuStrip LDLMenu;
        private System.Windows.Forms.ToolStripMenuItem showPersonInfoToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripMenuItem editApplicationToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem deleteApplicationToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
        private System.Windows.Forms.ToolStripMenuItem SechduleToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem CancleToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem sechduleVisionTest;
        private System.Windows.Forms.ToolStripMenuItem sechduleWritenTest;
        private System.Windows.Forms.ToolStripMenuItem sechduleStreatTest;
    }
}