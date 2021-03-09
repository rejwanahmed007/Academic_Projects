namespace TMS.ApplicationLayer
{
    partial class PassengersFeedback
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(PassengersFeedback));
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.dgvComplainDetails = new MetroFramework.Controls.MetroGrid();
            this.cmsRefresh = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.refreshToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.txtSearch = new MetroFramework.Controls.MetroTextBox();
            this.pnlSearch = new System.Windows.Forms.Panel();
            this.lblIssueDate = new System.Windows.Forms.Label();
            this.btnRefresh = new System.Windows.Forms.Button();
            this.lblProfit = new System.Windows.Forms.Label();
            this.btnSearch = new System.Windows.Forms.Button();
            this.lblTo = new System.Windows.Forms.Label();
            this.dtpTO = new System.Windows.Forms.DateTimePicker();
            this.lblFrom = new System.Windows.Forms.Label();
            this.dtpFrom = new System.Windows.Forms.DateTimePicker();
            this.complainid = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.details = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.complaindate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.passengerid = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.passengername = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.mobilenumber = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.email = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.address = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pnlButtonList.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvComplainDetails)).BeginInit();
            this.cmsRefresh.SuspendLayout();
            this.pnlSearch.SuspendLayout();
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
            this.pnlButtonList.TabIndex = 2;
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
            // panel1
            // 
            this.panel1.Controls.Add(this.dgvComplainDetails);
            this.panel1.Controls.Add(this.txtSearch);
            this.panel1.Location = new System.Drawing.Point(177, 149);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1136, 467);
            this.panel1.TabIndex = 3;
            // 
            // dgvComplainDetails
            // 
            this.dgvComplainDetails.AllowUserToAddRows = false;
            this.dgvComplainDetails.AllowUserToDeleteRows = false;
            this.dgvComplainDetails.AllowUserToResizeRows = false;
            this.dgvComplainDetails.BackgroundColor = System.Drawing.Color.DarkGray;
            this.dgvComplainDetails.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgvComplainDetails.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            this.dgvComplainDetails.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(174)))), ((int)(((byte)(219)))));
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(198)))), ((int)(((byte)(247)))));
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvComplainDetails.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvComplainDetails.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvComplainDetails.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.complainid,
            this.details,
            this.complaindate,
            this.passengerid,
            this.passengername,
            this.mobilenumber,
            this.email,
            this.address});
            this.dgvComplainDetails.ContextMenuStrip = this.cmsRefresh;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(136)))), ((int)(((byte)(136)))), ((int)(((byte)(136)))));
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(198)))), ((int)(((byte)(247)))));
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvComplainDetails.DefaultCellStyle = dataGridViewCellStyle2;
            this.dgvComplainDetails.EnableHeadersVisualStyles = false;
            this.dgvComplainDetails.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.dgvComplainDetails.GridColor = System.Drawing.Color.Black;
            this.dgvComplainDetails.Location = new System.Drawing.Point(3, 32);
            this.dgvComplainDetails.Name = "dgvComplainDetails";
            this.dgvComplainDetails.ReadOnly = true;
            this.dgvComplainDetails.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(174)))), ((int)(((byte)(219)))));
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(198)))), ((int)(((byte)(247)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvComplainDetails.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.dgvComplainDetails.RowHeadersWidth = 51;
            this.dgvComplainDetails.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.dgvComplainDetails.RowTemplate.Height = 24;
            this.dgvComplainDetails.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvComplainDetails.Size = new System.Drawing.Size(1145, 432);
            this.dgvComplainDetails.TabIndex = 11;
            this.dgvComplainDetails.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DgvComplainDetails_CellContentClick);
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
            this.txtSearch.CustomButton.Location = new System.Drawing.Point(1108, 1);
            this.txtSearch.CustomButton.Name = "";
            this.txtSearch.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.txtSearch.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txtSearch.CustomButton.TabIndex = 1;
            this.txtSearch.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txtSearch.CustomButton.UseSelectable = true;
            this.txtSearch.CustomButton.Visible = false;
            this.txtSearch.Lines = new string[0];
            this.txtSearch.Location = new System.Drawing.Point(3, 3);
            this.txtSearch.MaxLength = 32767;
            this.txtSearch.Name = "txtSearch";
            this.txtSearch.PasswordChar = '\0';
            this.txtSearch.PromptText = "Please search by passenger id or complain id";
            this.txtSearch.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtSearch.SelectedText = "";
            this.txtSearch.SelectionLength = 0;
            this.txtSearch.SelectionStart = 0;
            this.txtSearch.ShortcutsEnabled = true;
            this.txtSearch.Size = new System.Drawing.Size(1130, 23);
            this.txtSearch.TabIndex = 10;
            this.txtSearch.UseSelectable = true;
            this.txtSearch.WaterMark = "Please search by passenger id or complain id";
            this.txtSearch.WaterMarkColor = System.Drawing.Color.Maroon;
            this.txtSearch.WaterMarkFont = new System.Drawing.Font("Segoe UI", 7.2F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSearch.TextChanged += new System.EventHandler(this.TxtSearch_TextChanged);
            // 
            // pnlSearch
            // 
            this.pnlSearch.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnlSearch.ContextMenuStrip = this.cmsRefresh;
            this.pnlSearch.Controls.Add(this.lblIssueDate);
            this.pnlSearch.Controls.Add(this.btnRefresh);
            this.pnlSearch.Controls.Add(this.lblProfit);
            this.pnlSearch.Controls.Add(this.btnSearch);
            this.pnlSearch.Controls.Add(this.lblTo);
            this.pnlSearch.Controls.Add(this.dtpTO);
            this.pnlSearch.Controls.Add(this.lblFrom);
            this.pnlSearch.Controls.Add(this.dtpFrom);
            this.pnlSearch.Location = new System.Drawing.Point(177, 9);
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
            // btnRefresh
            // 
            this.btnRefresh.BackColor = System.Drawing.Color.Violet;
            this.btnRefresh.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRefresh.Location = new System.Drawing.Point(350, 80);
            this.btnRefresh.Name = "btnRefresh";
            this.btnRefresh.Size = new System.Drawing.Size(155, 32);
            this.btnRefresh.TabIndex = 10;
            this.btnRefresh.Text = "Refresh";
            this.btnRefresh.UseVisualStyleBackColor = false;
            this.btnRefresh.Click += new System.EventHandler(this.BtnRefresh_Click);
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
            // complainid
            // 
            this.complainid.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.complainid.DataPropertyName = "complainid";
            this.complainid.FillWeight = 25.66845F;
            this.complainid.HeaderText = "Complain ID";
            this.complainid.MinimumWidth = 100;
            this.complainid.Name = "complainid";
            this.complainid.ReadOnly = true;
            // 
            // details
            // 
            this.details.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.details.DataPropertyName = "details";
            this.details.FillWeight = 25.66845F;
            this.details.HeaderText = "Feedback Details";
            this.details.MinimumWidth = 350;
            this.details.Name = "details";
            this.details.ReadOnly = true;
            // 
            // complaindate
            // 
            this.complaindate.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.complaindate.DataPropertyName = "complaindate";
            this.complaindate.FillWeight = 25.66845F;
            this.complaindate.HeaderText = "Issued Date";
            this.complaindate.MinimumWidth = 125;
            this.complaindate.Name = "complaindate";
            this.complaindate.ReadOnly = true;
            // 
            // passengerid
            // 
            this.passengerid.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.passengerid.DataPropertyName = "passengerid";
            this.passengerid.FillWeight = 25.66845F;
            this.passengerid.HeaderText = "Passenger ID";
            this.passengerid.MinimumWidth = 100;
            this.passengerid.Name = "passengerid";
            this.passengerid.ReadOnly = true;
            // 
            // passengername
            // 
            this.passengername.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.passengername.DataPropertyName = "passengername";
            this.passengername.FillWeight = 25.66845F;
            this.passengername.HeaderText = "Passenger Name";
            this.passengername.MinimumWidth = 200;
            this.passengername.Name = "passengername";
            this.passengername.ReadOnly = true;
            // 
            // mobilenumber
            // 
            this.mobilenumber.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.mobilenumber.DataPropertyName = "mobilenumber";
            this.mobilenumber.FillWeight = 25.66845F;
            this.mobilenumber.HeaderText = "Passenger Mobile No";
            this.mobilenumber.MinimumWidth = 150;
            this.mobilenumber.Name = "mobilenumber";
            this.mobilenumber.ReadOnly = true;
            // 
            // email
            // 
            this.email.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.email.DataPropertyName = "email";
            this.email.FillWeight = 25.66845F;
            this.email.HeaderText = "Passenger Email";
            this.email.MinimumWidth = 150;
            this.email.Name = "email";
            this.email.ReadOnly = true;
            // 
            // address
            // 
            this.address.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.address.DataPropertyName = "address";
            this.address.FillWeight = 620.3209F;
            this.address.HeaderText = "Address";
            this.address.MinimumWidth = 300;
            this.address.Name = "address";
            this.address.ReadOnly = true;
            // 
            // PassengersFeedback
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Teal;
            this.ClientSize = new System.Drawing.Size(1325, 628);
            this.ContextMenuStrip = this.cmsRefresh;
            this.Controls.Add(this.pnlSearch);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.pnlButtonList);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "PassengersFeedback";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Passengers Feedback";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.PassengersFeedback_FormClosed);
            this.pnlButtonList.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvComplainDetails)).EndInit();
            this.cmsRefresh.ResumeLayout(false);
            this.pnlSearch.ResumeLayout(false);
            this.pnlSearch.PerformLayout();
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
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel pnlSearch;
        private System.Windows.Forms.Label lblIssueDate;
        private System.Windows.Forms.Button btnRefresh;
        private System.Windows.Forms.Label lblProfit;
        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.Label lblTo;
        private System.Windows.Forms.DateTimePicker dtpTO;
        private System.Windows.Forms.Label lblFrom;
        private System.Windows.Forms.DateTimePicker dtpFrom;
        private MetroFramework.Controls.MetroTextBox txtSearch;
        private MetroFramework.Controls.MetroGrid dgvComplainDetails;
        private System.Windows.Forms.ContextMenuStrip cmsRefresh;
        private System.Windows.Forms.ToolStripMenuItem refreshToolStripMenuItem;
        private System.Windows.Forms.DataGridViewTextBoxColumn complainid;
        private System.Windows.Forms.DataGridViewTextBoxColumn details;
        private System.Windows.Forms.DataGridViewTextBoxColumn complaindate;
        private System.Windows.Forms.DataGridViewTextBoxColumn passengerid;
        private System.Windows.Forms.DataGridViewTextBoxColumn passengername;
        private System.Windows.Forms.DataGridViewTextBoxColumn mobilenumber;
        private System.Windows.Forms.DataGridViewTextBoxColumn email;
        private System.Windows.Forms.DataGridViewTextBoxColumn address;
    }
}