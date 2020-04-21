using System;
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
        public User[] users;
        public User selectedUser;
        public ServiceReferenceUserAccount.UpdateAmountServiceClient service = new ServiceReferenceUserAccount.UpdateAmountServiceClient();

        public double priceCopy = 0.08;
        public Form1()
        {
            InitializeComponent();

            users = service.GetAllUsers();

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
            btnPrint.Enabled = true;
            txtNbreCopyToPrint.Enabled = true;

            CalculateNbreCopy();

            lblInfo.Text = "You're connected as : " + selectedUser.Username;
        }

        private void btnAddViaId_Click(object sender, EventArgs e)
        {
            double newAmount = double.Parse(txtAmount.Text) + selectedUser.Amount;
            service.UpdateAmountViaId(selectedUser.IdUser, newAmount);
            lblAmount.Text = newAmount.ToString();
            CalculateNbreCopy();
            lblInfo.Text = "You have succesfully added : " + txtAmount.Text + " to your balance";
        }

        private void btnAddViaUsername_Click(object sender, EventArgs e)
        {
            double newAmount = double.Parse(txtAmount.Text) + selectedUser.Amount;
            service.UpdateAmountViaUsername(selectedUser.Username, newAmount);
            lblAmount.Text = newAmount.ToString();
            CalculateNbreCopy();
            lblInfo.Text = "You have succesfully added : " + txtAmount.Text + " to your balance";
        }

        private void CalculateNbreCopy()
        {
            double amount_available = double.Parse(lblAmount.Text);
            int nbreCopy = (int)(amount_available / priceCopy);
            lblNbreCopy.Text = nbreCopy.ToString();
        }

        private void btnPrint_Click(object sender, EventArgs e)
        {
            double nbreCopies = double.Parse(txtNbreCopyToPrint.Text);
            double priceCopies = nbreCopies * priceCopy;
            double currentAmount = double.Parse(lblAmount.Text);
            double newAmount = currentAmount - priceCopies;
            service.UpdateAmountViaId(selectedUser.IdUser, newAmount);
            lblAmount.Text = newAmount.ToString();
            CalculateNbreCopy();
            lblInfo.Text = "You have succesfully print : " + txtNbreCopyToPrint.Text+ " for a total of " + priceCopies;
        }
    }
}
