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

        private void clock() // simple clock function
        {
            var timer = new System.Timers.Timer();
            timer.Elapsed += function;
            timer.Interval = 10;
            timer.Enabled = true;
            timer.Start();
        }

        private void function(object sender, ElapsedEventArgs e) // more clock
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

        private void SetText(string text) // more clock
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

        private void btn_Login_Click(object sender, EventArgs e) //check to see if the right input was entered, if so, log in.
        {
            if (String.IsNullOrWhiteSpace(txt_User.Text) || String.IsNullOrWhiteSpace(txt_Password.Text))
            {
                MessageBox.Show("Username and Password Required!");
            }
            else if (Data.Database.CheckUser(txt_User.Text, txt_Password.Text))
            {
                Form_Menu Menu = new Form_Menu();
                Menu.Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("Incorrect Username or Password");
            }
        }
    }
}