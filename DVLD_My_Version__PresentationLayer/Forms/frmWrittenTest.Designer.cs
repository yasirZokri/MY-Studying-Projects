namespace DVLD_My_Version__PresentationLayer.Forms
{
    partial class frmWrittenTest
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
            this.label2 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.btnAddAppointments = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.dgvAppointments = new System.Windows.Forms.DataGridView();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.updateAppoimentToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.deleteAppoimentToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.takeTestToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ctrApplicationBasicInfo1 = new DVLD_My_Version__PresentationLayer.Controlers.ctrApplicationBasicInfo();
            this.ctrLDLinfo1 = new DVLD_My_Version__PresentationLayer.Controlers.ctrLDLinfo();
            this.llViewPersonInfo = new System.Windows.Forms.LinkLabel();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvAppointments)).BeginInit();
            this.contextMenuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.Highlight;
            this.label2.Location = new System.Drawing.Point(397, 150);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(223, 40);
            this.label2.TabIndex = 37;
            this.label2.Text = "Written Test";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::DVLD_My_Version__PresentationLayer.Properties.Resources.Written_Test_512;
            this.pictureBox1.Location = new System.Drawing.Point(444, 33);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(126, 100);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 38;
            this.pictureBox1.TabStop = false;
            // 
            // btnAddAppointments
            // 
            this.btnAddAppointments.Image = global::DVLD_My_Version__PresentationLayer.Properties.Resources.AddAppointment_32;
            this.btnAddAppointments.Location = new System.Drawing.Point(986, 796);
            this.btnAddAppointments.Name = "btnAddAppointments";
            this.btnAddAppointments.Size = new System.Drawing.Size(54, 44);
            this.btnAddAppointments.TabIndex = 44;
            this.btnAddAppointments.UseVisualStyleBackColor = true;
            this.btnAddAppointments.Click += new System.EventHandler(this.btnAddAppointments_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(21, 820);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(125, 20);
            this.label1.TabIndex = 43;
            this.label1.Text = "Appointments:";
            // 
            // dgvAppointments
            // 
            this.dgvAppointments.AllowUserToAddRows = false;
            this.dgvAppointments.AllowUserToDeleteRows = false;
            this.dgvAppointments.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvAppointments.ContextMenuStrip = this.contextMenuStrip1;
            this.dgvAppointments.Location = new System.Drawing.Point(12, 846);
            this.dgvAppointments.Name = "dgvAppointments";
            this.dgvAppointments.ReadOnly = true;
            this.dgvAppointments.RowHeadersWidth = 62;
            this.dgvAppointments.RowTemplate.Height = 28;
            this.dgvAppointments.Size = new System.Drawing.Size(1028, 192);
            this.dgvAppointments.TabIndex = 42;
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
            // takeTestToolStripMenuItem
            // 
            this.takeTestToolStripMenuItem.Image = global::DVLD_My_Version__PresentationLayer.Properties.Resources.Schedule_Test_321;
            this.takeTestToolStripMenuItem.Name = "takeTestToolStripMenuItem";
            this.takeTestToolStripMenuItem.Size = new System.Drawing.Size(248, 32);
            this.takeTestToolStripMenuItem.Text = "Take Test";
            this.takeTestToolStripMenuItem.Click += new System.EventHandler(this.takeTestToolStripMenuItem_Click);
            // 
            // ctrApplicationBasicInfo1
            // 
            this.ctrApplicationBasicInfo1.Location = new System.Drawing.Point(12, 404);
            this.ctrApplicationBasicInfo1.Name = "ctrApplicationBasicInfo1";
            this.ctrApplicationBasicInfo1.Size = new System.Drawing.Size(1037, 404);
            this.ctrApplicationBasicInfo1.TabIndex = 40;
            // 
            // ctrLDLinfo1
            // 
            this.ctrLDLinfo1.Location = new System.Drawing.Point(12, 219);
            this.ctrLDLinfo1.Name = "ctrLDLinfo1";
            this.ctrLDLinfo1.Size = new System.Drawing.Size(1028, 179);
            this.ctrLDLinfo1.TabIndex = 39;
            // 
            // llViewPersonInfo
            // 
            this.llViewPersonInfo.AutoSize = true;
            this.llViewPersonInfo.Location = new System.Drawing.Point(677, 738);
            this.llViewPersonInfo.Name = "llViewPersonInfo";
            this.llViewPersonInfo.Size = new System.Drawing.Size(129, 20);
            this.llViewPersonInfo.TabIndex = 45;
            this.llViewPersonInfo.TabStop = true;
            this.llViewPersonInfo.Text = "View Person Info";
            this.llViewPersonInfo.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.llViewPersonInfo_LinkClicked);
            // 
            // frmWrittenTest
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1061, 1050);
            this.Controls.Add(this.llViewPersonInfo);
            this.Controls.Add(this.btnAddAppointments);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dgvAppointments);
            this.Controls.Add(this.ctrApplicationBasicInfo1);
            this.Controls.Add(this.ctrLDLinfo1);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.label2);
            this.Name = "frmWrittenTest";
            this.Text = "frmWrittenTest";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvAppointments)).EndInit();
            this.contextMenuStrip1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label2;
        private Controlers.ctrLDLinfo ctrLDLinfo1;
        private Controlers.ctrApplicationBasicInfo ctrApplicationBasicInfo1;
        private System.Windows.Forms.Button btnAddAppointments;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dgvAppointments;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ToolStripMenuItem updateAppoimentToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem deleteAppoimentToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem takeTestToolStripMenuItem;
        private System.Windows.Forms.LinkLabel llViewPersonInfo;
    }
}