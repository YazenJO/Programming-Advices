using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace My_First_Win_Forms_Project
{
   
    public partial class Form1 : Form
    {
        
    public Form1()
        {
            InitializeComponent();
            this.SetStyle(ControlStyles.OptimizedDoubleBuffer, true);
            this.SetStyle(ControlStyles.AllPaintingInWmPaint, true);
            this.SetStyle(ControlStyles.UserPaint, true);
            this.BackgroundImageLayout = ImageLayout.Center;

        }


        private void textBox3_TextChanged(object sender, EventArgs e)
        {
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
           // textBox3.Text = textBox1.Text;
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            textBox3.Text= textBox1.Text;
        }

        private void Mouse_Enter(object sender, EventArgs e)
        {
           textBox3.Text = textBox1.Text;

        }

        private void button3_Click(object sender, EventArgs e)
        {
            textBox1.Enabled = false;

        }

        private void button4_Click(object sender, EventArgs e)
        {
            textBox1.Enabled = true;
            
        }

        private void buttonEdit1_EditValueChanged(object sender, EventArgs e)
        {

        }

        private void button5_Click(object sender, EventArgs e)
        {
            textBox3.Visible = false;       
        }

        private void button6_Click(object sender, EventArgs e)
        {
            textBox3.Visible = true;
        }

        private void ChangeTitle(object sender, EventArgs e)
        {
            textBox1.Text = "Write The Form Title";
            textBox3.Visible = false;
           

                
            
            
            
        }

        private void button7_Enter(object sender, EventArgs e)
        {
            this.Text = textBox1.Text;
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button8_Click(object sender, EventArgs e)
        {
            label2.Text = textBox1.Text;
        }

        private void ChangeLabel(object sender, EventArgs e)
        {
            

        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
