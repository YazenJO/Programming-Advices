namespace Events_with_Args1
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
            this.calc1 = new Events_with_Args1.Calc();
            this.SuspendLayout();
            // 
            // calc1
            // 
            this.calc1.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.calc1.Location = new System.Drawing.Point(52, 37);
            this.calc1.Name = "calc1";
            this.calc1.Size = new System.Drawing.Size(493, 220);
            this.calc1.TabIndex = 0;
            this.calc1.OnCalculateComplete += new System.EventHandler<Events_with_Args1.Calc.CalculateEventArgs>(this.calc1_OnCalculateComplete);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.calc1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
        }

        private Events_with_Args1.Calc calc1;

        #endregion
    }
}