using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Permissions;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Frary_Demo_Sp2024
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }
        public string WidgetConfigFile = "WidgetCFG.txt";
        //property Nowarranty.. ALl setting of the property goes through here
        public double NoWarranty { get; set; }

        public double TwoYearWarranty { get; set; }

        public double FourYearWarranty { get; set; }
        private void Form2_Load(object sender, EventArgs e)
        {

        }

        private void btnSaveReturn_Click(object sender, EventArgs e)
        {
            bool noneValid, TwoValid, FourValid;
            // cant use a property as an out value so put it in a temporary value first
            double temp0, temp2, temp4; 
            noneValid = double.TryParse(txtNone.Text, out temp0);
            TwoValid = double.TryParse(txt2Year.Text, out temp2);
            FourValid = double.TryParse(txt4Year.Text, out temp4);
            if (noneValid && TwoValid && FourValid)
            {
                // the user is entering as a percent, but we are storing as a decimal
                temp0 = temp0 / 100.0;
                temp2 = temp2 / 100.0;
                temp4 = temp4 / 100.0;
                NoWarranty = temp0;
                TwoYearWarranty = temp2;
                FourYearWarranty = temp4;

                // save values to the file
                StreamWriter sw = File.CreateText(WidgetConfigFile);
                // the write must happen in the same order as the read!!!
                sw.WriteLine(NoWarranty.ToString("N"));
                sw.WriteLine(TwoYearWarranty.ToString("N"));
                sw.WriteLine(FourYearWarranty.ToString("N"));
               
                sw.Close();
                this.Hide();

            }

        }
    }
}
