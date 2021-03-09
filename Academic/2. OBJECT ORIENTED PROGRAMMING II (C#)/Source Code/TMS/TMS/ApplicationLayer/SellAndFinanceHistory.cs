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
    
    public partial class SellAndFinanceHistory : Form
    {
        private Employee employee;
        private List<string> trainList;
        private TrainRepo trainRepo;
        internal SellAndFinanceHistory(Employee employee)
        {
            
            InitializeComponent();
            this.employee = employee;
            this.trainRepo = new TrainRepo();
            this.trainList = this.trainRepo.TrainList();
            string query = "select traininfo.trainid,soldticketid,issuedate,traininfo.name,trainno,departurestation,journeydatetime,arrivalstation,arrivaltime,routetype,passengerinfo.passengername,passengerinfo.mobilenumber,passengerinfo.email,passengerinfo.address,employeeinfo.employeename,class Couch ,amountofticket,bill,vat,netbill,paytype,card,cardnumber,cash,change,couchno,bogeyinfo from soldticketinfo,employeeinfo,journeytimeinfo,passengerinfo,traininfo where soldticketinfo.passengeremail=passengerinfo.email and employeeinfo.email=soldticketinfo.employeeemail and soldticketinfo.journeytimeid=journeytimeinfo.journeytimeid and soldticketinfo.trainid=traininfo.trainid order by soldticketid desc;";
            this.PopulateGridView(query);
            this.cmbTrainNo.Items.AddRange(this.trainList.ToArray());
        }
        private void PopulateGridView(string query)
        {

            try
            {
                this.dgvSellHistory.AutoGenerateColumns = false;
                var dt = DataAccess.GetDataTable(query);
                this.dgvSellHistory.DataSource = dt;
                this.Revenue();
            }
            
            catch (Exception exception)
            {
                
            }

        }
        private void Revenue()
        {
            try
            {
                int counter = 0; double revenue = 0.0;
                while (counter < this.dgvSellHistory.RowCount)
                {
                    if (this.dgvSellHistory.Rows[counter].Cells["netbill"].Value.ToString() != null)
                    {
                        revenue = revenue + Convert.ToDouble(this.dgvSellHistory.Rows[counter].Cells["netbill"].Value.ToString());
                        counter++;
                    }
                }
                this.lblProfit.Text = revenue.ToString() + " BDT";
            }

            catch (Exception exception) { }
        }
        private void DtpFrom_ValueChanged(object sender, EventArgs e)
        {

        }

        private void SellAndFinanceHistory_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

        private void BtnRefresh_Click(object sender, EventArgs e)
        {
            this.RefreshMethod();
        }
        private void RefreshMethod()
        {
            SellAndFinanceHistory sellAndFinanceHistory = new SellAndFinanceHistory(this.employee);
            sellAndFinanceHistory.Visible = true;
            this.Visible = false;
        }

        private void RefreshToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.RefreshMethod();

        }

        private void TxtSearch_TextChanged(object sender, EventArgs e)
        {
            string name = this.txtSearch.Text.ToString();
            this.PopulateGridView("select traininfo.trainid,traininfo.trainid,soldticketid,issuedate,traininfo.name,trainno,departurestation,journeydatetime,arrivalstation,arrivaltime,routetype,passengerinfo.passengername,passengerinfo.mobilenumber,passengerinfo.email,passengerinfo.address,employeeinfo.employeename,class Couch ,amountofticket,bill,vat,netbill,paytype,card,cardnumber,cash,change,couchno,bogeyinfo from soldticketinfo,employeeinfo,journeytimeinfo,passengerinfo,traininfo where soldticketinfo.passengeremail=passengerinfo.email and employeeinfo.email=soldticketinfo.employeeemail and soldticketinfo.journeytimeid=journeytimeinfo.journeytimeid and soldticketinfo.trainid=traininfo.trainid and (employeeinfo.email like '" + name + "%' or employeeinfo.email  like '%" + name + "' or employeeinfo.email like'%" + name + "%' or employeeinfo.employeename like '" + name + "%' or employeeinfo.employeename  like '%" + name + "' or employeeinfo.employeename like'%" + name + "%' or soldticketinfo.issuedate like '" + name + "%' or soldticketinfo.issuedate  like '%" + name + "' or soldticketinfo.issuedate like'%" + name + "%'or traininfo.trainno like '" + name + "%' or traininfo.trainno like '%" + name + "' or traininfo.trainno like'%" + name + "%');");

        }

        private void BtnSearch_Click(object sender, EventArgs e)
        {
            //string sqlFormat = "YYYY-MM-DD hh:mm:ss[.nnnnnnn]";
            try
            {
                if (this.chkTrainNo.Checked == true && this.chkIssueDate.Checked == true)
                {
                    if (this.cmbTrainNo.SelectedItem != null)
                    {
                        string query = "select traininfo.trainid,soldticketid,issuedate,traininfo.name,trainno,departurestation,journeydatetime,arrivalstation,arrivaltime,routetype,passengerinfo.passengername,passengerinfo.mobilenumber,passengerinfo.email,passengerinfo.address,employeeinfo.employeename,class Couch ,amountofticket,bill,vat,netbill,paytype,card,cardnumber,cash,change,couchno,bogeyinfo from soldticketinfo,employeeinfo,journeytimeinfo,passengerinfo,traininfo where soldticketinfo.passengeremail=passengerinfo.email and employeeinfo.email=soldticketinfo.employeeemail and soldticketinfo.journeytimeid=journeytimeinfo.journeytimeid and soldticketinfo.trainid=traininfo.trainid and traininfo.trainno='" + this.cmbTrainNo.SelectedItem.ToString() + "' and  soldticketinfo.issuedate between '" + this.dtpFrom.Value.ToString() + "' and '" + this.dtpTO.Value.ToString() + "' order by soldticketid desc;";
                        this.PopulateGridView(query);
                    }
                    else
                    {
                        MessageBox.Show("You haven't select any train number");

                    }
                }
                else if (this.chkTrainNo.Checked == true && this.chkIssueDate.Checked == false)
                {
                    if (this.cmbTrainNo.SelectedItem != null)
                    {
                        string query = "select traininfo.trainid,soldticketid,issuedate,traininfo.name,trainno,departurestation,journeydatetime,arrivalstation,arrivaltime,routetype,passengerinfo.passengername,passengerinfo.mobilenumber,passengerinfo.email,passengerinfo.address,employeeinfo.employeename,class Couch ,amountofticket,bill,vat,netbill,paytype,card,cardnumber,cash,change,couchno,bogeyinfo from soldticketinfo,employeeinfo,journeytimeinfo,passengerinfo,traininfo where soldticketinfo.passengeremail=passengerinfo.email and employeeinfo.email=soldticketinfo.employeeemail and soldticketinfo.journeytimeid=journeytimeinfo.journeytimeid and soldticketinfo.trainid=traininfo.trainid and traininfo.trainno='" + this.cmbTrainNo.SelectedItem.ToString() + "' order by soldticketid desc;";
                        this.PopulateGridView(query);
                    }
                    else
                    {
                        MessageBox.Show("You haven't select any train number");

                    }
                }
                else if (this.chkTrainNo.Checked == false && this.chkIssueDate.Checked == true)
                {
                    string query = "select traininfo.trainid,soldticketid,issuedate,traininfo.name,trainno,departurestation,journeydatetime,arrivalstation,arrivaltime,routetype,passengerinfo.passengername,passengerinfo.mobilenumber,passengerinfo.email,passengerinfo.address,employeeinfo.employeename,class Couch ,amountofticket,bill,vat,netbill,paytype,card,cardnumber,cash,change,couchno,bogeyinfo from soldticketinfo,employeeinfo,journeytimeinfo,passengerinfo,traininfo where soldticketinfo.passengeremail=passengerinfo.email and employeeinfo.email=soldticketinfo.employeeemail and soldticketinfo.journeytimeid=journeytimeinfo.journeytimeid and soldticketinfo.trainid=traininfo.trainid and  soldticketinfo.issuedate between '" + this.dtpFrom.Value.ToString() + "' and '" + this.dtpTO.Value.ToString() + "' order by soldticketid desc;";
                    this.PopulateGridView(query);
                }
                else if (this.chkTrainNo.Checked == false && this.chkIssueDate.Checked == false)
                {
                    this.RefreshMethod();
                }
            }
            catch (Exception exception) { }
        }

        private void BtnDashboard_Click(object sender, EventArgs e)
        {
            ManagerDashboardPage managerDashboardPage = new ManagerDashboardPage(this.employee);
            managerDashboardPage.Visible = true;
            this.Visible = false;
        }

        private void BtnSellTicket_Click(object sender, EventArgs e)
        {
            SellAndFinanceHistory sellAndFinanceHistory = new SellAndFinanceHistory(this.employee);
            sellAndFinanceHistory.Visible = true;
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

        private void BtnExit_Click_1(object sender, EventArgs e)
        {

        }

        private void BtnSellHistory_Click(object sender, EventArgs e)
        {
            this.RefreshMethod();
        }

        private void BtnTrainInfo_Click(object sender, EventArgs e)
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

        private void BtnSellHistory_Click_1(object sender, EventArgs e)
        {
            SellAndFinanceHistory sellAndFinanceHistory = new SellAndFinanceHistory(this.employee);
            sellAndFinanceHistory.Visible = true;
            this.Visible = false;
        }

        private void BtnTrainInfo_Click_1(object sender, EventArgs e)
        {
            TrainAndRoute trainAndRoute = new TrainAndRoute(this.employee);
            trainAndRoute.Visible = true;
            this.Visible = false;
        }

        private void BtnFareInfo_Click_1(object sender, EventArgs e)
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

        private void BtnExit_Click_2(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
