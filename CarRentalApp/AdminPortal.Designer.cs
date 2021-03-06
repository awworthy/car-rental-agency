﻿namespace CarRentalApp
{
    partial class AdminPortal
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
            this.topPanel = new System.Windows.Forms.Panel();
            this.logoutButton = new System.Windows.Forms.Button();
            this.companyNameLabel = new System.Windows.Forms.Label();
            this.leftSidePanel = new System.Windows.Forms.Panel();
            this.popularCarLabel = new System.Windows.Forms.Label();
            this.popularCarTypeLabel = new System.Windows.Forms.Label();
            this.findVehicleTypeLabel = new System.Windows.Forms.Label();
            this.popularBranchLabel = new System.Windows.Forms.Label();
            this.top100CustomersLabel = new System.Windows.Forms.Label();
            this.findBranchLabel = new System.Windows.Forms.Label();
            this.addNewBranchLabel = new System.Windows.Forms.Label();
            this.top10EmployeeLabel = new System.Windows.Forms.Label();
            this.branchesLabel = new System.Windows.Forms.Label();
            this.findVehicleLabel = new System.Windows.Forms.Label();
            this.addEmployeeLabel = new System.Windows.Forms.Label();
            this.addNewUserLabel = new System.Windows.Forms.Label();
            this.addNewBookingLabel = new System.Windows.Forms.Label();
            this.findBookingLabel = new System.Windows.Forms.Label();
            this.addVehicleTypeLabel = new System.Windows.Forms.Label();
            this.findEmployeeLabel = new System.Windows.Forms.Label();
            this.findUserLabel = new System.Windows.Forms.Label();
            this.addNewVehicleLabel = new System.Windows.Forms.Label();
            this.statsLabel = new System.Windows.Forms.Label();
            this.bookingsLabel = new System.Windows.Forms.Label();
            this.employeeLabel = new System.Windows.Forms.Label();
            this.vehiclesLabel = new System.Windows.Forms.Label();
            this.usersLabel = new System.Windows.Forms.Label();
            this.rightHandSidePanel = new System.Windows.Forms.Panel();
            this.topPanel.SuspendLayout();
            this.leftSidePanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // topPanel
            // 
            this.topPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(10)))), ((int)(((byte)(20)))), ((int)(((byte)(20)))));
            this.topPanel.Controls.Add(this.logoutButton);
            this.topPanel.Controls.Add(this.companyNameLabel);
            this.topPanel.Dock = System.Windows.Forms.DockStyle.Top;
            this.topPanel.Location = new System.Drawing.Point(0, 0);
            this.topPanel.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.topPanel.Name = "topPanel";
            this.topPanel.Size = new System.Drawing.Size(1924, 70);
            this.topPanel.TabIndex = 0;
            // 
            // logoutButton
            // 
            this.logoutButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.logoutButton.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.logoutButton.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.logoutButton.ForeColor = System.Drawing.SystemColors.ActiveBorder;
            this.logoutButton.Location = new System.Drawing.Point(1814, 11);
            this.logoutButton.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.logoutButton.Name = "logoutButton";
            this.logoutButton.Size = new System.Drawing.Size(116, 42);
            this.logoutButton.TabIndex = 1;
            this.logoutButton.Text = "Logout";
            this.logoutButton.UseVisualStyleBackColor = false;
            this.logoutButton.Click += new System.EventHandler(this.logoutButton_Click);
            // 
            // companyNameLabel
            // 
            this.companyNameLabel.AutoSize = true;
            this.companyNameLabel.Font = new System.Drawing.Font("Segoe UI Historic", 25.2F);
            this.companyNameLabel.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.companyNameLabel.Location = new System.Drawing.Point(3, 4);
            this.companyNameLabel.Name = "companyNameLabel";
            this.companyNameLabel.Size = new System.Drawing.Size(211, 59);
            this.companyNameLabel.TabIndex = 0;
            this.companyNameLabel.Text = "Hi Admin,";
            // 
            // leftSidePanel
            // 
            this.leftSidePanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(43)))), ((int)(((byte)(43)))), ((int)(((byte)(43)))));
            this.leftSidePanel.Controls.Add(this.popularCarLabel);
            this.leftSidePanel.Controls.Add(this.popularCarTypeLabel);
            this.leftSidePanel.Controls.Add(this.findVehicleTypeLabel);
            this.leftSidePanel.Controls.Add(this.popularBranchLabel);
            this.leftSidePanel.Controls.Add(this.top100CustomersLabel);
            this.leftSidePanel.Controls.Add(this.findBranchLabel);
            this.leftSidePanel.Controls.Add(this.addNewBranchLabel);
            this.leftSidePanel.Controls.Add(this.top10EmployeeLabel);
            this.leftSidePanel.Controls.Add(this.branchesLabel);
            this.leftSidePanel.Controls.Add(this.findVehicleLabel);
            this.leftSidePanel.Controls.Add(this.addEmployeeLabel);
            this.leftSidePanel.Controls.Add(this.addNewUserLabel);
            this.leftSidePanel.Controls.Add(this.addNewBookingLabel);
            this.leftSidePanel.Controls.Add(this.findBookingLabel);
            this.leftSidePanel.Controls.Add(this.addVehicleTypeLabel);
            this.leftSidePanel.Controls.Add(this.findEmployeeLabel);
            this.leftSidePanel.Controls.Add(this.findUserLabel);
            this.leftSidePanel.Controls.Add(this.addNewVehicleLabel);
            this.leftSidePanel.Controls.Add(this.statsLabel);
            this.leftSidePanel.Controls.Add(this.bookingsLabel);
            this.leftSidePanel.Controls.Add(this.employeeLabel);
            this.leftSidePanel.Controls.Add(this.vehiclesLabel);
            this.leftSidePanel.Controls.Add(this.usersLabel);
            this.leftSidePanel.Dock = System.Windows.Forms.DockStyle.Left;
            this.leftSidePanel.Location = new System.Drawing.Point(0, 70);
            this.leftSidePanel.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.leftSidePanel.Name = "leftSidePanel";
            this.leftSidePanel.Size = new System.Drawing.Size(177, 985);
            this.leftSidePanel.TabIndex = 1;
            this.leftSidePanel.Paint += new System.Windows.Forms.PaintEventHandler(this.leftSidePanel_Paint);
            // 
            // popularCarLabel
            // 
            this.popularCarLabel.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.popularCarLabel.ForeColor = System.Drawing.Color.White;
            this.popularCarLabel.Location = new System.Drawing.Point(1, 627);
            this.popularCarLabel.Name = "popularCarLabel";
            this.popularCarLabel.Size = new System.Drawing.Size(176, 30);
            this.popularCarLabel.TabIndex = 19;
            this.popularCarLabel.Text = "Popular Car";
            this.popularCarLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.popularCarLabel.Click += new System.EventHandler(this.popularCarLabel_Click);
            this.popularCarLabel.MouseLeave += new System.EventHandler(this.popularCarLabel_MouseLeave);
            this.popularCarLabel.MouseHover += new System.EventHandler(this.popularCarLabel_MouseHover);
            // 
            // popularCarTypeLabel
            // 
            this.popularCarTypeLabel.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.popularCarTypeLabel.ForeColor = System.Drawing.Color.White;
            this.popularCarTypeLabel.Location = new System.Drawing.Point(1, 658);
            this.popularCarTypeLabel.Name = "popularCarTypeLabel";
            this.popularCarTypeLabel.Size = new System.Drawing.Size(179, 23);
            this.popularCarTypeLabel.TabIndex = 24;
            this.popularCarTypeLabel.Text = "Popular Car Type";
            this.popularCarTypeLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.popularCarTypeLabel.Click += new System.EventHandler(this.popularCarTypeLabel_Click);
            this.popularCarTypeLabel.MouseLeave += new System.EventHandler(this.popularCarTypeLabel_MouseLeave);
            this.popularCarTypeLabel.MouseHover += new System.EventHandler(this.popularCarTypeLabel_MouseHover);
            // 
            // findVehicleTypeLabel
            // 
            this.findVehicleTypeLabel.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.findVehicleTypeLabel.ForeColor = System.Drawing.Color.White;
            this.findVehicleTypeLabel.Location = new System.Drawing.Point(2, 308);
            this.findVehicleTypeLabel.Name = "findVehicleTypeLabel";
            this.findVehicleTypeLabel.Size = new System.Drawing.Size(171, 30);
            this.findVehicleTypeLabel.TabIndex = 25;
            this.findVehicleTypeLabel.Text = "Find Car Type";
            this.findVehicleTypeLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.findVehicleTypeLabel.Click += new System.EventHandler(this.findVehicleTypeLabel_Click);
            this.findVehicleTypeLabel.MouseLeave += new System.EventHandler(this.findVehicleTypeLabel_MouseLeave);
            this.findVehicleTypeLabel.MouseHover += new System.EventHandler(this.findVehicleTypeLabel_MouseHover);
            // 
            // popularBranchLabel
            // 
            this.popularBranchLabel.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.popularBranchLabel.ForeColor = System.Drawing.Color.White;
            this.popularBranchLabel.Location = new System.Drawing.Point(6, 682);
            this.popularBranchLabel.Name = "popularBranchLabel";
            this.popularBranchLabel.Size = new System.Drawing.Size(171, 30);
            this.popularBranchLabel.TabIndex = 22;
            this.popularBranchLabel.Text = "Popular Branch";
            this.popularBranchLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.popularBranchLabel.Click += new System.EventHandler(this.popularBranchLabel_Click);
            this.popularBranchLabel.MouseLeave += new System.EventHandler(this.popularBranchLabel_MouseLeave);
            this.popularBranchLabel.MouseHover += new System.EventHandler(this.popularBranchLabel_MouseHover);
            // 
            // top100CustomersLabel
            // 
            this.top100CustomersLabel.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.top100CustomersLabel.ForeColor = System.Drawing.Color.White;
            this.top100CustomersLabel.Location = new System.Drawing.Point(2, 741);
            this.top100CustomersLabel.Name = "top100CustomersLabel";
            this.top100CustomersLabel.Size = new System.Drawing.Size(172, 30);
            this.top100CustomersLabel.TabIndex = 23;
            this.top100CustomersLabel.Text = "Top Customers";
            this.top100CustomersLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.top100CustomersLabel.Click += new System.EventHandler(this.top100CustomersLabel_Click);
            this.top100CustomersLabel.MouseLeave += new System.EventHandler(this.top100CustomersLabel_MouseLeave);
            this.top100CustomersLabel.MouseHover += new System.EventHandler(this.top100CustomersLabel_MouseHover);
            // 
            // findBranchLabel
            // 
            this.findBranchLabel.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.findBranchLabel.ForeColor = System.Drawing.Color.White;
            this.findBranchLabel.Location = new System.Drawing.Point(0, 519);
            this.findBranchLabel.Name = "findBranchLabel";
            this.findBranchLabel.Size = new System.Drawing.Size(172, 30);
            this.findBranchLabel.TabIndex = 21;
            this.findBranchLabel.Text = "Find Branch";
            this.findBranchLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.findBranchLabel.Click += new System.EventHandler(this.findBranchLabel_Click);
            this.findBranchLabel.MouseLeave += new System.EventHandler(this.findBranchLabel_MouseLeave);
            this.findBranchLabel.MouseHover += new System.EventHandler(this.findBranchLabel_MouseHover);
            // 
            // addNewBranchLabel
            // 
            this.addNewBranchLabel.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.addNewBranchLabel.ForeColor = System.Drawing.Color.White;
            this.addNewBranchLabel.Location = new System.Drawing.Point(0, 549);
            this.addNewBranchLabel.Name = "addNewBranchLabel";
            this.addNewBranchLabel.Size = new System.Drawing.Size(172, 30);
            this.addNewBranchLabel.TabIndex = 20;
            this.addNewBranchLabel.Text = "Add New Branch";
            this.addNewBranchLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.addNewBranchLabel.Click += new System.EventHandler(this.addNewBranchLabel_Click);
            this.addNewBranchLabel.MouseLeave += new System.EventHandler(this.addBranchLabel_MouseLeave);
            this.addNewBranchLabel.MouseHover += new System.EventHandler(this.addBranchLabel_MouseHover);
            // 
            // top10EmployeeLabel
            // 
            this.top10EmployeeLabel.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.top10EmployeeLabel.ForeColor = System.Drawing.Color.White;
            this.top10EmployeeLabel.Location = new System.Drawing.Point(-1, 712);
            this.top10EmployeeLabel.Name = "top10EmployeeLabel";
            this.top10EmployeeLabel.Size = new System.Drawing.Size(175, 30);
            this.top10EmployeeLabel.TabIndex = 18;
            this.top10EmployeeLabel.Text = "Top Employees";
            this.top10EmployeeLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.top10EmployeeLabel.Click += new System.EventHandler(this.top10EmployeeLabel_Click);
            this.top10EmployeeLabel.MouseLeave += new System.EventHandler(this.top10EmployeeLabel_MouseLeave);
            this.top10EmployeeLabel.MouseHover += new System.EventHandler(this.top10EmployeeLabel_MouseHover);
            // 
            // branchesLabel
            // 
            this.branchesLabel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(63)))), ((int)(((byte)(63)))), ((int)(((byte)(63)))));
            this.branchesLabel.Font = new System.Drawing.Font("Segoe UI", 14F);
            this.branchesLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.branchesLabel.Location = new System.Drawing.Point(2, 480);
            this.branchesLabel.Name = "branchesLabel";
            this.branchesLabel.Size = new System.Drawing.Size(172, 39);
            this.branchesLabel.TabIndex = 17;
            this.branchesLabel.Text = "Branches";
            this.branchesLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // findVehicleLabel
            // 
            this.findVehicleLabel.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.findVehicleLabel.ForeColor = System.Drawing.Color.White;
            this.findVehicleLabel.Location = new System.Drawing.Point(3, 249);
            this.findVehicleLabel.Name = "findVehicleLabel";
            this.findVehicleLabel.Size = new System.Drawing.Size(171, 30);
            this.findVehicleLabel.TabIndex = 9;
            this.findVehicleLabel.Text = "Find Car";
            this.findVehicleLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.findVehicleLabel.Click += new System.EventHandler(this.findVehicleLabel_Click);
            this.findVehicleLabel.MouseLeave += new System.EventHandler(this.findVehicle_MouseLeave);
            this.findVehicleLabel.MouseHover += new System.EventHandler(this.findVehicle_MouseHover);
            // 
            // addEmployeeLabel
            // 
            this.addEmployeeLabel.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.addEmployeeLabel.ForeColor = System.Drawing.Color.White;
            this.addEmployeeLabel.Location = new System.Drawing.Point(-1, 171);
            this.addEmployeeLabel.Name = "addEmployeeLabel";
            this.addEmployeeLabel.Size = new System.Drawing.Size(176, 30);
            this.addEmployeeLabel.TabIndex = 6;
            this.addEmployeeLabel.Text = "Add New Employee";
            this.addEmployeeLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.addEmployeeLabel.Click += new System.EventHandler(this.addNewEmployeeLabel_Click);
            this.addEmployeeLabel.MouseLeave += new System.EventHandler(this.addEmployeeLabel_MouseLeave);
            this.addEmployeeLabel.MouseHover += new System.EventHandler(this.addEmployeeLabel_MouseHover);
            // 
            // addNewUserLabel
            // 
            this.addNewUserLabel.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.addNewUserLabel.ForeColor = System.Drawing.Color.White;
            this.addNewUserLabel.Location = new System.Drawing.Point(-1, 73);
            this.addNewUserLabel.Name = "addNewUserLabel";
            this.addNewUserLabel.Size = new System.Drawing.Size(176, 30);
            this.addNewUserLabel.TabIndex = 5;
            this.addNewUserLabel.Text = "Add New Customer";
            this.addNewUserLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.addNewUserLabel.Click += new System.EventHandler(this.addNewUserLabel_Click);
            this.addNewUserLabel.MouseLeave += new System.EventHandler(this.addUserLabel_MouseLeave);
            this.addNewUserLabel.MouseHover += new System.EventHandler(this.addUserLabel_MouseHover);
            // 
            // addNewBookingLabel
            // 
            this.addNewBookingLabel.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.addNewBookingLabel.ForeColor = System.Drawing.Color.White;
            this.addNewBookingLabel.Location = new System.Drawing.Point(3, 441);
            this.addNewBookingLabel.Name = "addNewBookingLabel";
            this.addNewBookingLabel.Size = new System.Drawing.Size(171, 30);
            this.addNewBookingLabel.TabIndex = 15;
            this.addNewBookingLabel.Text = "Add New Booking";
            this.addNewBookingLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.addNewBookingLabel.Click += new System.EventHandler(this.addNewBookingLabel_Click);
            this.addNewBookingLabel.MouseLeave += new System.EventHandler(this.addBookingLabel_MouseLeave);
            this.addNewBookingLabel.MouseHover += new System.EventHandler(this.addBookingLabel_MouseHover);
            // 
            // findBookingLabel
            // 
            this.findBookingLabel.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.findBookingLabel.ForeColor = System.Drawing.Color.White;
            this.findBookingLabel.Location = new System.Drawing.Point(2, 411);
            this.findBookingLabel.Name = "findBookingLabel";
            this.findBookingLabel.Size = new System.Drawing.Size(171, 30);
            this.findBookingLabel.TabIndex = 14;
            this.findBookingLabel.Text = "Find Booking";
            this.findBookingLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.findBookingLabel.Click += new System.EventHandler(this.findBookingLabel_Click);
            this.findBookingLabel.MouseLeave += new System.EventHandler(this.findBookingLabel_MouseLeave);
            this.findBookingLabel.MouseHover += new System.EventHandler(this.findBookingLabel_MouseHover);
            // 
            // addVehicleTypeLabel
            // 
            this.addVehicleTypeLabel.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.addVehicleTypeLabel.ForeColor = System.Drawing.Color.White;
            this.addVehicleTypeLabel.Location = new System.Drawing.Point(2, 338);
            this.addVehicleTypeLabel.Name = "addVehicleTypeLabel";
            this.addVehicleTypeLabel.Size = new System.Drawing.Size(172, 30);
            this.addVehicleTypeLabel.TabIndex = 13;
            this.addVehicleTypeLabel.Text = "Add Car Type";
            this.addVehicleTypeLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.addVehicleTypeLabel.Click += new System.EventHandler(this.addVehicleTypeLabel_Click);
            this.addVehicleTypeLabel.MouseLeave += new System.EventHandler(this.addVehicleTypeLabel_MouseLeave);
            this.addVehicleTypeLabel.MouseHover += new System.EventHandler(this.addVehicleTypeLabel_MouseHover);
            // 
            // findEmployeeLabel
            // 
            this.findEmployeeLabel.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.findEmployeeLabel.ForeColor = System.Drawing.Color.White;
            this.findEmployeeLabel.Location = new System.Drawing.Point(3, 143);
            this.findEmployeeLabel.Name = "findEmployeeLabel";
            this.findEmployeeLabel.Size = new System.Drawing.Size(175, 30);
            this.findEmployeeLabel.TabIndex = 10;
            this.findEmployeeLabel.Text = "Find Employee";
            this.findEmployeeLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.findEmployeeLabel.Click += new System.EventHandler(this.findEmployeeLabel_Click);
            this.findEmployeeLabel.MouseLeave += new System.EventHandler(this.findEmployeeLabel_MouseLeave);
            this.findEmployeeLabel.MouseHover += new System.EventHandler(this.findEmployeeLabel_MouseHover);
            // 
            // findUserLabel
            // 
            this.findUserLabel.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.findUserLabel.ForeColor = System.Drawing.Color.White;
            this.findUserLabel.Location = new System.Drawing.Point(3, 43);
            this.findUserLabel.Name = "findUserLabel";
            this.findUserLabel.Size = new System.Drawing.Size(171, 30);
            this.findUserLabel.TabIndex = 8;
            this.findUserLabel.Text = "Find Customer";
            this.findUserLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.findUserLabel.Click += new System.EventHandler(this.findUserLabel_Click);
            this.findUserLabel.MouseLeave += new System.EventHandler(this.findUserLabel_MouseLeave);
            this.findUserLabel.MouseHover += new System.EventHandler(this.findUserLabel_MouseHover);
            // 
            // addNewVehicleLabel
            // 
            this.addNewVehicleLabel.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.addNewVehicleLabel.ForeColor = System.Drawing.Color.White;
            this.addNewVehicleLabel.Location = new System.Drawing.Point(2, 279);
            this.addNewVehicleLabel.Name = "addNewVehicleLabel";
            this.addNewVehicleLabel.Size = new System.Drawing.Size(172, 30);
            this.addNewVehicleLabel.TabIndex = 7;
            this.addNewVehicleLabel.Text = "Add New Car";
            this.addNewVehicleLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.addNewVehicleLabel.Click += new System.EventHandler(this.addNewVehicleLabel_Click);
            this.addNewVehicleLabel.MouseLeave += new System.EventHandler(this.addVehicleLabel_MouseLeave);
            this.addNewVehicleLabel.MouseHover += new System.EventHandler(this.addVehicleLabel_MouseHover);
            // 
            // statsLabel
            // 
            this.statsLabel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(63)))), ((int)(((byte)(63)))), ((int)(((byte)(63)))));
            this.statsLabel.Font = new System.Drawing.Font("Segoe UI", 14F);
            this.statsLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.statsLabel.Location = new System.Drawing.Point(2, 588);
            this.statsLabel.Name = "statsLabel";
            this.statsLabel.Size = new System.Drawing.Size(172, 39);
            this.statsLabel.TabIndex = 4;
            this.statsLabel.Text = "Reports";
            this.statsLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // bookingsLabel
            // 
            this.bookingsLabel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(63)))), ((int)(((byte)(63)))), ((int)(((byte)(63)))));
            this.bookingsLabel.Font = new System.Drawing.Font("Segoe UI", 14F);
            this.bookingsLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.bookingsLabel.Location = new System.Drawing.Point(2, 372);
            this.bookingsLabel.Name = "bookingsLabel";
            this.bookingsLabel.Size = new System.Drawing.Size(172, 39);
            this.bookingsLabel.TabIndex = 3;
            this.bookingsLabel.Text = "Bookings";
            this.bookingsLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // employeeLabel
            // 
            this.employeeLabel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(63)))), ((int)(((byte)(63)))), ((int)(((byte)(63)))));
            this.employeeLabel.Font = new System.Drawing.Font("Segoe UI", 14F);
            this.employeeLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.employeeLabel.Location = new System.Drawing.Point(3, 103);
            this.employeeLabel.Name = "employeeLabel";
            this.employeeLabel.Size = new System.Drawing.Size(172, 39);
            this.employeeLabel.TabIndex = 2;
            this.employeeLabel.Text = "Employees";
            this.employeeLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // vehiclesLabel
            // 
            this.vehiclesLabel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(63)))), ((int)(((byte)(63)))), ((int)(((byte)(63)))));
            this.vehiclesLabel.Font = new System.Drawing.Font("Segoe UI", 14F);
            this.vehiclesLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.vehiclesLabel.Location = new System.Drawing.Point(2, 210);
            this.vehiclesLabel.Name = "vehiclesLabel";
            this.vehiclesLabel.Size = new System.Drawing.Size(172, 39);
            this.vehiclesLabel.TabIndex = 1;
            this.vehiclesLabel.Text = "Cars";
            this.vehiclesLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // usersLabel
            // 
            this.usersLabel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(63)))), ((int)(((byte)(63)))), ((int)(((byte)(63)))));
            this.usersLabel.Font = new System.Drawing.Font("Segoe UI", 14F);
            this.usersLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.usersLabel.Location = new System.Drawing.Point(3, 2);
            this.usersLabel.Name = "usersLabel";
            this.usersLabel.Size = new System.Drawing.Size(172, 39);
            this.usersLabel.TabIndex = 0;
            this.usersLabel.Text = "Customers";
            this.usersLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // rightHandSidePanel
            // 
            this.rightHandSidePanel.Location = new System.Drawing.Point(213, 81);
            this.rightHandSidePanel.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.rightHandSidePanel.Name = "rightHandSidePanel";
            this.rightHandSidePanel.Size = new System.Drawing.Size(1717, 1002);
            this.rightHandSidePanel.TabIndex = 2;
            // 
            // AdminPortal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.ClientSize = new System.Drawing.Size(1924, 1055);
            this.Controls.Add(this.rightHandSidePanel);
            this.Controls.Add(this.leftSidePanel);
            this.Controls.Add(this.topPanel);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "AdminPortal";
            this.Text = "Admin Portal";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.topPanel.ResumeLayout(false);
            this.topPanel.PerformLayout();
            this.leftSidePanel.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel topPanel;
        private System.Windows.Forms.Panel leftSidePanel;
        private System.Windows.Forms.Label companyNameLabel;
        private System.Windows.Forms.Label usersLabel;
        private System.Windows.Forms.Label employeeLabel;
        private System.Windows.Forms.Label vehiclesLabel;
        private System.Windows.Forms.Label statsLabel;
        private System.Windows.Forms.Label bookingsLabel;
        private System.Windows.Forms.Label addNewUserLabel;
        private System.Windows.Forms.Label branchesLabel;
        private System.Windows.Forms.Label addNewBookingLabel;
        private System.Windows.Forms.Label findBookingLabel;
        private System.Windows.Forms.Label addVehicleTypeLabel;
        private System.Windows.Forms.Label findEmployeeLabel;
        private System.Windows.Forms.Label findVehicleLabel;
        private System.Windows.Forms.Label findUserLabel;
        private System.Windows.Forms.Label addNewVehicleLabel;
        private System.Windows.Forms.Label addEmployeeLabel;
        private System.Windows.Forms.Label popularCarLabel;
        private System.Windows.Forms.Label top10EmployeeLabel;
        private System.Windows.Forms.Label findBranchLabel;
        private System.Windows.Forms.Label addNewBranchLabel;
        private System.Windows.Forms.Label top100CustomersLabel;
        private System.Windows.Forms.Label popularBranchLabel;
        private System.Windows.Forms.Label popularCarTypeLabel;
        private System.Windows.Forms.Panel rightHandSidePanel;
        private System.Windows.Forms.Button logoutButton;
        private System.Windows.Forms.Label findVehicleTypeLabel;
    }
}