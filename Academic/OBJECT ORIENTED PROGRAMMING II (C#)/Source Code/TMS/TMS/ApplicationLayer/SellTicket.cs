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
    public partial class SellTicket : Form
    {
        List<string> PassengerEmailList;
        private List<int> trainid = new List<int>();
        private int trainID;
        private TrainRepo traininfo;
        private Employee employee;
        private List<string> journeyFrom = new List<string>();
        private List<string> journeyTo = new List<string>();
        
        private int journeyTimeID;
        internal SellTicket(Employee employee)
        {
            InitializeComponent();
            this.employee = employee;
            traininfo = new TrainRepo();
            this.PopulateJourneyFrom();
            this.PopulateGridView("select journeytimeinfo.journeytimeid,trainno,traininfo.name,departurestation,journeydate,departuretime,arrivalstation,arrivaltime,routetype,capacity,bogey,standard,priceperstandard,standardavailableseat,economy,pricepereconomy,economyavailableseat,firstclass,priceperfirstclass,firstclassavailableseat,bogeyinfo from traininfo,journeytimeinfo where traininfo.trainid=journeytimeinfo.trainid and journeydatetime>SYSDATETIME()");
            
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
            if (journeyTo != null)
            {
                this.cmbTo.Items.AddRange(journeyTo.ToArray());
            }
        }
        private void PopulateJourneyFrom()
        {
            this.cmbFrom.Focus();
            this.journeyFrom = this.traininfo.getJourneyFrom();
            if (journeyFrom != null)
            {
                this.cmbFrom.Items.AddRange(journeyFrom.ToArray());
            }
            lblAvailableSeatResult.Visible = false;


        }
        private void PopulateJourneyDate()
        {
            if (this.traininfo.getJourneyDate(this.cmbFrom.SelectedItem.ToString(), this.cmbTo.SelectedItem.ToString()) != null)
            {
                this.cmbJourneyDate.Items.AddRange(this.traininfo.getJourneyDate(this.cmbFrom.SelectedItem.ToString(), this.cmbTo.SelectedItem.ToString()).ToArray());
            }
        }
        private void PopulateJourneyTime()
        {
            if (this.traininfo.getJourneyTime(this.cmbFrom.SelectedItem.ToString(), this.cmbTo.SelectedItem.ToString(), this.cmbJourneyDate.SelectedItem.ToString()) != null)
            {
                this.cmbJourneyTime.Items.AddRange(this.traininfo.getJourneyTime(this.cmbFrom.SelectedItem.ToString(), this.cmbTo.SelectedItem.ToString(), this.cmbJourneyDate.SelectedItem.ToString()).ToArray());
            }
        }
        private void PopulateAvailableTrain()
        {

            if (this.traininfo.getAvailableTrain(this.cmbFrom.SelectedItem.ToString(), this.cmbTo.SelectedItem.ToString(), this.cmbJourneyDate.SelectedItem.ToString(), this.cmbJourneyTime.SelectedItem.ToString()) != null)
            {
                this.cmbAvailableTrain.Items.AddRange(this.traininfo.getAvailableTrain(this.cmbFrom.SelectedItem.ToString(), this.cmbTo.SelectedItem.ToString(), this.cmbJourneyDate.SelectedItem.ToString(), this.cmbJourneyTime.SelectedItem.ToString()).ToArray());

            }
        }
        private void PopulateClass()
        {
            List<string> couchClass = new List<string>();
            couchClass.Add("Economy (Non-AC Couch)");
            couchClass.Add("Standard (AC Couch)");
            couchClass.Add("First Class (AC Cabin)");
            this.cmbClass.Items.AddRange(couchClass.ToArray());
        }
        private void PopulateNoOfSeat()
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
        private void PopulateAvailableSeat(int trainID, string availableSeat)
        {
            int seat = this.traininfo.getAvailableSeat(this.cmbFrom.SelectedItem.ToString(), this.cmbTo.SelectedItem.ToString(), this.cmbJourneyDate.SelectedItem.ToString(), this.cmbJourneyTime.SelectedItem.ToString(), this.cmbAvailableTrain.SelectedItem.ToString(), trainID, availableSeat);
            this.txtAvailableSeat.Text = seat.ToString();
            this.txtAvailableSeat.Visible = true;

        }
        private void PopulatePricePerSeat(int trainID, string price)
        {
            int pricePerSeat = this.traininfo.getPricePerSeat(this.cmbAvailableTrain.SelectedItem.ToString(), trainID, price);
            this.txtPricePerSeat.Text = pricePerSeat.ToString();
            this.txtPricePerSeat.Visible = true;
        }

        private void SellTicket_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

        private void CmbFrom_SelectedIndexChanged(object sender, EventArgs e)
        {
            this.PopulateGridView("select journeytimeinfo.journeytimeid,trainno,traininfo.name,departurestation,journeydate,departuretime,arrivalstation,arrivaltime,routetype,capacity,bogey,standard,priceperstandard,standardavailableseat,economy,pricepereconomy,economyavailableseat,firstclass,priceperfirstclass,firstclassavailableseat,bogeyinfo from traininfo,journeytimeinfo where traininfo.trainid=journeytimeinfo.trainid and journeydatetime>SYSDATETIME() and traininfo.departurestation='" + this.cmbFrom.SelectedItem.ToString() + "'");
            this.cmbTo.Items.Clear();
            this.cmbJourneyDate.Items.Clear();
            this.cmbJourneyTime.Items.Clear();
            this.cmbAvailableTrain.Items.Clear();
            this.cmbPassengerEmail.Items.Clear();
            this.cmbClass.Items.Clear();
            this.cmbNoOfSeat.Items.Clear();
            this.txtAvailableSeat.Clear();
            this.txtPricePerSeat.Clear();
            this.txtBill.Clear();
            this.txtNetBill.Clear();
            this.txtCard.Enabled = false;
            this.txtCardNo.Enabled = false;
            this.txtCash.Enabled = false;
            this.txtChange.Enabled = false;

            this.cmbPayType.Items.Clear();
            this.txtCash.Clear();
            this.txtCard.Clear();
            this.txtChange.Clear();
            this.txtCardNo.Clear();
            this.txtCouchNo.Clear();
        }
        private void CmbFrom_Leave(object sender, EventArgs e)
        {
            if (cmbFrom.Text.ToString().Length.Equals(0))
            {
                this.cmbFrom.Focus();
                this.errFrom.SetError(this.cmbFrom, "Please select the Journey From");
               // this.btnSell.Visible = false;

            }
            else
            {
                //this.btnSell.Visible = true;
                this.errFrom.Clear();
                this.PopulateJourneyTo();
            }
        }

        private void CmbTo_Leave(object sender, EventArgs e)
        {
            if (this.cmbFrom.SelectedItem == null)
            {
                this.cmbFrom.Focus();
                this.errFrom.SetError(this.cmbFrom, "Please select the Journey From");
                this.errTo.Clear();
                //this.btnSell.Visible = false;
            }
            else
            {
                if (this.cmbTo.Text.ToString().Length.Equals(0))
                {
                    this.cmbTo.Focus();
                    this.errTo.SetError(this.cmbTo, "Please select the Journey To");
                    //this.btnSell.Visible = false;
                }
                else
                {
                    this.errTo.Clear();
                    this.PopulateJourneyDate();
                    //this.btnSell.Visible = true;
                }
            }

        }

        private void BtnRefresh_Click(object sender, EventArgs e)
        {
            this.RefreshMethod();
        }
        private void RefreshMethod()
        {
            SellTicket sellTicket = new SellTicket(this.employee);
            sellTicket.Visible = true;
            this.Visible = false;
        }
        private void CmbTo_SelectedIndexChanged(object sender, EventArgs e)
        {
            this.PopulateGridView("select journeytimeinfo.journeytimeid,trainno,traininfo.name,departurestation,journeydate,departuretime,arrivalstation,arrivaltime,routetype,capacity,bogey,standard,priceperstandard,standardavailableseat,economy,pricepereconomy,economyavailableseat,firstclass,priceperfirstclass,firstclassavailableseat,bogeyinfo from traininfo,journeytimeinfo where traininfo.trainid=journeytimeinfo.trainid and journeydatetime>SYSDATETIME() and traininfo.departurestation='" + this.cmbFrom.SelectedItem.ToString() + "' and traininfo.arrivalstation='" + this.cmbTo.SelectedItem.ToString() + "'");
            this.cmbPassengerEmail.Items.Clear();
            this.cmbJourneyDate.Items.Clear();
            this.cmbJourneyTime.Items.Clear();
            this.cmbAvailableTrain.Items.Clear();
            this.cmbClass.Items.Clear();
            this.cmbNoOfSeat.Items.Clear();
            this.txtAvailableSeat.Clear();
            this.txtPricePerSeat.Clear();
            this.txtBill.Clear();
            this.txtNetBill.Clear();
            this.txtCard.Enabled = false;
            this.txtCardNo.Enabled = false;
            this.txtCash.Enabled = false;
            this.txtChange.Enabled = false;
            this.cmbPayType.Items.Clear();
            this.txtCash.Clear();
            this.txtCard.Clear();
            this.txtChange.Clear();
            this.txtCardNo.Clear();
            this.txtCouchNo.Clear();

        }

        private void CmbJourneyDate_SelectedIndexChanged(object sender, EventArgs e)
        {
            this.PopulateGridView("select journeytimeinfo.journeytimeid,trainno,traininfo.name,departurestation,journeydate,departuretime,arrivalstation,arrivaltime,routetype,capacity,bogey,standard,priceperstandard,standardavailableseat,economy,pricepereconomy,economyavailableseat,firstclass,priceperfirstclass,firstclassavailableseat,bogeyinfo from traininfo,journeytimeinfo where traininfo.trainid=journeytimeinfo.trainid and journeydatetime>SYSDATETIME() and traininfo.departurestation='" + this.cmbFrom.SelectedItem.ToString() + "' and traininfo.arrivalstation='" + this.cmbTo.SelectedItem.ToString() + "' and journeytimeinfo.journeydate='" + this.cmbJourneyDate.SelectedItem.ToString() + "'");
            this.cmbPassengerEmail.Items.Clear();
            this.cmbJourneyTime.Items.Clear();
            this.cmbAvailableTrain.Items.Clear();
            this.cmbClass.Items.Clear();
            this.cmbNoOfSeat.Items.Clear();
            this.txtAvailableSeat.Clear();
            this.txtPricePerSeat.Clear();
            this.txtBill.Clear();
            this.txtNetBill.Clear();
            this.txtCard.Enabled = false;
            this.txtCardNo.Enabled = false;
            this.txtCash.Enabled = false;
            this.txtChange.Enabled = false;
            this.cmbPayType.Items.Clear();
            this.txtCash.Clear();
            this.txtCard.Clear();
            this.txtChange.Clear();
            this.txtCardNo.Clear();
            this.txtCouchNo.Clear();
        }

        private void CmbJourneyTime_SelectedIndexChanged(object sender, EventArgs e)
        {
            this.PopulateGridView("select journeytimeinfo.journeytimeid,trainno,traininfo.name,departurestation,journeydate,departuretime,arrivalstation,arrivaltime,routetype,capacity,bogey,standard,priceperstandard,standardavailableseat,economy,pricepereconomy,economyavailableseat,firstclass,priceperfirstclass,firstclassavailableseat,bogeyinfo from traininfo,journeytimeinfo where traininfo.trainid=journeytimeinfo.trainid and journeydatetime>SYSDATETIME() and traininfo.departurestation='" + this.cmbFrom.SelectedItem.ToString() + "' and traininfo.arrivalstation='" + this.cmbTo.SelectedItem.ToString() + "' and journeytimeinfo.journeydate='" + this.cmbJourneyDate.SelectedItem.ToString() + "' and journeytimeinfo.journeytime='" + this.cmbJourneyTime.SelectedItem.ToString() + "'");
            this.cmbPassengerEmail.Items.Clear();
            this.cmbAvailableTrain.Items.Clear();
            this.cmbClass.Items.Clear();
            this.cmbNoOfSeat.Items.Clear();
            this.txtAvailableSeat.Clear();
            this.txtPricePerSeat.Clear();
            this.txtBill.Clear();
            this.txtNetBill.Clear();
            this.txtCard.Enabled = false;
            this.txtCardNo.Enabled = false;
            this.txtCash.Enabled = false;
            this.txtChange.Enabled = false;
            this.cmbPayType.Items.Clear();
            this.txtCash.Clear();
            this.txtCard.Clear();
            this.txtChange.Clear();
            this.txtCardNo.Clear();
            this.txtCouchNo.Clear();
        }

        private void CmbAvailableTrain_SelectedIndexChanged(object sender, EventArgs e)
        {
            string trainName = this.cmbAvailableTrain.SelectedItem.ToString();
            if (this.traininfo.GetTrainID(this.cmbFrom.SelectedItem.ToString(), this.cmbTo.SelectedItem.ToString(), this.cmbJourneyDate.SelectedItem.ToString(), this.cmbJourneyTime.SelectedItem.ToString(), this.cmbAvailableTrain.SelectedItem.ToString()) != 0)
            {
                this.trainID = this.traininfo.GetTrainID(this.cmbFrom.SelectedItem.ToString(), this.cmbTo.SelectedItem.ToString(), this.cmbJourneyDate.SelectedItem.ToString(), this.cmbJourneyTime.SelectedItem.ToString(), this.cmbAvailableTrain.SelectedItem.ToString());
            }
            this.PopulateGridView("select journeytimeinfo.journeytimeid, trainno,traininfo.name,departurestation,journeydate,departuretime,arrivalstation,arrivaltime,routetype,capacity,bogey,standard,priceperstandard,standardavailableseat,economy,pricepereconomy,economyavailableseat,firstclass,priceperfirstclass,firstclassavailableseat,bogeyinfo from traininfo,journeytimeinfo where traininfo.trainid=journeytimeinfo.trainid and journeydatetime>SYSDATETIME() and traininfo.departurestation='" + this.cmbFrom.SelectedItem.ToString() + "' and traininfo.arrivalstation='" + this.cmbTo.SelectedItem.ToString() + "' and journeytimeinfo.journeydate='" + this.cmbJourneyDate.SelectedItem.ToString() + "' and journeytimeinfo.journeytime='" + this.cmbJourneyTime.SelectedItem.ToString() + "' and traininfo.name='" + this.cmbAvailableTrain.SelectedItem.ToString() + "' and traininfo.trainid='" + this.trainID + "'");
            this.cmbPassengerEmail.Items.Clear();
            this.cmbClass.Items.Clear();
            this.cmbNoOfSeat.Items.Clear();
            this.txtAvailableSeat.Clear();
            this.txtPricePerSeat.Clear();
            this.txtBill.Clear();
            this.txtNetBill.Clear();
            this.txtCard.Enabled = false;
            this.txtCardNo.Enabled = false;
            this.txtCash.Enabled = false;
            this.txtChange.Enabled = false;
            this.journeyTimeID = Convert.ToInt32(this.dgvTrainList.Rows[0].Cells["journeytimeid"].Value.ToString());
            this.cmbPayType.Items.Clear();
            this.txtCash.Clear();
            this.txtCard.Clear();
            this.txtChange.Clear();
            this.txtCardNo.Clear();
            this.txtCouchNo.Clear();
        }

        private void CmbClass_SelectedIndexChanged(object sender, EventArgs e)
        {
            this.cmbPayType.Items.Clear();
            this.txtCash.Clear();
            this.txtCard.Clear();
            this.txtChange.Clear();
            this.txtCardNo.Clear();
            this.txtCouchNo.Clear();
            this.txtCard.Enabled = false;
            this.txtCardNo.Enabled = false;
            this.txtCash.Enabled = false;
            this.txtChange.Enabled = false;
            this.cmbNoOfSeat.Items.Clear();
            ////this.txtAvailableSeat.Clear();
            //this.txtPricePerSeat.Clear();
            this.txtBill.Clear();
            this.txtNetBill.Clear();
            this.cmbPassengerEmail.Items.Clear();
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
            if (this.cmbFrom.SelectedItem == null)
            {
                this.cmbFrom.Focus();
                this.errFrom.SetError(this.cmbFrom, "Please select the Journey From");
                this.errTo.Clear();
                this.errDate.Clear();
                //this.btnSell.Visible = false;
            }
            else if (this.cmbTo.SelectedItem == null)
            {
                this.cmbTo.Focus();
                this.errTo.SetError(this.cmbTo, "Please select the Journey To");
                this.errDate.Clear();
                //this.btnSell.Visible = false;
            }
            else
            {
                if (this.cmbJourneyDate.Text.ToString().Length.Equals(0))
                {
                    this.cmbJourneyDate.Focus();
                    this.errDate.SetError(this.cmbJourneyDate, "Please select the Journey Date");
                    //this.btnSell.Visible = false;
                }
                else
                {
                    this.errDate.Clear();
                    this.PopulateJourneyTime();
                    //this.btnSell.Visible = true ;
                }
            }
        }

        private void CmbJourneyTime_Leave(object sender, EventArgs e)
        {
            if (this.cmbFrom.SelectedItem == null)
            {
                this.cmbFrom.Focus();
                this.btnSell.Visible = false;
                this.errFrom.SetError(this.cmbFrom, "Please select the Journey From");
                this.errTo.Clear();
                this.errDate.Clear();
                this.errTime.Clear();
            }
            else if (this.cmbTo.SelectedItem == null)
            {
                this.cmbTo.Focus();
                this.btnSell.Visible = false;
                this.errTo.SetError(this.cmbTo, "Please select the Journey To");
                this.errDate.Clear();
                this.errTime.Clear();
            }
            else if (this.cmbJourneyDate.SelectedItem == null)
            {
                this.cmbJourneyDate.Focus();
                this.btnSell.Visible = false;
                this.errDate.SetError(this.cmbJourneyDate, "Please select the Journey Date");
                this.errTime.Clear();
            }
            else
            {
                if (this.cmbJourneyTime.Text.ToString().Length.Equals(0))
                {
                    this.cmbJourneyTime.Focus();
                    this.btnSell.Visible = false;
                    this.errTime.SetError(this.cmbJourneyTime, "Please select the Journey Time");
                }
                else
                {
                    this.errTime.Clear();
                    this.PopulateAvailableTrain();
                    //this.btnSell.Visible = true;
                }
            }
        }

        private void CmbAvailableTrain_Leave(object sender, EventArgs e)
        {
            if (this.cmbFrom.SelectedItem == null)
            {
                this.cmbFrom.Focus();
                this.btnSell.Visible = false;
                this.errFrom.SetError(this.cmbFrom, "Please select the Journey From");
                this.errTo.Clear();
                this.errDate.Clear();
                this.errTime.Clear();
                this.errTrain.Clear();
            }
            else if (this.cmbTo.SelectedItem == null)
            {
                this.cmbTo.Focus();
                this.btnSell.Visible = false;
                this.errTo.SetError(this.cmbTo, "Please select the Journey To");
                this.errDate.Clear();
                this.errTime.Clear();
                this.errTrain.Clear();
            }
            else if (this.cmbJourneyDate.SelectedItem == null)
            {
                this.cmbJourneyDate.Focus();
                this.btnSell.Visible = false;
                this.errDate.SetError(this.cmbJourneyDate, "Please select the Journey Date");
                this.errTime.Clear();
                this.errTrain.Clear();
            }
            else if (this.cmbJourneyTime.SelectedItem == null)
            {
                this.cmbJourneyTime.Focus();
                this.btnSell.Visible = false;
                this.errTime.SetError(this.cmbJourneyTime, "Please select the Journey Time");
                this.errTrain.Clear();
            }
            else
            {
                if (this.cmbAvailableTrain.Text.ToString().Length.Equals(0))
                {
                    this.cmbAvailableTrain.Focus();
                    this.btnSell.Visible = false;
                    this.errTrain.SetError(this.cmbAvailableTrain, "Please select Any Train");
                }
                else
                {
                    this.errTrain.Clear();
                    this.PopulateClass();
                    //this.btnSell.Visible = true;
                }
            }
        }

        private void CmbClass_Leave(object sender, EventArgs e)
        {
            if (this.cmbFrom.SelectedItem == null)
            {
                this.cmbFrom.Focus();
                this.btnSell.Visible = false;
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
                this.btnSell.Visible = false;
                this.errTo.SetError(this.cmbTo, "Please select the Journey To");
                this.errDate.Clear();
                this.errTime.Clear();
                this.errTrain.Clear();
                this.errClass.Clear();
            }
            else if (this.cmbJourneyDate.SelectedItem == null)
            {
                this.cmbJourneyDate.Focus(); this.btnSell.Visible = false;
                this.errDate.SetError(this.cmbJourneyDate, "Please select the Journey Date");
                this.errTime.Clear();
                this.errTrain.Clear();
                this.errClass.Clear();
            }
            else if (this.cmbJourneyTime.SelectedItem == null)
            {
                this.cmbJourneyTime.Focus(); this.btnSell.Visible = false;
                this.errTime.SetError(this.cmbJourneyTime, "Please select the Journey Time");
                this.errTrain.Clear();
                this.errClass.Clear();
            }
            else if (this.cmbAvailableTrain.SelectedItem == null)
            {
                this.cmbAvailableTrain.Focus(); this.btnSell.Visible = false;
                this.errTrain.SetError(this.cmbAvailableTrain, "Please select any train");
                this.errClass.Clear();
            }
            else
            {
                if (this.cmbClass.Text.ToString().Length.Equals(0))
                {
                    this.cmbClass.Focus(); this.btnSell.Visible = false;
                    this.errClass.SetError(this.cmbClass, "Please select Any Couch Type");
                }
                else
                {
                    this.errClass.Clear();
                    this.PopulateNoOfSeat();
                    //this.GetPassengerEmailList();
                    //this.btnSell.Visible = true;
                }
            }
        }
        

        private void CmbNoOfSeat_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                this.cmbPayType.Items.Clear();
                this.txtCash.Clear();
                this.txtCard.Clear();
                this.txtChange.Clear();
                this.txtCardNo.Clear();
                this.txtCouchNo.Clear();
                this.cmbPassengerEmail.Items.Clear();
                if (Convert.ToInt32(this.txtAvailableSeat.Text.ToString()) != 0)
                {
                    double bill = Convert.ToInt32(this.cmbNoOfSeat.SelectedItem.ToString()) * Convert.ToDouble(this.txtPricePerSeat.Text.ToString());
                    this.txtBill.Text = bill.ToString();
                    double netBill = bill + bill * Convert.ToDouble(Convert.ToDouble(this.txtVat.Text.ToString()) / 100);
                    this.txtNetBill.Text = netBill.ToString();
                    int booked = 0;

                    int chosenSeat = Convert.ToInt32(this.cmbNoOfSeat.SelectedItem.ToString());
                    int standard = Convert.ToInt32(this.dgvTrainList.Rows[0].Cells["standard"].Value.ToString());
                    int economy = Convert.ToInt32(this.dgvTrainList.Rows[0].Cells["economy"].Value.ToString());
                    int firstclass = Convert.ToInt32(this.dgvTrainList.Rows[0].Cells["firstclass"].Value.ToString());
                    int firstclassavailableseat = Convert.ToInt32(this.dgvTrainList.Rows[0].Cells["firstclassavailableseat"].Value.ToString());
                    int standardavailableseat = Convert.ToInt32(this.dgvTrainList.Rows[0].Cells["standardavailableseat"].Value.ToString());
                    int economyavailableseat = Convert.ToInt32(this.dgvTrainList.Rows[0].Cells["economyavailableseat"].Value.ToString());
                    int capacity = Convert.ToInt32(this.dgvTrainList.Rows[0].Cells["capacity"].Value.ToString());

                    if (this.cmbClass.SelectedItem.ToString().Equals("Economy (Non-AC Couch)"))
                    {
                        if (economyavailableseat - chosenSeat >= 0)
                        {
                            string couchno = null;
                            booked = economy - economyavailableseat + firstclass + standard;
                            int counter = 1;
                            while (counter <= chosenSeat)
                            {
                                couchno = couchno + (booked + counter).ToString() + " , ";
                                counter++;
                            }
                            this.txtCouchNo.Text = couchno.ToString();
                        }
                        else
                        {
                            MessageBox.Show("Exceed Limit!");
                            this.btnSell.Visible = false;
                        }
                    }
                    else if (this.cmbClass.SelectedItem.ToString().Equals("Standard (AC Couch)"))
                    {
                        if (standardavailableseat - chosenSeat >= 0)
                        {
                            string couchno = null;
                            booked = standard - standardavailableseat + firstclass;
                            int counter = 1;
                            while (counter <= chosenSeat)
                            {
                                couchno = couchno + (booked + counter).ToString() + " , ";
                                counter++;
                            }
                            this.txtCouchNo.Text = couchno.ToString();
                        }
                        else
                        {
                            MessageBox.Show("Exceed Limit!");
                            this.btnSell.Visible = false;
                        }
                    }
                    else if (this.cmbClass.SelectedItem.ToString().Equals("First Class (AC Cabin)"))
                    {
                        if (firstclassavailableseat - chosenSeat >= 0)
                        {
                            string couchno = null;
                            booked = firstclass - firstclassavailableseat;
                            int counter = 1;
                            while (counter <= chosenSeat)
                            {
                                couchno = couchno + (booked + counter).ToString() + " , ";
                                counter++;
                            }
                            this.txtCouchNo.Text = couchno.ToString();
                        }
                        else
                        {
                            MessageBox.Show("Exceed Limit!");
                            this.btnSell.Visible = false;
                        }
                    }
                }
                else
                {
                    MessageBox.Show("There is no available seat here!");
                    this.btnSell.Visible = false;
                }

                this.txtCard.Enabled = false;
                this.txtCardNo.Enabled = false;
                this.txtCash.Enabled = false;
                this.txtChange.Enabled = false;

            }

            catch (Exception exception) { }
        }

        private void TxtSearch_TextChanged(object sender, EventArgs e)
        {
            string name = this.txtSearch.Text.ToString();
            this.PopulateGridView("select journeytimeinfo.journeytimeid,trainno,traininfo.name,departurestation,journeydate,departuretime,arrivalstation,arrivaltime,routetype,capacity,bogey,standard,priceperstandard,standardavailableseat,economy,pricepereconomy,economyavailableseat,firstclass,priceperfirstclass,firstclassavailableseat,bogeyinfo from traininfo,journeytimeinfo where traininfo.trainid=journeytimeinfo.trainid and journeydatetime>SYSDATETIME() and (traininfo.name like '" + name + "%' or traininfo.name like '%" + name + "' or traininfo.name like'%" + name + "%'or traininfo.departurestation like '" + name + "%' or traininfo.departurestation like '%" + name + "' or traininfo.departurestation like'%" + name + "%' or traininfo.arrivalstation like '" + name + "%' or traininfo.arrivalstation like '%" + name + "' or traininfo.arrivalstation like'%" + name + "%');");

        }

        private void BtnDashboard_Click(object sender, EventArgs e)
        {
            TicketSellerDashboardPage ticketSellerDashboardPage = new TicketSellerDashboardPage(this.employee);
            ticketSellerDashboardPage.Visible = true;
            this.Visible = false;
        }
        private bool IsPaymentValid()
        {
            try
            {
                if (this.cmbPayType.SelectedItem.ToString() == "Cash")
                {
                    if (this.txtCash.Text.ToString() != null && this.txtNetBill.Text.ToString() != null)
                    {
                        int change = (Convert.ToInt32(this.txtCash.Text.ToString()) - Convert.ToInt32(this.txtNetBill.Text.ToString()));
                        this.txtChange.Text = change.ToString();
                        if (change < 0)
                        {
                            return false;
                        }
                        else
                        {
                            return true;
                        }
                    }
                    else if (this.txtCash.Text.ToString() == null && this.txtNetBill.Text.ToString() != null)
                    {
                        int change = (0 - Convert.ToInt32(this.txtNetBill.Text.ToString()));
                        this.txtChange.Text = change.ToString();
                        if (change < 0)
                        {
                            return false;
                        }
                        else
                        {
                            return true;
                        }
                    }
                    else
                    {
                        return false;
                    }
                }
                else if (this.cmbPayType.SelectedItem.ToString() == "Card")
                { return true; }
                else
                { return false; }
            }
            catch (Exception exception)
            {

                MessageBox.Show("This Field Can not be empty");
                //this.txtCash.Text = "0";
                this.txtCash.Focus();
                this.errCash.SetError(this.txtCash, "Provide Input");
                return false;

            }
        }
        private void ComboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if(this.cmbPayType.SelectedItem.ToString()=="Cash")
            {
                this.txtCash.Focus();
                this.btnSell.Visible = false;
                this.txtCard.Text = "0";
                this.txtCardNo.Text = "--";
                this.txtCash.Text = "0";
                this.txtCard.Enabled = false;
                this.txtCardNo.Enabled = false;
                this.txtCash.Enabled = true;
                this.txtChange.Enabled = false;

            }
            else if(this.cmbPayType.SelectedItem.ToString() == "Card")
            {

                this.txtCash.Text = "0";
                this.txtChange.Text = "0";
                this.txtCardNo.Clear();
                this.txtCard.Enabled = false;
                this.txtCardNo.Enabled = true;
                this.txtCash.Enabled = false;
                this.txtChange.Enabled = false;
                this.txtCard.Text = this.txtNetBill.Text.ToString();
                this.btnSell.Visible = true;

            }
        }

        private void TxtCash_KeyPress(object sender, KeyPressEventArgs e)
        {

            if (!char.IsDigit(e.KeyChar) && e.KeyChar != 8)
            {
                e.Handled = true;
                this.btnSell.Visible = false;
                this.errCash.SetError(this.txtCash, "Please provide only digit");
            }
            else
            {
                this.errCash.Clear();
                this.btnSell.Visible = true;
            }


        }

        private void TxtCard_KeyPress(object sender, KeyPressEventArgs e)
        {
            //if (!char.IsDigit(e.KeyChar) && e.KeyChar != 8)
            //{
            //    e.Handled = true;
            //    this.btnSell.Visible = false;
            //    this.errCard.SetError(this.txtCard, "Please provide only digit");
            //}
            //else
            //{
            //    this.errCard.Clear();
            //    this.btnSell.Visible = true;
            //}
                
        }

        private void TxtChange_KeyPress(object sender, KeyPressEventArgs e)
        {
            //if (!char.IsDigit(e.KeyChar) && e.KeyChar != 8)
            //{
            //    e.Handled = true;
            //    this.btnSell.Visible = false;
            //    this.errChange.SetError(this.txtChange, "Please provide only digit");
            //}
            //else
            //{
            //    this.btnSell.Visible = true;
            //    this.errChange.Clear();
            //}
                
        }

        private void CmbPassengerEmail_SelectedIndexChanged(object sender, EventArgs e)
        {
            this.cmbPayType.Items.Clear();
            this.txtCash.Clear();
            this.txtCard.Clear();
            this.txtChange.Clear();
            this.txtCardNo.Clear();
            //this.txtCouchNo.Clear();
            if (!this.cmbPassengerEmail.SelectedItem.ToString().Equals("Anonymous"))
            {
                int amountofticket = 0;
                this.txtCard.Enabled = false;
                this.txtCardNo.Enabled = false;
                this.txtCash.Enabled = false;
                this.txtChange.Enabled = false;

                string query = "select sum(amountofticket) amountofticket from journeytimeinfo,soldticketinfo,passengerinfo where journeytimeinfo.journeytimeid= soldticketinfo.journeytimeid and soldticketinfo.passengeremail=passengerinfo.email and passengerinfo.email ='" + this.cmbPassengerEmail.SelectedItem.ToString() + "' and journeytimeinfo.journeydate='" + this.cmbJourneyDate.SelectedItem.ToString() + "';";
                try
                {

                    var dt = DataAccess.GetDataTable(query);
                    int counter = 0;
                    while (counter < dt.Rows.Count)
                    {
                        if (dt.Rows[counter]["amountofticket"].ToString() != null)
                        {
                            amountofticket = Convert.ToInt32(dt.Rows[counter]["amountofticket"].ToString());

                        }
                        counter++;
                    }

                }
                catch (Exception exception) { }
                if (amountofticket + Convert.ToInt32(this.cmbNoOfSeat.SelectedItem.ToString()) > 10)
                {
                    MessageBox.Show("This Passenger already exceed the limit, Request him/her to buy from another Journey Date");
                    this.btnSell.Visible = false;
                }
                else
                {
                    //this.btnSell.Visible = true;
                }
            }
        }

            private void GetPassengerEmailList()
        {
            this.PassengerEmailList = new List<string>();
            try
            {
                string query = "select passengerinfo.email from passengerinfo";
                var dt = DataAccess.GetDataTable(query);
                int counter = 0;
                while (counter < dt.Rows.Count)
                {
                    if (dt.Rows[counter]["email"].ToString() != null)
                    {
                        this.PassengerEmailList.Add(dt.Rows[counter]["email"].ToString());

                    }
                    counter++;
                }

            }
            catch (Exception exception) { }
            this.cmbPassengerEmail.Items.AddRange(this.PassengerEmailList.ToArray());

        }


       
        private void BtnSell_Click(object sender, EventArgs e)
        {
            try
            {
                if (this.IsPaymentValid() == false || Validation.IsPassengerEmailValid(this.PassengerEmailList, this.cmbPassengerEmail.SelectedItem.ToString()) == false || this.cmbFrom.Text.ToString().Length.Equals(0) || this.cmbTo.Text.ToString().Length.Equals(0) || this.cmbJourneyDate.Text.ToString().Length.Equals(0) || this.cmbJourneyTime.Text.ToString().Length.Equals(0) || this.cmbAvailableTrain.Text.ToString().Length.Equals(0) || this.cmbClass.Text.ToString().Length.Equals(0) || this.txtAvailableSeat.Text.ToString().Length.Equals(0) || this.txtPricePerSeat.Text.ToString().Length.Equals(0) || this.cmbNoOfSeat.Text.ToString().Length.Equals(0) || this.txtBill.Text.ToString().Length.Equals(0) || this.txtVat.Text.ToString().Length.Equals(0) || this.txtNetBill.Text.ToString().Length.Equals(0) || this.cmbPassengerEmail.Text.ToString().Length.Equals(0) || this.cmbPayType.Text.ToString().Length.Equals(0) || this.txtCash.Text.ToString().Length.Equals(0) || this.txtCard.Text.ToString().Length.Equals(0) || this.txtChange.Text.ToString().Length.Equals(0) || this.txtCouchNo.Text.ToString().Length.Equals(0))
                {
                    this.btnSell.Visible = false;
                    MessageBox.Show("Missing Info");
                }
                else
                {
                    int seat = Convert.ToInt32(this.txtAvailableSeat.Text.ToString()) - Convert.ToInt32(this.cmbNoOfSeat.SelectedItem.ToString());
                    if (this.cmbClass.SelectedItem.ToString().Equals("Economy (Non-AC Couch)"))
                    {
                        string query1 = "insert into soldticketinfo values (" + this.trainID + "," + this.journeyTimeID + ",'" + this.cmbPassengerEmail.SelectedItem.ToString() + "','" + this.employee.Email.ToString() + "','" + this.cmbClass.SelectedItem.ToString() + "'," + this.cmbNoOfSeat.SelectedItem.ToString() + "," + this.txtBill.Text.ToString() + "," + this.txtVat.Text.ToString() + "," + this.txtNetBill.Text.ToString() + ",'" + this.cmbPayType.SelectedItem.ToString() + "'," + this.txtCard.Text.ToString() + ",'" + this.txtCardNo.Text.ToString() + "'," + this.txtCash.Text.ToString() + "," + this.txtChange.Text.ToString() + ",'" + this.txtCouchNo.Text.ToString() + "',SYSDATETIME() );";
                        string query2 = "update journeytimeinfo set economyavailableseat=" + seat + " where journeytimeinfo.journeytimeid =" + this.journeyTimeID;
                        int count1 = DataAccess.ExecuteQuery(query1);
                        int count2 = DataAccess.ExecuteQuery(query2);
                        if (count1 > 0 && count2 > 0)
                        {
                            MessageBox.Show("Ticket Sold Confirmed");
                            this.RefreshMethod();
                        }
                        else { MessageBox.Show("Something Happened Bad,pls try again"); }
                    }
                    else if (this.cmbClass.SelectedItem.ToString().Equals("Standard (AC Couch)"))
                    {
                        string query1 = "insert into soldticketinfo values (" + this.trainID + "," + this.journeyTimeID + ",'" + this.cmbPassengerEmail.SelectedItem.ToString() + "','" + this.employee.Email.ToString() + "','" + this.cmbClass.SelectedItem.ToString() + "'," + this.cmbNoOfSeat.SelectedItem.ToString() + "," + this.txtBill.Text.ToString() + "," + this.txtVat.Text.ToString() + "," + this.txtNetBill.Text.ToString() + ",'" + this.cmbPayType.SelectedItem.ToString() + "'," + this.txtCard.Text.ToString() + ",'" + this.txtCardNo.Text.ToString() + "'," + this.txtCash.Text.ToString() + "," + this.txtChange.Text.ToString() + ",'" + this.txtCouchNo.Text.ToString() + "',SYSDATETIME() );";
                        string query2 = "update journeytimeinfo set standardavailableseat=" + seat + " where journeytimeinfo.journeytimeid =" + this.journeyTimeID;
                        int count1 = DataAccess.ExecuteQuery(query1);
                        int count2 = DataAccess.ExecuteQuery(query2);
                        if (count1 > 0 && count2 > 0)
                        {
                            MessageBox.Show("Ticket Sold Confirmed");
                            this.RefreshMethod();
                        }
                        else { MessageBox.Show("Something Happened Bad,pls try again"); }
                    }
                    else if (this.cmbClass.SelectedItem.ToString().Equals("First Class (AC Cabin)"))
                    {
                        string query1 = "insert into soldticketinfo values (" + this.trainID + "," + this.journeyTimeID + ",'" + this.cmbPassengerEmail.SelectedItem.ToString() + "','" + this.employee.Email.ToString() + "','" + this.cmbClass.SelectedItem.ToString() + "'," + this.cmbNoOfSeat.SelectedItem.ToString() + "," + this.txtBill.Text.ToString() + "," + this.txtVat.Text.ToString() + "," + this.txtNetBill.Text.ToString() + ",'" + this.cmbPayType.SelectedItem.ToString() + "'," + this.txtCard.Text.ToString() + ",'" + this.txtCardNo.Text.ToString() + "'," + this.txtCash.Text.ToString() + "," + this.txtChange.Text.ToString() + ",'" + this.txtCouchNo.Text.ToString() + "',SYSDATETIME() );";
                        string query2 = "update journeytimeinfo set firstclassavailableseat=" + seat + " where journeytimeinfo.journeytimeid =" + this.journeyTimeID;
                        int count1 = DataAccess.ExecuteQuery(query1);
                        int count2 = DataAccess.ExecuteQuery(query2);
                        if (count1 > 0 && count2 > 0)
                        {
                            MessageBox.Show("Ticket Sold Confirmed");
                            this.RefreshMethod();
                        }
                        else { MessageBox.Show("Something Happened Bad,pls try again"); }

                    }



                }

            }
            catch (Exception exception) { }
        
        }

        private void RefreshToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.RefreshMethod();
        }

        private void CmbNoOfSeat_Leave(object sender, EventArgs e)
        {
            if (this.cmbFrom.SelectedItem == null)
            {
                this.cmbFrom.Focus();
                this.btnSell.Visible = false;
                this.errFrom.SetError(this.cmbFrom, "Please select the Journey From");
                this.errTo.Clear();
                this.errDate.Clear();
                this.errTime.Clear();
                this.errTrain.Clear();
                this.errClass.Clear();
                this.errSeat.Clear();
            }
            else if (this.cmbTo.SelectedItem == null)
            {
                this.cmbTo.Focus();
                this.btnSell.Visible = false;
                this.errTo.SetError(this.cmbTo, "Please select the Journey To");
                this.errDate.Clear();
                this.errTime.Clear();
                this.errTrain.Clear();
                this.errClass.Clear();
                this.errSeat.Clear();
            }
            else if (this.cmbJourneyDate.SelectedItem == null)
            {
                this.cmbJourneyDate.Focus(); this.btnSell.Visible = false;
                this.errDate.SetError(this.cmbJourneyDate, "Please select the Journey Date");
                this.errTime.Clear();
                this.errTrain.Clear();
                this.errClass.Clear();
                this.errSeat.Clear();
            }
            else if (this.cmbJourneyTime.SelectedItem == null)
            {
                this.cmbJourneyTime.Focus(); this.btnSell.Visible = false;
                this.errTime.SetError(this.cmbJourneyTime, "Please select the Journey Time");
                this.errTrain.Clear();
                this.errClass.Clear(); this.errSeat.Clear();
            }
            else if (this.cmbAvailableTrain.SelectedItem == null)
            {
                this.cmbAvailableTrain.Focus(); this.btnSell.Visible = false;
                this.errTrain.SetError(this.cmbAvailableTrain, "Please select any train");
                this.errClass.Clear();
                this.errSeat.Clear();
            }
            else if (this.cmbClass.SelectedItem == null)
            {
                this.cmbClass.Focus();
                this.btnSell.Visible = false;
                this.errClass.SetError(this.cmbClass, "Please select any Couch Type");
                //this.errClass.Clear();
                this.errSeat.Clear();
            }
            else
            {
                if (this.cmbNoOfSeat.Text.ToString().Length.Equals(0))
                {
                    this.cmbNoOfSeat.Focus();
                    this.btnSell.Visible = false;
                    this.errSeat.SetError(this.cmbNoOfSeat, "Please select any amount of seat");
                }
                else
                {
                    this.errSeat.Clear();
                    
                    this.GetPassengerEmailList();
                    //this.btnSell.Visible = true;
                }
            }
        }
        private void CmbPassengerEmail_Leave(object sender, EventArgs e)
        {
            if (this.cmbFrom.SelectedItem == null)
            {
                this.cmbFrom.Focus();
                this.btnSell.Visible = false;
                this.errFrom.SetError(this.cmbFrom, "Please select the Journey From");
                this.errTo.Clear();
                this.errDate.Clear();
                this.errTime.Clear();
                this.errTrain.Clear();
                this.errClass.Clear();
                this.errSeat.Clear();
                this.errPayType.Clear();
                this.errEmail.Clear();

            }
            else if (this.cmbTo.SelectedItem == null)
            {
                this.cmbTo.Focus();
                this.btnSell.Visible = false;
                this.errTo.SetError(this.cmbTo, "Please select the Journey To");
                this.errDate.Clear();
                this.errTime.Clear();
                this.errTrain.Clear();
                this.errClass.Clear();
                this.errSeat.Clear();
                this.errPayType.Clear(); this.errEmail.Clear();
            }
            else if (this.cmbJourneyDate.SelectedItem == null)
            {
                this.cmbJourneyDate.Focus(); this.btnSell.Visible = false;
                this.errDate.SetError(this.cmbJourneyDate, "Please select the Journey Date");
                this.errTime.Clear();
                this.errTrain.Clear();
                this.errClass.Clear();
                this.errSeat.Clear();
                this.errPayType.Clear();
                this.errEmail.Clear();
            }
            else if (this.cmbJourneyTime.SelectedItem == null)
            {
                this.cmbJourneyTime.Focus(); this.btnSell.Visible = false;
                this.errTime.SetError(this.cmbJourneyTime, "Please select the Journey Time");
                this.errTrain.Clear();
                this.errClass.Clear(); this.errSeat.Clear(); this.errPayType.Clear(); this.errEmail.Clear();
            }
            else if (this.cmbAvailableTrain.SelectedItem == null)
            {
                this.cmbAvailableTrain.Focus(); this.btnSell.Visible = false;
                this.errTrain.SetError(this.cmbAvailableTrain, "Please select any train");
                this.errClass.Clear();
                this.errSeat.Clear(); this.errPayType.Clear(); this.errEmail.Clear();
            }
            else if (this.cmbClass.SelectedItem == null)
            {
                this.cmbClass.Focus();
                this.btnSell.Visible = false;
                this.errClass.SetError(this.cmbClass, "Please select any Couch Type");
                //this.errClass.Clear();
                this.errSeat.Clear(); this.errPayType.Clear(); this.errEmail.Clear();
            }
            else if (this.cmbNoOfSeat.SelectedItem == null)
            {
                this.cmbNoOfSeat.Focus();
                this.btnSell.Visible = false;
                this.errSeat.SetError(this.cmbNoOfSeat, "Please select any no of seat");
                //this.errClass.Clear();
                //this.errSeat.Clear();
                this.errPayType.Clear();
                this.errEmail.Clear();
            }
            else
            {
                if (this.cmbPassengerEmail.Text.ToString().Length.Equals(0))
                {
                    this.cmbPassengerEmail.Focus();
                    this.btnSell.Visible = false;
                    this.errEmail.SetError(this.cmbPassengerEmail, "Please select any passenger Email");
                }
                else
                {
                    this.errEmail.Clear();

                    this.PopulatePaymentType();
                    //this.btnSell.Visible = true;
                }
            }
        }
        private void PopulatePaymentType()
        {
            List<string> payType = new List<string>();
            payType.Add("Cash"); payType.Add("Card");
            this.cmbPayType.Items.AddRange(payType.ToArray());
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

        private void BtnSellHistory_Click(object sender, EventArgs e)
        {
            SellHistoryTicketSeller sellHistoryTicketSeller = new SellHistoryTicketSeller(this.employee);
            sellHistoryTicketSeller.Visible = true;
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

        private void BtnTrainInfo_Click(object sender, EventArgs e)
        {
            TrainInfoTicketSeller trainInfoTicketSeller = new TrainInfoTicketSeller(this.employee);
            trainInfoTicketSeller.Visible = true;
            this.Visible = false;
        }

        private void TxtCash_TextChanged(object sender, EventArgs e)
        {
            try
            {
                if (this.txtCash.Text.ToString() != null && this.txtNetBill.Text.ToString() != null)
                {
                    int change = (Convert.ToInt32(this.txtCash.Text.ToString()) - Convert.ToInt32(this.txtNetBill.Text.ToString()));
                    this.txtChange.Text = change.ToString();
                    if (change < 0)
                    {
                        this.btnSell.Visible = false;
                    }
                    else
                    {
                        this.btnSell.Visible = true;
                    }
                }
                else if (this.txtCash.Text.ToString() == null && this.txtNetBill.Text.ToString() != null)
                {
                    int change = (0 - Convert.ToInt32(this.txtNetBill.Text.ToString()));
                    this.txtChange.Text = change.ToString();
                    if (change < 0)
                    {
                        this.btnSell.Visible = false;
                    }
                    else
                    {
                        this.btnSell.Visible = true;
                    }
                }
                else
                {
                    this.btnSell.Visible = false;
                }
            }
            catch (Exception exception)
            {
                //MessageBox.Show("This Field Can not be empty");
                //this.txtCash.Text = "0";
                this.txtCash.Focus();
                this.errCash.SetError(this.txtCash, "Provide Input");
                this.btnSell.Visible = false;
            }
        }
    }
}
