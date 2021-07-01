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

        public void Form1_Load(object sender, EventArgs e)
        {
            select_Gender.SelectedIndex = 0; //at index 0 is the label "--select gender--" 
        }

        //When the ENTER key is pressed, the cursor or ibeam will go to the next textbox
        private void Suffix_input_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                firstName_input.Focus(); 
            }
        }

        private void FirstName_input_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                middleName_input.Focus(); 
            }
        }

        private void MiddleName_input_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                lastName_input.Focus(); 
            }
        }

        private void LastName_input_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                select_Gender.Focus(); 
            }
        }

        private void Select_Gender_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                birthDate_maskedInput.Focus(); 
            }
        }

        private void BirthDate_maskedInput_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                homeAddress_input.Focus(); 
            }
        }

        private void HomeAddress_input_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                email_input.Focus(); 
            }
        }

        private void Email_input_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                mobileNumber_maskediInput.Focus(); 
            }
        }

        private void MobileNumber_maskediInput_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                submit_Btn.PerformClick(); //press ENTER to submit after finish inputting the required info
            }
        }

        //Submit button
        public void Submit_Btn_Click(object sender, EventArgs e)
        {
            String minor = "";

            if (Check_ifMinor.Checked)  //if user checked the box means they are signing up for a minor
                minor = "Under the age of 18";

            //required information
            if ((firstName_input.Text == "") || (lastName_input.Text == "") || (select_Gender.Text == "") || (birthDate_maskedInput.Text == "") ||
                (homeAddress_input.Text == "") || (mobileNumber_maskediInput.Text == ""))
            {
                MessageBox.Show("You must input the required information");
            }
            else if(checkAgree.CheckState != CheckState.Checked) //Confirming if the user agree to the Data Policy
            {
                MessageBox.Show("You must agree to Data Privacy Statement.");
            }
            else //confirmed or user agreed
            {
                //creating a file for one user
                StreamWriter outputFile;       
                outputFile = File.CreateText("Personal Information.txt");
                outputFile.WriteLine(minor);
                outputFile.WriteLine(SuffixNameLabel.Text + ": " + suffix_input.Text);
                outputFile.WriteLine(FirstNameLabel.Text + ": " + firstName_input.Text);
                outputFile.WriteLine(MiddleNameLabel.Text + ": " + middleName_input.Text);
                outputFile.WriteLine(LastNameLabel.Text + ": " + lastName_input.Text);
                outputFile.WriteLine(GenderLabel.Text + ": " + select_Gender.Text);
                outputFile.WriteLine(BirthdateLabel.Text + ": " + birthDate_maskedInput.Text);
                outputFile.WriteLine(HomeAddressLabel.Text + ": " + homeAddress_input.Text);
                outputFile.WriteLine(EmailLabel.Text + ": " + email_input.Text);
                outputFile.WriteLine(MobileNumberLabel.Text + ": " + mobileNumber_maskediInput.Text);
                outputFile.WriteLine("*******************************************************");
                outputFile.Close();

                //file for admin only who can access all the users' information
                StreamWriter allOutput;        
                allOutput = File.AppendText("Contact Tracing Information.txt");
                allOutput.WriteLine(minor);
                allOutput.WriteLine(SuffixNameLabel.Text + ": " + suffix_input.Text);
                allOutput.WriteLine(FirstNameLabel.Text + ": " + firstName_input.Text);
                allOutput.WriteLine(MiddleNameLabel.Text + ": " + middleName_input.Text);
                allOutput.WriteLine(LastNameLabel.Text + ": " + lastName_input.Text);
                allOutput.WriteLine(GenderLabel.Text + ": " + select_Gender.Text);
                allOutput.WriteLine(BirthdateLabel.Text + ": " + birthDate_maskedInput.Text);
                allOutput.WriteLine(HomeAddressLabel.Text + ": " + homeAddress_input.Text);
                allOutput.WriteLine(EmailLabel.Text + ": " + email_input.Text);
                allOutput.WriteLine(MobileNumberLabel.Text + ": " + mobileNumber_maskediInput.Text);
                allOutput.WriteLine("*******************************************************");
                allOutput.Close();

                //file that can read by a user, to check the details they input
                StreamReader inputFile;     
                inputFile = File.OpenText("Personal Information.txt");
                MessageBox.Show(inputFile.ReadToEnd());
                inputFile.Close();
            }
        }

        //when click, statement about data privacy is showed
        private void Data_PrivacyLabel_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            MessageBox.Show("The developer respects your individual privacy and protects any personal" +
                " information that you share with this contact tracing application. We commit to secure" +
                " the individual's right to privacy and ensure the credibility of procesing of individual's" +
                " personal information.", "DATA PRIVACY STATEMENT");
        }

        //close the application
        private void Cancel_Btn_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        //submitting new information
        private void SubmitAnotherLabel_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Check_ifMinor.Checked = false;
            suffix_input.Clear();
            firstName_input.Clear();
            middleName_input.Clear();
            lastName_input.Clear();
            select_Gender.SelectedIndex = 0;
            birthDate_maskedInput.Clear();
            homeAddress_input.Clear();
            email_input.Clear();
            mobileNumber_maskediInput.Clear();
            checkAgree.Checked = false;
        }

        //access to admin window to log in
        private void AdminLabel_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Form Adminlogin = new Form2();
            Adminlogin.Show();
            this.WindowState = FormWindowState.Minimized; //when the admin window popped up, contact tracing app minimize
        }
    }
}
