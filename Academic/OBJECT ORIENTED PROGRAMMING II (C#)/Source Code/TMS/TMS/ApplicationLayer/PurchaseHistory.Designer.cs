namespace TMS.ApplicationLayer
{
    partial class PurchaseHistory
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(PurchaseHistory));
            this.pnlButtonList = new System.Windows.Forms.Panel();
            this.pnlUserControlList = new System.Windows.Forms.Panel();
            this.btnExit = new System.Windows.Forms.Button();
            this.btnSignOut = new System.Windows.Forms.Button();
            this.btnUserProfile = new System.Windows.Forms.Button();
            this.btnPurchaseHistory = new System.Windows.Forms.Button();
            this.btnTrainRoute = new System.Windows.Forms.Button();
            this.btnFareQuery = new System.Windows.Forms.Button();
            this.btnDashboard = new System.Windows.Forms.Button();
            this.dgvPurchaseHistory = new MetroFramework.Controls.MetroGrid();
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
            this.lblExpense = new System.Windows.Forms.Label();
            this.pnlComplain = new System.Windows.Forms.Panel();
            this.txtComplain = new MetroFramework.Controls.MetroTextBox();
            this.lblComlain = new System.Windows.Forms.Label();
            this.btnSave = new System.Windows.Forms.Button();
            this.lblCost = new System.Windows.Forms.Label();
            this.dtpFrom = new System.Windows.Forms.DateTimePicker();
            this.lblFrom = new System.Windows.Forms.Label();
            this.dtpTO = new System.Windows.Forms.DateTimePicker();
            this.lblTo = new System.Windows.Forms.Label();
            this.btnSearch = new System.Windows.Forms.Button();
            this.lblProfit = new System.Windows.Forms.Label();
            this.btnRefresh = new System.Windows.Forms.Button();
            this.lblIssueDate = new System.Windows.Forms.Label();
            this.pnlSearch = new System.Windows.Forms.Panel();
            this.pnlButtonList.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPurchaseHistory)).BeginInit();
            this.cmsRefresh.SuspendLayout();
            this.pnlComplain.SuspendLayout();
            this.pnlSearch.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnlButtonList
            // 
            this.pnlButtonList.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.pnlButtonList.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.pnlButtonList.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnlButtonList.Controls.Add(this.pnlUserControlList);
            this.pnlButtonList.Controls.Add(this.btnExit);
            this.pnlButtonList.Controls.Add(this.btnSignOut);
            this.pnlButtonList.Controls.Add(this.btnUserProfile);
            this.pnlButtonList.Controls.Add(this.btnPurchaseHistory);
            this.pnlButtonList.Controls.Add(this.btnTrainRoute);
            this.pnlButtonList.Controls.Add(this.btnFareQuery);
            this.pnlButtonList.Controls.Add(this.btnDashboard);
            this.pnlButtonList.Location = new System.Drawing.Point(12, 11);
            this.pnlButtonList.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.pnlButtonList.Name = "pnlButtonList";
            this.pnlButtonList.Size = new System.Drawing.Size(150, 531);
            this.pnlButtonList.TabIndex = 5;
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
            this.btnExit.Location = new System.Drawing.Point(3, 443);
            this.btnExit.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(140, 79);
            this.btnExit.TabIndex = 6;
            this.btnExit.Text = "Exit";
            this.btnExit.UseVisualStyleBackColor = false;
            this.btnExit.Click += new System.EventHandler(this.BtnExit_Click);
            // 
            // btnSignOut
            // 
            this.btnSignOut.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.btnSignOut.Font = new System.Drawing.Font("Times New Roman", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSignOut.Location = new System.Drawing.Point(3, 373);
            this.btnSignOut.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnSignOut.Name = "btnSignOut";
            this.btnSignOut.Size = new System.Drawing.Size(140, 66);
            this.btnSignOut.TabIndex = 5;
            this.btnSignOut.Text = "Sign Out";
            this.btnSignOut.UseVisualStyleBackColor = false;
            this.btnSignOut.Click += new System.EventHandler(this.BtnSignOut_Click);
            // 
            // btnUserProfile
            // 
            this.btnUserProfile.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.btnUserProfile.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnUserProfile.Location = new System.Drawing.Point(3, 287);
            this.btnUserProfile.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnUserProfile.Name = "btnUserProfile";
            this.btnUserProfile.Size = new System.Drawing.Size(140, 82);
            this.btnUserProfile.TabIndex = 4;
            this.btnUserProfile.Text = "Change Password";
            this.btnUserProfile.UseVisualStyleBackColor = false;
            this.btnUserProfile.Click += new System.EventHandler(this.BtnUserProfile_Click);
            // 
            // btnPurchaseHistory
            // 
            this.btnPurchaseHistory.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.btnPurchaseHistory.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPurchaseHistory.Location = new System.Drawing.Point(3, 216);
            this.btnPurchaseHistory.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnPurchaseHistory.Name = "btnPurchaseHistory";
            this.btnPurchaseHistory.Size = new System.Drawing.Size(140, 66);
            this.btnPurchaseHistory.TabIndex = 3;
            this.btnPurchaseHistory.Text = "Purchase History";
            this.btnPurchaseHistory.UseVisualStyleBackColor = false;
            this.btnPurchaseHistory.Click += new System.EventHandler(this.BtnPurchaseHistory_Click);
            // 
            // btnTrainRoute
            // 
            this.btnTrainRoute.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.btnTrainRoute.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnTrainRoute.Location = new System.Drawing.Point(-1, 145);
            this.btnTrainRoute.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnTrainRoute.Name = "btnTrainRoute";
            this.btnTrainRoute.Size = new System.Drawing.Size(140, 66);
            this.btnTrainRoute.TabIndex = 2;
            this.btnTrainRoute.Text = "Train Route";
            this.btnTrainRoute.UseVisualStyleBackColor = false;
            this.btnTrainRoute.Click += new System.EventHandler(this.BtnTrainRoute_Click);
            // 
            // btnFareQuery
            // 
            this.btnFareQuery.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.btnFareQuery.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnFareQuery.Location = new System.Drawing.Point(3, 74);
            this.btnFareQuery.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnFareQuery.Name = "btnFareQuery";
            this.btnFareQuery.Size = new System.Drawing.Size(140, 66);
            this.btnFareQuery.TabIndex = 1;
            this.btnFareQuery.Text = "Fare Query";
            this.btnFareQuery.UseVisualStyleBackColor = false;
            this.btnFareQuery.Click += new System.EventHandler(this.BtnFareQuery_Click);
            // 
            // btnDashboard
            // 
            this.btnDashboard.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.btnDashboard.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDashboard.Location = new System.Drawing.Point(3, 2);
            this.btnDashboard.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnDashboard.Name = "btnDashboard";
            this.btnDashboard.Size = new System.Drawing.Size(140, 66);
            this.btnDashboard.TabIndex = 0;
            this.btnDashboard.Text = "Dashboard";
            this.btnDashboard.UseVisualStyleBackColor = false;
            this.btnDashboard.Click += new System.EventHandler(this.BtnDashboard_Click);
            // 
            // dgvPurchaseHistory
            // 
            this.dgvPurchaseHistory.AllowUserToAddRows = false;
            this.dgvPurchaseHistory.AllowUserToDeleteRows = false;
            this.dgvPurchaseHistory.AllowUserToResizeRows = false;
            this.dgvPurchaseHistory.BackgroundColor = System.Drawing.Color.DarkGray;
            this.dgvPurchaseHistory.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgvPurchaseHistory.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            this.dgvPurchaseHistory.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(174)))), ((int)(((byte)(219)))));
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(198)))), ((int)(((byte)(247)))));
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvPurchaseHistory.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvPurchaseHistory.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvPurchaseHistory.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
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
            this.dgvPurchaseHistory.ContextMenuStrip = this.cmsRefresh;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(136)))), ((int)(((byte)(136)))), ((int)(((byte)(136)))));
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(198)))), ((int)(((byte)(247)))));
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvPurchaseHistory.DefaultCellStyle = dataGridViewCellStyle2;
            this.dgvPurchaseHistory.EnableHeadersVisualStyles = false;
            this.dgvPurchaseHistory.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.dgvPurchaseHistory.GridColor = System.Drawing.Color.Black;
            this.dgvPurchaseHistory.Location = new System.Drawing.Point(168, 195);
            this.dgvPurchaseHistory.Name = "dgvPurchaseHistory";
            this.dgvPurchaseHistory.ReadOnly = true;
            this.dgvPurchaseHistory.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(174)))), ((int)(((byte)(219)))));
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(198)))), ((int)(((byte)(247)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvPurchaseHistory.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.dgvPurchaseHistory.RowHeadersWidth = 51;
            this.dgvPurchaseHistory.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.dgvPurchaseHistory.RowTemplate.Height = 24;
            this.dgvPurchaseHistory.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvPurchaseHistory.Size = new System.Drawing.Size(1145, 326);
            this.dgvPurchaseHistory.TabIndex = 6;
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
            this.txtSearch.CustomButton.Location = new System.Drawing.Point(721, 1);
            this.txtSearch.CustomButton.Name = "";
            this.txtSearch.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.txtSearch.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txtSearch.CustomButton.TabIndex = 1;
            this.txtSearch.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txtSearch.CustomButton.UseSelectable = true;
            this.txtSearch.CustomButton.Visible = false;
            this.txtSearch.Lines = new string[0];
            this.txtSearch.Location = new System.Drawing.Point(168, 166);
            this.txtSearch.MaxLength = 32767;
            this.txtSearch.Name = "txtSearch";
            this.txtSearch.PasswordChar = '\0';
            this.txtSearch.PromptText = "Please search your purchase history by train name  or journey date";
            this.txtSearch.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtSearch.SelectedText = "";
            this.txtSearch.SelectionLength = 0;
            this.txtSearch.SelectionStart = 0;
            this.txtSearch.ShortcutsEnabled = true;
            this.txtSearch.Size = new System.Drawing.Size(743, 23);
            this.txtSearch.TabIndex = 9;
            this.txtSearch.UseSelectable = true;
            this.txtSearch.WaterMark = "Please search your purchase history by train name  or journey date";
            this.txtSearch.WaterMarkColor = System.Drawing.Color.Maroon;
            this.txtSearch.WaterMarkFont = new System.Drawing.Font("Segoe UI", 7.2F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSearch.TextChanged += new System.EventHandler(this.TxtSearch_TextChanged);
            // 
            // lblExpense
            // 
            this.lblExpense.AutoSize = true;
            this.lblExpense.ContextMenuStrip = this.cmsRefresh;
            this.lblExpense.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblExpense.Location = new System.Drawing.Point(926, 163);
            this.lblExpense.Name = "lblExpense";
            this.lblExpense.Size = new System.Drawing.Size(143, 29);
            this.lblExpense.TabIndex = 22;
            this.lblExpense.Text = "Expense = ";
            this.lblExpense.Click += new System.EventHandler(this.LblRevenue_Click);
            // 
            // pnlComplain
            // 
            this.pnlComplain.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnlComplain.ContextMenuStrip = this.cmsRefresh;
            this.pnlComplain.Controls.Add(this.txtComplain);
            this.pnlComplain.Controls.Add(this.lblComlain);
            this.pnlComplain.Controls.Add(this.btnSave);
            this.pnlComplain.Location = new System.Drawing.Point(695, 19);
            this.pnlComplain.Name = "pnlComplain";
            this.pnlComplain.Size = new System.Drawing.Size(629, 133);
            this.pnlComplain.TabIndex = 25;
            // 
            // txtComplain
            // 
            // 
            // 
            // 
            this.txtComplain.CustomButton.Image = null;
            this.txtComplain.CustomButton.Location = new System.Drawing.Point(392, 2);
            this.txtComplain.CustomButton.Name = "";
            this.txtComplain.CustomButton.Size = new System.Drawing.Size(95, 95);
            this.txtComplain.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txtComplain.CustomButton.TabIndex = 1;
            this.txtComplain.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txtComplain.CustomButton.UseSelectable = true;
            this.txtComplain.CustomButton.Visible = false;
            this.txtComplain.Lines = new string[0];
            this.txtComplain.Location = new System.Drawing.Point(9, 13);
            this.txtComplain.MaxLength = 500;
            this.txtComplain.MinimumSize = new System.Drawing.Size(100, 100);
            this.txtComplain.Name = "txtComplain";
            this.txtComplain.PasswordChar = '\0';
            this.txtComplain.PromptText = "* If You Have Any Complain, Please Write Below and Save [Maximum 500 Letters]";
            this.txtComplain.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtComplain.SelectedText = "";
            this.txtComplain.SelectionLength = 0;
            this.txtComplain.SelectionStart = 0;
            this.txtComplain.ShortcutsEnabled = true;
            this.txtComplain.Size = new System.Drawing.Size(490, 100);
            this.txtComplain.TabIndex = 27;
            this.txtComplain.UseSelectable = true;
            this.txtComplain.WaterMark = "* If You Have Any Complain, Please Write Below and Save [Maximum 500 Letters]";
            this.txtComplain.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txtComplain.WaterMarkFont = new System.Drawing.Font("Times New Roman", 7.2F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
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
            // btnSave
            // 
            this.btnSave.BackColor = System.Drawing.Color.SteelBlue;
            this.btnSave.ContextMenuStrip = this.cmsRefresh;
            this.btnSave.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSave.Location = new System.Drawing.Point(505, 13);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(119, 100);
            this.btnSave.TabIndex = 26;
            this.btnSave.Text = "Save Complain";
            this.btnSave.UseVisualStyleBackColor = false;
            this.btnSave.Click += new System.EventHandler(this.BtnSave_Click);
            // 
            // lblCost
            // 
            this.lblCost.AutoSize = true;
            this.lblCost.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCost.Location = new System.Drawing.Point(1102, 163);
            this.lblCost.Name = "lblCost";
            this.lblCost.Size = new System.Drawing.Size(0, 25);
            this.lblCost.TabIndex = 25;
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
            this.dtpFrom.ValueChanged += new System.EventHandler(this.DtpFrom_ValueChanged);
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
            // lblProfit
            // 
            this.lblProfit.AutoSize = true;
            this.lblProfit.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblProfit.Location = new System.Drawing.Point(958, 54);
            this.lblProfit.Name = "lblProfit";
            this.lblProfit.Size = new System.Drawing.Size(0, 29);
            this.lblProfit.TabIndex = 23;
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
            this.pnlSearch.Location = new System.Drawing.Point(168, 18);
            this.pnlSearch.Name = "pnlSearch";
            this.pnlSearch.Size = new System.Drawing.Size(521, 134);
            this.pnlSearch.TabIndex = 11;
            // 
            // PurchaseHistory
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.BackColor = System.Drawing.Color.Teal;
            this.ClientSize = new System.Drawing.Size(1325, 545);
            this.Controls.Add(this.lblCost);
            this.Controls.Add(this.pnlComplain);
            this.Controls.Add(this.pnlSearch);
            this.Controls.Add(this.txtSearch);
            this.Controls.Add(this.dgvPurchaseHistory);
            this.Controls.Add(this.lblExpense);
            this.Controls.Add(this.pnlButtonList);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "PurchaseHistory";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Purchase History";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.PurchaseHistory_FormClosed);
            this.Load += new System.EventHandler(this.PurchaseHistory_Load);
            this.pnlButtonList.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvPurchaseHistory)).EndInit();
            this.cmsRefresh.ResumeLayout(false);
            this.pnlComplain.ResumeLayout(false);
            this.pnlComplain.PerformLayout();
            this.pnlSearch.ResumeLayout(false);
            this.pnlSearch.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel pnlButtonList;
        private System.Windows.Forms.Panel pnlUserControlList;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.Button btnSignOut;
        private System.Windows.Forms.Button btnUserProfile;
        private System.Windows.Forms.Button btnPurchaseHistory;
        private System.Windows.Forms.Button btnTrainRoute;
        private System.Windows.Forms.Button btnFareQuery;
        private System.Windows.Forms.Button btnDashboard;
        private MetroFramework.Controls.MetroGrid dgvPurchaseHistory;
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
        private System.Windows.Forms.Label lblExpense;
        private System.Windows.Forms.Panel pnlComplain;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Label lblComlain;
        private MetroFramework.Controls.MetroTextBox txtComplain;
        private System.Windows.Forms.ContextMenuStrip cmsRefresh;
        private System.Windows.Forms.ToolStripMenuItem refreshToolStripMenuItem;
        private System.Windows.Forms.Label lblCost;
        private System.Windows.Forms.DateTimePicker dtpFrom;
        private System.Windows.Forms.Label lblFrom;
        private System.Windows.Forms.DateTimePicker dtpTO;
        private System.Windows.Forms.Label lblTo;
        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.Label lblProfit;
        private System.Windows.Forms.Button btnRefresh;
        private System.Windows.Forms.Label lblIssueDate;
        private System.Windows.Forms.Panel pnlSearch;
    }
}