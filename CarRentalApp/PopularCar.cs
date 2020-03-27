﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CarRentalApp
{
    public partial class PopularCar : Form
    {
        public PopularCar()
        {
            InitializeComponent();
        }

        /*
         * Error checks for the number of entries entered by the user. 
         * If the user enters in only one text field, then the function returns true
         * If the user enters nothing, the function returns false.
         * If the user enters in more than one text field the function returns false.
         */
        private bool errorCheckSpecificFields()
        {
            // If all fields are empty
            if (branchTextBox.Text.TrimEnd() == "" && cityTextBox.Text.TrimEnd() == "" &&
                    provinceTextBox.Text.TrimEnd() == "" && countryTextBox.Text.TrimEnd() == "")
            {
                specificSearchErrorLabel.Text = "Error: Please search by one parameter";
                specificSearchErrorLabel.Visible = true;
                return false;
            }
            // Counting the number of empty fields and if there are less than 3 empty fields,
            // the function returns false
            int count = 0;

            if (branchTextBox.Text.TrimEnd() == "") { count++; }
            if (cityTextBox.Text.TrimEnd() == "") { count++; }
            if (provinceTextBox.Text.TrimEnd() == "") { count++; }
            if (countryTextBox.Text.TrimEnd() == "") { count++; }

            if (count < 3)
            {
                specificSearchErrorLabel.Text = "Error: Please search by only one parameter";
                specificSearchErrorLabel.Visible = true;
                return false;
            }
            return true;
        }
        /*
         * When the admin searches for the most popular car for a specific:
         * - Branch
         * - City
         * - Province
         * - Country
         * The search only takes place by one text field. The function reports an error if the user 
         * enters in more than one text field.
         */
        private void searchSpecificButton_Click(object sender, EventArgs e)
        {
            everySearchErrorLabel.Visible = false; // Making the error label for every search invisible

            if (!errorCheckSpecificFields()) { return; } // Error checking for invalid number of input entries

            specificSearchErrorLabel.Visible = false; // Making the error label for specific search invisible

            if (branchTextBox.Text.TrimEnd() != "")
            {
                // query by the branch name
            }
            if (cityTextBox.Text.TrimEnd() != "")
            {
                // query by city name
            }
            if (provinceTextBox.Text.TrimEnd() != "")
            {
                // query by province name
            }
            if (countryTextBox.Text.TrimEnd() != "")
            {
                // query by country name
            }
        }
        /*
         * When a admin searches for the most popular cars for
         * - Each Branch
         * - Each City or 
         * - Each Province or 
         * - Each Country
         */
        private void searchEveryButton_Click(object sender, EventArgs e)
        {
            specificSearchErrorLabel.Visible = false; // Making the error label for specific search invisible

            if (branchRadio.Checked)
            {
                branchRadio.Checked = false; // Uncheck the button after the search
                everySearchErrorLabel.Visible = false;

                //run all branches query
            }
            else if (cityRadio.Checked)
            {
                cityRadio.Checked = false; // Uncheck the button after the search
                everySearchErrorLabel.Visible = false;

                //run all cities query
            }
            else if (provinceRadio.Checked)
            {
                provinceRadio.Checked = false; // Uncheck the button after the search
                everySearchErrorLabel.Visible = false;

                //run all provinces query
            }
            else if (countryRadio.Checked)
            {
                countryRadio.Checked = false;// Uncheck the button after the search
                everySearchErrorLabel.Visible = false;

                //run all countries query
            }
            else
            {
                // You need to select an option
                everySearchErrorLabel.Visible = true;
            }
        }

        private void findMostPopularCarLabel_Click(object sender, EventArgs e)
        {

        }

        private void selectionFilterGroupBox_Enter(object sender, EventArgs e)
        {

        }

        private void countryRadio_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void provinceRadio_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void cityRadio_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void branchRadio_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void specificParamGroupBox_Enter(object sender, EventArgs e)
        {

        }

        private void countryTextBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void provinceTextBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void cityTextBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void branchTextBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void countryLabel_Click(object sender, EventArgs e)
        {

        }

        private void cityLabel_Click(object sender, EventArgs e)
        {

        }

        private void provinceLabel_Click(object sender, EventArgs e)
        {

        }

        private void branchLabel_Click(object sender, EventArgs e)
        {

        }

        private void specificSearchErrorLabel_Click(object sender, EventArgs e)
        {

        }

        private void everySearchErrorLabel_Click(object sender, EventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void topPanel_Paint(object sender, PaintEventArgs e)
        {

        }

        private void resultsDataGridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
