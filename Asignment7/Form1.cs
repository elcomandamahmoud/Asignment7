using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Asignment7
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {            
            for (int num = 0; num<=10; num+=1)
            {
                if (num == 5) 
                {
                    MessageBox.Show("هذا هو رقم5");
                }
                if (num==10)
                {
                    MessageBox.Show("هذا هو رقم 10");
                }
            }
        }
    }
}
