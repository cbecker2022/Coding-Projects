/* Cody Becker
 * April 20th, 2022
 * Program to track orders for MP3 Albums on a website*/
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Nocti_MP3_Website_Sales
{
    public partial class frmMain : Form
    {
        // initialize constant variables
        const double SALES_TAX = 0.06;
        // initialize array variables
        int[] aryQuantities = { 0, 0, 0 };
        double[] aryListPrice = {13.99, 37.99, 41.99};
        double[] aryProfit = {4.00, 11.00, 12.00};
        // initialize integer variables
        int LucyQuantity = 0, BarryQuantity = 0, BustaQuantity = 0, cumlItems = 0;
        // initialize double variables
        double LucyTotal = 0.00, BarryTotal = 0.00, BustaTotal = 0.00, LucyProf = 0.00, BarryProf = 0.00, BustaProf = 0.00, subtotal = 0.00, salesTax = 0.00, shippingFees = 0.00, orderTotal = 0.00, cumlProfit = 0.00;
        // initialize string variables
        string CustomerName = "", Date = "", TempName = "";
        public frmMain()
        {
            InitializeComponent();
        }
        private void frmMain_Load(object sender, EventArgs e)
        {
            // for loop to add numbers to the quantity combobox up to 100
            for (int x = 1; x <= 100; ++x)
            {
                cboQuantity.Items.Add(x);
            }
            // sets defaults of the comboboxes
            cboItem.SelectedIndex = 0;
            cboQuantity.SelectedIndex = 0;
        }
        private void btnExit_Click(object sender, EventArgs e)
        {
            // closes the program
            this.Close();
        }
        private void btnCalc_Click(object sender, EventArgs e)
        {
            // switch case statement to find the quantity of an item the customer orders
            // it will then determine the profit and totals for that specific item
            switch (cboItem.SelectedIndex)
            {
                case 0:
                    LucyQuantity = cboQuantity.SelectedIndex + 1;
                    aryQuantities[0] += LucyQuantity;
                    LucyProf += LucyQuantity * aryProfit[0];
                    LucyTotal += LucyQuantity * aryListPrice[0];
                    break;
                case 1:
                    BarryQuantity = cboQuantity.SelectedIndex + 1;
                    aryQuantities[1] += BarryQuantity;
                    BarryProf += BarryQuantity * aryProfit[1];
                    BarryTotal += BarryQuantity * aryListPrice[1];
                    break;
                case 2:
                    BustaQuantity = cboQuantity.SelectedIndex + 1;
                    aryQuantities[2] += BustaQuantity;
                    BustaProf += BustaQuantity * aryProfit[2];
                    BustaTotal += BustaQuantity * aryListPrice[2];
                    break;
            }
        }
        private void btnClear_Click(object sender, EventArgs e)
        {
            // clears the listbox
            lboxOutput.Items.Clear();
            // sets customer name variables to nothing
            CustomerName = "";
            TempName = "";
            // sets the lucy album information to zero
            LucyProf = 0;
            LucyQuantity = 0;
            LucyTotal = 0;
            // sets the barry album information to zero
            BarryProf = 0;
            BarryQuantity = 0;
            BarryTotal = 0;
            // sets the busta album information to zero
            BustaProf = 0;
            BustaQuantity = 0;
            BustaTotal = 0;
            // sets the calculated information to zero
            subtotal = 0;
            salesTax = 0;
            shippingFees = 0;
            orderTotal = 0;
            // for loop set all array quantities values to zero
            for (int x = 0; x < 3; ++x)
            {
                aryQuantities[x] = 0;
            }
            // sets the customer name textbox back to nothing
            txtName.Text = "";
            // sets the combobox back to the default info
            cboItem.SelectedIndex = 0;
            cboQuantity.SelectedIndex = 0;
        }
        private void btnPrint_Click(object sender, EventArgs e)
        {
            // gets customer name and date assigned to variables
            CustomerName = txtName.Text;
            TempName = CustomerName.ToLower();
            Date = dtpDate.Value.ToString();
            // rounds the totals each album
            LucyTotal = Math.Round(LucyTotal, 2);
            BarryTotal = Math.Round(BarryTotal, 2);
            BustaTotal = Math.Round(BustaTotal, 2);
            // adds item order information to the listbox
            lboxOutput.Items.Add(string.Format("Lucy Nelson's Greatest Hits {0} for {1}", aryQuantities[0], LucyTotal.ToString("C2")));
            lboxOutput.Items.Add(string.Format("Barry Cuda & The Sharks LIVE {0} for {1}", aryQuantities[1], BarryTotal.ToString("C2")));
            lboxOutput.Items.Add(string.Format("Busta Move Boogies {0} for {1}", aryQuantities[2], BustaTotal.ToString("C2")));
            // calculates subtotal and rounds it
            subtotal = LucyTotal + BarryTotal + BustaTotal;
            // calculates sales tax and rounds it
            salesTax = subtotal * SALES_TAX;
            salesTax = Math.Round(salesTax, 2);
            // switch case statement to determine shipping fees based on temporary name
            switch (TempName)
            {
                case "susan smith":
                    shippingFees = 10.00;
                    break;
                case "george jackson":
                    shippingFees = 9.68;
                    break;
            }
            // calculates the order total
            orderTotal = subtotal + salesTax + shippingFees;
            // calculates cumulative information and displays it
            cumlItems += aryQuantities[0] + aryQuantities[1] + aryQuantities[2];
            cumlProfit += LucyProf + BarryProf + BustaProf;
            lblCumlItem.Text = cumlItems.ToString();
            lblCumlProf.Text = cumlProfit.ToString("C2");
            // adds calculated information to the listbox
            lboxOutput.Items.Add(string.Format("Name: {0}", CustomerName));
            lboxOutput.Items.Add(string.Format("Date: {0}", Date));
            lboxOutput.Items.Add(string.Format("Subtotal: {0}", subtotal.ToString("C2")));
            lboxOutput.Items.Add(string.Format("Sales Tax: {0}", salesTax.ToString("C2")));
            lboxOutput.Items.Add(string.Format("Shipping Fees: {0}", shippingFees.ToString("C2")));
            lboxOutput.Items.Add(string.Format("Order Total: {0}", orderTotal.ToString("C2")));
            // message box displaying all information combined
            MessageBox.Show(string.Format("Name: {0}\nDate: {1}\nLucy Nelson's Greatest Hits {2} for {3}\nBarry Cuda & The Sharks LIVE {4} for {5}\nBusta Move Boogies {6} for {7}\nSubtotal: " +
                "{8}\nSales Tax: {9}\nShipping Fees: {10}\nOrder Total: {11}", CustomerName, Date, aryQuantities[0], LucyTotal.ToString("C2"), aryQuantities[1], BarryTotal.ToString("C2"), 
                aryQuantities[2], BustaTotal.ToString("C2"), subtotal.ToString("C2"), salesTax.ToString("C2"), shippingFees.ToString("C2"), orderTotal.ToString("C2")), "Receipt", 
                MessageBoxButtons.OK, MessageBoxIcon.Information);
            printCapture.Print();
            btnClear.PerformClick();
        }
        private void txtName_TextChanged(object sender, EventArgs e)
        {
            // set combobox quantity and item to default index if name changes
            cboItem.SelectedIndex = 0;
            cboQuantity.SelectedIndex = 0;
        }
        private void cboItem_SelectedIndexChanged(object sender, EventArgs e)
        {
            // set combobox quantity to default index if item changes
            cboQuantity.SelectedIndex = 0;
        }
    }
}
