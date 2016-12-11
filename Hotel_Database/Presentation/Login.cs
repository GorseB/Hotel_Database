using System;
using System.Timers;
using System.Windows.Forms;

namespace Hotel_Database.Presentation
{
    public partial class Login : Form
    {
        private delegate void SetTextCallback(string text);

        public Login()
        {
            InitializeComponent();
            clock();
        }

        private void clock()
        {
            var timer = new System.Timers.Timer();
            timer.Elapsed += function;
            timer.Interval = 10;
            timer.Enabled = true;
            timer.Start();
        }

        private void function(object sender, ElapsedEventArgs e)
        {
            try
            {
                SetText(DateTime.Now.ToString());
            }
            catch (InvalidOperationException ex)
            {
                MessageBox.Show("Error detected:\n" + ex.Message);
            }
        }

        private void SetText(string text)
        {
            if (this.lbl_DateandTime.InvokeRequired)
            {
                var d = new SetTextCallback(SetText);
                this.Invoke(d, new object[] { text });
            }
            else
            {
                this.lbl_DateandTime.Text = text;
            }
        }

        private void btn_Login_Click(object sender, EventArgs e)
        {
            if (String.IsNullOrWhiteSpace(txt_User.Text) || String.IsNullOrWhiteSpace(txt_Password.Text))
            {
                MessageBox.Show("Username and Password Required!");
            }
            else if (Data.Database.CheckUser(txt_User.Text, txt_Password.Text))
            {
                var form = new Presentation.Main();
                form.ShowDialog();
            }
            Clear();
        }

        private void Clear()
        {
            txt_Password.Text = "";
            txt_User.Text = "";
        }
    }
}