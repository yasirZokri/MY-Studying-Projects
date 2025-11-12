namespace DVLD_My_Version__PresentationLayer.Forms
{
    partial class frmUpdatePerson
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
            this.label1 = new System.Windows.Forms.Label();
            this.ctrAddorUpdateUserInfo1 = new DVLD_My_Version__PresentationLayer.Controlers.ctrAddOrUpdateUserInfo();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 22F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.LightSeaGreen;
            this.label1.Location = new System.Drawing.Point(401, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(325, 52);
            this.label1.TabIndex = 1;
            this.label1.Text = "Update Person";
            // 
            // ctrAddorUpdateUserInfo1
            // 
            this.ctrAddorUpdateUserInfo1.Location = new System.Drawing.Point(58, -20);
            this.ctrAddorUpdateUserInfo1.Name = "ctrAddorUpdateUserInfo1";
            this.ctrAddorUpdateUserInfo1.Size = new System.Drawing.Size(1010, 599);
            this.ctrAddorUpdateUserInfo1.TabIndex = 0;
            // 
            // frmUpdatePerson
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1128, 606);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.ctrAddorUpdateUserInfo1);
            this.Name = "frmUpdatePerson";
            this.Text = "frmUpdatePerson";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Controlers.ctrAddOrUpdateUserInfo ctrAddorUpdateUserInfo1;
        private System.Windows.Forms.Label label1;
    }
}