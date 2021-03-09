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
    public partial class PassengerDashboardPage : Form
    {
        
        private UserEntity userinfo;
        private List<UserEntity> userList;
        private UserRepo userRepo;
        internal PassengerDashboardPage(UserEntity userinfo)
        {
            InitializeComponent();
            this.userinfo = userinfo;
            this.GetUpdateData();

        }
        private void GetUpdateData()
        {
            
            userRepo = new UserRepo();
            this.userList = this.userRepo.GetAll();
            this.userinfo = Validation.SignInAuthentication(this.userList, this.userinfo.Email, this.userinfo.Password);

            this.txtName.Text = this.userinfo.Name;
            this.txtMobile.Text = this.userinfo.Mobile;
            this.txtAddress.Text = this.userinfo.Address;
        }
        

        private void PnlName_Paint(object sender, PaintEventArgs e)
        {
            this.lblNameText.Text = this.userinfo.Name;
        }

        private void PnlMobile_Paint(object sender, PaintEventArgs e)
        {
            this.lblMobileText.Text = this.userinfo.Mobile;
        }

        private void PnlEmail_Paint(object sender, PaintEventArgs e)
        {
            this.lblEmailText.Text = this.userinfo.Email;
        }

        private void PnlAddress_Paint(object sender, PaintEventArgs e)
        {
            this.lblAddressText.Text = this.userinfo.Address;
        }

        private void TxtName_Leave(object sender, EventArgs e)
        {
            if (Validation.IsStringValid(this.txtName.Text.ToString()) == false)
            {
                this.txtName.Focus();
                this.errName.SetError(this.txtName, "Please provide your name");
            }
            else
            {
                errName.Clear();
            }
        }

        private void TxtMobile_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && e.KeyChar != 8)
            {
                e.Handled = true;
                this.errMobile.SetError(this.txtMobile, "Please provide valid mobile number");
            }
            else
                errMobile.Clear();
        }

        private void TxtMobile_Leave(object sender, EventArgs e)
        {
            if (Validation.IsStringValid(this.txtMobile.Text.ToString()) == false)
            {
                this.txtMobile.Focus();
                this.errMobile.SetError(this.txtMobile, "Please provide valid Mobile Number");
            }
            else
            {
                errMobile.Clear();
            }
            if (Validation.MobileNumberValidation(this.txtMobile.Text.ToString()) == false)
            {
                this.txtMobile.Focus();
                this.errMobile.SetError(this.txtMobile, "Please provide valid Mobile Number");

            }
            else
            {
                errMobile.Clear();
            }
        }

        private void BtnRefresh_Click(object sender, EventArgs e)
        {
            PassengerDashboardPage passengerDashboardPage = new PassengerDashboardPage(this.userinfo);
            passengerDashboardPage.Visible = true;
            this.Visible = false;
        }

        private void BtnSave_Click(object sender, EventArgs e)
        {
            this.userinfo.Name = this.txtName.Text.ToString();
            this.userinfo.Mobile = this.txtMobile.Text.ToString();
            this.userinfo.Address = this.txtAddress.Text.ToString();

            if (Validation.IsStringValid(this.txtName.Text.ToString())==false || Validation.MobileNumberValidation(this.txtMobile.Text.ToString())==false || this.userinfo.Name.Length.Equals(0) || !this.userinfo.Mobile.Length.Equals(11))
            {
                MessageBox.Show("Please fill the above information");
                this.txtName.Focus();
            }
            else
            {
                UserEntity passenger = new UserEntity(this.userinfo.UserID, this.userinfo.Password, this.userinfo.Name, this.userinfo.Mobile, userinfo.Email, this.userinfo.Address, this.userinfo.UserType);
                UserRepo userRepo = new UserRepo();
                if (userRepo.SavePassengerInfo(passenger, "update") == true)
                {
                    MessageBox.Show("Information Updated Successfully");
                    this.lblNameText.Text = this.userinfo.Name;
                    this.lblMobileText.Text = this.userinfo.Mobile;
                    this.lblAddressText.Text = this.userinfo.Address;
                    this.lblName.Focus();
                    this.txtName.Clear();
                    this.txtMobile.Clear();
                    this.txtAddress.Clear();
                    this.txtName.Text = this.lblNameText.Text;
                    this.txtMobile.Text = this.lblMobileText.Text;
                    this.txtAddress.Text = this.lblAddressText.Text;

                }
                else { MessageBox.Show("Something Happened bad ,please try again"); }
            }
        }

        private void PassengerDashboardPage_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

        private void BtnDashboard_Click(object sender, EventArgs e)
        {
            PassengerDashboardPage dashboardPage = new PassengerDashboardPage(this.userinfo);
            dashboardPage.Visible = true;
            this.Visible = false;
        }

        private void BtnUserProfile_Click(object sender, EventArgs e)
        {
            ChangePassword changePassword = new ChangePassword(this.userinfo);
            changePassword.Visible = true;
            this.Visible = false;
        }

        private void BtnSignOut_Click(object sender, EventArgs e)
        {
            SignInPage signInPage = new SignInPage();
            signInPage.Visible = true;
            this.Visible = false;
        }

        private void BtnExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
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

        private void BtnFareQuery_Click(object sender, EventArgs e)
        {
            FareQuery fareQuery = new FareQuery(this.userinfo);
            fareQuery.Visible = true;
            this.Visible = false;

        }

        
    }
}
