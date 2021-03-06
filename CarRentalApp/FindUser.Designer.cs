﻿namespace CarRentalApp
{
    partial class FindUser
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
            this.findExistingUserLabel = new System.Windows.Forms.Label();
            this.customerInfoDataGridView = new System.Windows.Forms.DataGridView();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.customerIDResultLabel = new System.Windows.Forms.Label();
            this.customerIDSearchButton = new System.Windows.Forms.Button();
            this.customerIDTextbox = new System.Windows.Forms.TextBox();
            this.customerIDLabel = new System.Windows.Forms.Label();
            this.LastNameLabel = new System.Windows.Forms.Label();
            this.firstNameLabel = new System.Windows.Forms.Label();
            this.firstNameTextBox = new System.Windows.Forms.TextBox();
            this.lastNameTextBox = new System.Windows.Forms.TextBox();
            this.nameSearchButton = new System.Windows.Forms.Button();
            this.nameResultLabel = new System.Windows.Forms.Label();
            this.enterUserDetailsGroupBox = new System.Windows.Forms.GroupBox();
            this.phoneNumberLabel = new System.Windows.Forms.Label();
            this.phoneNumSearchButton = new System.Windows.Forms.Button();
            this.phoneNumberTextBox = new System.Windows.Forms.TextBox();
            this.phoneNumResultLabel = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.emailLabel = new System.Windows.Forms.Label();
            this.emailTextBox = new System.Windows.Forms.TextBox();
            this.emailSearchButton = new System.Windows.Forms.Button();
            this.emailResultLabel = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.topPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.customerInfoDataGridView)).BeginInit();
            this.groupBox3.SuspendLayout();
            this.enterUserDetailsGroupBox.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // topPanel
            // 
            this.topPanel.CausesValidation = false;
            this.topPanel.Controls.Add(this.findExistingUserLabel);
            this.topPanel.Dock = System.Windows.Forms.DockStyle.Top;
            this.topPanel.Font = new System.Drawing.Font("Segoe UI Emoji", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.topPanel.ForeColor = System.Drawing.SystemColors.ActiveBorder;
            this.topPanel.Location = new System.Drawing.Point(0, 0);
            this.topPanel.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.topPanel.Name = "topPanel";
            this.topPanel.Size = new System.Drawing.Size(1747, 85);
            this.topPanel.TabIndex = 18;
            // 
            // findExistingUserLabel
            // 
            this.findExistingUserLabel.AutoSize = true;
            this.findExistingUserLabel.Font = new System.Drawing.Font("Segoe UI Emoji", 22.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.findExistingUserLabel.ForeColor = System.Drawing.SystemColors.ActiveBorder;
            this.findExistingUserLabel.Location = new System.Drawing.Point(43, 23);
            this.findExistingUserLabel.Name = "findExistingUserLabel";
            this.findExistingUserLabel.Size = new System.Drawing.Size(367, 51);
            this.findExistingUserLabel.TabIndex = 0;
            this.findExistingUserLabel.Text = "Find an Existing User";
            // 
            // customerInfoDataGridView
            // 
            this.customerInfoDataGridView.AllowUserToAddRows = false;
            this.customerInfoDataGridView.AllowUserToDeleteRows = false;
            this.customerInfoDataGridView.BackgroundColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.customerInfoDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.customerInfoDataGridView.Location = new System.Drawing.Point(511, 122);
            this.customerInfoDataGridView.Margin = new System.Windows.Forms.Padding(4);
            this.customerInfoDataGridView.Name = "customerInfoDataGridView";
            this.customerInfoDataGridView.Size = new System.Drawing.Size(1099, 724);
            this.customerInfoDataGridView.TabIndex = 20;
            this.customerInfoDataGridView.CellValueChanged += new System.Windows.Forms.DataGridViewCellEventHandler(this.customerInfoDataGridView_CellValueChanged);
            this.customerInfoDataGridView.EditingControlShowing += new System.Windows.Forms.DataGridViewEditingControlShowingEventHandler(this.customerInfoDataGridView_EditingControlShowing);
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.customerIDResultLabel);
            this.groupBox3.Controls.Add(this.customerIDSearchButton);
            this.groupBox3.Controls.Add(this.customerIDTextbox);
            this.groupBox3.Controls.Add(this.customerIDLabel);
            this.groupBox3.Font = new System.Drawing.Font("Segoe UI Emoji", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox3.ForeColor = System.Drawing.SystemColors.ActiveBorder;
            this.groupBox3.Location = new System.Drawing.Point(15, 110);
            this.groupBox3.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBox3.Size = new System.Drawing.Size(460, 156);
            this.groupBox3.TabIndex = 27;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Look up by Customer ID";
            // 
            // customerIDResultLabel
            // 
            this.customerIDResultLabel.AutoSize = true;
            this.customerIDResultLabel.Font = new System.Drawing.Font("Segoe UI Emoji", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.customerIDResultLabel.ForeColor = System.Drawing.SystemColors.ActiveBorder;
            this.customerIDResultLabel.Location = new System.Drawing.Point(29, 89);
            this.customerIDResultLabel.Name = "customerIDResultLabel";
            this.customerIDResultLabel.Size = new System.Drawing.Size(0, 22);
            this.customerIDResultLabel.TabIndex = 26;
            this.customerIDResultLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.customerIDResultLabel.Visible = false;
            // 
            // customerIDSearchButton
            // 
            this.customerIDSearchButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.customerIDSearchButton.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.customerIDSearchButton.Font = new System.Drawing.Font("Segoe UI Emoji", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.customerIDSearchButton.ForeColor = System.Drawing.SystemColors.ActiveBorder;
            this.customerIDSearchButton.Location = new System.Drawing.Point(272, 97);
            this.customerIDSearchButton.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.customerIDSearchButton.Name = "customerIDSearchButton";
            this.customerIDSearchButton.Size = new System.Drawing.Size(87, 37);
            this.customerIDSearchButton.TabIndex = 25;
            this.customerIDSearchButton.Text = "Search";
            this.customerIDSearchButton.UseVisualStyleBackColor = false;
            this.customerIDSearchButton.Click += new System.EventHandler(this.customerIDSearchButton_Click);
            // 
            // customerIDTextbox
            // 
            this.customerIDTextbox.Font = new System.Drawing.Font("Segoe UI Emoji", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.customerIDTextbox.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.customerIDTextbox.Location = new System.Drawing.Point(183, 46);
            this.customerIDTextbox.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.customerIDTextbox.Name = "customerIDTextbox";
            this.customerIDTextbox.Size = new System.Drawing.Size(255, 30);
            this.customerIDTextbox.TabIndex = 24;
            this.customerIDTextbox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.numericTextBox_KeyPress);
            // 
            // customerIDLabel
            // 
            this.customerIDLabel.AutoSize = true;
            this.customerIDLabel.Font = new System.Drawing.Font("Segoe UI Emoji", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.customerIDLabel.ForeColor = System.Drawing.SystemColors.ActiveBorder;
            this.customerIDLabel.Location = new System.Drawing.Point(23, 46);
            this.customerIDLabel.Name = "customerIDLabel";
            this.customerIDLabel.Size = new System.Drawing.Size(106, 22);
            this.customerIDLabel.TabIndex = 23;
            this.customerIDLabel.Text = "Customer ID";
            // 
            // LastNameLabel
            // 
            this.LastNameLabel.AutoSize = true;
            this.LastNameLabel.Font = new System.Drawing.Font("Segoe UI Emoji", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LastNameLabel.ForeColor = System.Drawing.SystemColors.ActiveBorder;
            this.LastNameLabel.Location = new System.Drawing.Point(19, 94);
            this.LastNameLabel.Name = "LastNameLabel";
            this.LastNameLabel.Size = new System.Drawing.Size(91, 22);
            this.LastNameLabel.TabIndex = 1;
            this.LastNameLabel.Text = "Last Name";
            // 
            // firstNameLabel
            // 
            this.firstNameLabel.AutoSize = true;
            this.firstNameLabel.Font = new System.Drawing.Font("Segoe UI Emoji", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.firstNameLabel.ForeColor = System.Drawing.SystemColors.ActiveBorder;
            this.firstNameLabel.Location = new System.Drawing.Point(19, 47);
            this.firstNameLabel.Name = "firstNameLabel";
            this.firstNameLabel.Size = new System.Drawing.Size(92, 22);
            this.firstNameLabel.TabIndex = 2;
            this.firstNameLabel.Text = "First Name";
            // 
            // firstNameTextBox
            // 
            this.firstNameTextBox.Font = new System.Drawing.Font("Segoe UI Emoji", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.firstNameTextBox.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.firstNameTextBox.Location = new System.Drawing.Point(179, 47);
            this.firstNameTextBox.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.firstNameTextBox.Name = "firstNameTextBox";
            this.firstNameTextBox.Size = new System.Drawing.Size(255, 30);
            this.firstNameTextBox.TabIndex = 5;
            // 
            // lastNameTextBox
            // 
            this.lastNameTextBox.Font = new System.Drawing.Font("Segoe UI Emoji", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lastNameTextBox.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.lastNameTextBox.Location = new System.Drawing.Point(179, 94);
            this.lastNameTextBox.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.lastNameTextBox.Name = "lastNameTextBox";
            this.lastNameTextBox.Size = new System.Drawing.Size(255, 30);
            this.lastNameTextBox.TabIndex = 6;
            // 
            // nameSearchButton
            // 
            this.nameSearchButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.nameSearchButton.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.nameSearchButton.Font = new System.Drawing.Font("Segoe UI Emoji", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nameSearchButton.ForeColor = System.Drawing.SystemColors.ActiveBorder;
            this.nameSearchButton.Location = new System.Drawing.Point(268, 149);
            this.nameSearchButton.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.nameSearchButton.Name = "nameSearchButton";
            this.nameSearchButton.Size = new System.Drawing.Size(87, 37);
            this.nameSearchButton.TabIndex = 9;
            this.nameSearchButton.Text = "Search";
            this.nameSearchButton.UseVisualStyleBackColor = false;
            this.nameSearchButton.Click += new System.EventHandler(this.NameSearchButton_Click);
            // 
            // nameResultLabel
            // 
            this.nameResultLabel.AutoSize = true;
            this.nameResultLabel.Font = new System.Drawing.Font("Segoe UI Emoji", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nameResultLabel.ForeColor = System.Drawing.SystemColors.ActiveBorder;
            this.nameResultLabel.Location = new System.Drawing.Point(25, 140);
            this.nameResultLabel.Name = "nameResultLabel";
            this.nameResultLabel.Size = new System.Drawing.Size(0, 22);
            this.nameResultLabel.TabIndex = 18;
            this.nameResultLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.nameResultLabel.Visible = false;
            // 
            // enterUserDetailsGroupBox
            // 
            this.enterUserDetailsGroupBox.Controls.Add(this.nameResultLabel);
            this.enterUserDetailsGroupBox.Controls.Add(this.nameSearchButton);
            this.enterUserDetailsGroupBox.Controls.Add(this.lastNameTextBox);
            this.enterUserDetailsGroupBox.Controls.Add(this.firstNameTextBox);
            this.enterUserDetailsGroupBox.Controls.Add(this.firstNameLabel);
            this.enterUserDetailsGroupBox.Controls.Add(this.LastNameLabel);
            this.enterUserDetailsGroupBox.Font = new System.Drawing.Font("Segoe UI Emoji", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.enterUserDetailsGroupBox.ForeColor = System.Drawing.SystemColors.ActiveBorder;
            this.enterUserDetailsGroupBox.Location = new System.Drawing.Point(15, 278);
            this.enterUserDetailsGroupBox.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.enterUserDetailsGroupBox.Name = "enterUserDetailsGroupBox";
            this.enterUserDetailsGroupBox.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.enterUserDetailsGroupBox.Size = new System.Drawing.Size(456, 207);
            this.enterUserDetailsGroupBox.TabIndex = 19;
            this.enterUserDetailsGroupBox.TabStop = false;
            this.enterUserDetailsGroupBox.Text = "Look up by Name";
            // 
            // phoneNumberLabel
            // 
            this.phoneNumberLabel.AutoSize = true;
            this.phoneNumberLabel.Font = new System.Drawing.Font("Segoe UI Emoji", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.phoneNumberLabel.ForeColor = System.Drawing.SystemColors.ActiveBorder;
            this.phoneNumberLabel.Location = new System.Drawing.Point(17, 47);
            this.phoneNumberLabel.Name = "phoneNumberLabel";
            this.phoneNumberLabel.Size = new System.Drawing.Size(127, 22);
            this.phoneNumberLabel.TabIndex = 3;
            this.phoneNumberLabel.Text = "Phone Number";
            // 
            // phoneNumSearchButton
            // 
            this.phoneNumSearchButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.phoneNumSearchButton.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.phoneNumSearchButton.Font = new System.Drawing.Font("Segoe UI Emoji", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.phoneNumSearchButton.ForeColor = System.Drawing.SystemColors.ActiveBorder;
            this.phoneNumSearchButton.Location = new System.Drawing.Point(267, 98);
            this.phoneNumSearchButton.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.phoneNumSearchButton.Name = "phoneNumSearchButton";
            this.phoneNumSearchButton.Size = new System.Drawing.Size(87, 37);
            this.phoneNumSearchButton.TabIndex = 19;
            this.phoneNumSearchButton.Text = "Search";
            this.phoneNumSearchButton.UseVisualStyleBackColor = false;
            this.phoneNumSearchButton.Click += new System.EventHandler(this.phoneNumSearchButton_Click);
            // 
            // phoneNumberTextBox
            // 
            this.phoneNumberTextBox.Font = new System.Drawing.Font("Segoe UI Emoji", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.phoneNumberTextBox.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.phoneNumberTextBox.Location = new System.Drawing.Point(177, 47);
            this.phoneNumberTextBox.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.phoneNumberTextBox.Name = "phoneNumberTextBox";
            this.phoneNumberTextBox.Size = new System.Drawing.Size(255, 30);
            this.phoneNumberTextBox.TabIndex = 7;
            this.phoneNumberTextBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.numericTextBox_KeyPress);
            // 
            // phoneNumResultLabel
            // 
            this.phoneNumResultLabel.AutoSize = true;
            this.phoneNumResultLabel.Font = new System.Drawing.Font("Segoe UI Emoji", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.phoneNumResultLabel.ForeColor = System.Drawing.SystemColors.ActiveBorder;
            this.phoneNumResultLabel.Location = new System.Drawing.Point(24, 90);
            this.phoneNumResultLabel.Name = "phoneNumResultLabel";
            this.phoneNumResultLabel.Size = new System.Drawing.Size(0, 22);
            this.phoneNumResultLabel.TabIndex = 20;
            this.phoneNumResultLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.phoneNumResultLabel.Visible = false;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI Emoji", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.ActiveBorder;
            this.label2.Location = new System.Drawing.Point(25, 254);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(0, 22);
            this.label2.TabIndex = 20;
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.phoneNumResultLabel);
            this.groupBox1.Controls.Add(this.phoneNumberTextBox);
            this.groupBox1.Controls.Add(this.phoneNumSearchButton);
            this.groupBox1.Controls.Add(this.phoneNumberLabel);
            this.groupBox1.Font = new System.Drawing.Font("Segoe UI Emoji", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.ForeColor = System.Drawing.SystemColors.ActiveBorder;
            this.groupBox1.Location = new System.Drawing.Point(15, 683);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBox1.Size = new System.Drawing.Size(460, 164);
            this.groupBox1.TabIndex = 23;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Look up by Phone Number";
            // 
            // emailLabel
            // 
            this.emailLabel.AutoSize = true;
            this.emailLabel.Font = new System.Drawing.Font("Segoe UI Emoji", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.emailLabel.ForeColor = System.Drawing.SystemColors.ActiveBorder;
            this.emailLabel.Location = new System.Drawing.Point(23, 46);
            this.emailLabel.Name = "emailLabel";
            this.emailLabel.Size = new System.Drawing.Size(51, 22);
            this.emailLabel.TabIndex = 23;
            this.emailLabel.Text = "Email";
            // 
            // emailTextBox
            // 
            this.emailTextBox.Font = new System.Drawing.Font("Segoe UI Emoji", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.emailTextBox.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.emailTextBox.Location = new System.Drawing.Point(183, 46);
            this.emailTextBox.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.emailTextBox.Name = "emailTextBox";
            this.emailTextBox.Size = new System.Drawing.Size(255, 30);
            this.emailTextBox.TabIndex = 24;
            // 
            // emailSearchButton
            // 
            this.emailSearchButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.emailSearchButton.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.emailSearchButton.Font = new System.Drawing.Font("Segoe UI Emoji", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.emailSearchButton.ForeColor = System.Drawing.SystemColors.ActiveBorder;
            this.emailSearchButton.Location = new System.Drawing.Point(272, 97);
            this.emailSearchButton.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.emailSearchButton.Name = "emailSearchButton";
            this.emailSearchButton.Size = new System.Drawing.Size(87, 37);
            this.emailSearchButton.TabIndex = 25;
            this.emailSearchButton.Text = "Search";
            this.emailSearchButton.UseVisualStyleBackColor = false;
            this.emailSearchButton.Click += new System.EventHandler(this.emailSearchButton_Click);
            // 
            // emailResultLabel
            // 
            this.emailResultLabel.AutoSize = true;
            this.emailResultLabel.Font = new System.Drawing.Font("Segoe UI Emoji", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.emailResultLabel.ForeColor = System.Drawing.SystemColors.ActiveBorder;
            this.emailResultLabel.Location = new System.Drawing.Point(29, 89);
            this.emailResultLabel.Name = "emailResultLabel";
            this.emailResultLabel.Size = new System.Drawing.Size(0, 22);
            this.emailResultLabel.TabIndex = 26;
            this.emailResultLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.emailResultLabel.Visible = false;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.emailResultLabel);
            this.groupBox2.Controls.Add(this.emailSearchButton);
            this.groupBox2.Controls.Add(this.emailTextBox);
            this.groupBox2.Controls.Add(this.emailLabel);
            this.groupBox2.Font = new System.Drawing.Font("Segoe UI Emoji", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox2.ForeColor = System.Drawing.SystemColors.ActiveBorder;
            this.groupBox2.Location = new System.Drawing.Point(15, 505);
            this.groupBox2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBox2.Size = new System.Drawing.Size(460, 156);
            this.groupBox2.TabIndex = 23;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Look up by Email";
            // 
            // FindUser
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.ClientSize = new System.Drawing.Size(1747, 865);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.customerInfoDataGridView);
            this.Controls.Add(this.topPanel);
            this.Controls.Add(this.enterUserDetailsGroupBox);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "FindUser";
            this.Text = "FindUser";
            this.topPanel.ResumeLayout(false);
            this.topPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.customerInfoDataGridView)).EndInit();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.enterUserDetailsGroupBox.ResumeLayout(false);
            this.enterUserDetailsGroupBox.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel topPanel;
        private System.Windows.Forms.Label findExistingUserLabel;
        private System.Windows.Forms.DataGridView customerInfoDataGridView;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Label customerIDResultLabel;
        private System.Windows.Forms.Button customerIDSearchButton;
        private System.Windows.Forms.TextBox customerIDTextbox;
        private System.Windows.Forms.Label customerIDLabel;
        private System.Windows.Forms.Label LastNameLabel;
        private System.Windows.Forms.Label firstNameLabel;
        private System.Windows.Forms.TextBox firstNameTextBox;
        private System.Windows.Forms.TextBox lastNameTextBox;
        private System.Windows.Forms.Button nameSearchButton;
        private System.Windows.Forms.Label nameResultLabel;
        private System.Windows.Forms.GroupBox enterUserDetailsGroupBox;
        private System.Windows.Forms.Label phoneNumberLabel;
        private System.Windows.Forms.Button phoneNumSearchButton;
        private System.Windows.Forms.TextBox phoneNumberTextBox;
        private System.Windows.Forms.Label phoneNumResultLabel;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label emailLabel;
        private System.Windows.Forms.TextBox emailTextBox;
        private System.Windows.Forms.Button emailSearchButton;
        private System.Windows.Forms.Label emailResultLabel;
        private System.Windows.Forms.GroupBox groupBox2;
    }
}