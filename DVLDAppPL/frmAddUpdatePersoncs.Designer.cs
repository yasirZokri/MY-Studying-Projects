namespace DVLDAppPL
{
    partial class frmAddUpdatePersoncs
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
            this.ctrAddOrUpdateUserInfo1 = new DVLD_My_Version__PresentationLayer.Controlers.ctrAddOrUpdateUserInfo();
            this.SuspendLayout();
            // 
            // ctrAddOrUpdateUserInfo1
            // 
            this.ctrAddOrUpdateUserInfo1.Location = new System.Drawing.Point(91, 78);
            this.ctrAddOrUpdateUserInfo1.Name = "ctrAddOrUpdateUserInfo1";
            this.ctrAddOrUpdateUserInfo1.Size = new System.Drawing.Size(1119, 639);
            this.ctrAddOrUpdateUserInfo1.TabIndex = 0;
            // 
            // frmAddUpdatePersoncs
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1374, 723);
            this.Controls.Add(this.ctrAddOrUpdateUserInfo1);
            this.Name = "frmAddUpdatePersoncs";
            this.Text = "frmAddUpdatePersoncs";
            this.ResumeLayout(false);

        }

        #endregion

        private DVLD_My_Version__PresentationLayer.Controlers.ctrAddOrUpdateUserInfo ctrAddOrUpdateUserInfo1;
    }
}