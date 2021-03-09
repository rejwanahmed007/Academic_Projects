using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TMS.Data;
using TMS.Entity;
using TMS.Framework;
using TMS.Repository;

namespace TMS.ApplicationLayer
{
    public partial class ChangePasswordTicketSeller : Form
    {
        private Employee employee;
        internal ChangePasswordTicketSeller(Employee employee)
        {
            InitializeComponent();
            this.employee = employee;
        }

        private void ChangePasswordTicketSeller_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

        private void BtnRefresh_Click(object sender, EventArgs e)
        {
            ChangePasswordTicketSeller changePasswordTicketSeller = new ChangePasswordTicketSeller(this.employee);
            changePasswordTicketSeller.Visible = true;
            this.Visible = false;
        }

        private void TxtCurrentPassword_Leave(object sender, EventArgs e)
        {
            if (Validation.IsStringValid(this.txtCurrentPassword.Text.ToString()) == false)
            {
                this.txtCurrentPassword.Focus();
                this.errPassword.SetError(this.txtCurrentPassword, "Please enter password");
            }
            else
            {
                if (this.employee.Password.Equals(this.txtCurrentPassword.Text.ToString()))
                { errPassword.Clear(); }
                else
                {
                    this.txtCurrentPassword.Focus();
                    this.errPassword.SetError(this.txtCurrentPassword, "password not matched !");

                }
            }
        }

        private void TxtNewPassword_Leave(object sender, EventArgs e)
        {
            if (Validation.IsStringValid(this.txtNewPassword.Text.ToString()) == false)
            {
                this.txtNewPassword.Focus();
                this.errNewPassword.SetError(this.txtNewPassword, "Please enter password");
            }
            else
            {
                if (this.txtCurrentPassword.Text.ToString().Equals(this.txtNewPassword.Text.ToString()))
                {
                    MessageBox.Show("You have entered an old password,please try a new one !");
                    this.txtNewPassword.Focus();
                    this.errNewPassword.SetError(this.txtNewPassword, "You have entered an old password,please try a new one !");
                }
                else
                    this.errNewPassword.Clear();
            }
        }

        private void TxtConfirmPassword_Leave(object sender, EventArgs e)
        {
            if (Validation.IsStringValid(this.txtConfirmPassword.Text.ToString()) == false)
            {
                this.txtConfirmPassword.Focus();
                this.errConfirmPassword.SetError(this.txtConfirmPassword, "Please Retype password");
            }
            else
            {
                if (this.txtNewPassword.Text.ToString().Equals(this.txtConfirmPassword.Text.ToString()))
                    this.errConfirmPassword.Clear();
                else
                {
                    this.txtConfirmPassword.Focus();
                    this.errConfirmPassword.SetError(this.txtConfirmPassword, "Password Mismatched");

                }
            }
        }

        private void BtnSave_Click(object sender, EventArgs e)
        {
            if (!this.txtNewPassword.Text.ToString().Equals(this.txtConfirmPassword.Text.ToString()) || this.txtNewPassword.Text.ToString().Length.Equals(0) || this.txtConfirmPassword.Text.ToString().Length.Equals(0) || this.txtCurrentPassword.Text.ToString().Length.Equals(0) || this.txtCurrentPassword.Text.ToString().Equals(this.txtNewPassword.Text.ToString()) || !this.employee.Password.Equals(this.txtCurrentPassword.Text.ToString()) || Validation.IsStringValid(this.txtCurrentPassword.Text.ToString()) == false || Validation.IsStringValid(this.txtNewPassword.Text.ToString()) == false || Validation.IsStringValid(this.txtConfirmPassword.Text.ToString()) == false)
            {
                MessageBox.Show("Invalid Info");
                txtCurrentPassword.Focus();
            }
            else
            {
                this.employee.Password = this.txtNewPassword.Text.ToString();
                UserRepo employeeRepo = new UserRepo();
                if (employeeRepo.SaveEmployeeInfo(this.employee, "change password") == true)
                {
                    MessageBox.Show("Password Updated Successfully");
                    this.txtNewPassword.Clear();
                    this.txtConfirmPassword.Clear();
                    this.txtCurrentPassword.Clear();

                }
                else
                {
                    MessageBox.Show("Something happened bad,please try again");
                    this.txtNewPassword.Clear();
                    this.txtConfirmPassword.Clear();
                    this.txtCurrentPassword.Clear();
                }
            }
        }

        private void BtnExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void BtnSignOut_Click(object sender, EventArgs e)
        {
            SignInPage signInPage = new SignInPage();
            signInPage.Visible = true;
            this.Visible = false;
        }

        private void BtnUserProfile_Click(object sender, EventArgs e)
        {
            ChangePasswordTicketSeller changePasswordTicketSeller = new ChangePasswordTicketSeller(this.employee);
            changePasswordTicketSeller.Visible = true;
            this.Visible = false;
        }

        private void BtnDashboard_Click(object sender, EventArgs e)
        {
            TicketSellerDashboardPage ticketSellerDashboardPage = new TicketSellerDashboardPage(this.employee);
            ticketSellerDashboardPage.Visible = true;
            this.Visible = false;
        }

        private void BtnSellTicket_Click(object sender, EventArgs e)
        {
            SellTicket sellTicket = new SellTicket(this.employee);
            sellTicket.Visible = true;
            this.Visible = false;
        }

        private void BtnSellHistory_Click(object sender, EventArgs e)
        {
            SellHistoryTicketSeller sellHistoryTicketSeller = new SellHistoryTicketSeller(this.employee);
            sellHistoryTicketSeller.Visible = true;
            this.Visible = false;
        }

        private void BtnTrainInfo_Click(object sender, EventArgs e)
        {
            TrainInfoTicketSeller trainInfoTicketSeller = new TrainInfoTicketSeller(this.employee);
            trainInfoTicketSeller.Visible = true;
            this.Visible = false;
        }

        private void BtnUserProfile_Click_1(object sender, EventArgs e)
        {
            ChangePasswordTicketSeller changePassword = new ChangePasswordTicketSeller(this.employee);
            changePassword.Visible = true;
            this.Visible = false;
        }

        private void BtnSignOut_Click_1(object sender, EventArgs e)
        {
            SignInPage signInPage = new SignInPage();
            signInPage.Visible = true;
            this.Visible = false;
        }

        private void BtnExit_Click_1(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
