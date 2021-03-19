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
        Double oilLubeCharges, flushCharges, miscCharges, otherCharges, taxCharges, carWashCharges, totalCharges, totalCosts, partsAmount, laborHours, parts;
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
            if (oilChangeCheckBox.Checked)
            {
                totalCosts = +26;
            }
            else
            {

            }
            double x = 0;
            return x;
        }
        private double FlushCharges()
        {
            double x = 0;
            return x;
        }
        private double MiscCharges()
        {
            double x = 0;
            return x;
        }

        private double OtherCharges()
        {
            if (double.TryParse(partsUserInputTextBox.Text, out parts))
            {
                if (parts < 0)
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
            totalCosts = parts + laborHours * 20;
            return totalCosts; 
        }
        private double TaxCharges()
        {
            double x = 0;
            return x;
        }
        private double CarWashCharges()
        {
            double x = 0;
            return x;
        }
        private double TotalCharges()
        {
            return oilLubeCharges + flushCharges + miscCharges + otherCharges + taxCharges + carWashCharges;
        }
        private void DisplayOutput(double output)
        {
          // display output in summary groupbox
          // serviceAndLaborOutputLabel.Text = carWashChanges()
            partsOutputLabel.Text = otherCharges.ToString("c");
            taxOutputLabel.Text = "";
            totalChargesOutputLabel.Text = "";

        }
        private void ClearOilLube()
        {

        }
        private void ClearFlushes()
        {

        }
        private void ClearMisc()
        {

        }
        private void ClearOther()
        {

        }
        private void ClearFees()
        {

        }
        private void ClearCarWash()
        {

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
