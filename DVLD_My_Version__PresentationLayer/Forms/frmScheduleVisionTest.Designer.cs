namespace DVLD_My_Version__PresentationLayer.Forms
{
    partial class frmScheduleVisionTest
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
            this.ctrAppoitments1 = new DVLD_My_Version__PresentationLayer.Controlers.ctrAppoitments();
            this.btntSave = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // ctrAppoitments1
            // 
            this.ctrAppoitments1.Location = new System.Drawing.Point(12, 155);
            this.ctrAppoitments1.Name = "ctrAppoitments1";
            this.ctrAppoitments1.Size = new System.Drawing.Size(677, 589);
            this.ctrAppoitments1.TabIndex = 1;
            // 
            // btntSave
            // 
            this.btntSave.Image = global::DVLD_My_Version__PresentationLayer.Properties.Resources.Close_32;
            this.btntSave.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btntSave.Location = new System.Drawing.Point(333, 729);
            this.btntSave.Name = "btntSave";
            this.btntSave.Size = new System.Drawing.Size(108, 41);
            this.btntSave.TabIndex = 2;
            this.btntSave.Text = "Close";
            this.btntSave.UseVisualStyleBackColor = true;
            this.btntSave.Click += new System.EventHandler(this.btntSave_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(142, 112);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(354, 40);
            this.label1.TabIndex = 3;
            this.label1.Text = "Vision Test Schdule";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::DVLD_My_Version__PresentationLayer.Properties.Resources.Vision_512;
            this.pictureBox1.Location = new System.Drawing.Point(260, 22);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(118, 74);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 4;
            this.pictureBox1.TabStop = false;
            // 
            // frmScheduleVisionTest
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(722, 801);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btntSave);
            this.Controls.Add(this.ctrAppoitments1);
            this.Name = "frmScheduleVisionTest";
            this.Text = "frmScheduleVisionTest";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Controlers.ctrAppoitments ctrAppoitments1;
        private System.Windows.Forms.Button btntSave;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}