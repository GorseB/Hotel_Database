namespace Hotel_Database.Presentation
{
    partial class Update_Room_Pricing
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Update_Room_Pricing));
            this.lbl_Title = new System.Windows.Forms.Label();
            this.btn_Cancel = new System.Windows.Forms.Button();
            this.btn_Add = new System.Windows.Forms.Button();
            this.lbl_Single_Charge = new System.Windows.Forms.Label();
            this.lbl_Extra_Double = new System.Windows.Forms.Label();
            this.lbl_Double_Charge = new System.Windows.Forms.Label();
            this.lbl_Extra_Single = new System.Windows.Forms.Label();
            this.nud_Double_Charge = new System.Windows.Forms.NumericUpDown();
            this.nud_E_Single = new System.Windows.Forms.NumericUpDown();
            this.nud_E_Double = new System.Windows.Forms.NumericUpDown();
            this.nud_Single_Charge = new System.Windows.Forms.NumericUpDown();
            ((System.ComponentModel.ISupportInitialize)(this.nud_Double_Charge)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nud_E_Single)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nud_E_Double)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nud_Single_Charge)).BeginInit();
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
            this.lbl_Title.Text = "Update Room Pricing";
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
            this.btn_Add.Text = "Update Room Pricing";
            this.btn_Add.UseVisualStyleBackColor = true;
            this.btn_Add.Click += new System.EventHandler(this.btn_Add_Click);
            // 
            // lbl_Single_Charge
            // 
            this.lbl_Single_Charge.AutoSize = true;
            this.lbl_Single_Charge.BackColor = System.Drawing.Color.Transparent;
            this.lbl_Single_Charge.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Single_Charge.Location = new System.Drawing.Point(25, 60);
            this.lbl_Single_Charge.Name = "lbl_Single_Charge";
            this.lbl_Single_Charge.Size = new System.Drawing.Size(108, 18);
            this.lbl_Single_Charge.TabIndex = 14;
            this.lbl_Single_Charge.Text = "Single Charge";
            // 
            // lbl_Extra_Double
            // 
            this.lbl_Extra_Double.AutoSize = true;
            this.lbl_Extra_Double.BackColor = System.Drawing.Color.Transparent;
            this.lbl_Extra_Double.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Extra_Double.Location = new System.Drawing.Point(25, 200);
            this.lbl_Extra_Double.Name = "lbl_Extra_Double";
            this.lbl_Extra_Double.Size = new System.Drawing.Size(154, 18);
            this.lbl_Extra_Double.TabIndex = 15;
            this.lbl_Extra_Double.Text = "Extra Double Charge";
            // 
            // lbl_Double_Charge
            // 
            this.lbl_Double_Charge.AutoSize = true;
            this.lbl_Double_Charge.BackColor = System.Drawing.Color.Transparent;
            this.lbl_Double_Charge.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Double_Charge.Location = new System.Drawing.Point(25, 107);
            this.lbl_Double_Charge.Name = "lbl_Double_Charge";
            this.lbl_Double_Charge.Size = new System.Drawing.Size(114, 18);
            this.lbl_Double_Charge.TabIndex = 16;
            this.lbl_Double_Charge.Text = "Double Charge";
            // 
            // lbl_Extra_Single
            // 
            this.lbl_Extra_Single.AutoSize = true;
            this.lbl_Extra_Single.BackColor = System.Drawing.Color.Transparent;
            this.lbl_Extra_Single.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Extra_Single.Location = new System.Drawing.Point(25, 153);
            this.lbl_Extra_Single.Name = "lbl_Extra_Single";
            this.lbl_Extra_Single.Size = new System.Drawing.Size(148, 18);
            this.lbl_Extra_Single.TabIndex = 17;
            this.lbl_Extra_Single.Text = "Extra Single Charge";
            // 
            // nud_Double_Charge
            // 
            this.nud_Double_Charge.Location = new System.Drawing.Point(200, 109);
            this.nud_Double_Charge.Maximum = new decimal(new int[] {
            9999999,
            0,
            0,
            0});
            this.nud_Double_Charge.Name = "nud_Double_Charge";
            this.nud_Double_Charge.Size = new System.Drawing.Size(120, 20);
            this.nud_Double_Charge.TabIndex = 18;
            // 
            // nud_E_Single
            // 
            this.nud_E_Single.Location = new System.Drawing.Point(200, 153);
            this.nud_E_Single.Maximum = new decimal(new int[] {
            9999999,
            0,
            0,
            0});
            this.nud_E_Single.Name = "nud_E_Single";
            this.nud_E_Single.Size = new System.Drawing.Size(120, 20);
            this.nud_E_Single.TabIndex = 19;
            // 
            // nud_E_Double
            // 
            this.nud_E_Double.Location = new System.Drawing.Point(200, 198);
            this.nud_E_Double.Maximum = new decimal(new int[] {
            9999999,
            0,
            0,
            0});
            this.nud_E_Double.Name = "nud_E_Double";
            this.nud_E_Double.Size = new System.Drawing.Size(120, 20);
            this.nud_E_Double.TabIndex = 20;
            // 
            // nud_Single_Charge
            // 
            this.nud_Single_Charge.Location = new System.Drawing.Point(200, 63);
            this.nud_Single_Charge.Maximum = new decimal(new int[] {
            9999999,
            0,
            0,
            0});
            this.nud_Single_Charge.Name = "nud_Single_Charge";
            this.nud_Single_Charge.Size = new System.Drawing.Size(120, 20);
            this.nud_Single_Charge.TabIndex = 21;
            // 
            // Update_Room_Pricing
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::Hotel_Database.Properties.Resources.Sunset;
            this.ClientSize = new System.Drawing.Size(584, 288);
            this.ControlBox = false;
            this.Controls.Add(this.nud_Single_Charge);
            this.Controls.Add(this.nud_E_Double);
            this.Controls.Add(this.nud_E_Single);
            this.Controls.Add(this.nud_Double_Charge);
            this.Controls.Add(this.lbl_Extra_Single);
            this.Controls.Add(this.lbl_Double_Charge);
            this.Controls.Add(this.lbl_Extra_Double);
            this.Controls.Add(this.lbl_Single_Charge);
            this.Controls.Add(this.btn_Add);
            this.Controls.Add(this.btn_Cancel);
            this.Controls.Add(this.lbl_Title);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Update_Room_Pricing";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.Text = "Update Room Pricing";
            ((System.ComponentModel.ISupportInitialize)(this.nud_Double_Charge)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nud_E_Single)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nud_E_Double)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nud_Single_Charge)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbl_Title;
        private System.Windows.Forms.Button btn_Cancel;
        private System.Windows.Forms.Button btn_Add;
        private System.Windows.Forms.Label lbl_Single_Charge;
        private System.Windows.Forms.Label lbl_Extra_Double;
        private System.Windows.Forms.Label lbl_Double_Charge;
        private System.Windows.Forms.Label lbl_Extra_Single;
        private System.Windows.Forms.NumericUpDown nud_Double_Charge;
        private System.Windows.Forms.NumericUpDown nud_E_Single;
        private System.Windows.Forms.NumericUpDown nud_E_Double;
        private System.Windows.Forms.NumericUpDown nud_Single_Charge;
    }
}