/* Anh-Tu Ngoc Chapter 3 Exercise 6 Payroll GUI */
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PayrollGUI
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void calculateButton_Click(object sender, EventArgs e)
        {
            string Name = (nameTextBox.Text);                                        // Converting Strings to variable data
            string SSN = (ssnTextBox.Text);
            double HourlyPayRate = Convert.ToDouble(hourlypayrateTextBox.Text);
            double HoursWorked = Convert.ToDouble(hoursworkedTextBox.Text);

           
           
            summaryLabek.Text = "Pay summary for: " + Name;                          // Had Some issues with making a label declare a certain text.  
            ssnSummaryLabel.Text = " " + SSN;                                        // I wanted the label to display a text like " Blah Blah Blah [Variable] Blah Blah [Variable] "   
            statementLabel.Text = "You worked for " + HoursWorked;                   // I tried Placeholders {} and labelname.Text = "statement" + [variable] + "statement" but that didnt work either. 
            payrateLabel.Text = " hours at a rate of $" + HourlyPayRate;             // Couldn't find it in the book nor online either I guess it doesn't exist. 
            anHourLabel.Text = "an hour";                                            // This is why I made separate labels for each clauses. 

            double GrossPay = HourlyPayRate * HoursWorked;                           // Algorithms 
            double FederalWithholdings = GrossPay * .15;
            double StateWithholdings = GrossPay * .05;
            double NetPay = GrossPay - FederalWithholdings - StateWithholdings;

            grossPayTextBox.Text = "" + GrossPay.ToString("C");                      // Text Box displays declared variables after algorithms.  
            federalTaxtTextBox.Text = "" + FederalWithholdings.ToString("C");
            stateTaxTextBox.Text = "" + StateWithholdings.ToString("C");
            netPayTextBox.Text = "" + NetPay.ToString("C");

            
        }
    }
}
