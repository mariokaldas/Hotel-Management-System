using HotelManagement.Context;
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
    public partial class Login : Form
    {
        LoginMGRcontext frontendTable = new();
        LoginMGRcontext kitchenTable = new();

        Entities.Frontend admin = new();
        Entities.Kitchen kitchen = new();

        public Login()
        {
            InitializeComponent();
        }

        private void Login_Load(object sender, EventArgs e)
        {
            frontendTable.Frontend.Load();
            kitchenTable.Kitchen.Load();

            this.FormClosed += (sender, e) =>
            {
                frontendTable.Dispose();
                kitchenTable.Dispose();
            };
        }

        private void signinButton_Click(object sender, EventArgs e)
        {
            if(usernameTextBox.Text == string.Empty || passwordTextBox.Text == string.Empty)
            {
                lblSignIn.Visible = true;
            }
            else
            {
                lblSignIn.Visible = false;
                switch (Authorize(usernameTextBox.Text, passwordTextBox.Text))
                {
                    case "admin":
                        Frontend frmFrontend = new Frontend();
                        frmFrontend.Show();
                        this.Hide();
                        break;

                    case "kitchen":
                        Kitchen frmKitchen = new Kitchen();
                        frmKitchen.Show();
                        this.Hide();
                        break;

                    case "invalid":
                        MessageBox.Show("Invalid Credentials","Error",MessageBoxButtons.OK, MessageBoxIcon.Error);
                        break;

                    default:
                        throw new Exception("Unexpected behavior");
                
                }
            }
        }

        private string Authorize(string username, string password)
        {
            Entities.Frontend admin = frontendTable.Frontend.Local
                .FirstOrDefault(a => (a.user_name.Equals(username) && a.pass_word.Equals(password)));

            Entities.Kitchen kitchen = kitchenTable.Kitchen.Local
                .FirstOrDefault(a => (a.user_name.Equals(username) && a.pass_word.Equals(password)));

            if (admin != null)
                return "admin";

            else if (kitchen != null)
                return "kitchen";

            else
                return "invalid";
        }
    }
}
