using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Project2
{
    /*<summary>
    Lucas Graeff N01384687  
    Project 2
    Due Date: 10/30/18

    The purpose of this project is to create a calculator for loan amortization.
    The user inputs the loan amount, the term in years, and the APR. The program
    uses this input to give back a fixed monthly payment, total payment, and a listing of the principal,
    remaining payment, and amount paid by month.
    </summary>*/

    public partial class LoanAmortization : Form
    {
        public LoanAmortization()
        {
            InitializeComponent();

            lstBox.Items.Add(string.Format("{0,15}{1,21}{2,27}{3,33}", "Month", "Principal", "Int/Pmt", "Prn/Pmt"));
        }//end LoanAmortization

        public double CalcMonthlyPayment(double apr, double principal, double term)
        {
          
            //Evaluate fixed monthly payment
            double monthly = principal * (apr * (Math.Pow(1 + apr, term)) / (Math.Pow(1 + apr, term) - 1));
            return monthly;

        }//end CalcMonthlyPayment

        public void listOutput(double apr, double principal, double term, double fixedMonthly)
        {
            //Initialize variables
            double monthly = principal;
            double amountPaid;
            double remainingPayment;

            //Run loop to generate list
            for (int month = 1; month <= term; month++)
            {
                remainingPayment = monthly * apr;
                amountPaid = fixedMonthly - remainingPayment;
                monthly = monthly - amountPaid;
                lstBox.Items.Add(string.Format("{0,15}{1,21:C2}{2,27:C2}{3,33:C2}", month, monthly, remainingPayment, amountPaid));
            }//end for loop
        }//end listOutput

        public void clearLst()
        {
            lstBox.Items.Clear();
            lstBox.Items.Add(string.Format("{0,15}{1,21}{2,27}{3,33}", "Month", "Principal", "Int/Pmt", "Prn/Pmt"));
        }//end clearLst 

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void Loan_Amortization_Load(object sender, EventArgs e)
        {

        }

        private void btnAmortize_Click(object sender, EventArgs e)
        {
            clearLst();

            //Initialize variables
            bool acceptablePrinc = true;
            bool acceptableTerm = true;
            bool acceptableAPR = true;

            double principal;
            double termTotal;
            double apr;

            //Collect input from textboxes
            string input = txtLoanAmt.Text;
            bool parsePrinc = Double.TryParse(input, out principal);

            input = txtTerm.Text;
            bool parseTerm = Double.TryParse(input, out termTotal);
            double term = termTotal * 12;

            input = txtAPR.Text;
            bool parseAPR = Double.TryParse(input, out apr);

            //Test for valid inputs
            if (principal < 1000 || principal > 100000)
            {
                acceptablePrinc = false;
                MessageBox.Show("Loan amount must be $1000-$100,000.");
                txtLoanAmt.BackColor = Color.LightPink;
            }//end if statement
            else
            {
                acceptablePrinc = true;
                txtLoanAmt.BackColor = Color.White;
            }//end else statement


            if (termTotal > 50 || termTotal < 1)
            {
                acceptableTerm = false;
                MessageBox.Show("Term amount must be from 1-50 years.");
                txtTerm.BackColor = Color.LightPink;
            }//end if statement
            else
            {
                acceptableTerm = true;
                txtTerm.BackColor = Color.White;
            }//end else statement


            if (apr < 1 || apr > 10)
            {
                acceptableAPR = false;
                MessageBox.Show("APR must be a value from 1-10.");
                txtAPR.BackColor = Color.LightPink;
            }//end if statement
            else
            {
                acceptableAPR = true;
                txtAPR.BackColor = Color.White;
            }//end else statement

            apr = (apr / 100) / 12;


            if (acceptablePrinc == true && acceptableTerm == true && acceptableAPR == true)
            {
                //Calculate monthly payment
                double monthly = CalcMonthlyPayment(apr, principal, term);
                double total = monthly * term;

                //Output     
                txtMonthly.Text = String.Format("{0:C2}", monthly);
                txtTotal.Text = String.Format("{0:C2}", total);

                //List
                listOutput(apr, principal, term, monthly);
            }//end if statement


        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            //Clear all input and return the program to how it started
            txtAPR.Clear();
            txtLoanAmt.Clear();
            txtMonthly.Clear();
            txtTerm.Clear();
            txtTotal.Clear();
            txtLoanAmt.BackColor = Color.White;
            txtTerm.BackColor = Color.White;
            txtAPR.BackColor = Color.White;
            clearLst();
        }

        private void maskedTextBox1_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
        {

        }
    }//end class
}//end namespace
