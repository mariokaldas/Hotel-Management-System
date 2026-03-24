namespace HotelManagement
{
    partial class Kitchen
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
            metroTabControl1 = new TabControl();
            TodoTabPage = new TabPage();
            label1 = new Label();
            label2 = new Label();
            onTheLineLabel = new Label();
            updateButton = new Button();
            roomNLabel = new Label();
            floorNLabel = new Label();
            roomTypeLabel = new Label();
            Todo = new GroupBox();
            dinnerQTLabel = new Label();
            lunchQTLabel = new Label();
            breakfastQTLabel = new Label();
            breakfastTextBox = new TextBox();
            foodSelectionButton = new Button();
            supplyCheckBox = new CheckBox();
            lunchTextBox = new TextBox();
            towelCheckBox = new CheckBox();
            dinnerTextBox = new TextBox();
            cleaningCheckBox = new CheckBox();
            surpriseCheckBox = new CheckBox();
            floorNTextBox = new TextBox();
            roomNTextBox = new TextBox();
            roomTypeTextBox = new TextBox();
            phoneNTextBox = new TextBox();
            queueListBox = new ListBox();
            phoneNLabel = new Label();
            firstNameTextBox = new TextBox();
            lastNameTextBox = new TextBox();
            overviewTabPage = new TabPage();
            overviewDataGridView = new DataGridView();
            metroTabControl1.SuspendLayout();
            TodoTabPage.SuspendLayout();
            Todo.SuspendLayout();
            overviewTabPage.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)overviewDataGridView).BeginInit();
            SuspendLayout();
            // 
            // metroTabControl1
            // 
            metroTabControl1.Controls.Add(TodoTabPage);
            metroTabControl1.Controls.Add(overviewTabPage);
            metroTabControl1.Location = new Point(15, 97);
            metroTabControl1.Margin = new Padding(4, 5, 4, 5);
            metroTabControl1.Name = "metroTabControl1";
            metroTabControl1.SelectedIndex = 1;
            metroTabControl1.Size = new Size(1311, 738);
            metroTabControl1.TabIndex = 0;
            // 
            // TodoTabPage
            // 
            TodoTabPage.Controls.Add(label1);
            TodoTabPage.Controls.Add(label2);
            TodoTabPage.Controls.Add(onTheLineLabel);
            TodoTabPage.Controls.Add(updateButton);
            TodoTabPage.Controls.Add(roomNLabel);
            TodoTabPage.Controls.Add(floorNLabel);
            TodoTabPage.Controls.Add(roomTypeLabel);
            TodoTabPage.Controls.Add(Todo);
            TodoTabPage.Controls.Add(floorNTextBox);
            TodoTabPage.Controls.Add(roomNTextBox);
            TodoTabPage.Controls.Add(roomTypeTextBox);
            TodoTabPage.Controls.Add(phoneNTextBox);
            TodoTabPage.Controls.Add(queueListBox);
            TodoTabPage.Controls.Add(phoneNLabel);
            TodoTabPage.Controls.Add(firstNameTextBox);
            TodoTabPage.Controls.Add(lastNameTextBox);
            TodoTabPage.Location = new Point(4, 29);
            TodoTabPage.Margin = new Padding(4, 5, 4, 5);
            TodoTabPage.Name = "TodoTabPage";
            TodoTabPage.Size = new Size(1303, 705);
            TodoTabPage.TabIndex = 0;
            TodoTabPage.Text = "TODO";
            TodoTabPage.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.Transparent;
            label1.Location = new Point(254, 115);
            label1.Margin = new Padding(4, 0, 4, 0);
            label1.Name = "label1";
            label1.Size = new Size(79, 20);
            label1.TabIndex = 63;
            label1.Text = "Last Name";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = Color.Transparent;
            label2.Location = new Point(39, 115);
            label2.Margin = new Padding(4, 0, 4, 0);
            label2.Name = "label2";
            label2.Size = new Size(80, 20);
            label2.TabIndex = 62;
            label2.Text = "First Name";
            // 
            // onTheLineLabel
            // 
            onTheLineLabel.AutoSize = true;
            onTheLineLabel.BackColor = Color.Transparent;
            onTheLineLabel.Location = new Point(943, 55);
            onTheLineLabel.Margin = new Padding(4, 0, 4, 0);
            onTheLineLabel.Name = "onTheLineLabel";
            onTheLineLabel.Size = new Size(81, 20);
            onTheLineLabel.TabIndex = 61;
            onTheLineLabel.Text = "On the line";
            // 
            // updateButton
            // 
            updateButton.BackColor = Color.Green;
            updateButton.ForeColor = Color.White;
            updateButton.Location = new Point(943, 589);
            updateButton.Margin = new Padding(4, 5, 4, 5);
            updateButton.Name = "updateButton";
            updateButton.Size = new Size(299, 48);
            updateButton.TabIndex = 60;
            updateButton.Text = "Update changes";
            updateButton.UseVisualStyleBackColor = false;
            updateButton.Click += updateButton_Click;
            // 
            // roomNLabel
            // 
            roomNLabel.AutoSize = true;
            roomNLabel.BackColor = Color.Transparent;
            roomNLabel.Location = new Point(41, 401);
            roomNLabel.Margin = new Padding(4, 0, 4, 0);
            roomNLabel.Name = "roomNLabel";
            roomNLabel.Size = new Size(62, 20);
            roomNLabel.TabIndex = 58;
            roomNLabel.Text = "Room #";
            // 
            // floorNLabel
            // 
            floorNLabel.AutoSize = true;
            floorNLabel.BackColor = Color.Transparent;
            floorNLabel.Location = new Point(254, 306);
            floorNLabel.Margin = new Padding(4, 0, 4, 0);
            floorNLabel.Name = "floorNLabel";
            floorNLabel.Size = new Size(56, 20);
            floorNLabel.TabIndex = 57;
            floorNLabel.Text = "Floor #";
            // 
            // roomTypeLabel
            // 
            roomTypeLabel.AutoSize = true;
            roomTypeLabel.BackColor = Color.Transparent;
            roomTypeLabel.Location = new Point(41, 306);
            roomTypeLabel.Margin = new Padding(4, 0, 4, 0);
            roomTypeLabel.Name = "roomTypeLabel";
            roomTypeLabel.Size = new Size(82, 20);
            roomTypeLabel.TabIndex = 56;
            roomTypeLabel.Text = "Room type";
            // 
            // Todo
            // 
            Todo.BackColor = Color.Transparent;
            Todo.BackgroundImageLayout = ImageLayout.None;
            Todo.Controls.Add(dinnerQTLabel);
            Todo.Controls.Add(lunchQTLabel);
            Todo.Controls.Add(breakfastQTLabel);
            Todo.Controls.Add(breakfastTextBox);
            Todo.Controls.Add(foodSelectionButton);
            Todo.Controls.Add(supplyCheckBox);
            Todo.Controls.Add(lunchTextBox);
            Todo.Controls.Add(towelCheckBox);
            Todo.Controls.Add(dinnerTextBox);
            Todo.Controls.Add(cleaningCheckBox);
            Todo.Controls.Add(surpriseCheckBox);
            Todo.FlatStyle = FlatStyle.Flat;
            Todo.Location = new Point(469, 69);
            Todo.Margin = new Padding(4, 5, 4, 5);
            Todo.Name = "Todo";
            Todo.Padding = new Padding(4, 5, 4, 5);
            Todo.Size = new Size(465, 497);
            Todo.TabIndex = 55;
            Todo.TabStop = false;
            Todo.Text = "Todo";
            // 
            // dinnerQTLabel
            // 
            dinnerQTLabel.AutoSize = true;
            dinnerQTLabel.BackColor = Color.Transparent;
            dinnerQTLabel.Location = new Point(23, 143);
            dinnerQTLabel.Margin = new Padding(4, 0, 4, 0);
            dinnerQTLabel.Name = "dinnerQTLabel";
            dinnerQTLabel.Size = new Size(93, 20);
            dinnerQTLabel.TabIndex = 63;
            dinnerQTLabel.Text = "Dinner [QTY]";
            // 
            // lunchQTLabel
            // 
            lunchQTLabel.AutoSize = true;
            lunchQTLabel.BackColor = Color.Transparent;
            lunchQTLabel.Location = new Point(239, 46);
            lunchQTLabel.Margin = new Padding(4, 0, 4, 0);
            lunchQTLabel.Name = "lunchQTLabel";
            lunchQTLabel.Size = new Size(87, 20);
            lunchQTLabel.TabIndex = 62;
            lunchQTLabel.Text = "Lunch [QTY]";
            // 
            // breakfastQTLabel
            // 
            breakfastQTLabel.AutoSize = true;
            breakfastQTLabel.BackColor = Color.Transparent;
            breakfastQTLabel.Location = new Point(23, 46);
            breakfastQTLabel.Margin = new Padding(4, 0, 4, 0);
            breakfastQTLabel.Name = "breakfastQTLabel";
            breakfastQTLabel.Size = new Size(110, 20);
            breakfastQTLabel.TabIndex = 61;
            breakfastQTLabel.Text = "Breakfast [QTY]";
            // 
            // breakfastTextBox
            // 
            breakfastTextBox.BackColor = Color.White;
            breakfastTextBox.BorderStyle = BorderStyle.FixedSingle;
            breakfastTextBox.Enabled = false;
            breakfastTextBox.Location = new Point(23, 71);
            breakfastTextBox.Margin = new Padding(4, 5, 4, 5);
            breakfastTextBox.Name = "breakfastTextBox";
            breakfastTextBox.ReadOnly = true;
            breakfastTextBox.Size = new Size(206, 27);
            breakfastTextBox.TabIndex = 47;
            // 
            // foodSelectionButton
            // 
            foodSelectionButton.BackColor = Color.Green;
            foodSelectionButton.ForeColor = Color.White;
            foodSelectionButton.Location = new Point(23, 425);
            foodSelectionButton.Margin = new Padding(4, 5, 4, 5);
            foodSelectionButton.Name = "foodSelectionButton";
            foodSelectionButton.Size = new Size(423, 48);
            foodSelectionButton.TabIndex = 59;
            foodSelectionButton.Text = "Change food selection?";
            foodSelectionButton.UseVisualStyleBackColor = false;
            foodSelectionButton.Click += foodSelectionButton_Click;
            // 
            // supplyCheckBox
            // 
            supplyCheckBox.AutoSize = true;
            supplyCheckBox.BackColor = Color.Transparent;
            supplyCheckBox.Location = new Point(168, 366);
            supplyCheckBox.Margin = new Padding(4, 5, 4, 5);
            supplyCheckBox.Name = "supplyCheckBox";
            supplyCheckBox.Size = new Size(169, 24);
            supplyCheckBox.TabIndex = 42;
            supplyCheckBox.Text = "Food/Supply status ?";
            supplyCheckBox.UseVisualStyleBackColor = false;
            // 
            // lunchTextBox
            // 
            lunchTextBox.BackColor = Color.White;
            lunchTextBox.BorderStyle = BorderStyle.FixedSingle;
            lunchTextBox.Enabled = false;
            lunchTextBox.Location = new Point(239, 71);
            lunchTextBox.Margin = new Padding(4, 5, 4, 5);
            lunchTextBox.Name = "lunchTextBox";
            lunchTextBox.ReadOnly = true;
            lunchTextBox.Size = new Size(206, 27);
            lunchTextBox.TabIndex = 48;
            // 
            // towelCheckBox
            // 
            towelCheckBox.BackColor = Color.Transparent;
            towelCheckBox.Enabled = false;
            towelCheckBox.Location = new Point(180, 262);
            towelCheckBox.Margin = new Padding(4, 5, 4, 5);
            towelCheckBox.Name = "towelCheckBox";
            towelCheckBox.Size = new Size(103, 32);
            towelCheckBox.TabIndex = 52;
            towelCheckBox.Text = "Towels";
            towelCheckBox.UseVisualStyleBackColor = false;
            // 
            // dinnerTextBox
            // 
            dinnerTextBox.BackColor = Color.White;
            dinnerTextBox.BorderStyle = BorderStyle.FixedSingle;
            dinnerTextBox.Enabled = false;
            dinnerTextBox.Location = new Point(23, 168);
            dinnerTextBox.Margin = new Padding(4, 5, 4, 5);
            dinnerTextBox.Name = "dinnerTextBox";
            dinnerTextBox.ReadOnly = true;
            dinnerTextBox.Size = new Size(422, 27);
            dinnerTextBox.TabIndex = 49;
            // 
            // cleaningCheckBox
            // 
            cleaningCheckBox.BackColor = Color.Transparent;
            cleaningCheckBox.Enabled = false;
            cleaningCheckBox.Location = new Point(29, 262);
            cleaningCheckBox.Margin = new Padding(4, 5, 4, 5);
            cleaningCheckBox.Name = "cleaningCheckBox";
            cleaningCheckBox.Size = new Size(103, 32);
            cleaningCheckBox.TabIndex = 51;
            cleaningCheckBox.Text = "Cleaning";
            cleaningCheckBox.UseVisualStyleBackColor = false;
            // 
            // surpriseCheckBox
            // 
            surpriseCheckBox.BackColor = Color.Transparent;
            surpriseCheckBox.Enabled = false;
            surpriseCheckBox.Location = new Point(291, 263);
            surpriseCheckBox.Margin = new Padding(4, 5, 4, 5);
            surpriseCheckBox.Name = "surpriseCheckBox";
            surpriseCheckBox.Size = new Size(161, 32);
            surpriseCheckBox.TabIndex = 50;
            surpriseCheckBox.Text = "Sweetest Surprise";
            surpriseCheckBox.UseVisualStyleBackColor = false;
            // 
            // floorNTextBox
            // 
            floorNTextBox.BackColor = Color.White;
            floorNTextBox.BorderStyle = BorderStyle.FixedSingle;
            floorNTextBox.Enabled = false;
            floorNTextBox.Location = new Point(253, 331);
            floorNTextBox.Margin = new Padding(4, 5, 4, 5);
            floorNTextBox.Name = "floorNTextBox";
            floorNTextBox.ReadOnly = true;
            floorNTextBox.Size = new Size(206, 27);
            floorNTextBox.TabIndex = 46;
            // 
            // roomNTextBox
            // 
            roomNTextBox.BackColor = Color.White;
            roomNTextBox.BorderStyle = BorderStyle.FixedSingle;
            roomNTextBox.Enabled = false;
            roomNTextBox.Location = new Point(41, 426);
            roomNTextBox.Margin = new Padding(4, 5, 4, 5);
            roomNTextBox.Name = "roomNTextBox";
            roomNTextBox.ReadOnly = true;
            roomNTextBox.Size = new Size(421, 27);
            roomNTextBox.TabIndex = 45;
            // 
            // roomTypeTextBox
            // 
            roomTypeTextBox.BackColor = Color.White;
            roomTypeTextBox.BorderStyle = BorderStyle.FixedSingle;
            roomTypeTextBox.Enabled = false;
            roomTypeTextBox.Location = new Point(39, 331);
            roomTypeTextBox.Margin = new Padding(4, 5, 4, 5);
            roomTypeTextBox.Name = "roomTypeTextBox";
            roomTypeTextBox.ReadOnly = true;
            roomTypeTextBox.Size = new Size(206, 27);
            roomTypeTextBox.TabIndex = 44;
            // 
            // phoneNTextBox
            // 
            phoneNTextBox.BackColor = Color.White;
            phoneNTextBox.BorderStyle = BorderStyle.FixedSingle;
            phoneNTextBox.Enabled = false;
            phoneNTextBox.Location = new Point(41, 237);
            phoneNTextBox.Margin = new Padding(4, 5, 4, 5);
            phoneNTextBox.Name = "phoneNTextBox";
            phoneNTextBox.ReadOnly = true;
            phoneNTextBox.Size = new Size(421, 27);
            phoneNTextBox.TabIndex = 43;
            // 
            // queueListBox
            // 
            queueListBox.FormattingEnabled = true;
            queueListBox.Location = new Point(943, 80);
            queueListBox.Margin = new Padding(4, 5, 4, 5);
            queueListBox.Name = "queueListBox";
            queueListBox.Size = new Size(297, 484);
            queueListBox.TabIndex = 40;
            // 
            // phoneNLabel
            // 
            phoneNLabel.AutoSize = true;
            phoneNLabel.BackColor = Color.Transparent;
            phoneNLabel.Location = new Point(41, 212);
            phoneNLabel.Margin = new Padding(4, 0, 4, 0);
            phoneNLabel.Name = "phoneNLabel";
            phoneNLabel.Size = new Size(105, 20);
            phoneNLabel.TabIndex = 30;
            phoneNLabel.Text = "Phone number";
            // 
            // firstNameTextBox
            // 
            firstNameTextBox.BackColor = Color.White;
            firstNameTextBox.BorderStyle = BorderStyle.FixedSingle;
            firstNameTextBox.Enabled = false;
            firstNameTextBox.Location = new Point(40, 140);
            firstNameTextBox.Margin = new Padding(4, 5, 4, 5);
            firstNameTextBox.Name = "firstNameTextBox";
            firstNameTextBox.ReadOnly = true;
            firstNameTextBox.Size = new Size(206, 27);
            firstNameTextBox.TabIndex = 21;
            // 
            // lastNameTextBox
            // 
            lastNameTextBox.BackColor = Color.White;
            lastNameTextBox.BorderStyle = BorderStyle.FixedSingle;
            lastNameTextBox.Enabled = false;
            lastNameTextBox.Location = new Point(255, 140);
            lastNameTextBox.Margin = new Padding(4, 5, 4, 5);
            lastNameTextBox.Name = "lastNameTextBox";
            lastNameTextBox.ReadOnly = true;
            lastNameTextBox.Size = new Size(206, 27);
            lastNameTextBox.TabIndex = 22;
            // 
            // overviewTabPage
            // 
            overviewTabPage.Controls.Add(overviewDataGridView);
            overviewTabPage.Location = new Point(4, 29);
            overviewTabPage.Margin = new Padding(4, 5, 4, 5);
            overviewTabPage.Name = "overviewTabPage";
            overviewTabPage.Size = new Size(1303, 705);
            overviewTabPage.TabIndex = 1;
            overviewTabPage.Text = "Overview";
            overviewTabPage.UseVisualStyleBackColor = true;
            // 
            // overviewDataGridView
            // 
            overviewDataGridView.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            overviewDataGridView.Location = new Point(0, 31);
            overviewDataGridView.Margin = new Padding(4, 5, 4, 5);
            overviewDataGridView.Name = "overviewDataGridView";
            overviewDataGridView.RowHeadersWidth = 51;
            overviewDataGridView.Size = new Size(1300, 526);
            overviewDataGridView.TabIndex = 2;
            // 
            // Kitchen
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1333, 846);
            Controls.Add(metroTabControl1);
            Margin = new Padding(4, 5, 4, 5);
            Name = "Kitchen";
            Text = "Room Service";
            Load += Kitchen_Load;
            metroTabControl1.ResumeLayout(false);
            TodoTabPage.ResumeLayout(false);
            TodoTabPage.PerformLayout();
            Todo.ResumeLayout(false);
            Todo.PerformLayout();
            overviewTabPage.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)overviewDataGridView).EndInit();
            ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl metroTabControl1;
        private System.Windows.Forms.TabPage TodoTabPage;
        private System.Windows.Forms.TabPage overviewTabPage;
        private System.Windows.Forms.DataGridView overviewDataGridView;
        private System.Windows.Forms.Label phoneNLabel;
        private System.Windows.Forms.TextBox firstNameTextBox;
        private System.Windows.Forms.TextBox lastNameTextBox;
        private System.Windows.Forms.ListBox queueListBox;
        private System.Windows.Forms.TextBox phoneNTextBox;
        private System.Windows.Forms.CheckBox supplyCheckBox;
        private System.Windows.Forms.TextBox floorNTextBox;
        private System.Windows.Forms.TextBox roomNTextBox;
        private System.Windows.Forms.TextBox roomTypeTextBox;
        private System.Windows.Forms.CheckBox towelCheckBox;
        private System.Windows.Forms.CheckBox cleaningCheckBox;
        private System.Windows.Forms.CheckBox surpriseCheckBox;
        private System.Windows.Forms.TextBox dinnerTextBox;
        private System.Windows.Forms.TextBox lunchTextBox;
        private System.Windows.Forms.TextBox breakfastTextBox;
        private System.Windows.Forms.GroupBox Todo;
        private System.Windows.Forms.Label roomNLabel;
        private System.Windows.Forms.Label floorNLabel;
        private System.Windows.Forms.Label roomTypeLabel;
        private System.Windows.Forms.Button foodSelectionButton;
        private System.Windows.Forms.Button updateButton;
        private System.Windows.Forms.Label dinnerQTLabel;
        private System.Windows.Forms.Label lunchQTLabel;
        private System.Windows.Forms.Label breakfastQTLabel;
        private System.Windows.Forms.Label onTheLineLabel;
        private Label label1;
        private Label label2;
    }
}
