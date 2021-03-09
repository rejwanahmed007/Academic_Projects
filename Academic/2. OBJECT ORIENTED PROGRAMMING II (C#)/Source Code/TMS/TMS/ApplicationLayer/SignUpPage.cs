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
    public partial class SignUpPage : Form
    {
        private List<UserEntity> userList;
        internal SignUpPage(List<UserEntity> userList)
        {
            this.userList = userList;
            InitializeComponent();
        }

        private void BtnBack_Click(object sender, EventArgs e)
        {
            this.Visible = false;
            SignInPage signInPage = new SignInPage();
            signInPage.Visible = true;
            
        }

        private void SignUpPage_Load(object sender, EventArgs e)
        {

        }

        private void SignUpPage_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

        private void BtnRefresh_Click(object sender, EventArgs e)
        {

            SignUpPage signUpPage = new SignUpPage(this.userList);
            signUpPage.Visible = true;
            this.Visible = false;
        }

        private void TxtName_Leave(object sender, EventArgs e)
        {
            if (Validation.IsStringValid(txtName.Text.ToString()) == false)
            {
                txtName.Focus();
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
            if(Validation.MobileNumberValidation(this.txtMobile.Text.ToString())==false)
            {
                this.txtMobile.Focus();
                this.errMobile.SetError(this.txtMobile, "Please provide valid Mobile Number");

            }
            else
            {
                errMobile.Clear();
            }
        }

        private void TxtEmail_Leave(object sender, EventArgs e)
        {
            if (Validation.IsStringValid(this.txtEmail.Text.ToString()) == false)
            {
                this.txtEmail.Focus();
                this.errEmail.SetError(this.txtEmail, "Please fill the email address");
            }
            else
            {

                if (Validation.EmailAuthentication(txtEmail.Text.ToString()) == false)
                {
                    this.txtEmail.Focus();
                    this.errEmail.SetError(this.txtEmail, "Invalid Email");
                }
                else
                {
                    if (Validation.EmailCrossCheckingWithDatabase(this.userList, this.txtEmail.Text.ToString()) == false)
                    {
                        MessageBox.Show("This email is already used ! Try Different");
                    }
                    else
                    {
                        this.errEmail.Clear();
                    }
                }
            }
        }

        private void TxtPassword_Leave(object sender, EventArgs e)
        {
            if (Validation.IsStringValid(this.txtPassword.Text.ToString()) == false)
            {
                this.txtPassword.Focus();
                this.errPassword.SetError(this.txtPassword, "Please enter password");
            }
            else
            {
                this.errPassword.Clear();
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
                if(this.txtPassword.Text.ToString().Equals(this.txtConfirmPassword.Text.ToString()))
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

            int userID = 0;
            string password = this.txtPassword.Text.ToString();
            string name = this.txtName.Text.ToString();
            string mobile = this.txtMobile.Text.ToString();
            string email = this.txtEmail.Text.ToString();
            string address = this.txtAddress.Text.ToString();
            string userType = "Passenger";

            if(Validation.EmailCrossCheckingWithDatabase(this.userList, this.txtEmail.Text.ToString()) == false || Validation.MobileNumberValidation(mobile)==false || password.Length.Equals(0) || name.Length.Equals(0) || Validation.IsStringValid(name)==false || Validation.IsStringValid(password) == false || Validation.IsStringValid(this.txtConfirmPassword.Text.ToString()) == false || !mobile.Length.Equals(11) || email.Length.Equals(0) || Validation.EmailAuthentication(email)==false || this.txtConfirmPassword.Text.ToString().Length.Equals(0) || !this.txtConfirmPassword.Text.ToString().Equals(this.txtPassword.Text.ToString()))
            {
                MessageBox.Show("Please fill the above information");
                this.txtName.Focus();
            }
            else
            {
                UserEntity passenger = new UserEntity(userID, password, name, mobile, email, address, userType);
                UserRepo userRepo = new UserRepo();
                if (userRepo.SavePassengerInfo(passenger,"new") == true)
                {
                    MessageBox.Show("Account Created Successfully");
                    SignInPage signInPage = new SignInPage();
                    signInPage.Visible = true;
                    this.Visible = false;

                }
                else { MessageBox.Show("Something Happened bad ,please try again"); }
            }
        }

        
    }
}
