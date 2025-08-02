namespace Traffic_Project
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }

            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.trafficLight1 = new Traffic_Project.TrafficLight();
            this.SuspendLayout();
            // 
            // trafficLight1
            // 
            this.trafficLight1.GreenTime = 10;
            this.trafficLight1.Location = new System.Drawing.Point(171, 83);
            this.trafficLight1.Name = "trafficLight1";
            this.trafficLight1.OrangeTime = 3;
            this.trafficLight1.RedTime = 10;
            this.trafficLight1.Size = new System.Drawing.Size(150, 244);
            this.trafficLight1.TabIndex = 0;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(798, 442);
            this.Controls.Add(this.trafficLight1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
        }

        private Traffic_Project.TrafficLight trafficLight1;

        #endregion
    }
}