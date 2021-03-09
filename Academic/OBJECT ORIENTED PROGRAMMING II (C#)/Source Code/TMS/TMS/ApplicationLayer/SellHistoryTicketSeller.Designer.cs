namespace TMS.ApplicationLayer
{
    partial class SellHistoryTicketSeller
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SellHistoryTicketSeller));
            this.panel1 = new System.Windows.Forms.Panel();
            this.dgvSellHistory = new MetroFramework.Controls.MetroGrid();
            this.soldticketid = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.issuedate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.name = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.trainno = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.couchno = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.departurestatio = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.journeydatetime = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.arrivalstation = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.arrivaltime = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.routetype = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.passengername = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.mobilenumber = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.email = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.address = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.employeename = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Couch = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.amountofticket = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.bill = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.vat = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.netbill = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.paytype = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.card = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cardnumber = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cash = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.change = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.bogeyinfo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cmsRefresh = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.refreshToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.txtSearch = new MetroFramework.Controls.MetroTextBox();
            this.pnlButtonList = new System.Windows.Forms.Panel();
            this.btnTrainInfo = new System.Windows.Forms.Button();
            this.pnlUserControlList = new System.Windows.Forms.Panel();
            this.btnExit = new System.Windows.Forms.Button();
            this.btnSignOut = new System.Windows.Forms.Button();
            this.btnUserProfile = new System.Windows.Forms.Button();
            this.btnSellHistory = new System.Windows.Forms.Button();
            this.btnSellTicket = new System.Windows.Forms.Button();
            this.btnDashboard = new System.Windows.Forms.Button();
            this.pnlSearch = new System.Windows.Forms.Panel();
            this.lblIssueDate = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.lblProfit = new System.Windows.Forms.Label();
            this.btnSearch = new System.Windows.Forms.Button();
            this.lblTo = new System.Windows.Forms.Label();
            this.dtpTO = new System.Windows.Forms.DateTimePicker();
            this.lblFrom = new System.Windows.Forms.Label();
            this.dtpFrom = new System.Windows.Forms.DateTimePicker();
            this.pnlComplain = new System.Windows.Forms.Panel();
            this.lblComm = new System.Windows.Forms.Label();
            this.lblSell = new System.Windows.Forms.Label();
            this.lbldiscount = new System.Windows.Forms.Label();
            this.lbltotal = new System.Windows.Forms.Label();
            this.lblComlain = new System.Windows.Forms.Label();
            this.lblSold = new System.Windows.Forms.Label();
            this.lblCommission = new System.Windows.Forms.Label();
            this.lblTotalSell = new System.Windows.Forms.Label();
            this.lblTotallCommission = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvSellHistory)).BeginInit();
            this.cmsRefresh.SuspendLayout();
            this.pnlButtonList.SuspendLayout();
            this.pnlSearch.SuspendLayout();
            this.pnlComplain.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.dgvSellHistory);
            this.panel1.Controls.Add(this.txtSearch);
            this.panel1.Location = new System.Drawing.Point(161, 174);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(997, 414);
            this.panel1.TabIndex = 5;
            // 
            // dgvSellHistory
            // 
            this.dgvSellHistory.AllowUserToAddRows = false;
            this.dgvSellHistory.AllowUserToDeleteRows = false;
            this.dgvSellHistory.AllowUserToResizeRows = false;
            this.dgvSellHistory.BackgroundColor = System.Drawing.Color.DarkGray;
            this.dgvSellHistory.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgvSellHistory.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            this.dgvSellHistory.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(174)))), ((int)(((byte)(219)))));
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(198)))), ((int)(((byte)(247)))));
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvSellHistory.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvSellHistory.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvSellHistory.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.soldticketid,
            this.issuedate,
            this.name,
            this.trainno,
            this.couchno,
            this.departurestatio,
            this.journeydatetime,
            this.arrivalstation,
            this.arrivaltime,
            this.routetype,
            this.passengername,
            this.mobilenumber,
            this.email,
            this.address,
            this.employeename,
            this.Couch,
            this.amountofticket,
            this.bill,
            this.vat,
            this.netbill,
            this.paytype,
            this.card,
            this.cardnumber,
            this.cash,
            this.change,
            this.bogeyinfo});
            this.dgvSellHistory.ContextMenuStrip = this.cmsRefresh;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(136)))), ((int)(((byte)(136)))), ((int)(((byte)(136)))));
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(198)))), ((int)(((byte)(247)))));
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvSellHistory.DefaultCellStyle = dataGridViewCellStyle2;
            this.dgvSellHistory.EnableHeadersVisualStyles = false;
            this.dgvSellHistory.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.dgvSellHistory.GridColor = System.Drawing.Color.Black;
            this.dgvSellHistory.Location = new System.Drawing.Point(3, 50);
            this.dgvSellHistory.Name = "dgvSellHistory";
            this.dgvSellHistory.ReadOnly = true;
            this.dgvSellHistory.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(174)))), ((int)(((byte)(219)))));
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(198)))), ((int)(((byte)(247)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvSellHistory.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.dgvSellHistory.RowHeadersWidth = 51;
            this.dgvSellHistory.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.dgvSellHistory.RowTemplate.Height = 24;
            this.dgvSellHistory.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvSellHistory.Size = new System.Drawing.Size(978, 361);
            this.dgvSellHistory.TabIndex = 7;
            // 
            // soldticketid
            // 
            this.soldticketid.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.soldticketid.DataPropertyName = "soldticketid";
            this.soldticketid.FillWeight = 86.63101F;
            this.soldticketid.HeaderText = "Ticket ID";
            this.soldticketid.MinimumWidth = 100;
            this.soldticketid.Name = "soldticketid";
            this.soldticketid.ReadOnly = true;
            // 
            // issuedate
            // 
            this.issuedate.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.issuedate.DataPropertyName = "issuedate";
            this.issuedate.FillWeight = 86.63101F;
            this.issuedate.HeaderText = "Issuedate";
            this.issuedate.MinimumWidth = 200;
            this.issuedate.Name = "issuedate";
            this.issuedate.ReadOnly = true;
            // 
            // name
            // 
            this.name.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.name.DataPropertyName = "name";
            this.name.FillWeight = 86.63101F;
            this.name.HeaderText = "Train Name";
            this.name.MinimumWidth = 300;
            this.name.Name = "name";
            this.name.ReadOnly = true;
            // 
            // trainno
            // 
            this.trainno.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.trainno.DataPropertyName = "trainno";
            this.trainno.FillWeight = 86.63101F;
            this.trainno.HeaderText = "Train No";
            this.trainno.MinimumWidth = 100;
            this.trainno.Name = "trainno";
            this.trainno.ReadOnly = true;
            // 
            // couchno
            // 
            this.couchno.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.couchno.DataPropertyName = "couchno";
            this.couchno.FillWeight = 86.63101F;
            this.couchno.HeaderText = "Couch No";
            this.couchno.MinimumWidth = 300;
            this.couchno.Name = "couchno";
            this.couchno.ReadOnly = true;
            // 
            // departurestatio
            // 
            this.departurestatio.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.departurestatio.DataPropertyName = "departurestation";
            this.departurestatio.FillWeight = 86.63101F;
            this.departurestatio.HeaderText = "From";
            this.departurestatio.MinimumWidth = 300;
            this.departurestatio.Name = "departurestatio";
            this.departurestatio.ReadOnly = true;
            // 
            // journeydatetime
            // 
            this.journeydatetime.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.journeydatetime.DataPropertyName = "journeydatetime";
            this.journeydatetime.FillWeight = 86.63101F;
            this.journeydatetime.HeaderText = "Journey Date & Time";
            this.journeydatetime.MinimumWidth = 150;
            this.journeydatetime.Name = "journeydatetime";
            this.journeydatetime.ReadOnly = true;
            // 
            // arrivalstation
            // 
            this.arrivalstation.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.arrivalstation.DataPropertyName = "arrivalstation";
            this.arrivalstation.FillWeight = 86.63101F;
            this.arrivalstation.HeaderText = "To";
            this.arrivalstation.MinimumWidth = 300;
            this.arrivalstation.Name = "arrivalstation";
            this.arrivalstation.ReadOnly = true;
            // 
            // arrivaltime
            // 
            this.arrivaltime.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.arrivaltime.DataPropertyName = "arrivaltime";
            this.arrivaltime.FillWeight = 86.63101F;
            this.arrivaltime.HeaderText = "Arrival Time(Apprx.)";
            this.arrivaltime.MinimumWidth = 150;
            this.arrivaltime.Name = "arrivaltime";
            this.arrivaltime.ReadOnly = true;
            // 
            // routetype
            // 
            this.routetype.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.routetype.DataPropertyName = "routetype";
            this.routetype.FillWeight = 86.63101F;
            this.routetype.HeaderText = "Route Type";
            this.routetype.MinimumWidth = 300;
            this.routetype.Name = "routetype";
            this.routetype.ReadOnly = true;
            // 
            // passengername
            // 
            this.passengername.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.passengername.DataPropertyName = "passengername";
            this.passengername.FillWeight = 86.63101F;
            this.passengername.HeaderText = "Passenger Name";
            this.passengername.MinimumWidth = 150;
            this.passengername.Name = "passengername";
            this.passengername.ReadOnly = true;
            // 
            // mobilenumber
            // 
            this.mobilenumber.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.mobilenumber.DataPropertyName = "mobilenumber";
            this.mobilenumber.FillWeight = 86.63101F;
            this.mobilenumber.HeaderText = "Mobile Number";
            this.mobilenumber.MinimumWidth = 150;
            this.mobilenumber.Name = "mobilenumber";
            this.mobilenumber.ReadOnly = true;
            // 
            // email
            // 
            this.email.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.email.DataPropertyName = "email";
            this.email.FillWeight = 86.63101F;
            this.email.HeaderText = "Passenger Email";
            this.email.MinimumWidth = 150;
            this.email.Name = "email";
            this.email.ReadOnly = true;
            // 
            // address
            // 
            this.address.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.address.DataPropertyName = "address";
            this.address.FillWeight = 86.63101F;
            this.address.HeaderText = "Passenger Address";
            this.address.MinimumWidth = 300;
            this.address.Name = "address";
            this.address.ReadOnly = true;
            // 
            // employeename
            // 
            this.employeename.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.employeename.DataPropertyName = "employeename";
            this.employeename.FillWeight = 86.63101F;
            this.employeename.HeaderText = "Issued By";
            this.employeename.MinimumWidth = 150;
            this.employeename.Name = "employeename";
            this.employeename.ReadOnly = true;
            // 
            // Couch
            // 
            this.Couch.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Couch.DataPropertyName = "Couch";
            this.Couch.FillWeight = 86.63101F;
            this.Couch.HeaderText = "Couch Type";
            this.Couch.MinimumWidth = 150;
            this.Couch.Name = "Couch";
            this.Couch.ReadOnly = true;
            // 
            // amountofticket
            // 
            this.amountofticket.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.amountofticket.DataPropertyName = "amountofticket";
            this.amountofticket.FillWeight = 86.63101F;
            this.amountofticket.HeaderText = "Amount of Ticket";
            this.amountofticket.MinimumWidth = 100;
            this.amountofticket.Name = "amountofticket";
            this.amountofticket.ReadOnly = true;
            // 
            // bill
            // 
            this.bill.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.bill.DataPropertyName = "bill";
            this.bill.FillWeight = 86.63101F;
            this.bill.HeaderText = "Bill (BDT)";
            this.bill.MinimumWidth = 100;
            this.bill.Name = "bill";
            this.bill.ReadOnly = true;
            // 
            // vat
            // 
            this.vat.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.vat.DataPropertyName = "vat";
            this.vat.FillWeight = 86.63101F;
            this.vat.HeaderText = "Vat(%)";
            this.vat.MinimumWidth = 100;
            this.vat.Name = "vat";
            this.vat.ReadOnly = true;
            // 
            // netbill
            // 
            this.netbill.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.netbill.DataPropertyName = "netbill";
            this.netbill.FillWeight = 86.63101F;
            this.netbill.HeaderText = "Net Bill (BDT)";
            this.netbill.MinimumWidth = 100;
            this.netbill.Name = "netbill";
            this.netbill.ReadOnly = true;
            // 
            // paytype
            // 
            this.paytype.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.paytype.DataPropertyName = "paytype";
            this.paytype.FillWeight = 86.63101F;
            this.paytype.HeaderText = "Payment Type";
            this.paytype.MinimumWidth = 50;
            this.paytype.Name = "paytype";
            this.paytype.ReadOnly = true;
            // 
            // card
            // 
            this.card.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.card.DataPropertyName = "card";
            this.card.FillWeight = 86.63101F;
            this.card.HeaderText = "Card (BDT)";
            this.card.MinimumWidth = 50;
            this.card.Name = "card";
            this.card.ReadOnly = true;
            // 
            // cardnumber
            // 
            this.cardnumber.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.cardnumber.DataPropertyName = "cardnumber";
            this.cardnumber.FillWeight = 86.63101F;
            this.cardnumber.HeaderText = "Card Number";
            this.cardnumber.MinimumWidth = 300;
            this.cardnumber.Name = "cardnumber";
            this.cardnumber.ReadOnly = true;
            // 
            // cash
            // 
            this.cash.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.cash.DataPropertyName = "cash";
            this.cash.FillWeight = 86.63101F;
            this.cash.HeaderText = "Cash (BDT)";
            this.cash.MinimumWidth = 100;
            this.cash.Name = "cash";
            this.cash.ReadOnly = true;
            // 
            // change
            // 
            this.change.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.change.DataPropertyName = "change";
            this.change.FillWeight = 86.63101F;
            this.change.HeaderText = "Change (BDT)";
            this.change.MinimumWidth = 100;
            this.change.Name = "change";
            this.change.ReadOnly = true;
            // 
            // bogeyinfo
            // 
            this.bogeyinfo.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.bogeyinfo.DataPropertyName = "bogeyinfo";
            this.bogeyinfo.FillWeight = 447.5936F;
            this.bogeyinfo.HeaderText = "Bogey Info";
            this.bogeyinfo.MinimumWidth = 1100;
            this.bogeyinfo.Name = "bogeyinfo";
            this.bogeyinfo.ReadOnly = true;
            // 
            // cmsRefresh
            // 
            this.cmsRefresh.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.cmsRefresh.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.refreshToolStripMenuItem});
            this.cmsRefresh.Name = "contextMenuStrip1";
            this.cmsRefresh.Size = new System.Drawing.Size(128, 28);
            // 
            // refreshToolStripMenuItem
            // 
            this.refreshToolStripMenuItem.Name = "refreshToolStripMenuItem";
            this.refreshToolStripMenuItem.Size = new System.Drawing.Size(127, 24);
            this.refreshToolStripMenuItem.Text = "Refresh";
            this.refreshToolStripMenuItem.Click += new System.EventHandler(this.RefreshToolStripMenuItem_Click);
            // 
            // txtSearch
            // 
            // 
            // 
            // 
            this.txtSearch.CustomButton.Image = null;
            this.txtSearch.CustomButton.Location = new System.Drawing.Point(952, 1);
            this.txtSearch.CustomButton.Name = "";
            this.txtSearch.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.txtSearch.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txtSearch.CustomButton.TabIndex = 1;
            this.txtSearch.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txtSearch.CustomButton.UseSelectable = true;
            this.txtSearch.CustomButton.Visible = false;
            this.txtSearch.Lines = new string[0];
            this.txtSearch.Location = new System.Drawing.Point(7, 7);
            this.txtSearch.MaxLength = 32767;
            this.txtSearch.Name = "txtSearch";
            this.txtSearch.PasswordChar = '\0';
            this.txtSearch.PromptText = "Please search Sell History by Issuedate or Passenger Email";
            this.txtSearch.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtSearch.SelectedText = "";
            this.txtSearch.SelectionLength = 0;
            this.txtSearch.SelectionStart = 0;
            this.txtSearch.ShortcutsEnabled = true;
            this.txtSearch.Size = new System.Drawing.Size(974, 23);
            this.txtSearch.TabIndex = 8;
            this.txtSearch.UseSelectable = true;
            this.txtSearch.WaterMark = "Please search Sell History by Issuedate or Passenger Email";
            this.txtSearch.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txtSearch.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            this.txtSearch.TextChanged += new System.EventHandler(this.TxtSearch_TextChanged);
            this.txtSearch.Click += new System.EventHandler(this.TxtSearch_Click);
            // 
            // pnlButtonList
            // 
            this.pnlButtonList.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.pnlButtonList.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnlButtonList.Controls.Add(this.btnTrainInfo);
            this.pnlButtonList.Controls.Add(this.pnlUserControlList);
            this.pnlButtonList.Controls.Add(this.btnExit);
            this.pnlButtonList.Controls.Add(this.btnSignOut);
            this.pnlButtonList.Controls.Add(this.btnUserProfile);
            this.pnlButtonList.Controls.Add(this.btnSellHistory);
            this.pnlButtonList.Controls.Add(this.btnSellTicket);
            this.pnlButtonList.Controls.Add(this.btnDashboard);
            this.pnlButtonList.Location = new System.Drawing.Point(12, 18);
            this.pnlButtonList.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.pnlButtonList.Name = "pnlButtonList";
            this.pnlButtonList.Size = new System.Drawing.Size(147, 567);
            this.pnlButtonList.TabIndex = 10;
            // 
            // btnTrainInfo
            // 
            this.btnTrainInfo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.btnTrainInfo.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnTrainInfo.Location = new System.Drawing.Point(5, 251);
            this.btnTrainInfo.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnTrainInfo.Name = "btnTrainInfo";
            this.btnTrainInfo.Size = new System.Drawing.Size(140, 80);
            this.btnTrainInfo.TabIndex = 2;
            this.btnTrainInfo.Text = "Train Info";
            this.btnTrainInfo.UseVisualStyleBackColor = false;
            this.btnTrainInfo.Click += new System.EventHandler(this.BtnTrainInfo_Click);
            // 
            // pnlUserControlList
            // 
            this.pnlUserControlList.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.pnlUserControlList.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnlUserControlList.Location = new System.Drawing.Point(178, 2);
            this.pnlUserControlList.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.pnlUserControlList.Name = "pnlUserControlList";
            this.pnlUserControlList.Size = new System.Drawing.Size(830, 492);
            this.pnlUserControlList.TabIndex = 1;
            // 
            // btnExit
            // 
            this.btnExit.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.btnExit.Font = new System.Drawing.Font("Times New Roman", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnExit.Location = new System.Drawing.Point(2, 499);
            this.btnExit.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(140, 64);
            this.btnExit.TabIndex = 6;
            this.btnExit.Text = "Exit";
            this.btnExit.UseVisualStyleBackColor = false;
            this.btnExit.Click += new System.EventHandler(this.BtnExit_Click_1);
            // 
            // btnSignOut
            // 
            this.btnSignOut.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.btnSignOut.Font = new System.Drawing.Font("Times New Roman", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSignOut.Location = new System.Drawing.Point(2, 425);
            this.btnSignOut.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnSignOut.Name = "btnSignOut";
            this.btnSignOut.Size = new System.Drawing.Size(140, 69);
            this.btnSignOut.TabIndex = 5;
            this.btnSignOut.Text = "Sign Out";
            this.btnSignOut.UseVisualStyleBackColor = false;
            this.btnSignOut.Click += new System.EventHandler(this.BtnSignOut_Click_1);
            // 
            // btnUserProfile
            // 
            this.btnUserProfile.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.btnUserProfile.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnUserProfile.Location = new System.Drawing.Point(2, 335);
            this.btnUserProfile.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnUserProfile.Name = "btnUserProfile";
            this.btnUserProfile.Size = new System.Drawing.Size(140, 86);
            this.btnUserProfile.TabIndex = 4;
            this.btnUserProfile.Text = "Change Password";
            this.btnUserProfile.UseVisualStyleBackColor = false;
            this.btnUserProfile.Click += new System.EventHandler(this.BtnUserProfile_Click_1);
            // 
            // btnSellHistory
            // 
            this.btnSellHistory.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.btnSellHistory.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSellHistory.Location = new System.Drawing.Point(2, 162);
            this.btnSellHistory.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnSellHistory.Name = "btnSellHistory";
            this.btnSellHistory.Size = new System.Drawing.Size(140, 85);
            this.btnSellHistory.TabIndex = 3;
            this.btnSellHistory.Text = "Sell History";
            this.btnSellHistory.UseVisualStyleBackColor = false;
            this.btnSellHistory.Click += new System.EventHandler(this.BtnSellHistory_Click_1);
            // 
            // btnSellTicket
            // 
            this.btnSellTicket.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.btnSellTicket.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSellTicket.Location = new System.Drawing.Point(3, 79);
            this.btnSellTicket.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnSellTicket.Name = "btnSellTicket";
            this.btnSellTicket.Size = new System.Drawing.Size(140, 79);
            this.btnSellTicket.TabIndex = 1;
            this.btnSellTicket.Text = "Sell Ticket";
            this.btnSellTicket.UseVisualStyleBackColor = false;
            this.btnSellTicket.Click += new System.EventHandler(this.BtnSellTicket_Click);
            // 
            // btnDashboard
            // 
            this.btnDashboard.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.btnDashboard.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDashboard.Location = new System.Drawing.Point(3, 2);
            this.btnDashboard.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnDashboard.Name = "btnDashboard";
            this.btnDashboard.Size = new System.Drawing.Size(140, 73);
            this.btnDashboard.TabIndex = 0;
            this.btnDashboard.Text = "Dashboard";
            this.btnDashboard.UseVisualStyleBackColor = false;
            this.btnDashboard.Click += new System.EventHandler(this.BtnDashboard_Click_1);
            // 
            // pnlSearch
            // 
            this.pnlSearch.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnlSearch.ContextMenuStrip = this.cmsRefresh;
            this.pnlSearch.Controls.Add(this.lblIssueDate);
            this.pnlSearch.Controls.Add(this.button1);
            this.pnlSearch.Controls.Add(this.lblProfit);
            this.pnlSearch.Controls.Add(this.btnSearch);
            this.pnlSearch.Controls.Add(this.lblTo);
            this.pnlSearch.Controls.Add(this.dtpTO);
            this.pnlSearch.Controls.Add(this.lblFrom);
            this.pnlSearch.Controls.Add(this.dtpFrom);
            this.pnlSearch.Location = new System.Drawing.Point(168, 25);
            this.pnlSearch.Name = "pnlSearch";
            this.pnlSearch.Size = new System.Drawing.Size(521, 134);
            this.pnlSearch.TabIndex = 12;
            // 
            // lblIssueDate
            // 
            this.lblIssueDate.AutoSize = true;
            this.lblIssueDate.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblIssueDate.Location = new System.Drawing.Point(3, 0);
            this.lblIssueDate.Name = "lblIssueDate";
            this.lblIssueDate.Size = new System.Drawing.Size(115, 25);
            this.lblIssueDate.TabIndex = 24;
            this.lblIssueDate.Text = "Issue Date";
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.Violet;
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(350, 80);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(155, 32);
            this.button1.TabIndex = 10;
            this.button1.Text = "Refresh";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.Button1_Click);
            // 
            // lblProfit
            // 
            this.lblProfit.AutoSize = true;
            this.lblProfit.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblProfit.Location = new System.Drawing.Point(958, 54);
            this.lblProfit.Name = "lblProfit";
            this.lblProfit.Size = new System.Drawing.Size(0, 29);
            this.lblProfit.TabIndex = 23;
            // 
            // btnSearch
            // 
            this.btnSearch.BackColor = System.Drawing.Color.LightBlue;
            this.btnSearch.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSearch.Location = new System.Drawing.Point(350, 30);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(155, 36);
            this.btnSearch.TabIndex = 17;
            this.btnSearch.Text = "Search";
            this.btnSearch.UseVisualStyleBackColor = false;
            this.btnSearch.Click += new System.EventHandler(this.BtnSearch_Click);
            // 
            // lblTo
            // 
            this.lblTo.AutoSize = true;
            this.lblTo.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTo.Location = new System.Drawing.Point(3, 85);
            this.lblTo.Name = "lblTo";
            this.lblTo.Size = new System.Drawing.Size(38, 25);
            this.lblTo.TabIndex = 21;
            this.lblTo.Text = "To";
            // 
            // dtpTO
            // 
            this.dtpTO.CustomFormat = "yyyy-MM-dd hh:mm:ss";
            this.dtpTO.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpTO.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpTO.Location = new System.Drawing.Point(85, 85);
            this.dtpTO.MaxDate = new System.DateTime(2100, 1, 1, 0, 0, 0, 0);
            this.dtpTO.MinDate = new System.DateTime(2019, 8, 18, 0, 0, 0, 0);
            this.dtpTO.Name = "dtpTO";
            this.dtpTO.Size = new System.Drawing.Size(243, 27);
            this.dtpTO.TabIndex = 20;
            this.dtpTO.Value = new System.DateTime(2019, 9, 1, 0, 0, 0, 0);
            // 
            // lblFrom
            // 
            this.lblFrom.AutoSize = true;
            this.lblFrom.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFrom.Location = new System.Drawing.Point(3, 36);
            this.lblFrom.Name = "lblFrom";
            this.lblFrom.Size = new System.Drawing.Size(61, 25);
            this.lblFrom.TabIndex = 19;
            this.lblFrom.Text = "From";
            // 
            // dtpFrom
            // 
            this.dtpFrom.CustomFormat = "yyyy-MM-dd hh:mm:ss";
            this.dtpFrom.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpFrom.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpFrom.Location = new System.Drawing.Point(85, 34);
            this.dtpFrom.MaxDate = new System.DateTime(2100, 1, 1, 0, 0, 0, 0);
            this.dtpFrom.MinDate = new System.DateTime(2019, 8, 18, 0, 0, 0, 0);
            this.dtpFrom.Name = "dtpFrom";
            this.dtpFrom.Size = new System.Drawing.Size(243, 27);
            this.dtpFrom.TabIndex = 18;
            this.dtpFrom.Value = new System.DateTime(2019, 9, 1, 0, 0, 0, 0);
            // 
            // pnlComplain
            // 
            this.pnlComplain.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnlComplain.ContextMenuStrip = this.cmsRefresh;
            this.pnlComplain.Controls.Add(this.lblTotallCommission);
            this.pnlComplain.Controls.Add(this.lblTotalSell);
            this.pnlComplain.Controls.Add(this.lblComm);
            this.pnlComplain.Controls.Add(this.lblSell);
            this.pnlComplain.Controls.Add(this.lbldiscount);
            this.pnlComplain.Controls.Add(this.lbltotal);
            this.pnlComplain.Controls.Add(this.lblComlain);
            this.pnlComplain.Location = new System.Drawing.Point(695, 26);
            this.pnlComplain.Name = "pnlComplain";
            this.pnlComplain.Size = new System.Drawing.Size(463, 133);
            this.pnlComplain.TabIndex = 26;
            // 
            // lblComm
            // 
            this.lblComm.AutoSize = true;
            this.lblComm.ContextMenuStrip = this.cmsRefresh;
            this.lblComm.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblComm.Location = new System.Drawing.Point(12, 68);
            this.lblComm.Name = "lblComm";
            this.lblComm.Size = new System.Drawing.Size(186, 29);
            this.lblComm.TabIndex = 32;
            this.lblComm.Text = "Commission = ";
            // 
            // lblSell
            // 
            this.lblSell.AutoSize = true;
            this.lblSell.ContextMenuStrip = this.cmsRefresh;
            this.lblSell.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSell.Location = new System.Drawing.Point(12, 14);
            this.lblSell.Name = "lblSell";
            this.lblSell.Size = new System.Drawing.Size(88, 29);
            this.lblSell.TabIndex = 31;
            this.lblSell.Text = "Sell = ";
            // 
            // lbldiscount
            // 
            this.lbldiscount.AutoSize = true;
            this.lbldiscount.ContextMenuStrip = this.cmsRefresh;
            this.lbldiscount.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbldiscount.Location = new System.Drawing.Point(208, 71);
            this.lbldiscount.Name = "lbldiscount";
            this.lbldiscount.Size = new System.Drawing.Size(0, 25);
            this.lbldiscount.TabIndex = 30;
            // 
            // lbltotal
            // 
            this.lbltotal.AutoSize = true;
            this.lbltotal.ContextMenuStrip = this.cmsRefresh;
            this.lbltotal.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbltotal.Location = new System.Drawing.Point(114, 14);
            this.lbltotal.Name = "lbltotal";
            this.lbltotal.Size = new System.Drawing.Size(0, 29);
            this.lbltotal.TabIndex = 29;
            // 
            // lblComlain
            // 
            this.lblComlain.AutoSize = true;
            this.lblComlain.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblComlain.Location = new System.Drawing.Point(3, 13);
            this.lblComlain.Name = "lblComlain";
            this.lblComlain.Size = new System.Drawing.Size(0, 17);
            this.lblComlain.TabIndex = 26;
            this.lblComlain.Visible = false;
            // 
            // lblSold
            // 
            this.lblSold.Location = new System.Drawing.Point(0, 0);
            this.lblSold.Name = "lblSold";
            this.lblSold.Size = new System.Drawing.Size(100, 23);
            this.lblSold.TabIndex = 0;
            // 
            // lblCommission
            // 
            this.lblCommission.Location = new System.Drawing.Point(0, 0);
            this.lblCommission.Name = "lblCommission";
            this.lblCommission.Size = new System.Drawing.Size(100, 23);
            this.lblCommission.TabIndex = 0;
            // 
            // lblTotalSell
            // 
            this.lblTotalSell.AutoSize = true;
            this.lblTotalSell.ContextMenuStrip = this.cmsRefresh;
            this.lblTotalSell.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTotalSell.Location = new System.Drawing.Point(147, 14);
            this.lblTotalSell.Name = "lblTotalSell";
            this.lblTotalSell.Size = new System.Drawing.Size(27, 29);
            this.lblTotalSell.TabIndex = 33;
            this.lblTotalSell.Text = "0";
            // 
            // lblTotallCommission
            // 
            this.lblTotallCommission.AutoSize = true;
            this.lblTotallCommission.ContextMenuStrip = this.cmsRefresh;
            this.lblTotallCommission.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTotallCommission.Location = new System.Drawing.Point(226, 67);
            this.lblTotallCommission.Name = "lblTotallCommission";
            this.lblTotallCommission.Size = new System.Drawing.Size(27, 29);
            this.lblTotallCommission.TabIndex = 34;
            this.lblTotallCommission.Text = "0";
            // 
            // SellHistoryTicketSeller
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightSeaGreen;
            this.ClientSize = new System.Drawing.Size(1164, 593);
            this.Controls.Add(this.pnlComplain);
            this.Controls.Add(this.pnlSearch);
            this.Controls.Add(this.pnlButtonList);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "SellHistoryTicketSeller";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "My Sell History";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.SellHistoryTicketSeller_FormClosed);
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvSellHistory)).EndInit();
            this.cmsRefresh.ResumeLayout(false);
            this.pnlButtonList.ResumeLayout(false);
            this.pnlSearch.ResumeLayout(false);
            this.pnlSearch.PerformLayout();
            this.pnlComplain.ResumeLayout(false);
            this.pnlComplain.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Panel panel1;
        private MetroFramework.Controls.MetroGrid dgvSellHistory;
        private System.Windows.Forms.DataGridViewTextBoxColumn soldticketid;
        private System.Windows.Forms.DataGridViewTextBoxColumn issuedate;
        private System.Windows.Forms.DataGridViewTextBoxColumn name;
        private System.Windows.Forms.DataGridViewTextBoxColumn trainno;
        private System.Windows.Forms.DataGridViewTextBoxColumn couchno;
        private System.Windows.Forms.DataGridViewTextBoxColumn departurestatio;
        private System.Windows.Forms.DataGridViewTextBoxColumn journeydatetime;
        private System.Windows.Forms.DataGridViewTextBoxColumn arrivalstation;
        private System.Windows.Forms.DataGridViewTextBoxColumn arrivaltime;
        private System.Windows.Forms.DataGridViewTextBoxColumn routetype;
        private System.Windows.Forms.DataGridViewTextBoxColumn passengername;
        private System.Windows.Forms.DataGridViewTextBoxColumn mobilenumber;
        private System.Windows.Forms.DataGridViewTextBoxColumn email;
        private System.Windows.Forms.DataGridViewTextBoxColumn address;
        private System.Windows.Forms.DataGridViewTextBoxColumn employeename;
        private System.Windows.Forms.DataGridViewTextBoxColumn Couch;
        private System.Windows.Forms.DataGridViewTextBoxColumn amountofticket;
        private System.Windows.Forms.DataGridViewTextBoxColumn bill;
        private System.Windows.Forms.DataGridViewTextBoxColumn vat;
        private System.Windows.Forms.DataGridViewTextBoxColumn netbill;
        private System.Windows.Forms.DataGridViewTextBoxColumn paytype;
        private System.Windows.Forms.DataGridViewTextBoxColumn card;
        private System.Windows.Forms.DataGridViewTextBoxColumn cardnumber;
        private System.Windows.Forms.DataGridViewTextBoxColumn cash;
        private System.Windows.Forms.DataGridViewTextBoxColumn change;
        private System.Windows.Forms.DataGridViewTextBoxColumn bogeyinfo;
        private MetroFramework.Controls.MetroTextBox txtSearch;
        private System.Windows.Forms.ContextMenuStrip cmsRefresh;
        private System.Windows.Forms.ToolStripMenuItem refreshToolStripMenuItem;
        private System.Windows.Forms.Panel pnlButtonList;
        private System.Windows.Forms.Button btnTrainInfo;
        private System.Windows.Forms.Panel pnlUserControlList;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.Button btnSignOut;
        private System.Windows.Forms.Button btnUserProfile;
        private System.Windows.Forms.Button btnSellHistory;
        private System.Windows.Forms.Button btnSellTicket;
        private System.Windows.Forms.Button btnDashboard;
        private System.Windows.Forms.Panel pnlSearch;
        private System.Windows.Forms.Label lblIssueDate;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label lblProfit;
        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.Label lblTo;
        private System.Windows.Forms.DateTimePicker dtpTO;
        private System.Windows.Forms.Label lblFrom;
        private System.Windows.Forms.DateTimePicker dtpFrom;
        private System.Windows.Forms.Panel pnlComplain;
        private System.Windows.Forms.Label lblComlain;
        private System.Windows.Forms.Label lblSold;
        private System.Windows.Forms.Label lblCommission;
        private System.Windows.Forms.Label lbltotal;
        private System.Windows.Forms.Label lbldiscount;
        private System.Windows.Forms.Label lblComm;
        private System.Windows.Forms.Label lblSell;
        private System.Windows.Forms.Label lblTotalSell;
        private System.Windows.Forms.Label lblTotallCommission;
    }
}