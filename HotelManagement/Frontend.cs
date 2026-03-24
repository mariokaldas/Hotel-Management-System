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
    public partial class Frontend : Form
    {
        private ReservationContext reservationContext = new();
        private Reservation reservation;

        BindingSource mainBS = new BindingSource();
        BindingSource viewBS = new BindingSource();

        public Frontend()
        {
            InitializeComponent();
        }

        private void Frontend_FormClosed(object sender, FormClosedEventArgs e)
        {
            reservationContext.Dispose();
            Application.Exit();
        }

        private void Frontend_Load(object sender, EventArgs e)
        {
            reservationContext.Reservations.Load();
            AdvView_load();
            universalSearch_load();

        }

        private void submitButton_Click(object sender, EventArgs e)
        {
            reservation.birth_day = birthdayDatePicker.Value.ToString();
            reservation.Id = reservation.lunch + reservation.dinner + reservation.break_fast;

            reservationContext.Reservations.Add(reservation);
            MessageBox.Show($"{reservationContext.SaveChanges()} rows affected", "Updates saved", MessageBoxButtons.OK, MessageBoxIcon.Information);
            submitButton.Visible = false;
        }

        private void editButton_Click(object sender, EventArgs e)
        {
            resList.Visible = true;
            updateButton.Visible = true;
            deleteButton.Visible = true;

            resList.DataSource = reservationContext.Reservations.Local.ToBindingList();
            resList.DisplayMember = "FullName";
            resList.ValueMember = "Id";

            firstNameTextBox.DataBindings.Add("Text", reservationContext.Reservations.Local.ToBindingList(), "first_name");
            lastNameTextBox.DataBindings.Add("Text", reservationContext.Reservations.Local.ToBindingList(), "last_name");
            genderComboBox.DataBindings.Add("SelectedItem", reservationContext.Reservations.Local.ToBindingList(), "gender");
            phoneNumberTextBox.DataBindings.Add("Text", reservationContext.Reservations.Local.ToBindingList(), "phone_number");
            emailTextBox.DataBindings.Add("Text", reservationContext.Reservations.Local.ToBindingList(), "email_address");
            streetAddressTextBox.DataBindings.Add("Text", reservationContext.Reservations.Local.ToBindingList(), "street_address");
            aptTextBox.DataBindings.Add("Text", reservationContext.Reservations.Local.ToBindingList(), "apt_suite");
            cityTextBox.DataBindings.Add("Text", reservationContext.Reservations.Local.ToBindingList(), "city");
            zipTextBox.DataBindings.Add("Text", reservationContext.Reservations.Local.ToBindingList(), "zip_code");
            stateComboBox.DataBindings.Add("SelectedItem", reservationContext.Reservations.Local.ToBindingList(), "state");
            qtGuestComboBox.DataBindings.Add("Text", reservationContext.Reservations.Local.ToBindingList(), "number_guest");
            roomTypeComboBox.DataBindings.Add("Text", reservationContext.Reservations.Local.ToBindingList(), "room_type");
            roomNComboBox.DataBindings.Add("Text", reservationContext.Reservations.Local.ToBindingList(), "room_number");
            floorComboBox.DataBindings.Add("Text", reservationContext.Reservations.Local.ToBindingList(), "room_floor");
            entryDatePicker.DataBindings.Add("Value", reservationContext.Reservations.Local.ToBindingList(), "arrival_time");
            depDatePicker.DataBindings.Add("Value", reservationContext.Reservations.Local.ToBindingList(), "leaving_time");
            checkinCheckBox.DataBindings.Add("Checked", reservationContext.Reservations.Local.ToBindingList(), "check_in");
            foodSupplyCheckBox.DataBindings.Add("Checked", reservationContext.Reservations.Local.ToBindingList(), "supply_status");

        }

        private void newButton_Click(object sender, EventArgs e)
        {
            resList.Visible = false;
            updateButton.Visible = false;
            deleteButton.Visible = false;

            firstNameTextBox.DataBindings.Clear();
            lastNameTextBox.DataBindings.Clear();
            genderComboBox.DataBindings.Clear();
            phoneNumberTextBox.DataBindings.Clear();
            emailTextBox.DataBindings.Clear();
            streetAddressTextBox.DataBindings.Clear();
            aptTextBox.DataBindings.Clear();
            zipTextBox.DataBindings.Clear();
            cityTextBox.DataBindings.Clear();
            stateComboBox.DataBindings.Clear();
            qtGuestComboBox.DataBindings.Clear();
            roomTypeComboBox.DataBindings.Clear();
            roomNComboBox.DataBindings.Clear();
            floorComboBox.DataBindings.Clear();
            entryDatePicker.DataBindings.Clear();
            depDatePicker.DataBindings.Clear();

            firstNameTextBox.Clear();
            lastNameTextBox.Clear();
            genderComboBox.SelectedItem = null;
            phoneNumberTextBox.Clear();
            emailTextBox.Clear();
            streetAddressTextBox.Clear();
            aptTextBox.Clear();
            zipTextBox.Clear();
            cityTextBox.Clear();
            stateComboBox.SelectedItem = null;
            qtGuestComboBox.SelectedItem = null;
            roomTypeComboBox.SelectedItem = null;
            roomNComboBox.SelectedItem = null;
            floorComboBox.SelectedItem = null;

        }

        private void updateButton_Click(object sender, EventArgs e)
        {
            MessageBox.Show($"{reservationContext.SaveChanges()} rows affected", "Updates saved", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void finalizeButton_Click(object sender, EventArgs e)
        {
            FinalizePayment payment = new FinalizePayment(reservation);
            payment.ShowDialog();
            submitButton.Visible = true;
        }

        private void foodMenuButton_Click(object sender, EventArgs e)
        {
            reservation = new Reservation();

            reservation.first_name = firstNameTextBox.Text;
            reservation.last_name = lastNameTextBox.Text;
            reservation.gender = genderComboBox.SelectedItem.ToString();
            reservation.phone_number = phoneNumberTextBox.Text;
            reservation.email_address = emailTextBox.Text;
            reservation.street_address = streetAddressTextBox.Text;
            reservation.city = cityTextBox.Text;
            reservation.zip_code = zipTextBox.Text;
            reservation.apt_suite = aptTextBox.Text;
            reservation.state = stateComboBox.SelectedItem.ToString();
            reservation.number_guest = int.Parse(qtGuestComboBox.SelectedItem.ToString());
            reservation.room_type = roomTypeComboBox.SelectedItem.ToString();
            reservation.room_floor = floorComboBox.SelectedItem.ToString();
            reservation.room_number = roomNComboBox.SelectedItem.ToString();
            reservation.arrival_time = entryDatePicker.Value;
            reservation.leaving_time = depDatePicker.Value;
            reservation.check_in = checkinCheckBox.Checked;
            reservation.supply_status = foodSupplyCheckBox.Checked;

            FoodMenu food = new FoodMenu(reservation, false);
            food.ShowDialog();
        }

        private void deleteButton_Click(object sender, EventArgs e)
        {
            Reservation res = new Reservation();

            res = reservationContext.Reservations.Local.FirstOrDefault(r => r.Id == (int)resList.SelectedValue);
            reservationContext.Reservations.Local.Remove(res);
            MessageBox.Show($"{reservationContext.SaveChanges()} rows affected", "Updates saved", MessageBoxButtons.OK, MessageBoxIcon.Information);

        }

        private void AdvView_load()
        {
            resTotalDataGridView.DataSource = reservationContext.Reservations.Local.ToBindingList();
            resTotalDataGridView.ReadOnly = true;
            resTotalDataGridView.AllowUserToAddRows = false;
            resTotalDataGridView.AllowUserToDeleteRows = false;
        }

        private void universalSearch_load()
        {

            mainBS.DataSource = reservationContext.Reservations.Local.ToBindingList();
            viewBS.DataSource = mainBS;

            searchDataGridView.DataSource = viewBS;
        }

        private void searchTextBox_TextChanged(object sender, EventArgs e)
        {
            string search = searchTextBox.Text.Trim().ToLower();

            if (string.IsNullOrEmpty(search))
            {
                // restore full list
                viewBS.DataSource = mainBS;
            }
            else
            {
                var filtered = reservationContext.Reservations.Local
                    .Where(r =>
                        (r.first_name != null && r.first_name.ToLower().Contains(search)) ||
                        (r.last_name != null && r.last_name.ToLower().Contains(search)) ||
                        (r.phone_number != null && r.phone_number.Contains(search)) ||
                        (r.email_address != null && r.email_address.ToLower().Contains(search))
                    )
                    .ToList();

                if (filtered.Count == 0)
                {
                    SearchError.Visible = true;
                }
                else
                {
                    SearchError.Visible = false;
                }

                viewBS.DataSource = filtered;
            }
        }

    }
}
