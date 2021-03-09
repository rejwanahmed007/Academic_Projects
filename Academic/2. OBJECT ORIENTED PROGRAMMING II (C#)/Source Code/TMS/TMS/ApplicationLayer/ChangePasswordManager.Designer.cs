namespace TMS.ApplicationLayer
{
    partial class ChangePasswordManager
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ChangePasswordManager));
            this.pnlChangePassword = new System.Windows.Forms.Panel();
            this.pnlUpdateInfo = new System.Windows.Forms.Panel();
            this.btnSave = new System.Windows.Forms.Button();
            this.btnRefresh = new System.Windows.Forms.Button();
            this.txtConfirmPassword = new System.Windows.Forms.TextBox();
            this.txtNewPassword = new System.Windows.Forms.TextBox();
            this.txtCurrentPassword = new System.Windows.Forms.TextBox();
            this.pnlConfirmPassword = new System.Windows.Forms.Panel();
            this.lblConfirmPassword = new System.Windows.Forms.Label();
            this.pnlMobileUP = new System.Windows.Forms.Panel();
            this.lblNewPassword = new System.Windows.Forms.Label();
            this.pnlNameUP = new System.Windows.Forms.Panel();
            this.lblCurrentPassword = new System.Windows.Forms.Label();
            this.lblChangePassword = new System.Windows.Forms.Label();
            this.errPassword = new System.Windows.Forms.ErrorProvider(this.components);
            this.errNewPassword = new System.Windows.Forms.ErrorProvider(this.components);
            this.errConfirmPassword = new System.Windows.Forms.ErrorProvider(this.components);
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
            this.pnlChangePassword.SuspendLayout();
            this.pnlUpdateInfo.SuspendLayout();
            this.pnlConfirmPassword.SuspendLayout();
            this.pnlMobileUP.SuspendLayout();
            this.pnlNameUP.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errPassword)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errNewPassword)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errConfirmPassword)).BeginInit();
            this.pnlButtonList.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnlChangePassword
            // 
            this.pnlChangePassword.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnlChangePassword.Controls.Add(this.pnlUpdateInfo);
            this.pnlChangePassword.Location = new System.Drawing.Point(172, 17);
            this.pnlChangePassword.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.pnlChangePassword.Name = "pnlChangePassword";
            this.pnlChangePassword.Size = new System.Drawing.Size(688, 617);
            this.pnlChangePassword.TabIndex = 4;
            // 
            // pnlUpdateInfo
            // 
            this.pnlUpdateInfo.BackColor = System.Drawing.Color.DarkGray;
            this.pnlUpdateInfo.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnlUpdateInfo.Controls.Add(this.btnSave);
            this.pnlUpdateInfo.Controls.Add(this.btnRefresh);
            this.pnlUpdateInfo.Controls.Add(this.txtConfirmPassword);
            this.pnlUpdateInfo.Controls.Add(this.txtNewPassword);
            this.pnlUpdateInfo.Controls.Add(this.txtCurrentPassword);
            this.pnlUpdateInfo.Controls.Add(this.pnlConfirmPassword);
            this.pnlUpdateInfo.Controls.Add(this.pnlMobileUP);
            this.pnlUpdateInfo.Controls.Add(this.pnlNameUP);
            this.pnlUpdateInfo.Controls.Add(this.lblChangePassword);
            this.pnlUpdateInfo.Location = new System.Drawing.Point(3, 19);
            this.pnlUpdateInfo.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.pnlUpdateInfo.Name = "pnlUpdateInfo";
            this.pnlUpdateInfo.Size = new System.Drawing.Size(650, 295);
            this.pnlUpdateInfo.TabIndex = 3;
            // 
            // btnSave
            // 
            this.btnSave.BackColor = System.Drawing.Color.Green;
            this.btnSave.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSave.Location = new System.Drawing.Point(320, 210);
            this.btnSave.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(132, 43);
            this.btnSave.TabIndex = 21;
            this.btnSave.Text = "Save";
            this.btnSave.UseVisualStyleBackColor = false;
            this.btnSave.Click += new System.EventHandler(this.BtnSave_Click);
            // 
            // btnRefresh
            // 
            this.btnRefresh.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.btnRefresh.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRefresh.Location = new System.Drawing.Point(116, 210);
            this.btnRefresh.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnRefresh.Name = "btnRefresh";
            this.btnRefresh.Size = new System.Drawing.Size(132, 43);
            this.btnRefresh.TabIndex = 22;
            this.btnRefresh.Text = "Refresh";
            this.btnRefresh.UseVisualStyleBackColor = false;
            this.btnRefresh.Click += new System.EventHandler(this.BtnRefresh_Click);
            // 
            // txtConfirmPassword
            // 
            this.txtConfirmPassword.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.txtConfirmPassword.Font = new System.Drawing.Font("Times New Roman", 14F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtConfirmPassword.Location = new System.Drawing.Point(274, 149);
            this.txtConfirmPassword.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtConfirmPassword.MaxLength = 50;
            this.txtConfirmPassword.Name = "txtConfirmPassword";
            this.txtConfirmPassword.PasswordChar = '*';
            this.txtConfirmPassword.Size = new System.Drawing.Size(328, 34);
            this.txtConfirmPassword.TabIndex = 20;
            this.txtConfirmPassword.Leave += new System.EventHandler(this.TxtConfirmPassword_Leave);
            // 
            // txtNewPassword
            // 
            this.txtNewPassword.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.txtNewPassword.Font = new System.Drawing.Font("Times New Roman", 14F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNewPassword.Location = new System.Drawing.Point(274, 102);
            this.txtNewPassword.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtNewPassword.MaxLength = 50;
            this.txtNewPassword.Name = "txtNewPassword";
            this.txtNewPassword.PasswordChar = '*';
            this.txtNewPassword.Size = new System.Drawing.Size(328, 34);
            this.txtNewPassword.TabIndex = 19;
            this.txtNewPassword.Leave += new System.EventHandler(this.TxtNewPassword_Leave);
            // 
            // txtCurrentPassword
            // 
            this.txtCurrentPassword.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.txtCurrentPassword.Font = new System.Drawing.Font("Times New Roman", 14F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCurrentPassword.Location = new System.Drawing.Point(274, 56);
            this.txtCurrentPassword.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtCurrentPassword.MaxLength = 50;
            this.txtCurrentPassword.Name = "txtCurrentPassword";
            this.txtCurrentPassword.PasswordChar = '*';
            this.txtCurrentPassword.Size = new System.Drawing.Size(328, 34);
            this.txtCurrentPassword.TabIndex = 18;
            this.txtCurrentPassword.Leave += new System.EventHandler(this.TxtCurrentPassword_Leave);
            // 
            // pnlConfirmPassword
            // 
            this.pnlConfirmPassword.Controls.Add(this.lblConfirmPassword);
            this.pnlConfirmPassword.Location = new System.Drawing.Point(16, 149);
            this.pnlConfirmPassword.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.pnlConfirmPassword.Name = "pnlConfirmPassword";
            this.pnlConfirmPassword.Size = new System.Drawing.Size(232, 32);
            this.pnlConfirmPassword.TabIndex = 14;
            // 
            // lblConfirmPassword
            // 
            this.lblConfirmPassword.AutoSize = true;
            this.lblConfirmPassword.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblConfirmPassword.Location = new System.Drawing.Point(12, 5);
            this.lblConfirmPassword.Name = "lblConfirmPassword";
            this.lblConfirmPassword.Size = new System.Drawing.Size(187, 25);
            this.lblConfirmPassword.TabIndex = 2;
            this.lblConfirmPassword.Text = "Confirm Password";
            // 
            // pnlMobileUP
            // 
            this.pnlMobileUP.Controls.Add(this.lblNewPassword);
            this.pnlMobileUP.Location = new System.Drawing.Point(16, 102);
            this.pnlMobileUP.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.pnlMobileUP.Name = "pnlMobileUP";
            this.pnlMobileUP.Size = new System.Drawing.Size(232, 32);
            this.pnlMobileUP.TabIndex = 17;
            // 
            // lblNewPassword
            // 
            this.lblNewPassword.AutoSize = true;
            this.lblNewPassword.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNewPassword.Location = new System.Drawing.Point(12, 5);
            this.lblNewPassword.Name = "lblNewPassword";
            this.lblNewPassword.Size = new System.Drawing.Size(154, 25);
            this.lblNewPassword.TabIndex = 1;
            this.lblNewPassword.Text = "New Password";
            // 
            // pnlNameUP
            // 
            this.pnlNameUP.Controls.Add(this.lblCurrentPassword);
            this.pnlNameUP.Location = new System.Drawing.Point(16, 56);
            this.pnlNameUP.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.pnlNameUP.Name = "pnlNameUP";
            this.pnlNameUP.Size = new System.Drawing.Size(232, 32);
            this.pnlNameUP.TabIndex = 16;
            // 
            // lblCurrentPassword
            // 
            this.lblCurrentPassword.AutoSize = true;
            this.lblCurrentPassword.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCurrentPassword.Location = new System.Drawing.Point(12, 5);
            this.lblCurrentPassword.Name = "lblCurrentPassword";
            this.lblCurrentPassword.Size = new System.Drawing.Size(184, 25);
            this.lblCurrentPassword.TabIndex = 0;
            this.lblCurrentPassword.Text = "Current Password";
            // 
            // lblChangePassword
            // 
            this.lblChangePassword.AutoSize = true;
            this.lblChangePassword.Font = new System.Drawing.Font("Times New Roman", 14F, ((System.Drawing.FontStyle)(((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic) 
                | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblChangePassword.Location = new System.Drawing.Point(23, 21);
            this.lblChangePassword.Name = "lblChangePassword";
            this.lblChangePassword.Size = new System.Drawing.Size(189, 28);
            this.lblChangePassword.TabIndex = 15;
            this.lblChangePassword.Text = "Change Password";
            // 
            // errPassword
            // 
            this.errPassword.ContainerControl = this;
            // 
            // errNewPassword
            // 
            this.errNewPassword.ContainerControl = this;
            // 
            // errConfirmPassword
            // 
            this.errConfirmPassword.ContainerControl = this;
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
            this.pnlButtonList.Location = new System.Drawing.Point(12, 17);
            this.pnlButtonList.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.pnlButtonList.Name = "pnlButtonList";
            this.pnlButtonList.Size = new System.Drawing.Size(147, 610);
            this.pnlButtonList.TabIndex = 4;
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
            this.btnExit.Click += new System.EventHandler(this.BtnExit_Click_1);
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
            this.btnDashboard.Click += new System.EventHandler(this.BtnDashboard_Click_1);
            // 
            // ChangePasswordManager
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.MediumAquamarine;
            this.ClientSize = new System.Drawing.Size(872, 645);
            this.Controls.Add(this.pnlButtonList);
            this.Controls.Add(this.pnlChangePassword);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "ChangePasswordManager";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Change Password";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.ChangePasswordManager_FormClosed);
            this.pnlChangePassword.ResumeLayout(false);
            this.pnlUpdateInfo.ResumeLayout(false);
            this.pnlUpdateInfo.PerformLayout();
            this.pnlConfirmPassword.ResumeLayout(false);
            this.pnlConfirmPassword.PerformLayout();
            this.pnlMobileUP.ResumeLayout(false);
            this.pnlMobileUP.PerformLayout();
            this.pnlNameUP.ResumeLayout(false);
            this.pnlNameUP.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errPassword)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errNewPassword)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errConfirmPassword)).EndInit();
            this.pnlButtonList.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Panel pnlChangePassword;
        private System.Windows.Forms.Panel pnlUpdateInfo;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Button btnRefresh;
        private System.Windows.Forms.TextBox txtConfirmPassword;
        private System.Windows.Forms.TextBox txtNewPassword;
        private System.Windows.Forms.TextBox txtCurrentPassword;
        private System.Windows.Forms.Panel pnlConfirmPassword;
        private System.Windows.Forms.Label lblConfirmPassword;
        private System.Windows.Forms.Panel pnlMobileUP;
        private System.Windows.Forms.Label lblNewPassword;
        private System.Windows.Forms.Panel pnlNameUP;
        private System.Windows.Forms.Label lblCurrentPassword;
        private System.Windows.Forms.Label lblChangePassword;
        private System.Windows.Forms.ErrorProvider errPassword;
        private System.Windows.Forms.ErrorProvider errNewPassword;
        private System.Windows.Forms.ErrorProvider errConfirmPassword;
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