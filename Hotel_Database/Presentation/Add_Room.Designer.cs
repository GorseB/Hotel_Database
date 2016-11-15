namespace Hotel_Database.Presentation
{
    partial class add_Room
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(add_Room));
            this.lbl_Title = new System.Windows.Forms.Label();
            this.btn_Cancel = new System.Windows.Forms.Button();
            this.btn_Add = new System.Windows.Forms.Button();
            this.lbl_Room_Name = new System.Windows.Forms.Label();
            this.lbl_Extra_Info = new System.Windows.Forms.Label();
            this.lbl_Single_Beds = new System.Windows.Forms.Label();
            this.lbl_Double_Beds = new System.Windows.Forms.Label();
            this.txt_Extra_Info = new System.Windows.Forms.TextBox();
            this.txt_Name = new System.Windows.Forms.TextBox();
            this.nud_single = new System.Windows.Forms.NumericUpDown();
            this.nud_double = new System.Windows.Forms.NumericUpDown();
            ((System.ComponentModel.ISupportInitialize)(this.nud_single)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nud_double)).BeginInit();
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
            this.lbl_Title.Text = "Add Room";
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
            this.btn_Add.Text = "Add Room";
            this.btn_Add.UseVisualStyleBackColor = true;
            this.btn_Add.Click += new System.EventHandler(this.btn_Add_Click);
            // 
            // lbl_Room_Name
            // 
            this.lbl_Room_Name.AutoSize = true;
            this.lbl_Room_Name.BackColor = System.Drawing.Color.Transparent;
            this.lbl_Room_Name.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Room_Name.Location = new System.Drawing.Point(25, 60);
            this.lbl_Room_Name.Name = "lbl_Room_Name";
            this.lbl_Room_Name.Size = new System.Drawing.Size(96, 18);
            this.lbl_Room_Name.TabIndex = 14;
            this.lbl_Room_Name.Text = "Room Name";
            // 
            // lbl_Extra_Info
            // 
            this.lbl_Extra_Info.AutoSize = true;
            this.lbl_Extra_Info.BackColor = System.Drawing.Color.Transparent;
            this.lbl_Extra_Info.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Extra_Info.Location = new System.Drawing.Point(25, 200);
            this.lbl_Extra_Info.Name = "lbl_Extra_Info";
            this.lbl_Extra_Info.Size = new System.Drawing.Size(72, 18);
            this.lbl_Extra_Info.TabIndex = 15;
            this.lbl_Extra_Info.Text = "Extra Info";
            // 
            // lbl_Single_Beds
            // 
            this.lbl_Single_Beds.AutoSize = true;
            this.lbl_Single_Beds.BackColor = System.Drawing.Color.Transparent;
            this.lbl_Single_Beds.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Single_Beds.Location = new System.Drawing.Point(25, 107);
            this.lbl_Single_Beds.Name = "lbl_Single_Beds";
            this.lbl_Single_Beds.Size = new System.Drawing.Size(93, 18);
            this.lbl_Single_Beds.TabIndex = 16;
            this.lbl_Single_Beds.Text = "Single Beds";
            // 
            // lbl_Double_Beds
            // 
            this.lbl_Double_Beds.AutoSize = true;
            this.lbl_Double_Beds.BackColor = System.Drawing.Color.Transparent;
            this.lbl_Double_Beds.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Double_Beds.Location = new System.Drawing.Point(25, 153);
            this.lbl_Double_Beds.Name = "lbl_Double_Beds";
            this.lbl_Double_Beds.Size = new System.Drawing.Size(99, 18);
            this.lbl_Double_Beds.TabIndex = 17;
            this.lbl_Double_Beds.Text = "Double Beds";
            // 
            // txt_Extra_Info
            // 
            this.txt_Extra_Info.Location = new System.Drawing.Point(130, 201);
            this.txt_Extra_Info.Name = "txt_Extra_Info";
            this.txt_Extra_Info.Size = new System.Drawing.Size(442, 20);
            this.txt_Extra_Info.TabIndex = 3;
            // 
            // txt_Name
            // 
            this.txt_Name.Location = new System.Drawing.Point(130, 61);
            this.txt_Name.Name = "txt_Name";
            this.txt_Name.Size = new System.Drawing.Size(442, 20);
            this.txt_Name.TabIndex = 0;
            // 
            // nud_single
            // 
            this.nud_single.Location = new System.Drawing.Point(130, 109);
            this.nud_single.Name = "nud_single";
            this.nud_single.Size = new System.Drawing.Size(120, 20);
            this.nud_single.TabIndex = 18;
            // 
            // nud_double
            // 
            this.nud_double.Location = new System.Drawing.Point(130, 155);
            this.nud_double.Name = "nud_double";
            this.nud_double.Size = new System.Drawing.Size(120, 20);
            this.nud_double.TabIndex = 19;
            // 
            // add_Room
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::Hotel_Database.Properties.Resources.Sunset;
            this.ClientSize = new System.Drawing.Size(584, 288);
            this.ControlBox = false;
            this.Controls.Add(this.nud_double);
            this.Controls.Add(this.nud_single);
            this.Controls.Add(this.txt_Name);
            this.Controls.Add(this.txt_Extra_Info);
            this.Controls.Add(this.lbl_Double_Beds);
            this.Controls.Add(this.lbl_Single_Beds);
            this.Controls.Add(this.lbl_Extra_Info);
            this.Controls.Add(this.lbl_Room_Name);
            this.Controls.Add(this.btn_Add);
            this.Controls.Add(this.btn_Cancel);
            this.Controls.Add(this.lbl_Title);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "add_Room";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.Text = "Add Room";
            ((System.ComponentModel.ISupportInitialize)(this.nud_single)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nud_double)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbl_Title;
        private System.Windows.Forms.Button btn_Cancel;
        private System.Windows.Forms.Button btn_Add;
        private System.Windows.Forms.Label lbl_Room_Name;
        private System.Windows.Forms.Label lbl_Extra_Info;
        private System.Windows.Forms.Label lbl_Single_Beds;
        private System.Windows.Forms.Label lbl_Double_Beds;
        private System.Windows.Forms.TextBox txt_Extra_Info;
        private System.Windows.Forms.TextBox txt_Name;
        private System.Windows.Forms.NumericUpDown nud_single;
        private System.Windows.Forms.NumericUpDown nud_double;
    }
}