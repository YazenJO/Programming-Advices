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
    
    public partial class Calculater : UserControl
    {
        public class CalculationCompleteEventArgs : EventArgs
        {
            public int Val1 { get; }
            public int Val2 { get; }
            public int Result { get; }

            public CalculationCompleteEventArgs(int val1, int val2, int result)
            {
                Val1 = val1;
                Val2 = val2;
                Result = result;
            }
        }
        public event EventHandler<CalculationCompleteEventArgs> OnCalculationComplete;

        public void RaiseOnCalulationComplete(int Results, int Val1, int Val2)
        {
            RaiseOnCalulationComplete(new CalculationCompleteEventArgs( Val1, Val2,Results));

        }
        protected void RaiseOnCalulationComplete(CalculationCompleteEventArgs e)
        {
            OnCalculationComplete?.Invoke(this,e);
            
        }
        
        public Calculater()
        {
            InitializeComponent();
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void btnCalc_Click(object sender, EventArgs e)
        {
            int val1;
            int val2;
            val1=int.Parse(txtFirstNum.Text);
            val2=int.Parse(txtSecondNum.Text);
            int result = val1 + val2;
            lblAwnser.Text = result.ToString();

            if (OnCalculationComplete != null)
            RaiseOnCalulationComplete(result, val1, val2);
            

        }
    }
}
