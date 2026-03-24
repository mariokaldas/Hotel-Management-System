namespace HotelManagement
{
    partial class FinalizePayment
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
            nextButton = new Button();
            reservation = new Label();
            currentBillAmount = new Label();
            priceLabel = new Label();
            currentBill = new Label();
            cardNumberTextBox = new TextBox();
            paymentLabel = new Label();
            paymentComboBox = new ComboBox();
            metroLabel5 = new Label();
            taxAmount = new Label();
            totalLabel = new Label();
            totalAmount = new Label();
            monthComboBox = new ComboBox();
            yearComboBox = new ComboBox();
            metroLabel10 = new Label();
            cvcTextBox = new TextBox();
            foodBillLabel = new Label();
            foodBillAmount = new Label();
            SuspendLayout();
            // 
            // nextButton
            // 
            nextButton.BackColor = Color.Green;
            nextButton.ForeColor = Color.White;
            nextButton.Location = new Point(453, 374);
            nextButton.Margin = new Padding(4, 5, 4, 5);
            nextButton.Name = "nextButton";
            nextButton.Size = new Size(117, 52);
            nextButton.TabIndex = 0;
            nextButton.Text = "Next";
            nextButton.UseVisualStyleBackColor = false;
            nextButton.Click += nextButton_Click;
            // 
            // reservation
            // 
            reservation.AutoSize = true;
            reservation.Location = new Point(19, 38);
            reservation.Margin = new Padding(4, 0, 4, 0);
            reservation.Name = "reservation";
            reservation.Size = new Size(86, 20);
            reservation.TabIndex = 1;
            reservation.Text = "Reservation";
            // 
            // currentBillAmount
            // 
            currentBillAmount.AutoSize = true;
            currentBillAmount.Location = new Point(475, 74);
            currentBillAmount.Margin = new Padding(4, 0, 4, 0);
            currentBillAmount.Name = "currentBillAmount";
            currentBillAmount.Size = new Size(17, 20);
            currentBillAmount.TabIndex = 2;
            currentBillAmount.Text = "$";
            currentBillAmount.TextAlign = ContentAlignment.TopRight;
            // 
            // priceLabel
            // 
            priceLabel.AutoSize = true;
            priceLabel.Location = new Point(520, 38);
            priceLabel.Margin = new Padding(4, 0, 4, 0);
            priceLabel.Name = "priceLabel";
            priceLabel.Size = new Size(41, 20);
            priceLabel.TabIndex = 3;
            priceLabel.Text = "Price";
            // 
            // currentBill
            // 
            currentBill.AutoSize = true;
            currentBill.Location = new Point(19, 74);
            currentBill.Margin = new Padding(4, 0, 4, 0);
            currentBill.Name = "currentBill";
            currentBill.Size = new Size(82, 20);
            currentBill.TabIndex = 4;
            currentBill.Text = "Current bill";
            // 
            // cardNumberTextBox
            // 
            cardNumberTextBox.BackColor = Color.White;
            cardNumberTextBox.BorderStyle = BorderStyle.FixedSingle;
            cardNumberTextBox.Location = new Point(215, 245);
            cardNumberTextBox.Margin = new Padding(4, 5, 4, 5);
            cardNumberTextBox.Name = "cardNumberTextBox";
            cardNumberTextBox.PlaceholderText = "9999-9999-9999-9999";
            cardNumberTextBox.Size = new Size(355, 27);
            cardNumberTextBox.TabIndex = 28;
            // 
            // paymentLabel
            // 
            paymentLabel.AutoSize = true;
            paymentLabel.BackColor = Color.Transparent;
            paymentLabel.Location = new Point(19, 211);
            paymentLabel.Margin = new Padding(4, 0, 4, 0);
            paymentLabel.Name = "paymentLabel";
            paymentLabel.Size = new Size(65, 20);
            paymentLabel.TabIndex = 25;
            paymentLabel.Text = "Payment";
            // 
            // paymentComboBox
            // 
            paymentComboBox.FormattingEnabled = true;
            paymentComboBox.Items.AddRange(new object[] { "Credit", "Debit" });
            paymentComboBox.Location = new Point(24, 245);
            paymentComboBox.Margin = new Padding(4, 5, 4, 5);
            paymentComboBox.Name = "paymentComboBox";
            paymentComboBox.Size = new Size(169, 28);
            paymentComboBox.TabIndex = 29;
            // 
            // metroLabel5
            // 
            metroLabel5.AutoSize = true;
            metroLabel5.Location = new Point(356, 152);
            metroLabel5.Margin = new Padding(4, 0, 4, 0);
            metroLabel5.Name = "metroLabel5";
            metroLabel5.Size = new Size(30, 20);
            metroLabel5.TabIndex = 30;
            metroLabel5.Text = "Tax";
            // 
            // taxAmount
            // 
            taxAmount.AutoSize = true;
            taxAmount.Location = new Point(457, 152);
            taxAmount.Margin = new Padding(4, 0, 4, 0);
            taxAmount.Name = "taxAmount";
            taxAmount.Size = new Size(17, 20);
            taxAmount.TabIndex = 31;
            taxAmount.Text = "$";
            taxAmount.TextAlign = ContentAlignment.TopRight;
            // 
            // totalLabel
            // 
            totalLabel.AutoSize = true;
            totalLabel.Location = new Point(327, 195);
            totalLabel.Margin = new Padding(4, 0, 4, 0);
            totalLabel.Name = "totalLabel";
            totalLabel.Size = new Size(42, 20);
            totalLabel.TabIndex = 32;
            totalLabel.Text = "Total";
            // 
            // totalAmount
            // 
            totalAmount.AutoSize = true;
            totalAmount.Location = new Point(445, 195);
            totalAmount.Margin = new Padding(4, 0, 4, 0);
            totalAmount.Name = "totalAmount";
            totalAmount.Size = new Size(17, 20);
            totalAmount.TabIndex = 33;
            totalAmount.Text = "$";
            totalAmount.TextAlign = ContentAlignment.TopRight;
            // 
            // monthComboBox
            // 
            monthComboBox.FormattingEnabled = true;
            monthComboBox.Items.AddRange(new object[] { "01", "02", "03", "04", "05", "06", "07", "08", "09", "10", "11", "12" });
            monthComboBox.Location = new Point(24, 308);
            monthComboBox.Margin = new Padding(4, 5, 4, 5);
            monthComboBox.Name = "monthComboBox";
            monthComboBox.Size = new Size(77, 28);
            monthComboBox.TabIndex = 34;
            monthComboBox.Text = "MM";
            // 
            // yearComboBox
            // 
            yearComboBox.FormattingEnabled = true;
            yearComboBox.Items.AddRange(new object[] { "14", "15", "16", "17", "18", "19", "20", "21", "22", "23", "24" });
            yearComboBox.Location = new Point(135, 309);
            yearComboBox.Margin = new Padding(4, 5, 4, 5);
            yearComboBox.Name = "yearComboBox";
            yearComboBox.Size = new Size(59, 28);
            yearComboBox.TabIndex = 35;
            yearComboBox.Text = "YY";
            // 
            // metroLabel10
            // 
            metroLabel10.AutoSize = true;
            metroLabel10.Location = new Point(111, 315);
            metroLabel10.Margin = new Padding(4, 0, 4, 0);
            metroLabel10.Name = "metroLabel10";
            metroLabel10.Size = new Size(15, 20);
            metroLabel10.TabIndex = 36;
            metroLabel10.Text = "/";
            // 
            // cvcTextBox
            // 
            cvcTextBox.BackColor = Color.White;
            cvcTextBox.BorderStyle = BorderStyle.FixedSingle;
            cvcTextBox.Location = new Point(215, 309);
            cvcTextBox.Margin = new Padding(4, 5, 4, 5);
            cvcTextBox.Name = "cvcTextBox";
            cvcTextBox.PlaceholderText = "CVC";
            cvcTextBox.Size = new Size(54, 27);
            cvcTextBox.TabIndex = 37;
            // 
            // foodBillLabel
            // 
            foodBillLabel.AutoSize = true;
            foodBillLabel.Location = new Point(19, 111);
            foodBillLabel.Margin = new Padding(4, 0, 4, 0);
            foodBillLabel.Name = "foodBillLabel";
            foodBillLabel.Size = new Size(68, 20);
            foodBillLabel.TabIndex = 40;
            foodBillLabel.Text = "Food bill";
            // 
            // foodBillAmount
            // 
            foodBillAmount.AutoSize = true;
            foodBillAmount.Location = new Point(475, 111);
            foodBillAmount.Margin = new Padding(4, 0, 4, 0);
            foodBillAmount.Name = "foodBillAmount";
            foodBillAmount.Size = new Size(17, 20);
            foodBillAmount.TabIndex = 41;
            foodBillAmount.Text = "$";
            foodBillAmount.TextAlign = ContentAlignment.TopRight;
            // 
            // FinalizePayment
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(579, 437);
            Controls.Add(foodBillAmount);
            Controls.Add(foodBillLabel);
            Controls.Add(cvcTextBox);
            Controls.Add(metroLabel10);
            Controls.Add(yearComboBox);
            Controls.Add(monthComboBox);
            Controls.Add(totalAmount);
            Controls.Add(totalLabel);
            Controls.Add(taxAmount);
            Controls.Add(metroLabel5);
            Controls.Add(currentBill);
            Controls.Add(paymentComboBox);
            Controls.Add(priceLabel);
            Controls.Add(currentBillAmount);
            Controls.Add(cardNumberTextBox);
            Controls.Add(reservation);
            Controls.Add(paymentLabel);
            Controls.Add(nextButton);
            Margin = new Padding(4, 5, 4, 5);
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "FinalizePayment";
            Padding = new Padding(27, 46, 27, 31);
            ShowIcon = false;
            ShowInTaskbar = false;
            ResumeLayout(false);
            PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button nextButton;
        private System.Windows.Forms.Label reservation;
        private System.Windows.Forms.Label currentBillAmount;
        private System.Windows.Forms.Label priceLabel;
        private System.Windows.Forms.Label currentBill;
        private System.Windows.Forms.Label paymentLabel;
        private System.Windows.Forms.Label metroLabel5;
        private System.Windows.Forms.Label taxAmount;
        private System.Windows.Forms.Label totalLabel;
        private System.Windows.Forms.Label totalAmount;
        private System.Windows.Forms.Label metroLabel10;
        public System.Windows.Forms.TextBox cardNumberTextBox;
        public System.Windows.Forms.ComboBox paymentComboBox;
        public System.Windows.Forms.ComboBox monthComboBox;
        public System.Windows.Forms.ComboBox yearComboBox;
        public System.Windows.Forms.TextBox cvcTextBox;
        private System.Windows.Forms.Label foodBillLabel;
        private System.Windows.Forms.Label foodBillAmount;

    }
}
