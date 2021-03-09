namespace TMS.ApplicationLayer
{
    partial class SellAndFinanceHistory
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SellAndFinanceHistory));
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnRefresh = new System.Windows.Forms.Button();
            this.txtSearch = new MetroFramework.Controls.MetroTextBox();
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
            this.chkTrainNo = new System.Windows.Forms.CheckBox();
            this.chkIssueDate = new System.Windows.Forms.CheckBox();
            this.cmbTrainNo = new System.Windows.Forms.ComboBox();
            this.dtpFrom = new System.Windows.Forms.DateTimePicker();
            this.lblFrom = new System.Windows.Forms.Label();
            this.lblTo = new System.Windows.Forms.Label();
            this.dtpTO = new System.Windows.Forms.DateTimePicker();
            this.btnSearch = new System.Windows.Forms.Button();
            this.lblRevenue = new System.Windows.Forms.Label();
            this.lblProfit = new System.Windows.Forms.Label();
            this.pnlButtonList = new System.Windows.Forms.Panel();
            this.btnPassengersFeedback = new System.Windows.Forms.Button();
            this.btnFareInfo = new System.Windows.Forms.Button();
            this.btnEmployeeInfo = new System.Windows.Forms.Button();
            this.btnTrainInfo = new System.Windows.Forms.Button();
            this.pnlUserControlList = new System.Windows.Forms.Panel();
            this.btnExit = new System.Windows.Forms.Button();
            this.btnSignOut = new System.Windows.Forms.Button();
            this.btnUserProfile = new System.Windows.Forms.Button();
            this.btnSellHistory = new System.Windows.Forms.Button();
            this.btnDashboard = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvSellHistory)).BeginInit();
            this.cmsRefresh.SuspendLayout();
            this.pnlButtonList.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.btnRefresh);
            this.panel1.Controls.Add(this.txtSearch);
            this.panel1.Controls.Add(this.dgvSellHistory);
            this.panel1.Location = new System.Drawing.Point(162, 134);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1157, 499);
            this.panel1.TabIndex = 6;
            // 
            // btnRefresh
            // 
            this.btnRefresh.Location = new System.Drawing.Point(981, 4);
            this.btnRefresh.Name = "btnRefresh";
            this.btnRefresh.Size = new System.Drawing.Size(167, 23);
            this.btnRefresh.TabIndex = 9;
            this.btnRefresh.Text = "Refresh";
            this.btnRefresh.UseVisualStyleBackColor = true;
            this.btnRefresh.Click += new System.EventHandler(this.BtnRefresh_Click);
            // 
            // txtSearch
            // 
            // 
            // 
            // 
            this.txtSearch.CustomButton.Image = null;
            this.txtSearch.CustomButton.Location = new System.Drawing.Point(950, 1);
            this.txtSearch.CustomButton.Name = "";
            this.txtSearch.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.txtSearch.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txtSearch.CustomButton.TabIndex = 1;
            this.txtSearch.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txtSearch.CustomButton.UseSelectable = true;
            this.txtSearch.CustomButton.Visible = false;
            this.txtSearch.Lines = new string[0];
            this.txtSearch.Location = new System.Drawing.Point(3, 4);
            this.txtSearch.MaxLength = 32767;
            this.txtSearch.Name = "txtSearch";
            this.txtSearch.PasswordChar = '\0';
            this.txtSearch.PromptText = "Please search Sell History by Issuedate or Train No  or Employee Name or Employee" +
    " Email";
            this.txtSearch.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtSearch.SelectedText = "";
            this.txtSearch.SelectionLength = 0;
            this.txtSearch.SelectionStart = 0;
            this.txtSearch.ShortcutsEnabled = true;
            this.txtSearch.Size = new System.Drawing.Size(972, 23);
            this.txtSearch.TabIndex = 8;
            this.txtSearch.UseSelectable = true;
            this.txtSearch.WaterMark = "Please search Sell History by Issuedate or Train No  or Employee Name or Employee" +
    " Email";
            this.txtSearch.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txtSearch.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            this.txtSearch.TextChanged += new System.EventHandler(this.TxtSearch_TextChanged);
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
            this.dgvSellHistory.Location = new System.Drawing.Point(3, 33);
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
            this.dgvSellHistory.Size = new System.Drawing.Size(1151, 457);
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
            // chkTrainNo
            // 
            this.chkTrainNo.AutoSize = true;
            this.chkTrainNo.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chkTrainNo.Location = new System.Drawing.Point(174, 18);
            this.chkTrainNo.Name = "chkTrainNo";
            this.chkTrainNo.Size = new System.Drawing.Size(117, 29);
            this.chkTrainNo.TabIndex = 7;
            this.chkTrainNo.Text = "Train No";
            this.chkTrainNo.UseVisualStyleBackColor = true;
            // 
            // chkIssueDate
            // 
            this.chkIssueDate.AutoSize = true;
            this.chkIssueDate.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chkIssueDate.Location = new System.Drawing.Point(174, 62);
            this.chkIssueDate.Name = "chkIssueDate";
            this.chkIssueDate.Size = new System.Drawing.Size(137, 29);
            this.chkIssueDate.TabIndex = 8;
            this.chkIssueDate.Text = "Issue Date";
            this.chkIssueDate.UseVisualStyleBackColor = true;
            // 
            // cmbTrainNo
            // 
            this.cmbTrainNo.BackColor = System.Drawing.Color.Lavender;
            this.cmbTrainNo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbTrainNo.FormattingEnabled = true;
            this.cmbTrainNo.Location = new System.Drawing.Point(348, 18);
            this.cmbTrainNo.Name = "cmbTrainNo";
            this.cmbTrainNo.Size = new System.Drawing.Size(371, 24);
            this.cmbTrainNo.TabIndex = 9;
            // 
            // dtpFrom
            // 
            this.dtpFrom.CustomFormat = "yyyy-MM-dd hh:mm:ss";
            this.dtpFrom.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpFrom.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpFrom.Location = new System.Drawing.Point(430, 62);
            this.dtpFrom.MaxDate = new System.DateTime(2100, 1, 1, 0, 0, 0, 0);
            this.dtpFrom.MinDate = new System.DateTime(2019, 8, 18, 0, 0, 0, 0);
            this.dtpFrom.Name = "dtpFrom";
            this.dtpFrom.Size = new System.Drawing.Size(289, 27);
            this.dtpFrom.TabIndex = 10;
            this.dtpFrom.Value = new System.DateTime(2019, 9, 1, 0, 0, 0, 0);
            this.dtpFrom.ValueChanged += new System.EventHandler(this.DtpFrom_ValueChanged);
            // 
            // lblFrom
            // 
            this.lblFrom.AutoSize = true;
            this.lblFrom.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFrom.Location = new System.Drawing.Point(343, 64);
            this.lblFrom.Name = "lblFrom";
            this.lblFrom.Size = new System.Drawing.Size(61, 25);
            this.lblFrom.TabIndex = 11;
            this.lblFrom.Text = "From";
            // 
            // lblTo
            // 
            this.lblTo.AutoSize = true;
            this.lblTo.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTo.Location = new System.Drawing.Point(343, 104);
            this.lblTo.Name = "lblTo";
            this.lblTo.Size = new System.Drawing.Size(38, 25);
            this.lblTo.TabIndex = 13;
            this.lblTo.Text = "To";
            // 
            // dtpTO
            // 
            this.dtpTO.CustomFormat = "yyyy-MM-dd hh:mm:ss";
            this.dtpTO.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpTO.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpTO.Location = new System.Drawing.Point(430, 102);
            this.dtpTO.MaxDate = new System.DateTime(2100, 1, 1, 0, 0, 0, 0);
            this.dtpTO.MinDate = new System.DateTime(2019, 8, 18, 0, 0, 0, 0);
            this.dtpTO.Name = "dtpTO";
            this.dtpTO.Size = new System.Drawing.Size(289, 27);
            this.dtpTO.TabIndex = 12;
            this.dtpTO.Value = new System.DateTime(2019, 9, 1, 0, 0, 0, 0);
            // 
            // btnSearch
            // 
            this.btnSearch.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSearch.Location = new System.Drawing.Point(725, 18);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(167, 110);
            this.btnSearch.TabIndex = 10;
            this.btnSearch.Text = "Search";
            this.btnSearch.UseVisualStyleBackColor = true;
            this.btnSearch.Click += new System.EventHandler(this.BtnSearch_Click);
            // 
            // lblRevenue
            // 
            this.lblRevenue.AutoSize = true;
            this.lblRevenue.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblRevenue.Location = new System.Drawing.Point(909, 55);
            this.lblRevenue.Name = "lblRevenue";
            this.lblRevenue.Size = new System.Drawing.Size(205, 36);
            this.lblRevenue.TabIndex = 14;
            this.lblRevenue.Text = "REVENUE = ";
            // 
            // lblProfit
            // 
            this.lblProfit.AutoSize = true;
            this.lblProfit.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblProfit.Location = new System.Drawing.Point(1110, 58);
            this.lblProfit.Name = "lblProfit";
            this.lblProfit.Size = new System.Drawing.Size(0, 29);
            this.lblProfit.TabIndex = 15;
            // 
            // pnlButtonList
            // 
            this.pnlButtonList.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.pnlButtonList.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnlButtonList.Controls.Add(this.btnPassengersFeedback);
            this.pnlButtonList.Controls.Add(this.btnFareInfo);
            this.pnlButtonList.Controls.Add(this.btnEmployeeInfo);
            this.pnlButtonList.Controls.Add(this.btnTrainInfo);
            this.pnlButtonList.Controls.Add(this.pnlUserControlList);
            this.pnlButtonList.Controls.Add(this.btnExit);
            this.pnlButtonList.Controls.Add(this.btnSignOut);
            this.pnlButtonList.Controls.Add(this.btnUserProfile);
            this.pnlButtonList.Controls.Add(this.btnSellHistory);
            this.pnlButtonList.Controls.Add(this.btnDashboard);
            this.pnlButtonList.Location = new System.Drawing.Point(9, 14);
            this.pnlButtonList.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.pnlButtonList.Name = "pnlButtonList";
            this.pnlButtonList.Size = new System.Drawing.Size(147, 610);
            this.pnlButtonList.TabIndex = 16;
            // 
            // btnPassengersFeedback
            // 
            this.btnPassengersFeedback.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.btnPassengersFeedback.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPassengersFeedback.Location = new System.Drawing.Point(6, 71);
            this.btnPassengersFeedback.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnPassengersFeedback.Name = "btnPassengersFeedback";
            this.btnPassengersFeedback.Size = new System.Drawing.Size(140, 66);
            this.btnPassengersFeedback.TabIndex = 9;
            this.btnPassengersFeedback.Text = "Passengers Feedback";
            this.btnPassengersFeedback.UseVisualStyleBackColor = false;
            this.btnPassengersFeedback.Click += new System.EventHandler(this.BtnPassengersFeedback_Click);
            // 
            // btnFareInfo
            // 
            this.btnFareInfo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.btnFareInfo.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnFareInfo.Location = new System.Drawing.Point(6, 277);
            this.btnFareInfo.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnFareInfo.Name = "btnFareInfo";
            this.btnFareInfo.Size = new System.Drawing.Size(140, 66);
            this.btnFareInfo.TabIndex = 8;
            this.btnFareInfo.Text = "Fare Info";
            this.btnFareInfo.UseVisualStyleBackColor = false;
            this.btnFareInfo.Click += new System.EventHandler(this.BtnFareInfo_Click_1);
            // 
            // btnEmployeeInfo
            // 
            this.btnEmployeeInfo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.btnEmployeeInfo.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEmployeeInfo.Location = new System.Drawing.Point(6, 347);
            this.btnEmployeeInfo.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnEmployeeInfo.Name = "btnEmployeeInfo";
            this.btnEmployeeInfo.Size = new System.Drawing.Size(140, 66);
            this.btnEmployeeInfo.TabIndex = 7;
            this.btnEmployeeInfo.Text = "Employee Info";
            this.btnEmployeeInfo.UseVisualStyleBackColor = false;
            this.btnEmployeeInfo.Click += new System.EventHandler(this.BtnEmployeeInfo_Click_1);
            // 
            // btnTrainInfo
            // 
            this.btnTrainInfo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.btnTrainInfo.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnTrainInfo.Location = new System.Drawing.Point(6, 207);
            this.btnTrainInfo.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnTrainInfo.Name = "btnTrainInfo";
            this.btnTrainInfo.Size = new System.Drawing.Size(140, 66);
            this.btnTrainInfo.TabIndex = 2;
            this.btnTrainInfo.Text = "Train Info";
            this.btnTrainInfo.UseVisualStyleBackColor = false;
            this.btnTrainInfo.Click += new System.EventHandler(this.BtnTrainInfo_Click_1);
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
            this.btnExit.Location = new System.Drawing.Point(2, 551);
            this.btnExit.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(140, 55);
            this.btnExit.TabIndex = 6;
            this.btnExit.Text = "Exit";
            this.btnExit.UseVisualStyleBackColor = false;
            this.btnExit.Click += new System.EventHandler(this.BtnExit_Click_2);
            // 
            // btnSignOut
            // 
            this.btnSignOut.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.btnSignOut.Font = new System.Drawing.Font("Times New Roman", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSignOut.Location = new System.Drawing.Point(2, 487);
            this.btnSignOut.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnSignOut.Name = "btnSignOut";
            this.btnSignOut.Size = new System.Drawing.Size(140, 61);
            this.btnSignOut.TabIndex = 5;
            this.btnSignOut.Text = "Sign Out";
            this.btnSignOut.UseVisualStyleBackColor = false;
            this.btnSignOut.Click += new System.EventHandler(this.BtnSignOut_Click_1);
            // 
            // btnUserProfile
            // 
            this.btnUserProfile.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.btnUserProfile.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnUserProfile.Location = new System.Drawing.Point(3, 417);
            this.btnUserProfile.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnUserProfile.Name = "btnUserProfile";
            this.btnUserProfile.Size = new System.Drawing.Size(140, 66);
            this.btnUserProfile.TabIndex = 4;
            this.btnUserProfile.Text = "Change Password";
            this.btnUserProfile.UseVisualStyleBackColor = false;
            this.btnUserProfile.Click += new System.EventHandler(this.BtnUserProfile_Click_1);
            // 
            // btnSellHistory
            // 
            this.btnSellHistory.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.btnSellHistory.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSellHistory.Location = new System.Drawing.Point(6, 137);
            this.btnSellHistory.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnSellHistory.Name = "btnSellHistory";
            this.btnSellHistory.Size = new System.Drawing.Size(140, 66);
            this.btnSellHistory.TabIndex = 3;
            this.btnSellHistory.Text = "Sales and Revenue";
            this.btnSellHistory.UseVisualStyleBackColor = false;
            this.btnSellHistory.Click += new System.EventHandler(this.BtnSellHistory_Click_1);
            // 
            // btnDashboard
            // 
            this.btnDashboard.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.btnDashboard.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDashboard.Location = new System.Drawing.Point(6, 1);
            this.btnDashboard.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnDashboard.Name = "btnDashboard";
            this.btnDashboard.Size = new System.Drawing.Size(140, 66);
            this.btnDashboard.TabIndex = 0;
            this.btnDashboard.Text = "Dashboard";
            this.btnDashboard.UseVisualStyleBackColor = false;
            this.btnDashboard.Click += new System.EventHandler(this.BtnDashboard_Click_1);
            // 
            // SellAndFinanceHistory
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Teal;
            this.ClientSize = new System.Drawing.Size(1325, 645);
            this.ContextMenuStrip = this.cmsRefresh;
            this.Controls.Add(this.pnlButtonList);
            this.Controls.Add(this.lblProfit);
            this.Controls.Add(this.lblRevenue);
            this.Controls.Add(this.btnSearch);
            this.Controls.Add(this.lblTo);
            this.Controls.Add(this.dtpTO);
            this.Controls.Add(this.lblFrom);
            this.Controls.Add(this.dtpFrom);
            this.Controls.Add(this.cmbTrainNo);
            this.Controls.Add(this.chkIssueDate);
            this.Controls.Add(this.chkTrainNo);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "SellAndFinanceHistory";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Sell and Revenue";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.SellAndFinanceHistory_FormClosed);
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvSellHistory)).EndInit();
            this.cmsRefresh.ResumeLayout(false);
            this.pnlButtonList.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btnRefresh;
        private MetroFramework.Controls.MetroTextBox txtSearch;
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
        private System.Windows.Forms.CheckBox chkTrainNo;
        private System.Windows.Forms.CheckBox chkIssueDate;
        private System.Windows.Forms.ComboBox cmbTrainNo;
        private System.Windows.Forms.DateTimePicker dtpFrom;
        private System.Windows.Forms.Label lblFrom;
        private System.Windows.Forms.Label lblTo;
        private System.Windows.Forms.DateTimePicker dtpTO;
        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.Label lblRevenue;
        private System.Windows.Forms.Label lblProfit;
        private System.Windows.Forms.ContextMenuStrip cmsRefresh;
        private System.Windows.Forms.ToolStripMenuItem refreshToolStripMenuItem;
        private System.Windows.Forms.Panel pnlButtonList;
        private System.Windows.Forms.Button btnPassengersFeedback;
        private System.Windows.Forms.Button btnFareInfo;
        private System.Windows.Forms.Button btnEmployeeInfo;
        private System.Windows.Forms.Button btnTrainInfo;
        private System.Windows.Forms.Panel pnlUserControlList;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.Button btnSignOut;
        private System.Windows.Forms.Button btnUserProfile;
        private System.Windows.Forms.Button btnSellHistory;
        private System.Windows.Forms.Button btnDashboard;
    }
}