using System.ComponentModel;

namespace Traffic_Project
{
    partial class TrafficLight
    {
        /// <summary> 
        /// Required designer variable.
        /// </summary>
        private IContainer components = null;

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

        #region Component Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.LbTimer = new System.Windows.Forms.Label();
            this.PbTrafficLight = new System.Windows.Forms.PictureBox();
            this.LightTimer = new System.Windows.Forms.Timer(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.PbTrafficLight)).BeginInit();
            this.SuspendLayout();
            // 
            // LbTimer
            // 
            this.LbTimer.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LbTimer.ForeColor = System.Drawing.Color.Red;
            this.LbTimer.Location = new System.Drawing.Point(57, 183);
            this.LbTimer.Name = "LbTimer";
            this.LbTimer.Size = new System.Drawing.Size(29, 23);
            this.LbTimer.TabIndex = 3;
            this.LbTimer.Text = "??";
            this.LbTimer.Click += new System.EventHandler(this.LbTimer_Click);
            // 
            // PbTrafficLight
            // 
            this.PbTrafficLight.Image = global::Traffic_Project.Properties.Resources.Red;
            this.PbTrafficLight.Location = new System.Drawing.Point(21, 5);
            this.PbTrafficLight.Name = "PbTrafficLight";
            this.PbTrafficLight.Size = new System.Drawing.Size(100, 177);
            this.PbTrafficLight.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.PbTrafficLight.TabIndex = 2;
            this.PbTrafficLight.TabStop = false;
            // 
            // LightTimer
            // 
            this.LightTimer.Tick += new System.EventHandler(this.LightTimer_Tick);
            // 
            // TrafficLight
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.LbTimer);
            this.Controls.Add(this.PbTrafficLight);
            this.Name = "TrafficLight";
            this.Size = new System.Drawing.Size(150, 244);
            ((System.ComponentModel.ISupportInitialize)(this.PbTrafficLight)).EndInit();
            this.ResumeLayout(false);
        }

        private System.Windows.Forms.Timer LightTimer;

        private System.Windows.Forms.Label LbTimer;
        private System.Windows.Forms.PictureBox PbTrafficLight;

        #endregion
    }
}