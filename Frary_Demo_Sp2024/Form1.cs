using System.Windows.Forms.Design;

namespace Frary_Demo_Sp2024
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void btnClear_Click(object sender, EventArgs e)
        {

            //ica 2 clearing textboxes and list box
            txtWidgetName.Clear();
            txtWidgetPrice.Clear();
            lstOut.Items.Clear();
            //changes the focus to the First textbox
            txtWidgetName.Focus();


        }

        private void btnQuit_Click(object sender, EventArgs e)
        {
            //ica 5
            DialogResult ButtonSelected;
            ButtonSelected = MessageBox.Show("Are you sure you want to exit?", 
                                               "Exiting...",
                                               MessageBoxButtons.YesNo,
                                               MessageBoxIcon.Question);
            if (ButtonSelected == DialogResult.Yes)
            {
                // closing/ending the program
                this.Close();
            }
        }

        private void btnCalc_Click(object sender, EventArgs e)
        {
            //ICA 3 - part 1
            string WidgetName;
            double WidgetPrice;
            double TotalPrice, TaxAmount;

            double taxRate = .0875;
            //ICA 4
            bool wPriceValid;

            //input 

            WidgetName = txtWidgetName.Text;

            // ica 4
            //WidgetPrice = double.Parse(txtWidgetPrice.Text);
            wPriceValid = double.TryParse(txtWidgetPrice.Text, out WidgetPrice);

            //ica5
            // only do regular processing if the value(s) are good
            if (wPriceValid )
            {

                //ICA 3 part 2
                //processing
                TaxAmount = WidgetPrice * taxRate;
                TotalPrice = WidgetPrice + TaxAmount;

                //output
                lstOut.Items.Add("You bought " + WidgetName);
                lstOut.Items.Add("The price was " + WidgetPrice.ToString("C"));
                lstOut.Items.Add("The tax was " + TaxAmount.ToString("C") + " (" + taxRate.ToString("P") + " )");
                lstOut.Items.Add(" Your total is " + TotalPrice.ToString("C"));
                // changes the focus to the clear button
                btnClear.Focus();
            } else  // Error processing - ica 5
            {
                lstOut.Items.Add("The Widget Price entered is not valid");
            }
            // in most cases you should have nothing down here

        }
        //non default event procedure
        private void txtWidgetName_Enter(object sender, EventArgs e)
        {
            txtWidgetName.BackColor = Color.Beige;
        }

        private void txtWidgetName_Leave(object sender, EventArgs e)
        {
            txtWidgetName.BackColor = SystemColors.Window;

        }

        private void txtWidgetPrice_Leave(object sender, EventArgs e)
        {
            txtWidgetPrice.BackColor = SystemColors.Window;
        }

        private void txtWidgetPrice_Enter(object sender, EventArgs e)
        {
            txtWidgetPrice.BackColor = Color.Beige;
        }
    }
}
