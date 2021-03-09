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
    public partial class FareInfo : Form
    {
        private Employee employee;
        private List<string> trainIDList;
        internal FareInfo(Employee employee)
        {
            
            InitializeComponent();
            this.employee = employee;
            this.GetTrainIDList();
            this.PopulateGridViewFareDetails("select traininfo.trainid,journeytimeinfo.journeytimeid,trainno,traininfo.name,departurestation,journeydate,departuretime,arrivalstation,arrivaltime,routetype,capacity,bogey,standard,priceperstandard,standardavailableseat,economy,pricepereconomy,economyavailableseat,firstclass,priceperfirstclass,firstclassavailableseat,bogeyinfo from traininfo,journeytimeinfo where traininfo.trainid=journeytimeinfo.trainid and journeydatetime>'2019-08-20 06:00:00'");
            this.PopulateGridViewTrainList("select * from traininfo;");
        }
        private void GetTrainIDList()
        {
            
            try
            {
                this.trainIDList = new List<string>();
                string query = "select trainid from traininfo;";
                var dt = DataAccess.GetDataTable(query);
                int counter = 0;
                while (counter < dt.Rows.Count)
                {
                    if (dt.Rows[counter]["trainid"].ToString() != null)
                    {
                        this.trainIDList.Add(dt.Rows[counter]["trainid"].ToString());
                    }
                    counter++;
                }
                this.cmbTrainID.Items.AddRange(this.trainIDList.ToArray());
                this.cmbTrainID.AutoCompleteCustomSource.AddRange(this.trainIDList.ToArray());
            }
            catch (Exception exception) { }
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

        private void FareInfo_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

        private void BtnRefresh_Click(object sender, EventArgs e)
        {
            this.RefreshMethod();
        }
        private void RefreshMethod()
        {
            FareInfo fareInfo = new FareInfo(this.employee);
            fareInfo.Visible = true;
            this.Visible = false;
        }

        private void BtnFareInfo_Click(object sender, EventArgs e)
        {
            FareInfo fareInfo = new FareInfo(this.employee);
            fareInfo.Visible = true;
            this.Visible = false;
        }
        private void PopulateGridViewFareDetails(string query)
        {
            try
            {
                this.dgvFareDetails.AutoGenerateColumns = false;
                var dt = DataAccess.GetDataTable(query);
                this.dgvFareDetails.DataSource = dt;
            }
            catch (Exception exception) { }

        }

        private void RefreshToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.RefreshMethod();
        }

        private void CmbTrainID_TextChanged(object sender, EventArgs e)
        {
            //string name = this.txtSearch.Text.ToString();
            //string query1 = "select * from traininfo where traininfo.trainid like '" + name + "%' or traininfo.trainid like '%" + name + "' or traininfo.trainid like'%" + name + "%';";
            //var dt = DataAccess.GetDataTable(query1);
            //this.dgvTrainList.DataSource = dt;
        }

        private void TxtSearch_TextChanged(object sender, EventArgs e)
        {
            string name = this.txtSearchFareQuery.Text.ToString();
            this.PopulateGridViewFareDetails("select traininfo.trainid,journeytimeinfo.journeytimeid,traininfo.trainno,traininfo.name,departurestation,journeydate,departuretime,arrivalstation,arrivaltime,routetype,capacity,bogey,standard,priceperstandard,standardavailableseat,economy,pricepereconomy,economyavailableseat,firstclass,priceperfirstclass,firstclassavailableseat,bogeyinfo from traininfo,journeytimeinfo where traininfo.trainid=journeytimeinfo.trainid and journeydatetime>'2019-08-20 06:00:00' and (traininfo.trainno like '" + name + "%' or traininfo.trainno like '%" + name + "' or traininfo.trainno like '%" + name + "%' or  traininfo.trainid like '" + name + "%' or traininfo.trainid like '%" + name + "' or traininfo.trainid like '%" + name + "%'or traininfo.name like '" + name + "%' or traininfo.name like '%" + name + "' or traininfo.name like'%" + name + "%'or traininfo.departurestation like '" + name + "%' or traininfo.departurestation like '%" + name + "' or traininfo.departurestation like'%" + name + "%' or traininfo.arrivalstation like '" + name + "%' or traininfo.arrivalstation like '%" + name + "' or traininfo.arrivalstation like'%" + name + "%');");

        }

        private void MetroTextBox1_TextChanged(object sender, EventArgs e)
        {
            string name = this.txtSearchTrainInfo.Text.ToString();
            string query1 = "select * from traininfo where traininfo.trainno like '" + name + "%' or traininfo.trainno like '%" + name + "' or traininfo.trainno like '%" + name + "%' or  traininfo.trainid like '" + name + "%' or traininfo.trainid like '%" + name + "' or traininfo.trainid like '%" + name + "%'or  traininfo.name like '" + name + "%' or traininfo.name like '%" + name + "' or traininfo.name like'%" + name + "%'or traininfo.departurestation like '" + name + "%' or traininfo.departurestation like '%" + name + "' or traininfo.departurestation like'%" + name + "%' or traininfo.arrivalstation like '" + name + "%' or traininfo.arrivalstation like '%" + name + "' or traininfo.arrivalstation like'%" + name + "%';";
            this.PopulateGridViewTrainList(query1);
        }

        private void DgvFareDetails_CellContentDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            //if (e.RowIndex >= 0)
            //{
            //    this.cmbTrainID.SelectedItem = this.dgvFareDetails.CurrentRow.Cells["trainid"].Value.ToString();

            //}
        }

        private void DgvTrainList_CellContentDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            //if (e.RowIndex >= 0)
            //{
            //    this.cmbTrainID.SelectedItem = this.dgvTrainList.CurrentRow.Cells["trainid"].Value.ToString();

            //if (this.dtpJourneyDate.Text.ToString() < System.DateTime)
        }

        private void BtnSave_Click(object sender, EventArgs e)
        {
            DateTime now = DateTime.Now;
            try

            {
                
                if (now <Convert.ToDateTime(this.dtpJourneyDate.Text.ToString()))
                {
                    //if (this.cmbTrainID.SelectedItem.ToString() != null && this.txtDateList.Text.ToString() != null)
                    if (this.cmbTrainID.SelectedItem.ToString() != null && this.dtpJourneyDate.Text.ToString() != null)

                    {
                        string trainid = this.cmbTrainID.SelectedItem.ToString();
                        string query1 = "select count(trainid) number from journeytimeinfo where trainid = " + trainid + " and journeydate = '" + this.dtpJourneyDate.Text.ToString() + "' ";
                        var dt = DataAccess.GetDataTable(query1);
                        if (Convert.ToInt32(dt.Rows[0]["number"].ToString()) == 0)
                        {
                            string query2 = "select departuretime=convert(char(8),departuretime),standard,economy,firstclass from traininfo where traininfo.trainid=" + trainid.ToString();
                            dt = DataAccess.GetDataTable(query2);
                            string departuretime = dt.Rows[0]["departuretime"].ToString();
                            int standard = Convert.ToInt32(dt.Rows[0]["standard"].ToString());
                            int economy = Convert.ToInt32(dt.Rows[0]["economy"].ToString());
                            int firstclass = Convert.ToInt32(dt.Rows[0]["firstclass"].ToString());
                            string journeydatetime = this.dtpJourneyDate.Text.ToString() + " " + departuretime.ToString();
                            string query = "insert into journeytimeinfo values(" + trainid + ", '" + journeydatetime + "', " + standard + ", " + economy + ", " + firstclass + ", '" + this.dtpJourneyDate.Text.ToString() + "', '" + departuretime.ToString() + "')";
                            int count1 = DataAccess.ExecuteQuery(query);
                            if (count1 > 0)
                            {
                                MessageBox.Show("Fare List Updated Successfully");


                            }
                            else { MessageBox.Show("Something Happened Bad,pls try again"); }
                        }
                        else
                        {
                            MessageBox.Show("This Train ID already exist in this selected date and try from next date");
                        }


                    }
                    else
                    { MessageBox.Show("You haven't select any train ID"); }
                }
                else
                { MessageBox.Show("You selected date is less than current date,try from the next some"); }
            }
            catch (Exception exception)
            {
                MessageBox.Show("Something Happened Bad,Please select right Train ID and try again");
                //this.dtpJourneyDate.Value.GetDateTimeFormats.
            }
            this.PopulateGridViewFareDetails("select traininfo.trainid,journeytimeinfo.journeytimeid,trainno,traininfo.name,departurestation,journeydate,departuretime,arrivalstation,arrivaltime,routetype,capacity,bogey,standard,priceperstandard,standardavailableseat,economy,pricepereconomy,economyavailableseat,firstclass,priceperfirstclass,firstclassavailableseat,bogeyinfo from traininfo,journeytimeinfo where traininfo.trainid=journeytimeinfo.trainid and journeydatetime>'2019-08-20 06:00:00'");
            this.PopulateGridViewTrainList("select * from traininfo;");
        }

        private void CmbTrainID_SelectedIndexChanged(object sender, EventArgs e)
        {
            string trainid = this.cmbTrainID.SelectedItem.ToString();
            this.PopulateGridViewFareDetails("select traininfo.trainid,journeytimeinfo.journeytimeid,trainno,traininfo.name,departurestation,journeydate,departuretime,arrivalstation,arrivaltime,routetype,capacity,bogey,standard,priceperstandard,standardavailableseat,economy,pricepereconomy,economyavailableseat,firstclass,priceperfirstclass,firstclassavailableseat,bogeyinfo from traininfo,journeytimeinfo where traininfo.trainid=journeytimeinfo.trainid and journeydatetime>'2019-08-20 06:00:00' and traininfo.trainid='"+ trainid + "'");
            this.PopulateGridViewTrainList("select * from traininfo where traininfo.trainid='" + trainid + "';");
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

        private void BtnFareInfo_Click_1(object sender, EventArgs e)
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
