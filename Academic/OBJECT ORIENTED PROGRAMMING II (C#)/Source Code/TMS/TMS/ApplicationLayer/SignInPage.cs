using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using TMS.Data;
using TMS.Entity;
using TMS.Framework;
using TMS.Repository;

namespace TMS.ApplicationLayer
{
    public partial class SignInPage : Form
    {
        private UserEntity userinfo;
        private List<UserEntity> userList;
        private UserRepo userRepo;
        public SignInPage(Form frm)
        {
            InitializeComponent();
            int counter = 0;
            while (counter < 30)
            {
                Thread.Sleep(100);
                Application.DoEvents();
                counter++;

            }

            frm.Close();
            userRepo = new UserRepo();
            this.userList=this.userRepo.GetAll();
        }
        public SignInPage()
        {
            InitializeComponent();
            userRepo = new UserRepo();
            this.userList = this.userRepo.GetAll();
        }

        

        private void BtnSignIn_Click(object sender, EventArgs e)
        {
            this.userinfo = Validation.SignInAuthentication(this.userList, this.txtEmail.Text.ToString(), this.txtPassword.Text.ToString());
            if (this.userinfo != null)
            {
                if(userinfo.UserType.Equals("Passenger"))
                {
                    PassengerDashboardPage dashboardPage = new PassengerDashboardPage(this.userinfo);
                    dashboardPage.Visible = true;
                    this.Visible = false;
                }
                else if (userinfo.UserType.Equals("Manager"))
                {
                    ManagerDashboardPage dashboardPage = new ManagerDashboardPage(this.userinfo);
                    dashboardPage.Visible = true;
                    this.Visible = false;
                }
                else
                {
                    TicketSellerDashboardPage dashboardPage = new TicketSellerDashboardPage(this.userinfo);
                    dashboardPage.Visible = true;
                    this.Visible = false;
                }

            }
            else
            {
                MessageBox.Show("Invalid Email Address or Password !");

            }

        }


        private void TxtUserID_Leave(object sender, EventArgs e)
        {
            if(Validation.IsStringValid(txtEmail.Text.ToString())==false)
            {
                txtEmail.Focus();
                errEmail.SetError(this.txtEmail, "Please fill the email address");
            }
            else
            {
                
                if(Validation.EmailAuthentication(txtEmail.Text.ToString())==false)
                {
                    txtEmail.Focus();
                    errEmail.SetError(this.txtEmail, "Invalid Email");
                }
                else
                {
                    errEmail.Clear();
                }
            }
        }

        private void TxtPassword_Leave(object sender, EventArgs e)
        {
            if (Validation.IsStringValid(txtPassword.Text.ToString()) == false)
            {
                this.txtPassword.Focus();
                errPassword.SetError(this.txtPassword, "Please enter password");
            }
            else
            {
                errPassword.Clear();
            }
        }

        

        private void BtnSignUp_Click(object sender, EventArgs e)
        {
            btnSignUp.Focus();
            errEmail.Clear();
            errPassword.Clear();
            SignUpPage signUpPage = new SignUpPage(this.userList);
            signUpPage.Visible=true;
            this.Visible=false;
          
        }

        

        private void SignInPage_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }
    }
}
