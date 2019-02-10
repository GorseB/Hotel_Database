namespace Hotel_Database.Presentation
{
    partial class Add_Booking
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Add_Booking));
            this.lbl_Title = new System.Windows.Forms.Label();
            this.Calender = new System.Windows.Forms.MonthCalendar();
            this.btn_Select_Guest = new System.Windows.Forms.Button();
            this.btn_Select_Room = new System.Windows.Forms.Button();
            this.nud_Singles = new System.Windows.Forms.NumericUpDown();
            this.nud_Doubles = new System.Windows.Forms.NumericUpDown();
            this.lbl_Singles = new System.Windows.Forms.Label();
            this.lbl_Doubles = new System.Windows.Forms.Label();
            this.btn_Create = new System.Windows.Forms.Button();
            this.btn_Cancel = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.nud_Singles)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nud_Doubles)).BeginInit();
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
            this.lbl_Title.Text = "Create Booking";
            this.lbl_Title.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Calender
            // 
            this.Calender.Location = new System.Drawing.Point(19, 69);
            this.Calender.MaxSelectionCount = 14;
            this.Calender.MinDate = new System.DateTime(2016, 11, 9, 0, 0, 0, 0);
            this.Calender.Name = "Calender";
            this.Calender.ShowToday = false;
            this.Calender.TabIndex = 4;
            this.Calender.MouseLeave += new System.EventHandler(this.Calender_MouseLeave);
            // 
            // btn_Select_Guest
            // 
            this.btn_Select_Guest.Enabled = false;
            this.btn_Select_Guest.Location = new System.Drawing.Point(258, 69);
            this.btn_Select_Guest.Name = "btn_Select_Guest";
            this.btn_Select_Guest.Size = new System.Drawing.Size(314, 81);
            this.btn_Select_Guest.TabIndex = 5;
            this.btn_Select_Guest.Text = "Select Guest";
            this.btn_Select_Guest.UseVisualStyleBackColor = true;
            this.btn_Select_Guest.Click += new System.EventHandler(this.btn_Select_Guest_Click);
            // 
            // btn_Select_Room
            // 
            this.btn_Select_Room.Enabled = false;
            this.btn_Select_Room.Location = new System.Drawing.Point(258, 150);
            this.btn_Select_Room.Name = "btn_Select_Room";
            this.btn_Select_Room.Size = new System.Drawing.Size(314, 81);
            this.btn_Select_Room.TabIndex = 6;
            this.btn_Select_Room.Text = "Select Room";
            this.btn_Select_Room.UseVisualStyleBackColor = true;
            this.btn_Select_Room.Click += new System.EventHandler(this.btn_Select_Room_Click);
            // 
            // nud_Singles
            // 
            this.nud_Singles.Enabled = false;
            this.nud_Singles.Location = new System.Drawing.Point(452, 237);
            this.nud_Singles.Maximum = new decimal(new int[] {
            2,
            0,
            0,
            0});
            this.nud_Singles.Name = "nud_Singles";
            this.nud_Singles.Size = new System.Drawing.Size(120, 20);
            this.nud_Singles.TabIndex = 7;
            this.nud_Singles.ValueChanged += new System.EventHandler(this.ValueChanged);
            // 
            // nud_Doubles
            // 
            this.nud_Doubles.Enabled = false;
            this.nud_Doubles.Location = new System.Drawing.Point(452, 263);
            this.nud_Doubles.Maximum = new decimal(new int[] {
            2,
            0,
            0,
            0});
            this.nud_Doubles.Name = "nud_Doubles";
            this.nud_Doubles.Size = new System.Drawing.Size(120, 20);
            this.nud_Doubles.TabIndex = 8;
            this.nud_Doubles.ValueChanged += new System.EventHandler(this.ValueChanged);
            // 
            // lbl_Singles
            // 
            this.lbl_Singles.AutoSize = true;
            this.lbl_Singles.Location = new System.Drawing.Point(356, 239);
            this.lbl_Singles.Name = "lbl_Singles";
            this.lbl_Singles.Size = new System.Drawing.Size(90, 13);
            this.lbl_Singles.TabIndex = 9;
            this.lbl_Singles.Text = "Extra Single Beds";
            // 
            // lbl_Doubles
            // 
            this.lbl_Doubles.AutoSize = true;
            this.lbl_Doubles.Location = new System.Drawing.Point(351, 265);
            this.lbl_Doubles.Name = "lbl_Doubles";
            this.lbl_Doubles.Size = new System.Drawing.Size(95, 13);
            this.lbl_Doubles.TabIndex = 10;
            this.lbl_Doubles.Text = "Extra Double Beds";
            // 
            // btn_Create
            // 
            this.btn_Create.Enabled = false;
            this.btn_Create.Location = new System.Drawing.Point(19, 237);
            this.btn_Create.Name = "btn_Create";
            this.btn_Create.Size = new System.Drawing.Size(148, 46);
            this.btn_Create.TabIndex = 11;
            this.btn_Create.Text = "Create";
            this.btn_Create.UseVisualStyleBackColor = true;
            this.btn_Create.Click += new System.EventHandler(this.btn_Create_Click);
            // 
            // btn_Cancel
            // 
            this.btn_Cancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btn_Cancel.Location = new System.Drawing.Point(187, 237);
            this.btn_Cancel.Name = "btn_Cancel";
            this.btn_Cancel.Size = new System.Drawing.Size(148, 46);
            this.btn_Cancel.TabIndex = 12;
            this.btn_Cancel.Text = "Cancel";
            this.btn_Cancel.UseVisualStyleBackColor = true;
            // 
            // Add_Booking
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::Hotel_Database.Properties.Resources.Sunset;
            this.ClientSize = new System.Drawing.Size(584, 288);
            this.ControlBox = false;
            this.Controls.Add(this.btn_Cancel);
            this.Controls.Add(this.btn_Create);
            this.Controls.Add(this.lbl_Doubles);
            this.Controls.Add(this.lbl_Singles);
            this.Controls.Add(this.nud_Doubles);
            this.Controls.Add(this.nud_Singles);
            this.Controls.Add(this.btn_Select_Room);
            this.Controls.Add(this.btn_Select_Guest);
            this.Controls.Add(this.Calender);
            this.Controls.Add(this.lbl_Title);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Add_Booking";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.Text = "Create Booking";
            ((System.ComponentModel.ISupportInitialize)(this.nud_Singles)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nud_Doubles)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbl_Title;
        private System.Windows.Forms.Button btn_Select_Guest;
        private System.Windows.Forms.Button btn_Select_Room;
        private System.Windows.Forms.NumericUpDown nud_Singles;
        private System.Windows.Forms.NumericUpDown nud_Doubles;
        private System.Windows.Forms.Label lbl_Singles;
        private System.Windows.Forms.Label lbl_Doubles;
        private System.Windows.Forms.Button btn_Create;
        private System.Windows.Forms.Button btn_Cancel;
        public System.Windows.Forms.MonthCalendar Calender;
    }
}