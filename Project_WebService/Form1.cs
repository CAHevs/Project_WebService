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
            double newAmount;
            if(!double.TryParse(txtAmount.Text, out newAmount))
            {
                lblInfo.Text = "This is a number only field";
            }
            else
            {
                newAmount += selectedUser.Amount;
                service.UpdateAmountViaId(selectedUser.IdUser, newAmount);
                lblAmount.Text = newAmount.ToString();
                CalculateNbreCopy();
                lblInfo.Text = "You have succesfully added : " + txtAmount.Text + " to your balance";
            }
           
        }

        private void btnAddViaUsername_Click(object sender, EventArgs e)
        {   
            double newAmount;
            if (!double.TryParse(txtAmount.Text, out newAmount))
            {
                lblInfo.Text = "This is a number only field";
            }
            else
            {
                newAmount += selectedUser.Amount;
                service.UpdateAmountViaUsername(selectedUser.Username, newAmount);
                lblAmount.Text = newAmount.ToString();
                CalculateNbreCopy();
                lblInfo.Text = "You have succesfully added : " + txtAmount.Text + " to your balance";
            }

        }

        private void CalculateNbreCopy()
        {
            double amount_available = double.Parse(lblAmount.Text);
            int nbreCopy = (int)(amount_available / priceCopy);
            lblNbreCopy.Text = nbreCopy.ToString();
        }

        private void btnPrint_Click(object sender, EventArgs e)
        {
            double nbreCopies;
            if(!double.TryParse(txtNbreCopyToPrint.Text, out nbreCopies))
            {
                lblInfo.Text = "This is a number only field";
            }
            else
            {
                double priceCopies = nbreCopies * priceCopy;
                double currentAmount = double.Parse(lblAmount.Text);
                double newAmount = currentAmount - priceCopies;
                service.UpdateAmountViaId(selectedUser.IdUser, newAmount);
                lblAmount.Text = newAmount.ToString();
                CalculateNbreCopy();
                lblInfo.Text = "You have succesfully print : " + txtNbreCopyToPrint.Text + " for a total of " + priceCopies;
            }
            
        }

        private void btnConnectUsername_Click(object sender, EventArgs e)
        {
            string username = txtUsername.Text;
            selectedUser = service.ConnectWithUsername(username);
            if (selectedUser != null)
            {
                changeDisplay(true, selectedUser);
            }
            else
            {
                changeDisplay(false, null);
            }


        }

        private void btnConnectWithId_Click(object sender, EventArgs e)
        {
            int id;
            if(!int.TryParse(txtId.Text, out id))
            {
                lblInfo.Text = "This is a number only field";
            }
            else
            {
                selectedUser = service.ConnectWithId(id);
                if (selectedUser != null)
                {
                    changeDisplay(true, selectedUser);
                }
                else
                {
                    changeDisplay(false, null);
                }
            } 
        }

        private void changeDisplay(bool connected, User user)
        {
            if (connected)
            {
                lblFirstname.Text = user.Firstname;
                lblLastname.Text = user.Lastname;
                lblAmount.Text = user.Amount.ToString();

                btnAddViaId.Enabled = true;
                btnAddViaUsername.Enabled = true;
                txtAmount.Enabled = true;
                btnPrint.Enabled = true;
                txtNbreCopyToPrint.Enabled = true;

                CalculateNbreCopy();

                lblInfo.Text = "You're connected as : " + user.Username;
                connected = true;
            }
            else
            {
                lblFirstname.Text = "-";
                lblLastname.Text = "-";
                lblAmount.Text = "-";

                btnAddViaId.Enabled = false;
                btnAddViaUsername.Enabled = false;
                txtAmount.Enabled = false;
                btnPrint.Enabled = false;
                txtNbreCopyToPrint.Enabled = false;

                lblNbreCopy.Text = "-";

                lblInfo.Text = "Error during the connection. The username or the id does not exists";
                connected = false;
            }
        }
    }
}
