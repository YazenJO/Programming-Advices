namespace DVLD___Driving_License_Management
{
    partial class ShowUserDetailsScreen
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
            this.ctrlShowUserDetails1 = new DVLD___Driving_License_Management.ctrlShowUserDetails();
            this.SuspendLayout();
            // 
            // ctrlShowUserDetails1
            // 
            this.ctrlShowUserDetails1.Location = new System.Drawing.Point(12, 12);
            this.ctrlShowUserDetails1.Name = "ctrlShowUserDetails1";
            this.ctrlShowUserDetails1.Size = new System.Drawing.Size(889, 542);
            this.ctrlShowUserDetails1.TabIndex = 0;
            // 
            // ShowUserDetailsScreen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(902, 567);
            this.Controls.Add(this.ctrlShowUserDetails1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "ShowUserDetailsScreen";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ShowUserDetailsScreen";
            this.Load += new System.EventHandler(this.ShowUserDetailsScreen_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private ctrlShowUserDetails ctrlShowUserDetails1;
    }
}