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
            // closing/ending the program
            this.Close();
        }

        private void btnCalc_Click(object sender, EventArgs e)
        {
            //ICA 3 - part 1
            string WidgetName;
            double WidgetPrice;
            double TotalPrice, TaxAmount;

            double taxRate = .0875;

            //input 

            WidgetName = txtWidgetName.Text;
            WidgetPrice = double.Parse(txtWidgetPrice.Text);

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
