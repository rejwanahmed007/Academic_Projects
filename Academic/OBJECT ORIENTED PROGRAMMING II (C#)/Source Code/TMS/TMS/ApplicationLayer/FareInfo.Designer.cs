namespace TMS.ApplicationLayer
{
    partial class FareInfo
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FareInfo));
            this.pnlUpdateFareInfo = new System.Windows.Forms.Panel();
            this.cmsEditAndRefresh = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.refreshToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.btnRefresh = new System.Windows.Forms.Button();
            this.btnSave = new System.Windows.Forms.Button();
            this.dtpJourneyDate = new MetroFramework.Controls.MetroDateTime();
            this.cmbTrainID = new System.Windows.Forms.ComboBox();
            this.lblJourneyDate = new System.Windows.Forms.Label();
            this.lblTrainID = new System.Windows.Forms.Label();
            this.lblHeading = new System.Windows.Forms.Label();
            this.dgvFareDetails = new System.Windows.Forms.DataGridView();
            this.journeytimeid = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.train_id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.trainno = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.name = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.departurestation = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.journeydate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.departuretime = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.arrivalstation = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.arrivaltime = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.routetype = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.capacity = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.bogey = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.standard = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.priceperstandard = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.standardavailableseat = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.economy = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pricepereconomy = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.economyavailableseat = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.firstclass = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.priceperfirstclass = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.firstclassavailableseat = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.bogeyinfo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.txtSearchFareQuery = new MetroFramework.Controls.MetroTextBox();
            this.dgvTrainList = new System.Windows.Forms.DataGridView();
            this.trainid = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.offday = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn7 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn8 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn9 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn10 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn11 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn12 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn13 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn14 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn15 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn16 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panel1 = new System.Windows.Forms.Panel();
            this.lblFareInfo = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.lblTrainInfo = new System.Windows.Forms.Label();
            this.txtSearchTrainInfo = new MetroFramework.Controls.MetroTextBox();
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
            this.pnlUpdateFareInfo.SuspendLayout();
            this.cmsEditAndRefresh.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvFareDetails)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvTrainList)).BeginInit();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.pnlButtonList.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnlUpdateFareInfo
            // 
            this.pnlUpdateFareInfo.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnlUpdateFareInfo.ContextMenuStrip = this.cmsEditAndRefresh;
            this.pnlUpdateFareInfo.Controls.Add(this.btnRefresh);
            this.pnlUpdateFareInfo.Controls.Add(this.btnSave);
            this.pnlUpdateFareInfo.Controls.Add(this.dtpJourneyDate);
            this.pnlUpdateFareInfo.Controls.Add(this.cmbTrainID);
            this.pnlUpdateFareInfo.Controls.Add(this.lblJourneyDate);
            this.pnlUpdateFareInfo.Controls.Add(this.lblTrainID);
            this.pnlUpdateFareInfo.Controls.Add(this.lblHeading);
            this.pnlUpdateFareInfo.Location = new System.Drawing.Point(165, 18);
            this.pnlUpdateFareInfo.Name = "pnlUpdateFareInfo";
            this.pnlUpdateFareInfo.Size = new System.Drawing.Size(367, 600);
            this.pnlUpdateFareInfo.TabIndex = 4;
            // 
            // cmsEditAndRefresh
            // 
            this.cmsEditAndRefresh.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.cmsEditAndRefresh.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.refreshToolStripMenuItem});
            this.cmsEditAndRefresh.Name = "contextMenuStrip1";
            this.cmsEditAndRefresh.Size = new System.Drawing.Size(128, 28);
            // 
            // refreshToolStripMenuItem
            // 
            this.refreshToolStripMenuItem.Name = "refreshToolStripMenuItem";
            this.refreshToolStripMenuItem.Size = new System.Drawing.Size(127, 24);
            this.refreshToolStripMenuItem.Text = "Refresh";
            this.refreshToolStripMenuItem.Click += new System.EventHandler(this.RefreshToolStripMenuItem_Click);
            // 
            // btnRefresh
            // 
            this.btnRefresh.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.btnRefresh.Font = new System.Drawing.Font("Times New Roman", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRefresh.Location = new System.Drawing.Point(29, 265);
            this.btnRefresh.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnRefresh.Name = "btnRefresh";
            this.btnRefresh.Size = new System.Drawing.Size(110, 41);
            this.btnRefresh.TabIndex = 10;
            this.btnRefresh.Text = "Refresh";
            this.btnRefresh.UseVisualStyleBackColor = false;
            this.btnRefresh.Click += new System.EventHandler(this.BtnRefresh_Click);
            // 
            // btnSave
            // 
            this.btnSave.BackColor = System.Drawing.Color.Olive;
            this.btnSave.Font = new System.Drawing.Font("Times New Roman", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSave.Location = new System.Drawing.Point(211, 265);
            this.btnSave.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(110, 41);
            this.btnSave.TabIndex = 9;
            this.btnSave.Text = "Save";
            this.btnSave.UseVisualStyleBackColor = false;
            this.btnSave.Click += new System.EventHandler(this.BtnSave_Click);
            // 
            // dtpJourneyDate
            // 
            this.dtpJourneyDate.CustomFormat = "yyyy-MM-dd";
            this.dtpJourneyDate.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpJourneyDate.Location = new System.Drawing.Point(162, 135);
            this.dtpJourneyDate.MinDate = new System.DateTime(2019, 9, 3, 0, 0, 0, 0);
            this.dtpJourneyDate.MinimumSize = new System.Drawing.Size(0, 30);
            this.dtpJourneyDate.Name = "dtpJourneyDate";
            this.dtpJourneyDate.Size = new System.Drawing.Size(184, 30);
            this.dtpJourneyDate.TabIndex = 4;
            this.dtpJourneyDate.Value = new System.DateTime(2019, 9, 4, 0, 0, 0, 0);
            // 
            // cmbTrainID
            // 
            this.cmbTrainID.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
            this.cmbTrainID.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.CustomSource;
            this.cmbTrainID.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.cmbTrainID.FormattingEnabled = true;
            this.cmbTrainID.Location = new System.Drawing.Point(162, 79);
            this.cmbTrainID.Name = "cmbTrainID";
            this.cmbTrainID.Size = new System.Drawing.Size(184, 24);
            this.cmbTrainID.TabIndex = 3;
            this.cmbTrainID.SelectedIndexChanged += new System.EventHandler(this.CmbTrainID_SelectedIndexChanged);
            this.cmbTrainID.TextChanged += new System.EventHandler(this.CmbTrainID_TextChanged);
            // 
            // lblJourneyDate
            // 
            this.lblJourneyDate.AutoSize = true;
            this.lblJourneyDate.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblJourneyDate.Location = new System.Drawing.Point(3, 135);
            this.lblJourneyDate.Name = "lblJourneyDate";
            this.lblJourneyDate.Size = new System.Drawing.Size(129, 25);
            this.lblJourneyDate.TabIndex = 2;
            this.lblJourneyDate.Text = "Journey Date";
            // 
            // lblTrainID
            // 
            this.lblTrainID.AutoSize = true;
            this.lblTrainID.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTrainID.Location = new System.Drawing.Point(3, 79);
            this.lblTrainID.Name = "lblTrainID";
            this.lblTrainID.Size = new System.Drawing.Size(81, 25);
            this.lblTrainID.TabIndex = 1;
            this.lblTrainID.Text = "Train ID";
            // 
            // lblHeading
            // 
            this.lblHeading.AutoSize = true;
            this.lblHeading.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblHeading.Location = new System.Drawing.Point(3, 9);
            this.lblHeading.Name = "lblHeading";
            this.lblHeading.Size = new System.Drawing.Size(242, 32);
            this.lblHeading.TabIndex = 0;
            this.lblHeading.Text = "Update Fare Info";
            // 
            // dgvFareDetails
            // 
            this.dgvFareDetails.AllowUserToAddRows = false;
            this.dgvFareDetails.AllowUserToDeleteRows = false;
            this.dgvFareDetails.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvFareDetails.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvFareDetails.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.journeytimeid,
            this.train_id,
            this.trainno,
            this.name,
            this.departurestation,
            this.journeydate,
            this.departuretime,
            this.arrivalstation,
            this.arrivaltime,
            this.routetype,
            this.capacity,
            this.bogey,
            this.standard,
            this.priceperstandard,
            this.standardavailableseat,
            this.economy,
            this.pricepereconomy,
            this.economyavailableseat,
            this.firstclass,
            this.priceperfirstclass,
            this.firstclassavailableseat,
            this.bogeyinfo});
            this.dgvFareDetails.ContextMenuStrip = this.cmsEditAndRefresh;
            this.dgvFareDetails.Location = new System.Drawing.Point(6, 33);
            this.dgvFareDetails.Name = "dgvFareDetails";
            this.dgvFareDetails.ReadOnly = true;
            this.dgvFareDetails.RowHeadersWidth = 51;
            this.dgvFareDetails.RowTemplate.Height = 24;
            this.dgvFareDetails.Size = new System.Drawing.Size(825, 234);
            this.dgvFareDetails.TabIndex = 27;
            this.dgvFareDetails.CellContentDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DgvFareDetails_CellContentDoubleClick);
            // 
            // journeytimeid
            // 
            this.journeytimeid.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.journeytimeid.DataPropertyName = "journeytimeid";
            this.journeytimeid.HeaderText = "Journey Time ID";
            this.journeytimeid.MinimumWidth = 150;
            this.journeytimeid.Name = "journeytimeid";
            this.journeytimeid.ReadOnly = true;
            // 
            // train_id
            // 
            this.train_id.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.train_id.DataPropertyName = "trainid";
            this.train_id.HeaderText = "Train ID";
            this.train_id.MinimumWidth = 125;
            this.train_id.Name = "train_id";
            this.train_id.ReadOnly = true;
            // 
            // trainno
            // 
            this.trainno.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.trainno.DataPropertyName = "trainno";
            this.trainno.HeaderText = "Train Number";
            this.trainno.MinimumWidth = 100;
            this.trainno.Name = "trainno";
            this.trainno.ReadOnly = true;
            // 
            // name
            // 
            this.name.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.name.DataPropertyName = "name";
            this.name.HeaderText = "Train Name";
            this.name.MinimumWidth = 150;
            this.name.Name = "name";
            this.name.ReadOnly = true;
            // 
            // departurestation
            // 
            this.departurestation.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.departurestation.DataPropertyName = "departurestation";
            this.departurestation.HeaderText = "Departure Station";
            this.departurestation.MinimumWidth = 100;
            this.departurestation.Name = "departurestation";
            this.departurestation.ReadOnly = true;
            // 
            // journeydate
            // 
            this.journeydate.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.journeydate.DataPropertyName = "journeydate";
            this.journeydate.HeaderText = "Journey Date";
            this.journeydate.MinimumWidth = 100;
            this.journeydate.Name = "journeydate";
            this.journeydate.ReadOnly = true;
            // 
            // departuretime
            // 
            this.departuretime.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.departuretime.DataPropertyName = "departuretime";
            this.departuretime.HeaderText = "Journey Time";
            this.departuretime.MinimumWidth = 100;
            this.departuretime.Name = "departuretime";
            this.departuretime.ReadOnly = true;
            // 
            // arrivalstation
            // 
            this.arrivalstation.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.arrivalstation.DataPropertyName = "arrivalstation";
            this.arrivalstation.HeaderText = "Arrival Station";
            this.arrivalstation.MinimumWidth = 100;
            this.arrivalstation.Name = "arrivalstation";
            this.arrivalstation.ReadOnly = true;
            // 
            // arrivaltime
            // 
            this.arrivaltime.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.arrivaltime.DataPropertyName = "arrivaltime";
            this.arrivaltime.HeaderText = "Arrival Time";
            this.arrivaltime.MinimumWidth = 100;
            this.arrivaltime.Name = "arrivaltime";
            this.arrivaltime.ReadOnly = true;
            // 
            // routetype
            // 
            this.routetype.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.routetype.DataPropertyName = "routetype";
            this.routetype.HeaderText = "Route Type";
            this.routetype.MinimumWidth = 250;
            this.routetype.Name = "routetype";
            this.routetype.ReadOnly = true;
            // 
            // capacity
            // 
            this.capacity.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.capacity.DataPropertyName = "capacity";
            this.capacity.HeaderText = "Total Capacity";
            this.capacity.MinimumWidth = 100;
            this.capacity.Name = "capacity";
            this.capacity.ReadOnly = true;
            // 
            // bogey
            // 
            this.bogey.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.bogey.DataPropertyName = "bogey";
            this.bogey.HeaderText = "Total Bogye";
            this.bogey.MinimumWidth = 100;
            this.bogey.Name = "bogey";
            this.bogey.ReadOnly = true;
            // 
            // standard
            // 
            this.standard.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.standard.DataPropertyName = "standard";
            this.standard.HeaderText = "Standard(AC Couch)";
            this.standard.MinimumWidth = 100;
            this.standard.Name = "standard";
            this.standard.ReadOnly = true;
            // 
            // priceperstandard
            // 
            this.priceperstandard.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.priceperstandard.DataPropertyName = "priceperstandard";
            this.priceperstandard.HeaderText = "Price/Standard(BDT)";
            this.priceperstandard.MinimumWidth = 110;
            this.priceperstandard.Name = "priceperstandard";
            this.priceperstandard.ReadOnly = true;
            // 
            // standardavailableseat
            // 
            this.standardavailableseat.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.standardavailableseat.DataPropertyName = "standardavailableseat";
            this.standardavailableseat.HeaderText = "Standard Available Seat";
            this.standardavailableseat.MinimumWidth = 100;
            this.standardavailableseat.Name = "standardavailableseat";
            this.standardavailableseat.ReadOnly = true;
            // 
            // economy
            // 
            this.economy.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.economy.DataPropertyName = "economy";
            this.economy.HeaderText = "Economy (Non AC)";
            this.economy.MinimumWidth = 100;
            this.economy.Name = "economy";
            this.economy.ReadOnly = true;
            // 
            // pricepereconomy
            // 
            this.pricepereconomy.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.pricepereconomy.DataPropertyName = "pricepereconomy";
            this.pricepereconomy.HeaderText = "Price/ Economy(BDT)";
            this.pricepereconomy.MinimumWidth = 100;
            this.pricepereconomy.Name = "pricepereconomy";
            this.pricepereconomy.ReadOnly = true;
            // 
            // economyavailableseat
            // 
            this.economyavailableseat.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.economyavailableseat.DataPropertyName = "economyavailableseat";
            this.economyavailableseat.HeaderText = "Economoy Available Seat";
            this.economyavailableseat.MinimumWidth = 100;
            this.economyavailableseat.Name = "economyavailableseat";
            this.economyavailableseat.ReadOnly = true;
            // 
            // firstclass
            // 
            this.firstclass.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.firstclass.DataPropertyName = "firstclass";
            this.firstclass.HeaderText = "Firstclass (Cabin)";
            this.firstclass.MinimumWidth = 100;
            this.firstclass.Name = "firstclass";
            this.firstclass.ReadOnly = true;
            // 
            // priceperfirstclass
            // 
            this.priceperfirstclass.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.priceperfirstclass.DataPropertyName = "priceperfirstclass";
            this.priceperfirstclass.HeaderText = "Price/Firstclass(BDT)";
            this.priceperfirstclass.MinimumWidth = 110;
            this.priceperfirstclass.Name = "priceperfirstclass";
            this.priceperfirstclass.ReadOnly = true;
            // 
            // firstclassavailableseat
            // 
            this.firstclassavailableseat.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.firstclassavailableseat.DataPropertyName = "firstclassavailableseat";
            this.firstclassavailableseat.HeaderText = "Firstclass Available Seat";
            this.firstclassavailableseat.MinimumWidth = 100;
            this.firstclassavailableseat.Name = "firstclassavailableseat";
            this.firstclassavailableseat.ReadOnly = true;
            // 
            // bogeyinfo
            // 
            this.bogeyinfo.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.bogeyinfo.DataPropertyName = "bogeyinfo";
            this.bogeyinfo.HeaderText = "Bogey Info";
            this.bogeyinfo.MinimumWidth = 1200;
            this.bogeyinfo.Name = "bogeyinfo";
            this.bogeyinfo.ReadOnly = true;
            // 
            // txtSearchFareQuery
            // 
            // 
            // 
            // 
            this.txtSearchFareQuery.CustomButton.Image = null;
            this.txtSearchFareQuery.CustomButton.Location = new System.Drawing.Point(637, 1);
            this.txtSearchFareQuery.CustomButton.Name = "";
            this.txtSearchFareQuery.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.txtSearchFareQuery.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txtSearchFareQuery.CustomButton.TabIndex = 1;
            this.txtSearchFareQuery.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txtSearchFareQuery.CustomButton.UseSelectable = true;
            this.txtSearchFareQuery.CustomButton.Visible = false;
            this.txtSearchFareQuery.Lines = new string[0];
            this.txtSearchFareQuery.Location = new System.Drawing.Point(172, 4);
            this.txtSearchFareQuery.MaxLength = 32767;
            this.txtSearchFareQuery.Name = "txtSearchFareQuery";
            this.txtSearchFareQuery.PasswordChar = '\0';
            this.txtSearchFareQuery.PromptText = "Please search fare details by train name or departure station  or arrival station" +
    "";
            this.txtSearchFareQuery.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtSearchFareQuery.SelectedText = "";
            this.txtSearchFareQuery.SelectionLength = 0;
            this.txtSearchFareQuery.SelectionStart = 0;
            this.txtSearchFareQuery.ShortcutsEnabled = true;
            this.txtSearchFareQuery.Size = new System.Drawing.Size(659, 23);
            this.txtSearchFareQuery.TabIndex = 28;
            this.txtSearchFareQuery.UseSelectable = true;
            this.txtSearchFareQuery.WaterMark = "Please search fare details by train name or departure station  or arrival station" +
    "";
            this.txtSearchFareQuery.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txtSearchFareQuery.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            this.txtSearchFareQuery.TextChanged += new System.EventHandler(this.TxtSearch_TextChanged);
            // 
            // dgvTrainList
            // 
            this.dgvTrainList.AllowUserToAddRows = false;
            this.dgvTrainList.AllowUserToDeleteRows = false;
            this.dgvTrainList.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvTrainList.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvTrainList.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.trainid,
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2,
            this.offday,
            this.dataGridViewTextBoxColumn3,
            this.dataGridViewTextBoxColumn4,
            this.dataGridViewTextBoxColumn5,
            this.dataGridViewTextBoxColumn6,
            this.dataGridViewTextBoxColumn7,
            this.dataGridViewTextBoxColumn8,
            this.dataGridViewTextBoxColumn9,
            this.dataGridViewTextBoxColumn10,
            this.dataGridViewTextBoxColumn11,
            this.dataGridViewTextBoxColumn12,
            this.dataGridViewTextBoxColumn13,
            this.dataGridViewTextBoxColumn14,
            this.dataGridViewTextBoxColumn15,
            this.dataGridViewTextBoxColumn16});
            this.dgvTrainList.ContextMenuStrip = this.cmsEditAndRefresh;
            this.dgvTrainList.Location = new System.Drawing.Point(6, 34);
            this.dgvTrainList.Name = "dgvTrainList";
            this.dgvTrainList.ReadOnly = true;
            this.dgvTrainList.RowHeadersWidth = 51;
            this.dgvTrainList.RowTemplate.Height = 24;
            this.dgvTrainList.Size = new System.Drawing.Size(825, 283);
            this.dgvTrainList.TabIndex = 29;
            this.dgvTrainList.CellContentDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DgvTrainList_CellContentDoubleClick);
            // 
            // trainid
            // 
            this.trainid.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.trainid.DataPropertyName = "trainid";
            this.trainid.HeaderText = "Train ID";
            this.trainid.MinimumWidth = 100;
            this.trainid.Name = "trainid";
            this.trainid.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.dataGridViewTextBoxColumn1.DataPropertyName = "trainno";
            this.dataGridViewTextBoxColumn1.HeaderText = "Train Number";
            this.dataGridViewTextBoxColumn1.MinimumWidth = 100;
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.dataGridViewTextBoxColumn2.DataPropertyName = "name";
            this.dataGridViewTextBoxColumn2.HeaderText = "Name";
            this.dataGridViewTextBoxColumn2.MinimumWidth = 150;
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            this.dataGridViewTextBoxColumn2.ReadOnly = true;
            // 
            // offday
            // 
            this.offday.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.offday.DataPropertyName = "offday";
            this.offday.HeaderText = "Off Day";
            this.offday.MinimumWidth = 100;
            this.offday.Name = "offday";
            this.offday.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.dataGridViewTextBoxColumn3.DataPropertyName = "departurestation";
            this.dataGridViewTextBoxColumn3.HeaderText = "Departure Station";
            this.dataGridViewTextBoxColumn3.MinimumWidth = 100;
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            this.dataGridViewTextBoxColumn3.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn4
            // 
            this.dataGridViewTextBoxColumn4.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.dataGridViewTextBoxColumn4.DataPropertyName = "departuretime";
            this.dataGridViewTextBoxColumn4.HeaderText = "Departure Time";
            this.dataGridViewTextBoxColumn4.MinimumWidth = 100;
            this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            this.dataGridViewTextBoxColumn4.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn5
            // 
            this.dataGridViewTextBoxColumn5.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.dataGridViewTextBoxColumn5.DataPropertyName = "arrivalstation";
            this.dataGridViewTextBoxColumn5.HeaderText = "Arrival Station";
            this.dataGridViewTextBoxColumn5.MinimumWidth = 100;
            this.dataGridViewTextBoxColumn5.Name = "dataGridViewTextBoxColumn5";
            this.dataGridViewTextBoxColumn5.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn6
            // 
            this.dataGridViewTextBoxColumn6.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.dataGridViewTextBoxColumn6.DataPropertyName = "arrivaltime";
            this.dataGridViewTextBoxColumn6.HeaderText = "Arrival Time";
            this.dataGridViewTextBoxColumn6.MinimumWidth = 100;
            this.dataGridViewTextBoxColumn6.Name = "dataGridViewTextBoxColumn6";
            this.dataGridViewTextBoxColumn6.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn7
            // 
            this.dataGridViewTextBoxColumn7.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.dataGridViewTextBoxColumn7.DataPropertyName = "routetype";
            this.dataGridViewTextBoxColumn7.HeaderText = "Route Type";
            this.dataGridViewTextBoxColumn7.MinimumWidth = 250;
            this.dataGridViewTextBoxColumn7.Name = "dataGridViewTextBoxColumn7";
            this.dataGridViewTextBoxColumn7.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn8
            // 
            this.dataGridViewTextBoxColumn8.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.dataGridViewTextBoxColumn8.DataPropertyName = "capacity";
            this.dataGridViewTextBoxColumn8.HeaderText = "Total Capacity";
            this.dataGridViewTextBoxColumn8.MinimumWidth = 100;
            this.dataGridViewTextBoxColumn8.Name = "dataGridViewTextBoxColumn8";
            this.dataGridViewTextBoxColumn8.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn9
            // 
            this.dataGridViewTextBoxColumn9.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.dataGridViewTextBoxColumn9.DataPropertyName = "bogey";
            this.dataGridViewTextBoxColumn9.HeaderText = "Total Bogye";
            this.dataGridViewTextBoxColumn9.MinimumWidth = 100;
            this.dataGridViewTextBoxColumn9.Name = "dataGridViewTextBoxColumn9";
            this.dataGridViewTextBoxColumn9.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn10
            // 
            this.dataGridViewTextBoxColumn10.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.dataGridViewTextBoxColumn10.DataPropertyName = "standard";
            this.dataGridViewTextBoxColumn10.HeaderText = "Standard(AC Couch)";
            this.dataGridViewTextBoxColumn10.MinimumWidth = 100;
            this.dataGridViewTextBoxColumn10.Name = "dataGridViewTextBoxColumn10";
            this.dataGridViewTextBoxColumn10.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn11
            // 
            this.dataGridViewTextBoxColumn11.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.dataGridViewTextBoxColumn11.DataPropertyName = "priceperstandard";
            this.dataGridViewTextBoxColumn11.HeaderText = "Price/Standard(BDT)";
            this.dataGridViewTextBoxColumn11.MinimumWidth = 100;
            this.dataGridViewTextBoxColumn11.Name = "dataGridViewTextBoxColumn11";
            this.dataGridViewTextBoxColumn11.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn12
            // 
            this.dataGridViewTextBoxColumn12.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.dataGridViewTextBoxColumn12.DataPropertyName = "economy";
            this.dataGridViewTextBoxColumn12.HeaderText = "Economy (Non AC)";
            this.dataGridViewTextBoxColumn12.MinimumWidth = 100;
            this.dataGridViewTextBoxColumn12.Name = "dataGridViewTextBoxColumn12";
            this.dataGridViewTextBoxColumn12.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn13
            // 
            this.dataGridViewTextBoxColumn13.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.dataGridViewTextBoxColumn13.DataPropertyName = "pricepereconomy";
            this.dataGridViewTextBoxColumn13.HeaderText = "Price/Economy(BDT)";
            this.dataGridViewTextBoxColumn13.MinimumWidth = 100;
            this.dataGridViewTextBoxColumn13.Name = "dataGridViewTextBoxColumn13";
            this.dataGridViewTextBoxColumn13.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn14
            // 
            this.dataGridViewTextBoxColumn14.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.dataGridViewTextBoxColumn14.DataPropertyName = "firstclass";
            this.dataGridViewTextBoxColumn14.HeaderText = "Firstclass (Cabin)";
            this.dataGridViewTextBoxColumn14.MinimumWidth = 100;
            this.dataGridViewTextBoxColumn14.Name = "dataGridViewTextBoxColumn14";
            this.dataGridViewTextBoxColumn14.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn15
            // 
            this.dataGridViewTextBoxColumn15.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.dataGridViewTextBoxColumn15.DataPropertyName = "priceperfirstclass";
            this.dataGridViewTextBoxColumn15.HeaderText = "Price/Firstclass(BDT)";
            this.dataGridViewTextBoxColumn15.MinimumWidth = 100;
            this.dataGridViewTextBoxColumn15.Name = "dataGridViewTextBoxColumn15";
            this.dataGridViewTextBoxColumn15.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn16
            // 
            this.dataGridViewTextBoxColumn16.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.dataGridViewTextBoxColumn16.DataPropertyName = "bogeyinfo";
            this.dataGridViewTextBoxColumn16.HeaderText = "Bogey Info";
            this.dataGridViewTextBoxColumn16.MinimumWidth = 1200;
            this.dataGridViewTextBoxColumn16.Name = "dataGridViewTextBoxColumn16";
            this.dataGridViewTextBoxColumn16.ReadOnly = true;
            // 
            // panel1
            // 
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.lblFareInfo);
            this.panel1.Controls.Add(this.txtSearchFareQuery);
            this.panel1.Controls.Add(this.dgvFareDetails);
            this.panel1.Location = new System.Drawing.Point(538, 18);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(836, 272);
            this.panel1.TabIndex = 5;
            // 
            // lblFareInfo
            // 
            this.lblFareInfo.AutoSize = true;
            this.lblFareInfo.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFareInfo.Location = new System.Drawing.Point(3, 4);
            this.lblFareInfo.Name = "lblFareInfo";
            this.lblFareInfo.Size = new System.Drawing.Size(116, 25);
            this.lblFareInfo.TabIndex = 11;
            this.lblFareInfo.Text = "Fare Details";
            // 
            // panel2
            // 
            this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel2.Controls.Add(this.lblTrainInfo);
            this.panel2.Controls.Add(this.txtSearchTrainInfo);
            this.panel2.Controls.Add(this.dgvTrainList);
            this.panel2.Location = new System.Drawing.Point(538, 296);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(836, 322);
            this.panel2.TabIndex = 6;
            // 
            // lblTrainInfo
            // 
            this.lblTrainInfo.AutoSize = true;
            this.lblTrainInfo.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTrainInfo.Location = new System.Drawing.Point(1, 5);
            this.lblTrainInfo.Name = "lblTrainInfo";
            this.lblTrainInfo.Size = new System.Drawing.Size(151, 25);
            this.lblTrainInfo.TabIndex = 29;
            this.lblTrainInfo.Text = "Train and Route";
            // 
            // txtSearchTrainInfo
            // 
            this.txtSearchTrainInfo.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            // 
            // 
            // 
            this.txtSearchTrainInfo.CustomButton.Image = null;
            this.txtSearchTrainInfo.CustomButton.Location = new System.Drawing.Point(633, 1);
            this.txtSearchTrainInfo.CustomButton.Name = "";
            this.txtSearchTrainInfo.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.txtSearchTrainInfo.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txtSearchTrainInfo.CustomButton.TabIndex = 1;
            this.txtSearchTrainInfo.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txtSearchTrainInfo.CustomButton.UseSelectable = true;
            this.txtSearchTrainInfo.CustomButton.Visible = false;
            this.txtSearchTrainInfo.Lines = new string[0];
            this.txtSearchTrainInfo.Location = new System.Drawing.Point(172, 5);
            this.txtSearchTrainInfo.MaxLength = 32767;
            this.txtSearchTrainInfo.Name = "txtSearchTrainInfo";
            this.txtSearchTrainInfo.PasswordChar = '\0';
            this.txtSearchTrainInfo.PromptText = "Please search route by train ID or train no or train name or departure station  o" +
    "r arrival station";
            this.txtSearchTrainInfo.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtSearchTrainInfo.SelectedText = "";
            this.txtSearchTrainInfo.SelectionLength = 0;
            this.txtSearchTrainInfo.SelectionStart = 0;
            this.txtSearchTrainInfo.ShortcutsEnabled = true;
            this.txtSearchTrainInfo.Size = new System.Drawing.Size(655, 23);
            this.txtSearchTrainInfo.TabIndex = 7;
            this.txtSearchTrainInfo.UseSelectable = true;
            this.txtSearchTrainInfo.WaterMark = "Please search route by train ID or train no or train name or departure station  o" +
    "r arrival station";
            this.txtSearchTrainInfo.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txtSearchTrainInfo.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            this.txtSearchTrainInfo.TextChanged += new System.EventHandler(this.MetroTextBox1_TextChanged);
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
            this.pnlButtonList.Location = new System.Drawing.Point(12, 11);
            this.pnlButtonList.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.pnlButtonList.Name = "pnlButtonList";
            this.pnlButtonList.Size = new System.Drawing.Size(147, 610);
            this.pnlButtonList.TabIndex = 30;
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
            this.btnEmployeeInfo.Click += new System.EventHandler(this.BtnEmployeeInfo_Click);
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
            this.btnExit.Location = new System.Drawing.Point(2, 551);
            this.btnExit.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(140, 55);
            this.btnExit.TabIndex = 6;
            this.btnExit.Text = "Exit";
            this.btnExit.UseVisualStyleBackColor = false;
            this.btnExit.Click += new System.EventHandler(this.BtnExit_Click);
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
            this.btnSignOut.Click += new System.EventHandler(this.BtnSignOut_Click);
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
            this.btnUserProfile.Click += new System.EventHandler(this.BtnUserProfile_Click);
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
            this.btnSellHistory.Click += new System.EventHandler(this.BtnSellHistory_Click);
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
            this.btnDashboard.Click += new System.EventHandler(this.BtnDashboard_Click);
            // 
            // FareInfo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Tan;
            this.ClientSize = new System.Drawing.Size(1378, 630);
            this.Controls.Add(this.pnlButtonList);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.pnlUpdateFareInfo);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "FareInfo";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Fare Info";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.FareInfo_FormClosed);
            this.pnlUpdateFareInfo.ResumeLayout(false);
            this.pnlUpdateFareInfo.PerformLayout();
            this.cmsEditAndRefresh.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvFareDetails)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvTrainList)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.pnlButtonList.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Panel pnlUpdateFareInfo;
        private System.Windows.Forms.Label lblHeading;
        private System.Windows.Forms.Label lblTrainID;
        private System.Windows.Forms.Label lblJourneyDate;
        private System.Windows.Forms.ComboBox cmbTrainID;
        private System.Windows.Forms.DataGridView dgvFareDetails;
        private MetroFramework.Controls.MetroTextBox txtSearchFareQuery;
        private System.Windows.Forms.DataGridView dgvTrainList;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private MetroFramework.Controls.MetroTextBox txtSearchTrainInfo;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Button btnRefresh;
        private System.Windows.Forms.ContextMenuStrip cmsEditAndRefresh;
        private System.Windows.Forms.ToolStripMenuItem refreshToolStripMenuItem;
        private System.Windows.Forms.DataGridViewTextBoxColumn trainid;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn offday;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn5;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn6;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn7;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn8;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn9;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn10;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn11;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn12;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn13;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn14;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn15;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn16;
        private MetroFramework.Controls.MetroDateTime dtpJourneyDate;
        private System.Windows.Forms.DataGridViewTextBoxColumn journeytimeid;
        private System.Windows.Forms.DataGridViewTextBoxColumn train_id;
        private System.Windows.Forms.DataGridViewTextBoxColumn trainno;
        private System.Windows.Forms.DataGridViewTextBoxColumn name;
        private System.Windows.Forms.DataGridViewTextBoxColumn departurestation;
        private System.Windows.Forms.DataGridViewTextBoxColumn journeydate;
        private System.Windows.Forms.DataGridViewTextBoxColumn departuretime;
        private System.Windows.Forms.DataGridViewTextBoxColumn arrivalstation;
        private System.Windows.Forms.DataGridViewTextBoxColumn arrivaltime;
        private System.Windows.Forms.DataGridViewTextBoxColumn routetype;
        private System.Windows.Forms.DataGridViewTextBoxColumn capacity;
        private System.Windows.Forms.DataGridViewTextBoxColumn bogey;
        private System.Windows.Forms.DataGridViewTextBoxColumn standard;
        private System.Windows.Forms.DataGridViewTextBoxColumn priceperstandard;
        private System.Windows.Forms.DataGridViewTextBoxColumn standardavailableseat;
        private System.Windows.Forms.DataGridViewTextBoxColumn economy;
        private System.Windows.Forms.DataGridViewTextBoxColumn pricepereconomy;
        private System.Windows.Forms.DataGridViewTextBoxColumn economyavailableseat;
        private System.Windows.Forms.DataGridViewTextBoxColumn firstclass;
        private System.Windows.Forms.DataGridViewTextBoxColumn priceperfirstclass;
        private System.Windows.Forms.DataGridViewTextBoxColumn firstclassavailableseat;
        private System.Windows.Forms.DataGridViewTextBoxColumn bogeyinfo;
        private System.Windows.Forms.Label lblFareInfo;
        private System.Windows.Forms.Label lblTrainInfo;
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