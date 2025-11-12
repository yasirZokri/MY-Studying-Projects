namespace DVLD_My_Version__PresentationLayer.Forms
{
    partial class frmPersonInfoAsPerson
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
            this.personInfoAsPerson1 = new DVLD_My_Version__PresentationLayer.Controlers.ctrPersonInfoAsPerson();
            this.SuspendLayout();
            // 
            // personInfoAsPerson1
            // 
            this.personInfoAsPerson1.Location = new System.Drawing.Point(24, 12);
            this.personInfoAsPerson1.Name = "personInfoAsPerson1";
            this.personInfoAsPerson1.Size = new System.Drawing.Size(1040, 428);
            this.personInfoAsPerson1.TabIndex = 0;
            // 
            // frmPersonInfoAsPerson
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1100, 459);
            this.Controls.Add(this.personInfoAsPerson1);
            this.Name = "frmPersonInfoAsPerson";
            this.Text = "frmPersonInfoAsPerson";
            this.ResumeLayout(false);

        }

        #endregion

        private Controlers.ctrPersonInfoAsPerson personInfoAsPerson1;
    }
}