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
    public partial class TrainInfoTicketSeller : Form
    {
        private Employee employee;
        internal TrainInfoTicketSeller(Employee employee)
        {
            InitializeComponent();
            
            this.employee = employee;
            PopulateGridView();
        }
        private void PopulateGridView()
        {
            this.dgvTrainList.AutoGenerateColumns = false;
            string query1 = "select * from traininfo;";
            var dt = DataAccess.GetDataTable(query1);
            this.dgvTrainList.DataSource = dt;


        }
        private void Search()
        {
            string name = this.txtSearch.Text.ToString();
            string query1 = "select * from traininfo where traininfo.name like '" + name + "%' or traininfo.name like '%" + name + "' or traininfo.name like'%" + name + "%'or traininfo.departurestation like '" + name + "%' or traininfo.departurestation like '%" + name + "' or traininfo.departurestation like'%" + name + "%' or traininfo.arrivalstation like '" + name + "%' or traininfo.arrivalstation like '%" + name + "' or traininfo.arrivalstation like'%" + name + "%';";
            var dt = DataAccess.GetDataTable(query1);
            this.dgvTrainList.DataSource = dt;
        }
        private void TrainInfoTicketSeller_Leave(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void TxtSearch_TextChanged(object sender, EventArgs e)
        {
            this.Search();
        }

        private void BtnSearch_Click(object sender, EventArgs e)
        {
            this.Search();
        }

        private void BtnDashboard_Click(object sender, EventArgs e)
        {
            TicketSellerDashboardPage ticketSellerDashboardPage = new TicketSellerDashboardPage(this.employee);
            ticketSellerDashboardPage.Visible = true;
            this.Visible = false;
        }

        private void BtnSellTicket_Click(object sender, EventArgs e)
        {
            SellTicket sellTicket = new SellTicket(this.employee);
            sellTicket.Visible = true;
            this.Visible = false;
        }

        private void BtnSellHistory_Click(object sender, EventArgs e)
        {
            SellHistoryTicketSeller sellHistoryTicketSeller = new SellHistoryTicketSeller(this.employee);
            sellHistoryTicketSeller.Visible = true;
            this.Visible = false;
        }

        private void BtnTrainInfo_Click(object sender, EventArgs e)
        {
            TrainInfoTicketSeller trainInfoTicketSeller = new TrainInfoTicketSeller(this.employee);
            trainInfoTicketSeller.Visible = true;
            this.Visible = false;
        }

        private void BtnUserProfile_Click(object sender, EventArgs e)
        {
            ChangePasswordTicketSeller changePassword = new ChangePasswordTicketSeller(this.employee);
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
    }
}
