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
    public partial class FareQuery : Form
    {
        private List<int> trainid = new List<int>();
        private int trainID;
        private TrainRepo traininfo;
        private UserEntity userinfo;
        private List<string> journeyFrom = new List<string>();
        private List<string> journeyTo = new List<string>();
        
        internal FareQuery(UserEntity userinfo)
        {
            InitializeComponent();
            this.userinfo = userinfo;
            traininfo = new TrainRepo();
            this.PopulateJourneyFrom();
            this.PopulateGridView("select trainno,traininfo.name,departurestation,journeydate,departuretime,arrivalstation,arrivaltime,routetype,capacity,bogey,standard,priceperstandard,standardavailableseat,economy,pricepereconomy,economyavailableseat,firstclass,priceperfirstclass,firstclassavailableseat,bogeyinfo from traininfo,journeytimeinfo where traininfo.trainid=journeytimeinfo.trainid and journeydatetime>SYSDATETIME()");
            
        }
        private void PopulateGridView(string query)
        {
            try
            {
                this.dgvTrainList.AutoGenerateColumns = false;
                var dt = DataAccess.GetDataTable(query);
                this.dgvTrainList.DataSource = dt;
            }

            catch (Exception exception) { }
        }
        private void PopulateJourneyTo()
        {
            this.journeyTo = this.traininfo.getJourneyTo(this.cmbFrom.SelectedItem.ToString());
            if(journeyTo!=null)
            {
                this.cmbTo.Items.AddRange(journeyTo.ToArray());
            }
        }
        private void PopulateJourneyFrom()
        {
            this.cmbFrom.Focus();
            this.journeyFrom = this.traininfo.getJourneyFrom();
            if(journeyFrom!=null)
            {
                this.cmbFrom.Items.AddRange(journeyFrom.ToArray());
            }
            lblAvailableSeatResult.Visible = false;


        }
        private void PopulateJourneyDate()
        {
            try
            {
                if (this.traininfo.getJourneyDate(this.cmbFrom.SelectedItem.ToString(), this.cmbTo.SelectedItem.ToString()) != null)
                {
                    this.cmbJourneyDate.Items.AddRange(this.traininfo.getJourneyDate(this.cmbFrom.SelectedItem.ToString(), this.cmbTo.SelectedItem.ToString()).ToArray());
                }
            }

            catch (Exception exception) { }
        }
        private void PopulateJourneyTime()
        {
            if (this.traininfo.getJourneyTime(this.cmbFrom.SelectedItem.ToString(), this.cmbTo.SelectedItem.ToString(),this.cmbJourneyDate.SelectedItem.ToString()) != null)
            {
                this.cmbJourneyTime.Items.AddRange(this.traininfo.getJourneyTime(this.cmbFrom.SelectedItem.ToString(), this.cmbTo.SelectedItem.ToString(),this.cmbJourneyDate.SelectedItem.ToString()).ToArray());
            }
        }

        private void PopulateAvailableTrain()
        {
            
            if (this.traininfo.getAvailableTrain(this.cmbFrom.SelectedItem.ToString(), this.cmbTo.SelectedItem.ToString(), this.cmbJourneyDate.SelectedItem.ToString(),this.cmbJourneyTime.SelectedItem.ToString()) != null)
            {
                this.cmbAvailableTrain.Items.AddRange(this.traininfo.getAvailableTrain(this.cmbFrom.SelectedItem.ToString(), this.cmbTo.SelectedItem.ToString(), this.cmbJourneyDate.SelectedItem.ToString(), this.cmbJourneyTime.SelectedItem.ToString()).ToArray());
                
            }
        }
        private void PopulateClass()
        {
            try
            {
                List<string> couchClass = new List<string>();
                couchClass.Add("Economy (Non-AC Couch)");
                couchClass.Add("Standard (AC Couch)");
                couchClass.Add("First Class (AC Cabin)");
                this.cmbClass.Items.AddRange(couchClass.ToArray());
            }

            catch (Exception exception) { }
        }
        private void PopulateNoOfSeat()
        {
            try
            {
                List<string> noOfSeat = new List<string>();
                int counter = 1;
                while (counter < 11)
                {
                    noOfSeat.Add(counter.ToString());
                    counter++;
                }
                this.cmbNoOfSeat.Items.AddRange(noOfSeat.ToArray());
            }

            catch (Exception exception) { }
        }
        private void PopulateAvailableSeat(int trainID,string availableSeat)
        {
            int seat = this.traininfo.getAvailableSeat(this.cmbFrom.SelectedItem.ToString(), this.cmbTo.SelectedItem.ToString(), this.cmbJourneyDate.SelectedItem.ToString(), this.cmbJourneyTime.SelectedItem.ToString(),this.cmbAvailableTrain.SelectedItem.ToString(),trainID,availableSeat);
            this.txtAvailableSeat.Text = seat.ToString();
            this.txtAvailableSeat.Visible = true;
            
        }
        private void PopulatePricePerSeat(int trainID,string price)
        {
            int pricePerSeat = this.traininfo.getPricePerSeat(this.cmbAvailableTrain.SelectedItem.ToString(), trainID, price);
            this.txtPricePerSeat.Text = pricePerSeat.ToString();
            this.txtPricePerSeat.Visible = true;
        }
        
        private void FairQuery_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

        private void CmbFrom_Leave(object sender, EventArgs e)
        {
            if (cmbFrom.Text.ToString().Length.Equals(0))
            {
                this.cmbFrom.Focus();
                this.errFrom.SetError(this.cmbFrom, "Please select the Journey From");
            }
            else
            {
                this.errFrom.Clear();
                this.PopulateJourneyTo();
            }
        }

        private void CmbFrom_SelectedIndexChanged(object sender, EventArgs e)
        {
            this.PopulateGridView("select trainno,traininfo.name,departurestation,journeydate,departuretime,arrivalstation,arrivaltime,routetype,capacity,bogey,standard,priceperstandard,standardavailableseat,economy,pricepereconomy,economyavailableseat,firstclass,priceperfirstclass,firstclassavailableseat,bogeyinfo from traininfo,journeytimeinfo where traininfo.trainid=journeytimeinfo.trainid and journeydatetime>SYSDATETIME() and traininfo.departurestation='" + this.cmbFrom.SelectedItem.ToString() + "'");
            this.cmbTo.Items.Clear();
            this.cmbJourneyDate.Items.Clear();
            this.cmbJourneyTime.Items.Clear();
            this.cmbAvailableTrain.Items.Clear();
            this.cmbClass.Items.Clear();
            this.cmbNoOfSeat.Items.Clear();
            this.txtAvailableSeat.Clear();
            this.txtPricePerSeat.Clear();
            this.txtBill.Clear();
            this.txtNetBill.Clear();
        }

        private void CmbTo_Leave(object sender, EventArgs e)
        {
            if (this.cmbFrom.SelectedItem == null)
            {
                this.cmbFrom.Focus();
                this.errFrom.SetError(this.cmbFrom, "Please select the Journey From");
                this.errTo.Clear();
            }
            else
            {
                if (this.cmbTo.Text.ToString().Length.Equals(0))
                {
                    this.cmbTo.Focus();
                    this.errTo.SetError(this.cmbTo, "Please select the Journey To");
                }
                else
                {
                    this.errTo.Clear();
                    this.PopulateJourneyDate();
                }
            }
            
        }
        

        private void BtnRefresh_Click(object sender, EventArgs e)
        {
            FareQuery fairQuery = new FareQuery(this.userinfo);
            fairQuery.Visible = true;
            this.Visible = false;
            
        }

        private void CmbTo_SelectedIndexChanged(object sender, EventArgs e)
        {
            this.PopulateGridView("select trainno,traininfo.name,departurestation,journeydate,departuretime,arrivalstation,arrivaltime,routetype,capacity,bogey,standard,priceperstandard,standardavailableseat,economy,pricepereconomy,economyavailableseat,firstclass,priceperfirstclass,firstclassavailableseat,bogeyinfo from traininfo,journeytimeinfo where traininfo.trainid=journeytimeinfo.trainid and journeydatetime>SYSDATETIME() and traininfo.departurestation='" + this.cmbFrom.SelectedItem.ToString() + "' and traininfo.arrivalstation='"+this.cmbTo.SelectedItem.ToString()+"'");

            this.cmbJourneyDate.Items.Clear();
            this.cmbJourneyTime.Items.Clear();
            this.cmbAvailableTrain.Items.Clear();
            this.cmbClass.Items.Clear();
            this.cmbNoOfSeat.Items.Clear();
            this.txtAvailableSeat.Clear();
            this.txtPricePerSeat.Clear();
            this.txtBill.Clear();
            this.txtNetBill.Clear();
            

        }

        private void CmbJourneyDate_SelectedIndexChanged(object sender, EventArgs e)
        {
            this.PopulateGridView("select trainno,traininfo.name,departurestation,journeydate,departuretime,arrivalstation,arrivaltime,routetype,capacity,bogey,standard,priceperstandard,standardavailableseat,economy,pricepereconomy,economyavailableseat,firstclass,priceperfirstclass,firstclassavailableseat,bogeyinfo from traininfo,journeytimeinfo where traininfo.trainid=journeytimeinfo.trainid and journeydatetime>SYSDATETIME() and traininfo.departurestation='" + this.cmbFrom.SelectedItem.ToString() + "' and traininfo.arrivalstation='" + this.cmbTo.SelectedItem.ToString() + "' and journeytimeinfo.journeydate='"+this.cmbJourneyDate.SelectedItem.ToString()+"'");

            this.cmbJourneyTime.Items.Clear();
            this.cmbAvailableTrain.Items.Clear();
            this.cmbClass.Items.Clear();
            this.cmbNoOfSeat.Items.Clear();
            this.txtAvailableSeat.Clear();
            this.txtPricePerSeat.Clear();
            this.txtBill.Clear();
            this.txtNetBill.Clear();
        }

        private void CmbJourneyTime_SelectedIndexChanged(object sender, EventArgs e)
        {
            this.PopulateGridView("select trainno,traininfo.name,departurestation,journeydate,departuretime,arrivalstation,arrivaltime,routetype,capacity,bogey,standard,priceperstandard,standardavailableseat,economy,pricepereconomy,economyavailableseat,firstclass,priceperfirstclass,firstclassavailableseat,bogeyinfo from traininfo,journeytimeinfo where traininfo.trainid=journeytimeinfo.trainid and journeydatetime>SYSDATETIME() and traininfo.departurestation='" + this.cmbFrom.SelectedItem.ToString() + "' and traininfo.arrivalstation='" + this.cmbTo.SelectedItem.ToString() + "' and journeytimeinfo.journeydate='" + this.cmbJourneyDate.SelectedItem.ToString() + "' and journeytimeinfo.journeytime='"+this.cmbJourneyTime.SelectedItem.ToString()+"'");

            this.cmbAvailableTrain.Items.Clear();
            this.cmbClass.Items.Clear();
            this.cmbNoOfSeat.Items.Clear();
            this.txtAvailableSeat.Clear();
            this.txtPricePerSeat.Clear();
            this.txtBill.Clear();
            this.txtNetBill.Clear();
        }

        private void CmbAvailableTrain_SelectedIndexChanged(object sender, EventArgs e)
        {
            string trainName = this.cmbAvailableTrain.SelectedItem.ToString();
            if(this.traininfo.GetTrainID(this.cmbFrom.SelectedItem.ToString(), this.cmbTo.SelectedItem.ToString(), this.cmbJourneyDate.SelectedItem.ToString(), this.cmbJourneyTime.SelectedItem.ToString(), this.cmbAvailableTrain.SelectedItem.ToString())!=0)
            {
                this.trainID = this.traininfo.GetTrainID(this.cmbFrom.SelectedItem.ToString(), this.cmbTo.SelectedItem.ToString(), this.cmbJourneyDate.SelectedItem.ToString(), this.cmbJourneyTime.SelectedItem.ToString(), this.cmbAvailableTrain.SelectedItem.ToString());
            }
            this.PopulateGridView("select trainno,traininfo.name,departurestation,journeydate,departuretime,arrivalstation,arrivaltime,routetype,capacity,bogey,standard,priceperstandard,standardavailableseat,economy,pricepereconomy,economyavailableseat,firstclass,priceperfirstclass,firstclassavailableseat,bogeyinfo from traininfo,journeytimeinfo where traininfo.trainid=journeytimeinfo.trainid and journeydatetime>SYSDATETIME() and traininfo.departurestation='" + this.cmbFrom.SelectedItem.ToString() + "' and traininfo.arrivalstation='" + this.cmbTo.SelectedItem.ToString() + "' and journeytimeinfo.journeydate='" + this.cmbJourneyDate.SelectedItem.ToString() + "' and journeytimeinfo.journeytime='" + this.cmbJourneyTime.SelectedItem.ToString() + "' and traininfo.name='"+this.cmbAvailableTrain.SelectedItem.ToString()+ "' and traininfo.trainid='"+this.trainID+"'");

            this.cmbClass.Items.Clear();
            this.cmbNoOfSeat.Items.Clear();
            this.txtAvailableSeat.Clear();
            this.txtPricePerSeat.Clear();
            this.txtBill.Clear();
            this.txtNetBill.Clear();
        }

        private void CmbClass_SelectedIndexChanged(object sender, EventArgs e)
        {

            this.cmbNoOfSeat.Items.Clear();
            ////this.txtAvailableSeat.Clear();
            //this.txtPricePerSeat.Clear();
            this.txtBill.Clear();
            this.txtNetBill.Clear();
            
            if (this.cmbClass.SelectedItem.ToString().Equals("Economy (Non-AC Couch)"))
            {
                this.PopulateAvailableSeat(trainID, "economyavailableseat");
                this.PopulatePricePerSeat(trainID, "pricepereconomy");
            }
            else if (this.cmbClass.SelectedItem.ToString().Equals("Standard (AC Couch)"))
            {
                this.PopulateAvailableSeat(trainID, "standardavailableseat");
                this.PopulatePricePerSeat(trainID, "priceperstandard");
            }
            else if (this.cmbClass.SelectedItem.ToString().Equals("First Class (AC Cabin)"))
            {
                this.PopulateAvailableSeat(trainID, "firstclassavailableseat");
                this.PopulatePricePerSeat(this.trainID, "priceperfirstclass");
            }
        }

        private void CmbJourneyDate_Leave(object sender, EventArgs e)
        {
            if (this.cmbFrom.SelectedItem == null )
            {
                this.cmbFrom.Focus();
                this.errFrom.SetError(this.cmbFrom, "Please select the Journey From");
                this.errTo.Clear();
                this.errDate.Clear();
            }
            else if(this.cmbTo.SelectedItem == null)
            {
                this.cmbTo.Focus();
                this.errTo.SetError(this.cmbTo, "Please select the Journey To");
                this.errDate.Clear();
            }
            else
            {
                if (this.cmbJourneyDate.Text.ToString().Length.Equals(0))
                {
                    this.cmbJourneyDate.Focus();
                    this.errDate.SetError(this.cmbJourneyDate, "Please select the Journey Date");
                }
                else
                {
                    this.errDate.Clear();
                    this.PopulateJourneyTime();
                }
            }
        }

        private void CmbJourneyTime_Leave(object sender, EventArgs e)
        {
            if (this.cmbFrom.SelectedItem == null)
            {
                this.cmbFrom.Focus();
                this.errFrom.SetError(this.cmbFrom, "Please select the Journey From");
                this.errTo.Clear();
                this.errDate.Clear();
                this.errTime.Clear();
            }
            else if (this.cmbTo.SelectedItem == null)
            {
                this.cmbTo.Focus();
                this.errTo.SetError(this.cmbTo, "Please select the Journey To");
                this.errDate.Clear();
                this.errTime.Clear();
            }
            else if (this.cmbJourneyDate.SelectedItem == null)
            {
                this.cmbJourneyDate.Focus();
                this.errDate.SetError(this.cmbJourneyDate, "Please select the Journey Date");
                this.errTime.Clear();
            }
            else
            {
                if (this.cmbJourneyTime.Text.ToString().Length.Equals(0))
                {
                    this.cmbJourneyTime.Focus();
                    this.errTime.SetError(this.cmbJourneyTime, "Please select the Journey Time");
                }
                else
                {
                    this.errTime.Clear();
                    this.PopulateAvailableTrain();
                }
            }
        }

        private void CmbAvailableTrain_Leave(object sender, EventArgs e)
        {
            if (this.cmbFrom.SelectedItem == null)
            {
                this.cmbFrom.Focus();
                this.errFrom.SetError(this.cmbFrom, "Please select the Journey From");
                this.errTo.Clear();
                this.errDate.Clear();
                this.errTime.Clear();
                this.errTrain.Clear();
            }
            else if (this.cmbTo.SelectedItem == null)
            {
                this.cmbTo.Focus();
                this.errTo.SetError(this.cmbTo, "Please select the Journey To");
                this.errDate.Clear();
                this.errTime.Clear();
                this.errTrain.Clear();
            }
            else if (this.cmbJourneyDate.SelectedItem == null)
            {
                this.cmbJourneyDate.Focus();
                this.errDate.SetError(this.cmbJourneyDate, "Please select the Journey Date");
                this.errTime.Clear();
                this.errTrain.Clear();
            }
            else if (this.cmbJourneyTime.SelectedItem == null)
            {
                this.cmbJourneyTime.Focus();
                this.errTime.SetError(this.cmbJourneyTime, "Please select the Journey Time");
                this.errTrain.Clear();
            }
            else
            {
                if (this.cmbAvailableTrain.Text.ToString().Length.Equals(0))
                {
                    this.cmbAvailableTrain.Focus();
                    this.errTrain.SetError(this.cmbAvailableTrain, "Please select Any Train");
                }
                else
                {
                    this.errTrain.Clear();
                    this.PopulateClass();
                }
            }
        }

        private void CmbClass_Leave(object sender, EventArgs e)
        {
            if (this.cmbFrom.SelectedItem == null)
            {
                this.cmbFrom.Focus();
                this.errFrom.SetError(this.cmbFrom, "Please select the Journey From");
                this.errTo.Clear();
                this.errDate.Clear();
                this.errTime.Clear();
                this.errTrain.Clear();
                this.errClass.Clear();
            }
            else if (this.cmbTo.SelectedItem == null)
            {
                this.cmbTo.Focus();
                this.errTo.SetError(this.cmbTo, "Please select the Journey To");
                this.errDate.Clear();
                this.errTime.Clear();
                this.errTrain.Clear();
                this.errClass.Clear();
            }
            else if (this.cmbJourneyDate.SelectedItem == null)
            {
                this.cmbJourneyDate.Focus();
                this.errDate.SetError(this.cmbJourneyDate, "Please select the Journey Date");
                this.errTime.Clear();
                this.errTrain.Clear();
                this.errClass.Clear();
            }
            else if (this.cmbJourneyTime.SelectedItem == null)
            {
                this.cmbJourneyTime.Focus();
                this.errTime.SetError(this.cmbJourneyTime, "Please select the Journey Time");
                this.errTrain.Clear();
                this.errClass.Clear();
            }
            else if (this.cmbAvailableTrain.SelectedItem == null)
            {
                this.cmbAvailableTrain.Focus();
                this.errTrain.SetError(this.cmbAvailableTrain, "Please select any train");
                this.errClass.Clear();
            }
            else
            {
                if (this.cmbClass.Text.ToString().Length.Equals(0))
                {
                    this.cmbClass.Focus();
                    this.errClass.SetError(this.cmbClass, "Please select Any Couch Type");
                }
                else
                {
                    this.errClass.Clear();
                    this.PopulateNoOfSeat();
                }
            }
            
        }

        private void CmbNoOfSeat_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                double bill = Convert.ToDouble(this.cmbNoOfSeat.SelectedItem.ToString()) * Convert.ToDouble(this.txtPricePerSeat.Text.ToString());
                this.txtBill.Text = bill.ToString();
                double netBill = bill + bill * Convert.ToDouble(Convert.ToDouble(this.txtVat.Text.ToString()) / 100);
                this.txtNetBill.Text = netBill.ToString();
            }

            catch (Exception exception) { }
        }

        private void TxtSearch_TextChanged(object sender, EventArgs e)
        {
            string name = this.txtSearch.Text.ToString();
            this.PopulateGridView("select trainno,traininfo.name,departurestation,journeydate,departuretime,arrivalstation,arrivaltime,routetype,capacity,bogey,standard,priceperstandard,standardavailableseat,economy,pricepereconomy,economyavailableseat,firstclass,priceperfirstclass,firstclassavailableseat,bogeyinfo from traininfo,journeytimeinfo where traininfo.trainid=journeytimeinfo.trainid and journeydatetime>SYSDATETIME() and (traininfo.name like '" + name + "%' or traininfo.name like '%" + name + "' or traininfo.name like'%" + name + "%'or traininfo.departurestation like '" + name + "%' or traininfo.departurestation like '%" + name + "' or traininfo.departurestation like'%" + name + "%' or traininfo.arrivalstation like '" + name + "%' or traininfo.arrivalstation like '%" + name + "' or traininfo.arrivalstation like'%" + name + "%');") ;
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

        private void RefreshToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.RefreshMethod();
        }
        private void RefreshMethod()
        {
            FareQuery fareQuery = new FareQuery(this.userinfo);
            fareQuery.Visible = true;
            this.Visible = false;

        }

        private void RefreshToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            this.RefreshMethod();
        }

        private void FareQuery_Load(object sender, EventArgs e)
        {

        }
    }
}
