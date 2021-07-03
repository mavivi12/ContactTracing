using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ContactTracing
{
    public partial class Form2 : Form
    {
        int attempt = 0;

        public Form2()
        {
            InitializeComponent();
        }

        private void Username_input_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                password_input.Focus();
            }
        }

        private void Password_input_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                loginBtn.PerformClick();
            }
        }

        private void LoginBtn_Click(object sender, EventArgs e)
        {
            if ((username_input.Text == "admin") && (password_input.Text == "PASSWORD"))
            {
                MessageBox.Show("Login successfully!", "ACCESS GRANTED");
                this.Close();

                StreamReader allinfo;
                allinfo = File.OpenText("Contact Tracing Information.txt");
                MessageBox.Show(allinfo.ReadToEnd());
                allinfo.Close();
            }
            else if ((username_input.Text == "") || (password_input.Text == ""))
            {
                MessageBox.Show("Please enter username and password.", "ACCESS DENIED");
                attempt += 1;
                numOfAttemptLabel.Text = attempt.ToString();
                username_input.Clear();
                password_input.Clear();
            }
            else 
            {
                MessageBox.Show("Incorrect username and/or password.", "ACCESS DENIED");

                attempt += 1;                                      
                numOfAttemptLabel.Text = attempt.ToString();       
                username_input.Clear();                           
                password_input.Clear();

                if (numOfAttemptLabel.Text == "3")  
                {
                    MessageBox.Show("Attempted 3 times!\nIncorrect username and/or password.\n" +
                        "This window will close.", "ACCESS DENIED");
                    this.Close();
                }
            }
        }

        private void CancelBtn_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
