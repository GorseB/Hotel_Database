namespace Hotel_Database.Presentation
{
    partial class Update_Booking
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Update_Booking));
            this.lbl_Title = new System.Windows.Forms.Label();
            this.btn_Cancel = new System.Windows.Forms.Button();
            this.btn_Add = new System.Windows.Forms.Button();
            this.lbl_Date_From = new System.Windows.Forms.Label();
            this.lbl_Date_To = new System.Windows.Forms.Label();
            this.lbl_Checked_In = new System.Windows.Forms.Label();
            this.cbx_CheckedIn = new System.Windows.Forms.CheckBox();
            this.dtp_From = new System.Windows.Forms.DateTimePicker();
            this.dtp_To = new System.Windows.Forms.DateTimePicker();
            this.SuspendLayout();
            // 
            // lbl_Title
            // 
            this.lbl_Title.BackColor = System.Drawing.Color.Transparent;
            this.lbl_Title.Font = new System.Drawing.Font("Arial", 24F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Title.Location = new System.Drawing.Point(12, 9);
            this.lbl_Title.Name = "lbl_Title";
            this.lbl_Title.Size = new System.Drawing.Size(560, 51);
            this.lbl_Title.TabIndex = 0;
            this.lbl_Title.Text = "Update_Booking";
            this.lbl_Title.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btn_Cancel
            // 
            this.btn_Cancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btn_Cancel.Location = new System.Drawing.Point(12, 261);
            this.btn_Cancel.Name = "btn_Cancel";
            this.btn_Cancel.Size = new System.Drawing.Size(560, 24);
            this.btn_Cancel.TabIndex = 5;
            this.btn_Cancel.Text = "Cancel";
            this.btn_Cancel.UseVisualStyleBackColor = true;
            // 
            // btn_Add
            // 
            this.btn_Add.Location = new System.Drawing.Point(12, 231);
            this.btn_Add.Name = "btn_Add";
            this.btn_Add.Size = new System.Drawing.Size(560, 24);
            this.btn_Add.TabIndex = 4;
            this.btn_Add.Text = "Update";
            this.btn_Add.UseVisualStyleBackColor = true;
            this.btn_Add.Click += new System.EventHandler(this.btn_Add_Click);
            // 
            // lbl_Date_From
            // 
            this.lbl_Date_From.AutoSize = true;
            this.lbl_Date_From.BackColor = System.Drawing.Color.Transparent;
            this.lbl_Date_From.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Date_From.Location = new System.Drawing.Point(22, 77);
            this.lbl_Date_From.Name = "lbl_Date_From";
            this.lbl_Date_From.Size = new System.Drawing.Size(83, 18);
            this.lbl_Date_From.TabIndex = 14;
            this.lbl_Date_From.Text = "Date From";
            // 
            // lbl_Date_To
            // 
            this.lbl_Date_To.AutoSize = true;
            this.lbl_Date_To.BackColor = System.Drawing.Color.Transparent;
            this.lbl_Date_To.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Date_To.Location = new System.Drawing.Point(22, 145);
            this.lbl_Date_To.Name = "lbl_Date_To";
            this.lbl_Date_To.Size = new System.Drawing.Size(62, 18);
            this.lbl_Date_To.TabIndex = 16;
            this.lbl_Date_To.Text = "Date To";
            // 
            // lbl_Checked_In
            // 
            this.lbl_Checked_In.AutoSize = true;
            this.lbl_Checked_In.BackColor = System.Drawing.Color.Transparent;
            this.lbl_Checked_In.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Checked_In.Location = new System.Drawing.Point(22, 210);
            this.lbl_Checked_In.Name = "lbl_Checked_In";
            this.lbl_Checked_In.Size = new System.Drawing.Size(86, 18);
            this.lbl_Checked_In.TabIndex = 17;
            this.lbl_Checked_In.Text = "Checked In";
            // 
            // cbx_CheckedIn
            // 
            this.cbx_CheckedIn.AutoSize = true;
            this.cbx_CheckedIn.Location = new System.Drawing.Point(167, 210);
            this.cbx_CheckedIn.Name = "cbx_CheckedIn";
            this.cbx_CheckedIn.Size = new System.Drawing.Size(15, 14);
            this.cbx_CheckedIn.TabIndex = 18;
            this.cbx_CheckedIn.UseVisualStyleBackColor = true;
            // 
            // dtp_From
            // 
            this.dtp_From.Location = new System.Drawing.Point(167, 77);
            this.dtp_From.Name = "dtp_From";
            this.dtp_From.Size = new System.Drawing.Size(218, 20);
            this.dtp_From.TabIndex = 19;
            // 
            // dtp_To
            // 
            this.dtp_To.Location = new System.Drawing.Point(167, 145);
            this.dtp_To.Name = "dtp_To";
            this.dtp_To.Size = new System.Drawing.Size(218, 20);
            this.dtp_To.TabIndex = 20;
            // 
            // Update_Booking
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::Hotel_Database.Properties.Resources.Sunset;
            this.ClientSize = new System.Drawing.Size(584, 288);
            this.ControlBox = false;
            this.Controls.Add(this.dtp_To);
            this.Controls.Add(this.dtp_From);
            this.Controls.Add(this.cbx_CheckedIn);
            this.Controls.Add(this.lbl_Checked_In);
            this.Controls.Add(this.lbl_Date_To);
            this.Controls.Add(this.lbl_Date_From);
            this.Controls.Add(this.btn_Add);
            this.Controls.Add(this.btn_Cancel);
            this.Controls.Add(this.lbl_Title);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Update_Booking";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.Text = "Update_Booking";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbl_Title;
        private System.Windows.Forms.Button btn_Cancel;
        private System.Windows.Forms.Button btn_Add;
        private System.Windows.Forms.Label lbl_Date_From;
        private System.Windows.Forms.Label lbl_Date_To;
        private System.Windows.Forms.Label lbl_Checked_In;
        private System.Windows.Forms.CheckBox cbx_CheckedIn;
        private System.Windows.Forms.DateTimePicker dtp_From;
        private System.Windows.Forms.DateTimePicker dtp_To;
    }
}