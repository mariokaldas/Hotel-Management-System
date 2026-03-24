namespace HotelManagement
{
    partial class Frontend
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
            metroTabPage2 = new TabPage();
            resTotalDataGridView = new DataGridView();
            searchPage = new TabPage();
            searchDataGridView = new DataGridView();
            searchTextBox = new TextBox();
            searchButton = new Button();
            SearchError = new Label();
            reservationPage = new TabPage();
            leftMPanel = new Panel();
            streetAddressTextBox = new TextBox();
            aptTextBox = new TextBox();
            metroLabel6 = new Label();
            cityTextBox = new TextBox();
            lastNameTextBox = new TextBox();
            stateComboBox = new ComboBox();
            phoneNumberTextBox = new TextBox();
            zipTextBox = new TextBox();
            genderLabel = new Label();
            firstNameTextBox = new TextBox();
            phoneNumberLabel = new Label();
            birthdayLabel = new Label();
            genderComboBox = new ComboBox();
            emailTextBox = new TextBox();
            nameLabel = new Label();
            emailLabel = new Label();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            label6 = new Label();
            birthdayDatePicker = new DateTimePicker();
            middlePanel = new Panel();
            choiceLabel = new Label();
            roomTypeComboBox = new ComboBox();
            entryLabel = new Label();
            entryDatePicker = new DateTimePicker();
            floorComboBox = new ComboBox();
            roomNComboBox = new ComboBox();
            depDatePicker = new DateTimePicker();
            submitButton = new Button();
            metroLabel12 = new Label();
            finalizeButton = new Button();
            qtGuestComboBox = new ComboBox();
            foodMenuButton = new Button();
            checkinCheckBox = new CheckBox();
            foodSupplyCheckBox = new CheckBox();
            smsCheckBox = new CheckBox();
            label7 = new Label();
            label8 = new Label();
            label9 = new Label();
            rightMPanel = new Panel();
            updateButton = new Button();
            editButton = new Button();
            deleteButton = new Button();
            newButton = new Button();
            resList = new ComboBox();
            resPanel = new TabControl();
            metroTabPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)resTotalDataGridView).BeginInit();
            searchPage.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)searchDataGridView).BeginInit();
            reservationPage.SuspendLayout();
            leftMPanel.SuspendLayout();
            middlePanel.SuspendLayout();
            rightMPanel.SuspendLayout();
            resPanel.SuspendLayout();
            SuspendLayout();
            // 
            // metroTabPage2
            // 
            metroTabPage2.AutoScroll = true;
            metroTabPage2.Controls.Add(resTotalDataGridView);
            metroTabPage2.Location = new Point(4, 29);
            metroTabPage2.Margin = new Padding(4, 5, 4, 5);
            metroTabPage2.Name = "metroTabPage2";
            metroTabPage2.Size = new Size(1304, 708);
            metroTabPage2.TabIndex = 3;
            metroTabPage2.Text = "Reservation Adv. view";
            metroTabPage2.UseVisualStyleBackColor = true;
            // 
            // resTotalDataGridView
            // 
            resTotalDataGridView.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            resTotalDataGridView.Location = new Point(0, 5);
            resTotalDataGridView.Margin = new Padding(4, 5, 4, 5);
            resTotalDataGridView.Name = "resTotalDataGridView";
            resTotalDataGridView.RowHeadersWidth = 51;
            resTotalDataGridView.Size = new Size(1301, 668);
            resTotalDataGridView.TabIndex = 2;
            // 
            // searchPage
            // 
            searchPage.Controls.Add(SearchError);
            searchPage.Controls.Add(searchButton);
            searchPage.Controls.Add(searchTextBox);
            searchPage.Controls.Add(searchDataGridView);
            searchPage.Location = new Point(4, 29);
            searchPage.Margin = new Padding(4, 5, 4, 5);
            searchPage.Name = "searchPage";
            searchPage.Size = new Size(1304, 708);
            searchPage.TabIndex = 4;
            searchPage.Text = "Universal Search";
            searchPage.UseVisualStyleBackColor = true;
            // 
            // searchDataGridView
            // 
            searchDataGridView.AllowUserToAddRows = false;
            searchDataGridView.AllowUserToDeleteRows = false;
            searchDataGridView.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            searchDataGridView.Dock = DockStyle.Bottom;
            searchDataGridView.Location = new Point(0, 174);
            searchDataGridView.Margin = new Padding(4, 5, 4, 5);
            searchDataGridView.Name = "searchDataGridView";
            searchDataGridView.ReadOnly = true;
            searchDataGridView.RowHeadersWidth = 51;
            searchDataGridView.Size = new Size(1304, 534);
            searchDataGridView.TabIndex = 18;
            // 
            // searchTextBox
            // 
            searchTextBox.BackColor = Color.White;
            searchTextBox.BorderStyle = BorderStyle.FixedSingle;
            searchTextBox.Location = new Point(72, 26);
            searchTextBox.Margin = new Padding(4, 5, 4, 5);
            searchTextBox.Name = "searchTextBox";
            searchTextBox.Size = new Size(951, 27);
            searchTextBox.TabIndex = 15;
            searchTextBox.TextChanged += searchTextBox_TextChanged;
            // 
            // searchButton
            // 
            searchButton.BackColor = Color.Transparent;
            searchButton.BackgroundImageLayout = ImageLayout.Zoom;
            searchButton.Image = Properties.Resources.ic_action_search__3_;
            searchButton.Location = new Point(1031, 17);
            searchButton.Margin = new Padding(4, 5, 4, 5);
            searchButton.Name = "searchButton";
            searchButton.Size = new Size(61, 45);
            searchButton.TabIndex = 17;
            searchButton.UseVisualStyleBackColor = false;
            // 
            // SearchError
            // 
            SearchError.AutoSize = true;
            SearchError.BackColor = SystemColors.ButtonShadow;
            SearchError.Font = new Font("Microsoft Sans Serif", 13F, FontStyle.Regular, GraphicsUnit.Point, 0);
            SearchError.ForeColor = Color.Red;
            SearchError.Location = new Point(473, 368);
            SearchError.Margin = new Padding(4, 0, 4, 0);
            SearchError.Name = "SearchError";
            SearchError.Size = new Size(388, 130);
            SearchError.TabIndex = 19;
            SearchError.Text = "I ran out of entries :( SORRY DUDE.\r\n\r\nYou know, we can make another deal. \r\n\r\nI sure will find something.\r\n";
            SearchError.Visible = false;
            // 
            // reservationPage
            // 
            reservationPage.Controls.Add(rightMPanel);
            reservationPage.Controls.Add(middlePanel);
            reservationPage.Controls.Add(leftMPanel);
            reservationPage.Location = new Point(4, 29);
            reservationPage.Margin = new Padding(4, 5, 4, 5);
            reservationPage.Name = "reservationPage";
            reservationPage.Size = new Size(1304, 708);
            reservationPage.TabIndex = 0;
            reservationPage.Text = "Reservation";
            reservationPage.UseVisualStyleBackColor = true;
            // 
            // leftMPanel
            // 
            leftMPanel.BackColor = Color.FromArgb(225, 225, 225);
            leftMPanel.BackgroundImageLayout = ImageLayout.None;
            leftMPanel.Controls.Add(birthdayDatePicker);
            leftMPanel.Controls.Add(label6);
            leftMPanel.Controls.Add(label5);
            leftMPanel.Controls.Add(label4);
            leftMPanel.Controls.Add(label3);
            leftMPanel.Controls.Add(label2);
            leftMPanel.Controls.Add(label1);
            leftMPanel.Controls.Add(emailLabel);
            leftMPanel.Controls.Add(nameLabel);
            leftMPanel.Controls.Add(emailTextBox);
            leftMPanel.Controls.Add(genderComboBox);
            leftMPanel.Controls.Add(birthdayLabel);
            leftMPanel.Controls.Add(phoneNumberLabel);
            leftMPanel.Controls.Add(firstNameTextBox);
            leftMPanel.Controls.Add(genderLabel);
            leftMPanel.Controls.Add(zipTextBox);
            leftMPanel.Controls.Add(phoneNumberTextBox);
            leftMPanel.Controls.Add(stateComboBox);
            leftMPanel.Controls.Add(lastNameTextBox);
            leftMPanel.Controls.Add(cityTextBox);
            leftMPanel.Controls.Add(metroLabel6);
            leftMPanel.Controls.Add(aptTextBox);
            leftMPanel.Controls.Add(streetAddressTextBox);
            leftMPanel.Location = new Point(4, 22);
            leftMPanel.Margin = new Padding(4, 5, 4, 5);
            leftMPanel.Name = "leftMPanel";
            leftMPanel.Size = new Size(460, 648);
            leftMPanel.TabIndex = 4;
            // 
            // streetAddressTextBox
            // 
            streetAddressTextBox.BackColor = Color.White;
            streetAddressTextBox.BorderStyle = BorderStyle.FixedSingle;
            streetAddressTextBox.Location = new Point(20, 446);
            streetAddressTextBox.Margin = new Padding(4, 5, 4, 5);
            streetAddressTextBox.Name = "streetAddressTextBox";
            streetAddressTextBox.Size = new Size(421, 27);
            streetAddressTextBox.TabIndex = 15;
            // 
            // aptTextBox
            // 
            aptTextBox.BackColor = Color.White;
            aptTextBox.BorderStyle = BorderStyle.FixedSingle;
            aptTextBox.Location = new Point(20, 515);
            aptTextBox.Margin = new Padding(4, 5, 4, 5);
            aptTextBox.Name = "aptTextBox";
            aptTextBox.Size = new Size(201, 27);
            aptTextBox.TabIndex = 17;
            // 
            // metroLabel6
            // 
            metroLabel6.AutoSize = true;
            metroLabel6.BackColor = Color.Transparent;
            metroLabel6.Location = new Point(20, 380);
            metroLabel6.Margin = new Padding(4, 0, 4, 0);
            metroLabel6.Name = "metroLabel6";
            metroLabel6.Size = new Size(93, 20);
            metroLabel6.TabIndex = 16;
            metroLabel6.Text = "Your address";
            // 
            // cityTextBox
            // 
            cityTextBox.BackColor = Color.White;
            cityTextBox.BorderStyle = BorderStyle.FixedSingle;
            cityTextBox.Location = new Point(226, 515);
            cityTextBox.Margin = new Padding(4, 5, 4, 5);
            cityTextBox.Name = "cityTextBox";
            cityTextBox.Size = new Size(212, 27);
            cityTextBox.TabIndex = 18;
            // 
            // lastNameTextBox
            // 
            lastNameTextBox.BackColor = Color.White;
            lastNameTextBox.BorderStyle = BorderStyle.FixedSingle;
            lastNameTextBox.Location = new Point(235, 41);
            lastNameTextBox.Margin = new Padding(4, 5, 4, 5);
            lastNameTextBox.Name = "lastNameTextBox";
            lastNameTextBox.Size = new Size(207, 27);
            lastNameTextBox.TabIndex = 3;
            // 
            // stateComboBox
            // 
            stateComboBox.FormattingEnabled = true;
            stateComboBox.Items.AddRange(new object[] { "Alabama ", "Alaska ", "Arizona ", "Arkansas ", "California ", "Colorado ", "Connecticut ", "Delaware ", "Florida ", "Georgia ", "Hawaii ", "Idaho ", "Illinois Indiana ", "Iowa ", "Kansas ", "Kentucky ", "Louisiana ", "Maine ", "Maryland ", "Massachusetts ", "Michigan ", "Minnesota ", "Mississippi ", "Missouri ", "Montana Nebraska ", "Nevada ", "New Hampshire ", "New Jersey ", "New Mexico ", "New York ", "North Carolina ", "North Dakota ", "Ohio ", "Oklahoma ", "Oregon ", "Pennsylvania Rhode Island ", "South Carolina ", "South Dakota ", "Tennessee ", "Texas ", "Utah ", "Vermont ", "Virginia ", "Washington ", "West Virginia ", "Wisconsin ", "Wyoming" });
            stateComboBox.Location = new Point(20, 581);
            stateComboBox.Margin = new Padding(4, 5, 4, 5);
            stateComboBox.Name = "stateComboBox";
            stateComboBox.Size = new Size(199, 28);
            stateComboBox.TabIndex = 19;
            // 
            // phoneNumberTextBox
            // 
            phoneNumberTextBox.BackColor = Color.White;
            phoneNumberTextBox.BorderStyle = BorderStyle.FixedSingle;
            phoneNumberTextBox.Location = new Point(20, 298);
            phoneNumberTextBox.Margin = new Padding(4, 5, 4, 5);
            phoneNumberTextBox.Name = "phoneNumberTextBox";
            phoneNumberTextBox.Size = new Size(421, 27);
            phoneNumberTextBox.TabIndex = 13;
            // 
            // zipTextBox
            // 
            zipTextBox.BackColor = Color.White;
            zipTextBox.BorderStyle = BorderStyle.FixedSingle;
            zipTextBox.Location = new Point(229, 581);
            zipTextBox.Margin = new Padding(4, 5, 4, 5);
            zipTextBox.Name = "zipTextBox";
            zipTextBox.Size = new Size(212, 27);
            zipTextBox.TabIndex = 20;
            // 
            // genderLabel
            // 
            genderLabel.AutoSize = true;
            genderLabel.BackColor = Color.Transparent;
            genderLabel.Location = new Point(20, 190);
            genderLabel.Margin = new Padding(4, 0, 4, 0);
            genderLabel.Name = "genderLabel";
            genderLabel.Size = new Size(57, 20);
            genderLabel.TabIndex = 10;
            genderLabel.Text = "Gender";
            // 
            // firstNameTextBox
            // 
            firstNameTextBox.BackColor = Color.White;
            firstNameTextBox.BorderStyle = BorderStyle.FixedSingle;
            firstNameTextBox.Location = new Point(20, 41);
            firstNameTextBox.Margin = new Padding(4, 5, 4, 5);
            firstNameTextBox.Name = "firstNameTextBox";
            firstNameTextBox.Size = new Size(207, 27);
            firstNameTextBox.TabIndex = 2;
            // 
            // phoneNumberLabel
            // 
            phoneNumberLabel.AutoSize = true;
            phoneNumberLabel.BackColor = Color.Transparent;
            phoneNumberLabel.Location = new Point(20, 273);
            phoneNumberLabel.Margin = new Padding(4, 0, 4, 0);
            phoneNumberLabel.Name = "phoneNumberLabel";
            phoneNumberLabel.Size = new Size(105, 20);
            phoneNumberLabel.TabIndex = 12;
            phoneNumberLabel.Text = "Phone number";
            // 
            // birthdayLabel
            // 
            birthdayLabel.AutoSize = true;
            birthdayLabel.BackColor = Color.Transparent;
            birthdayLabel.Location = new Point(20, 104);
            birthdayLabel.Margin = new Padding(4, 0, 4, 0);
            birthdayLabel.Name = "birthdayLabel";
            birthdayLabel.Size = new Size(64, 20);
            birthdayLabel.TabIndex = 5;
            birthdayLabel.Text = "Birthday";
            // 
            // genderComboBox
            // 
            genderComboBox.FormattingEnabled = true;
            genderComboBox.Items.AddRange(new object[] { "Female", "Male", "Other" });
            genderComboBox.Location = new Point(20, 215);
            genderComboBox.Margin = new Padding(4, 5, 4, 5);
            genderComboBox.Name = "genderComboBox";
            genderComboBox.Size = new Size(419, 28);
            genderComboBox.TabIndex = 11;
            // 
            // emailTextBox
            // 
            emailTextBox.BackColor = Color.White;
            emailTextBox.BorderStyle = BorderStyle.FixedSingle;
            emailTextBox.Location = new Point(20, 380);
            emailTextBox.Margin = new Padding(4, 5, 4, 5);
            emailTextBox.Name = "emailTextBox";
            emailTextBox.Size = new Size(421, 27);
            emailTextBox.TabIndex = 14;
            // 
            // nameLabel
            // 
            nameLabel.AutoSize = true;
            nameLabel.BackColor = Color.Transparent;
            nameLabel.Location = new Point(20, 16);
            nameLabel.Margin = new Padding(4, 0, 4, 0);
            nameLabel.Name = "nameLabel";
            nameLabel.Size = new Size(80, 20);
            nameLabel.TabIndex = 4;
            nameLabel.Text = "First Name";
            // 
            // emailLabel
            // 
            emailLabel.AutoSize = true;
            emailLabel.BackColor = Color.Transparent;
            emailLabel.Location = new Point(20, 355);
            emailLabel.Margin = new Padding(4, 0, 4, 0);
            emailLabel.Name = "emailLabel";
            emailLabel.Size = new Size(107, 20);
            emailLabel.TabIndex = 15;
            emailLabel.Text = "E-mail address";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.Transparent;
            label1.Location = new Point(235, 16);
            label1.Margin = new Padding(4, 0, 4, 0);
            label1.Name = "label1";
            label1.Size = new Size(79, 20);
            label1.TabIndex = 21;
            label1.Text = "Last Name";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = Color.Transparent;
            label2.Location = new Point(20, 421);
            label2.Margin = new Padding(4, 0, 4, 0);
            label2.Name = "label2";
            label2.Size = new Size(103, 20);
            label2.TabIndex = 22;
            label2.Text = "Street address";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.BackColor = Color.Transparent;
            label3.Location = new Point(20, 490);
            label3.Margin = new Padding(4, 0, 4, 0);
            label3.Name = "label3";
            label3.Size = new Size(73, 20);
            label3.TabIndex = 23;
            label3.Text = "Apt./suite";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.BackColor = Color.Transparent;
            label4.Location = new Point(226, 490);
            label4.Margin = new Padding(4, 0, 4, 0);
            label4.Name = "label4";
            label4.Size = new Size(34, 20);
            label4.TabIndex = 24;
            label4.Text = "City";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.BackColor = Color.Transparent;
            label5.Location = new Point(20, 556);
            label5.Margin = new Padding(4, 0, 4, 0);
            label5.Name = "label5";
            label5.Size = new Size(43, 20);
            label5.TabIndex = 25;
            label5.Text = "State";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.BackColor = Color.Transparent;
            label6.Location = new Point(229, 556);
            label6.Margin = new Padding(4, 0, 4, 0);
            label6.Name = "label6";
            label6.Size = new Size(68, 20);
            label6.TabIndex = 26;
            label6.Text = "Zip code";
            // 
            // birthdayDatePicker
            // 
            birthdayDatePicker.CalendarFont = new Font("Microsoft Sans Serif", 8F, FontStyle.Underline, GraphicsUnit.Point, 0);
            birthdayDatePicker.CustomFormat = "MM-dd-yyyy";
            birthdayDatePicker.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            birthdayDatePicker.Format = DateTimePickerFormat.Custom;
            birthdayDatePicker.Location = new Point(20, 129);
            birthdayDatePicker.Margin = new Padding(4, 5, 4, 5);
            birthdayDatePicker.MaxDate = new DateTime(2027, 4, 27, 23, 59, 0, 0);
            birthdayDatePicker.MinDate = new DateTime(1940, 1, 1, 0, 0, 0, 0);
            birthdayDatePicker.Name = "birthdayDatePicker";
            birthdayDatePicker.Size = new Size(417, 30);
            birthdayDatePicker.TabIndex = 39;
            birthdayDatePicker.Value = new DateTime(2026, 3, 22, 0, 0, 0, 0);
            // 
            // middlePanel
            // 
            middlePanel.BackColor = Color.FromArgb(225, 225, 225);
            middlePanel.BackgroundImageLayout = ImageLayout.None;
            middlePanel.Controls.Add(label9);
            middlePanel.Controls.Add(label8);
            middlePanel.Controls.Add(label7);
            middlePanel.Controls.Add(smsCheckBox);
            middlePanel.Controls.Add(foodSupplyCheckBox);
            middlePanel.Controls.Add(checkinCheckBox);
            middlePanel.Controls.Add(foodMenuButton);
            middlePanel.Controls.Add(qtGuestComboBox);
            middlePanel.Controls.Add(finalizeButton);
            middlePanel.Controls.Add(metroLabel12);
            middlePanel.Controls.Add(submitButton);
            middlePanel.Controls.Add(depDatePicker);
            middlePanel.Controls.Add(roomNComboBox);
            middlePanel.Controls.Add(floorComboBox);
            middlePanel.Controls.Add(entryDatePicker);
            middlePanel.Controls.Add(entryLabel);
            middlePanel.Controls.Add(roomTypeComboBox);
            middlePanel.Controls.Add(choiceLabel);
            middlePanel.Location = new Point(473, 21);
            middlePanel.Margin = new Padding(4, 5, 4, 5);
            middlePanel.Name = "middlePanel";
            middlePanel.Size = new Size(460, 648);
            middlePanel.TabIndex = 16;
            // 
            // choiceLabel
            // 
            choiceLabel.AutoSize = true;
            choiceLabel.BackColor = Color.Transparent;
            choiceLabel.Location = new Point(21, 21);
            choiceLabel.Margin = new Padding(4, 0, 4, 0);
            choiceLabel.Name = "choiceLabel";
            choiceLabel.Size = new Size(127, 20);
            choiceLabel.TabIndex = 21;
            choiceLabel.Text = "Number of guests";
            // 
            // roomTypeComboBox
            // 
            roomTypeComboBox.ForeColor = SystemColors.WindowFrame;
            roomTypeComboBox.FormattingEnabled = true;
            roomTypeComboBox.Items.AddRange(new object[] { "Single", "Double", "Twin", "Duplex", "Suite" });
            roomTypeComboBox.Location = new Point(231, 45);
            roomTypeComboBox.Margin = new Padding(4, 5, 4, 5);
            roomTypeComboBox.Name = "roomTypeComboBox";
            roomTypeComboBox.Size = new Size(211, 28);
            roomTypeComboBox.TabIndex = 22;
            // 
            // entryLabel
            // 
            entryLabel.AutoSize = true;
            entryLabel.BackColor = Color.Transparent;
            entryLabel.Location = new Point(21, 190);
            entryLabel.Margin = new Padding(4, 0, 4, 0);
            entryLabel.Name = "entryLabel";
            entryLabel.Size = new Size(86, 20);
            entryLabel.TabIndex = 30;
            entryLabel.Text = "Entry [date]";
            // 
            // entryDatePicker
            // 
            entryDatePicker.CalendarFont = new Font("Microsoft Sans Serif", 8F, FontStyle.Underline, GraphicsUnit.Point, 0);
            entryDatePicker.CustomFormat = "MM-dd-yyyy";
            entryDatePicker.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            entryDatePicker.Format = DateTimePickerFormat.Custom;
            entryDatePicker.Location = new Point(21, 215);
            entryDatePicker.Margin = new Padding(4, 5, 4, 5);
            entryDatePicker.MaxDate = new DateTime(2027, 4, 27, 23, 59, 0, 0);
            entryDatePicker.MinDate = new DateTime(2013, 1, 1, 0, 0, 0, 0);
            entryDatePicker.Name = "entryDatePicker";
            entryDatePicker.Size = new Size(417, 30);
            entryDatePicker.TabIndex = 26;
            entryDatePicker.Value = new DateTime(2026, 1, 1, 0, 0, 0, 0);
            // 
            // floorComboBox
            // 
            floorComboBox.FormattingEnabled = true;
            floorComboBox.Items.AddRange(new object[] { "1", "2", "3", "4", "5" });
            floorComboBox.Location = new Point(21, 128);
            floorComboBox.Margin = new Padding(4, 5, 4, 5);
            floorComboBox.Name = "floorComboBox";
            floorComboBox.Size = new Size(200, 28);
            floorComboBox.TabIndex = 23;
            // 
            // roomNComboBox
            // 
            roomNComboBox.FormattingEnabled = true;
            roomNComboBox.Items.AddRange(new object[] { "101", "102", "103", "104", "105", "106", "107", "108", "109", "110", "201", "202", "203", "204", "205", "206", "207", "208", "209", "210", "301", "302", "303", "304", "305", "306", "307", "308", "309", "310", "401", "402", "403", "404", "405", "406", "407", "408", "409", "410", "501", "502", "503", "504", "505", "506", "507", "508", "509", "510" });
            roomNComboBox.Location = new Point(231, 128);
            roomNComboBox.Margin = new Padding(4, 5, 4, 5);
            roomNComboBox.Name = "roomNComboBox";
            roomNComboBox.Size = new Size(211, 28);
            roomNComboBox.TabIndex = 24;
            // 
            // depDatePicker
            // 
            depDatePicker.CalendarFont = new Font("Microsoft Sans Serif", 8F, FontStyle.Underline, GraphicsUnit.Point, 0);
            depDatePicker.CustomFormat = "MM-dd-yyyy";
            depDatePicker.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            depDatePicker.Format = DateTimePickerFormat.Custom;
            depDatePicker.Location = new Point(21, 294);
            depDatePicker.Margin = new Padding(4, 5, 4, 5);
            depDatePicker.MaxDate = new DateTime(2027, 4, 27, 23, 59, 0, 0);
            depDatePicker.MinDate = new DateTime(2013, 1, 1, 0, 0, 0, 0);
            depDatePicker.Name = "depDatePicker";
            depDatePicker.Size = new Size(420, 30);
            depDatePicker.TabIndex = 31;
            depDatePicker.Value = new DateTime(2026, 1, 1, 0, 0, 0, 0);
            // 
            // submitButton
            // 
            submitButton.BackColor = Color.Green;
            submitButton.ForeColor = Color.White;
            submitButton.Location = new Point(21, 572);
            submitButton.Margin = new Padding(4, 5, 4, 5);
            submitButton.Name = "submitButton";
            submitButton.Size = new Size(419, 55);
            submitButton.TabIndex = 17;
            submitButton.Text = "Submit";
            submitButton.UseVisualStyleBackColor = false;
            submitButton.Visible = false;
            submitButton.Click += submitButton_Click;
            // 
            // metroLabel12
            // 
            metroLabel12.AutoSize = true;
            metroLabel12.BackColor = Color.Transparent;
            metroLabel12.Location = new Point(21, 269);
            metroLabel12.Margin = new Padding(4, 0, 4, 0);
            metroLabel12.Name = "metroLabel12";
            metroLabel12.Size = new Size(120, 20);
            metroLabel12.TabIndex = 32;
            metroLabel12.Text = "Deperture [date]";
            // 
            // finalizeButton
            // 
            finalizeButton.BackColor = Color.Green;
            finalizeButton.ForeColor = Color.White;
            finalizeButton.Location = new Point(21, 519);
            finalizeButton.Margin = new Padding(4, 5, 4, 5);
            finalizeButton.Name = "finalizeButton";
            finalizeButton.Size = new Size(419, 48);
            finalizeButton.TabIndex = 22;
            finalizeButton.Text = "Finalize bill";
            finalizeButton.UseVisualStyleBackColor = false;
            finalizeButton.Click += finalizeButton_Click;
            // 
            // qtGuestComboBox
            // 
            qtGuestComboBox.ForeColor = SystemColors.WindowFrame;
            qtGuestComboBox.FormattingEnabled = true;
            qtGuestComboBox.Items.AddRange(new object[] { "1", "2", "3", "4", "5", "6" });
            qtGuestComboBox.Location = new Point(21, 46);
            qtGuestComboBox.Margin = new Padding(4, 5, 4, 5);
            qtGuestComboBox.Name = "qtGuestComboBox";
            qtGuestComboBox.Size = new Size(200, 28);
            qtGuestComboBox.TabIndex = 25;
            // 
            // foodMenuButton
            // 
            foodMenuButton.BackColor = Color.Green;
            foodMenuButton.ForeColor = Color.White;
            foodMenuButton.Location = new Point(21, 374);
            foodMenuButton.Margin = new Padding(4, 5, 4, 5);
            foodMenuButton.Name = "foodMenuButton";
            foodMenuButton.Size = new Size(419, 52);
            foodMenuButton.TabIndex = 23;
            foodMenuButton.Text = "Food and menu";
            foodMenuButton.UseVisualStyleBackColor = false;
            foodMenuButton.Click += foodMenuButton_Click;
            // 
            // checkinCheckBox
            // 
            checkinCheckBox.AutoSize = true;
            checkinCheckBox.BackColor = Color.Transparent;
            checkinCheckBox.Location = new Point(21, 448);
            checkinCheckBox.Margin = new Padding(4, 5, 4, 5);
            checkinCheckBox.Name = "checkinCheckBox";
            checkinCheckBox.Size = new Size(97, 24);
            checkinCheckBox.TabIndex = 33;
            checkinCheckBox.Text = "Check in ?";
            checkinCheckBox.UseVisualStyleBackColor = false;
            // 
            // foodSupplyCheckBox
            // 
            foodSupplyCheckBox.AutoSize = true;
            foodSupplyCheckBox.BackColor = Color.Transparent;
            foodSupplyCheckBox.Location = new Point(259, 446);
            foodSupplyCheckBox.Margin = new Padding(4, 5, 4, 5);
            foodSupplyCheckBox.Name = "foodSupplyCheckBox";
            foodSupplyCheckBox.Size = new Size(169, 24);
            foodSupplyCheckBox.TabIndex = 34;
            foodSupplyCheckBox.Text = "Food/Supply status ?";
            foodSupplyCheckBox.UseVisualStyleBackColor = false;
            // 
            // smsCheckBox
            // 
            smsCheckBox.AutoSize = true;
            smsCheckBox.BackColor = Color.Transparent;
            smsCheckBox.Location = new Point(140, 448);
            smsCheckBox.Margin = new Padding(4, 5, 4, 5);
            smsCheckBox.Name = "smsCheckBox";
            smsCheckBox.Size = new Size(100, 24);
            smsCheckBox.TabIndex = 35;
            smsCheckBox.Text = "Send sms?";
            smsCheckBox.UseVisualStyleBackColor = false;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.BackColor = Color.Transparent;
            label7.Location = new Point(231, 21);
            label7.Margin = new Padding(4, 0, 4, 0);
            label7.Name = "label7";
            label7.Size = new Size(82, 20);
            label7.TabIndex = 36;
            label7.Text = "Room type";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.BackColor = Color.Transparent;
            label8.Location = new Point(21, 105);
            label8.Margin = new Padding(4, 0, 4, 0);
            label8.Name = "label8";
            label8.Size = new Size(43, 20);
            label8.TabIndex = 37;
            label8.Text = "Floor";
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.BackColor = Color.Transparent;
            label9.Location = new Point(231, 105);
            label9.Margin = new Padding(4, 0, 4, 0);
            label9.Name = "label9";
            label9.Size = new Size(54, 20);
            label9.TabIndex = 38;
            label9.Text = "# floor";
            // 
            // rightMPanel
            // 
            rightMPanel.BackColor = Color.FromArgb(225, 225, 225);
            rightMPanel.BackgroundImageLayout = ImageLayout.None;
            rightMPanel.Controls.Add(resList);
            rightMPanel.Controls.Add(newButton);
            rightMPanel.Controls.Add(deleteButton);
            rightMPanel.Controls.Add(editButton);
            rightMPanel.Controls.Add(updateButton);
            rightMPanel.Location = new Point(944, 21);
            rightMPanel.Margin = new Padding(4, 5, 4, 5);
            rightMPanel.Name = "rightMPanel";
            rightMPanel.Size = new Size(353, 648);
            rightMPanel.TabIndex = 34;
            // 
            // updateButton
            // 
            updateButton.BackColor = Color.Green;
            updateButton.ForeColor = Color.White;
            updateButton.Location = new Point(13, 378);
            updateButton.Margin = new Padding(4, 5, 4, 5);
            updateButton.Name = "updateButton";
            updateButton.Size = new Size(327, 52);
            updateButton.TabIndex = 19;
            updateButton.Text = "Update";
            updateButton.UseVisualStyleBackColor = false;
            updateButton.Visible = false;
            updateButton.Click += updateButton_Click;
            // 
            // editButton
            // 
            editButton.BackColor = Color.Green;
            editButton.ForeColor = Color.White;
            editButton.Location = new Point(13, 515);
            editButton.Margin = new Padding(4, 5, 4, 5);
            editButton.Name = "editButton";
            editButton.Size = new Size(327, 49);
            editButton.TabIndex = 18;
            editButton.Text = "Edit existing Reservation";
            editButton.UseVisualStyleBackColor = false;
            editButton.Click += editButton_Click;
            // 
            // deleteButton
            // 
            deleteButton.BackColor = Color.Red;
            deleteButton.ForeColor = Color.White;
            deleteButton.Location = new Point(13, 442);
            deleteButton.Margin = new Padding(4, 5, 4, 5);
            deleteButton.Name = "deleteButton";
            deleteButton.Size = new Size(327, 52);
            deleteButton.TabIndex = 23;
            deleteButton.Text = "Delete";
            deleteButton.UseVisualStyleBackColor = false;
            deleteButton.Visible = false;
            deleteButton.Click += deleteButton_Click;
            // 
            // newButton
            // 
            newButton.BackColor = Color.Green;
            newButton.ForeColor = Color.White;
            newButton.Location = new Point(13, 578);
            newButton.Margin = new Padding(4, 5, 4, 5);
            newButton.Name = "newButton";
            newButton.Size = new Size(327, 49);
            newButton.TabIndex = 22;
            newButton.Text = "New reservation";
            newButton.UseVisualStyleBackColor = false;
            newButton.Click += newButton_Click;
            // 
            // resList
            // 
            resList.FormattingEnabled = true;
            resList.Location = new Point(7, 46);
            resList.Name = "resList";
            resList.Size = new Size(335, 28);
            resList.TabIndex = 24;
            resList.Visible = false;
            // 
            // resPanel
            // 
            resPanel.Controls.Add(reservationPage);
            resPanel.Controls.Add(searchPage);
            resPanel.Controls.Add(metroTabPage2);
            resPanel.Location = new Point(13, 83);
            resPanel.Margin = new Padding(4, 5, 4, 5);
            resPanel.Name = "resPanel";
            resPanel.SelectedIndex = 0;
            resPanel.Size = new Size(1312, 741);
            resPanel.TabIndex = 0;
            // 
            // Frontend
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            AutoSizeMode = AutoSizeMode.GrowAndShrink;
            ClientSize = new Size(1331, 839);
            Controls.Add(resPanel);
            Margin = new Padding(4, 5, 4, 5);
            Name = "Frontend";
            Padding = new Padding(27, 92, 27, 31);
            StartPosition = FormStartPosition.Manual;
            Text = "Frontend";
            FormClosed += Frontend_FormClosed;
            Load += Frontend_Load;
            metroTabPage2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)resTotalDataGridView).EndInit();
            searchPage.ResumeLayout(false);
            searchPage.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)searchDataGridView).EndInit();
            reservationPage.ResumeLayout(false);
            leftMPanel.ResumeLayout(false);
            leftMPanel.PerformLayout();
            middlePanel.ResumeLayout(false);
            middlePanel.PerformLayout();
            rightMPanel.ResumeLayout(false);
            resPanel.ResumeLayout(false);
            ResumeLayout(false);

        }

        #endregion

        private TabPage metroTabPage2;
        private DataGridView resTotalDataGridView;
        private TabPage searchPage;
        private Label SearchError;
        private Button searchButton;
        private TextBox searchTextBox;
        private DataGridView searchDataGridView;
        private TabPage reservationPage;
        private Panel rightMPanel;
        private ComboBox resList;
        private Button newButton;
        private Button deleteButton;
        private Button editButton;
        private Button updateButton;
        private Panel middlePanel;
        private Label label9;
        private Label label8;
        private Label label7;
        private CheckBox smsCheckBox;
        private CheckBox foodSupplyCheckBox;
        private CheckBox checkinCheckBox;
        private Button foodMenuButton;
        private ComboBox qtGuestComboBox;
        private Button finalizeButton;
        private Label metroLabel12;
        private Button submitButton;
        private DateTimePicker depDatePicker;
        private ComboBox roomNComboBox;
        private ComboBox floorComboBox;
        private DateTimePicker entryDatePicker;
        private Label entryLabel;
        private ComboBox roomTypeComboBox;
        private Label choiceLabel;
        private Panel leftMPanel;
        private DateTimePicker birthdayDatePicker;
        private Label label6;
        private Label label5;
        private Label label4;
        private Label label3;
        private Label label2;
        private Label label1;
        private Label emailLabel;
        private Label nameLabel;
        private TextBox emailTextBox;
        private ComboBox genderComboBox;
        private Label birthdayLabel;
        private Label phoneNumberLabel;
        private TextBox firstNameTextBox;
        private Label genderLabel;
        private TextBox zipTextBox;
        private TextBox phoneNumberTextBox;
        private ComboBox stateComboBox;
        private TextBox lastNameTextBox;
        private TextBox cityTextBox;
        private Label metroLabel6;
        private TextBox aptTextBox;
        private TextBox streetAddressTextBox;
        private TabControl resPanel;
    }
}