namespace DVLD_My_Version__PresentationLayer.Forms
{
    partial class frmTakeTest
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
            this.ctrTest1 = new DVLD_My_Version__PresentationLayer.Controlers.ctrTest();
            this.btnCancle = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // ctrTest1
            // 
            this.ctrTest1.Location = new System.Drawing.Point(12, 12);
            this.ctrTest1.Name = "ctrTest1";
            this.ctrTest1.Size = new System.Drawing.Size(505, 830);
            this.ctrTest1.TabIndex = 0;
            // 
            // btnCancle
            // 
            this.btnCancle.Image = global::DVLD_My_Version__PresentationLayer.Properties.Resources.Close_32;
            this.btnCancle.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnCancle.Location = new System.Drawing.Point(221, 739);
            this.btnCancle.Name = "btnCancle";
            this.btnCancle.Size = new System.Drawing.Size(139, 43);
            this.btnCancle.TabIndex = 49;
            this.btnCancle.Text = "Cancle";
            this.btnCancle.UseVisualStyleBackColor = true;
            this.btnCancle.Click += new System.EventHandler(this.btnCancle_Click);
            // 
            // frmTakeTest
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(532, 848);
            this.Controls.Add(this.btnCancle);
            this.Controls.Add(this.ctrTest1);
            this.Name = "frmTakeTest";
            this.Text = "frmTakeTest";
            this.ResumeLayout(false);

        }

        #endregion

        private Controlers.ctrTest ctrTest1;
        private System.Windows.Forms.Button btnCancle;
    }
}