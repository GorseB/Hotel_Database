namespace Hotel_Database.Presentation
{
    partial class add_Guest
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(add_Guest));
            this.lbl_Title = new System.Windows.Forms.Label();
            this.btn_Cancel = new System.Windows.Forms.Button();
            this.btn_Add = new System.Windows.Forms.Button();
            this.lbl_Guest_Name = new System.Windows.Forms.Label();
            this.lbl_HomePhone = new System.Windows.Forms.Label();
            this.lbl_Guest_Address = new System.Windows.Forms.Label();
            this.lbl_Mobile = new System.Windows.Forms.Label();
            this.txt_Home_Phone = new System.Windows.Forms.TextBox();
            this.txt_Mobile = new System.Windows.Forms.TextBox();
            this.txt_Address = new System.Windows.Forms.TextBox();
            this.txt_Name = new System.Windows.Forms.TextBox();
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
            this.lbl_Title.Text = "Add Guest";
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
            this.btn_Add.Text = "Add Guest";
            this.btn_Add.UseVisualStyleBackColor = true;
            this.btn_Add.Click += new System.EventHandler(this.btn_Add_Click);
            // 
            // lbl_Guest_Name
            // 
            this.lbl_Guest_Name.AutoSize = true;
            this.lbl_Guest_Name.BackColor = System.Drawing.Color.Transparent;
            this.lbl_Guest_Name.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Guest_Name.Location = new System.Drawing.Point(25, 60);
            this.lbl_Guest_Name.Name = "lbl_Guest_Name";
            this.lbl_Guest_Name.Size = new System.Drawing.Size(50, 18);
            this.lbl_Guest_Name.TabIndex = 14;
            this.lbl_Guest_Name.Text = "Name";
            // 
            // lbl_HomePhone
            // 
            this.lbl_HomePhone.AutoSize = true;
            this.lbl_HomePhone.BackColor = System.Drawing.Color.Transparent;
            this.lbl_HomePhone.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_HomePhone.Location = new System.Drawing.Point(25, 200);
            this.lbl_HomePhone.Name = "lbl_HomePhone";
            this.lbl_HomePhone.Size = new System.Drawing.Size(99, 18);
            this.lbl_HomePhone.TabIndex = 15;
            this.lbl_HomePhone.Text = "Home Phone";
            // 
            // lbl_Guest_Address
            // 
            this.lbl_Guest_Address.AutoSize = true;
            this.lbl_Guest_Address.BackColor = System.Drawing.Color.Transparent;
            this.lbl_Guest_Address.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Guest_Address.Location = new System.Drawing.Point(25, 107);
            this.lbl_Guest_Address.Name = "lbl_Guest_Address";
            this.lbl_Guest_Address.Size = new System.Drawing.Size(67, 18);
            this.lbl_Guest_Address.TabIndex = 16;
            this.lbl_Guest_Address.Text = "Address";
            // 
            // lbl_Mobile
            // 
            this.lbl_Mobile.AutoSize = true;
            this.lbl_Mobile.BackColor = System.Drawing.Color.Transparent;
            this.lbl_Mobile.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Mobile.Location = new System.Drawing.Point(25, 153);
            this.lbl_Mobile.Name = "lbl_Mobile";
            this.lbl_Mobile.Size = new System.Drawing.Size(55, 18);
            this.lbl_Mobile.TabIndex = 17;
            this.lbl_Mobile.Text = "Mobile";
            // 
            // txt_Home_Phone
            // 
            this.txt_Home_Phone.Location = new System.Drawing.Point(130, 201);
            this.txt_Home_Phone.Name = "txt_Home_Phone";
            this.txt_Home_Phone.Size = new System.Drawing.Size(442, 20);
            this.txt_Home_Phone.TabIndex = 3;
            // 
            // txt_Mobile
            // 
            this.txt_Mobile.Location = new System.Drawing.Point(130, 154);
            this.txt_Mobile.Name = "txt_Mobile";
            this.txt_Mobile.Size = new System.Drawing.Size(442, 20);
            this.txt_Mobile.TabIndex = 2;
            // 
            // txt_Address
            // 
            this.txt_Address.Location = new System.Drawing.Point(130, 108);
            this.txt_Address.Name = "txt_Address";
            this.txt_Address.Size = new System.Drawing.Size(442, 20);
            this.txt_Address.TabIndex = 1;
            // 
            // txt_Name
            // 
            this.txt_Name.Location = new System.Drawing.Point(130, 61);
            this.txt_Name.Name = "txt_Name";
            this.txt_Name.Size = new System.Drawing.Size(442, 20);
            this.txt_Name.TabIndex = 0;
            // 
            // add_Guest
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::Hotel_Database.Properties.Resources.Sunset;
            this.ClientSize = new System.Drawing.Size(584, 288);
            this.ControlBox = false;
            this.Controls.Add(this.txt_Name);
            this.Controls.Add(this.txt_Address);
            this.Controls.Add(this.txt_Mobile);
            this.Controls.Add(this.txt_Home_Phone);
            this.Controls.Add(this.lbl_Mobile);
            this.Controls.Add(this.lbl_Guest_Address);
            this.Controls.Add(this.lbl_HomePhone);
            this.Controls.Add(this.lbl_Guest_Name);
            this.Controls.Add(this.btn_Add);
            this.Controls.Add(this.btn_Cancel);
            this.Controls.Add(this.lbl_Title);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "add_Guest";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.Text = "Add Guest";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbl_Title;
        private System.Windows.Forms.Button btn_Cancel;
        private System.Windows.Forms.Button btn_Add;
        private System.Windows.Forms.Label lbl_Guest_Name;
        private System.Windows.Forms.Label lbl_HomePhone;
        private System.Windows.Forms.Label lbl_Guest_Address;
        private System.Windows.Forms.Label lbl_Mobile;
        private System.Windows.Forms.TextBox txt_Home_Phone;
        private System.Windows.Forms.TextBox txt_Mobile;
        private System.Windows.Forms.TextBox txt_Address;
        private System.Windows.Forms.TextBox txt_Name;
    }
}