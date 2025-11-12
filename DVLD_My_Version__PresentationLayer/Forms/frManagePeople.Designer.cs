namespace DVLD_My_Version__PresentationLayer.Forms
{
    partial class frManagePeople
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
            this.ctrManagePeople1 = new DVLD_My_Version__PresentationLayer.Controlers.ctrManagePeople();
            this.SuspendLayout();
            // 
            // ctrManagePeople1
            // 
            this.ctrManagePeople1.Location = new System.Drawing.Point(12, -5);
            this.ctrManagePeople1.Name = "ctrManagePeople1";
            this.ctrManagePeople1.Size = new System.Drawing.Size(1115, 660);
            this.ctrManagePeople1.TabIndex = 0;
            // 
            // frManagePeople
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1110, 572);
            this.Controls.Add(this.ctrManagePeople1);
            this.Name = "frManagePeople";
            this.Text = "frManagePeople";
            this.ResumeLayout(false);

        }

        #endregion

        private Controlers.ctrManagePeople ctrManagePeople1;
    }
}