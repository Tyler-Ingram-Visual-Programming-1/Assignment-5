using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
namespace Assignment5
{
    public partial class Form1 : Form
    {
        //Made by Tyler Ingram in 2021 - C# Visual Prog 1
        public Form1()
        {
            InitializeComponent();
        }
        Double oilLubeCharges, flushCharges, miscCharges, otherCharges, taxCharges, 
            carWashCharges, totalCharges, laborHours, partCharges;
        
        private void calculateButton_Click(object sender, EventArgs e)
        {
             oilLubeCharges = OilLubeCharges();
             flushCharges = FlushCharges();
             miscCharges = MiscCharges();
             otherCharges = OtherCharges();
             taxCharges = TaxCharges();
             carWashCharges = CarWashCharges();
             totalCharges = TotalCharges();
             DisplayOutput(otherCharges+flushCharges+oilLubeCharges);
        }
        private void clearButton_Click(object sender, EventArgs e)
        {
            ClearOilLube();
            ClearFlushes();
            ClearMisc();
            ClearOther();
            ClearFees();
            ClearCarWash();
        }
        private double OilLubeCharges()
        {
            oilLubeCharges = 0;
            if (oilChangeCheckBox.Checked)
            {
                regularRadioButton.Enabled = true;
                mixedRadioButton.Enabled = true;
                fullSyntheticRadioButton.Enabled = true;
                oilLubeCharges += 26;
                
                if (mixedRadioButton.Checked) oilLubeCharges += 10;
                
                else if (fullSyntheticRadioButton.Checked) oilLubeCharges += 20;
                
            }
            /* Not in the instructions for the assignment, but this lets the user know they need to check the oil change
box if they plan to purchase an oil change. */
            else if ((!oilChangeCheckBox.Checked) 
                     && (regularRadioButton.Checked || mixedRadioButton.Checked || fullSyntheticRadioButton.Checked))
            {
                MessageBox.Show("Please check the oil change check box if you plan to purchase an oil change.");
                oilChangeCheckBox.Focus();
                return 0;
            }
            if (lubeJobCheckBox.Checked) oilLubeCharges += 18;
            return oilLubeCharges;
        }
        private double FlushCharges()
        {
            flushCharges = 0;
            if (radiatorFlushCheckBox.Checked) flushCharges += 30;
            if (transmissionFlushCheckBox.Checked) flushCharges += 80;
            return flushCharges;
        }
        private double MiscCharges()
        {
            miscCharges = 0;
            if (inspectionCheckBox.Checked) miscCharges += 15;
            if (replaceMufflerCheckBox.Checked) miscCharges += 100;
            if (tireRotationCheckBox.Checked) miscCharges += 20;
            return miscCharges;
        }

        private double OtherCharges()
        {
            otherCharges = 0;
            if (double.TryParse(partsUserInputTextBox.Text, out partCharges))
            {
                if (partCharges < 0)
                {
                    MessageBox.Show("Please input a number for cost of parts that is 0 or higher.");
                    laborHoursUserInputTextBox.Focus();
                }
            }
            else
            {
                MessageBox.Show("Invalid input for the cost of parts used. Please input an integer.");
            }
            if (double.TryParse(laborHoursUserInputTextBox.Text, out laborHours))
            {
                if (laborHours < 0)
                {
                    MessageBox.Show("Please input a number for number of labor hours that is 0 or higher.");
                    laborHoursUserInputTextBox.Focus();
                }
            }
            else
            {
                MessageBox.Show("Invalid input for the hours used. Please input an integer.");
            }
            otherCharges = partCharges + laborHours * 20;
            return otherCharges; 
        }
        private double TaxCharges()
        {
            taxCharges = partCharges * 0.06;
            return taxCharges;
        }
        private double CarWashCharges()
        {
            carWashCharges = 0;
            if (noneRadioButton.Checked) carWashCharges += 0;
            else if (complimentaryRadioButton.Checked) carWashCharges += 0;
            else if (fullServiceRadioButton.Checked) carWashCharges += 6;
            else if(premiumRadioButton.Checked) carWashCharges += 9;
            return carWashCharges;
        }
        private double TotalCharges()
        {
            totalCharges = oilLubeCharges + flushCharges + miscCharges + otherCharges + taxCharges + carWashCharges;
            return totalCharges;
        }
        private void DisplayOutput(double output)
        {
          // display output in summary groupbox
            serviceAndLaborOutputLabel.Text = (totalCharges-partCharges-taxCharges).ToString("c");
            partsOutputLabel.Text = partCharges.ToString("c");
            taxOutputLabel.Text = taxCharges.ToString("c");
            totalChargesOutputLabel.Text = totalCharges.ToString("c");

        }
        private void ClearOilLube()
        {
            oilChangeCheckBox.Checked = false;
            regularRadioButton.Checked = false;
            mixedRadioButton.Checked = false;
            fullSyntheticRadioButton.Checked = false;
            lubeJobCheckBox.Checked = false;

        }
        private void ClearFlushes()
        {
            radiatorFlushCheckBox.Checked = false;
            transmissionFlushCheckBox.Checked = false;
        }
        private void ClearMisc()
        {
            inspectionCheckBox.Checked = false;
            replaceMufflerCheckBox.Checked = false;
            tireRotationCheckBox.Checked = false;
        }

        private void ClearOther()
        {
            partsUserInputTextBox.Text = "";
            laborHoursUserInputTextBox.Text = "";

        }
        private void ClearFees()
        {
            serviceAndLaborOutputLabel.Text = "";
            partsOutputLabel.Text = "";
            taxOutputLabel.Text = "";
            totalChargesOutputLabel.Text = "";
        }
        private void ClearCarWash()
        {
            noneRadioButton.Checked = false;
            complimentaryRadioButton.Checked = false;
            fullServiceRadioButton.Checked = false;
            premiumRadioButton.Checked = false;
        }
        private void exitButton_Click(object sender, EventArgs e)
        {
            exitApplication();
        }
        private void exitApplication()
        {
            Application.Exit();
        }

    }
}
