using System.Diagnostics.Eventing.Reader;
using System.Windows.Forms.Design;

namespace Frary_Demo_Sp2024
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        // these are class level variables
        string WarrantyType;
        const string NO_WARRANTY = "None";
        const string TWO_YEAR_WARRANTY = "2-Year";
        const string FOUR_YEAR_WARRANTY = "4-Year";
        double twoYearRate ;
        double fourYearRate;
        double noneRate;
        string WidgetTranasctionsFile = "WidgetLog.txt";
        string WidgetConfigFile = "WidgetCFG.txt";

        private void Form1_Load(object sender, EventArgs e)
        {
            rdoNoWarranty.Checked = true;
            // this is temporary intil we figure out a way to change variables
            // in program
            //  outputConfig();
            bool fileGood = false;
            do
            {
                try
                {
                    StreamReader sr = File.OpenText(WidgetConfigFile);
                    // this stops the loop since we know we have a good file
                    fileGood = true;
                    string temp = "";
                    while (temp == "") {
                        temp = sr.ReadLine();
                    }                    
                    noneRate = double.Parse(temp);
                    temp = "";
                    while (temp == "")
                    {
                        temp = sr.ReadLine();
                    }
                    twoYearRate = double.Parse(temp);
                    temp = "";
                    while (temp == "")
                    {
                        temp = sr.ReadLine();
                    }
                    fourYearRate = double.Parse(temp);
                    sr.Close();
                }
                catch (FileNotFoundException ex)
                {
                    lstOut.Items.Add(ex.Message);
                    OFD.FileName = WidgetConfigFile;
                    OFD.Filter = "Text Files|*.txt|All Files|*.*";
                    OFD.ShowDialog(this);
                    WidgetConfigFile = OFD.FileName;

                }
            } while (!fileGood); 



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
            double WarrantyPct = 0;
            double WarrantyAmt = 0;
            int Quantity = 0;

            double taxRate = .0875;
            //ICA 4
            bool wPriceValid, QuantityValid;
            StreamWriter swLog;
           
            //input 

            WidgetName = txtWidgetName.Text;

            // ica 4
            //WidgetPrice = double.Parse(txtWidgetPrice.Text);
            wPriceValid = double.TryParse(txtWidgetPrice.Text, out WidgetPrice);
            QuantityValid = int.TryParse(txtQuantity.Text, out Quantity);


            //ica5
            // only do regular processing if the value(s) are good
            if (wPriceValid)
            {
                switch (WarrantyType)
                {
                    case NO_WARRANTY:
                        WarrantyPct = noneRate;
                        break;
                    case TWO_YEAR_WARRANTY:
                        WarrantyPct = twoYearRate;
                        break;
                    case FOUR_YEAR_WARRANTY:
                        WarrantyPct = fourYearRate;
                        break;
                    default:
                        lstOut.Items.Add(" Switch default - this shouldn't happen!!!");
                        break;
                }



                switch (Quantity)
                {
                    // advanced topic fyi not required
                    case int n when (n >= 0 && n < 20):
                        // discount = 0;
                        break;
                    // if you want multiple cases to run the same code
                    // don't put break in
                    case 0:
                    //could put code here
                    case 1:
                    case 2:
                    case 3:
                    case 4:
                    case 5:
                        // discount = 0;
                        break;
                }

                //ICA 3 part 2
                //processing
                WarrantyAmt = WidgetPrice * WarrantyPct;
                TaxAmount = (WidgetPrice + WarrantyAmt) * taxRate;
                TotalPrice = WidgetPrice + TaxAmount;

                //output
                lstOut.Items.Add("You bought " + WidgetName);
                lstOut.Items.Add("The price is " + WidgetPrice.ToString("C"));
                lstOut.Items.Add("The warranty type is " + WarrantyType);
                lstOut.Items.Add("The warranty percent is " + WarrantyPct.ToString("P"));
                lstOut.Items.Add("The warranty amount charged is " + WarrantyAmt.ToString("C"));
                lstOut.Items.Add("The tax is " + TaxAmount.ToString("C") + " (" + taxRate.ToString("P") + " )");
                lstOut.Items.Add("Your total is " + TotalPrice.ToString("C"));
                
                DateTime d = DateTime.Now;
                swLog = File.AppendText(WidgetTranasctionsFile);
                swLog.WriteLine("************** Beginning of Transaction on " +
                        d.ToString("G") + "***********");
                swLog.WriteLine("You bought " + WidgetName);
                swLog.WriteLine("The price is " + WidgetPrice.ToString("C"));
                swLog.WriteLine("The warranty type is " + WarrantyType);
                swLog.WriteLine("The warranty percent is " + WarrantyPct.ToString("P"));
                swLog.WriteLine("The waranty amount charged is " + WarrantyAmt.ToString("C"));
                swLog.WriteLine("The tax is " + TaxAmount.ToString("C") + " (" + taxRate.ToString("P") + " )");
                swLog.WriteLine("Your total is " + TotalPrice.ToString("C"));
                swLog.Close();

                // changes the focus to the clear button
                btnClear.Focus();
            }
            else  // Error processing - ica 5
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

        private void rdoNoWarranty_CheckedChanged(object sender, EventArgs e)
        {
            if (rdoNoWarranty.Checked)
            {
                WarrantyType = NO_WARRANTY;
            }

        }

        private void rdo2Year_CheckedChanged(object sender, EventArgs e)
        {
            if (rdo2Year.Checked)
            {
                WarrantyType = TWO_YEAR_WARRANTY;
            }
        }

        private void rdo4Year_CheckedChanged(object sender, EventArgs e)
        {
            if (rdo4Year.Checked)
            {
                WarrantyType = FOUR_YEAR_WARRANTY;
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            DateTime d = DateTime.Now;
            lstOut.Items.Add("D parameter gives: " + d.ToString("D"));
            lstOut.Items.Add("d parameter gives: " + d.ToString("d"));
            lstOut.Items.Add("T parameter gives: " + d.ToString("T"));
            lstOut.Items.Add("t parameter gives: " + d.ToString("t"));
            lstOut.Items.Add("G parameter gives: " + d.ToString("G"));
            lstOut.Items.Add("g parameter gives: " + d.ToString("g"));
            lstOut.Items.Add(btnCalc.ToString());
        }

        void outputConfig()
        {
            StreamWriter sw = File.CreateText(WidgetConfigFile);
            sw.WriteLine(noneRate);
            sw.WriteLine(twoYearRate);
            sw.WriteLine(fourYearRate);
            sw.Close();

        }
    }
}
