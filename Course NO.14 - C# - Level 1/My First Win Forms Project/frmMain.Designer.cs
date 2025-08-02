namespace My_First_Win_Forms_Project
{
    partial class frmMain
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
            this.btrnShowMain = new System.Windows.Forms.Button();
            this.btnShowMainDialog = new System.Windows.Forms.Button();
            this.btnShowMassageBox = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btrnShowMain
            // 
            this.btrnShowMain.Location = new System.Drawing.Point(28, 44);
            this.btrnShowMain.Name = "btrnShowMain";
            this.btrnShowMain.Size = new System.Drawing.Size(215, 87);
            this.btrnShowMain.TabIndex = 0;
            this.btrnShowMain.Text = "Show Main";
            this.btrnShowMain.UseVisualStyleBackColor = true;
            this.btrnShowMain.Click += new System.EventHandler(this.button1_Click);
            // 
            // btnShowMainDialog
            // 
            this.btnShowMainDialog.Location = new System.Drawing.Point(28, 301);
            this.btnShowMainDialog.Name = "btnShowMainDialog";
            this.btnShowMainDialog.Size = new System.Drawing.Size(215, 87);
            this.btnShowMainDialog.TabIndex = 1;
            this.btnShowMainDialog.Text = "ShowMainDialog";
            this.btnShowMainDialog.UseVisualStyleBackColor = true;
            this.btnShowMainDialog.Click += new System.EventHandler(this.btnShowMainDialog_Click);
            // 
            // btnShowMassageBox
            // 
            this.btnShowMassageBox.Location = new System.Drawing.Point(28, 163);
            this.btnShowMassageBox.Name = "btnShowMassageBox";
            this.btnShowMassageBox.Size = new System.Drawing.Size(215, 87);
            this.btnShowMassageBox.TabIndex = 2;
            this.btnShowMassageBox.Text = "ShowMassageBoxForm";
            this.btnShowMassageBox.UseVisualStyleBackColor = true;
            this.btnShowMassageBox.Click += new System.EventHandler(this.btnShowMassageBox_Click);
            // 
            // frmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnShowMassageBox);
            this.Controls.Add(this.btnShowMainDialog);
            this.Controls.Add(this.btrnShowMain);
            this.Name = "frmMain";
            this.Text = "Form2";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btrnShowMain;
        private System.Windows.Forms.Button btnShowMainDialog;
        private System.Windows.Forms.Button btnShowMassageBox;
    }
}