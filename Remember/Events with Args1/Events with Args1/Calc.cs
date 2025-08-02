using System;
using System.Windows.Forms;

namespace Events_with_Args1
{
    public partial class Calc : UserControl
    {
        public Calc()
        {
            InitializeComponent();
        }
        public class CalculateEventArgs : EventArgs
        {
            public int value1 { get;}
            public int value2 { get; }
            public int Result { get;}
            public CalculateEventArgs(int v1, int v2)
            {
                value1 = v1;
                value2 = v2;
                Result = value1 + value2;
            }
        }

        public event EventHandler<CalculateEventArgs> OnCalculateComplete;
        
        public void RaiseOnCalculateComplete(int v1, int v2)
        {
            CalculateEventArgs args = new CalculateEventArgs(v1, v2);
            OnCalculateComplete?.Invoke(this, args);
        }
    
        private void button1_Click_1(object sender, EventArgs e)
        {
            int n1= int.Parse(v1.Text);
            int n2 = int.Parse(v2.Text);
            int result = n1 + n2;
            lblResult.Text = result.ToString();
            if (OnCalculateComplete != null)
            {
                RaiseOnCalculateComplete(n1,n2);
            }
        }
    }
}