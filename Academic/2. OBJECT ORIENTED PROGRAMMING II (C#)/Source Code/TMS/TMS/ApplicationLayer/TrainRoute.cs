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
using MetroFramework.Forms;

namespace TMS.ApplicationLayer
{
    public partial class TrainRoute : Form
    {
        private UserEntity userinfo;
        internal TrainRoute(UserEntity userinfo)
        {
           InitializeComponent();
           this.userinfo = userinfo;
           PopulateGridView();
        }
        private void PopulateGridView()
        {
            this.dgvTrainList.AutoGenerateColumns = false;
            string query1 = "select * from traininfo;";
            var dt = DataAccess.GetDataTable(query1);
            this.dgvTrainList.DataSource = dt;

            
        }

        private void FareQuery_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

        private void TxtSearch_TextChanged(object sender, EventArgs e)
        {
            Search();
        }
        private void Search()
        {
            string name = this.txtSearch.Text.ToString();
            string query1 = "select * from traininfo where traininfo.name like '"+name+ "%' or traininfo.name like '%"+name+ "' or traininfo.name like'%"+name+ "%'or traininfo.departurestation like '" + name + "%' or traininfo.departurestation like '%" + name + "' or traininfo.departurestation like'%" + name + "%' or traininfo.arrivalstation like '" + name + "%' or traininfo.arrivalstation like '%" + name + "' or traininfo.arrivalstation like'%" + name + "%';";
            var dt = DataAccess.GetDataTable(query1);
            this.dgvTrainList.DataSource = dt;
        }

        private void BtnSearch_Click(object sender, EventArgs e)
        {
            Search();
        }

        private void BtnDashboard_Click(object sender, EventArgs e)
        {
            PassengerDashboardPage dashboardPage = new PassengerDashboardPage(this.userinfo);
            dashboardPage.Visible = true;
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

        private void BtnPurchaseHistory_Click(object sender, EventArgs e)
        {
            PurchaseHistory purchaseHistory = new PurchaseHistory(this.userinfo);
            purchaseHistory.Visible = true;
            this.Visible = false;
        }
    }
}
