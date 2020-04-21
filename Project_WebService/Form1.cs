﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BLL;
using DTO;
using Microsoft.Extensions.Configuration;

namespace Project_WebService
{
    public partial class Form1 : Form
    {
        /*public static IConfiguration Configuration { get; } = new ConfigurationBuilder()
            .SetBasePath(Directory.GetCurrentDirectory())
            .AddJsonFile("appsettings.json", optional: true, reloadOnChange: true)
            .Build();*/

        public ServiceReferenceUpdateAmount.UpdateAmountServiceClient service = new ServiceReferenceUpdateAmount.UpdateAmountServiceClient();

        public List<User> users;
        public User selectedUser;

        public double priceCopy = 0.08;
        public Form1()
        {
            InitializeComponent();

            foreach(var user in users)
            {
                lbUsername.Items.Add(user.Username);
            }
        }

        private void lbUsername_SelectedIndexChanged(object sender, EventArgs e)
        {
            string selectedUsername = lbUsername.SelectedItem.ToString();
            foreach (var user in users)
            {
                if (user.Username == selectedUsername)
                {
                   selectedUser = user;
                }
            }
           
            lblFirstname.Text = selectedUser.Firstname;
            lblLastname.Text = selectedUser.Lastname;
            lblAmount.Text = selectedUser.Amount.ToString();

            btnAddViaId.Enabled = true;
            btnAddViaUsername.Enabled = true;
            txtAmount.Enabled = true;
            btnNbreCopy.Enabled = true;

            CalculateNbreCopy();
        }

        private void btnAddViaId_Click(object sender, EventArgs e)
        {
            CalculateNbreCopy();     
        }

        private void CalculateNbreCopy()
        {
            double amount_available = double.Parse(lblAmount.Text);
            int nbreCopy = (int)(amount_available / priceCopy);
            lblNbreCopy.Text = nbreCopy.ToString();
        }
    }
}
