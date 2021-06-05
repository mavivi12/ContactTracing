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
        public Form2()
        {
            InitializeComponent();
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
            else
            {
                do
                {
                    int attempt = 0;

                    MessageBox.Show("Incorrect username or password.", "ACCESS DENIED");

                    attempt++;
                    numOfAttemptLabel.Text = attempt.ToString();
                } while (numOfAttemptLabel.Text == "3");

                if(numOfAttemptLabel.Text == "3")
                {
                    MessageBox.Show("Attempted 3 times!\nIncorrect username or password.\n" +
                        "This program will close.", "ACCESS DENIED");
                    this.Close();
                }
                //do
                //{
                //    attempt++;
                //    numOfAttemptLabel.Text = attempt.ToString();
                //    MessageBox.Show("Incorrect username or password.", "ACCESS DENIED");

                //    username_inp

                //} while (attempt <= 2);

                //if (numOfAttemptLabel.Text == "3")
                //{
                //    this.Close();
                //}

                ////for (attempt = 0; attempt <= 3; attempt++)
                ////{
                ////    numOfAttemptLabel.Text = attempt.ToString();
                ////    MessageBox.Show("Incorrect username or password.", "ACCESS DENIED");

                ////}


            }
        }

        private void CancelBtn_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
