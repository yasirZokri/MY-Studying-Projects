namespace DVLD_My_Version__PresentationLayer.Forms
{
    partial class frmCurrentUserInfo
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
            this.ctrPersonInfo1 = new DVLD_My_Version__PresentationLayer.Controlers.ctrPersonInfo();
            this.SuspendLayout();
            // 
            // ctrPersonInfo1
            // 
            this.ctrPersonInfo1.Location = new System.Drawing.Point(22, 3);
            this.ctrPersonInfo1.Name = "ctrPersonInfo1";
            this.ctrPersonInfo1.Size = new System.Drawing.Size(1062, 592);
            this.ctrPersonInfo1.TabIndex = 0;
            // 
            // frmCurrentUserInfo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1116, 609);
            this.Controls.Add(this.ctrPersonInfo1);
            this.Name = "frmCurrentUserInfo";
            this.Text = "frmCurrentUserInfo";
            this.ResumeLayout(false);

        }

        #endregion

        private Controlers.ctrPersonInfo ctrPersonInfo1;
    }
}