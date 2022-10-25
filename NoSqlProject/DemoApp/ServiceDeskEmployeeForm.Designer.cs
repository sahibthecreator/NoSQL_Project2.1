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
            this.tabPageUserManagement = new System.Windows.Forms.TabPage();
            this.panelAddUser = new System.Windows.Forms.Panel();
            this.comboLocation = new System.Windows.Forms.ComboBox();
            this.comboType = new System.Windows.Forms.ComboBox();
            this.checkBoxYes = new System.Windows.Forms.CheckBox();
            this.txtPhoneNumber = new System.Windows.Forms.TextBox();
            this.txtEmail = new System.Windows.Forms.TextBox();
            this.txtLastName = new System.Windows.Forms.TextBox();
            this.txtFirstName = new System.Windows.Forms.TextBox();
            this.lblSentPassword = new System.Windows.Forms.Label();
            this.lblLocation = new System.Windows.Forms.Label();
            this.lblPhoneNumber = new System.Windows.Forms.Label();
            this.lblEmail = new System.Windows.Forms.Label();
            this.lblType = new System.Windows.Forms.Label();
            this.lblLastName = new System.Windows.Forms.Label();
            this.lblFirstName = new System.Windows.Forms.Label();
            this.btnCancel = new System.Windows.Forms.Button();
            this.btnAddUser = new System.Windows.Forms.Button();
            this.lblAddUser = new System.Windows.Forms.Label();
            this.panelUserManagement = new System.Windows.Forms.Panel();
            this.lblUserManagement = new System.Windows.Forms.Label();
            this.buttonAddNewUser = new System.Windows.Forms.Button();
            this.textBoxFilterByEmail = new System.Windows.Forms.TextBox();
            this.listViewUsers = new System.Windows.Forms.ListView();
            this.columnHeader6 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader7 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader8 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader9 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader10 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.tabPageDashboard = new System.Windows.Forms.TabPage();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.btnCreateIncident = new System.Windows.Forms.Button();
            this.textBoxFilterByEmailTickets = new System.Windows.Forms.TextBox();
            this.listViewTickets = new System.Windows.Forms.ListView();
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader3 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader4 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader5 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.tabControl1.SuspendLayout();
            this.tabPageIncidentManagement.SuspendLayout();
            this.tabPageUserManagement.SuspendLayout();
            this.panelAddUser.SuspendLayout();
            this.panelUserManagement.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPageIncidentManagement);
            this.tabControl1.Controls.Add(this.tabPageUserManagement);
            this.tabControl1.Controls.Add(this.tabPageDashboard);
            this.tabControl1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tabControl1.Location = new System.Drawing.Point(0, 3);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(800, 447);
            this.tabControl1.TabIndex = 0;
            this.tabControl1.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tabControl1_KeyPress);
            // 
            // tabPageIncidentManagement
            // 
            this.tabPageIncidentManagement.Controls.Add(this.panel1);
            this.tabPageIncidentManagement.Location = new System.Drawing.Point(4, 29);
            this.tabPageIncidentManagement.Name = "tabPageIncidentManagement";
            this.tabPageIncidentManagement.Padding = new System.Windows.Forms.Padding(3, 3, 3, 3);
            this.tabPageIncidentManagement.Size = new System.Drawing.Size(792, 414);
            this.tabPageIncidentManagement.TabIndex = 1;
            this.tabPageIncidentManagement.Text = "Incident Management";
            this.tabPageIncidentManagement.UseVisualStyleBackColor = true;
            // 
            // tabPageUserManagement
            // 
            this.tabPageUserManagement.Controls.Add(this.panelAddUser);
            this.tabPageUserManagement.Controls.Add(this.panelUserManagement);
            this.tabPageUserManagement.Location = new System.Drawing.Point(4, 29);
            this.tabPageUserManagement.Name = "tabPageUserManagement";
            this.tabPageUserManagement.Padding = new System.Windows.Forms.Padding(3, 3, 3, 3);
            this.tabPageUserManagement.Size = new System.Drawing.Size(792, 414);
            this.tabPageUserManagement.TabIndex = 2;
            this.tabPageUserManagement.Text = "User Management";
            this.tabPageUserManagement.UseVisualStyleBackColor = true;
            this.tabPageUserManagement.Click += new System.EventHandler(this.tabPageUserManagement_Click);
            // 
            // panelAddUser
            // 
            this.panelAddUser.Controls.Add(this.comboLocation);
            this.panelAddUser.Controls.Add(this.comboType);
            this.panelAddUser.Controls.Add(this.checkBoxYes);
            this.panelAddUser.Controls.Add(this.txtPhoneNumber);
            this.panelAddUser.Controls.Add(this.txtEmail);
            this.panelAddUser.Controls.Add(this.txtLastName);
            this.panelAddUser.Controls.Add(this.txtFirstName);
            this.panelAddUser.Controls.Add(this.lblSentPassword);
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
            this.panelAddUser.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.panelAddUser.Name = "panelAddUser";
            this.panelAddUser.Size = new System.Drawing.Size(795, 422);
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
            this.comboLocation.Location = new System.Drawing.Point(225, 255);
            this.comboLocation.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.comboLocation.Name = "comboLocation";
            this.comboLocation.Size = new System.Drawing.Size(238, 24);
            this.comboLocation.TabIndex = 22;
            // 
            // comboType
            // 
            this.comboType.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboType.FormattingEnabled = true;
            this.comboType.Items.AddRange(new object[] {
            "Employee",
            "Service Desk Employee"});
            this.comboType.Location = new System.Drawing.Point(225, 157);
            this.comboType.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.comboType.Name = "comboType";
            this.comboType.Size = new System.Drawing.Size(238, 24);
            this.comboType.TabIndex = 21;
            // 
            // checkBoxYes
            // 
            this.checkBoxYes.AutoSize = true;
            this.checkBoxYes.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.checkBoxYes.Location = new System.Drawing.Point(225, 293);
            this.checkBoxYes.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.checkBoxYes.Name = "checkBoxYes";
            this.checkBoxYes.Size = new System.Drawing.Size(240, 17);
            this.checkBoxYes.TabIndex = 20;
            this.checkBoxYes.Text = "yes, a password e-mail will be sent to the user";
            this.checkBoxYes.UseVisualStyleBackColor = true;
            // 
            // txtPhoneNumber
            // 
            this.txtPhoneNumber.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPhoneNumber.Location = new System.Drawing.Point(225, 224);
            this.txtPhoneNumber.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtPhoneNumber.Name = "txtPhoneNumber";
            this.txtPhoneNumber.Size = new System.Drawing.Size(238, 23);
            this.txtPhoneNumber.TabIndex = 19;
            // 
            // txtEmail
            // 
            this.txtEmail.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtEmail.Location = new System.Drawing.Point(225, 192);
            this.txtEmail.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.Size = new System.Drawing.Size(238, 23);
            this.txtEmail.TabIndex = 18;
            // 
            // txtLastName
            // 
            this.txtLastName.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtLastName.Location = new System.Drawing.Point(225, 123);
            this.txtLastName.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtLastName.Name = "txtLastName";
            this.txtLastName.Size = new System.Drawing.Size(238, 23);
            this.txtLastName.TabIndex = 17;
            // 
            // txtFirstName
            // 
            this.txtFirstName.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtFirstName.ForeColor = System.Drawing.SystemColors.WindowText;
            this.txtFirstName.Location = new System.Drawing.Point(225, 94);
            this.txtFirstName.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtFirstName.Name = "txtFirstName";
            this.txtFirstName.Size = new System.Drawing.Size(238, 23);
            this.txtFirstName.TabIndex = 16;
            // 
            // lblSentPassword
            // 
            this.lblSentPassword.AutoSize = true;
            this.lblSentPassword.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSentPassword.Location = new System.Drawing.Point(47, 292);
            this.lblSentPassword.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblSentPassword.Name = "lblSentPassword";
            this.lblSentPassword.Size = new System.Drawing.Size(113, 17);
            this.lblSentPassword.TabIndex = 15;
            this.lblSentPassword.Text = "Send password?";
            // 
            // lblLocation
            // 
            this.lblLocation.AutoSize = true;
            this.lblLocation.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblLocation.Location = new System.Drawing.Point(47, 260);
            this.lblLocation.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblLocation.Name = "lblLocation";
            this.lblLocation.Size = new System.Drawing.Size(114, 17);
            this.lblLocation.TabIndex = 14;
            this.lblLocation.Text = "Location/branch:";
            // 
            // lblPhoneNumber
            // 
            this.lblPhoneNumber.AutoSize = true;
            this.lblPhoneNumber.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPhoneNumber.Location = new System.Drawing.Point(47, 227);
            this.lblPhoneNumber.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblPhoneNumber.Name = "lblPhoneNumber";
            this.lblPhoneNumber.Size = new System.Drawing.Size(105, 17);
            this.lblPhoneNumber.TabIndex = 13;
            this.lblPhoneNumber.Text = "Phone number:";
            // 
            // lblEmail
            // 
            this.lblEmail.AutoSize = true;
            this.lblEmail.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEmail.Location = new System.Drawing.Point(47, 195);
            this.lblEmail.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblEmail.Name = "lblEmail";
            this.lblEmail.Size = new System.Drawing.Size(106, 17);
            this.lblEmail.TabIndex = 12;
            this.lblEmail.Text = "E-mail address:";
            // 
            // lblType
            // 
            this.lblType.AutoSize = true;
            this.lblType.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblType.Location = new System.Drawing.Point(47, 162);
            this.lblType.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblType.Name = "lblType";
            this.lblType.Size = new System.Drawing.Size(92, 17);
            this.lblType.TabIndex = 11;
            this.lblType.Text = "Type of user:";
            // 
            // lblLastName
            // 
            this.lblLastName.AutoSize = true;
            this.lblLastName.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblLastName.Location = new System.Drawing.Point(47, 130);
            this.lblLastName.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblLastName.Name = "lblLastName";
            this.lblLastName.Size = new System.Drawing.Size(80, 17);
            this.lblLastName.TabIndex = 10;
            this.lblLastName.Text = "Last Name:";
            // 
            // lblFirstName
            // 
            this.lblFirstName.AutoSize = true;
            this.lblFirstName.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFirstName.Location = new System.Drawing.Point(47, 98);
            this.lblFirstName.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblFirstName.Name = "lblFirstName";
            this.lblFirstName.Size = new System.Drawing.Size(80, 17);
            this.lblFirstName.TabIndex = 9;
            this.lblFirstName.Text = "First Name:";
            // 
            // btnCancel
            // 
            this.btnCancel.BackColor = System.Drawing.Color.Transparent;
            this.btnCancel.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCancel.Location = new System.Drawing.Point(225, 320);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(93, 32);
            this.btnCancel.TabIndex = 8;
            this.btnCancel.Text = "CANCEL";
            this.btnCancel.UseVisualStyleBackColor = false;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // btnAddUser
            // 
            this.btnAddUser.BackColor = System.Drawing.Color.DodgerBlue;
            this.btnAddUser.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAddUser.Location = new System.Drawing.Point(368, 320);
            this.btnAddUser.Name = "btnAddUser";
            this.btnAddUser.Size = new System.Drawing.Size(93, 32);
            this.btnAddUser.TabIndex = 7;
            this.btnAddUser.Text = "ADD USER";
            this.btnAddUser.UseVisualStyleBackColor = false;
            this.btnAddUser.Click += new System.EventHandler(this.btnAddUser_Click);
            // 
            // lblAddUser
            // 
            this.lblAddUser.AutoSize = true;
            this.lblAddUser.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAddUser.Location = new System.Drawing.Point(47, 26);
            this.lblAddUser.Name = "lblAddUser";
            this.lblAddUser.Size = new System.Drawing.Size(228, 31);
            this.lblAddUser.TabIndex = 5;
            this.lblAddUser.Text = "Create new user";
            // 
            // panelUserManagement
            // 
            this.panelUserManagement.Controls.Add(this.lblUserManagement);
            this.panelUserManagement.Controls.Add(this.buttonAddNewUser);
            this.panelUserManagement.Controls.Add(this.textBoxFilterByEmail);
            this.panelUserManagement.Controls.Add(this.listViewUsers);
            this.panelUserManagement.Location = new System.Drawing.Point(0, 0);
            this.panelUserManagement.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.panelUserManagement.Name = "panelUserManagement";
            this.panelUserManagement.Size = new System.Drawing.Size(795, 422);
            this.panelUserManagement.TabIndex = 8;
            // 
            // lblUserManagement
            // 
            this.lblUserManagement.AutoSize = true;
            this.lblUserManagement.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblUserManagement.Location = new System.Drawing.Point(47, 26);
            this.lblUserManagement.Name = "lblUserManagement";
            this.lblUserManagement.Size = new System.Drawing.Size(251, 31);
            this.lblUserManagement.TabIndex = 4;
            this.lblUserManagement.Text = "User management";
            // 
            // buttonAddNewUser
            // 
            this.buttonAddNewUser.BackColor = System.Drawing.Color.LawnGreen;
            this.buttonAddNewUser.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonAddNewUser.Location = new System.Drawing.Point(578, 66);
            this.buttonAddNewUser.Name = "buttonAddNewUser";
            this.buttonAddNewUser.Size = new System.Drawing.Size(109, 33);
            this.buttonAddNewUser.TabIndex = 6;
            this.buttonAddNewUser.Text = "+ ADD NEW USER";
            this.buttonAddNewUser.UseVisualStyleBackColor = false;
            this.buttonAddNewUser.Click += new System.EventHandler(this.buttonAddNewUser_Click);
            // 
            // textBoxFilterByEmail
            // 
            this.textBoxFilterByEmail.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxFilterByEmail.ForeColor = System.Drawing.SystemColors.ScrollBar;
            this.textBoxFilterByEmail.Location = new System.Drawing.Point(47, 78);
            this.textBoxFilterByEmail.Name = "textBoxFilterByEmail";
            this.textBoxFilterByEmail.Size = new System.Drawing.Size(214, 24);
            this.textBoxFilterByEmail.TabIndex = 7;
            this.textBoxFilterByEmail.Text = "Filter by email";
            this.textBoxFilterByEmail.Click += new System.EventHandler(this.textBoxFilterByEmail_Click);
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
            this.listViewUsers.Location = new System.Drawing.Point(47, 123);
            this.listViewUsers.Name = "listViewUsers";
            this.listViewUsers.Size = new System.Drawing.Size(642, 283);
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
            // tabPageDashboard
            // 
            this.tabPageDashboard.Location = new System.Drawing.Point(4, 29);
            this.tabPageDashboard.Name = "tabPageDashboard";
            this.tabPageDashboard.Padding = new System.Windows.Forms.Padding(3, 3, 3, 3);
            this.tabPageDashboard.Size = new System.Drawing.Size(792, 414);
            this.tabPageDashboard.TabIndex = 0;
            this.tabPageDashboard.Text = "Dashboard";
            this.tabPageDashboard.UseVisualStyleBackColor = true;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.btnCreateIncident);
            this.panel1.Controls.Add(this.textBoxFilterByEmailTickets);
            this.panel1.Controls.Add(this.listViewTickets);
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(792, 414);
            this.panel1.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(47, 26);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(233, 31);
            this.label1.TabIndex = 8;
            this.label1.Text = "Tickets overview";
            // 
            // btnCreateIncident
            // 
            this.btnCreateIncident.BackColor = System.Drawing.Color.DodgerBlue;
            this.btnCreateIncident.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCreateIncident.Location = new System.Drawing.Point(575, 66);
            this.btnCreateIncident.Name = "btnCreateIncident";
            this.btnCreateIncident.Size = new System.Drawing.Size(112, 33);
            this.btnCreateIncident.TabIndex = 10;
            this.btnCreateIncident.Text = "CREATE INCIDENT";
            this.btnCreateIncident.UseVisualStyleBackColor = false;
            // 
            // textBoxFilterByEmailTickets
            // 
            this.textBoxFilterByEmailTickets.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxFilterByEmailTickets.ForeColor = System.Drawing.SystemColors.ScrollBar;
            this.textBoxFilterByEmailTickets.Location = new System.Drawing.Point(47, 78);
            this.textBoxFilterByEmailTickets.Name = "textBoxFilterByEmailTickets";
            this.textBoxFilterByEmailTickets.Size = new System.Drawing.Size(214, 24);
            this.textBoxFilterByEmailTickets.TabIndex = 11;
            this.textBoxFilterByEmailTickets.Text = "Filter by email";
            // 
            // listViewTickets
            // 
            this.listViewTickets.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader2,
            this.columnHeader3,
            this.columnHeader4,
            this.columnHeader5});
            this.listViewTickets.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.listViewTickets.HideSelection = false;
            this.listViewTickets.Location = new System.Drawing.Point(47, 123);
            this.listViewTickets.Name = "listViewTickets";
            this.listViewTickets.Size = new System.Drawing.Size(642, 283);
            this.listViewTickets.TabIndex = 9;
            this.listViewTickets.UseCompatibleStateImageBehavior = false;
            this.listViewTickets.View = System.Windows.Forms.View.Details;
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "ID";
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "Subject";
            this.columnHeader2.Width = 200;
            // 
            // columnHeader3
            // 
            this.columnHeader3.Text = "User";
            this.columnHeader3.Width = 120;
            // 
            // columnHeader4
            // 
            this.columnHeader4.Text = "Date";
            this.columnHeader4.Width = 120;
            // 
            // columnHeader5
            // 
            this.columnHeader5.Text = "Status";
            this.columnHeader5.Width = 80;
            // 
            // ServiceDeskEmployeeForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.tabControl1);
            this.Name = "ServiceDeskEmployeeForm";
            this.Text = "ServiceDeskEmployeeForm";
            this.tabControl1.ResumeLayout(false);
            this.tabPageIncidentManagement.ResumeLayout(false);
            this.tabPageUserManagement.ResumeLayout(false);
            this.panelAddUser.ResumeLayout(false);
            this.panelAddUser.PerformLayout();
            this.panelUserManagement.ResumeLayout(false);
            this.panelUserManagement.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPageDashboard;
        private System.Windows.Forms.TabPage tabPageIncidentManagement;
        private System.Windows.Forms.TabPage tabPageUserManagement;
        private System.Windows.Forms.TextBox textBoxFilterByEmail;
        private System.Windows.Forms.Button buttonAddNewUser;
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
        private System.Windows.Forms.Label lblSentPassword;
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
        private System.Windows.Forms.CheckBox checkBoxYes;
        private System.Windows.Forms.ComboBox comboLocation;
        private System.Windows.Forms.ComboBox comboType;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnCreateIncident;
        private System.Windows.Forms.TextBox textBoxFilterByEmailTickets;
        private System.Windows.Forms.ListView listViewTickets;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.ColumnHeader columnHeader3;
        private System.Windows.Forms.ColumnHeader columnHeader4;
        private System.Windows.Forms.ColumnHeader columnHeader5;
    }
}