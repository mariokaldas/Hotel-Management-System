using HotelManagement.Context;
using HotelManagement.Entities;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace HotelManagement
{
    public partial class Kitchen : Form
    {
        ReservationContext reservation = new();
        public Kitchen()
        {
            InitializeComponent();
        }

        private void Kitchen_Load(object sender, EventArgs e)
        {
            reservation.Reservations.Load();
            this.FormClosed += (sender, e) => reservation.Dispose();

            OverView_load();
            TODO_load();
        }

        private void OverView_load()
        {
            overviewDataGridView.DataSource = reservation.Reservations.Local.ToBindingList();
            overviewDataGridView.ReadOnly = true;
            overviewDataGridView.AllowUserToAddRows = false;
            overviewDataGridView.AllowUserToDeleteRows = false;
        }
        private void TODO_load()
        {
            queueListBox.DataSource = reservation.Reservations.Local.ToBindingList();
            queueListBox.DisplayMember = "FullName";
            queueListBox.ValueMember = "Id";

            firstNameTextBox.DataBindings.Add("Text", reservation.Reservations.Local.ToBindingList(), "first_name");
            lastNameTextBox.DataBindings.Add("Text", reservation.Reservations.Local.ToBindingList(), "last_name");
            phoneNTextBox.DataBindings.Add("Text", reservation.Reservations.Local.ToBindingList(), "phone_number");
            roomTypeTextBox.DataBindings.Add("Text", reservation.Reservations.Local.ToBindingList(), "room_type");
            roomNTextBox.DataBindings.Add("Text", reservation.Reservations.Local.ToBindingList(), "room_number");
            floorNTextBox.DataBindings.Add("Text", reservation.Reservations.Local.ToBindingList(), "room_floor");
            breakfastTextBox.DataBindings.Add("Text", reservation.Reservations.Local.ToBindingList(), "break_fast");
            lunchTextBox.DataBindings.Add("Text", reservation.Reservations.Local.ToBindingList(), "lunch");
            dinnerTextBox.DataBindings.Add("Text", reservation.Reservations.Local.ToBindingList(), "dinner");
            cleaningCheckBox.DataBindings.Add("Checked", reservation.Reservations.Local.ToBindingList(), "cleaning");
            towelCheckBox.DataBindings.Add("Checked", reservation.Reservations.Local.ToBindingList(), "towel");
            surpriseCheckBox.DataBindings.Add("Checked", reservation.Reservations.Local.ToBindingList(), "s_surprise");
            supplyCheckBox.DataBindings.Add("Checked", reservation.Reservations.Local.ToBindingList(), "supply_status");

        }

        private void foodSelectionButton_Click(object sender, EventArgs e)
        {
            Reservation res = reservation.Reservations.Local.FirstOrDefault(r => r.Id == (int)queueListBox.SelectedValue);
            FoodMenu menu = new FoodMenu(res, true);
            menu.ShowDialog();
        }

        private void updateButton_Click(object sender, EventArgs e)
        {
            MessageBox.Show($"{reservation.SaveChanges()} rows affected", "Updates saved", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
    }
}
