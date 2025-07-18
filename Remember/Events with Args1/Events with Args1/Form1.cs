using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Events_with_Args1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void calc1_OnCalculateComplete(object sender, Calc.CalculateEventArgs e)
        {
            // Display the result in a message box
            MessageBox.Show($"Calculation complete! The result of {e.Result} is from adding {e.value1} and {e.value2}.");
        }
    }
}