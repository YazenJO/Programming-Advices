namespace Contacts_Windows_Forms
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
            this.dvgAllContacts = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dvgAllContacts)).BeginInit();
            this.SuspendLayout();
            // 
            // dvgAllContacts
            // 
            this.dvgAllContacts.AllowUserToAddRows = false;
            this.dvgAllContacts.AllowUserToDeleteRows = false;
            this.dvgAllContacts.AllowUserToOrderColumns = true;
            this.dvgAllContacts.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dvgAllContacts.Location = new System.Drawing.Point(12, 45);
            this.dvgAllContacts.Name = "dvgAllContacts";
            this.dvgAllContacts.ReadOnly = true;
            this.dvgAllContacts.Size = new System.Drawing.Size(776, 393);
            this.dvgAllContacts.TabIndex = 0;
            this.dvgAllContacts.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dvgAllContacts_CellContentClick);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.dvgAllContacts);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dvgAllContacts)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dvgAllContacts;
    }
}

