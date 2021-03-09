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
    public partial class PassengersFeedback : Form
    {
        private Employee employee;
        internal PassengersFeedback(Employee employee)
        {
            InitializeComponent();
            this.employee = employee;
            this.PopulateGridView("select complainid,complain.details,complaindate,passengerid,passengername,mobilenumber,logininfo.email,address from logininfo,passengerinfo,complain where logininfo.email=passengerinfo.email and passengerinfo.email=complain.passengeremail order by complaindate desc;");
        }
        private void PopulateGridView(string query)
        {
            try
            {
                this.dgvComplainDetails.AutoGenerateColumns = false;
                var dt = DataAccess.GetDataTable(query);
                this.dgvComplainDetails.DataSource = dt;
                
            }
            catch (Exception exception) { }
        }
        private void PassengersFeedback_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

        private void TxtSearch_TextChanged(object sender, EventArgs e)
        {
            string name = this.txtSearch.Text.ToString();
            string query = "select complainid,complain.details,complaindate,passengerid,passengername,mobilenumber,logininfo.email,address from logininfo,passengerinfo,complain where logininfo.email=passengerinfo.email and passengerinfo.email=complain.passengeremail and (passengerid like '" + name + "%' or passengerid  like '%" + name + "' or passengerid like'%" + name + "%' or complainid like '" + name + "%' or complainid  like '%" + name + "' or complainid like'%" + name + "%')order by complaindate desc;";
            this.PopulateGridView(query);
        }

        private void BtnRefresh_Click(object sender, EventArgs e)
        {
            this.RefreshMethod();
        }
        private void RefreshMethod()
        {
            PassengersFeedback passengersFeedback = new PassengersFeedback(this.employee);
            passengersFeedback.Visible = true;
            this.Visible = false;
        }

        private void RefreshToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.RefreshMethod();
        }

        private void BtnSearch_Click(object sender, EventArgs e)
        {
            string query = "select complainid,complain.details,complaindate,passengerid,passengername,mobilenumber,logininfo.email,address from logininfo,passengerinfo,complain where logininfo.email=passengerinfo.email and passengerinfo.email=complain.passengeremail and complaindate between '" + this.dtpFrom.Value.ToString() + "' and '" + this.dtpTO.Value.ToString() + "'order by complaindate desc;";
            this.PopulateGridView(query);
        }

        private void DgvComplainDetails_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

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
    }
}
