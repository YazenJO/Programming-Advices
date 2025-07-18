using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace UserContrls
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnResult_Click(object sender, EventArgs e)
        {
            MessageBox.Show(ctrlCalculater1.Result.ToString());
        }

        private void InitializeComponent()
        {
            this.ctrlCalculater1 = new UserContrls.ctrlCalculater();
            this.btnResult = new Guna.UI2.WinForms.Guna2Button();
            this.SuspendLayout();
            // 
            // ctrlCalculater1
            // 
            this.ctrlCalculater1.Location = new System.Drawing.Point(36, 24);
            this.ctrlCalculater1.Name = "ctrlCalculater1";
            this.ctrlCalculater1.Size = new System.Drawing.Size(1029, 217);
            this.ctrlCalculater1.TabIndex = 0;
            // 
            // btnResult
            // 
            this.btnResult.CheckedState.Parent = this.btnResult;
            this.btnResult.CustomImages.Parent = this.btnResult;
            this.btnResult.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btnResult.ForeColor = System.Drawing.Color.White;
            this.btnResult.HoverState.Parent = this.btnResult;
            this.btnResult.Location = new System.Drawing.Point(845, 302);
            this.btnResult.Name = "btnResult";
            this.btnResult.ShadowDecoration.Parent = this.btnResult;
            this.btnResult.Size = new System.Drawing.Size(180, 51);
            this.btnResult.TabIndex = 1;
            this.btnResult.Text = "Show Result";
            this.btnResult.Click += new System.EventHandler(this.btnResult_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1226, 450);
            this.Controls.Add(this.btnResult);
            this.Controls.Add(this.ctrlCalculater1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}