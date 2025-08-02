using System.Windows.Forms;

namespace UserContrls
{
    public partial class ctrlCalculater : UserControl
    {
        public ctrlCalculater()
        {
            InitializeComponent();
        }
        public  float Result
        {
            get { return float.Parse(lblresult.Text); }
        }

        private void guna2Button1_Click(object sender, System.EventArgs e)
        {
            lblresult.Text = (float.Parse(txt1.Text) + float.Parse(txt2.Text)).ToString();


        }

        private void ctrlCalculater_Load(object sender, System.EventArgs e)
        {

        }
    }
}