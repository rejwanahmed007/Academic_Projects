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
    public partial class ManagerDashboardPage : Form
    {
        private UserEntity userinfo;
        private UserRepo userRepo;
        private Employee employee;
        internal ManagerDashboardPage(UserEntity userinfo)
        {
            InitializeComponent();
            this.userinfo = userinfo;
            this.GetUpdateData();
        }
        private void GetUpdateData()
        {

            userRepo = new UserRepo();
            this.employee = this.userRepo.GetEmployeeInfo(this.userinfo.Email, this.userinfo.Password);
            this.userinfo = employee;
            this.txtName.Text = this.employee.Name.ToString();
            this.txtEmail.Text = this.employee.Email.ToString();
            this.txtDesignation.Text = this.employee.Designation.ToString();
            this.txtSalary.Text=this.employee.Salary.ToString()+" BDT";
            this.txtMobileNumber.Text = this.employee.Mobile.ToString();
            this.txtAddress.Text = this.employee.Address.ToString();
            if(this.employee.Commission.ToString().Equals(null))
            {
                this.txtCommission.Text = "Not Applicable";
            }
            else
            {
                this.txtCommission.Text = this.employee.Commission.ToString() + " % on Each Sell";
            }
            
            this.txtHireDate.Text = this.employee.HireDate.ToString();
        }

        private void ManagerDashboardPage_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

        private void BtnExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void BtnUserProfile_Click(object sender, EventArgs e)
        {
            ChangePasswordManager changePasswordManager = new ChangePasswordManager(this.employee);
            changePasswordManager.Visible = true;
            this.Visible = false;
        }

        private void BtnUpdateProfile_Click(object sender, EventArgs e)
        {
            this.txtMobileNumber.Enabled = true;
            this.txtAddress.Enabled = true;
            this.btnUpdateProfile.Visible = false;
            this.btnCancel.Visible = true;
            this.btnSave.Visible = true;
        }

        private void BtnCancel_Click(object sender, EventArgs e)
        {
            ManagerDashboardPage managerDashboardPage = new ManagerDashboardPage(this.userinfo);
            managerDashboardPage.Visible = true;
            this.Visible = false;
        }

        private void BtnSave_Click(object sender, EventArgs e)
        {
            
            
            if (!this.txtMobileNumber.Text.ToString().Length.Equals(11) || Validation.MobileNumberValidation(this.txtMobileNumber.Text.ToString()) == false)
            {
                MessageBox.Show("Please fill the above information");
                this.txtMobileNumber.Focus();
            }
            else
            {
                this.employee.Mobile = this.txtMobileNumber.Text.ToString();
                this.employee.Address = this.txtAddress.Text.ToString();
                if (this.userRepo.SaveEmployeeInfo(employee, "update") == true)
                {
                    MessageBox.Show("Information Updated Successfully");
                    this.btnCancel.Visible = false;
                    this.btnSave.Visible = false;
                    this.btnUpdateProfile.Visible = true;
                    this.txtMobileNumber.Enabled = false;
                    this.txtAddress.Enabled = false;
                    this.userinfo = employee;
                }
                else { MessageBox.Show("Something Happened bad ,please try again"); }
            }
        }

        private void TxtMobileNumber_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && e.KeyChar != 8)
            {
                e.Handled = true;
                this.errMobile.SetError(this.txtMobileNumber, "Please provide valid mobile number");
            }
            else
                errMobile.Clear();
        }

        private void TxtMobileNumber_Leave(object sender, EventArgs e)
        {
            if (Validation.IsStringValid(this.txtMobileNumber.Text.ToString()) == false)
            {
                this.txtMobileNumber.Focus();
                this.errMobile.SetError(this.txtMobileNumber, "Please provide valid Mobile Number");
            }
            else
            {
                errMobile.Clear();
            }
            if (Validation.MobileNumberValidation(this.txtMobileNumber.Text.ToString()) == false)
            {
                this.txtMobileNumber.Focus();
                this.errMobile.SetError(this.txtMobileNumber, "Please provide valid Mobile Number");

            }
            else
            {
                errMobile.Clear();
            }
        }

        private void BtnDashboard_Click(object sender, EventArgs e)
        {
            ManagerDashboardPage managerDashboardPage = new ManagerDashboardPage(this.employee);
            managerDashboardPage.Visible = true;
            this.Visible = false;
        }

        private void BtnSignOut_Click(object sender, EventArgs e)
        {
            SignInPage signInPage = new SignInPage();
            signInPage.Visible = true;
            this.Visible = false;
        }

        private void BtnEmployeeInfo_Click(object sender, EventArgs e)
        {
            EmployeeInfo employeeInfo = new EmployeeInfo(this.employee);
            employeeInfo.Visible = true;
            this.Visible = false;
        }

        private void BtnSellHistory_Click(object sender, EventArgs e)
        {
            SellAndFinanceHistory sellAndFinanceHistory = new SellAndFinanceHistory(this.employee);
            sellAndFinanceHistory.Visible = true;
            this.Visible = false;

        }

        private void ManagerDashboardPage_Load(object sender, EventArgs e)
        {

        }

        private void BtnFareInfo_Click(object sender, EventArgs e)
        {
            FareInfo fareInfo = new FareInfo(this.employee);
            fareInfo.Visible = true ;
            this.Visible = false;
        }

        private void BtnPassengersFeedback_Click(object sender, EventArgs e)
        {
            PassengersFeedback passengersFeedback = new PassengersFeedback(this.employee);
            passengersFeedback.Visible = true;
            this.Visible = false;
        }

        private void BtnTrainInfo_Click(object sender, EventArgs e)
        {
            TrainAndRoute trainAndRoute = new TrainAndRoute(this.employee);
            trainAndRoute.Visible = true;
            this.Visible = false;
        }
    }
}
