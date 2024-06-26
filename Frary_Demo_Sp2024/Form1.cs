using Microsoft.VisualBasic.Logging;
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

        //Create an array of strings for the log file entries
        const int MAX_ENTRIES = 2000;
        string[] LogEntries = new string[MAX_ENTRIES];
        /*
        double twoYearRate;
        double fourYearRate;
        double noneRate;
        */
        string WidgetTranasctionsFile = "WidgetLog.txt";

        Form2 sf;

        

        private void Form1_Load(object sender, EventArgs e)
        {
            rdoNoWarranty.Checked = true;
            // this is temporary intil we figure out a way to change variables
            // in program
            //  outputConfig();
            sf = new Form2();
            // read file ICA 9
            bool fileGood = false;
            do
            {
                try
                {
                    StreamReader sr = File.OpenText(sf.WidgetConfigFile);
                    // this stops the loop since we know we have a good file
                    fileGood = true;
                    string temp = "";
                    while (temp == "")
                    {
                        temp = sr.ReadLine();
                    }
                    // noneRate = double.Parse(temp);
                    sf.NoWarranty = double.Parse(temp);// Changing of variable to property ICA 10
                    temp = "";
                    while (temp == "")
                    {
                        temp = sr.ReadLine();
                    }
                    //   twoYearRate = double.Parse(temp);
                    sf.TwoYearWarranty = double.Parse(temp); // Changing of variable to property ICA 10
                    temp = "";
                    while (temp == "")
                    {
                        temp = sr.ReadLine();
                    }
                    //fourYearRate = double.Parse(temp);
                    sf.FourYearWarranty = double.Parse(temp);// Changing of variable to property ICA 10

                    sr.Close();
                }
                catch (FileNotFoundException ex)
                {
                    lstOut.Items.Add(ex.Message);
                    OFD.FileName = sf.WidgetConfigFile;
                    OFD.Filter = "Text Files|*.txt|All Files|*.*";
                    OFD.ShowDialog(this);
                    sf.WidgetConfigFile = OFD.FileName;// Changing ofconfig file variable to second form variable ICA 11

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
            rdoNoWarranty.Checked = true;
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

                        WarrantyPct = sf.NoWarranty;// Changing of variable to property ICA 10
                        break;
                    case TWO_YEAR_WARRANTY:
                        WarrantyPct = sf.TwoYearWarranty; // Changing of variable to property ICA 10
                        break;
                    case FOUR_YEAR_WARRANTY:
                        WarrantyPct = sf.FourYearWarranty; // Changing of variable to property ICA 10
                        break;
                    default:
                        OutputData(" Switch default - this shouldn't happen!!!", LISTBOX);
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
               
                DateTime d = DateTime.Now;

              OutputData("************** Beginning of Transaction on " +
                        d.ToString("G") + "***********", LOGFILE);


                //output
                OutputData("You bought " + WidgetName, BOTH);
                OutputData("The price is " + WidgetPrice.ToString("C"), BOTH);
                OutputData("The warranty type is " + WarrantyType, BOTH);
                OutputData("The warranty percent is " + WarrantyPct.ToString("P"), BOTH);
                OutputData("The warranty amount charged is " + WarrantyAmt.ToString("C"), BOTH);
                OutputData("The tax is " + TaxAmount.ToString("C") + " (" + taxRate.ToString("P") + " )", BOTH);
                OutputData("Your total is " + TotalPrice.ToString("C"), BOTH) ;

              

                // changes the focus to the clear button
                btnClear.Focus();
            }
            else  // Error processing - ica 5
            {
                OutputData("The Widget Price entered is not valid", LISTBOX);
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
            int i = 0;
            i++;
            lstOut.Items.Add(" i = ");

            DateTime d = DateTime.Now;
            lstOut.Items.Add("D parameter gives: " + d.ToString("D"));
            lstOut.Items.Add("d parameter gives: " + d.ToString("d"));
            lstOut.Items.Add("T parameter gives: " + d.ToString("T"));
            lstOut.Items.Add("t parameter gives: " + d.ToString("t"));
            lstOut.Items.Add("G parameter gives: " + d.ToString("G"));
            lstOut.Items.Add("g parameter gives: " + d.ToString("g"));
            lstOut.Items.Add(btnCalc.ToString());
        }



        private void settingsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //ICA 11
            sf.txtNone.Text = (sf.NoWarranty * 100).ToString("N2");
            sf.txt2Year.Text = (sf.TwoYearWarranty * 100).ToString("N2");
            sf.txt4Year.Text = (sf.FourYearWarranty * 100).ToString("N2");
            // ICA 10
            sf.ShowDialog();
        }

        private void btnLogEntries_Click(object sender, EventArgs e)
        {
            //open widget file to read it
            StreamReader sr = File.OpenText(WidgetTranasctionsFile);
            // declare a variable to keep track of how many entries are reead in
            int numEntries = 0;
            // read the file til you get to the end
            while (!sr.EndOfStream)
            {
                // put the current line into the current log Entry
                LogEntries[numEntries] = sr.ReadLine();
                // updates number of log entries
                numEntries++;
            }
            sr.Close();

            // loop through all the LogEntries
            for (int i = 0; i < numEntries; i++)
            {
                // if the current log entry has the warranty type in the text
                if (LogEntries[i].IndexOf(WarrantyType) != -1)
                {
                    // loop through that tranasction and put each line in the listbox
                    for (int j = i - 3; j <= i + 4; j++)
                    {
                        lstOut.Items.Add(LogEntries[j]);
                    }
                }
            }

        }

        const int NO_OUTPUT = 0;
        const int LOGFILE = 1;
        const int LISTBOX = 2;
        const int BOTH = 3;
        private void OutputData(string msg, int where)
        {
            StreamWriter swLog;
            if (where == LISTBOX || where == BOTH) {
                lstOut.Items.Add(msg);
            }
            if (where == LOGFILE || where == BOTH)
            {
                swLog = File.AppendText(WidgetTranasctionsFile);
                swLog.WriteLine(msg);
                swLog.Close();
            }


        }
    }
}
