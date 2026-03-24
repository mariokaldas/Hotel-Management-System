namespace HotelManagement
{
    partial class FoodMenu
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
            foodPanel = new Panel();
            dinnerQTY = new TextBox();
            lunchQTY = new TextBox();
            breakfastQTY = new TextBox();
            dinnerPicture = new PictureBox();
            lunchPicture = new PictureBox();
            breakfastPicture = new PictureBox();
            dinnerCheckBox = new CheckBox();
            lunchCheckBox = new CheckBox();
            breakfastCheckBox = new CheckBox();
            metroLabel1 = new Label();
            needPanel = new Panel();
            surpriseCheckBox = new CheckBox();
            towelsCheckBox = new CheckBox();
            cleaningCheckBox = new CheckBox();
            metroLabel2 = new Label();
            nextButton = new Button();
            foodPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dinnerPicture).BeginInit();
            ((System.ComponentModel.ISupportInitialize)lunchPicture).BeginInit();
            ((System.ComponentModel.ISupportInitialize)breakfastPicture).BeginInit();
            needPanel.SuspendLayout();
            SuspendLayout();
            // 
            // foodPanel
            // 
            foodPanel.BackColor = Color.FromArgb(225, 225, 225);
            foodPanel.BackgroundImageLayout = ImageLayout.None;
            foodPanel.Controls.Add(dinnerQTY);
            foodPanel.Controls.Add(lunchQTY);
            foodPanel.Controls.Add(breakfastQTY);
            foodPanel.Controls.Add(dinnerPicture);
            foodPanel.Controls.Add(lunchPicture);
            foodPanel.Controls.Add(breakfastPicture);
            foodPanel.Controls.Add(dinnerCheckBox);
            foodPanel.Controls.Add(lunchCheckBox);
            foodPanel.Controls.Add(breakfastCheckBox);
            foodPanel.Controls.Add(metroLabel1);
            foodPanel.Location = new Point(19, 97);
            foodPanel.Margin = new Padding(4, 5, 4, 5);
            foodPanel.Name = "foodPanel";
            foodPanel.Size = new Size(443, 565);
            foodPanel.TabIndex = 5;
            // 
            // dinnerQTY
            // 
            dinnerQTY.BackColor = Color.White;
            dinnerQTY.BorderStyle = BorderStyle.FixedSingle;
            dinnerQTY.Enabled = false;
            dinnerQTY.Location = new Point(19, 503);
            dinnerQTY.Margin = new Padding(4, 5, 4, 5);
            dinnerQTY.Name = "dinnerQTY";
            dinnerQTY.PlaceholderText = "Quantity";
            dinnerQTY.Size = new Size(171, 27);
            dinnerQTY.TabIndex = 40;
            // 
            // lunchQTY
            // 
            lunchQTY.BackColor = Color.White;
            lunchQTY.BorderStyle = BorderStyle.FixedSingle;
            lunchQTY.Enabled = false;
            lunchQTY.Location = new Point(229, 278);
            lunchQTY.Margin = new Padding(4, 5, 4, 5);
            lunchQTY.Name = "lunchQTY";
            lunchQTY.PlaceholderText = "Quantity";
            lunchQTY.Size = new Size(191, 27);
            lunchQTY.TabIndex = 39;
            // 
            // breakfastQTY
            // 
            breakfastQTY.BackColor = Color.White;
            breakfastQTY.BorderStyle = BorderStyle.FixedSingle;
            breakfastQTY.Enabled = false;
            breakfastQTY.Location = new Point(19, 278);
            breakfastQTY.Margin = new Padding(4, 5, 4, 5);
            breakfastQTY.Name = "breakfastQTY";
            breakfastQTY.PlaceholderText = "Quantity";
            breakfastQTY.Size = new Size(171, 27);
            breakfastQTY.TabIndex = 38;
            // 
            // dinnerPicture
            // 
            dinnerPicture.Image = Properties.Resources.Dinner_new_png;
            dinnerPicture.Location = new Point(19, 348);
            dinnerPicture.Margin = new Padding(4, 5, 4, 5);
            dinnerPicture.Name = "dinnerPicture";
            dinnerPicture.Size = new Size(172, 115);
            dinnerPicture.SizeMode = PictureBoxSizeMode.StretchImage;
            dinnerPicture.TabIndex = 8;
            dinnerPicture.TabStop = false;
            // 
            // lunchPicture
            // 
            lunchPicture.Image = Properties.Resources.lunch_new_png;
            lunchPicture.Location = new Point(229, 85);
            lunchPicture.Margin = new Padding(4, 5, 4, 5);
            lunchPicture.Name = "lunchPicture";
            lunchPicture.Size = new Size(192, 142);
            lunchPicture.SizeMode = PictureBoxSizeMode.StretchImage;
            lunchPicture.TabIndex = 7;
            lunchPicture.TabStop = false;
            // 
            // breakfastPicture
            // 
            breakfastPicture.Image = Properties.Resources.breakfast;
            breakfastPicture.Location = new Point(19, 85);
            breakfastPicture.Margin = new Padding(4, 5, 4, 5);
            breakfastPicture.Name = "breakfastPicture";
            breakfastPicture.Size = new Size(172, 142);
            breakfastPicture.SizeMode = PictureBoxSizeMode.StretchImage;
            breakfastPicture.TabIndex = 6;
            breakfastPicture.TabStop = false;
            // 
            // dinnerCheckBox
            // 
            dinnerCheckBox.AutoSize = true;
            dinnerCheckBox.BackColor = Color.Transparent;
            dinnerCheckBox.Location = new Point(19, 472);
            dinnerCheckBox.Margin = new Padding(4, 5, 4, 5);
            dinnerCheckBox.Name = "dinnerCheckBox";
            dinnerCheckBox.Size = new Size(121, 24);
            dinnerCheckBox.TabIndex = 5;
            dinnerCheckBox.Text = "Dinner   ($15)";
            dinnerCheckBox.UseVisualStyleBackColor = false;
            dinnerCheckBox.CheckedChanged += dinnerCheckBox_CheckedChanged;
            // 
            // lunchCheckBox
            // 
            lunchCheckBox.AutoSize = true;
            lunchCheckBox.BackColor = Color.Transparent;
            lunchCheckBox.Location = new Point(229, 240);
            lunchCheckBox.Margin = new Padding(4, 5, 4, 5);
            lunchCheckBox.Name = "lunchCheckBox";
            lunchCheckBox.Size = new Size(115, 24);
            lunchCheckBox.TabIndex = 4;
            lunchCheckBox.Text = "Lunch   ($15)";
            lunchCheckBox.UseVisualStyleBackColor = false;
            lunchCheckBox.CheckedChanged += lunchCheckBox_CheckedChanged;
            // 
            // breakfastCheckBox
            // 
            breakfastCheckBox.AutoSize = true;
            breakfastCheckBox.BackColor = Color.Transparent;
            breakfastCheckBox.Location = new Point(19, 240);
            breakfastCheckBox.Margin = new Padding(4, 5, 4, 5);
            breakfastCheckBox.Name = "breakfastCheckBox";
            breakfastCheckBox.Size = new Size(131, 24);
            breakfastCheckBox.TabIndex = 3;
            breakfastCheckBox.Text = "Break Fast  ($7)";
            breakfastCheckBox.UseVisualStyleBackColor = false;
            breakfastCheckBox.CheckedChanged += breakfastCheckBox_CheckedChanged;
            // 
            // metroLabel1
            // 
            metroLabel1.AutoSize = true;
            metroLabel1.BackColor = Color.Transparent;
            metroLabel1.Font = new Font("Microsoft Sans Serif", 14F, FontStyle.Regular, GraphicsUnit.Point, 0);
            metroLabel1.Location = new Point(4, 15);
            metroLabel1.Margin = new Padding(4, 0, 4, 0);
            metroLabel1.Name = "metroLabel1";
            metroLabel1.Size = new Size(177, 29);
            metroLabel1.TabIndex = 2;
            metroLabel1.Text = "Food Selection";
            // 
            // needPanel
            // 
            needPanel.BackColor = Color.FromArgb(225, 225, 225);
            needPanel.BackgroundImageLayout = ImageLayout.None;
            needPanel.Controls.Add(surpriseCheckBox);
            needPanel.Controls.Add(towelsCheckBox);
            needPanel.Controls.Add(cleaningCheckBox);
            needPanel.Controls.Add(metroLabel2);
            needPanel.Location = new Point(473, 97);
            needPanel.Margin = new Padding(4, 5, 4, 5);
            needPanel.Name = "needPanel";
            needPanel.Size = new Size(219, 502);
            needPanel.TabIndex = 6;
            // 
            // surpriseCheckBox
            // 
            surpriseCheckBox.AutoSize = true;
            surpriseCheckBox.BackColor = Color.Transparent;
            surpriseCheckBox.Location = new Point(24, 197);
            surpriseCheckBox.Margin = new Padding(4, 5, 4, 5);
            surpriseCheckBox.Name = "surpriseCheckBox";
            surpriseCheckBox.Size = new Size(145, 24);
            surpriseCheckBox.TabIndex = 44;
            surpriseCheckBox.Text = "Sweetest surprise";
            surpriseCheckBox.UseVisualStyleBackColor = false;
            // 
            // towelsCheckBox
            // 
            towelsCheckBox.AutoSize = true;
            towelsCheckBox.BackColor = Color.Transparent;
            towelsCheckBox.Location = new Point(24, 140);
            towelsCheckBox.Margin = new Padding(4, 5, 4, 5);
            towelsCheckBox.Name = "towelsCheckBox";
            towelsCheckBox.Size = new Size(76, 24);
            towelsCheckBox.TabIndex = 42;
            towelsCheckBox.Text = "Towels";
            towelsCheckBox.UseVisualStyleBackColor = false;
            // 
            // cleaningCheckBox
            // 
            cleaningCheckBox.AutoSize = true;
            cleaningCheckBox.BackColor = Color.Transparent;
            cleaningCheckBox.Location = new Point(24, 85);
            cleaningCheckBox.Margin = new Padding(4, 5, 4, 5);
            cleaningCheckBox.Name = "cleaningCheckBox";
            cleaningCheckBox.Size = new Size(89, 24);
            cleaningCheckBox.TabIndex = 41;
            cleaningCheckBox.Text = "Cleaning";
            cleaningCheckBox.UseVisualStyleBackColor = false;
            // 
            // metroLabel2
            // 
            metroLabel2.AutoSize = true;
            metroLabel2.BackColor = Color.Transparent;
            metroLabel2.Font = new Font("Microsoft Sans Serif", 14F, FontStyle.Regular, GraphicsUnit.Point, 0);
            metroLabel2.Location = new Point(4, 15);
            metroLabel2.Margin = new Padding(4, 0, 4, 0);
            metroLabel2.Name = "metroLabel2";
            metroLabel2.Size = new Size(167, 29);
            metroLabel2.TabIndex = 41;
            metroLabel2.Text = "Special needs";
            // 
            // nextButton
            // 
            nextButton.BackColor = Color.FromArgb(0, 192, 0);
            nextButton.ForeColor = Color.White;
            nextButton.Location = new Point(473, 609);
            nextButton.Margin = new Padding(4, 5, 4, 5);
            nextButton.Name = "nextButton";
            nextButton.Size = new Size(219, 52);
            nextButton.TabIndex = 45;
            nextButton.Text = "Next";
            nextButton.UseVisualStyleBackColor = false;
            nextButton.Click += nextButton_Click;
            // 
            // FoodMenu
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(712, 680);
            Controls.Add(nextButton);
            Controls.Add(needPanel);
            Controls.Add(foodPanel);
            Margin = new Padding(4, 5, 4, 5);
            MaximizeBox = false;
            Name = "FoodMenu";
            ShowInTaskbar = false;
            Text = "Food and Menu";
            Load += FoodMenu_Load;
            foodPanel.ResumeLayout(false);
            foodPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dinnerPicture).EndInit();
            ((System.ComponentModel.ISupportInitialize)lunchPicture).EndInit();
            ((System.ComponentModel.ISupportInitialize)breakfastPicture).EndInit();
            needPanel.ResumeLayout(false);
            needPanel.PerformLayout();
            ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel foodPanel;
        private System.Windows.Forms.Label metroLabel1;
        private System.Windows.Forms.PictureBox dinnerPicture;
        private System.Windows.Forms.PictureBox lunchPicture;
        private System.Windows.Forms.PictureBox breakfastPicture;
        public System.Windows.Forms.TextBox breakfastQTY;
        public System.Windows.Forms.TextBox dinnerQTY;
        public System.Windows.Forms.TextBox lunchQTY;
        private System.Windows.Forms.Label metroLabel2;
        public System.Windows.Forms.CheckBox dinnerCheckBox;
        public System.Windows.Forms.CheckBox lunchCheckBox;
        public System.Windows.Forms.CheckBox breakfastCheckBox;
        public System.Windows.Forms.CheckBox surpriseCheckBox;
        public System.Windows.Forms.CheckBox towelsCheckBox;
        public System.Windows.Forms.CheckBox cleaningCheckBox;
        public System.Windows.Forms.Panel needPanel;
        public System.Windows.Forms.Button nextButton;
    }
}
