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
    public partial class TrainAndRoute : Form
    {
        private Employee employee;
        private bool IsViewed{set;get;}
        internal TrainAndRoute(Employee employee)
        {
            InitializeComponent();
            this.employee = employee;
            this.PopulateGridViewTrainList("select * from traininfo;");
            this.IsViewed = false;
        }
        private void PopulateGridViewTrainList(string query)
        {
            try
            {
                this.dgvTrainList.AutoGenerateColumns = false;
                var dt = DataAccess.GetDataTable(query);
                this.dgvTrainList.DataSource = dt;
            }
            catch (Exception exception) { }

        }
        private void TrainInfo_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

        private void RefreshToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.RefreshMethod();
        }
        private void RefreshMethod()
        {
            TrainAndRoute trainAndRoute = new TrainAndRoute(this.employee);
            trainAndRoute.Visible = true;
            this.Visible = false;
        }

        private void TxtSearch_TextChanged(object sender, EventArgs e)
        {
            string name = this.txtSearch.Text.ToString();
            string query1 = "select * from traininfo where traininfo.trainid like '" + name + "%' or traininfo.trainid like '%" + name + "' or traininfo.trainid like '%" + name + "%' or  traininfo.trainid like '" + name + "%' or traininfo.trainid like '%" + name + "' or traininfo.trainid like '%" + name + "%'or  traininfo.name like '" + name + "%' or traininfo.name like '%" + name + "' or traininfo.name like'%" + name + "%';";
            this.PopulateGridViewTrainList(query1);
        }

        private void BtnRefresh_Click(object sender, EventArgs e)
        {
            this.RefreshMethod();
        }

        
       

        private void ToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            this.RefreshMethod();
        }

        private void RefreshToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            this.RefreshMethod();
        }

        private void TxtCapacity_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && e.KeyChar != 8)
            {
                e.Handled = true;
                this.errDigit.SetError(this.txtCapacity, "Please provide only digit");
            }
            else
                errDigit.Clear();
        }

        private void TxtBogey_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && e.KeyChar != 8)
            {
                e.Handled = true;
                this.errDigit.SetError(this.txtBogey, "Please provide only digit");
            }
            else
                errDigit.Clear();
        }

        private void TxtFirstClass_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && e.KeyChar != 8)
            {
                e.Handled = true;
                this.errDigit.SetError(this.txtFirstClass, "Please provide only digit");
            }
            else
                errDigit.Clear();
        }

        private void TxtPriceFirstClass_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && e.KeyChar != 8)
            {
                e.Handled = true;
                this.errDigit.SetError(this.txtPriceFirstClass, "Please provide only digit");
            }
            else
                errDigit.Clear();
        }

        private void TxtStandard_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && e.KeyChar != 8)
            {
                e.Handled = true;
                this.errDigit.SetError(this.txtStandard, "Please provide only digit");
            }
            else
                errDigit.Clear();
        }

        private void TxtPriceStandard_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && e.KeyChar != 8)
            {
                e.Handled = true;
                this.errDigit.SetError(this.txtPriceStandard, "Please provide only digit");
            }
            else
                errDigit.Clear();
        }

        private void TxtEconomy_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && e.KeyChar != 8)
            {
                e.Handled = true;
                this.errDigit.SetError(this.txtEconomy, "Please provide only digit");
            }
            else
                errDigit.Clear();
        }

        private void TxtPricerEconomy_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && e.KeyChar != 8)
            {
                e.Handled = true;
                this.errDigit.SetError(this.txtPriceStandard, "Please provide only digit");
            }
            else
                errDigit.Clear();
        }

        private void BtnSave_Click(object sender, EventArgs e)
        {
            try
            {

                if (this.txtBogeyInfo.Text.ToString().Length.Equals(0) || Validation.IsStringValid(this.txtBogeyInfo.Text.ToString()) == false || this.txtPricerEconomy.Text.ToString().Length.Equals(0) || this.txtEconomy.Text.ToString().Length.Equals(0) || this.txtPriceStandard.Text.ToString().Length.Equals(0) || this.txtStandard.Text.ToString().Length.Equals(0) || this.txtPriceFirstClass.Text.ToString().Length.Equals(0) || this.txtFirstClass.Text.ToString().Length.Equals(0) || this.txtBogey.Text.ToString().Length.Equals(0) || this.txtCapacity.Text.ToString().Length.Equals(0) || this.txtTo.Text.ToString().Length.Equals(0) || Validation.IsStringValid(this.txtTo.Text.ToString()) == false || this.dtpFrom.Text.ToString().Length.Equals(0) || this.dtpFrom.Text.ToString().Length.Equals(0) || this.txtFrom.Text.ToString().Length.Equals(0) || Validation.IsStringValid(this.txtFrom.Text.ToString()) == false || this.txtRouteType.Text.ToString().Length.Equals(0) || Validation.IsStringValid(this.txtRouteType.Text.ToString()) == false || this.txtOffDay.Text.ToString().Length.Equals(0) || Validation.IsStringValid(this.txtOffDay.Text.ToString()) == false || this.txtTrainName.Text.ToString().Length.Equals(0) || this.txtTrainNo.Text.ToString().Length.Equals(0) || Validation.IsStringValid(this.txtTrainNo.Text.ToString()) == false)
                {
                    MessageBox.Show("Information Missing or Invalid Inputs Given,Please Try again");

                }
                else
                {
                    if(Convert.ToInt32(this.txtCapacity.Text.ToString())== Convert.ToInt32(this.txtEconomy.Text.ToString())+ Convert.ToInt32(this.txtStandard.Text.ToString())+ Convert.ToInt32(this.txtFirstClass.Text.ToString()))
                    {
                        string query = "insert into traininfo values ('" + this.txtTrainNo.Text.ToString() + "','" + this.txtTrainName.Text.ToString() + "','" + this.txtOffDay.Text.ToString() + "','" + this.txtFrom.Text.ToString() + "','" + this.dtpFrom.Text.ToString() + "','" + this.txtTo.Text.ToString() + "','" + this.dtpTo.Text.ToString() + "','" + this.txtRouteType.Text.ToString() + "'," + this.txtCapacity.Text.ToString() + "," + this.txtBogey.Text.ToString() + "," + this.txtStandard.Text.ToString() + "," + this.txtPriceStandard.Text.ToString() + "," + this.txtEconomy.Text.ToString() + "," + this.txtPricerEconomy.Text.ToString() + "," + this.txtFirstClass.Text.ToString() + "," + this.txtPriceFirstClass.Text.ToString() + ",'" + this.txtBogeyInfo.Text.ToString() + "');";
                        int count = DataAccess.ExecuteQuery(query);
                        if (count > 0)
                        {
                            MessageBox.Show("Train Added Successfully");
                            this.RefreshMethod();
                        }
                        else
                        {
                            { MessageBox.Show("Something Happened Bad,pls try again"); }
                        }
                    }
                    else
                    {
                        MessageBox.Show("Given unbalanced input regarding the total capacity, please check the standard,economy and first class seats amount");
                    }
                }
            }
            catch (Exception exception) { }
        }

        private void TxtTrainNo_Leave(object sender, EventArgs e)
        {
            if(Validation.IsStringValid(this.txtTrainNo.Text.ToString())==false)
            {
                this.errString.SetError(this.txtTrainNo, "Please provide valid input");
            }
        }

        private void TxtTrainName_Leave(object sender, EventArgs e)
        {
            if (Validation.IsStringValid(this.txtTrainName.Text.ToString()) == false)
            {
                this.errString.SetError(this.txtTrainName, "Please provide valid input");
            }
        }

        private void TxtOffDay_Leave(object sender, EventArgs e)
        {
            if (Validation.IsStringValid(this.txtOffDay.Text.ToString()) == false)
            {
                this.errString.SetError(this.txtOffDay, "Please provide valid input");
            }
        }

        private void TxtRouteType_Leave(object sender, EventArgs e)
        {
            if (Validation.IsStringValid(this.txtRouteType.Text.ToString()) == false)
            {
                this.errString.SetError(this.txtRouteType, "Please provide valid input");
            }
        }

        private void TxtFrom_Leave(object sender, EventArgs e)
        {
            if (Validation.IsStringValid(this.txtFrom.Text.ToString()) == false)
            {
                this.errString.SetError(this.txtFrom, "Please provide valid input");
            }
        }

        private void TxtTo_Leave(object sender, EventArgs e)
        {
            if (Validation.IsStringValid(this.txtTo.Text.ToString()) == false)
            {
                this.errString.SetError(this.txtTo, "Please provide valid input");
            }
        }

        private void TxtBogeyInfo_Leave(object sender, EventArgs e)
        {
            if (Validation.IsStringValid(this.txtBogeyInfo.Text.ToString()) == false)
            {
                this.errString.SetError(this.txtBogeyInfo, "Please provide valid input");
            }
        }

        private void BtnDashboard_Click(object sender, EventArgs e)
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

        private void BtnUserProfile_Click(object sender, EventArgs e)
        {
            ChangePasswordManager changePasswordManager = new ChangePasswordManager(this.employee);
            changePasswordManager.Visible = true;
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

        private void RefreshToolStripMenuItem_Click_2(object sender, EventArgs e)
        {
            this.RefreshMethod();
        }

        private void LblTrainNo_Click(object sender, EventArgs e)
        {

        }

        private void LblTrainName_Click(object sender, EventArgs e)
        {

        }

        private void TxtTrainNo_Click(object sender, EventArgs e)
        {

        }

        private void TxtTrainName_Click(object sender, EventArgs e)
        {

        }

        private void TrainAndRoute_Load(object sender, EventArgs e)
        {

        }
    }
}
