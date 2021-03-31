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
             DisplayOutput();
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
            double charge = 0;
            if (oilChangeCheckBox.Checked)
            {
                regularRadioButton.Enabled = true;
                mixedRadioButton.Enabled = true;
                fullSyntheticRadioButton.Enabled = true;
                charge += 26;
                
                if (mixedRadioButton.Checked) charge += 10;
                
                else if (fullSyntheticRadioButton.Checked) charge += 20;
                
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
            if (lubeJobCheckBox.Checked) charge += 18;
            return charge;
        }
        private double FlushCharges()
        {
            double charges = 0;
            if (radiatorFlushCheckBox.Checked) charges += 30;
            if (transmissionFlushCheckBox.Checked) charges += 80;
            return charges;
        }
        private double MiscCharges()
        {
            double charges = 0;
            if (inspectionCheckBox.Checked) charges += 15;
            if (replaceMufflerCheckBox.Checked) charges += 100;
            if (tireRotationCheckBox.Checked) charges += 20;
            return charges;
        }

        private double OtherCharges()
        {
            double charges = 0;
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
            charges = partCharges + laborHours * 20;
            return charges; 
        }
        private double TaxCharges()
        {
            double charges = partCharges * 0.06;
            return charges;
        }
        private double CarWashCharges()
        {
            double charges = 0;
            if (noneRadioButton.Checked) charges += 0;
            else if (complimentaryRadioButton.Checked) charges += 0;
            else if (fullServiceRadioButton.Checked) charges += 6;
            else if(premiumRadioButton.Checked) charges += 9;
            return charges;
        }
        private double TotalCharges()
        {
            double charges = oilLubeCharges + flushCharges + miscCharges + otherCharges + taxCharges + carWashCharges;
            return charges;
        }
        private void DisplayOutput()
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
