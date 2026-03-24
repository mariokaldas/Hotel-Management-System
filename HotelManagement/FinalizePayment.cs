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
    public partial class FinalizePayment : Form
    {
        private Reservation res;
        public FinalizePayment()
        {
            InitializeComponent();
        }

        public FinalizePayment(Reservation reservation) : this()
        {
            {
                this.res = reservation;
            }
        }

        private void nextButton_Click(object sender, EventArgs e)
        {
            res.payment_type = paymentComboBox.Text;
            res.card_type = "Visa";
            res.card_number = cardNumberTextBox.Text;
            res.card_cvc = cvcTextBox.Text;
            res.card_exp = monthComboBox.Text + "/" + yearComboBox.Text;

            res.food_bill = (res.break_fast*7) + (res.lunch*15) + (res.dinner*15);
            res.total_bill = res.food_bill + ((res.food_bill * 10)/100); 

            this.Close();
        }
    }
}
