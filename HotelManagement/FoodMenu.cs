using HotelManagement.Entities;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace HotelManagement
{
    public partial class FoodMenu : Form
    {

        bool foodOnly = false;
        Reservation reservation;

        public FoodMenu()
        {
            InitializeComponent();
        }
        public FoodMenu(Reservation reservation, bool food) : this()
        {
            foodOnly = food;
            this.reservation = reservation;
        }

        private void FoodMenu_Load(object sender, EventArgs e)
        {
            if (foodOnly)
            {
                cleaningCheckBox.Enabled = false;
                towelsCheckBox.Enabled = false;
                surpriseCheckBox.Enabled = false;
            }
        }

        private void lunchCheckBox_CheckedChanged(object sender, EventArgs e)
        {
            if (lunchCheckBox.Checked)
            {
                lunchQTY.Enabled = true;
            }
            else
            {
                lunchQTY.Enabled = false;
            }
        }

        private void breakfastCheckBox_CheckedChanged(object sender, EventArgs e)
        {
            if (breakfastCheckBox.Checked)
            {
                breakfastQTY.Enabled = true;
            }
            else
            {
                breakfastQTY.Enabled = false;
            }
        }

        private void dinnerCheckBox_CheckedChanged(object sender, EventArgs e)
        {
            if (dinnerCheckBox.Checked)
            {
                dinnerQTY.Enabled = true;
            }
            else
            {
                dinnerQTY.Enabled = false;
            }
        }

        private void nextButton_Click(object sender, EventArgs e)
        {
            if (breakfastQTY.Enabled)
            {
                reservation.break_fast = int.Parse(breakfastQTY.Text);
            }

            if (lunchQTY.Enabled)
            {
                reservation.lunch = int.Parse(lunchQTY.Text);
            }

            if (dinnerQTY.Enabled)
            {
                reservation.dinner = int.Parse(dinnerQTY.Text);
            }

            if(!foodOnly)
            {
                reservation.cleaning = cleaningCheckBox.Checked;
                reservation.towel = towelsCheckBox.Checked;
                reservation.s_surprise = surpriseCheckBox.Checked;
            }
            this.Close();
        }
    }
}
