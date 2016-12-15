namespace Hotel_Database.Presentation
{
    partial class Update_Password
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
            this.btn_Cancel = new System.Windows.Forms.Button();
            this.btn_Done = new System.Windows.Forms.Button();
            this.lbl_NewPassword = new System.Windows.Forms.Label();
            this.txt_NewPassword = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // btn_Cancel
            // 
            this.btn_Cancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btn_Cancel.Location = new System.Drawing.Point(12, 87);
            this.btn_Cancel.Name = "btn_Cancel";
            this.btn_Cancel.Size = new System.Drawing.Size(202, 23);
            this.btn_Cancel.TabIndex = 9;
            this.btn_Cancel.Text = "Cancel";
            this.btn_Cancel.UseVisualStyleBackColor = true;
            // 
            // btn_Done
            // 
            this.btn_Done.Location = new System.Drawing.Point(12, 58);
            this.btn_Done.Name = "btn_Done";
            this.btn_Done.Size = new System.Drawing.Size(202, 23);
            this.btn_Done.TabIndex = 8;
            this.btn_Done.Text = "Done";
            this.btn_Done.UseVisualStyleBackColor = true;
            this.btn_Done.Click += new System.EventHandler(this.btn_Done_Click);
            // 
            // lbl_NewPassword
            // 
            this.lbl_NewPassword.AutoSize = true;
            this.lbl_NewPassword.BackColor = System.Drawing.Color.White;
            this.lbl_NewPassword.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_NewPassword.Location = new System.Drawing.Point(54, 9);
            this.lbl_NewPassword.Name = "lbl_NewPassword";
            this.lbl_NewPassword.Size = new System.Drawing.Size(125, 20);
            this.lbl_NewPassword.TabIndex = 6;
            this.lbl_NewPassword.Text = "New Password";
            // 
            // txt_NewPassword
            // 
            this.txt_NewPassword.Location = new System.Drawing.Point(12, 32);
            this.txt_NewPassword.Name = "txt_NewPassword";
            this.txt_NewPassword.Size = new System.Drawing.Size(202, 20);
            this.txt_NewPassword.TabIndex = 7;
            this.txt_NewPassword.UseSystemPasswordChar = true;
            // 
            // Update_Password
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BackgroundImage = global::Hotel_Database.Properties.Resources.Sunset;
            this.ClientSize = new System.Drawing.Size(225, 118);
            this.ControlBox = false;
            this.Controls.Add(this.btn_Cancel);
            this.Controls.Add(this.btn_Done);
            this.Controls.Add(this.lbl_NewPassword);
            this.Controls.Add(this.txt_NewPassword);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Update_Password";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.Text = "Update Password";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn_Cancel;
        private System.Windows.Forms.Button btn_Done;
        private System.Windows.Forms.Label lbl_NewPassword;
        private System.Windows.Forms.TextBox txt_NewPassword;
    }
}