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

        //property Nowarranty.. ALl setting of the property goes through here
        public double NoWarranty {  get; set; } 

        public double TwoYearWarranty { get; set; }

        public double FourYearWarranty { get; set; }
        private void Form2_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

        }
    }
}
