﻿namespace DemoApp
{
    partial class ServiceDeskEmployeeForm
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
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPageIncidentManagement = new System.Windows.Forms.TabPage();
            this.panelTicketsOverview = new System.Windows.Forms.Panel();
            this.btnLow = new System.Windows.Forms.Button();
            this.label10 = new System.Windows.Forms.Label();
            this.btnHigh = new System.Windows.Forms.Button();
            this.btnResolve = new System.Windows.Forms.Button();
            this.btnCloseTicket = new System.Windows.Forms.Button();
            this.btnDeleteTicket = new System.Windows.Forms.Button();
            this.btnEditTicket = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.btnCreateTicket = new System.Windows.Forms.Button();
            this.textBoxFilterBySubject = new System.Windows.Forms.TextBox();
            this.listViewTickets = new System.Windows.Forms.ListView();
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader11 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader12 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader3 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader14 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader13 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader5 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader15 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.panelCreateTicket = new System.Windows.Forms.Panel();
            this.cmbPriorityIncident = new System.Windows.Forms.ComboBox();
            this.txtDescriptionIncident = new System.Windows.Forms.RichTextBox();
            this.cmbDeadlineIncident = new System.Windows.Forms.ComboBox();
            this.cmbTypeIncident = new System.Windows.Forms.ComboBox();
            this.txtUserNameIncident = new System.Windows.Forms.TextBox();
            this.txtSubjectIncident = new System.Windows.Forms.TextBox();
            this.txtDateReported = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.btnCancelCreateTicket = new System.Windows.Forms.Button();
            this.btnSubmitTicket = new System.Windows.Forms.Button();
            this.label9 = new System.Windows.Forms.Label();
            this.tabPageUserManagement = new System.Windows.Forms.TabPage();
            this.panelUserManagement = new System.Windows.Forms.Panel();
            this.btnAdd = new System.Windows.Forms.Button();
            this.lblUserManagement = new System.Windows.Forms.Label();
            this.textBoxFilterByEmail = new System.Windows.Forms.TextBox();
            this.listViewUsers = new System.Windows.Forms.ListView();
            this.columnHeader6 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader7 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader8 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader9 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader10 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.panelAddUser = new System.Windows.Forms.Panel();
            this.comboLocation = new System.Windows.Forms.ComboBox();
            this.comboType = new System.Windows.Forms.ComboBox();
            this.txtPhoneNumber = new System.Windows.Forms.TextBox();
            this.txtEmail = new System.Windows.Forms.TextBox();
            this.txtLastName = new System.Windows.Forms.TextBox();
            this.txtFirstName = new System.Windows.Forms.TextBox();
            this.lblLocation = new System.Windows.Forms.Label();
            this.lblPhoneNumber = new System.Windows.Forms.Label();
            this.lblEmail = new System.Windows.Forms.Label();
            this.lblType = new System.Windows.Forms.Label();
            this.lblLastName = new System.Windows.Forms.Label();
            this.lblFirstName = new System.Windows.Forms.Label();
            this.btnCancel = new System.Windows.Forms.Button();
            this.btnAddUser = new System.Windows.Forms.Button();
            this.lblAddUser = new System.Windows.Forms.Label();
            this.tabPageDashboard = new System.Windows.Forms.TabPage();
            this.tabControl1.SuspendLayout();
            this.tabPageIncidentManagement.SuspendLayout();
            this.panelTicketsOverview.SuspendLayout();
            this.panelCreateTicket.SuspendLayout();
            this.tabPageUserManagement.SuspendLayout();
            this.panelUserManagement.SuspendLayout();
            this.panelAddUser.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPageIncidentManagement);
            this.tabControl1.Controls.Add(this.tabPageUserManagement);
            this.tabControl1.Controls.Add(this.tabPageDashboard);
            this.tabControl1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tabControl1.Location = new System.Drawing.Point(0, 5);
            this.tabControl1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(1200, 688);
            this.tabControl1.TabIndex = 0;
            this.tabControl1.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tabControl1_KeyPress);
            // 
            // tabPageIncidentManagement
            // 
            this.tabPageIncidentManagement.Controls.Add(this.panelTicketsOverview);
            this.tabPageIncidentManagement.Controls.Add(this.panelCreateTicket);
            this.tabPageIncidentManagement.Location = new System.Drawing.Point(4, 38);
            this.tabPageIncidentManagement.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.tabPageIncidentManagement.Name = "tabPageIncidentManagement";
            this.tabPageIncidentManagement.Padding = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.tabPageIncidentManagement.Size = new System.Drawing.Size(1192, 646);
            this.tabPageIncidentManagement.TabIndex = 1;
            this.tabPageIncidentManagement.Text = "Incident Management";
            this.tabPageIncidentManagement.UseVisualStyleBackColor = true;
            // 
            // panelTicketsOverview
            // 
            this.panelTicketsOverview.Controls.Add(this.btnLow);
            this.panelTicketsOverview.Controls.Add(this.label10);
            this.panelTicketsOverview.Controls.Add(this.btnHigh);
            this.panelTicketsOverview.Controls.Add(this.btnResolve);
            this.panelTicketsOverview.Controls.Add(this.btnCloseTicket);
            this.panelTicketsOverview.Controls.Add(this.btnDeleteTicket);
            this.panelTicketsOverview.Controls.Add(this.btnEditTicket);
            this.panelTicketsOverview.Controls.Add(this.label1);
            this.panelTicketsOverview.Controls.Add(this.btnCreateTicket);
            this.panelTicketsOverview.Controls.Add(this.textBoxFilterBySubject);
            this.panelTicketsOverview.Controls.Add(this.listViewTickets);
            this.panelTicketsOverview.Location = new System.Drawing.Point(0, 0);
            this.panelTicketsOverview.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.panelTicketsOverview.Name = "panelTicketsOverview";
            this.panelTicketsOverview.Size = new System.Drawing.Size(1188, 637);
            this.panelTicketsOverview.TabIndex = 0;
            // 
            // btnLow
            // 
            this.btnLow.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLow.Location = new System.Drawing.Point(646, 32);
            this.btnLow.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnLow.Name = "btnLow";
            this.btnLow.Size = new System.Drawing.Size(60, 35);
            this.btnLow.TabIndex = 18;
            this.btnLow.Text = "Low";
            this.btnLow.UseVisualStyleBackColor = true;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(580, 8);
            this.label10.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(125, 20);
            this.label10.TabIndex = 17;
            this.label10.Text = "Filter by priority";
            // 
            // btnHigh
            // 
            this.btnHigh.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnHigh.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btnHigh.Location = new System.Drawing.Point(567, 31);
            this.btnHigh.Name = "btnHigh";
            this.btnHigh.Size = new System.Drawing.Size(60, 37);
            this.btnHigh.TabIndex = 16;
            this.btnHigh.Text = "High";
            this.btnHigh.UseVisualStyleBackColor = true;
            this.btnHigh.Click += new System.EventHandler(this.btnFilterByPriority_Click);
            // 
            // btnResolve
            // 
            this.btnResolve.BackColor = System.Drawing.Color.Yellow;
            this.btnResolve.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnResolve.Location = new System.Drawing.Point(1064, 106);
            this.btnResolve.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnResolve.Name = "btnResolve";
            this.btnResolve.Size = new System.Drawing.Size(112, 51);
            this.btnResolve.TabIndex = 15;
            this.btnResolve.Text = "RESOLVE";
            this.btnResolve.UseVisualStyleBackColor = false;
            this.btnResolve.Click += new System.EventHandler(this.btnResolve_Click);
            // 
            // btnCloseTicket
            // 
            this.btnCloseTicket.BackColor = System.Drawing.Color.LimeGreen;
            this.btnCloseTicket.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCloseTicket.Location = new System.Drawing.Point(921, 106);
            this.btnCloseTicket.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnCloseTicket.Name = "btnCloseTicket";
            this.btnCloseTicket.Size = new System.Drawing.Size(112, 51);
            this.btnCloseTicket.TabIndex = 14;
            this.btnCloseTicket.Text = "CLOSE";
            this.btnCloseTicket.UseVisualStyleBackColor = false;
            this.btnCloseTicket.Click += new System.EventHandler(this.btnCloseTicket_Click);
            // 
            // btnDeleteTicket
            // 
            this.btnDeleteTicket.BackColor = System.Drawing.Color.Red;
            this.btnDeleteTicket.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDeleteTicket.Location = new System.Drawing.Point(783, 106);
            this.btnDeleteTicket.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnDeleteTicket.Name = "btnDeleteTicket";
            this.btnDeleteTicket.Size = new System.Drawing.Size(112, 51);
            this.btnDeleteTicket.TabIndex = 13;
            this.btnDeleteTicket.Text = "DELETE";
            this.btnDeleteTicket.UseVisualStyleBackColor = false;
            this.btnDeleteTicket.Click += new System.EventHandler(this.btnDeleteTicket_Click);
            // 
            // btnEditTicket
            // 
            this.btnEditTicket.BackColor = System.Drawing.Color.Gray;
            this.btnEditTicket.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEditTicket.Location = new System.Drawing.Point(646, 106);
            this.btnEditTicket.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnEditTicket.Name = "btnEditTicket";
            this.btnEditTicket.Size = new System.Drawing.Size(112, 51);
            this.btnEditTicket.TabIndex = 12;
            this.btnEditTicket.Text = "EDIT";
            this.btnEditTicket.UseVisualStyleBackColor = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(70, 40);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(344, 47);
            this.label1.TabIndex = 8;
            this.label1.Text = "Tickets overview";
            // 
            // btnCreateTicket
            // 
            this.btnCreateTicket.BackColor = System.Drawing.Color.DodgerBlue;
            this.btnCreateTicket.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCreateTicket.Location = new System.Drawing.Point(456, 106);
            this.btnCreateTicket.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnCreateTicket.Name = "btnCreateTicket";
            this.btnCreateTicket.Size = new System.Drawing.Size(168, 51);
            this.btnCreateTicket.TabIndex = 10;
            this.btnCreateTicket.Text = "CREATE TICKET";
            this.btnCreateTicket.UseVisualStyleBackColor = false;
            this.btnCreateTicket.Click += new System.EventHandler(this.btnCreateTicket_Click);
            // 
            // textBoxFilterBySubject
            // 
            this.textBoxFilterBySubject.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxFilterBySubject.ForeColor = System.Drawing.SystemColors.ScrollBar;
            this.textBoxFilterBySubject.Location = new System.Drawing.Point(70, 120);
            this.textBoxFilterBySubject.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.textBoxFilterBySubject.Name = "textBoxFilterBySubject";
            this.textBoxFilterBySubject.Size = new System.Drawing.Size(319, 33);
            this.textBoxFilterBySubject.TabIndex = 11;
            this.textBoxFilterBySubject.Text = "Filter by email";
            this.textBoxFilterBySubject.Click += new System.EventHandler(this.textBoxFilterBySubject_Click);
            this.textBoxFilterBySubject.TextChanged += new System.EventHandler(this.textBoxFilterBySubject_TextChanged);
            // 
            // listViewTickets
            // 
            this.listViewTickets.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader11,
            this.columnHeader2,
            this.columnHeader12,
            this.columnHeader3,
            this.columnHeader14,
            this.columnHeader13,
            this.columnHeader5,
            this.columnHeader15});
            this.listViewTickets.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.listViewTickets.FullRowSelect = true;
            this.listViewTickets.HideSelection = false;
            this.listViewTickets.Location = new System.Drawing.Point(70, 189);
            this.listViewTickets.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.listViewTickets.Name = "listViewTickets";
            this.listViewTickets.Size = new System.Drawing.Size(1104, 433);
            this.listViewTickets.TabIndex = 9;
            this.listViewTickets.UseCompatibleStateImageBehavior = false;
            this.listViewTickets.View = System.Windows.Forms.View.Details;
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "ID";
            this.columnHeader1.Width = 80;
            // 
            // columnHeader11
            // 
            this.columnHeader11.Text = "date";
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "Subject";
            // 
            // columnHeader12
            // 
            this.columnHeader12.Text = "Type";
            // 
            // columnHeader3
            // 
            this.columnHeader3.Text = "User";
            this.columnHeader3.Width = 120;
            // 
            // columnHeader14
            // 
            this.columnHeader14.Text = "deadline";
            this.columnHeader14.Width = 100;
            // 
            // columnHeader13
            // 
            this.columnHeader13.Text = "Description";
            this.columnHeader13.Width = 100;
            // 
            // columnHeader5
            // 
            this.columnHeader5.Text = "Status";
            this.columnHeader5.Width = 80;
            // 
            // columnHeader15
            // 
            this.columnHeader15.Text = "priority";
            // 
            // panelCreateTicket
            // 
            this.panelCreateTicket.Controls.Add(this.cmbPriorityIncident);
            this.panelCreateTicket.Controls.Add(this.txtDescriptionIncident);
            this.panelCreateTicket.Controls.Add(this.cmbDeadlineIncident);
            this.panelCreateTicket.Controls.Add(this.cmbTypeIncident);
            this.panelCreateTicket.Controls.Add(this.txtUserNameIncident);
            this.panelCreateTicket.Controls.Add(this.txtSubjectIncident);
            this.panelCreateTicket.Controls.Add(this.txtDateReported);
            this.panelCreateTicket.Controls.Add(this.label2);
            this.panelCreateTicket.Controls.Add(this.label3);
            this.panelCreateTicket.Controls.Add(this.label4);
            this.panelCreateTicket.Controls.Add(this.label5);
            this.panelCreateTicket.Controls.Add(this.label6);
            this.panelCreateTicket.Controls.Add(this.label7);
            this.panelCreateTicket.Controls.Add(this.label8);
            this.panelCreateTicket.Controls.Add(this.btnCancelCreateTicket);
            this.panelCreateTicket.Controls.Add(this.btnSubmitTicket);
            this.panelCreateTicket.Controls.Add(this.label9);
            this.panelCreateTicket.Location = new System.Drawing.Point(0, 0);
            this.panelCreateTicket.Name = "panelCreateTicket";
            this.panelCreateTicket.Size = new System.Drawing.Size(1188, 637);
            this.panelCreateTicket.TabIndex = 12;
            this.panelCreateTicket.Visible = false;
            // 
            // cmbPriorityIncident
            // 
            this.cmbPriorityIncident.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbPriorityIncident.FormattingEnabled = true;
            this.cmbPriorityIncident.Items.AddRange(new object[] {
            "Low",
            "Normal",
            "High"});
            this.cmbPriorityIncident.Location = new System.Drawing.Point(338, 345);
            this.cmbPriorityIncident.Name = "cmbPriorityIncident";
            this.cmbPriorityIncident.Size = new System.Drawing.Size(355, 33);
            this.cmbPriorityIncident.TabIndex = 24;
            // 
            // txtDescriptionIncident
            // 
            this.txtDescriptionIncident.Location = new System.Drawing.Point(804, 182);
            this.txtDescriptionIncident.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtDescriptionIncident.Name = "txtDescriptionIncident";
            this.txtDescriptionIncident.Size = new System.Drawing.Size(325, 264);
            this.txtDescriptionIncident.TabIndex = 23;
            this.txtDescriptionIncident.Text = "";
            // 
            // cmbDeadlineIncident
            // 
            this.cmbDeadlineIncident.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbDeadlineIncident.FormattingEnabled = true;
            this.cmbDeadlineIncident.Items.AddRange(new object[] {
            "7 days",
            "14 days",
            "28 days",
            "6 months"});
            this.cmbDeadlineIncident.Location = new System.Drawing.Point(338, 392);
            this.cmbDeadlineIncident.Name = "cmbDeadlineIncident";
            this.cmbDeadlineIncident.Size = new System.Drawing.Size(355, 33);
            this.cmbDeadlineIncident.TabIndex = 22;
            // 
            // cmbTypeIncident
            // 
            this.cmbTypeIncident.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbTypeIncident.FormattingEnabled = true;
            this.cmbTypeIncident.Items.AddRange(new object[] {
            "Software",
            "Hardware",
            "Service"});
            this.cmbTypeIncident.Location = new System.Drawing.Point(338, 242);
            this.cmbTypeIncident.Name = "cmbTypeIncident";
            this.cmbTypeIncident.Size = new System.Drawing.Size(355, 33);
            this.cmbTypeIncident.TabIndex = 21;
            // 
            // txtUserNameIncident
            // 
            this.txtUserNameIncident.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtUserNameIncident.Location = new System.Drawing.Point(338, 295);
            this.txtUserNameIncident.Name = "txtUserNameIncident";
            this.txtUserNameIncident.Size = new System.Drawing.Size(355, 30);
            this.txtUserNameIncident.TabIndex = 18;
            // 
            // txtSubjectIncident
            // 
            this.txtSubjectIncident.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSubjectIncident.Location = new System.Drawing.Point(338, 189);
            this.txtSubjectIncident.Name = "txtSubjectIncident";
            this.txtSubjectIncident.Size = new System.Drawing.Size(355, 30);
            this.txtSubjectIncident.TabIndex = 17;
            // 
            // txtDateReported
            // 
            this.txtDateReported.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDateReported.ForeColor = System.Drawing.SystemColors.WindowText;
            this.txtDateReported.Location = new System.Drawing.Point(338, 145);
            this.txtDateReported.Name = "txtDateReported";
            this.txtDateReported.Size = new System.Drawing.Size(355, 30);
            this.txtDateReported.TabIndex = 16;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(800, 151);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(115, 25);
            this.label2.TabIndex = 15;
            this.label2.Text = "Description:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(70, 400);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(177, 25);
            this.label3.TabIndex = 14;
            this.label3.Text = "Deadline/follow up:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(70, 349);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(77, 25);
            this.label4.TabIndex = 13;
            this.label4.Text = "Priority:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(70, 300);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(166, 25);
            this.label5.TabIndex = 12;
            this.label5.Text = "Reported by user:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(70, 249);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(156, 25);
            this.label6.TabIndex = 11;
            this.label6.Text = "Type of incident:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(70, 200);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(177, 25);
            this.label7.TabIndex = 10;
            this.label7.Text = "Subject of incident:";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(70, 151);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(178, 25);
            this.label8.TabIndex = 9;
            this.label8.Text = "Date/time reported:";
            // 
            // btnCancelCreateTicket
            // 
            this.btnCancelCreateTicket.BackColor = System.Drawing.Color.Transparent;
            this.btnCancelCreateTicket.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCancelCreateTicket.Location = new System.Drawing.Point(630, 523);
            this.btnCancelCreateTicket.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnCancelCreateTicket.Name = "btnCancelCreateTicket";
            this.btnCancelCreateTicket.Size = new System.Drawing.Size(140, 49);
            this.btnCancelCreateTicket.TabIndex = 8;
            this.btnCancelCreateTicket.Text = "CANCEL";
            this.btnCancelCreateTicket.UseVisualStyleBackColor = false;
            this.btnCancelCreateTicket.Click += new System.EventHandler(this.btnCancelCreateTicket_Click);
            // 
            // btnSubmitTicket
            // 
            this.btnSubmitTicket.BackColor = System.Drawing.Color.DodgerBlue;
            this.btnSubmitTicket.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSubmitTicket.Location = new System.Drawing.Point(778, 523);
            this.btnSubmitTicket.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnSubmitTicket.Name = "btnSubmitTicket";
            this.btnSubmitTicket.Size = new System.Drawing.Size(146, 49);
            this.btnSubmitTicket.TabIndex = 7;
            this.btnSubmitTicket.Text = "SUBMIT TICKET";
            this.btnSubmitTicket.UseVisualStyleBackColor = false;
            this.btnSubmitTicket.Click += new System.EventHandler(this.btnSubmitTicket_Click);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(70, 40);
            this.label9.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(356, 47);
            this.label9.TabIndex = 5;
            this.label9.Text = "Create new ticket";
            // 
            // tabPageUserManagement
            // 
            this.tabPageUserManagement.Controls.Add(this.panelUserManagement);
            this.tabPageUserManagement.Controls.Add(this.panelAddUser);
            this.tabPageUserManagement.Location = new System.Drawing.Point(4, 38);
            this.tabPageUserManagement.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.tabPageUserManagement.Name = "tabPageUserManagement";
            this.tabPageUserManagement.Padding = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.tabPageUserManagement.Size = new System.Drawing.Size(1192, 646);
            this.tabPageUserManagement.TabIndex = 2;
            this.tabPageUserManagement.Text = "User Management";
            this.tabPageUserManagement.UseVisualStyleBackColor = true;
            this.tabPageUserManagement.Click += new System.EventHandler(this.tabPageUserManagement_Click);
            // 
            // panelUserManagement
            // 
            this.panelUserManagement.Controls.Add(this.btnAdd);
            this.panelUserManagement.Controls.Add(this.lblUserManagement);
            this.panelUserManagement.Controls.Add(this.textBoxFilterByEmail);
            this.panelUserManagement.Controls.Add(this.listViewUsers);
            this.panelUserManagement.Location = new System.Drawing.Point(0, 0);
            this.panelUserManagement.Name = "panelUserManagement";
            this.panelUserManagement.Size = new System.Drawing.Size(1788, 998);
            this.panelUserManagement.TabIndex = 8;
            // 
            // btnAdd
            // 
            this.btnAdd.BackColor = System.Drawing.Color.LimeGreen;
            this.btnAdd.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.btnAdd.Location = new System.Drawing.Point(1003, 107);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(171, 46);
            this.btnAdd.TabIndex = 8;
            this.btnAdd.Text = "Add User";
            this.btnAdd.UseVisualStyleBackColor = false;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // lblUserManagement
            // 
            this.lblUserManagement.AutoSize = true;
            this.lblUserManagement.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblUserManagement.Location = new System.Drawing.Point(70, 40);
            this.lblUserManagement.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.lblUserManagement.Name = "lblUserManagement";
            this.lblUserManagement.Size = new System.Drawing.Size(374, 47);
            this.lblUserManagement.TabIndex = 4;
            this.lblUserManagement.Text = "User management";
            // 
            // textBoxFilterByEmail
            // 
            this.textBoxFilterByEmail.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxFilterByEmail.ForeColor = System.Drawing.SystemColors.ScrollBar;
            this.textBoxFilterByEmail.Location = new System.Drawing.Point(70, 120);
            this.textBoxFilterByEmail.Margin = new System.Windows.Forms.Padding(6, 8, 6, 8);
            this.textBoxFilterByEmail.Name = "textBoxFilterByEmail";
            this.textBoxFilterByEmail.Size = new System.Drawing.Size(319, 33);
            this.textBoxFilterByEmail.TabIndex = 7;
            this.textBoxFilterByEmail.Text = "Filter by email";
            this.textBoxFilterByEmail.Click += new System.EventHandler(this.textBoxFilterByEmail_Click);
            this.textBoxFilterByEmail.TextChanged += new System.EventHandler(this.textBoxFilterByEmail_TextChanged);
            // 
            // listViewUsers
            // 
            this.listViewUsers.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader6,
            this.columnHeader7,
            this.columnHeader8,
            this.columnHeader9,
            this.columnHeader10});
            this.listViewUsers.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.listViewUsers.HideSelection = false;
            this.listViewUsers.Location = new System.Drawing.Point(70, 189);
            this.listViewUsers.Margin = new System.Windows.Forms.Padding(6, 8, 6, 8);
            this.listViewUsers.Name = "listViewUsers";
            this.listViewUsers.Size = new System.Drawing.Size(1104, 433);
            this.listViewUsers.TabIndex = 5;
            this.listViewUsers.UseCompatibleStateImageBehavior = false;
            this.listViewUsers.View = System.Windows.Forms.View.Details;
            // 
            // columnHeader6
            // 
            this.columnHeader6.Text = "ID";
            // 
            // columnHeader7
            // 
            this.columnHeader7.Text = "Email";
            this.columnHeader7.Width = 200;
            // 
            // columnHeader8
            // 
            this.columnHeader8.Text = "First Name";
            this.columnHeader8.Width = 120;
            // 
            // columnHeader9
            // 
            this.columnHeader9.Text = "Last Name";
            this.columnHeader9.Width = 120;
            // 
            // columnHeader10
            // 
            this.columnHeader10.Text = "# tickets";
            this.columnHeader10.Width = 80;
            // 
            // panelAddUser
            // 
            this.panelAddUser.Controls.Add(this.comboLocation);
            this.panelAddUser.Controls.Add(this.comboType);
            this.panelAddUser.Controls.Add(this.txtPhoneNumber);
            this.panelAddUser.Controls.Add(this.txtEmail);
            this.panelAddUser.Controls.Add(this.txtLastName);
            this.panelAddUser.Controls.Add(this.txtFirstName);
            this.panelAddUser.Controls.Add(this.lblLocation);
            this.panelAddUser.Controls.Add(this.lblPhoneNumber);
            this.panelAddUser.Controls.Add(this.lblEmail);
            this.panelAddUser.Controls.Add(this.lblType);
            this.panelAddUser.Controls.Add(this.lblLastName);
            this.panelAddUser.Controls.Add(this.lblFirstName);
            this.panelAddUser.Controls.Add(this.btnCancel);
            this.panelAddUser.Controls.Add(this.btnAddUser);
            this.panelAddUser.Controls.Add(this.lblAddUser);
            this.panelAddUser.Location = new System.Drawing.Point(0, 0);
            this.panelAddUser.Name = "panelAddUser";
            this.panelAddUser.Size = new System.Drawing.Size(1192, 649);
            this.panelAddUser.TabIndex = 8;
            this.panelAddUser.Visible = false;
            // 
            // comboLocation
            // 
            this.comboLocation.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboLocation.FormattingEnabled = true;
            this.comboLocation.Items.AddRange(new object[] {
            "Haarlem",
            "Amterdam",
            "Utrecht"});
            this.comboLocation.Location = new System.Drawing.Point(338, 392);
            this.comboLocation.Name = "comboLocation";
            this.comboLocation.Size = new System.Drawing.Size(355, 33);
            this.comboLocation.TabIndex = 22;
            // 
            // comboType
            // 
            this.comboType.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboType.FormattingEnabled = true;
            this.comboType.Items.AddRange(new object[] {
            "Employee",
            "Service Desk Employee"});
            this.comboType.Location = new System.Drawing.Point(338, 242);
            this.comboType.Name = "comboType";
            this.comboType.Size = new System.Drawing.Size(355, 33);
            this.comboType.TabIndex = 21;
            // 
            // txtPhoneNumber
            // 
            this.txtPhoneNumber.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPhoneNumber.Location = new System.Drawing.Point(338, 345);
            this.txtPhoneNumber.Name = "txtPhoneNumber";
            this.txtPhoneNumber.Size = new System.Drawing.Size(355, 30);
            this.txtPhoneNumber.TabIndex = 19;
            // 
            // txtEmail
            // 
            this.txtEmail.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtEmail.Location = new System.Drawing.Point(338, 295);
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.Size = new System.Drawing.Size(355, 30);
            this.txtEmail.TabIndex = 18;
            // 
            // txtLastName
            // 
            this.txtLastName.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtLastName.Location = new System.Drawing.Point(338, 189);
            this.txtLastName.Name = "txtLastName";
            this.txtLastName.Size = new System.Drawing.Size(355, 30);
            this.txtLastName.TabIndex = 17;
            // 
            // txtFirstName
            // 
            this.txtFirstName.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtFirstName.ForeColor = System.Drawing.SystemColors.WindowText;
            this.txtFirstName.Location = new System.Drawing.Point(338, 145);
            this.txtFirstName.Name = "txtFirstName";
            this.txtFirstName.Size = new System.Drawing.Size(355, 30);
            this.txtFirstName.TabIndex = 16;
            // 
            // lblLocation
            // 
            this.lblLocation.AutoSize = true;
            this.lblLocation.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblLocation.Location = new System.Drawing.Point(70, 400);
            this.lblLocation.Name = "lblLocation";
            this.lblLocation.Size = new System.Drawing.Size(158, 25);
            this.lblLocation.TabIndex = 14;
            this.lblLocation.Text = "Location/branch:";
            // 
            // lblPhoneNumber
            // 
            this.lblPhoneNumber.AutoSize = true;
            this.lblPhoneNumber.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPhoneNumber.Location = new System.Drawing.Point(70, 349);
            this.lblPhoneNumber.Name = "lblPhoneNumber";
            this.lblPhoneNumber.Size = new System.Drawing.Size(146, 25);
            this.lblPhoneNumber.TabIndex = 13;
            this.lblPhoneNumber.Text = "Phone number:";
            // 
            // lblEmail
            // 
            this.lblEmail.AutoSize = true;
            this.lblEmail.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEmail.Location = new System.Drawing.Point(70, 300);
            this.lblEmail.Name = "lblEmail";
            this.lblEmail.Size = new System.Drawing.Size(148, 25);
            this.lblEmail.TabIndex = 12;
            this.lblEmail.Text = "E-mail address:";
            // 
            // lblType
            // 
            this.lblType.AutoSize = true;
            this.lblType.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblType.Location = new System.Drawing.Point(70, 249);
            this.lblType.Name = "lblType";
            this.lblType.Size = new System.Drawing.Size(127, 25);
            this.lblType.TabIndex = 11;
            this.lblType.Text = "Type of user:";
            // 
            // lblLastName
            // 
            this.lblLastName.AutoSize = true;
            this.lblLastName.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblLastName.Location = new System.Drawing.Point(70, 200);
            this.lblLastName.Name = "lblLastName";
            this.lblLastName.Size = new System.Drawing.Size(112, 25);
            this.lblLastName.TabIndex = 10;
            this.lblLastName.Text = "Last Name:";
            // 
            // lblFirstName
            // 
            this.lblFirstName.AutoSize = true;
            this.lblFirstName.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFirstName.Location = new System.Drawing.Point(70, 151);
            this.lblFirstName.Name = "lblFirstName";
            this.lblFirstName.Size = new System.Drawing.Size(112, 25);
            this.lblFirstName.TabIndex = 9;
            this.lblFirstName.Text = "First Name:";
            // 
            // btnCancel
            // 
            this.btnCancel.BackColor = System.Drawing.Color.Transparent;
            this.btnCancel.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCancel.Location = new System.Drawing.Point(338, 492);
            this.btnCancel.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(140, 49);
            this.btnCancel.TabIndex = 8;
            this.btnCancel.Text = "CANCEL";
            this.btnCancel.UseVisualStyleBackColor = false;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // btnAddUser
            // 
            this.btnAddUser.BackColor = System.Drawing.Color.DodgerBlue;
            this.btnAddUser.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAddUser.Location = new System.Drawing.Point(552, 492);
            this.btnAddUser.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnAddUser.Name = "btnAddUser";
            this.btnAddUser.Size = new System.Drawing.Size(140, 49);
            this.btnAddUser.TabIndex = 7;
            this.btnAddUser.Text = "ADD USER";
            this.btnAddUser.UseVisualStyleBackColor = false;
            this.btnAddUser.Click += new System.EventHandler(this.btnAddUser_Click);
            // 
            // lblAddUser
            // 
            this.lblAddUser.AutoSize = true;
            this.lblAddUser.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAddUser.Location = new System.Drawing.Point(70, 40);
            this.lblAddUser.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblAddUser.Name = "lblAddUser";
            this.lblAddUser.Size = new System.Drawing.Size(338, 47);
            this.lblAddUser.TabIndex = 5;
            this.lblAddUser.Text = "Create new user";
            // 
            // tabPageDashboard
            // 
            this.tabPageDashboard.Location = new System.Drawing.Point(4, 38);
            this.tabPageDashboard.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.tabPageDashboard.Name = "tabPageDashboard";
            this.tabPageDashboard.Padding = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.tabPageDashboard.Size = new System.Drawing.Size(1192, 646);
            this.tabPageDashboard.TabIndex = 0;
            this.tabPageDashboard.Text = "Dashboard";
            this.tabPageDashboard.UseVisualStyleBackColor = true;
            // 
            // ServiceDeskEmployeeForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1200, 692);
            this.Controls.Add(this.tabControl1);
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "ServiceDeskEmployeeForm";
            this.Text = "ServiceDeskEmployeeForm";
            this.tabControl1.ResumeLayout(false);
            this.tabPageIncidentManagement.ResumeLayout(false);
            this.panelTicketsOverview.ResumeLayout(false);
            this.panelTicketsOverview.PerformLayout();
            this.panelCreateTicket.ResumeLayout(false);
            this.panelCreateTicket.PerformLayout();
            this.tabPageUserManagement.ResumeLayout(false);
            this.panelUserManagement.ResumeLayout(false);
            this.panelUserManagement.PerformLayout();
            this.panelAddUser.ResumeLayout(false);
            this.panelAddUser.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPageDashboard;
        private System.Windows.Forms.TabPage tabPageIncidentManagement;
        private System.Windows.Forms.TabPage tabPageUserManagement;
        private System.Windows.Forms.TextBox textBoxFilterByEmail;
        private System.Windows.Forms.ListView listViewUsers;
        private System.Windows.Forms.ColumnHeader columnHeader6;
        private System.Windows.Forms.ColumnHeader columnHeader7;
        private System.Windows.Forms.ColumnHeader columnHeader8;
        private System.Windows.Forms.ColumnHeader columnHeader9;
        private System.Windows.Forms.ColumnHeader columnHeader10;
        private System.Windows.Forms.Label lblUserManagement;
        private System.Windows.Forms.Panel panelUserManagement;
        private System.Windows.Forms.Panel panelAddUser;
        private System.Windows.Forms.Label lblAddUser;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Button btnAddUser;
        private System.Windows.Forms.Label lblLocation;
        private System.Windows.Forms.Label lblPhoneNumber;
        private System.Windows.Forms.Label lblEmail;
        private System.Windows.Forms.Label lblType;
        private System.Windows.Forms.Label lblLastName;
        private System.Windows.Forms.Label lblFirstName;
        private System.Windows.Forms.TextBox txtPhoneNumber;
        private System.Windows.Forms.TextBox txtEmail;
        private System.Windows.Forms.TextBox txtLastName;
        private System.Windows.Forms.TextBox txtFirstName;
        private System.Windows.Forms.ComboBox comboLocation;
        private System.Windows.Forms.ComboBox comboType;
        private System.Windows.Forms.Panel panelTicketsOverview;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnCreateTicket;
        private System.Windows.Forms.TextBox textBoxFilterBySubject;
        private System.Windows.Forms.ListView listViewTickets;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.ColumnHeader columnHeader3;
        private System.Windows.Forms.ColumnHeader columnHeader5;
        private System.Windows.Forms.Panel panelCreateTicket;
        private System.Windows.Forms.ComboBox cmbDeadlineIncident;
        private System.Windows.Forms.ComboBox cmbTypeIncident;
        private System.Windows.Forms.TextBox txtUserNameIncident;
        private System.Windows.Forms.TextBox txtSubjectIncident;
        private System.Windows.Forms.TextBox txtDateReported;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Button btnCancelCreateTicket;
        private System.Windows.Forms.Button btnSubmitTicket;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.RichTextBox txtDescriptionIncident;
        private System.Windows.Forms.Button btnCloseTicket;
        private System.Windows.Forms.Button btnDeleteTicket;
        private System.Windows.Forms.Button btnEditTicket;
        private System.Windows.Forms.Button btnResolve;
        private System.Windows.Forms.Button btnHigh;

        private System.Windows.Forms.ComboBox cmbPriorityIncident;
        private System.Windows.Forms.ColumnHeader columnHeader11;
        private System.Windows.Forms.ColumnHeader columnHeader12;
        private System.Windows.Forms.ColumnHeader columnHeader14;
        private System.Windows.Forms.ColumnHeader columnHeader13;
        private System.Windows.Forms.ColumnHeader columnHeader15;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Button btnLow;
        private System.Windows.Forms.Button btnAdd;
    }
}