namespace TMS.ApplicationLayer
{
    partial class SellTicket
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SellTicket));
            this.pnlFairQueryBrief = new System.Windows.Forms.Panel();
            this.cmsEditAndRefresh = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.refreshToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.lblCouchNo = new System.Windows.Forms.Label();
            this.txtCouchNo = new System.Windows.Forms.TextBox();
            this.txtChange = new System.Windows.Forms.TextBox();
            this.lblChange = new System.Windows.Forms.Label();
            this.txtCardNo = new System.Windows.Forms.TextBox();
            this.lblCardNo = new System.Windows.Forms.Label();
            this.lblCard = new System.Windows.Forms.Label();
            this.txtCard = new System.Windows.Forms.TextBox();
            this.txtCash = new System.Windows.Forms.TextBox();
            this.lblCash = new System.Windows.Forms.Label();
            this.cmbPayType = new System.Windows.Forms.ComboBox();
            this.lblPayType = new System.Windows.Forms.Label();
            this.cmbPassengerEmail = new System.Windows.Forms.ComboBox();
            this.lblPassengerEmail = new System.Windows.Forms.Label();
            this.btnSell = new System.Windows.Forms.Button();
            this.txtAvailableSeat = new System.Windows.Forms.TextBox();
            this.lblAvailableSeatResult = new System.Windows.Forms.Label();
            this.btnRefresh = new System.Windows.Forms.Button();
            this.txtNetBill = new System.Windows.Forms.TextBox();
            this.lblNetBill = new System.Windows.Forms.Label();
            this.txtVat = new System.Windows.Forms.TextBox();
            this.lblVat = new System.Windows.Forms.Label();
            this.txtBill = new System.Windows.Forms.TextBox();
            this.lblBill = new System.Windows.Forms.Label();
            this.cmbNoOfSeat = new System.Windows.Forms.ComboBox();
            this.lblNoOfSeat = new System.Windows.Forms.Label();
            this.txtPricePerSeat = new System.Windows.Forms.TextBox();
            this.lblPricePerSeat = new System.Windows.Forms.Label();
            this.lblAvailableSeat = new System.Windows.Forms.Label();
            this.cmbClass = new System.Windows.Forms.ComboBox();
            this.lblClass = new System.Windows.Forms.Label();
            this.cmbAvailableTrain = new System.Windows.Forms.ComboBox();
            this.lblAvailableTrain = new System.Windows.Forms.Label();
            this.cmbJourneyTime = new System.Windows.Forms.ComboBox();
            this.lblJourneyTime = new System.Windows.Forms.Label();
            this.cmbJourneyDate = new System.Windows.Forms.ComboBox();
            this.lblJourneyDate = new System.Windows.Forms.Label();
            this.cmbTo = new System.Windows.Forms.ComboBox();
            this.lblTo = new System.Windows.Forms.Label();
            this.cmbFrom = new System.Windows.Forms.ComboBox();
            this.lblFrom = new System.Windows.Forms.Label();
            this.dgvTrainList = new System.Windows.Forms.DataGridView();
            this.journeytimeid = new System.Windows.Forms.DataGridViewTextBoxColumn();
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
            this.txtSearch = new MetroFramework.Controls.MetroTextBox();
            this.errFrom = new System.Windows.Forms.ErrorProvider(this.components);
            this.errTo = new System.Windows.Forms.ErrorProvider(this.components);
            this.errDate = new System.Windows.Forms.ErrorProvider(this.components);
            this.errTime = new System.Windows.Forms.ErrorProvider(this.components);
            this.errTrain = new System.Windows.Forms.ErrorProvider(this.components);
            this.errClass = new System.Windows.Forms.ErrorProvider(this.components);
            this.errCash = new System.Windows.Forms.ErrorProvider(this.components);
            this.errCard = new System.Windows.Forms.ErrorProvider(this.components);
            this.errChange = new System.Windows.Forms.ErrorProvider(this.components);
            this.errSeat = new System.Windows.Forms.ErrorProvider(this.components);
            this.pnlButtonList = new System.Windows.Forms.Panel();
            this.btnTrainInfo = new System.Windows.Forms.Button();
            this.pnlUserControlList = new System.Windows.Forms.Panel();
            this.btnExit = new System.Windows.Forms.Button();
            this.btnSignOut = new System.Windows.Forms.Button();
            this.btnUserProfile = new System.Windows.Forms.Button();
            this.btnSellHistory = new System.Windows.Forms.Button();
            this.btnSellTicket = new System.Windows.Forms.Button();
            this.btnDashboard = new System.Windows.Forms.Button();
            this.errPayType = new System.Windows.Forms.ErrorProvider(this.components);
            this.errEmail = new System.Windows.Forms.ErrorProvider(this.components);
            this.pnlFairQueryBrief.SuspendLayout();
            this.cmsEditAndRefresh.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvTrainList)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errFrom)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errTo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errDate)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errTime)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errTrain)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errClass)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errCash)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errCard)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errChange)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errSeat)).BeginInit();
            this.pnlButtonList.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errPayType)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errEmail)).BeginInit();
            this.SuspendLayout();
            // 
            // pnlFairQueryBrief
            // 
            this.pnlFairQueryBrief.BackColor = System.Drawing.Color.Teal;
            this.pnlFairQueryBrief.ContextMenuStrip = this.cmsEditAndRefresh;
            this.pnlFairQueryBrief.Controls.Add(this.lblCouchNo);
            this.pnlFairQueryBrief.Controls.Add(this.txtCouchNo);
            this.pnlFairQueryBrief.Controls.Add(this.txtChange);
            this.pnlFairQueryBrief.Controls.Add(this.lblChange);
            this.pnlFairQueryBrief.Controls.Add(this.txtCardNo);
            this.pnlFairQueryBrief.Controls.Add(this.lblCardNo);
            this.pnlFairQueryBrief.Controls.Add(this.lblCard);
            this.pnlFairQueryBrief.Controls.Add(this.txtCard);
            this.pnlFairQueryBrief.Controls.Add(this.txtCash);
            this.pnlFairQueryBrief.Controls.Add(this.lblCash);
            this.pnlFairQueryBrief.Controls.Add(this.cmbPayType);
            this.pnlFairQueryBrief.Controls.Add(this.lblPayType);
            this.pnlFairQueryBrief.Controls.Add(this.cmbPassengerEmail);
            this.pnlFairQueryBrief.Controls.Add(this.lblPassengerEmail);
            this.pnlFairQueryBrief.Controls.Add(this.btnSell);
            this.pnlFairQueryBrief.Controls.Add(this.txtAvailableSeat);
            this.pnlFairQueryBrief.Controls.Add(this.lblAvailableSeatResult);
            this.pnlFairQueryBrief.Controls.Add(this.btnRefresh);
            this.pnlFairQueryBrief.Controls.Add(this.txtNetBill);
            this.pnlFairQueryBrief.Controls.Add(this.lblNetBill);
            this.pnlFairQueryBrief.Controls.Add(this.txtVat);
            this.pnlFairQueryBrief.Controls.Add(this.lblVat);
            this.pnlFairQueryBrief.Controls.Add(this.txtBill);
            this.pnlFairQueryBrief.Controls.Add(this.lblBill);
            this.pnlFairQueryBrief.Controls.Add(this.cmbNoOfSeat);
            this.pnlFairQueryBrief.Controls.Add(this.lblNoOfSeat);
            this.pnlFairQueryBrief.Controls.Add(this.txtPricePerSeat);
            this.pnlFairQueryBrief.Controls.Add(this.lblPricePerSeat);
            this.pnlFairQueryBrief.Controls.Add(this.lblAvailableSeat);
            this.pnlFairQueryBrief.Controls.Add(this.cmbClass);
            this.pnlFairQueryBrief.Controls.Add(this.lblClass);
            this.pnlFairQueryBrief.Controls.Add(this.cmbAvailableTrain);
            this.pnlFairQueryBrief.Controls.Add(this.lblAvailableTrain);
            this.pnlFairQueryBrief.Controls.Add(this.cmbJourneyTime);
            this.pnlFairQueryBrief.Controls.Add(this.lblJourneyTime);
            this.pnlFairQueryBrief.Controls.Add(this.cmbJourneyDate);
            this.pnlFairQueryBrief.Controls.Add(this.lblJourneyDate);
            this.pnlFairQueryBrief.Controls.Add(this.cmbTo);
            this.pnlFairQueryBrief.Controls.Add(this.lblTo);
            this.pnlFairQueryBrief.Controls.Add(this.cmbFrom);
            this.pnlFairQueryBrief.Controls.Add(this.lblFrom);
            this.pnlFairQueryBrief.Location = new System.Drawing.Point(165, 12);
            this.pnlFairQueryBrief.Name = "pnlFairQueryBrief";
            this.pnlFairQueryBrief.Size = new System.Drawing.Size(493, 596);
            this.pnlFairQueryBrief.TabIndex = 5;
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
            // lblCouchNo
            // 
            this.lblCouchNo.AutoSize = true;
            this.lblCouchNo.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCouchNo.Location = new System.Drawing.Point(7, 524);
            this.lblCouchNo.Name = "lblCouchNo";
            this.lblCouchNo.Size = new System.Drawing.Size(81, 19);
            this.lblCouchNo.TabIndex = 40;
            this.lblCouchNo.Text = "Couch No";
            // 
            // txtCouchNo
            // 
            this.txtCouchNo.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtCouchNo.Enabled = false;
            this.txtCouchNo.Location = new System.Drawing.Point(141, 521);
            this.txtCouchNo.Name = "txtCouchNo";
            this.txtCouchNo.Size = new System.Drawing.Size(318, 22);
            this.txtCouchNo.TabIndex = 39;
            // 
            // txtChange
            // 
            this.txtChange.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtChange.Enabled = false;
            this.txtChange.Location = new System.Drawing.Point(348, 446);
            this.txtChange.Name = "txtChange";
            this.txtChange.Size = new System.Drawing.Size(110, 22);
            this.txtChange.TabIndex = 38;
            this.txtChange.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TxtChange_KeyPress);
            // 
            // lblChange
            // 
            this.lblChange.AutoSize = true;
            this.lblChange.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblChange.Location = new System.Drawing.Point(253, 446);
            this.lblChange.Name = "lblChange";
            this.lblChange.Size = new System.Drawing.Size(64, 19);
            this.lblChange.TabIndex = 37;
            this.lblChange.Text = "Change";
            // 
            // txtCardNo
            // 
            this.txtCardNo.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtCardNo.Enabled = false;
            this.txtCardNo.Location = new System.Drawing.Point(142, 485);
            this.txtCardNo.Name = "txtCardNo";
            this.txtCardNo.Size = new System.Drawing.Size(316, 22);
            this.txtCardNo.TabIndex = 36;
            // 
            // lblCardNo
            // 
            this.lblCardNo.AutoSize = true;
            this.lblCardNo.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCardNo.Location = new System.Drawing.Point(7, 488);
            this.lblCardNo.Name = "lblCardNo";
            this.lblCardNo.Size = new System.Drawing.Size(71, 19);
            this.lblCardNo.TabIndex = 35;
            this.lblCardNo.Text = "Card No";
            // 
            // lblCard
            // 
            this.lblCard.AutoSize = true;
            this.lblCard.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCard.Location = new System.Drawing.Point(6, 449);
            this.lblCard.Name = "lblCard";
            this.lblCard.Size = new System.Drawing.Size(96, 19);
            this.lblCard.TabIndex = 34;
            this.lblCard.Text = "Card (BDT)";
            // 
            // txtCard
            // 
            this.txtCard.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtCard.Enabled = false;
            this.txtCard.Location = new System.Drawing.Point(141, 446);
            this.txtCard.Name = "txtCard";
            this.txtCard.Size = new System.Drawing.Size(93, 22);
            this.txtCard.TabIndex = 33;
            this.txtCard.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TxtCard_KeyPress);
            // 
            // txtCash
            // 
            this.txtCash.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtCash.Enabled = false;
            this.txtCash.Location = new System.Drawing.Point(348, 413);
            this.txtCash.Name = "txtCash";
            this.txtCash.Size = new System.Drawing.Size(110, 22);
            this.txtCash.TabIndex = 32;
            this.txtCash.TextChanged += new System.EventHandler(this.TxtCash_TextChanged);
            this.txtCash.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TxtCash_KeyPress);
            // 
            // lblCash
            // 
            this.lblCash.AutoSize = true;
            this.lblCash.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCash.Location = new System.Drawing.Point(253, 413);
            this.lblCash.Name = "lblCash";
            this.lblCash.Size = new System.Drawing.Size(45, 19);
            this.lblCash.TabIndex = 31;
            this.lblCash.Text = "Cash";
            // 
            // cmbPayType
            // 
            this.cmbPayType.BackColor = System.Drawing.Color.Lavender;
            this.cmbPayType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbPayType.FormattingEnabled = true;
            this.cmbPayType.Items.AddRange(new object[] {
            "Cash",
            "Card"});
            this.cmbPayType.Location = new System.Drawing.Point(142, 412);
            this.cmbPayType.Name = "cmbPayType";
            this.cmbPayType.Size = new System.Drawing.Size(92, 24);
            this.cmbPayType.TabIndex = 30;
            this.cmbPayType.SelectedIndexChanged += new System.EventHandler(this.ComboBox1_SelectedIndexChanged);
            // 
            // lblPayType
            // 
            this.lblPayType.AutoSize = true;
            this.lblPayType.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPayType.Location = new System.Drawing.Point(4, 412);
            this.lblPayType.Name = "lblPayType";
            this.lblPayType.Size = new System.Drawing.Size(74, 19);
            this.lblPayType.TabIndex = 29;
            this.lblPayType.Text = "Pay Type";
            // 
            // cmbPassengerEmail
            // 
            this.cmbPassengerEmail.BackColor = System.Drawing.Color.Lavender;
            this.cmbPassengerEmail.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbPassengerEmail.FormattingEnabled = true;
            this.cmbPassengerEmail.Location = new System.Drawing.Point(142, 377);
            this.cmbPassengerEmail.Name = "cmbPassengerEmail";
            this.cmbPassengerEmail.Size = new System.Drawing.Size(320, 24);
            this.cmbPassengerEmail.TabIndex = 28;
            this.cmbPassengerEmail.SelectedIndexChanged += new System.EventHandler(this.CmbPassengerEmail_SelectedIndexChanged);
            this.cmbPassengerEmail.Leave += new System.EventHandler(this.CmbPassengerEmail_Leave);
            // 
            // lblPassengerEmail
            // 
            this.lblPassengerEmail.AutoSize = true;
            this.lblPassengerEmail.Font = new System.Drawing.Font("Times New Roman", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPassengerEmail.Location = new System.Drawing.Point(6, 378);
            this.lblPassengerEmail.Name = "lblPassengerEmail";
            this.lblPassengerEmail.Size = new System.Drawing.Size(117, 17);
            this.lblPassengerEmail.TabIndex = 27;
            this.lblPassengerEmail.Text = "Passenger Email";
            // 
            // btnSell
            // 
            this.btnSell.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.btnSell.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSell.Location = new System.Drawing.Point(295, 549);
            this.btnSell.Name = "btnSell";
            this.btnSell.Size = new System.Drawing.Size(88, 40);
            this.btnSell.TabIndex = 26;
            this.btnSell.Text = "Sell";
            this.btnSell.UseVisualStyleBackColor = false;
            this.btnSell.Visible = false;
            this.btnSell.Click += new System.EventHandler(this.BtnSell_Click);
            // 
            // txtAvailableSeat
            // 
            this.txtAvailableSeat.Enabled = false;
            this.txtAvailableSeat.Location = new System.Drawing.Point(141, 264);
            this.txtAvailableSeat.Name = "txtAvailableSeat";
            this.txtAvailableSeat.Size = new System.Drawing.Size(80, 22);
            this.txtAvailableSeat.TabIndex = 6;
            // 
            // lblAvailableSeatResult
            // 
            this.lblAvailableSeatResult.AutoSize = true;
            this.lblAvailableSeatResult.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAvailableSeatResult.Location = new System.Drawing.Point(137, 264);
            this.lblAvailableSeatResult.Name = "lblAvailableSeatResult";
            this.lblAvailableSeatResult.Size = new System.Drawing.Size(0, 19);
            this.lblAvailableSeatResult.TabIndex = 25;
            // 
            // btnRefresh
            // 
            this.btnRefresh.BackColor = System.Drawing.Color.DeepSkyBlue;
            this.btnRefresh.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRefresh.Location = new System.Drawing.Point(166, 549);
            this.btnRefresh.Name = "btnRefresh";
            this.btnRefresh.Size = new System.Drawing.Size(88, 40);
            this.btnRefresh.TabIndex = 12;
            this.btnRefresh.Text = "Refresh";
            this.btnRefresh.UseVisualStyleBackColor = false;
            this.btnRefresh.Click += new System.EventHandler(this.BtnRefresh_Click);
            // 
            // txtNetBill
            // 
            this.txtNetBill.Enabled = false;
            this.txtNetBill.Location = new System.Drawing.Point(386, 341);
            this.txtNetBill.Name = "txtNetBill";
            this.txtNetBill.Size = new System.Drawing.Size(73, 22);
            this.txtNetBill.TabIndex = 11;
            // 
            // lblNetBill
            // 
            this.lblNetBill.AutoSize = true;
            this.lblNetBill.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNetBill.Location = new System.Drawing.Point(244, 344);
            this.lblNetBill.Name = "lblNetBill";
            this.lblNetBill.Size = new System.Drawing.Size(119, 19);
            this.lblNetBill.TabIndex = 24;
            this.lblNetBill.Text = "Net Bill (BDT)";
            // 
            // txtVat
            // 
            this.txtVat.Enabled = false;
            this.txtVat.Location = new System.Drawing.Point(142, 344);
            this.txtVat.Name = "txtVat";
            this.txtVat.Size = new System.Drawing.Size(79, 22);
            this.txtVat.TabIndex = 10;
            this.txtVat.Text = "2";
            // 
            // lblVat
            // 
            this.lblVat.AutoSize = true;
            this.lblVat.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblVat.Location = new System.Drawing.Point(6, 345);
            this.lblVat.Name = "lblVat";
            this.lblVat.Size = new System.Drawing.Size(64, 19);
            this.lblVat.TabIndex = 22;
            this.lblVat.Text = "Vat (%)";
            // 
            // txtBill
            // 
            this.txtBill.Enabled = false;
            this.txtBill.Location = new System.Drawing.Point(386, 303);
            this.txtBill.Name = "txtBill";
            this.txtBill.Size = new System.Drawing.Size(73, 22);
            this.txtBill.TabIndex = 9;
            // 
            // lblBill
            // 
            this.lblBill.AutoSize = true;
            this.lblBill.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblBill.Location = new System.Drawing.Point(244, 308);
            this.lblBill.Name = "lblBill";
            this.lblBill.Size = new System.Drawing.Size(89, 19);
            this.lblBill.TabIndex = 20;
            this.lblBill.Text = "Bill (BDT)";
            // 
            // cmbNoOfSeat
            // 
            this.cmbNoOfSeat.BackColor = System.Drawing.Color.Lavender;
            this.cmbNoOfSeat.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbNoOfSeat.FormattingEnabled = true;
            this.cmbNoOfSeat.Location = new System.Drawing.Point(142, 303);
            this.cmbNoOfSeat.Name = "cmbNoOfSeat";
            this.cmbNoOfSeat.Size = new System.Drawing.Size(79, 24);
            this.cmbNoOfSeat.TabIndex = 8;
            this.cmbNoOfSeat.SelectedIndexChanged += new System.EventHandler(this.CmbNoOfSeat_SelectedIndexChanged);
            this.cmbNoOfSeat.Leave += new System.EventHandler(this.CmbNoOfSeat_Leave);
            // 
            // lblNoOfSeat
            // 
            this.lblNoOfSeat.AutoSize = true;
            this.lblNoOfSeat.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNoOfSeat.Location = new System.Drawing.Point(6, 308);
            this.lblNoOfSeat.Name = "lblNoOfSeat";
            this.lblNoOfSeat.Size = new System.Drawing.Size(87, 19);
            this.lblNoOfSeat.TabIndex = 18;
            this.lblNoOfSeat.Text = "No Of Seat";
            // 
            // txtPricePerSeat
            // 
            this.txtPricePerSeat.Enabled = false;
            this.txtPricePerSeat.Location = new System.Drawing.Point(385, 261);
            this.txtPricePerSeat.Name = "txtPricePerSeat";
            this.txtPricePerSeat.Size = new System.Drawing.Size(73, 22);
            this.txtPricePerSeat.TabIndex = 7;
            // 
            // lblPricePerSeat
            // 
            this.lblPricePerSeat.AutoSize = true;
            this.lblPricePerSeat.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPricePerSeat.Location = new System.Drawing.Point(233, 264);
            this.lblPricePerSeat.Name = "lblPricePerSeat";
            this.lblPricePerSeat.Size = new System.Drawing.Size(132, 19);
            this.lblPricePerSeat.TabIndex = 15;
            this.lblPricePerSeat.Text = "Price/Seat(BDT)";
            // 
            // lblAvailableSeat
            // 
            this.lblAvailableSeat.AutoSize = true;
            this.lblAvailableSeat.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAvailableSeat.Location = new System.Drawing.Point(3, 264);
            this.lblAvailableSeat.Name = "lblAvailableSeat";
            this.lblAvailableSeat.Size = new System.Drawing.Size(113, 19);
            this.lblAvailableSeat.TabIndex = 13;
            this.lblAvailableSeat.Text = "Available Seat";
            // 
            // cmbClass
            // 
            this.cmbClass.BackColor = System.Drawing.Color.Lavender;
            this.cmbClass.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbClass.FormattingEnabled = true;
            this.cmbClass.Location = new System.Drawing.Point(141, 219);
            this.cmbClass.Name = "cmbClass";
            this.cmbClass.Size = new System.Drawing.Size(317, 24);
            this.cmbClass.TabIndex = 5;
            this.cmbClass.SelectedIndexChanged += new System.EventHandler(this.CmbClass_SelectedIndexChanged);
            this.cmbClass.Leave += new System.EventHandler(this.CmbClass_Leave);
            // 
            // lblClass
            // 
            this.lblClass.AutoSize = true;
            this.lblClass.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblClass.Location = new System.Drawing.Point(3, 224);
            this.lblClass.Name = "lblClass";
            this.lblClass.Size = new System.Drawing.Size(49, 19);
            this.lblClass.TabIndex = 11;
            this.lblClass.Text = "Class";
            // 
            // cmbAvailableTrain
            // 
            this.cmbAvailableTrain.BackColor = System.Drawing.Color.Lavender;
            this.cmbAvailableTrain.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbAvailableTrain.FormattingEnabled = true;
            this.cmbAvailableTrain.Location = new System.Drawing.Point(141, 175);
            this.cmbAvailableTrain.Name = "cmbAvailableTrain";
            this.cmbAvailableTrain.Size = new System.Drawing.Size(317, 24);
            this.cmbAvailableTrain.TabIndex = 4;
            this.cmbAvailableTrain.SelectedIndexChanged += new System.EventHandler(this.CmbAvailableTrain_SelectedIndexChanged);
            this.cmbAvailableTrain.Leave += new System.EventHandler(this.CmbAvailableTrain_Leave);
            // 
            // lblAvailableTrain
            // 
            this.lblAvailableTrain.AutoSize = true;
            this.lblAvailableTrain.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAvailableTrain.Location = new System.Drawing.Point(3, 180);
            this.lblAvailableTrain.Name = "lblAvailableTrain";
            this.lblAvailableTrain.Size = new System.Drawing.Size(122, 19);
            this.lblAvailableTrain.TabIndex = 9;
            this.lblAvailableTrain.Text = "Available Train";
            // 
            // cmbJourneyTime
            // 
            this.cmbJourneyTime.BackColor = System.Drawing.Color.Lavender;
            this.cmbJourneyTime.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbJourneyTime.FormattingEnabled = true;
            this.cmbJourneyTime.Location = new System.Drawing.Point(141, 130);
            this.cmbJourneyTime.Name = "cmbJourneyTime";
            this.cmbJourneyTime.Size = new System.Drawing.Size(317, 24);
            this.cmbJourneyTime.TabIndex = 3;
            this.cmbJourneyTime.SelectedIndexChanged += new System.EventHandler(this.CmbJourneyTime_SelectedIndexChanged);
            this.cmbJourneyTime.Leave += new System.EventHandler(this.CmbJourneyTime_Leave);
            // 
            // lblJourneyTime
            // 
            this.lblJourneyTime.AutoSize = true;
            this.lblJourneyTime.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblJourneyTime.Location = new System.Drawing.Point(3, 135);
            this.lblJourneyTime.Name = "lblJourneyTime";
            this.lblJourneyTime.Size = new System.Drawing.Size(111, 19);
            this.lblJourneyTime.TabIndex = 7;
            this.lblJourneyTime.Text = "Journey Time";
            // 
            // cmbJourneyDate
            // 
            this.cmbJourneyDate.BackColor = System.Drawing.Color.Lavender;
            this.cmbJourneyDate.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbJourneyDate.FormattingEnabled = true;
            this.cmbJourneyDate.Location = new System.Drawing.Point(141, 87);
            this.cmbJourneyDate.Name = "cmbJourneyDate";
            this.cmbJourneyDate.Size = new System.Drawing.Size(317, 24);
            this.cmbJourneyDate.TabIndex = 2;
            this.cmbJourneyDate.SelectedIndexChanged += new System.EventHandler(this.CmbJourneyDate_SelectedIndexChanged);
            this.cmbJourneyDate.Leave += new System.EventHandler(this.CmbJourneyDate_Leave);
            // 
            // lblJourneyDate
            // 
            this.lblJourneyDate.AutoSize = true;
            this.lblJourneyDate.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblJourneyDate.Location = new System.Drawing.Point(3, 92);
            this.lblJourneyDate.Name = "lblJourneyDate";
            this.lblJourneyDate.Size = new System.Drawing.Size(107, 19);
            this.lblJourneyDate.TabIndex = 5;
            this.lblJourneyDate.Text = "Journey Date";
            // 
            // cmbTo
            // 
            this.cmbTo.BackColor = System.Drawing.Color.Lavender;
            this.cmbTo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbTo.FormattingEnabled = true;
            this.cmbTo.Location = new System.Drawing.Point(141, 51);
            this.cmbTo.Name = "cmbTo";
            this.cmbTo.Size = new System.Drawing.Size(317, 24);
            this.cmbTo.TabIndex = 1;
            this.cmbTo.SelectedIndexChanged += new System.EventHandler(this.CmbTo_SelectedIndexChanged);
            this.cmbTo.Leave += new System.EventHandler(this.CmbTo_Leave);
            // 
            // lblTo
            // 
            this.lblTo.AutoSize = true;
            this.lblTo.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTo.Location = new System.Drawing.Point(3, 51);
            this.lblTo.Name = "lblTo";
            this.lblTo.Size = new System.Drawing.Size(90, 19);
            this.lblTo.TabIndex = 3;
            this.lblTo.Text = "Journey To";
            // 
            // cmbFrom
            // 
            this.cmbFrom.BackColor = System.Drawing.Color.Lavender;
            this.cmbFrom.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbFrom.FormattingEnabled = true;
            this.cmbFrom.Location = new System.Drawing.Point(141, 13);
            this.cmbFrom.Name = "cmbFrom";
            this.cmbFrom.Size = new System.Drawing.Size(317, 24);
            this.cmbFrom.TabIndex = 0;
            this.cmbFrom.SelectedIndexChanged += new System.EventHandler(this.CmbFrom_SelectedIndexChanged);
            this.cmbFrom.Leave += new System.EventHandler(this.CmbFrom_Leave);
            // 
            // lblFrom
            // 
            this.lblFrom.AutoSize = true;
            this.lblFrom.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFrom.Location = new System.Drawing.Point(3, 14);
            this.lblFrom.Name = "lblFrom";
            this.lblFrom.Size = new System.Drawing.Size(115, 19);
            this.lblFrom.TabIndex = 1;
            this.lblFrom.Text = "Journey From";
            // 
            // dgvTrainList
            // 
            this.dgvTrainList.AllowUserToAddRows = false;
            this.dgvTrainList.AllowUserToDeleteRows = false;
            this.dgvTrainList.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvTrainList.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvTrainList.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.journeytimeid,
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
            this.dgvTrainList.ContextMenuStrip = this.cmsEditAndRefresh;
            this.dgvTrainList.Location = new System.Drawing.Point(664, 41);
            this.dgvTrainList.Name = "dgvTrainList";
            this.dgvTrainList.ReadOnly = true;
            this.dgvTrainList.RowHeadersWidth = 51;
            this.dgvTrainList.RowTemplate.Height = 24;
            this.dgvTrainList.Size = new System.Drawing.Size(649, 568);
            this.dgvTrainList.TabIndex = 26;
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
            // txtSearch
            // 
            // 
            // 
            // 
            this.txtSearch.CustomButton.Image = null;
            this.txtSearch.CustomButton.Location = new System.Drawing.Point(627, 1);
            this.txtSearch.CustomButton.Name = "";
            this.txtSearch.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.txtSearch.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txtSearch.CustomButton.TabIndex = 1;
            this.txtSearch.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txtSearch.CustomButton.UseSelectable = true;
            this.txtSearch.CustomButton.Visible = false;
            this.txtSearch.Lines = new string[0];
            this.txtSearch.Location = new System.Drawing.Point(664, 12);
            this.txtSearch.MaxLength = 32767;
            this.txtSearch.Name = "txtSearch";
            this.txtSearch.PasswordChar = '\0';
            this.txtSearch.PromptText = "Please search fare details by train name or departure station  or arrival station" +
    "";
            this.txtSearch.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtSearch.SelectedText = "";
            this.txtSearch.SelectionLength = 0;
            this.txtSearch.SelectionStart = 0;
            this.txtSearch.ShortcutsEnabled = true;
            this.txtSearch.Size = new System.Drawing.Size(649, 23);
            this.txtSearch.TabIndex = 27;
            this.txtSearch.UseSelectable = true;
            this.txtSearch.WaterMark = "Please search fare details by train name or departure station  or arrival station" +
    "";
            this.txtSearch.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txtSearch.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            this.txtSearch.TextChanged += new System.EventHandler(this.TxtSearch_TextChanged);
            // 
            // errFrom
            // 
            this.errFrom.ContainerControl = this;
            // 
            // errTo
            // 
            this.errTo.ContainerControl = this;
            // 
            // errDate
            // 
            this.errDate.ContainerControl = this;
            // 
            // errTime
            // 
            this.errTime.ContainerControl = this;
            // 
            // errTrain
            // 
            this.errTrain.ContainerControl = this;
            // 
            // errClass
            // 
            this.errClass.ContainerControl = this;
            // 
            // errCash
            // 
            this.errCash.ContainerControl = this;
            // 
            // errCard
            // 
            this.errCard.ContainerControl = this;
            // 
            // errChange
            // 
            this.errChange.ContainerControl = this;
            // 
            // errSeat
            // 
            this.errSeat.ContainerControl = this;
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
            this.pnlButtonList.Location = new System.Drawing.Point(12, 11);
            this.pnlButtonList.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.pnlButtonList.Name = "pnlButtonList";
            this.pnlButtonList.Size = new System.Drawing.Size(147, 597);
            this.pnlButtonList.TabIndex = 28;
            // 
            // btnTrainInfo
            // 
            this.btnTrainInfo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.btnTrainInfo.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnTrainInfo.Location = new System.Drawing.Point(3, 244);
            this.btnTrainInfo.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnTrainInfo.Name = "btnTrainInfo";
            this.btnTrainInfo.Size = new System.Drawing.Size(140, 78);
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
            this.btnExit.Location = new System.Drawing.Point(3, 507);
            this.btnExit.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(140, 78);
            this.btnExit.TabIndex = 6;
            this.btnExit.Text = "Exit";
            this.btnExit.UseVisualStyleBackColor = false;
            this.btnExit.Click += new System.EventHandler(this.BtnExit_Click);
            // 
            // btnSignOut
            // 
            this.btnSignOut.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.btnSignOut.Font = new System.Drawing.Font("Times New Roman", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSignOut.Location = new System.Drawing.Point(3, 429);
            this.btnSignOut.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnSignOut.Name = "btnSignOut";
            this.btnSignOut.Size = new System.Drawing.Size(140, 74);
            this.btnSignOut.TabIndex = 5;
            this.btnSignOut.Text = "Sign Out";
            this.btnSignOut.UseVisualStyleBackColor = false;
            this.btnSignOut.Click += new System.EventHandler(this.BtnSignOut_Click);
            // 
            // btnUserProfile
            // 
            this.btnUserProfile.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.btnUserProfile.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnUserProfile.Location = new System.Drawing.Point(2, 326);
            this.btnUserProfile.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnUserProfile.Name = "btnUserProfile";
            this.btnUserProfile.Size = new System.Drawing.Size(140, 98);
            this.btnUserProfile.TabIndex = 4;
            this.btnUserProfile.Text = "Change Password";
            this.btnUserProfile.UseVisualStyleBackColor = false;
            this.btnUserProfile.Click += new System.EventHandler(this.BtnUserProfile_Click);
            // 
            // btnSellHistory
            // 
            this.btnSellHistory.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.btnSellHistory.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSellHistory.Location = new System.Drawing.Point(2, 164);
            this.btnSellHistory.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnSellHistory.Name = "btnSellHistory";
            this.btnSellHistory.Size = new System.Drawing.Size(140, 77);
            this.btnSellHistory.TabIndex = 3;
            this.btnSellHistory.Text = "Sell History";
            this.btnSellHistory.UseVisualStyleBackColor = false;
            this.btnSellHistory.Click += new System.EventHandler(this.BtnSellHistory_Click);
            // 
            // btnSellTicket
            // 
            this.btnSellTicket.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.btnSellTicket.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSellTicket.Location = new System.Drawing.Point(2, 78);
            this.btnSellTicket.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnSellTicket.Name = "btnSellTicket";
            this.btnSellTicket.Size = new System.Drawing.Size(140, 82);
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
            // errPayType
            // 
            this.errPayType.ContainerControl = this;
            // 
            // errEmail
            // 
            this.errEmail.ContainerControl = this;
            // 
            // SellTicket
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.ClientSize = new System.Drawing.Size(1325, 620);
            this.Controls.Add(this.pnlButtonList);
            this.Controls.Add(this.txtSearch);
            this.Controls.Add(this.dgvTrainList);
            this.Controls.Add(this.pnlFairQueryBrief);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "SellTicket";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Sell Ticket";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.SellTicket_FormClosed);
            this.pnlFairQueryBrief.ResumeLayout(false);
            this.pnlFairQueryBrief.PerformLayout();
            this.cmsEditAndRefresh.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvTrainList)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errFrom)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errTo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errDate)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errTime)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errTrain)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errClass)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errCash)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errCard)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errChange)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errSeat)).EndInit();
            this.pnlButtonList.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.errPayType)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errEmail)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Panel pnlFairQueryBrief;
        private System.Windows.Forms.TextBox txtAvailableSeat;
        private System.Windows.Forms.Label lblAvailableSeatResult;
        private System.Windows.Forms.Button btnRefresh;
        private System.Windows.Forms.TextBox txtNetBill;
        private System.Windows.Forms.Label lblNetBill;
        private System.Windows.Forms.TextBox txtVat;
        private System.Windows.Forms.Label lblVat;
        private System.Windows.Forms.TextBox txtBill;
        private System.Windows.Forms.Label lblBill;
        private System.Windows.Forms.ComboBox cmbNoOfSeat;
        private System.Windows.Forms.Label lblNoOfSeat;
        private System.Windows.Forms.TextBox txtPricePerSeat;
        private System.Windows.Forms.Label lblPricePerSeat;
        private System.Windows.Forms.Label lblAvailableSeat;
        private System.Windows.Forms.ComboBox cmbClass;
        private System.Windows.Forms.Label lblClass;
        private System.Windows.Forms.ComboBox cmbAvailableTrain;
        private System.Windows.Forms.Label lblAvailableTrain;
        private System.Windows.Forms.ComboBox cmbJourneyTime;
        private System.Windows.Forms.Label lblJourneyTime;
        private System.Windows.Forms.ComboBox cmbJourneyDate;
        private System.Windows.Forms.Label lblJourneyDate;
        private System.Windows.Forms.ComboBox cmbTo;
        private System.Windows.Forms.Label lblTo;
        private System.Windows.Forms.ComboBox cmbFrom;
        private System.Windows.Forms.Label lblFrom;
        private System.Windows.Forms.DataGridView dgvTrainList;
        private MetroFramework.Controls.MetroTextBox txtSearch;
        private System.Windows.Forms.ErrorProvider errFrom;
        private System.Windows.Forms.ErrorProvider errTo;
        private System.Windows.Forms.ErrorProvider errDate;
        private System.Windows.Forms.ErrorProvider errTime;
        private System.Windows.Forms.ErrorProvider errTrain;
        private System.Windows.Forms.ErrorProvider errClass;
        private System.Windows.Forms.DataGridViewTextBoxColumn journeytimeid;
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
        private System.Windows.Forms.Button btnSell;
        private System.Windows.Forms.Label lblPassengerEmail;
        private System.Windows.Forms.ComboBox cmbPassengerEmail;
        private System.Windows.Forms.Label lblPayType;
        private System.Windows.Forms.ComboBox cmbPayType;
        private System.Windows.Forms.Label lblCash;
        private System.Windows.Forms.TextBox txtCash;
        private System.Windows.Forms.Label lblCard;
        private System.Windows.Forms.TextBox txtCard;
        private System.Windows.Forms.Label lblCardNo;
        private System.Windows.Forms.TextBox txtCardNo;
        private System.Windows.Forms.Label lblChange;
        private System.Windows.Forms.TextBox txtChange;
        private System.Windows.Forms.Label lblCouchNo;
        private System.Windows.Forms.TextBox txtCouchNo;
        private System.Windows.Forms.ErrorProvider errCash;
        private System.Windows.Forms.ErrorProvider errCard;
        private System.Windows.Forms.ErrorProvider errChange;
        private System.Windows.Forms.ContextMenuStrip cmsEditAndRefresh;
        private System.Windows.Forms.ToolStripMenuItem refreshToolStripMenuItem;
        private System.Windows.Forms.ErrorProvider errSeat;
        private System.Windows.Forms.Panel pnlButtonList;
        private System.Windows.Forms.Button btnTrainInfo;
        private System.Windows.Forms.Panel pnlUserControlList;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.Button btnSignOut;
        private System.Windows.Forms.Button btnUserProfile;
        private System.Windows.Forms.Button btnSellHistory;
        private System.Windows.Forms.Button btnSellTicket;
        private System.Windows.Forms.Button btnDashboard;
        private System.Windows.Forms.ErrorProvider errPayType;
        private System.Windows.Forms.ErrorProvider errEmail;
    }
}