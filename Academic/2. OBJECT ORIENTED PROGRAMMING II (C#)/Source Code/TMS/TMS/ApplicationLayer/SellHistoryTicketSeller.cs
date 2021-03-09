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
    public partial class SellHistoryTicketSeller : Form
    {
        private Employee employee;
        internal SellHistoryTicketSeller(Employee employee)
        {
            InitializeComponent();
            this.employee = employee;
            string query = "select soldticketid,issuedate,traininfo.name,trainno,departurestation,journeydatetime,arrivalstation,arrivaltime,routetype,passengerinfo.passengername,passengerinfo.mobilenumber,passengerinfo.email,passengerinfo.address,employeeinfo.employeename,class Couch ,amountofticket,bill,vat,netbill,paytype,card,cardnumber,cash,change,couchno,bogeyinfo from soldticketinfo,employeeinfo,journeytimeinfo,passengerinfo,traininfo where soldticketinfo.employeeemail='" + this.employee.Email + "' and soldticketinfo.passengeremail=passengerinfo.email and employeeinfo.email=soldticketinfo.employeeemail and soldticketinfo.journeytimeid=journeytimeinfo.journeytimeid and soldticketinfo.trainid=traininfo.trainid order by soldticketid desc;";
            this.PopulateGridView(query);
        }
        private void PopulateGridView(string query)
        {
            try
            {
                this.dgvSellHistory.AutoGenerateColumns = false;
                var dt = DataAccess.GetDataTable(query);
                this.dgvSellHistory.DataSource = dt;
                this.PopulateSellCommission();
                
            }
            catch (Exception exception) { }
        }

        private void SellHistoryTicketSeller_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

        private void TxtSearch_TextChanged(object sender, EventArgs e)
        {
            string name = this.txtSearch.Text.ToString();
            this.PopulateGridView("select soldticketid,issuedate,traininfo.name,trainno,departurestation,journeydatetime,arrivalstation,arrivaltime,routetype,passengerinfo.passengername,passengerinfo.mobilenumber,passengerinfo.email,passengerinfo.address,employeeinfo.employeename,class Couch ,amountofticket,bill,vat,netbill,paytype,card,cardnumber,cash,change,couchno,bogeyinfo from soldticketinfo,employeeinfo,journeytimeinfo,passengerinfo,traininfo where soldticketinfo.employeeemail='" + this.employee.Email + "' and soldticketinfo.passengeremail=passengerinfo.email and employeeinfo.email=soldticketinfo.employeeemail and soldticketinfo.journeytimeid=journeytimeinfo.journeytimeid and soldticketinfo.trainid=traininfo.trainid and (soldticketinfo.issuedate like '" + name + "%' or soldticketinfo.issuedate  like '%" + name + "' or soldticketinfo.issuedate like'%" + name + "%'or soldticketinfo.passengeremail like '" + name + "%' or soldticketinfo.passengeremail like '%" + name + "' or soldticketinfo.passengeremail like'%" + name + "%');");
            
        }
        private void PopulateSellCommission()
        {
            try
            {
                int counter = 0;
                double sell = 0;
                double netSell = 0;
                double commission = 0;
                while (counter < this.dgvSellHistory.RowCount)
                {
                    if (this.dgvSellHistory.Rows[counter].Cells["bill"].Value.ToString() != null)
                    {
                        netSell = netSell + Convert.ToDouble(this.dgvSellHistory.Rows[counter].Cells["netbill"].Value.ToString());

                        sell = sell + Convert.ToDouble(this.dgvSellHistory.Rows[counter].Cells["bill"].Value.ToString());
                        counter++;
                    }
                }
                this.lblTotalSell.Text = netSell.ToString() + " BDT";
                commission = sell * (this.employee.Commission / 100);
                this.lblTotallCommission.Text=commission.ToString()+" BDT";
            }
            catch (Exception exception) { }
        }

        private void RefreshToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.RefreshMethod();
        }
        private void RefreshMethod()
        {
            SellHistoryTicketSeller sellHistoryTicketSeller = new SellHistoryTicketSeller(this.employee);
            sellHistoryTicketSeller.Visible = true;
            this.Visible = false;
        }

        private void BtnRefresh_Click(object sender, EventArgs e)
        {
            this.RefreshMethod();
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
            ChangePasswordTicketSeller changePasswordTicketSeller = new ChangePasswordTicketSeller(this.employee);
            changePasswordTicketSeller.Visible = true;
            this.Visible = false;
        }

        private void BtnDashboard_Click(object sender, EventArgs e)
        {
            TicketSellerDashboardPage ticketSellerDashboardPage = new TicketSellerDashboardPage(this.employee);
            ticketSellerDashboardPage.Visible = true;
            this.Visible = false;
        }

        private void BtnSellHistory_Click(object sender, EventArgs e)
        {
            this.RefreshMethod();
        }

        private void BtnDashboard_Click_1(object sender, EventArgs e)
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

        private void BtnSellHistory_Click_1(object sender, EventArgs e)
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

        private void BtnUserProfile_Click_1(object sender, EventArgs e)
        {
            ChangePasswordTicketSeller changePassword = new ChangePasswordTicketSeller(this.employee);
            changePassword.Visible = true;
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

        private void TxtSearch_Click(object sender, EventArgs e)
        {

        }

        private void Button1_Click(object sender, EventArgs e)
        {
            this.RefreshMethod();
        }

        private void BtnSearch_Click(object sender, EventArgs e)
        {
            if (!this.dtpFrom.Text.ToString().Equals(null) && !this.dtpTO.Text.ToString().Equals(null))
            {
                string query = "select soldticketid,issuedate,traininfo.name,trainno,departurestation,journeydatetime,arrivalstation,arrivaltime,routetype,passengerinfo.passengername,passengerinfo.mobilenumber,passengerinfo.email,passengerinfo.address,employeeinfo.employeename,class Couch ,amountofticket,bill,vat,netbill,paytype,card,cardnumber,cash,change,couchno,bogeyinfo from soldticketinfo,employeeinfo,journeytimeinfo,passengerinfo,traininfo where soldticketinfo.employeeemail='" + this.employee.Email + "' and soldticketinfo.passengeremail=passengerinfo.email and employeeinfo.email=soldticketinfo.employeeemail and soldticketinfo.journeytimeid=journeytimeinfo.journeytimeid and soldticketinfo.trainid=traininfo.trainid  and soldticketinfo.issuedate between '" + this.dtpFrom.Text.ToString() + "' and '" + this.dtpTO.Text.ToString() + "' order by soldticketid desc;";
                this.PopulateGridView(query);
            }
        }
    }
}
