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

        private void Submit_Btn_Click(object sender, EventArgs e)
        {
            StreamWriter outputFile;
            outputFile = File.AppendText("Contact Tracing.txt");
            outputFile.WriteLine(SuffixNameLabel + ": " + suffix_input.Text);
            outputFile.WriteLine(FirstNameLabel.Text + ": " + firstName_input.Text);
            outputFile.WriteLine(MiddleNameLabel.Text + ": " + middleName_input.Text);
            outputFile.WriteLine(LastNameLabel.Text + ": " + lastName_input.Text);
            outputFile.WriteLine(GenderLabel.Text + ": " + select_Gender.Text);
            outputFile.WriteLine(BirthdateLabel.Text + ": " + birthDate_input.Text);
            outputFile.WriteLine(HomeAddressLabel.Text + ": " + homeAddress_input.Text);
            outputFile.WriteLine(EmailLabel.Text + ": " + email_input.Text);
            outputFile.WriteLine(MobileNumberLabel.Text + ": " + mobileNumber_input.Text);
            outputFile.WriteLine("*******************************************************");
            outputFile.Close();

            StreamReader inputFile;
            inputFile = File.OpenText("Contact Tracing.txt");
            MessageBox.Show(inputFile.ReadToEnd());
            inputFile.Close();
        }
    }
}
