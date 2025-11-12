namespace DVLD_My_Version__PresentationLayer.Forms
{
    partial class frmChangeUserPassword
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
            this.ctrPersonInfo1 = new DVLD_My_Version__PresentationLayer.Controlers.ctrPersonInfo();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txtCurrentPassword = new System.Windows.Forms.TextBox();
            this.txtNewPasswordAgain = new System.Windows.Forms.TextBox();
            this.txtNewPassword = new System.Windows.Forms.TextBox();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            this.btnSaveNewUserPassword = new System.Windows.Forms.Button();
            this.btnCloseForm = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            this.SuspendLayout();
            // 
            // ctrPersonInfo1
            // 
            this.ctrPersonInfo1.Location = new System.Drawing.Point(31, -20);
            this.ctrPersonInfo1.Name = "ctrPersonInfo1";
            this.ctrPersonInfo1.Size = new System.Drawing.Size(1062, 592);
            this.ctrPersonInfo1.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.label1.Location = new System.Drawing.Point(62, 585);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(156, 20);
            this.label1.TabIndex = 1;
            this.label1.Text = "Current Password:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.label2.Location = new System.Drawing.Point(685, 588);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(181, 20);
            this.label2.TabIndex = 2;
            this.label2.Text = "Again New Password:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.label3.Location = new System.Drawing.Point(379, 585);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(130, 20);
            this.label3.TabIndex = 3;
            this.label3.Text = "New Password:";
            // 
            // txtCurrentPassword
            // 
            this.txtCurrentPassword.Location = new System.Drawing.Point(224, 582);
            this.txtCurrentPassword.Name = "txtCurrentPassword";
            this.txtCurrentPassword.Size = new System.Drawing.Size(135, 26);
            this.txtCurrentPassword.TabIndex = 4;
            this.txtCurrentPassword.TextChanged += new System.EventHandler(this.txtCurrentPassword_TextChanged);
            // 
            // txtNewPasswordAgain
            // 
            this.txtNewPasswordAgain.Location = new System.Drawing.Point(872, 585);
            this.txtNewPasswordAgain.Name = "txtNewPasswordAgain";
            this.txtNewPasswordAgain.Size = new System.Drawing.Size(146, 26);
            this.txtNewPasswordAgain.TabIndex = 5;
            // 
            // txtNewPassword
            // 
            this.txtNewPassword.Location = new System.Drawing.Point(515, 582);
            this.txtNewPassword.Name = "txtNewPassword";
            this.txtNewPassword.Size = new System.Drawing.Size(147, 26);
            this.txtNewPassword.TabIndex = 6;
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // btnSaveNewUserPassword
            // 
            this.btnSaveNewUserPassword.Image = global::DVLD_My_Version__PresentationLayer.Properties.Resources.Save_32;
            this.btnSaveNewUserPassword.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnSaveNewUserPassword.Location = new System.Drawing.Point(1063, 637);
            this.btnSaveNewUserPassword.Name = "btnSaveNewUserPassword";
            this.btnSaveNewUserPassword.Size = new System.Drawing.Size(130, 52);
            this.btnSaveNewUserPassword.TabIndex = 7;
            this.btnSaveNewUserPassword.Text = "Save";
            this.btnSaveNewUserPassword.UseVisualStyleBackColor = true;
            this.btnSaveNewUserPassword.Click += new System.EventHandler(this.btnSaveNewUserPassword_Click);
            // 
            // btnCloseForm
            // 
            this.btnCloseForm.Image = global::DVLD_My_Version__PresentationLayer.Properties.Resources.Close_32;
            this.btnCloseForm.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnCloseForm.Location = new System.Drawing.Point(895, 637);
            this.btnCloseForm.Name = "btnCloseForm";
            this.btnCloseForm.Size = new System.Drawing.Size(140, 52);
            this.btnCloseForm.TabIndex = 8;
            this.btnCloseForm.Text = "Close";
            this.btnCloseForm.UseVisualStyleBackColor = true;
            this.btnCloseForm.Click += new System.EventHandler(this.btnCloseForm_Click);
            // 
            // frmChangeUserPassword
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1202, 703);
            this.Controls.Add(this.btnCloseForm);
            this.Controls.Add(this.btnSaveNewUserPassword);
            this.Controls.Add(this.txtNewPassword);
            this.Controls.Add(this.txtNewPasswordAgain);
            this.Controls.Add(this.txtCurrentPassword);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.ctrPersonInfo1);
            this.Name = "frmChangeUserPassword";
            this.Text = "frmChangeUserPassword";
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Controlers.ctrPersonInfo ctrPersonInfo1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtCurrentPassword;
        private System.Windows.Forms.TextBox txtNewPasswordAgain;
        private System.Windows.Forms.TextBox txtNewPassword;
        private System.Windows.Forms.ErrorProvider errorProvider1;
        private System.Windows.Forms.Button btnCloseForm;
        private System.Windows.Forms.Button btnSaveNewUserPassword;
    }
}