using System;
using System.Windows.Forms;

namespace Simple_Event_With_Parameters_Using_Arguments
{
    public partial class Test : UserControl
    {
        public Test()
        {
            InitializeComponent();
        }

        private void Test_Load(object sender, EventArgs e)
        {
            
        }
        public event Action <string> OnEnterNameComplete;

        protected virtual void EnterNameComplete(string Name)
        {
            Action<string> handler = OnEnterNameComplete;
            if (handler != null)
            {
                handler(Name);
            }
           
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string Name = textBox1.Text.Trim();
            if(OnEnterNameComplete != null)
                EnterNameComplete(Name);
        }
    }
}