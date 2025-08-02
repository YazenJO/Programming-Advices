namespace Simple_Event_With_Parameters_Using_Arguments
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
            this.calculater1 = new Simple_Event_With_Parameters_Using_Arguments.Calculater();
            this.test1 = new Simple_Event_With_Parameters_Using_Arguments.Test();
            this.SuspendLayout();
            // 
            // calculater1
            // 
            this.calculater1.Location = new System.Drawing.Point(54, 50);
            this.calculater1.Name = "calculater1";
            this.calculater1.Size = new System.Drawing.Size(584, 233);
            this.calculater1.TabIndex = 0;
            this.calculater1.OnCalculationComplete += new System.EventHandler<Simple_Event_With_Parameters_Using_Arguments.Calculater.CalculationCompleteEventArgs>(this.calculater1_OnCalculationComplete);
            // 
            // test1
            // 
            this.test1.BackColor = System.Drawing.SystemColors.Info;
            this.test1.Location = new System.Drawing.Point(54, 300);
            this.test1.Name = "test1";
            this.test1.Size = new System.Drawing.Size(474, 204);
            this.test1.TabIndex = 1;
            this.test1.OnEnterNameComplete += new System.Action<string>(this.test1_OnEnterNameComplete);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 599);
            this.Controls.Add(this.test1);
            this.Controls.Add(this.calculater1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
        }

        private Simple_Event_With_Parameters_Using_Arguments.Test test1;

        #endregion

        private Simple_Event_With_Parameters_Using_Arguments.Calculater calculater1;
    }
}

