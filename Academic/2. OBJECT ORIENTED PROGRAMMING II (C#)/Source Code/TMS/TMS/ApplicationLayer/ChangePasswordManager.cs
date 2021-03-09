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
    public partial class ChangePasswordManager : Form
    {
        private Employee employee;
        internal ChangePasswordManager(Employee employee)
        {
            InitializeComponent();
            this.employee = employee;
        }

        private void ChangePasswordManager_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
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

        private void BtnRefresh_Click(object sender, EventArgs e)
        {
            ChangePasswordManager changePasswordManager = new ChangePasswordManager(employee);
            changePasswordManager.Visible = true;
            this.Visible = false;
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
            ChangePasswordManager changePasswordManager = new ChangePasswordManager(this.employee);
            changePasswordManager.Visible = true;
            this.Visible = false;
        }

        private void BtnDashboard_Click(object sender, EventArgs e)
        {
            ManagerDashboardPage managerDashboardPage = new ManagerDashboardPage(this.employee);
            managerDashboardPage.Visible = true;
            this.Visible = false;
        }

        private void BtnDashboard_Click_1(object sender, EventArgs e)
        {
            ManagerDashboardPage managerDashboardPage = new ManagerDashboardPage(this.employee);
            managerDashboardPage.Visible = true;
            this.Visible = false;
        }

        private void BtnPassengersFeedback_Click(object sender, EventArgs e)
        {
            PassengersFeedback passengersFeedback = new PassengersFeedback(this.employee);
            passengersFeedback.Visible = true;
            this.Visible = false;
        }

        private void BtnSellHistory_Click(object sender, EventArgs e)
        {
            SellAndFinanceHistory sellAndFinanceHistory = new SellAndFinanceHistory(this.employee);
            sellAndFinanceHistory.Visible = true;
            this.Visible = false;
        }

        private void BtnTrainInfo_Click(object sender, EventArgs e)
        {
            TrainAndRoute trainAndRoute = new TrainAndRoute(this.employee);
            trainAndRoute.Visible = true;
            this.Visible = false;
        }

        private void BtnFareInfo_Click(object sender, EventArgs e)
        {
            FareInfo fareInfo = new FareInfo(this.employee);
            fareInfo.Visible = true;
            this.Visible = false;
        }

        private void BtnEmployeeInfo_Click(object sender, EventArgs e)
        {
            EmployeeInfo employeeInfo = new EmployeeInfo(this.employee);
            employeeInfo.Visible = true;
            this.Visible = false;
        }

        private void BtnUserProfile_Click_1(object sender, EventArgs e)
        {
            ChangePasswordManager changePasswordManager = new ChangePasswordManager(this.employee);
            changePasswordManager.Visible = true;
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
