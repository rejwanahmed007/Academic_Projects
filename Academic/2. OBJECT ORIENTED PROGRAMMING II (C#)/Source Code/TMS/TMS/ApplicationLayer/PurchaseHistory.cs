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
    public partial class PurchaseHistory : Form
    {
        private UserEntity userinfo;
        internal PurchaseHistory(UserEntity userinfo)
        {
            InitializeComponent();
            this.userinfo = userinfo;
            string query = "select soldticketid,issuedate,traininfo.name,trainno,departurestation,journeydatetime,arrivalstation,arrivaltime,routetype,passengerinfo.passengername,passengerinfo.mobilenumber,passengerinfo.email,passengerinfo.address,employeeinfo.employeename,class Couch ,amountofticket,bill,vat,netbill,paytype,card,cardnumber,cash,change,couchno,bogeyinfo from soldticketinfo,employeeinfo,journeytimeinfo,passengerinfo,traininfo where soldticketinfo.passengeremail='" + this.userinfo.Email + "' and soldticketinfo.passengeremail=passengerinfo.email and employeeinfo.email=soldticketinfo.employeeemail and soldticketinfo.journeytimeid=journeytimeinfo.journeytimeid and soldticketinfo.trainid=traininfo.trainid order by soldticketid desc;";
            this.PopulateGridView(query);
        }
        private void PopulateGridView(string query)
        {
            try
            {
                this.dgvPurchaseHistory.AutoGenerateColumns = false;
                var dt = DataAccess.GetDataTable(query);
                this.dgvPurchaseHistory.DataSource = dt;
                this.PopulateExpense();
            }
            catch (Exception exception) { }


        }

        private void PurchaseHistory_Load(object sender, EventArgs e)
        {

        }

        private void PurchaseHistory_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

        private void BtnDashboard_Click(object sender, EventArgs e)
        {
            PassengerDashboardPage dashboardPage = new PassengerDashboardPage(this.userinfo);
            dashboardPage.Visible = true;
            this.Visible = false;
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

        private void BtnFareQuery_Click(object sender, EventArgs e)
        {
            FareQuery fareQuery = new FareQuery(this.userinfo);
            fareQuery.Visible = true;
            this.Visible = false;
        }

        private void DtpFrom_ValueChanged(object sender, EventArgs e)
        {

        }

        private void LblRevenue_Click(object sender, EventArgs e)
        {

        }

        private void BtnSave_Click(object sender, EventArgs e)
        {
            try
            {
                if(!this.txtComplain.Text.ToString().Equals(null))
                {
                    string details = this.txtComplain.Text.ToString();
                    string query = "insert into complain values ('" + this.userinfo.Email + "','" + details + "', SYSDATETIME());";
                    int count1 = DataAccess.ExecuteQuery(query);
                    if(count1>0)
                    {
                        MessageBox.Show("Your Complain/Suggestions are appreciated, Thank you for this feedback");
                        this.txtComplain.Clear();
                    }
                    else { MessageBox.Show("Oopss...Server problem, Please Try Again.."); }
                }
                else { MessageBox.Show("Write Your Suggestion/Feedback Before Pressing Save Button"); }
            }
            catch (Exception exception) { MessageBox.Show("Oopss...Server problem, Please Try Again.."); }
        }

        private void TxtSearch_TextChanged(object sender, EventArgs e)
        {
            string name = this.txtSearch.Text.ToString();
            string query = "select soldticketid,issuedate,traininfo.name,trainno,departurestation,journeydatetime,arrivalstation,arrivaltime,routetype,passengerinfo.passengername,passengerinfo.mobilenumber,passengerinfo.email,passengerinfo.address,employeeinfo.employeename,class Couch ,amountofticket,bill,vat,netbill,paytype,card,cardnumber,cash,change,couchno,bogeyinfo from soldticketinfo,employeeinfo,journeytimeinfo,passengerinfo,traininfo where soldticketinfo.passengeremail='" + this.userinfo.Email + "' and soldticketinfo.passengeremail=passengerinfo.email and employeeinfo.email=soldticketinfo.employeeemail and soldticketinfo.journeytimeid=journeytimeinfo.journeytimeid and soldticketinfo.trainid=traininfo.trainid and (traininfo.name like '" + name + "%' or traininfo.name  like '%" + name + "' or traininfo.name like'%" + name + "%' or journeytimeinfo.journeydate like '" + name + "%' or journeytimeinfo.journeydate  like '%" + name + "' or journeytimeinfo.journeydate like'%" + name + "%');";
            this.PopulateGridView(query);
            
        }
        private void PopulateExpense()
        {
            try
            {
                int counter = 0; double cost = 0;
                while (counter < this.dgvPurchaseHistory.RowCount)
                {
                    if (this.dgvPurchaseHistory.Rows[counter].Cells["netbill"].Value.ToString() != null)
                    {
                        cost = cost + Convert.ToDouble(this.dgvPurchaseHistory.Rows[counter].Cells["netbill"].Value.ToString());
                        counter++;
                    }
                }
                this.lblCost.Text = cost.ToString() + " BDT";
            }
            catch (Exception exception) { }
        }
        private void RefreshToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.RefreshMethod();
        }
        private void RefreshMethod()
        {
            PurchaseHistory purchaseHistory = new PurchaseHistory(userinfo);
            purchaseHistory.Visible = true;
            this.Visible = false;
        }

        private void BtnSearch_Click(object sender, EventArgs e)
        {
            if (!this.dtpFrom.Text.ToString().Equals(null) && !this.dtpTO.Text.ToString().Equals(null))
            {
                string query = "select soldticketid,issuedate,traininfo.name,trainno,departurestation,journeydatetime,arrivalstation,arrivaltime,routetype,passengerinfo.passengername,passengerinfo.mobilenumber,passengerinfo.email,passengerinfo.address,employeeinfo.employeename,class Couch ,amountofticket,bill,vat,netbill,paytype,card,cardnumber,cash,change,couchno,bogeyinfo from soldticketinfo,employeeinfo,journeytimeinfo,passengerinfo,traininfo where soldticketinfo.passengeremail='" + this.userinfo.Email + "' and soldticketinfo.passengeremail=passengerinfo.email and employeeinfo.email=soldticketinfo.employeeemail and soldticketinfo.journeytimeid=journeytimeinfo.journeytimeid and soldticketinfo.trainid=traininfo.trainid and soldticketinfo.issuedate between '" + this.dtpFrom.Value.ToString() + "' and '" + this.dtpTO.Value.ToString() + "' order by soldticketid desc;";
                this.PopulateGridView(query);
            }
        }

        private void BtnRefresh_Click(object sender, EventArgs e)
        {
            this.RefreshMethod();
        }
    }
}
