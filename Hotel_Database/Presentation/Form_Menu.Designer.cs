namespace Hotel_Database
{
    partial class Form_Menu
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form_Menu));
            this.Tab_Control_Main = new System.Windows.Forms.TabControl();
            this.Complete_Bookings = new System.Windows.Forms.TabPage();
            this.DGV_Bookings_Simple = new System.Windows.Forms.DataGridView();
            this.Bookings = new System.Windows.Forms.TabPage();
            this.DGV_Bookings = new System.Windows.Forms.DataGridView();
            this.Rooms = new System.Windows.Forms.TabPage();
            this.DGV_Rooms = new System.Windows.Forms.DataGridView();
            this.Guest_Info = new System.Windows.Forms.TabPage();
            this.DGV_GuestInfo = new System.Windows.Forms.DataGridView();
            this.Charges = new System.Windows.Forms.TabPage();
            this.DGV_Charges = new System.Windows.Forms.DataGridView();
            this.Room_Prices = new System.Windows.Forms.TabPage();
            this.DGV_Room_Pricing = new System.Windows.Forms.DataGridView();
            this.lbl_Create = new System.Windows.Forms.Label();
            this.btn_Add_Booking = new System.Windows.Forms.Button();
            this.btn_Add_Guest = new System.Windows.Forms.Button();
            this.btn_Add_Room = new System.Windows.Forms.Button();
            this.btn_Update_Guest = new System.Windows.Forms.Button();
            this.btn_Add_Charge = new System.Windows.Forms.Button();
            this.btn_Update_Booking = new System.Windows.Forms.Button();
            this.lbl_Update = new System.Windows.Forms.Label();
            this.btn_Update_Room_Pricing = new System.Windows.Forms.Button();
            this.btn_Update_Room = new System.Windows.Forms.Button();
            this.btn_Delete_Charges = new System.Windows.Forms.Button();
            this.btn_Delete_Guest = new System.Windows.Forms.Button();
            this.btn_Delete_Room = new System.Windows.Forms.Button();
            this.btn_Delete_Booking = new System.Windows.Forms.Button();
            this.lbl_Delete = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.btn_ChangePassword = new System.Windows.Forms.Button();
            this.btn_CreateAcc = new System.Windows.Forms.Button();
            this.btn_DeleteAcc = new System.Windows.Forms.Button();
            this.btn_EleveateAcc = new System.Windows.Forms.Button();
            this.btn_Return = new System.Windows.Forms.Button();
            this.Tab_Control_Main.SuspendLayout();
            this.Complete_Bookings.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DGV_Bookings_Simple)).BeginInit();
            this.Bookings.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DGV_Bookings)).BeginInit();
            this.Rooms.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DGV_Rooms)).BeginInit();
            this.Guest_Info.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DGV_GuestInfo)).BeginInit();
            this.Charges.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DGV_Charges)).BeginInit();
            this.Room_Prices.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DGV_Room_Pricing)).BeginInit();
            this.SuspendLayout();
            // 
            // Tab_Control_Main
            // 
            this.Tab_Control_Main.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.Tab_Control_Main.Controls.Add(this.Complete_Bookings);
            this.Tab_Control_Main.Controls.Add(this.Bookings);
            this.Tab_Control_Main.Controls.Add(this.Rooms);
            this.Tab_Control_Main.Controls.Add(this.Guest_Info);
            this.Tab_Control_Main.Controls.Add(this.Charges);
            this.Tab_Control_Main.Controls.Add(this.Room_Prices);
            this.Tab_Control_Main.Location = new System.Drawing.Point(10, 0);
            this.Tab_Control_Main.Name = "Tab_Control_Main";
            this.Tab_Control_Main.SelectedIndex = 0;
            this.Tab_Control_Main.Size = new System.Drawing.Size(721, 310);
            this.Tab_Control_Main.TabIndex = 0;
            // 
            // Complete_Bookings
            // 
            this.Complete_Bookings.Controls.Add(this.DGV_Bookings_Simple);
            this.Complete_Bookings.Location = new System.Drawing.Point(4, 22);
            this.Complete_Bookings.Name = "Complete_Bookings";
            this.Complete_Bookings.Size = new System.Drawing.Size(713, 284);
            this.Complete_Bookings.TabIndex = 5;
            this.Complete_Bookings.Text = "Bookings Simple";
            this.Complete_Bookings.UseVisualStyleBackColor = true;
            // 
            // DGV_Bookings_Simple
            // 
            this.DGV_Bookings_Simple.AllowUserToAddRows = false;
            this.DGV_Bookings_Simple.AllowUserToDeleteRows = false;
            this.DGV_Bookings_Simple.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DGV_Bookings_Simple.Dock = System.Windows.Forms.DockStyle.Fill;
            this.DGV_Bookings_Simple.Location = new System.Drawing.Point(0, 0);
            this.DGV_Bookings_Simple.Name = "DGV_Bookings_Simple";
            this.DGV_Bookings_Simple.ReadOnly = true;
            this.DGV_Bookings_Simple.Size = new System.Drawing.Size(713, 284);
            this.DGV_Bookings_Simple.TabIndex = 0;
            // 
            // Bookings
            // 
            this.Bookings.Controls.Add(this.DGV_Bookings);
            this.Bookings.Location = new System.Drawing.Point(4, 22);
            this.Bookings.Name = "Bookings";
            this.Bookings.Padding = new System.Windows.Forms.Padding(3);
            this.Bookings.Size = new System.Drawing.Size(713, 284);
            this.Bookings.TabIndex = 0;
            this.Bookings.Text = "Bookings ";
            this.Bookings.UseVisualStyleBackColor = true;
            // 
            // DGV_Bookings
            // 
            this.DGV_Bookings.AllowUserToAddRows = false;
            this.DGV_Bookings.AllowUserToDeleteRows = false;
            this.DGV_Bookings.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DGV_Bookings.Dock = System.Windows.Forms.DockStyle.Fill;
            this.DGV_Bookings.Location = new System.Drawing.Point(3, 3);
            this.DGV_Bookings.Name = "DGV_Bookings";
            this.DGV_Bookings.ReadOnly = true;
            this.DGV_Bookings.Size = new System.Drawing.Size(707, 278);
            this.DGV_Bookings.TabIndex = 1;
            // 
            // Rooms
            // 
            this.Rooms.Controls.Add(this.DGV_Rooms);
            this.Rooms.Location = new System.Drawing.Point(4, 22);
            this.Rooms.Name = "Rooms";
            this.Rooms.Size = new System.Drawing.Size(713, 284);
            this.Rooms.TabIndex = 4;
            this.Rooms.Text = "Rooms";
            this.Rooms.UseVisualStyleBackColor = true;
            // 
            // DGV_Rooms
            // 
            this.DGV_Rooms.AllowUserToAddRows = false;
            this.DGV_Rooms.AllowUserToDeleteRows = false;
            this.DGV_Rooms.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DGV_Rooms.Dock = System.Windows.Forms.DockStyle.Fill;
            this.DGV_Rooms.Location = new System.Drawing.Point(0, 0);
            this.DGV_Rooms.Name = "DGV_Rooms";
            this.DGV_Rooms.ReadOnly = true;
            this.DGV_Rooms.Size = new System.Drawing.Size(713, 284);
            this.DGV_Rooms.TabIndex = 1;
            // 
            // Guest_Info
            // 
            this.Guest_Info.Controls.Add(this.DGV_GuestInfo);
            this.Guest_Info.Location = new System.Drawing.Point(4, 22);
            this.Guest_Info.Name = "Guest_Info";
            this.Guest_Info.Size = new System.Drawing.Size(713, 284);
            this.Guest_Info.TabIndex = 2;
            this.Guest_Info.Text = "Guest Info";
            this.Guest_Info.UseVisualStyleBackColor = true;
            // 
            // DGV_GuestInfo
            // 
            this.DGV_GuestInfo.AllowUserToAddRows = false;
            this.DGV_GuestInfo.AllowUserToDeleteRows = false;
            this.DGV_GuestInfo.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DGV_GuestInfo.Dock = System.Windows.Forms.DockStyle.Fill;
            this.DGV_GuestInfo.Location = new System.Drawing.Point(0, 0);
            this.DGV_GuestInfo.Name = "DGV_GuestInfo";
            this.DGV_GuestInfo.ReadOnly = true;
            this.DGV_GuestInfo.Size = new System.Drawing.Size(713, 284);
            this.DGV_GuestInfo.TabIndex = 1;
            // 
            // Charges
            // 
            this.Charges.Controls.Add(this.DGV_Charges);
            this.Charges.Location = new System.Drawing.Point(4, 22);
            this.Charges.Name = "Charges";
            this.Charges.Padding = new System.Windows.Forms.Padding(3);
            this.Charges.Size = new System.Drawing.Size(713, 284);
            this.Charges.TabIndex = 1;
            this.Charges.Text = "Charges";
            this.Charges.UseVisualStyleBackColor = true;
            // 
            // DGV_Charges
            // 
            this.DGV_Charges.AllowUserToAddRows = false;
            this.DGV_Charges.AllowUserToDeleteRows = false;
            this.DGV_Charges.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DGV_Charges.Dock = System.Windows.Forms.DockStyle.Fill;
            this.DGV_Charges.Location = new System.Drawing.Point(3, 3);
            this.DGV_Charges.Name = "DGV_Charges";
            this.DGV_Charges.ReadOnly = true;
            this.DGV_Charges.Size = new System.Drawing.Size(707, 278);
            this.DGV_Charges.TabIndex = 1;
            // 
            // Room_Prices
            // 
            this.Room_Prices.Controls.Add(this.DGV_Room_Pricing);
            this.Room_Prices.Location = new System.Drawing.Point(4, 22);
            this.Room_Prices.Name = "Room_Prices";
            this.Room_Prices.Size = new System.Drawing.Size(713, 284);
            this.Room_Prices.TabIndex = 3;
            this.Room_Prices.Text = "Room Pricing";
            this.Room_Prices.UseVisualStyleBackColor = true;
            // 
            // DGV_Room_Pricing
            // 
            this.DGV_Room_Pricing.AllowUserToAddRows = false;
            this.DGV_Room_Pricing.AllowUserToDeleteRows = false;
            this.DGV_Room_Pricing.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DGV_Room_Pricing.Dock = System.Windows.Forms.DockStyle.Fill;
            this.DGV_Room_Pricing.Location = new System.Drawing.Point(0, 0);
            this.DGV_Room_Pricing.Name = "DGV_Room_Pricing";
            this.DGV_Room_Pricing.ReadOnly = true;
            this.DGV_Room_Pricing.Size = new System.Drawing.Size(713, 284);
            this.DGV_Room_Pricing.TabIndex = 1;
            // 
            // lbl_Create
            // 
            this.lbl_Create.BackColor = System.Drawing.Color.Transparent;
            this.lbl_Create.Font = new System.Drawing.Font("Arial", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Create.Location = new System.Drawing.Point(886, 22);
            this.lbl_Create.Name = "lbl_Create";
            this.lbl_Create.Size = new System.Drawing.Size(140, 45);
            this.lbl_Create.TabIndex = 1;
            this.lbl_Create.Text = "Create";
            this.lbl_Create.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lbl_Create.Click += new System.EventHandler(this.lbl_Create_Click);
            // 
            // btn_Add_Booking
            // 
            this.btn_Add_Booking.Location = new System.Drawing.Point(737, 70);
            this.btn_Add_Booking.Name = "btn_Add_Booking";
            this.btn_Add_Booking.Size = new System.Drawing.Size(140, 61);
            this.btn_Add_Booking.TabIndex = 1;
            this.btn_Add_Booking.Text = "Add Booking";
            this.btn_Add_Booking.UseVisualStyleBackColor = true;
            this.btn_Add_Booking.Click += new System.EventHandler(this.lbl_AddBooking_Click);
            // 
            // btn_Add_Guest
            // 
            this.btn_Add_Guest.Location = new System.Drawing.Point(886, 70);
            this.btn_Add_Guest.Name = "btn_Add_Guest";
            this.btn_Add_Guest.Size = new System.Drawing.Size(140, 61);
            this.btn_Add_Guest.TabIndex = 2;
            this.btn_Add_Guest.Text = "Add Guest";
            this.btn_Add_Guest.UseVisualStyleBackColor = true;
            this.btn_Add_Guest.Click += new System.EventHandler(this.btn_Add_Guest_Click);
            // 
            // btn_Add_Room
            // 
            this.btn_Add_Room.Location = new System.Drawing.Point(1032, 70);
            this.btn_Add_Room.Name = "btn_Add_Room";
            this.btn_Add_Room.Size = new System.Drawing.Size(140, 61);
            this.btn_Add_Room.TabIndex = 3;
            this.btn_Add_Room.Text = "Add Room";
            this.btn_Add_Room.UseVisualStyleBackColor = true;
            this.btn_Add_Room.Click += new System.EventHandler(this.btn_Add_Room_Click);
            // 
            // btn_Update_Guest
            // 
            this.btn_Update_Guest.Location = new System.Drawing.Point(1032, 182);
            this.btn_Update_Guest.Name = "btn_Update_Guest";
            this.btn_Update_Guest.Size = new System.Drawing.Size(140, 61);
            this.btn_Update_Guest.TabIndex = 6;
            this.btn_Update_Guest.Text = "Update Guest Info";
            this.btn_Update_Guest.UseVisualStyleBackColor = true;
            this.btn_Update_Guest.Click += new System.EventHandler(this.btn_Update_Guest_Click);
            // 
            // btn_Add_Charge
            // 
            this.btn_Add_Charge.Location = new System.Drawing.Point(886, 182);
            this.btn_Add_Charge.Name = "btn_Add_Charge";
            this.btn_Add_Charge.Size = new System.Drawing.Size(140, 61);
            this.btn_Add_Charge.TabIndex = 5;
            this.btn_Add_Charge.Text = "Update Charges";
            this.btn_Add_Charge.UseVisualStyleBackColor = true;
            this.btn_Add_Charge.Click += new System.EventHandler(this.btn_Add_Charge_Click);
            // 
            // btn_Update_Booking
            // 
            this.btn_Update_Booking.Location = new System.Drawing.Point(737, 182);
            this.btn_Update_Booking.Name = "btn_Update_Booking";
            this.btn_Update_Booking.Size = new System.Drawing.Size(140, 61);
            this.btn_Update_Booking.TabIndex = 4;
            this.btn_Update_Booking.Text = "Update Booking";
            this.btn_Update_Booking.UseVisualStyleBackColor = true;
            this.btn_Update_Booking.Click += new System.EventHandler(this.btn_Update_Booking_Click);
            // 
            // lbl_Update
            // 
            this.lbl_Update.BackColor = System.Drawing.Color.Transparent;
            this.lbl_Update.Font = new System.Drawing.Font("Arial", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Update.Location = new System.Drawing.Point(886, 134);
            this.lbl_Update.Name = "lbl_Update";
            this.lbl_Update.Size = new System.Drawing.Size(140, 45);
            this.lbl_Update.TabIndex = 5;
            this.lbl_Update.Text = "Update";
            this.lbl_Update.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btn_Update_Room_Pricing
            // 
            this.btn_Update_Room_Pricing.Location = new System.Drawing.Point(956, 249);
            this.btn_Update_Room_Pricing.Name = "btn_Update_Room_Pricing";
            this.btn_Update_Room_Pricing.Size = new System.Drawing.Size(216, 61);
            this.btn_Update_Room_Pricing.TabIndex = 8;
            this.btn_Update_Room_Pricing.Text = "Update Room Pricing";
            this.btn_Update_Room_Pricing.UseVisualStyleBackColor = true;
            this.btn_Update_Room_Pricing.Click += new System.EventHandler(this.btn_Update_Room_Pricing_Click);
            // 
            // btn_Update_Room
            // 
            this.btn_Update_Room.Location = new System.Drawing.Point(737, 249);
            this.btn_Update_Room.Name = "btn_Update_Room";
            this.btn_Update_Room.Size = new System.Drawing.Size(215, 61);
            this.btn_Update_Room.TabIndex = 7;
            this.btn_Update_Room.Text = "Update Room";
            this.btn_Update_Room.UseVisualStyleBackColor = true;
            this.btn_Update_Room.Click += new System.EventHandler(this.btn_Update_Room_Click);
            // 
            // btn_Delete_Charges
            // 
            this.btn_Delete_Charges.Location = new System.Drawing.Point(737, 428);
            this.btn_Delete_Charges.Name = "btn_Delete_Charges";
            this.btn_Delete_Charges.Size = new System.Drawing.Size(435, 70);
            this.btn_Delete_Charges.TabIndex = 13;
            this.btn_Delete_Charges.Text = "Remove Charges";
            this.btn_Delete_Charges.UseVisualStyleBackColor = true;
            this.btn_Delete_Charges.Click += new System.EventHandler(this.btn_Delete_Charges_Click);
            // 
            // btn_Delete_Guest
            // 
            this.btn_Delete_Guest.Location = new System.Drawing.Point(1027, 361);
            this.btn_Delete_Guest.Name = "btn_Delete_Guest";
            this.btn_Delete_Guest.Size = new System.Drawing.Size(145, 61);
            this.btn_Delete_Guest.TabIndex = 12;
            this.btn_Delete_Guest.Text = "Remove Guest";
            this.btn_Delete_Guest.UseVisualStyleBackColor = true;
            this.btn_Delete_Guest.Click += new System.EventHandler(this.btn_Delete_Guest_Click);
            // 
            // btn_Delete_Room
            // 
            this.btn_Delete_Room.Location = new System.Drawing.Point(881, 361);
            this.btn_Delete_Room.Name = "btn_Delete_Room";
            this.btn_Delete_Room.Size = new System.Drawing.Size(140, 61);
            this.btn_Delete_Room.TabIndex = 11;
            this.btn_Delete_Room.Text = "Remove Room";
            this.btn_Delete_Room.UseVisualStyleBackColor = true;
            this.btn_Delete_Room.Click += new System.EventHandler(this.btn_Delete_Room_Click);
            // 
            // btn_Delete_Booking
            // 
            this.btn_Delete_Booking.Location = new System.Drawing.Point(737, 361);
            this.btn_Delete_Booking.Name = "btn_Delete_Booking";
            this.btn_Delete_Booking.Size = new System.Drawing.Size(135, 61);
            this.btn_Delete_Booking.TabIndex = 10;
            this.btn_Delete_Booking.Text = "Remove Booking";
            this.btn_Delete_Booking.UseVisualStyleBackColor = true;
            this.btn_Delete_Booking.Click += new System.EventHandler(this.btn_Delete_Booking_Click);
            // 
            // lbl_Delete
            // 
            this.lbl_Delete.BackColor = System.Drawing.Color.Transparent;
            this.lbl_Delete.Font = new System.Drawing.Font("Arial", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Delete.Location = new System.Drawing.Point(881, 313);
            this.lbl_Delete.Name = "lbl_Delete";
            this.lbl_Delete.Size = new System.Drawing.Size(140, 45);
            this.lbl_Delete.TabIndex = 9;
            this.lbl_Delete.Text = "Delete";
            this.lbl_Delete.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label1
            // 
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Arial", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(225, 313);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(210, 45);
            this.label1.TabIndex = 14;
            this.label1.Text = "Account Control";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btn_ChangePassword
            // 
            this.btn_ChangePassword.Location = new System.Drawing.Point(324, 437);
            this.btn_ChangePassword.Name = "btn_ChangePassword";
            this.btn_ChangePassword.Size = new System.Drawing.Size(212, 61);
            this.btn_ChangePassword.TabIndex = 15;
            this.btn_ChangePassword.Text = "Change My Password";
            this.btn_ChangePassword.UseVisualStyleBackColor = true;
            this.btn_ChangePassword.Click += new System.EventHandler(this.btn_ChangePassword_Click);
            // 
            // btn_CreateAcc
            // 
            this.btn_CreateAcc.Location = new System.Drawing.Point(114, 361);
            this.btn_CreateAcc.Name = "btn_CreateAcc";
            this.btn_CreateAcc.Size = new System.Drawing.Size(204, 61);
            this.btn_CreateAcc.TabIndex = 16;
            this.btn_CreateAcc.Text = "Create Account";
            this.btn_CreateAcc.UseVisualStyleBackColor = true;
            this.btn_CreateAcc.Click += new System.EventHandler(this.btn_CreateAcc_Click);
            // 
            // btn_DeleteAcc
            // 
            this.btn_DeleteAcc.Location = new System.Drawing.Point(324, 361);
            this.btn_DeleteAcc.Name = "btn_DeleteAcc";
            this.btn_DeleteAcc.Size = new System.Drawing.Size(212, 61);
            this.btn_DeleteAcc.TabIndex = 17;
            this.btn_DeleteAcc.Text = "Delete Account";
            this.btn_DeleteAcc.UseVisualStyleBackColor = true;
            this.btn_DeleteAcc.Click += new System.EventHandler(this.btn_DeleteAcc_Click);
            // 
            // btn_EleveateAcc
            // 
            this.btn_EleveateAcc.Location = new System.Drawing.Point(114, 437);
            this.btn_EleveateAcc.Name = "btn_EleveateAcc";
            this.btn_EleveateAcc.Size = new System.Drawing.Size(204, 61);
            this.btn_EleveateAcc.TabIndex = 18;
            this.btn_EleveateAcc.Text = "Change Account Status";
            this.btn_EleveateAcc.UseVisualStyleBackColor = true;
            this.btn_EleveateAcc.Click += new System.EventHandler(this.btn_EleveateAcc_Click);
            // 
            // btn_Return
            // 
            this.btn_Return.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Return.Location = new System.Drawing.Point(542, 361);
            this.btn_Return.Name = "btn_Return";
            this.btn_Return.Size = new System.Drawing.Size(189, 137);
            this.btn_Return.TabIndex = 19;
            this.btn_Return.Text = "Logout";
            this.btn_Return.UseVisualStyleBackColor = true;
            this.btn_Return.Click += new System.EventHandler(this.btn_Return_Click);
            // 
            // Form_Menu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::Hotel_Database.Properties.Resources.Sunset;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1184, 562);
            this.Controls.Add(this.btn_Return);
            this.Controls.Add(this.btn_EleveateAcc);
            this.Controls.Add(this.btn_DeleteAcc);
            this.Controls.Add(this.btn_CreateAcc);
            this.Controls.Add(this.btn_ChangePassword);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btn_Delete_Charges);
            this.Controls.Add(this.btn_Delete_Guest);
            this.Controls.Add(this.btn_Delete_Room);
            this.Controls.Add(this.btn_Delete_Booking);
            this.Controls.Add(this.lbl_Delete);
            this.Controls.Add(this.btn_Update_Room_Pricing);
            this.Controls.Add(this.btn_Update_Room);
            this.Controls.Add(this.btn_Update_Guest);
            this.Controls.Add(this.btn_Add_Charge);
            this.Controls.Add(this.btn_Update_Booking);
            this.Controls.Add(this.lbl_Update);
            this.Controls.Add(this.btn_Add_Room);
            this.Controls.Add(this.btn_Add_Guest);
            this.Controls.Add(this.btn_Add_Booking);
            this.Controls.Add(this.lbl_Create);
            this.Controls.Add(this.Tab_Control_Main);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "Form_Menu";
            this.Text = "Hotel Management";
            this.Load += new System.EventHandler(this.Hotel_Management_Load);
            this.Tab_Control_Main.ResumeLayout(false);
            this.Complete_Bookings.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.DGV_Bookings_Simple)).EndInit();
            this.Bookings.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.DGV_Bookings)).EndInit();
            this.Rooms.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.DGV_Rooms)).EndInit();
            this.Guest_Info.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.DGV_GuestInfo)).EndInit();
            this.Charges.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.DGV_Charges)).EndInit();
            this.Room_Prices.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.DGV_Room_Pricing)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl Tab_Control_Main;
        private System.Windows.Forms.TabPage Complete_Bookings;
        private System.Windows.Forms.DataGridView DGV_Bookings_Simple;
        private System.Windows.Forms.TabPage Bookings;
        private System.Windows.Forms.DataGridView DGV_Bookings;
        private System.Windows.Forms.TabPage Rooms;
        private System.Windows.Forms.DataGridView DGV_Rooms;
        private System.Windows.Forms.TabPage Guest_Info;
        private System.Windows.Forms.DataGridView DGV_GuestInfo;
        private System.Windows.Forms.TabPage Charges;
        private System.Windows.Forms.DataGridView DGV_Charges;
        private System.Windows.Forms.TabPage Room_Prices;
        private System.Windows.Forms.DataGridView DGV_Room_Pricing;
        private System.Windows.Forms.Label lbl_Create;
        private System.Windows.Forms.Button btn_Add_Booking;
        private System.Windows.Forms.Button btn_Add_Guest;
        private System.Windows.Forms.Button btn_Add_Room;
        private System.Windows.Forms.Button btn_Update_Guest;
        private System.Windows.Forms.Button btn_Add_Charge;
        private System.Windows.Forms.Button btn_Update_Booking;
        private System.Windows.Forms.Label lbl_Update;
        private System.Windows.Forms.Button btn_Update_Room_Pricing;
        private System.Windows.Forms.Button btn_Update_Room;
        private System.Windows.Forms.Button btn_Delete_Charges;
        private System.Windows.Forms.Button btn_Delete_Guest;
        private System.Windows.Forms.Button btn_Delete_Room;
        private System.Windows.Forms.Button btn_Delete_Booking;
        private System.Windows.Forms.Label lbl_Delete;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btn_ChangePassword;
        private System.Windows.Forms.Button btn_CreateAcc;
        private System.Windows.Forms.Button btn_DeleteAcc;
        private System.Windows.Forms.Button btn_EleveateAcc;
        private System.Windows.Forms.Button btn_Return;
    }
}

