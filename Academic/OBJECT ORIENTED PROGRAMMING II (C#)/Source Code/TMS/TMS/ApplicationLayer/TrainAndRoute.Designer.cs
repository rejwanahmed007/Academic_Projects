namespace TMS.ApplicationLayer
{
    partial class TrainAndRoute
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(TrainAndRoute));
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
            this.pnlTrainInfo = new System.Windows.Forms.Panel();
            this.cmsRefresh = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.refreshToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.txtTo = new System.Windows.Forms.TextBox();
            this.txtFrom = new System.Windows.Forms.TextBox();
            this.txtRouteType = new System.Windows.Forms.TextBox();
            this.txtOffDay = new System.Windows.Forms.TextBox();
            this.dtpTo = new System.Windows.Forms.DateTimePicker();
            this.dtpFrom = new System.Windows.Forms.DateTimePicker();
            this.lblTrainID = new System.Windows.Forms.Label();
            this.lblTrainIDHeading = new System.Windows.Forms.Label();
            this.btnRefresh = new System.Windows.Forms.Button();
            this.btnSave = new System.Windows.Forms.Button();
            this.lblHeading = new System.Windows.Forms.Label();
            this.txtBogeyInfo = new MetroFramework.Controls.MetroTextBox();
            this.lblBogeyInfo = new System.Windows.Forms.Label();
            this.txtPricerEconomy = new MetroFramework.Controls.MetroTextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtPriceStandard = new MetroFramework.Controls.MetroTextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtPriceFirstClass = new MetroFramework.Controls.MetroTextBox();
            this.lblPriceFirst = new System.Windows.Forms.Label();
            this.txtEconomy = new MetroFramework.Controls.MetroTextBox();
            this.lblEconomy = new System.Windows.Forms.Label();
            this.txtStandard = new MetroFramework.Controls.MetroTextBox();
            this.lblStandard = new System.Windows.Forms.Label();
            this.txtFirstClass = new MetroFramework.Controls.MetroTextBox();
            this.lblFirstClass = new System.Windows.Forms.Label();
            this.txtBogey = new MetroFramework.Controls.MetroTextBox();
            this.lblBogey = new System.Windows.Forms.Label();
            this.txtCapacity = new MetroFramework.Controls.MetroTextBox();
            this.lblCapacity = new System.Windows.Forms.Label();
            this.lblArrivalTime = new System.Windows.Forms.Label();
            this.lblTO = new System.Windows.Forms.Label();
            this.lblLeavingTime = new System.Windows.Forms.Label();
            this.lblFrom = new System.Windows.Forms.Label();
            this.lblRouteType = new System.Windows.Forms.Label();
            this.lblOffDay = new System.Windows.Forms.Label();
            this.txtTrainName = new MetroFramework.Controls.MetroTextBox();
            this.lblTrainName = new System.Windows.Forms.Label();
            this.txtTrainNo = new MetroFramework.Controls.MetroTextBox();
            this.lblTrainNo = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.txtSearch = new MetroFramework.Controls.MetroTextBox();
            this.dgvTrainList = new MetroFramework.Controls.MetroGrid();
            this.trainid = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.trainno = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.name = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.offday = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.departurestation = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.departuretime = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.arrivalstation = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.arrivaltime = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.routetype = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.capacity = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.bogey = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.standard = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.priceperstandard = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.economy = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pricepereconomy = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.firstclass = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.priceperfirstclass = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.bogeyinfo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.errDigit = new System.Windows.Forms.ErrorProvider(this.components);
            this.errString = new System.Windows.Forms.ErrorProvider(this.components);
            this.pnlButtonList.SuspendLayout();
            this.pnlTrainInfo.SuspendLayout();
            this.cmsRefresh.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvTrainList)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errDigit)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errString)).BeginInit();
            this.SuspendLayout();
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
            this.pnlButtonList.TabIndex = 3;
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
            this.btnFareInfo.Click += new System.EventHandler(this.BtnFareInfo_Click);
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
            // pnlTrainInfo
            // 
            this.pnlTrainInfo.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnlTrainInfo.ContextMenuStrip = this.cmsRefresh;
            this.pnlTrainInfo.Controls.Add(this.txtTo);
            this.pnlTrainInfo.Controls.Add(this.txtFrom);
            this.pnlTrainInfo.Controls.Add(this.txtRouteType);
            this.pnlTrainInfo.Controls.Add(this.txtOffDay);
            this.pnlTrainInfo.Controls.Add(this.dtpTo);
            this.pnlTrainInfo.Controls.Add(this.dtpFrom);
            this.pnlTrainInfo.Controls.Add(this.lblTrainID);
            this.pnlTrainInfo.Controls.Add(this.lblTrainIDHeading);
            this.pnlTrainInfo.Controls.Add(this.btnRefresh);
            this.pnlTrainInfo.Controls.Add(this.btnSave);
            this.pnlTrainInfo.Controls.Add(this.lblHeading);
            this.pnlTrainInfo.Controls.Add(this.txtBogeyInfo);
            this.pnlTrainInfo.Controls.Add(this.lblBogeyInfo);
            this.pnlTrainInfo.Controls.Add(this.txtPricerEconomy);
            this.pnlTrainInfo.Controls.Add(this.label3);
            this.pnlTrainInfo.Controls.Add(this.txtPriceStandard);
            this.pnlTrainInfo.Controls.Add(this.label2);
            this.pnlTrainInfo.Controls.Add(this.txtPriceFirstClass);
            this.pnlTrainInfo.Controls.Add(this.lblPriceFirst);
            this.pnlTrainInfo.Controls.Add(this.txtEconomy);
            this.pnlTrainInfo.Controls.Add(this.lblEconomy);
            this.pnlTrainInfo.Controls.Add(this.txtStandard);
            this.pnlTrainInfo.Controls.Add(this.lblStandard);
            this.pnlTrainInfo.Controls.Add(this.txtFirstClass);
            this.pnlTrainInfo.Controls.Add(this.lblFirstClass);
            this.pnlTrainInfo.Controls.Add(this.txtBogey);
            this.pnlTrainInfo.Controls.Add(this.lblBogey);
            this.pnlTrainInfo.Controls.Add(this.txtCapacity);
            this.pnlTrainInfo.Controls.Add(this.lblCapacity);
            this.pnlTrainInfo.Controls.Add(this.lblArrivalTime);
            this.pnlTrainInfo.Controls.Add(this.lblTO);
            this.pnlTrainInfo.Controls.Add(this.lblLeavingTime);
            this.pnlTrainInfo.Controls.Add(this.lblFrom);
            this.pnlTrainInfo.Controls.Add(this.lblRouteType);
            this.pnlTrainInfo.Controls.Add(this.lblOffDay);
            this.pnlTrainInfo.Controls.Add(this.txtTrainName);
            this.pnlTrainInfo.Controls.Add(this.lblTrainName);
            this.pnlTrainInfo.Controls.Add(this.txtTrainNo);
            this.pnlTrainInfo.Controls.Add(this.lblTrainNo);
            this.pnlTrainInfo.Location = new System.Drawing.Point(165, 11);
            this.pnlTrainInfo.Name = "pnlTrainInfo";
            this.pnlTrainInfo.Size = new System.Drawing.Size(547, 607);
            this.pnlTrainInfo.TabIndex = 4;
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
            this.refreshToolStripMenuItem.Click += new System.EventHandler(this.RefreshToolStripMenuItem_Click_2);
            // 
            // txtTo
            // 
            this.txtTo.AutoCompleteCustomSource.AddRange(new string[] {
            "DHAKA",
            "FARIDPUR",
            "GAZIPUR",
            "GOPALGANJ",
            "JAMALPUR",
            "KISHOREGONJ",
            "MADARIPUR",
            "MANIKGANJ",
            "MUNSHIGANJ",
            "MYMENSINGH",
            "NARAYANGANJ",
            "NETRAKONA",
            "NARSINGDI",
            "RAJBARI",
            "SHARIATPUR",
            "SHERPUR",
            "TANGAIL",
            "BANDARBAN",
            "BRAHMANBARIA",
            "CHANDPUR",
            "CHITTAGONG",
            "COMILLA",
            "COX`S BAZAR",
            "FENI",
            "MEHERPUR",
            "LAKSHMIPUR",
            "NOAKHALI",
            "RANGAMATI",
            "BARGUNA",
            "BARISAL",
            "BHOLA",
            "JHALOKATI",
            "PATUAKHALI",
            "PIROJPUR",
            "BOGRA",
            "CHAPAINABABGANJ",
            "JOYPURHAT",
            "PABNA",
            "NAOGAON",
            "NATORE",
            "RAJSHAHI",
            "SIRAJGANJ",
            "DINAJPUR",
            "GAIBANDHA",
            "KURIGRAM",
            "LALMONIRHAT",
            "NILPHAMARI",
            "PANCHAGARH",
            "RANGPUR",
            "THAKURGAON",
            "BAGERHAT",
            "CHUADANGA",
            "JHENAIDAH",
            "JESSORE",
            "KHULNA",
            "KUSHTIA",
            "MAGURA",
            "MEHERPUR",
            "NARAIL",
            "SATKHIRA",
            "HABIGANJ",
            "MAULVIBAZAR",
            "SUNAMGANJ",
            "SYLHET",
            "Joydebpur",
            "Akhaura",
            "Benapole"});
            this.txtTo.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.txtTo.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.CustomSource;
            this.txtTo.Location = new System.Drawing.Point(109, 258);
            this.txtTo.MaxLength = 150;
            this.txtTo.Name = "txtTo";
            this.txtTo.Size = new System.Drawing.Size(138, 22);
            this.txtTo.TabIndex = 202;
            this.txtTo.Leave += new System.EventHandler(this.TxtTo_Leave);
            // 
            // txtFrom
            // 
            this.txtFrom.AutoCompleteCustomSource.AddRange(new string[] {
            "DHAKA",
            "FARIDPUR",
            "GAZIPUR",
            "GOPALGANJ",
            "JAMALPUR",
            "KISHOREGONJ",
            "MADARIPUR",
            "MANIKGANJ",
            "MUNSHIGANJ",
            "MYMENSINGH",
            "NARAYANGANJ",
            "NETRAKONA",
            "NARSINGDI",
            "RAJBARI",
            "SHARIATPUR",
            "SHERPUR",
            "TANGAIL",
            "BANDARBAN",
            "BRAHMANBARIA",
            "CHANDPUR",
            "CHITTAGONG",
            "COMILLA",
            "COX`S BAZAR",
            "FENI",
            "MEHERPUR",
            "LAKSHMIPUR",
            "NOAKHALI",
            "RANGAMATI",
            "BARGUNA",
            "BARISAL",
            "BHOLA",
            "JHALOKATI",
            "PATUAKHALI",
            "PIROJPUR",
            "BOGRA",
            "CHAPAINABABGANJ",
            "JOYPURHAT",
            "PABNA",
            "NAOGAON",
            "NATORE",
            "RAJSHAHI",
            "SIRAJGANJ",
            "DINAJPUR",
            "GAIBANDHA",
            "KURIGRAM",
            "LALMONIRHAT",
            "NILPHAMARI",
            "PANCHAGARH",
            "RANGPUR",
            "THAKURGAON",
            "BAGERHAT",
            "CHUADANGA",
            "JHENAIDAH",
            "JESSORE",
            "KHULNA",
            "KUSHTIA",
            "MAGURA",
            "MEHERPUR",
            "NARAIL",
            "SATKHIRA",
            "HABIGANJ",
            "MAULVIBAZAR",
            "SUNAMGANJ",
            "SYLHET",
            "Joydebpur",
            "Akhaura",
            "Benapole"});
            this.txtFrom.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.txtFrom.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.CustomSource;
            this.txtFrom.Location = new System.Drawing.Point(109, 217);
            this.txtFrom.MaxLength = 150;
            this.txtFrom.Name = "txtFrom";
            this.txtFrom.Size = new System.Drawing.Size(138, 22);
            this.txtFrom.TabIndex = 201;
            this.txtFrom.Leave += new System.EventHandler(this.TxtFrom_Leave);
            // 
            // txtRouteType
            // 
            this.txtRouteType.AutoCompleteCustomSource.AddRange(new string[] {
            "Intercity Trains ( Meter Gauge & Dual Gauge)",
            "Intercity Trains (Broad Gauge & Dual Gauge)",
            "Mail/Express Trains (Metre Gauge)",
            "Mail/Express Trains (Broad Gauge & Duel Gauge)"});
            this.txtRouteType.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.txtRouteType.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.CustomSource;
            this.txtRouteType.Location = new System.Drawing.Point(109, 178);
            this.txtRouteType.MaxLength = 40;
            this.txtRouteType.Name = "txtRouteType";
            this.txtRouteType.Size = new System.Drawing.Size(416, 22);
            this.txtRouteType.TabIndex = 200;
            this.txtRouteType.Leave += new System.EventHandler(this.TxtRouteType_Leave);
            // 
            // txtOffDay
            // 
            this.txtOffDay.AutoCompleteCustomSource.AddRange(new string[] {
            "No",
            "Sunday",
            "Monday",
            "Tuesday",
            "Wednesday",
            "Thursday",
            "Friday",
            "Saturday"});
            this.txtOffDay.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.txtOffDay.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.CustomSource;
            this.txtOffDay.Location = new System.Drawing.Point(109, 140);
            this.txtOffDay.MaxLength = 40;
            this.txtOffDay.Name = "txtOffDay";
            this.txtOffDay.Size = new System.Drawing.Size(422, 22);
            this.txtOffDay.TabIndex = 39;
            this.txtOffDay.Leave += new System.EventHandler(this.TxtOffDay_Leave);
            // 
            // dtpTo
            // 
            this.dtpTo.CustomFormat = "hh:mm:ss";
            this.dtpTo.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpTo.Location = new System.Drawing.Point(385, 256);
            this.dtpTo.Name = "dtpTo";
            this.dtpTo.Size = new System.Drawing.Size(139, 22);
            this.dtpTo.TabIndex = 38;
            // 
            // dtpFrom
            // 
            this.dtpFrom.CustomFormat = "hh:mm:ss";
            this.dtpFrom.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpFrom.Location = new System.Drawing.Point(385, 215);
            this.dtpFrom.Name = "dtpFrom";
            this.dtpFrom.Size = new System.Drawing.Size(139, 22);
            this.dtpFrom.TabIndex = 37;
            // 
            // lblTrainID
            // 
            this.lblTrainID.AutoSize = true;
            this.lblTrainID.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTrainID.Location = new System.Drawing.Point(160, 71);
            this.lblTrainID.Name = "lblTrainID";
            this.lblTrainID.Size = new System.Drawing.Size(0, 29);
            this.lblTrainID.TabIndex = 36;
            // 
            // lblTrainIDHeading
            // 
            this.lblTrainIDHeading.AutoSize = true;
            this.lblTrainIDHeading.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTrainIDHeading.Location = new System.Drawing.Point(4, 71);
            this.lblTrainIDHeading.Name = "lblTrainIDHeading";
            this.lblTrainIDHeading.Size = new System.Drawing.Size(0, 29);
            this.lblTrainIDHeading.TabIndex = 35;
            // 
            // btnRefresh
            // 
            this.btnRefresh.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.btnRefresh.Font = new System.Drawing.Font("Times New Roman", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRefresh.Location = new System.Drawing.Point(138, 529);
            this.btnRefresh.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnRefresh.Name = "btnRefresh";
            this.btnRefresh.Size = new System.Drawing.Size(110, 41);
            this.btnRefresh.TabIndex = 15;
            this.btnRefresh.Text = "Refresh";
            this.btnRefresh.UseVisualStyleBackColor = false;
            this.btnRefresh.Click += new System.EventHandler(this.BtnRefresh_Click);
            // 
            // btnSave
            // 
            this.btnSave.BackColor = System.Drawing.Color.Olive;
            this.btnSave.Font = new System.Drawing.Font("Times New Roman", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSave.Location = new System.Drawing.Point(320, 529);
            this.btnSave.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(110, 41);
            this.btnSave.TabIndex = 14;
            this.btnSave.Text = "Save";
            this.btnSave.UseVisualStyleBackColor = false;
            this.btnSave.Click += new System.EventHandler(this.BtnSave_Click);
            // 
            // lblHeading
            // 
            this.lblHeading.AutoSize = true;
            this.lblHeading.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblHeading.Location = new System.Drawing.Point(122, 15);
            this.lblHeading.Name = "lblHeading";
            this.lblHeading.Size = new System.Drawing.Size(292, 32);
            this.lblHeading.TabIndex = 34;
            this.lblHeading.Text = "Train and Route Info";
            // 
            // txtBogeyInfo
            // 
            // 
            // 
            // 
            this.txtBogeyInfo.CustomButton.Image = null;
            this.txtBogeyInfo.CustomButton.Location = new System.Drawing.Point(392, 1);
            this.txtBogeyInfo.CustomButton.Name = "";
            this.txtBogeyInfo.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.txtBogeyInfo.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txtBogeyInfo.CustomButton.TabIndex = 1;
            this.txtBogeyInfo.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txtBogeyInfo.CustomButton.UseSelectable = true;
            this.txtBogeyInfo.CustomButton.Visible = false;
            this.txtBogeyInfo.Lines = new string[0];
            this.txtBogeyInfo.Location = new System.Drawing.Point(110, 464);
            this.txtBogeyInfo.MaxLength = 400;
            this.txtBogeyInfo.Name = "txtBogeyInfo";
            this.txtBogeyInfo.PasswordChar = '\0';
            this.txtBogeyInfo.PromptText = "Bogey Details Info";
            this.txtBogeyInfo.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtBogeyInfo.SelectedText = "";
            this.txtBogeyInfo.SelectionLength = 0;
            this.txtBogeyInfo.SelectionStart = 0;
            this.txtBogeyInfo.ShortcutsEnabled = true;
            this.txtBogeyInfo.Size = new System.Drawing.Size(414, 23);
            this.txtBogeyInfo.TabIndex = 33;
            this.txtBogeyInfo.UseSelectable = true;
            this.txtBogeyInfo.WaterMark = "Bogey Details Info";
            this.txtBogeyInfo.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txtBogeyInfo.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            this.txtBogeyInfo.Leave += new System.EventHandler(this.TxtBogeyInfo_Leave);
            // 
            // lblBogeyInfo
            // 
            this.lblBogeyInfo.AutoSize = true;
            this.lblBogeyInfo.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblBogeyInfo.Location = new System.Drawing.Point(6, 467);
            this.lblBogeyInfo.Name = "lblBogeyInfo";
            this.lblBogeyInfo.Size = new System.Drawing.Size(88, 20);
            this.lblBogeyInfo.TabIndex = 32;
            this.lblBogeyInfo.Text = "Bogey Info";
            // 
            // txtPricerEconomy
            // 
            // 
            // 
            // 
            this.txtPricerEconomy.CustomButton.Image = null;
            this.txtPricerEconomy.CustomButton.Location = new System.Drawing.Point(117, 1);
            this.txtPricerEconomy.CustomButton.Name = "";
            this.txtPricerEconomy.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.txtPricerEconomy.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txtPricerEconomy.CustomButton.TabIndex = 1;
            this.txtPricerEconomy.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txtPricerEconomy.CustomButton.UseSelectable = true;
            this.txtPricerEconomy.CustomButton.Visible = false;
            this.txtPricerEconomy.Lines = new string[0];
            this.txtPricerEconomy.Location = new System.Drawing.Point(386, 416);
            this.txtPricerEconomy.MaxLength = 4;
            this.txtPricerEconomy.Name = "txtPricerEconomy";
            this.txtPricerEconomy.PasswordChar = '\0';
            this.txtPricerEconomy.PromptText = "Price per Couch";
            this.txtPricerEconomy.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtPricerEconomy.SelectedText = "";
            this.txtPricerEconomy.SelectionLength = 0;
            this.txtPricerEconomy.SelectionStart = 0;
            this.txtPricerEconomy.ShortcutsEnabled = true;
            this.txtPricerEconomy.Size = new System.Drawing.Size(139, 23);
            this.txtPricerEconomy.TabIndex = 31;
            this.txtPricerEconomy.UseSelectable = true;
            this.txtPricerEconomy.WaterMark = "Price per Couch";
            this.txtPricerEconomy.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txtPricerEconomy.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            this.txtPricerEconomy.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TxtPricerEconomy_KeyPress);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(264, 419);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(105, 20);
            this.label3.TabIndex = 30;
            this.label3.Text = "Price(BDT)";
            // 
            // txtPriceStandard
            // 
            // 
            // 
            // 
            this.txtPriceStandard.CustomButton.Image = null;
            this.txtPriceStandard.CustomButton.Location = new System.Drawing.Point(117, 1);
            this.txtPriceStandard.CustomButton.Name = "";
            this.txtPriceStandard.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.txtPriceStandard.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txtPriceStandard.CustomButton.TabIndex = 1;
            this.txtPriceStandard.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txtPriceStandard.CustomButton.UseSelectable = true;
            this.txtPriceStandard.CustomButton.Visible = false;
            this.txtPriceStandard.Lines = new string[0];
            this.txtPriceStandard.Location = new System.Drawing.Point(386, 378);
            this.txtPriceStandard.MaxLength = 4;
            this.txtPriceStandard.Name = "txtPriceStandard";
            this.txtPriceStandard.PasswordChar = '\0';
            this.txtPriceStandard.PromptText = "Price per AC Couch";
            this.txtPriceStandard.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtPriceStandard.SelectedText = "";
            this.txtPriceStandard.SelectionLength = 0;
            this.txtPriceStandard.SelectionStart = 0;
            this.txtPriceStandard.ShortcutsEnabled = true;
            this.txtPriceStandard.Size = new System.Drawing.Size(139, 23);
            this.txtPriceStandard.TabIndex = 29;
            this.txtPriceStandard.UseSelectable = true;
            this.txtPriceStandard.WaterMark = "Price per AC Couch";
            this.txtPriceStandard.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txtPriceStandard.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            this.txtPriceStandard.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TxtPriceStandard_KeyPress);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(264, 381);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(105, 20);
            this.label2.TabIndex = 28;
            this.label2.Text = "Price(BDT)";
            // 
            // txtPriceFirstClass
            // 
            // 
            // 
            // 
            this.txtPriceFirstClass.CustomButton.Image = null;
            this.txtPriceFirstClass.CustomButton.Location = new System.Drawing.Point(117, 1);
            this.txtPriceFirstClass.CustomButton.Name = "";
            this.txtPriceFirstClass.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.txtPriceFirstClass.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txtPriceFirstClass.CustomButton.TabIndex = 1;
            this.txtPriceFirstClass.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txtPriceFirstClass.CustomButton.UseSelectable = true;
            this.txtPriceFirstClass.CustomButton.Visible = false;
            this.txtPriceFirstClass.Lines = new string[0];
            this.txtPriceFirstClass.Location = new System.Drawing.Point(386, 335);
            this.txtPriceFirstClass.MaxLength = 4;
            this.txtPriceFirstClass.Name = "txtPriceFirstClass";
            this.txtPriceFirstClass.PasswordChar = '\0';
            this.txtPriceFirstClass.PromptText = "Price Per Cabin";
            this.txtPriceFirstClass.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtPriceFirstClass.SelectedText = "";
            this.txtPriceFirstClass.SelectionLength = 0;
            this.txtPriceFirstClass.SelectionStart = 0;
            this.txtPriceFirstClass.ShortcutsEnabled = true;
            this.txtPriceFirstClass.Size = new System.Drawing.Size(139, 23);
            this.txtPriceFirstClass.TabIndex = 27;
            this.txtPriceFirstClass.UseSelectable = true;
            this.txtPriceFirstClass.WaterMark = "Price Per Cabin";
            this.txtPriceFirstClass.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txtPriceFirstClass.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            this.txtPriceFirstClass.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TxtPriceFirstClass_KeyPress);
            // 
            // lblPriceFirst
            // 
            this.lblPriceFirst.AutoSize = true;
            this.lblPriceFirst.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPriceFirst.Location = new System.Drawing.Point(264, 338);
            this.lblPriceFirst.Name = "lblPriceFirst";
            this.lblPriceFirst.Size = new System.Drawing.Size(105, 20);
            this.lblPriceFirst.TabIndex = 26;
            this.lblPriceFirst.Text = "Price(BDT)";
            // 
            // txtEconomy
            // 
            // 
            // 
            // 
            this.txtEconomy.CustomButton.Image = null;
            this.txtEconomy.CustomButton.Location = new System.Drawing.Point(117, 1);
            this.txtEconomy.CustomButton.Name = "";
            this.txtEconomy.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.txtEconomy.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txtEconomy.CustomButton.TabIndex = 1;
            this.txtEconomy.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txtEconomy.CustomButton.UseSelectable = true;
            this.txtEconomy.CustomButton.Visible = false;
            this.txtEconomy.Lines = new string[0];
            this.txtEconomy.Location = new System.Drawing.Point(110, 419);
            this.txtEconomy.MaxLength = 4;
            this.txtEconomy.Name = "txtEconomy";
            this.txtEconomy.PasswordChar = '\0';
            this.txtEconomy.PromptText = "Non-AC Cabin";
            this.txtEconomy.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtEconomy.SelectedText = "";
            this.txtEconomy.SelectionLength = 0;
            this.txtEconomy.SelectionStart = 0;
            this.txtEconomy.ShortcutsEnabled = true;
            this.txtEconomy.Size = new System.Drawing.Size(139, 23);
            this.txtEconomy.TabIndex = 25;
            this.txtEconomy.UseSelectable = true;
            this.txtEconomy.WaterMark = "Non-AC Cabin";
            this.txtEconomy.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txtEconomy.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            this.txtEconomy.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TxtEconomy_KeyPress);
            // 
            // lblEconomy
            // 
            this.lblEconomy.AutoSize = true;
            this.lblEconomy.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEconomy.Location = new System.Drawing.Point(3, 422);
            this.lblEconomy.Name = "lblEconomy";
            this.lblEconomy.Size = new System.Drawing.Size(85, 20);
            this.lblEconomy.TabIndex = 24;
            this.lblEconomy.Text = "Economy";
            // 
            // txtStandard
            // 
            // 
            // 
            // 
            this.txtStandard.CustomButton.Image = null;
            this.txtStandard.CustomButton.Location = new System.Drawing.Point(117, 1);
            this.txtStandard.CustomButton.Name = "";
            this.txtStandard.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.txtStandard.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txtStandard.CustomButton.TabIndex = 1;
            this.txtStandard.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txtStandard.CustomButton.UseSelectable = true;
            this.txtStandard.CustomButton.Visible = false;
            this.txtStandard.Lines = new string[0];
            this.txtStandard.Location = new System.Drawing.Point(110, 381);
            this.txtStandard.MaxLength = 4;
            this.txtStandard.Name = "txtStandard";
            this.txtStandard.PasswordChar = '\0';
            this.txtStandard.PromptText = "Standard(AC Couch)";
            this.txtStandard.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtStandard.SelectedText = "";
            this.txtStandard.SelectionLength = 0;
            this.txtStandard.SelectionStart = 0;
            this.txtStandard.ShortcutsEnabled = true;
            this.txtStandard.Size = new System.Drawing.Size(139, 23);
            this.txtStandard.TabIndex = 23;
            this.txtStandard.UseSelectable = true;
            this.txtStandard.WaterMark = "Standard(AC Couch)";
            this.txtStandard.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txtStandard.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            this.txtStandard.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TxtStandard_KeyPress);
            // 
            // lblStandard
            // 
            this.lblStandard.AutoSize = true;
            this.lblStandard.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblStandard.Location = new System.Drawing.Point(3, 384);
            this.lblStandard.Name = "lblStandard";
            this.lblStandard.Size = new System.Drawing.Size(84, 20);
            this.lblStandard.TabIndex = 22;
            this.lblStandard.Text = "Standard";
            // 
            // txtFirstClass
            // 
            // 
            // 
            // 
            this.txtFirstClass.CustomButton.Image = null;
            this.txtFirstClass.CustomButton.Location = new System.Drawing.Point(117, 1);
            this.txtFirstClass.CustomButton.Name = "";
            this.txtFirstClass.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.txtFirstClass.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txtFirstClass.CustomButton.TabIndex = 1;
            this.txtFirstClass.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txtFirstClass.CustomButton.UseSelectable = true;
            this.txtFirstClass.CustomButton.Visible = false;
            this.txtFirstClass.Lines = new string[0];
            this.txtFirstClass.Location = new System.Drawing.Point(110, 338);
            this.txtFirstClass.MaxLength = 4;
            this.txtFirstClass.Name = "txtFirstClass";
            this.txtFirstClass.PasswordChar = '\0';
            this.txtFirstClass.PromptText = "First Class (AC Cabin)";
            this.txtFirstClass.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtFirstClass.SelectedText = "";
            this.txtFirstClass.SelectionLength = 0;
            this.txtFirstClass.SelectionStart = 0;
            this.txtFirstClass.ShortcutsEnabled = true;
            this.txtFirstClass.Size = new System.Drawing.Size(139, 23);
            this.txtFirstClass.TabIndex = 21;
            this.txtFirstClass.UseSelectable = true;
            this.txtFirstClass.WaterMark = "First Class (AC Cabin)";
            this.txtFirstClass.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txtFirstClass.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            this.txtFirstClass.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TxtFirstClass_KeyPress);
            // 
            // lblFirstClass
            // 
            this.lblFirstClass.AutoSize = true;
            this.lblFirstClass.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFirstClass.Location = new System.Drawing.Point(2, 341);
            this.lblFirstClass.Name = "lblFirstClass";
            this.lblFirstClass.Size = new System.Drawing.Size(102, 20);
            this.lblFirstClass.TabIndex = 20;
            this.lblFirstClass.Text = "First Class";
            // 
            // txtBogey
            // 
            // 
            // 
            // 
            this.txtBogey.CustomButton.Image = null;
            this.txtBogey.CustomButton.Location = new System.Drawing.Point(117, 1);
            this.txtBogey.CustomButton.Name = "";
            this.txtBogey.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.txtBogey.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txtBogey.CustomButton.TabIndex = 1;
            this.txtBogey.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txtBogey.CustomButton.UseSelectable = true;
            this.txtBogey.CustomButton.Visible = false;
            this.txtBogey.Lines = new string[0];
            this.txtBogey.Location = new System.Drawing.Point(386, 294);
            this.txtBogey.MaxLength = 2;
            this.txtBogey.Name = "txtBogey";
            this.txtBogey.PasswordChar = '\0';
            this.txtBogey.PromptText = "Number Of Bogey";
            this.txtBogey.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtBogey.SelectedText = "";
            this.txtBogey.SelectionLength = 0;
            this.txtBogey.SelectionStart = 0;
            this.txtBogey.ShortcutsEnabled = true;
            this.txtBogey.Size = new System.Drawing.Size(139, 23);
            this.txtBogey.TabIndex = 19;
            this.txtBogey.UseSelectable = true;
            this.txtBogey.WaterMark = "Number Of Bogey";
            this.txtBogey.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txtBogey.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            this.txtBogey.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TxtBogey_KeyPress);
            // 
            // lblBogey
            // 
            this.lblBogey.AutoSize = true;
            this.lblBogey.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblBogey.Location = new System.Drawing.Point(264, 297);
            this.lblBogey.Name = "lblBogey";
            this.lblBogey.Size = new System.Drawing.Size(67, 20);
            this.lblBogey.TabIndex = 18;
            this.lblBogey.Text = "Bogey:";
            // 
            // txtCapacity
            // 
            // 
            // 
            // 
            this.txtCapacity.CustomButton.Image = null;
            this.txtCapacity.CustomButton.Location = new System.Drawing.Point(117, 1);
            this.txtCapacity.CustomButton.Name = "";
            this.txtCapacity.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.txtCapacity.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txtCapacity.CustomButton.TabIndex = 1;
            this.txtCapacity.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txtCapacity.CustomButton.UseSelectable = true;
            this.txtCapacity.CustomButton.Visible = false;
            this.txtCapacity.Lines = new string[0];
            this.txtCapacity.Location = new System.Drawing.Point(110, 294);
            this.txtCapacity.MaxLength = 4;
            this.txtCapacity.Name = "txtCapacity";
            this.txtCapacity.PasswordChar = '\0';
            this.txtCapacity.PromptText = "Capacity";
            this.txtCapacity.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtCapacity.SelectedText = "";
            this.txtCapacity.SelectionLength = 0;
            this.txtCapacity.SelectionStart = 0;
            this.txtCapacity.ShortcutsEnabled = true;
            this.txtCapacity.Size = new System.Drawing.Size(139, 23);
            this.txtCapacity.TabIndex = 17;
            this.txtCapacity.UseSelectable = true;
            this.txtCapacity.WaterMark = "Capacity";
            this.txtCapacity.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txtCapacity.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            this.txtCapacity.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TxtCapacity_KeyPress);
            // 
            // lblCapacity
            // 
            this.lblCapacity.AutoSize = true;
            this.lblCapacity.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCapacity.Location = new System.Drawing.Point(3, 297);
            this.lblCapacity.Name = "lblCapacity";
            this.lblCapacity.Size = new System.Drawing.Size(88, 20);
            this.lblCapacity.TabIndex = 16;
            this.lblCapacity.Text = "Capacity:";
            // 
            // lblArrivalTime
            // 
            this.lblArrivalTime.AutoSize = true;
            this.lblArrivalTime.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblArrivalTime.Location = new System.Drawing.Point(264, 258);
            this.lblArrivalTime.Name = "lblArrivalTime";
            this.lblArrivalTime.Size = new System.Drawing.Size(87, 20);
            this.lblArrivalTime.TabIndex = 14;
            this.lblArrivalTime.Text = "Arr. Time";
            // 
            // lblTO
            // 
            this.lblTO.AutoSize = true;
            this.lblTO.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTO.Location = new System.Drawing.Point(3, 258);
            this.lblTO.Name = "lblTO";
            this.lblTO.Size = new System.Drawing.Size(36, 20);
            this.lblTO.TabIndex = 12;
            this.lblTO.Text = "To:";
            // 
            // lblLeavingTime
            // 
            this.lblLeavingTime.AutoSize = true;
            this.lblLeavingTime.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblLeavingTime.Location = new System.Drawing.Point(264, 217);
            this.lblLeavingTime.Name = "lblLeavingTime";
            this.lblLeavingTime.Size = new System.Drawing.Size(113, 20);
            this.lblLeavingTime.TabIndex = 10;
            this.lblLeavingTime.Text = "Depart Time";
            // 
            // lblFrom
            // 
            this.lblFrom.AutoSize = true;
            this.lblFrom.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFrom.Location = new System.Drawing.Point(3, 217);
            this.lblFrom.Name = "lblFrom";
            this.lblFrom.Size = new System.Drawing.Size(58, 20);
            this.lblFrom.TabIndex = 8;
            this.lblFrom.Text = "From:";
            // 
            // lblRouteType
            // 
            this.lblRouteType.AutoSize = true;
            this.lblRouteType.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblRouteType.Location = new System.Drawing.Point(-1, 178);
            this.lblRouteType.Name = "lblRouteType";
            this.lblRouteType.Size = new System.Drawing.Size(92, 18);
            this.lblRouteType.TabIndex = 6;
            this.lblRouteType.Text = "Route Type: ";
            // 
            // lblOffDay
            // 
            this.lblOffDay.AutoSize = true;
            this.lblOffDay.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblOffDay.Location = new System.Drawing.Point(3, 137);
            this.lblOffDay.Name = "lblOffDay";
            this.lblOffDay.Size = new System.Drawing.Size(80, 20);
            this.lblOffDay.TabIndex = 4;
            this.lblOffDay.Text = "Off Day:";
            // 
            // txtTrainName
            // 
            // 
            // 
            // 
            this.txtTrainName.CustomButton.Image = null;
            this.txtTrainName.CustomButton.Location = new System.Drawing.Point(117, 1);
            this.txtTrainName.CustomButton.Name = "";
            this.txtTrainName.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.txtTrainName.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txtTrainName.CustomButton.TabIndex = 1;
            this.txtTrainName.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txtTrainName.CustomButton.UseSelectable = true;
            this.txtTrainName.CustomButton.Visible = false;
            this.txtTrainName.Lines = new string[0];
            this.txtTrainName.Location = new System.Drawing.Point(392, 92);
            this.txtTrainName.MaxLength = 150;
            this.txtTrainName.Name = "txtTrainName";
            this.txtTrainName.PasswordChar = '\0';
            this.txtTrainName.PromptText = "Train Name";
            this.txtTrainName.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtTrainName.SelectedText = "";
            this.txtTrainName.SelectionLength = 0;
            this.txtTrainName.SelectionStart = 0;
            this.txtTrainName.ShortcutsEnabled = true;
            this.txtTrainName.Size = new System.Drawing.Size(139, 23);
            this.txtTrainName.TabIndex = 3;
            this.txtTrainName.UseSelectable = true;
            this.txtTrainName.WaterMark = "Train Name";
            this.txtTrainName.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txtTrainName.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            this.txtTrainName.Click += new System.EventHandler(this.TxtTrainName_Click);
            this.txtTrainName.Leave += new System.EventHandler(this.TxtTrainName_Leave);
            // 
            // lblTrainName
            // 
            this.lblTrainName.AutoSize = true;
            this.lblTrainName.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTrainName.Location = new System.Drawing.Point(271, 95);
            this.lblTrainName.Name = "lblTrainName";
            this.lblTrainName.Size = new System.Drawing.Size(112, 20);
            this.lblTrainName.TabIndex = 2;
            this.lblTrainName.Text = "Train Name:";
            this.lblTrainName.Click += new System.EventHandler(this.LblTrainName_Click);
            // 
            // txtTrainNo
            // 
            // 
            // 
            // 
            this.txtTrainNo.CustomButton.Image = null;
            this.txtTrainNo.CustomButton.Location = new System.Drawing.Point(123, 1);
            this.txtTrainNo.CustomButton.Name = "";
            this.txtTrainNo.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.txtTrainNo.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txtTrainNo.CustomButton.TabIndex = 1;
            this.txtTrainNo.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txtTrainNo.CustomButton.UseSelectable = true;
            this.txtTrainNo.CustomButton.Visible = false;
            this.txtTrainNo.Lines = new string[0];
            this.txtTrainNo.Location = new System.Drawing.Point(110, 92);
            this.txtTrainNo.MaxLength = 40;
            this.txtTrainNo.Name = "txtTrainNo";
            this.txtTrainNo.PasswordChar = '\0';
            this.txtTrainNo.PromptText = "Train No";
            this.txtTrainNo.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtTrainNo.SelectedText = "";
            this.txtTrainNo.SelectionLength = 0;
            this.txtTrainNo.SelectionStart = 0;
            this.txtTrainNo.ShortcutsEnabled = true;
            this.txtTrainNo.Size = new System.Drawing.Size(145, 23);
            this.txtTrainNo.TabIndex = 1;
            this.txtTrainNo.UseSelectable = true;
            this.txtTrainNo.WaterMark = "Train No";
            this.txtTrainNo.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txtTrainNo.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            this.txtTrainNo.Click += new System.EventHandler(this.TxtTrainNo_Click);
            this.txtTrainNo.Leave += new System.EventHandler(this.TxtTrainNo_Leave);
            // 
            // lblTrainNo
            // 
            this.lblTrainNo.AutoSize = true;
            this.lblTrainNo.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTrainNo.Location = new System.Drawing.Point(6, 92);
            this.lblTrainNo.Name = "lblTrainNo";
            this.lblTrainNo.Size = new System.Drawing.Size(87, 20);
            this.lblTrainNo.TabIndex = 0;
            this.lblTrainNo.Text = "Train No:";
            this.lblTrainNo.Click += new System.EventHandler(this.LblTrainNo_Click);
            // 
            // panel1
            // 
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.txtSearch);
            this.panel1.Controls.Add(this.dgvTrainList);
            this.panel1.Location = new System.Drawing.Point(718, 11);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(595, 610);
            this.panel1.TabIndex = 5;
            // 
            // txtSearch
            // 
            this.txtSearch.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            // 
            // 
            // 
            this.txtSearch.CustomButton.Image = null;
            this.txtSearch.CustomButton.Location = new System.Drawing.Point(565, 1);
            this.txtSearch.CustomButton.Name = "";
            this.txtSearch.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.txtSearch.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txtSearch.CustomButton.TabIndex = 1;
            this.txtSearch.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txtSearch.CustomButton.UseSelectable = true;
            this.txtSearch.CustomButton.Visible = false;
            this.txtSearch.Lines = new string[0];
            this.txtSearch.Location = new System.Drawing.Point(3, 6);
            this.txtSearch.MaxLength = 32767;
            this.txtSearch.Name = "txtSearch";
            this.txtSearch.PasswordChar = '\0';
            this.txtSearch.PromptText = "Please search route by train ID or Train Name";
            this.txtSearch.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtSearch.SelectedText = "";
            this.txtSearch.SelectionLength = 0;
            this.txtSearch.SelectionStart = 0;
            this.txtSearch.ShortcutsEnabled = true;
            this.txtSearch.Size = new System.Drawing.Size(587, 23);
            this.txtSearch.TabIndex = 13;
            this.txtSearch.UseSelectable = true;
            this.txtSearch.WaterMark = "Please search route by train ID or Train Name";
            this.txtSearch.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txtSearch.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            this.txtSearch.TextChanged += new System.EventHandler(this.TxtSearch_TextChanged);
            // 
            // dgvTrainList
            // 
            this.dgvTrainList.AllowUserToAddRows = false;
            this.dgvTrainList.AllowUserToDeleteRows = false;
            this.dgvTrainList.AllowUserToResizeRows = false;
            this.dgvTrainList.BackgroundColor = System.Drawing.Color.DarkGray;
            this.dgvTrainList.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgvTrainList.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            this.dgvTrainList.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(174)))), ((int)(((byte)(219)))));
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(198)))), ((int)(((byte)(247)))));
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvTrainList.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvTrainList.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvTrainList.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.trainid,
            this.trainno,
            this.name,
            this.offday,
            this.departurestation,
            this.departuretime,
            this.arrivalstation,
            this.arrivaltime,
            this.routetype,
            this.capacity,
            this.bogey,
            this.standard,
            this.priceperstandard,
            this.economy,
            this.pricepereconomy,
            this.firstclass,
            this.priceperfirstclass,
            this.bogeyinfo});
            this.dgvTrainList.ContextMenuStrip = this.cmsRefresh;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(136)))), ((int)(((byte)(136)))), ((int)(((byte)(136)))));
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(198)))), ((int)(((byte)(247)))));
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvTrainList.DefaultCellStyle = dataGridViewCellStyle2;
            this.dgvTrainList.EnableHeadersVisualStyles = false;
            this.dgvTrainList.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.dgvTrainList.GridColor = System.Drawing.Color.Black;
            this.dgvTrainList.Location = new System.Drawing.Point(3, 35);
            this.dgvTrainList.Name = "dgvTrainList";
            this.dgvTrainList.ReadOnly = true;
            this.dgvTrainList.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(174)))), ((int)(((byte)(219)))));
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(198)))), ((int)(((byte)(247)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvTrainList.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.dgvTrainList.RowHeadersWidth = 51;
            this.dgvTrainList.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.dgvTrainList.RowTemplate.Height = 24;
            this.dgvTrainList.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvTrainList.Size = new System.Drawing.Size(591, 570);
            this.dgvTrainList.TabIndex = 12;
            // 
            // trainid
            // 
            this.trainid.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.trainid.DataPropertyName = "trainid";
            this.trainid.HeaderText = "Train ID";
            this.trainid.MinimumWidth = 125;
            this.trainid.Name = "trainid";
            this.trainid.ReadOnly = true;
            // 
            // trainno
            // 
            this.trainno.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.trainno.DataPropertyName = "trainno";
            this.trainno.HeaderText = "Train No";
            this.trainno.MinimumWidth = 150;
            this.trainno.Name = "trainno";
            this.trainno.ReadOnly = true;
            // 
            // name
            // 
            this.name.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.name.DataPropertyName = "name";
            this.name.HeaderText = "Train Name";
            this.name.MinimumWidth = 300;
            this.name.Name = "name";
            this.name.ReadOnly = true;
            // 
            // offday
            // 
            this.offday.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.offday.DataPropertyName = "offday";
            this.offday.HeaderText = "Off Day";
            this.offday.MinimumWidth = 150;
            this.offday.Name = "offday";
            this.offday.ReadOnly = true;
            // 
            // departurestation
            // 
            this.departurestation.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.departurestation.DataPropertyName = "departurestation";
            this.departurestation.HeaderText = "From";
            this.departurestation.MinimumWidth = 200;
            this.departurestation.Name = "departurestation";
            this.departurestation.ReadOnly = true;
            // 
            // departuretime
            // 
            this.departuretime.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.departuretime.DataPropertyName = "departuretime";
            this.departuretime.HeaderText = "Time";
            this.departuretime.MinimumWidth = 150;
            this.departuretime.Name = "departuretime";
            this.departuretime.ReadOnly = true;
            // 
            // arrivalstation
            // 
            this.arrivalstation.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.arrivalstation.DataPropertyName = "arrivalstation";
            this.arrivalstation.HeaderText = "To";
            this.arrivalstation.MinimumWidth = 200;
            this.arrivalstation.Name = "arrivalstation";
            this.arrivalstation.ReadOnly = true;
            // 
            // arrivaltime
            // 
            this.arrivaltime.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.arrivaltime.DataPropertyName = "arrivaltime";
            this.arrivaltime.HeaderText = "Time";
            this.arrivaltime.MinimumWidth = 150;
            this.arrivaltime.Name = "arrivaltime";
            this.arrivaltime.ReadOnly = true;
            // 
            // routetype
            // 
            this.routetype.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.routetype.DataPropertyName = "routetype";
            this.routetype.HeaderText = "Route Type";
            this.routetype.MinimumWidth = 300;
            this.routetype.Name = "routetype";
            this.routetype.ReadOnly = true;
            // 
            // capacity
            // 
            this.capacity.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.capacity.DataPropertyName = "capacity";
            this.capacity.HeaderText = "Capacity";
            this.capacity.MinimumWidth = 150;
            this.capacity.Name = "capacity";
            this.capacity.ReadOnly = true;
            // 
            // bogey
            // 
            this.bogey.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.bogey.DataPropertyName = "bogey";
            this.bogey.HeaderText = "No Of Bogye";
            this.bogey.MinimumWidth = 150;
            this.bogey.Name = "bogey";
            this.bogey.ReadOnly = true;
            // 
            // standard
            // 
            this.standard.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.standard.DataPropertyName = "standard";
            this.standard.HeaderText = "Standard (AC Couch)";
            this.standard.MinimumWidth = 150;
            this.standard.Name = "standard";
            this.standard.ReadOnly = true;
            // 
            // priceperstandard
            // 
            this.priceperstandard.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.priceperstandard.DataPropertyName = "priceperstandard";
            this.priceperstandard.HeaderText = "Price/Couch";
            this.priceperstandard.MinimumWidth = 150;
            this.priceperstandard.Name = "priceperstandard";
            this.priceperstandard.ReadOnly = true;
            // 
            // economy
            // 
            this.economy.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.economy.DataPropertyName = "economy";
            this.economy.HeaderText = "Economy (Non-AC Couch)";
            this.economy.MinimumWidth = 150;
            this.economy.Name = "economy";
            this.economy.ReadOnly = true;
            // 
            // pricepereconomy
            // 
            this.pricepereconomy.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.pricepereconomy.DataPropertyName = "pricepereconomy";
            this.pricepereconomy.HeaderText = "Price/Couch";
            this.pricepereconomy.MinimumWidth = 150;
            this.pricepereconomy.Name = "pricepereconomy";
            this.pricepereconomy.ReadOnly = true;
            // 
            // firstclass
            // 
            this.firstclass.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.firstclass.DataPropertyName = "firstclass";
            this.firstclass.HeaderText = "First Class(AC Cabin)";
            this.firstclass.MinimumWidth = 150;
            this.firstclass.Name = "firstclass";
            this.firstclass.ReadOnly = true;
            // 
            // priceperfirstclass
            // 
            this.priceperfirstclass.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.priceperfirstclass.DataPropertyName = "priceperfirstclass";
            this.priceperfirstclass.HeaderText = "Price/Cabin";
            this.priceperfirstclass.MinimumWidth = 150;
            this.priceperfirstclass.Name = "priceperfirstclass";
            this.priceperfirstclass.ReadOnly = true;
            // 
            // bogeyinfo
            // 
            this.bogeyinfo.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.bogeyinfo.DataPropertyName = "bogeyinfo";
            this.bogeyinfo.HeaderText = "Bogey Details";
            this.bogeyinfo.MinimumWidth = 1200;
            this.bogeyinfo.Name = "bogeyinfo";
            this.bogeyinfo.ReadOnly = true;
            // 
            // errDigit
            // 
            this.errDigit.ContainerControl = this;
            // 
            // errString
            // 
            this.errString.ContainerControl = this;
            // 
            // TrainAndRoute
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Teal;
            this.ClientSize = new System.Drawing.Size(1325, 631);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.pnlTrainInfo);
            this.Controls.Add(this.pnlButtonList);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "TrainAndRoute";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Train & Route Info";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.TrainInfo_FormClosed);
            this.pnlButtonList.ResumeLayout(false);
            this.pnlTrainInfo.ResumeLayout(false);
            this.pnlTrainInfo.PerformLayout();
            this.cmsRefresh.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvTrainList)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errDigit)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errString)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

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
        private System.Windows.Forms.Panel pnlTrainInfo;
        private System.Windows.Forms.Panel panel1;
        private MetroFramework.Controls.MetroGrid dgvTrainList;
        private MetroFramework.Controls.MetroTextBox txtTrainNo;
        private System.Windows.Forms.Label lblTrainNo;
        private MetroFramework.Controls.MetroTextBox txtTrainName;
        private System.Windows.Forms.Label lblTrainName;
        private System.Windows.Forms.Label lblOffDay;
        private System.Windows.Forms.Label lblRouteType;
        private System.Windows.Forms.Label lblFrom;
        private System.Windows.Forms.Label lblLeavingTime;
        private System.Windows.Forms.Label lblArrivalTime;
        private System.Windows.Forms.Label lblTO;
        private MetroFramework.Controls.MetroTextBox txtBogey;
        private System.Windows.Forms.Label lblBogey;
        private MetroFramework.Controls.MetroTextBox txtCapacity;
        private System.Windows.Forms.Label lblCapacity;
        private MetroFramework.Controls.MetroTextBox txtStandard;
        private System.Windows.Forms.Label lblStandard;
        private MetroFramework.Controls.MetroTextBox txtFirstClass;
        private System.Windows.Forms.Label lblFirstClass;
        private MetroFramework.Controls.MetroTextBox txtEconomy;
        private System.Windows.Forms.Label lblEconomy;
        private MetroFramework.Controls.MetroTextBox txtPricerEconomy;
        private System.Windows.Forms.Label label3;
        private MetroFramework.Controls.MetroTextBox txtPriceStandard;
        private System.Windows.Forms.Label label2;
        private MetroFramework.Controls.MetroTextBox txtPriceFirstClass;
        private System.Windows.Forms.Label lblPriceFirst;
        private MetroFramework.Controls.MetroTextBox txtBogeyInfo;
        private System.Windows.Forms.Label lblBogeyInfo;
        private System.Windows.Forms.Label lblHeading;
        private System.Windows.Forms.DataGridViewTextBoxColumn trainid;
        private System.Windows.Forms.DataGridViewTextBoxColumn trainno;
        private System.Windows.Forms.DataGridViewTextBoxColumn name;
        private System.Windows.Forms.DataGridViewTextBoxColumn offday;
        private System.Windows.Forms.DataGridViewTextBoxColumn departurestation;
        private System.Windows.Forms.DataGridViewTextBoxColumn departuretime;
        private System.Windows.Forms.DataGridViewTextBoxColumn arrivalstation;
        private System.Windows.Forms.DataGridViewTextBoxColumn arrivaltime;
        private System.Windows.Forms.DataGridViewTextBoxColumn routetype;
        private System.Windows.Forms.DataGridViewTextBoxColumn capacity;
        private System.Windows.Forms.DataGridViewTextBoxColumn bogey;
        private System.Windows.Forms.DataGridViewTextBoxColumn standard;
        private System.Windows.Forms.DataGridViewTextBoxColumn priceperstandard;
        private System.Windows.Forms.DataGridViewTextBoxColumn economy;
        private System.Windows.Forms.DataGridViewTextBoxColumn pricepereconomy;
        private System.Windows.Forms.DataGridViewTextBoxColumn firstclass;
        private System.Windows.Forms.DataGridViewTextBoxColumn priceperfirstclass;
        private System.Windows.Forms.DataGridViewTextBoxColumn bogeyinfo;
        private MetroFramework.Controls.MetroTextBox txtSearch;
        private System.Windows.Forms.Button btnRefresh;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Label lblTrainIDHeading;
        private System.Windows.Forms.Label lblTrainID;
        private System.Windows.Forms.DateTimePicker dtpFrom;
        private System.Windows.Forms.DateTimePicker dtpTo;
        private System.Windows.Forms.TextBox txtOffDay;
        private System.Windows.Forms.TextBox txtRouteType;
        private System.Windows.Forms.TextBox txtFrom;
        private System.Windows.Forms.TextBox txtTo;
        private System.Windows.Forms.ErrorProvider errDigit;
        private System.Windows.Forms.ErrorProvider errString;
        private System.Windows.Forms.ContextMenuStrip cmsRefresh;
        private System.Windows.Forms.ToolStripMenuItem refreshToolStripMenuItem;
    }
}