namespace Delegate
{
    partial class Form2
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
            this.btnSenData = new DevExpress.XtraEditors.SimpleButton();
            this.txtBox1 = new DevExpress.XtraEditors.TextEdit();
            ((System.ComponentModel.ISupportInitialize)(this.txtBox1.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // btnSenData
            // 
            this.btnSenData.Location = new System.Drawing.Point(307, 59);
            this.btnSenData.Name = "btnSenData";
            this.btnSenData.Size = new System.Drawing.Size(135, 48);
            this.btnSenData.TabIndex = 3;
            this.btnSenData.Text = "Send Data";
            this.btnSenData.Click += new System.EventHandler(this.btnSenData_Click);
            // 
            // txtBox1
            // 
            this.txtBox1.EditValue = "";
            this.txtBox1.Location = new System.Drawing.Point(103, 73);
            this.txtBox1.Name = "txtBox1";
            this.txtBox1.Size = new System.Drawing.Size(175, 20);
            this.txtBox1.TabIndex = 2;
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(536, 268);
            this.Controls.Add(this.btnSenData);
            this.Controls.Add(this.txtBox1);
            this.Name = "Form2";
            this.Text = "Form2";
            this.Load += new System.EventHandler(this.Form2_Load);
            ((System.ComponentModel.ISupportInitialize)(this.txtBox1.Properties)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraEditors.SimpleButton btnSenData;
        private DevExpress.XtraEditors.TextEdit txtBox1;
    }
}