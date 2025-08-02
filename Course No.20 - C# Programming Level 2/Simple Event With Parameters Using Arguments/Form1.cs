using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Simple_Event_With_Parameters_Using_Arguments
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void calculater1_OnCalculationComplete(object sender, Calculater.CalculationCompleteEventArgs e)
        {
            // Display the result in a message box
            MessageBox.Show($"The result of adding {e.Val1} and {e.Val2} is {e.Result}");
         
        }

        private void test1_OnEnterNameComplete(string obj)
        {
            MessageBox.Show("Your Name Is : "+obj);
        }
    }
}
