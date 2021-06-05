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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            select_Gender.SelectedIndex = 0;
        }

        private void MobileNumber_input_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((!char.IsNumber(e.KeyChar)) && (!char.IsControl(e.KeyChar)))
            {
                e.Handled = true;
            }
        }

        private void Data_PrivacyLabel_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            MessageBox.Show("The developer respects your individual privacy and protects any personal" +
                " information that youshare with this contact tracing application. We commit to secure" +
                " the individual's right to privacy and ensure the credibility of procesing of individual's" +
                " personal information", "DATA PRIVACY STATEMENT");
        }

        private void Submit_Btn_Click(object sender, EventArgs e)
        {
            String minor = "";

            if (Check_ifMinor.Checked)
            {
                minor += "Under the age of 18";

            }

            if (checkAgree.CheckState != CheckState.Checked)
            {
                MessageBox.Show("You must agree to Data Privacy Statement");
            }
            else
            {
                StreamWriter outputFile;
                outputFile = File.AppendText("Contact Tracing Information.txt");
                outputFile.WriteLine(minor);
                outputFile.WriteLine(SuffixNameLabel + ": " + suffix_input.Text);
                outputFile.WriteLine(FirstNameLabel.Text + ": " + firstName_input.Text);
                outputFile.WriteLine(MiddleNameLabel.Text + ": " + lastName_input.Text);
                outputFile.WriteLine(LastNameLabel.Text + ": " + middleName_input.Text);
                outputFile.WriteLine(GenderLabel.Text + ": " + select_Gender.Text);
                outputFile.WriteLine(BirthdateLabel.Text + ": " + birthDate_input.Text);
                outputFile.WriteLine(HomeAddressLabel.Text + ": " + homeAddress_input.Text);
                outputFile.WriteLine(EmailLabel.Text + ": " + email_input.Text);
                outputFile.WriteLine(MobileNumberLabel.Text + ": " + mobileNumber_input.Text);
                outputFile.WriteLine("*******************************************************");
                outputFile.Close();

                StreamReader inputFile;
                inputFile = File.OpenText("Contact Tracing Information.txt");
                MessageBox.Show(inputFile.ReadToEnd());
                inputFile.Close();
            }
        }

        private void Cancel_Btn_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void SaveBtn_Click(object sender, EventArgs e)
        {
            
        }
    }
}
