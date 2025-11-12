namespace DVLD_My_Version__PresentationLayer.Forms
{
    partial class frmVisionTestcs
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
            this.linkLabel1 = new System.Windows.Forms.LinkLabel();
            this.linkLabel2 = new System.Windows.Forms.LinkLabel();
            this.dgvAppointments = new System.Windows.Forms.DataGridView();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.updateAppoimentToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.deleteAppoimentToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.ctrLDLinfo1 = new DVLD_My_Version__PresentationLayer.Controlers.ctrLDLinfo();
            this.ctrApplicationBasicInfo1 = new DVLD_My_Version__PresentationLayer.Controlers.ctrApplicationBasicInfo();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.btnAddAppointments = new System.Windows.Forms.Button();
            this.takeTestToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgvAppointments)).BeginInit();
            this.contextMenuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            this.SuspendLayout();
            // 
            // linkLabel1
            // 
            this.linkLabel1.AutoSize = true;
            this.linkLabel1.Location = new System.Drawing.Point(178, 269);
            this.linkLabel1.Name = "linkLabel1";
            this.linkLabel1.Size = new System.Drawing.Size(140, 20);
            this.linkLabel1.TabIndex = 9;
            this.linkLabel1.TabStop = true;
            this.linkLabel1.Text = "Show License Info";
            // 
            // linkLabel2
            // 
            this.linkLabel2.AutoSize = true;
            this.linkLabel2.Location = new System.Drawing.Point(771, 691);
            this.linkLabel2.Name = "linkLabel2";
            this.linkLabel2.Size = new System.Drawing.Size(129, 20);
            this.linkLabel2.TabIndex = 31;
            this.linkLabel2.TabStop = true;
            this.linkLabel2.Text = "View Person Info";
            this.linkLabel2.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabel2_LinkClicked);
            // 
            // dgvAppointments
            // 
            this.dgvAppointments.AllowUserToAddRows = false;
            this.dgvAppointments.AllowUserToDeleteRows = false;
            this.dgvAppointments.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvAppointments.ContextMenuStrip = this.contextMenuStrip1;
            this.dgvAppointments.Location = new System.Drawing.Point(21, 846);
            this.dgvAppointments.Name = "dgvAppointments";
            this.dgvAppointments.ReadOnly = true;
            this.dgvAppointments.RowHeadersWidth = 62;
            this.dgvAppointments.RowTemplate.Height = 28;
            this.dgvAppointments.Size = new System.Drawing.Size(1057, 192);
            this.dgvAppointments.TabIndex = 32;
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.contextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.updateAppoimentToolStripMenuItem,
            this.deleteAppoimentToolStripMenuItem,
            this.takeTestToolStripMenuItem});
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(249, 133);
            // 
            // updateAppoimentToolStripMenuItem
            // 
            this.updateAppoimentToolStripMenuItem.Name = "updateAppoimentToolStripMenuItem";
            this.updateAppoimentToolStripMenuItem.Size = new System.Drawing.Size(248, 32);
            this.updateAppoimentToolStripMenuItem.Text = "Update Appoiment";
            this.updateAppoimentToolStripMenuItem.Click += new System.EventHandler(this.updateAppoimentToolStripMenuItem_Click);
            // 
            // deleteAppoimentToolStripMenuItem
            // 
            this.deleteAppoimentToolStripMenuItem.Name = "deleteAppoimentToolStripMenuItem";
            this.deleteAppoimentToolStripMenuItem.Size = new System.Drawing.Size(248, 32);
            this.deleteAppoimentToolStripMenuItem.Text = "Delete Appoiment";
            this.deleteAppoimentToolStripMenuItem.Click += new System.EventHandler(this.deleteAppoimentToolStripMenuItem_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(30, 820);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(125, 20);
            this.label1.TabIndex = 33;
            this.label1.Text = "Appointments:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.Highlight;
            this.label2.Location = new System.Drawing.Point(397, 131);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(166, 32);
            this.label2.TabIndex = 35;
            this.label2.Text = "Vision Test";
            // 
            // ctrLDLinfo1
            // 
            this.ctrLDLinfo1.Location = new System.Drawing.Point(12, 166);
            this.ctrLDLinfo1.Name = "ctrLDLinfo1";
            this.ctrLDLinfo1.Size = new System.Drawing.Size(1055, 179);
            this.ctrLDLinfo1.TabIndex = 37;
            // 
            // ctrApplicationBasicInfo1
            // 
            this.ctrApplicationBasicInfo1.Location = new System.Drawing.Point(12, 354);
            this.ctrApplicationBasicInfo1.Name = "ctrApplicationBasicInfo1";
            this.ctrApplicationBasicInfo1.Size = new System.Drawing.Size(1041, 405);
            this.ctrApplicationBasicInfo1.TabIndex = 0;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::DVLD_My_Version__PresentationLayer.Properties.Resources.Vision_512;
            this.pictureBox1.Location = new System.Drawing.Point(442, 51);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(78, 50);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 36;
            this.pictureBox1.TabStop = false;
            // 
            // btnAddAppointments
            // 
            this.btnAddAppointments.Image = global::DVLD_My_Version__PresentationLayer.Properties.Resources.AddAppointment_32;
            this.btnAddAppointments.Location = new System.Drawing.Point(1024, 796);
            this.btnAddAppointments.Name = "btnAddAppointments";
            this.btnAddAppointments.Size = new System.Drawing.Size(54, 44);
            this.btnAddAppointments.TabIndex = 34;
            this.btnAddAppointments.UseVisualStyleBackColor = true;
            this.btnAddAppointments.Click += new System.EventHandler(this.btnAddAppointments_Click);
            // 
            // takeTestToolStripMenuItem
            // 
            this.takeTestToolStripMenuItem.Image = global::DVLD_My_Version__PresentationLayer.Properties.Resources.Schedule_Test_321;
            this.takeTestToolStripMenuItem.Name = "takeTestToolStripMenuItem";
            this.takeTestToolStripMenuItem.Size = new System.Drawing.Size(248, 32);
            this.takeTestToolStripMenuItem.Text = "Take Test";
            this.takeTestToolStripMenuItem.Click += new System.EventHandler(this.takeTestToolStripMenuItem_Click);
            // 
            // pictureBox3
            // 
            this.pictureBox3.Image = global::DVLD_My_Version__PresentationLayer.Properties.Resources.personal_data;
            this.pictureBox3.Location = new System.Drawing.Point(131, 269);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(41, 32);
            this.pictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox3.TabIndex = 10;
            this.pictureBox3.TabStop = false;
            // 
            // frmVisionTestcs
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1116, 1050);
            this.Controls.Add(this.ctrLDLinfo1);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btnAddAppointments);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dgvAppointments);
            this.Controls.Add(this.linkLabel2);
            this.Controls.Add(this.pictureBox3);
            this.Controls.Add(this.linkLabel1);
            this.Controls.Add(this.ctrApplicationBasicInfo1);
            this.Name = "frmVisionTestcs";
            this.Text = "frmVisionTestcs";
            ((System.ComponentModel.ISupportInitialize)(this.dgvAppointments)).EndInit();
            this.contextMenuStrip1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Controlers.ctrApplicationBasicInfo ctrApplicationBasicInfo1;
        private Controlers.ctrLDLinfo ldLinfo1;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.LinkLabel linkLabel1;
        private System.Windows.Forms.LinkLabel linkLabel2;
        private System.Windows.Forms.DataGridView dgvAppointments;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnAddAppointments;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.PictureBox pictureBox1;
        private Controlers.ctrLDLinfo ldLinfo2;
        private Controlers.ctrLDLinfo ctrLDLinfo1;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ToolStripMenuItem updateAppoimentToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem deleteAppoimentToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem takeTestToolStripMenuItem;
    }
}