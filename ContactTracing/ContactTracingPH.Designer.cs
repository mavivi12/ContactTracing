
namespace ContactTracing
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.select_Gender = new System.Windows.Forms.ComboBox();
            this.ContactTracingLabel = new System.Windows.Forms.Label();
            this.PHLabel = new System.Windows.Forms.Label();
            this.Check_ifMinor = new System.Windows.Forms.CheckBox();
            this.SuffixNameLabel = new System.Windows.Forms.Label();
            this.FirstNameLabel = new System.Windows.Forms.Label();
            this.MiddleNameLabel = new System.Windows.Forms.Label();
            this.LastNameLabel = new System.Windows.Forms.Label();
            this.GenderLabel = new System.Windows.Forms.Label();
            this.BirthdateLabel = new System.Windows.Forms.Label();
            this.HomeAddressLabel = new System.Windows.Forms.Label();
            this.EmailLabel = new System.Windows.Forms.Label();
            this.MobileNumberLabel = new System.Windows.Forms.Label();
            this.suffix_input = new System.Windows.Forms.TextBox();
            this.firstName_input = new System.Windows.Forms.TextBox();
            this.lastName_input = new System.Windows.Forms.TextBox();
            this.middleName_input = new System.Windows.Forms.TextBox();
            this.homeAddress_input = new System.Windows.Forms.TextBox();
            this.email_input = new System.Windows.Forms.TextBox();
            this.checkAgree = new System.Windows.Forms.CheckBox();
            this.iAgreeLabel = new System.Windows.Forms.Label();
            this.Data_PrivacyLabel = new System.Windows.Forms.LinkLabel();
            this.submit_Btn = new System.Windows.Forms.Button();
            this.cancel_Btn = new System.Windows.Forms.Button();
            this.submitAnotherLabel = new System.Windows.Forms.LinkLabel();
            this.adminLabel = new System.Windows.Forms.LinkLabel();
            this.mobileNumber_maskediInput = new System.Windows.Forms.MaskedTextBox();
            this.birthDate_maskedInput = new System.Windows.Forms.MaskedTextBox();
            this.birthDate_formatLabel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // select_Gender
            // 
            this.select_Gender.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.select_Gender.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.select_Gender.FormattingEnabled = true;
            this.select_Gender.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.select_Gender.Items.AddRange(new object[] {
            "--select gender--",
            "Female",
            "Male"});
            this.select_Gender.Location = new System.Drawing.Point(224, 296);
            this.select_Gender.MaxDropDownItems = 3;
            this.select_Gender.Name = "select_Gender";
            this.select_Gender.Size = new System.Drawing.Size(331, 33);
            this.select_Gender.TabIndex = 15;
            this.select_Gender.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Select_Gender_KeyDown);
            // 
            // ContactTracingLabel
            // 
            this.ContactTracingLabel.AutoSize = true;
            this.ContactTracingLabel.Enabled = false;
            this.ContactTracingLabel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ContactTracingLabel.Font = new System.Drawing.Font("Century Gothic", 48F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.ContactTracingLabel.ForeColor = System.Drawing.Color.MidnightBlue;
            this.ContactTracingLabel.Location = new System.Drawing.Point(33, 13);
            this.ContactTracingLabel.Name = "ContactTracingLabel";
            this.ContactTracingLabel.Size = new System.Drawing.Size(526, 77);
            this.ContactTracingLabel.TabIndex = 28;
            this.ContactTracingLabel.Text = "Contact Tracing";
            // 
            // PHLabel
            // 
            this.PHLabel.AutoSize = true;
            this.PHLabel.Font = new System.Drawing.Font("Century Gothic", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.PHLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.PHLabel.Location = new System.Drawing.Point(388, 78);
            this.PHLabel.Name = "PHLabel";
            this.PHLabel.Size = new System.Drawing.Size(113, 23);
            this.PHLabel.TabIndex = 29;
            this.PHLabel.Text = "Philippines";
            // 
            // Check_ifMinor
            // 
            this.Check_ifMinor.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.Check_ifMinor.AutoSize = true;
            this.Check_ifMinor.Font = new System.Drawing.Font("Quicksand", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.Check_ifMinor.ForeColor = System.Drawing.Color.White;
            this.Check_ifMinor.Location = new System.Drawing.Point(33, 111);
            this.Check_ifMinor.Name = "Check_ifMinor";
            this.Check_ifMinor.Size = new System.Drawing.Size(270, 28);
            this.Check_ifMinor.TabIndex = 10;
            this.Check_ifMinor.Text = "Check if filling up for a minor";
            this.Check_ifMinor.UseVisualStyleBackColor = true;
            // 
            // SuffixNameLabel
            // 
            this.SuffixNameLabel.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.SuffixNameLabel.AutoSize = true;
            this.SuffixNameLabel.Enabled = false;
            this.SuffixNameLabel.Font = new System.Drawing.Font("Quicksand", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.SuffixNameLabel.ForeColor = System.Drawing.Color.AliceBlue;
            this.SuffixNameLabel.Location = new System.Drawing.Point(49, 143);
            this.SuffixNameLabel.Name = "SuffixNameLabel";
            this.SuffixNameLabel.Size = new System.Drawing.Size(64, 28);
            this.SuffixNameLabel.TabIndex = 4;
            this.SuffixNameLabel.Text = "Suffix";
            // 
            // FirstNameLabel
            // 
            this.FirstNameLabel.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.FirstNameLabel.AutoSize = true;
            this.FirstNameLabel.Enabled = false;
            this.FirstNameLabel.Font = new System.Drawing.Font("Quicksand", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.FirstNameLabel.ForeColor = System.Drawing.Color.AliceBlue;
            this.FirstNameLabel.Location = new System.Drawing.Point(49, 180);
            this.FirstNameLabel.Name = "FirstNameLabel";
            this.FirstNameLabel.Size = new System.Drawing.Size(124, 28);
            this.FirstNameLabel.TabIndex = 1;
            this.FirstNameLabel.Text = "*First Name";
            // 
            // MiddleNameLabel
            // 
            this.MiddleNameLabel.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.MiddleNameLabel.AutoSize = true;
            this.MiddleNameLabel.Enabled = false;
            this.MiddleNameLabel.Font = new System.Drawing.Font("Quicksand", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.MiddleNameLabel.ForeColor = System.Drawing.Color.AliceBlue;
            this.MiddleNameLabel.Location = new System.Drawing.Point(49, 219);
            this.MiddleNameLabel.Name = "MiddleNameLabel";
            this.MiddleNameLabel.Size = new System.Drawing.Size(138, 28);
            this.MiddleNameLabel.TabIndex = 2;
            this.MiddleNameLabel.Text = "Middle Name";
            // 
            // LastNameLabel
            // 
            this.LastNameLabel.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.LastNameLabel.AutoSize = true;
            this.LastNameLabel.Enabled = false;
            this.LastNameLabel.Font = new System.Drawing.Font("Quicksand", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.LastNameLabel.ForeColor = System.Drawing.Color.AliceBlue;
            this.LastNameLabel.Location = new System.Drawing.Point(49, 257);
            this.LastNameLabel.Name = "LastNameLabel";
            this.LastNameLabel.Size = new System.Drawing.Size(122, 28);
            this.LastNameLabel.TabIndex = 3;
            this.LastNameLabel.Text = "*Last Name";
            // 
            // GenderLabel
            // 
            this.GenderLabel.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.GenderLabel.AutoSize = true;
            this.GenderLabel.Enabled = false;
            this.GenderLabel.Font = new System.Drawing.Font("Quicksand", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.GenderLabel.ForeColor = System.Drawing.Color.AliceBlue;
            this.GenderLabel.Location = new System.Drawing.Point(49, 297);
            this.GenderLabel.Name = "GenderLabel";
            this.GenderLabel.Size = new System.Drawing.Size(89, 28);
            this.GenderLabel.TabIndex = 6;
            this.GenderLabel.Text = "*Gender";
            // 
            // BirthdateLabel
            // 
            this.BirthdateLabel.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.BirthdateLabel.AutoSize = true;
            this.BirthdateLabel.Enabled = false;
            this.BirthdateLabel.Font = new System.Drawing.Font("Quicksand", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.BirthdateLabel.ForeColor = System.Drawing.Color.AliceBlue;
            this.BirthdateLabel.Location = new System.Drawing.Point(49, 330);
            this.BirthdateLabel.Name = "BirthdateLabel";
            this.BirthdateLabel.Size = new System.Drawing.Size(116, 28);
            this.BirthdateLabel.TabIndex = 7;
            this.BirthdateLabel.Text = "*Birth Date";
            // 
            // HomeAddressLabel
            // 
            this.HomeAddressLabel.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.HomeAddressLabel.AutoSize = true;
            this.HomeAddressLabel.Enabled = false;
            this.HomeAddressLabel.Font = new System.Drawing.Font("Quicksand", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.HomeAddressLabel.ForeColor = System.Drawing.Color.AliceBlue;
            this.HomeAddressLabel.Location = new System.Drawing.Point(49, 373);
            this.HomeAddressLabel.Name = "HomeAddressLabel";
            this.HomeAddressLabel.Size = new System.Drawing.Size(159, 28);
            this.HomeAddressLabel.TabIndex = 8;
            this.HomeAddressLabel.Text = "*Home Address";
            // 
            // EmailLabel
            // 
            this.EmailLabel.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.EmailLabel.AutoSize = true;
            this.EmailLabel.Enabled = false;
            this.EmailLabel.Font = new System.Drawing.Font("Quicksand", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.EmailLabel.ForeColor = System.Drawing.Color.AliceBlue;
            this.EmailLabel.Location = new System.Drawing.Point(49, 412);
            this.EmailLabel.Name = "EmailLabel";
            this.EmailLabel.Size = new System.Drawing.Size(64, 28);
            this.EmailLabel.TabIndex = 9;
            this.EmailLabel.Text = "Email";
            // 
            // MobileNumberLabel
            // 
            this.MobileNumberLabel.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.MobileNumberLabel.AutoSize = true;
            this.MobileNumberLabel.Enabled = false;
            this.MobileNumberLabel.Font = new System.Drawing.Font("Quicksand", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.MobileNumberLabel.ForeColor = System.Drawing.Color.AliceBlue;
            this.MobileNumberLabel.Location = new System.Drawing.Point(49, 450);
            this.MobileNumberLabel.Name = "MobileNumberLabel";
            this.MobileNumberLabel.Size = new System.Drawing.Size(165, 28);
            this.MobileNumberLabel.TabIndex = 10;
            this.MobileNumberLabel.Text = "*Mobile Number";
            // 
            // suffix_input
            // 
            this.suffix_input.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.suffix_input.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.suffix_input.Location = new System.Drawing.Point(224, 142);
            this.suffix_input.Name = "suffix_input";
            this.suffix_input.PlaceholderText = "Suffix(e.g Sr., Jr., III)";
            this.suffix_input.Size = new System.Drawing.Size(331, 32);
            this.suffix_input.TabIndex = 11;
            this.suffix_input.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Suffix_input_KeyDown);
            // 
            // firstName_input
            // 
            this.firstName_input.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.firstName_input.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.firstName_input.Location = new System.Drawing.Point(224, 180);
            this.firstName_input.Name = "firstName_input";
            this.firstName_input.PlaceholderText = "First Name";
            this.firstName_input.Size = new System.Drawing.Size(331, 32);
            this.firstName_input.TabIndex = 12;
            this.firstName_input.KeyDown += new System.Windows.Forms.KeyEventHandler(this.FirstName_input_KeyDown);
            // 
            // lastName_input
            // 
            this.lastName_input.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.lastName_input.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lastName_input.Location = new System.Drawing.Point(224, 256);
            this.lastName_input.Name = "lastName_input";
            this.lastName_input.PlaceholderText = "Last Name";
            this.lastName_input.Size = new System.Drawing.Size(331, 32);
            this.lastName_input.TabIndex = 14;
            this.lastName_input.KeyDown += new System.Windows.Forms.KeyEventHandler(this.LastName_input_KeyDown);
            // 
            // middleName_input
            // 
            this.middleName_input.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.middleName_input.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.middleName_input.Location = new System.Drawing.Point(224, 218);
            this.middleName_input.Name = "middleName_input";
            this.middleName_input.PlaceholderText = "Middle Name";
            this.middleName_input.Size = new System.Drawing.Size(331, 32);
            this.middleName_input.TabIndex = 13;
            this.middleName_input.KeyDown += new System.Windows.Forms.KeyEventHandler(this.MiddleName_input_KeyDown);
            // 
            // homeAddress_input
            // 
            this.homeAddress_input.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.homeAddress_input.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.homeAddress_input.Location = new System.Drawing.Point(224, 373);
            this.homeAddress_input.Name = "homeAddress_input";
            this.homeAddress_input.PlaceholderText = "Home Address";
            this.homeAddress_input.Size = new System.Drawing.Size(331, 32);
            this.homeAddress_input.TabIndex = 17;
            this.homeAddress_input.KeyDown += new System.Windows.Forms.KeyEventHandler(this.HomeAddress_input_KeyDown);
            // 
            // email_input
            // 
            this.email_input.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.email_input.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.email_input.Location = new System.Drawing.Point(224, 411);
            this.email_input.Name = "email_input";
            this.email_input.PlaceholderText = "Email";
            this.email_input.Size = new System.Drawing.Size(331, 32);
            this.email_input.TabIndex = 18;
            this.email_input.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Email_input_KeyDown);
            // 
            // checkAgree
            // 
            this.checkAgree.AutoSize = true;
            this.checkAgree.Font = new System.Drawing.Font("Quicksand", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.checkAgree.Location = new System.Drawing.Point(54, 500);
            this.checkAgree.Name = "checkAgree";
            this.checkAgree.Size = new System.Drawing.Size(15, 14);
            this.checkAgree.TabIndex = 20;
            this.checkAgree.UseVisualStyleBackColor = true;
            // 
            // iAgreeLabel
            // 
            this.iAgreeLabel.AutoSize = true;
            this.iAgreeLabel.Font = new System.Drawing.Font("Quicksand", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.iAgreeLabel.Location = new System.Drawing.Point(75, 494);
            this.iAgreeLabel.Name = "iAgreeLabel";
            this.iAgreeLabel.Size = new System.Drawing.Size(81, 24);
            this.iAgreeLabel.TabIndex = 26;
            this.iAgreeLabel.Text = "I Agree to";
            // 
            // Data_PrivacyLabel
            // 
            this.Data_PrivacyLabel.AutoSize = true;
            this.Data_PrivacyLabel.Font = new System.Drawing.Font("Quicksand", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.Data_PrivacyLabel.Location = new System.Drawing.Point(153, 494);
            this.Data_PrivacyLabel.Name = "Data_PrivacyLabel";
            this.Data_PrivacyLabel.Size = new System.Drawing.Size(185, 24);
            this.Data_PrivacyLabel.TabIndex = 21;
            this.Data_PrivacyLabel.TabStop = true;
            this.Data_PrivacyLabel.Text = "Data Privacy Statement";
            this.Data_PrivacyLabel.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.Data_PrivacyLabel_LinkClicked);
            // 
            // submit_Btn
            // 
            this.submit_Btn.AutoSize = true;
            this.submit_Btn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.submit_Btn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.submit_Btn.FlatAppearance.BorderSize = 0;
            this.submit_Btn.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Navy;
            this.submit_Btn.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Navy;
            this.submit_Btn.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.submit_Btn.Font = new System.Drawing.Font("Quicksand", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.submit_Btn.ForeColor = System.Drawing.Color.White;
            this.submit_Btn.Location = new System.Drawing.Point(358, 538);
            this.submit_Btn.Name = "submit_Btn";
            this.submit_Btn.Size = new System.Drawing.Size(91, 38);
            this.submit_Btn.TabIndex = 24;
            this.submit_Btn.Text = "&Submit";
            this.submit_Btn.UseVisualStyleBackColor = false;
            this.submit_Btn.Click += new System.EventHandler(this.Submit_Btn_Click);
            // 
            // cancel_Btn
            // 
            this.cancel_Btn.AutoSize = true;
            this.cancel_Btn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.cancel_Btn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.cancel_Btn.FlatAppearance.BorderSize = 0;
            this.cancel_Btn.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Navy;
            this.cancel_Btn.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Navy;
            this.cancel_Btn.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.cancel_Btn.Font = new System.Drawing.Font("Quicksand", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.cancel_Btn.ForeColor = System.Drawing.Color.White;
            this.cancel_Btn.Location = new System.Drawing.Point(464, 538);
            this.cancel_Btn.Name = "cancel_Btn";
            this.cancel_Btn.Size = new System.Drawing.Size(91, 38);
            this.cancel_Btn.TabIndex = 25;
            this.cancel_Btn.Text = "&Cancel";
            this.cancel_Btn.UseVisualStyleBackColor = false;
            this.cancel_Btn.Click += new System.EventHandler(this.Cancel_Btn_Click);
            // 
            // submitAnotherLabel
            // 
            this.submitAnotherLabel.AutoSize = true;
            this.submitAnotherLabel.Font = new System.Drawing.Font("Quicksand", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.submitAnotherLabel.LinkColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.submitAnotherLabel.Location = new System.Drawing.Point(49, 538);
            this.submitAnotherLabel.Name = "submitAnotherLabel";
            this.submitAnotherLabel.Size = new System.Drawing.Size(196, 24);
            this.submitAnotherLabel.TabIndex = 30;
            this.submitAnotherLabel.TabStop = true;
            this.submitAnotherLabel.Text = "Submit another response";
            this.submitAnotherLabel.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.SubmitAnotherLabel_LinkClicked);
            // 
            // adminLabel
            // 
            this.adminLabel.AutoSize = true;
            this.adminLabel.Font = new System.Drawing.Font("Quicksand", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.adminLabel.LinkColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.adminLabel.Location = new System.Drawing.Point(49, 562);
            this.adminLabel.Name = "adminLabel";
            this.adminLabel.Size = new System.Drawing.Size(179, 24);
            this.adminLabel.TabIndex = 31;
            this.adminLabel.TabStop = true;
            this.adminLabel.Text = "Access Data as ADMIN";
            this.adminLabel.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.AdminLabel_LinkClicked);
            // 
            // mobileNumber_maskediInput
            // 
            this.mobileNumber_maskediInput.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.mobileNumber_maskediInput.Location = new System.Drawing.Point(224, 449);
            this.mobileNumber_maskediInput.Mask = "(0999) 000-0000";
            this.mobileNumber_maskediInput.Name = "mobileNumber_maskediInput";
            this.mobileNumber_maskediInput.Size = new System.Drawing.Size(331, 32);
            this.mobileNumber_maskediInput.TabIndex = 19;
            this.mobileNumber_maskediInput.Text = "09";
            this.mobileNumber_maskediInput.KeyDown += new System.Windows.Forms.KeyEventHandler(this.MobileNumber_maskediInput_KeyDown);
            // 
            // birthDate_maskedInput
            // 
            this.birthDate_maskedInput.BeepOnError = true;
            this.birthDate_maskedInput.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.birthDate_maskedInput.Location = new System.Drawing.Point(224, 335);
            this.birthDate_maskedInput.Mask = "00/00/0000";
            this.birthDate_maskedInput.Name = "birthDate_maskedInput";
            this.birthDate_maskedInput.PromptChar = '-';
            this.birthDate_maskedInput.Size = new System.Drawing.Size(331, 32);
            this.birthDate_maskedInput.TabIndex = 16;
            this.birthDate_maskedInput.TextMaskFormat = System.Windows.Forms.MaskFormat.IncludePrompt;
            this.birthDate_maskedInput.ValidatingType = typeof(System.DateTime);
            this.birthDate_maskedInput.KeyDown += new System.Windows.Forms.KeyEventHandler(this.BirthDate_maskedInput_KeyDown);
            // 
            // birthDate_formatLabel
            // 
            this.birthDate_formatLabel.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.birthDate_formatLabel.AutoSize = true;
            this.birthDate_formatLabel.Enabled = false;
            this.birthDate_formatLabel.Font = new System.Drawing.Font("Quicksand", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.birthDate_formatLabel.ForeColor = System.Drawing.Color.AliceBlue;
            this.birthDate_formatLabel.Location = new System.Drawing.Point(50, 352);
            this.birthDate_formatLabel.Name = "birthDate_formatLabel";
            this.birthDate_formatLabel.Size = new System.Drawing.Size(106, 18);
            this.birthDate_formatLabel.TabIndex = 34;
            this.birthDate_formatLabel.Text = "(MM/DD/YYYY)";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.ClientSize = new System.Drawing.Size(595, 606);
            this.Controls.Add(this.birthDate_formatLabel);
            this.Controls.Add(this.birthDate_maskedInput);
            this.Controls.Add(this.mobileNumber_maskediInput);
            this.Controls.Add(this.adminLabel);
            this.Controls.Add(this.submitAnotherLabel);
            this.Controls.Add(this.cancel_Btn);
            this.Controls.Add(this.submit_Btn);
            this.Controls.Add(this.Data_PrivacyLabel);
            this.Controls.Add(this.iAgreeLabel);
            this.Controls.Add(this.checkAgree);
            this.Controls.Add(this.email_input);
            this.Controls.Add(this.homeAddress_input);
            this.Controls.Add(this.select_Gender);
            this.Controls.Add(this.middleName_input);
            this.Controls.Add(this.lastName_input);
            this.Controls.Add(this.firstName_input);
            this.Controls.Add(this.suffix_input);
            this.Controls.Add(this.MobileNumberLabel);
            this.Controls.Add(this.EmailLabel);
            this.Controls.Add(this.HomeAddressLabel);
            this.Controls.Add(this.BirthdateLabel);
            this.Controls.Add(this.GenderLabel);
            this.Controls.Add(this.LastNameLabel);
            this.Controls.Add(this.MiddleNameLabel);
            this.Controls.Add(this.FirstNameLabel);
            this.Controls.Add(this.SuffixNameLabel);
            this.Controls.Add(this.Check_ifMinor);
            this.Controls.Add(this.PHLabel);
            this.Controls.Add(this.ContactTracingLabel);
            this.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Contact Tracing PH";
            this.TopMost = true;
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label ContactTracingLabel;
        private System.Windows.Forms.Label PHLabel;
        private System.Windows.Forms.CheckBox Check_ifMinor;
        private System.Windows.Forms.Label FirstNameLabel;
        private System.Windows.Forms.Label MiddleNameLabel;
        private System.Windows.Forms.Label LastNameLabel;
        private System.Windows.Forms.Label GenderLabel;
        private System.Windows.Forms.Label BirthdateLabel;
        private System.Windows.Forms.Label birthDate_formatLabel;
        private System.Windows.Forms.Label HomeAddressLabel;
        private System.Windows.Forms.Label EmailLabel;
        private System.Windows.Forms.Label MobileNumberLabel;
        private System.Windows.Forms.TextBox suffix_input;
        private System.Windows.Forms.TextBox firstName_input;
        private System.Windows.Forms.TextBox lastName_input;
        private System.Windows.Forms.TextBox middleName_input;
        private System.Windows.Forms.ComboBox select_Gender;
        private System.Windows.Forms.MaskedTextBox birthDate_maskedInput;
        private System.Windows.Forms.TextBox homeAddress_input;
        private System.Windows.Forms.TextBox email_input;
        private System.Windows.Forms.MaskedTextBox mobileNumber_maskediInput;
        private System.Windows.Forms.CheckBox checkAgree;
        private System.Windows.Forms.Label iAgreeLabel;
        private System.Windows.Forms.LinkLabel Data_PrivacyLabel;
        private System.Windows.Forms.Button submit_Btn;
        private System.Windows.Forms.Button cancel_Btn;
        private System.Windows.Forms.LinkLabel submitAnotherLabel;
        private System.Windows.Forms.LinkLabel adminLabel;
        private System.Windows.Forms.Label SuffixNameLabel;
    }
}

