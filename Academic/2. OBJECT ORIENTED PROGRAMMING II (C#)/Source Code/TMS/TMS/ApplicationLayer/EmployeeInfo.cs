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
    public partial class EmployeeInfo : Form
    {
        private Employee employee;
        private UserRepo userRepo;
        private List<UserEntity> userList;
        private bool isEdited;
        internal EmployeeInfo(Employee employee)
        {
            InitializeComponent();
            this.employee = employee;
            this.userRepo = new UserRepo();
            this.userList = this.userRepo.GetAll();
            this.isEdited = false;
            this.PopulateGridView("select employeeid,password,usertype,employeename,mobilenumber,logininfo.email,address,designation,salary,hiredate,commission from logininfo,employeeinfo where logininfo.email=employeeinfo.email;");

        }
        private void PopulateGridView(string query)
        {
            try
            {
                this.dgvEmployeeInfo.AutoGenerateColumns = false;
                var dt = DataAccess.GetDataTable(query);
                this.dgvEmployeeInfo.DataSource = dt;
            }
            catch (Exception exception) { }
        }


        private void EmployeeInfo_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

        private void TxtSearch_TextChanged(object sender, EventArgs e)
        {
            string name = this.txtSearch.Text.ToString();
            this.PopulateGridView("select employeeid,password,usertype,employeename,mobilenumber,logininfo.email,address,designation,salary,hiredate,commission from logininfo,employeeinfo where logininfo.email=employeeinfo.email and (employeeinfo.email like '" + name + "%' or employeeinfo.email like '%" + name + "' or employeeinfo.email like '%" + name + "%' or employeeinfo.employeeid like '" + name + "%' or employeeinfo.employeeid like '%" + name + "' or employeeinfo.employeeid like '%" + name + "%'  or employeeinfo.employeename like '" + name + "%' or employeeinfo.employeename like '%" + name + "' or employeeinfo.employeename like '%" + name + "%' )");
        }

        private void DgvEmployeeInfo_CellContentDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                EditInfo();
            }
        }
        private void EditInfo()
        {
            this.isEdited = true;
            this.txtSearch.Visible = false;
            this.dgvEmployeeInfo.Visible = false;
            this.txtName.Text = this.dgvEmployeeInfo.CurrentRow.Cells["employeename"].Value.ToString();
            this.txtEmail.Text = this.dgvEmployeeInfo.CurrentRow.Cells["email"].Value.ToString();
            //this.cmbDesignation.Text= this.dgvEmployeeInfo.Rows[0].Cells["designation"].Value.ToString();
            this.txtSalary.Text = this.dgvEmployeeInfo.CurrentRow.Cells["salary"].Value.ToString();
            this.txtMobile.Text = this.dgvEmployeeInfo.CurrentRow.Cells["mobilenumber"].Value.ToString();
            this.txtAddress.Text = this.dgvEmployeeInfo.CurrentRow.Cells["address"].Value.ToString();
            this.txtPassword.Text = this.dgvEmployeeInfo.CurrentRow.Cells["password"].Value.ToString();
            this.txtCommission.Text = this.dgvEmployeeInfo.CurrentRow.Cells["commission"].Value.ToString();
            this.txtEmail.Enabled = false;
        }

        private void CmsContactList_Click(object sender, EventArgs e)
        {
            EditInfo();
        }

        private void RefreshToolStripMenuItem_Click(object sender, EventArgs e)
        {
            RefreshMethod();
        }
        private void RefreshMethod()
        {
            EmployeeInfo employeeInfo = new EmployeeInfo(this.employee);
            employeeInfo.Visible = true;
            this.Visible = false;
        }

        private void BtnRefresh_Click(object sender, EventArgs e)
        {
            this.RefreshMethod();
        }

        private void TxtName_Leave(object sender, EventArgs e)
        {
            if (Validation.IsStringValid(this.txtName.Text.ToString()) == false)
            {
                txtName.Focus();
                this.errName.SetError(this.txtName, "Please provide your name");
            }
            else
            {
                errName.Clear();
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
                        this.txtEmail.Focus();
                        this.errEmail.SetError(this.txtEmail, "Invalid Email");
                        MessageBox.Show("This email is already used ! Try Different");
                    }
                    else
                    {
                        this.errEmail.Clear();
                    }
                }
            }
        }

        private void CmbDesignation_Leave(object sender, EventArgs e)
        {
            if (this.cmbDesignation.Text.ToString().Length.Equals(0))
            {
                this.cmbDesignation.Focus();
                this.errDesignation.SetError(this.cmbDesignation, "Please select any designation");
            }
            else
            {
                this.errDesignation.Clear();
                
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

        private void TxtSalary_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && e.KeyChar != 8)
            {
                e.Handled = true;
                this.errSalary.SetError(this.txtSalary, "Please provide valid salary input");
            }
            else
                errSalary.Clear();
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

        private void BtnPassword_Click(object sender, EventArgs e)
        {
            this.txtPassword.Text = this.txtEmail.Text.ToString();
        }

        private void BtnSave_Click(object sender, EventArgs e)
        {
            try
            {
                if (this.isEdited == false)
                {
                    if (Validation.EmailCrossCheckingWithDatabase(this.userList, this.txtEmail.Text.ToString()) == false || Validation.MobileNumberValidation(this.txtMobile.Text.ToString()) == false || !this.txtMobile.Text.ToString().Length.Equals(11) || this.txtCommission.Text.ToString().Length.Equals(0) || this.txtPassword.Text.ToString().Length.Equals(0) || this.txtName.Text.ToString().Length.Equals(0) || Validation.IsStringValid(this.txtSalary.Text.ToString()) == false || Validation.IsStringValid(this.txtName.Text.ToString()) == false || Validation.IsStringValid(this.txtPassword.Text.ToString()) == false || this.txtEmail.Text.ToString().Length.Equals(0) || Validation.EmailAuthentication(this.txtEmail.Text.ToString()) == false || this.cmbDesignation.Text.ToString().Length.Equals(0) || this.txtSalary.Text.ToString().Length.Equals(0))
                    {
                        MessageBox.Show("Please fill the above information correctly");
                        this.txtName.Focus();
                    }
                    else
                    {
                        string query1 = "insert into employeeinfo values ('" + this.txtName.Text.ToString() + "','" + this.txtMobile.Text.ToString() + "','" + this.txtEmail.Text.ToString() + "','" + this.txtAddress.Text.ToString() + "','" + this.cmbDesignation.SelectedItem.ToString() + "'," + this.txtSalary.Text.ToString() + ",SYSDATETIME()," + this.txtCommission.Text.ToString() + ");";
                        string query2 = "insert into logininfo values ('" + this.txtEmail.Text.ToString() + "','" + this.txtPassword.Text.ToString() + "','" + this.cmbDesignation.SelectedItem.ToString() + "');";
                        int count1 = DataAccess.ExecuteQuery(query1);
                        int count2 = DataAccess.ExecuteQuery(query2);
                        if (count1 > 0 && count2 > 0)
                        {
                            MessageBox.Show("Account Created Successfully");
                            this.RefreshMethod();
                        }
                        else { MessageBox.Show("Something Happened Bad,pls try again"); }
                    }
                }
                else
                {
                    if (this.txtCommission.Text.ToString().Length.Equals(0) || Validation.MobileNumberValidation(this.txtMobile.Text.ToString()) == false || !this.txtMobile.Text.ToString().Length.Equals(11) || this.txtPassword.Text.ToString().Length.Equals(0) || this.txtName.Text.ToString().Length.Equals(0) || Validation.IsStringValid(this.txtSalary.Text.ToString()) == false || Validation.IsStringValid(this.txtName.Text.ToString()) == false || Validation.IsStringValid(this.txtPassword.Text.ToString()) == false  || this.cmbDesignation.Text.ToString().Length.Equals(0) || this.txtSalary.Text.ToString().Length.Equals(0))
                    {
                        MessageBox.Show("Please fill the above information correctly");
                        this.txtName.Focus();
                    }
                    else
                    {
                        string query1 = "update employeeinfo set employeename = '" + this.txtName.Text.ToString() + "', mobilenumber = '" + this.txtMobile.Text.ToString() + "', address = '" + this.txtAddress.Text.ToString() + "',designation='" + this.cmbDesignation.SelectedItem.ToString() + "',salary=" + this.txtSalary.Text.ToString() + ",commission=" + this.txtCommission.Text.ToString() + " where employeeinfo.email ='" + this.dgvEmployeeInfo.CurrentRow.Cells["email"].Value.ToString() + "' and employeeid = " + this.dgvEmployeeInfo.CurrentRow.Cells["employeeid"].Value.ToString();
                        string query2 = "update logininfo set password='" + this.txtPassword.Text.ToString() + "',usertype='" + this.cmbDesignation.SelectedItem.ToString() + "' where logininfo.email ='" + this.dgvEmployeeInfo.CurrentRow.Cells["email"].Value.ToString() + "' ";
                        int count1 = DataAccess.ExecuteQuery(query1);
                        int count2 = DataAccess.ExecuteQuery(query2);
                        if (count1 > 0 && count2 > 0)
                        {
                            MessageBox.Show("Account Updated Successfully");
                            this.RefreshMethod();
                        }
                        else { MessageBox.Show("Something Happened Bad,pls try again"); }
                    }
                }
            }
            catch (Exception exception)
            {
                MessageBox.Show("Something Happened Bad,pls try again");
            }

            
        }

            private void BtnEmployeeInfo_Click(object sender, EventArgs e)
        {
            this.RefreshMethod();
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

        private void TxtCommission_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && e.KeyChar != 8 && e.KeyChar !=46)
            {
                e.Handled = true;
                this.errCommission.SetError(this.txtCommission, "Please provide valid input for commission");
            }
            else
                errCommission.Clear();
        }

        private void BtnSellTicket_Click(object sender, EventArgs e)
        {

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

        private void BtnEmployeeInfo_Click_1(object sender, EventArgs e)
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
