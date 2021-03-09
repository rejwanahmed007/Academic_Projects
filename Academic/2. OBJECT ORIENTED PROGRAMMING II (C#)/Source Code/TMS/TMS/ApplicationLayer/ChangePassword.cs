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
    public partial class ChangePassword : Form
    {
        private UserEntity userinfo;
        internal ChangePassword(UserEntity userinfo)
        {
            InitializeComponent();
            this.userinfo = userinfo;
        }

        private void ChangePassword_FormClosed(object sender, FormClosedEventArgs e)
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
                if(this.userinfo.Password.Equals(this.txtCurrentPassword.Text.ToString()))
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
                this.errorProvider1.SetError(this.txtNewPassword, "Please enter password");
            }
            else
            {
                if(this.txtCurrentPassword.Text.ToString().Equals(this.txtNewPassword.Text.ToString()))
                {
                    MessageBox.Show("You have entered an old password,please try a new one !");
                    this.txtNewPassword.Focus();
                    this.errorProvider1.SetError(this.txtNewPassword, "You have entered an old password,please try a new one !");
                }
                else
                this.errorProvider1.Clear();
            }
        }

        private void TxtAddress_Leave(object sender, EventArgs e)
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
            if(!this.txtNewPassword.Text.ToString().Equals(this.txtConfirmPassword.Text.ToString()) || this.txtNewPassword.Text.ToString().Length.Equals(0) || this.txtConfirmPassword.Text.ToString().Length.Equals(0) || this.txtCurrentPassword.Text.ToString().Length.Equals(0) || this.txtCurrentPassword.Text.ToString().Equals(this.txtNewPassword.Text.ToString()) || !this.userinfo.Password.Equals(this.txtCurrentPassword.Text.ToString()) || Validation.IsStringValid(this.txtCurrentPassword.Text.ToString())==false || Validation.IsStringValid(this.txtNewPassword.Text.ToString()) == false || Validation.IsStringValid(this.txtConfirmPassword.Text.ToString()) == false)
            {
                MessageBox.Show("Invalid Info");
                txtCurrentPassword.Focus();
            }
            else
            {
                this.userinfo.Password = this.txtNewPassword.Text.ToString();
                UserRepo passenger = new UserRepo();
                if(passenger.SavePassengerInfo(this.userinfo,"change password") ==true)
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
            ChangePassword changePassword = new ChangePassword(this.userinfo);
            changePassword.Visible = true;
            this.Visible = false;
        }

        private void BtnDashboard_Click(object sender, EventArgs e)
        {
            PassengerDashboardPage dashboardPage = new PassengerDashboardPage(this.userinfo);
            dashboardPage.Visible = true;
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
            ChangePassword changePassword = new ChangePassword(this.userinfo);
            changePassword.Visible = true;
            this.Visible = false;
        }

        private void BtnFareQuery_Click(object sender, EventArgs e)
        {
            FareQuery fareQuery = new FareQuery(this.userinfo);
            fareQuery.Visible = true;
            this.Visible = false;
        }

        private void BtnTrainRoute_Click(object sender, EventArgs e)
        {
            TrainRoute trainRoute = new TrainRoute(this.userinfo);
            trainRoute.Visible = true;
            this.Visible = false;
        }

        private void BtnPurchaseHistory_Click(object sender, EventArgs e)
        {
            PurchaseHistory purchaseHistory = new PurchaseHistory(this.userinfo);
            purchaseHistory.Visible = true;
            this.Visible = false;
        }
    }
}
