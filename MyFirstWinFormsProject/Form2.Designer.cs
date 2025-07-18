namespace MyFirstWinFormsProject
{
    partial class frmColorDialog
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmColorDialog));
            this.colorDialog1 = new System.Windows.Forms.ColorDialog();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.btntextbarcolor = new DevExpress.XtraEditors.SimpleButton();
            this.btnformcolor = new DevExpress.XtraEditors.SimpleButton();
            this.SuspendLayout();
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(84, 46);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(164, 20);
            this.textBox1.TabIndex = 0;
            // 
            // btntextbarcolor
            // 
            this.btntextbarcolor.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("simpleButton1.ImageOptions.Image")));
            this.btntextbarcolor.Location = new System.Drawing.Point(41, 113);
            this.btntextbarcolor.Name = "btntextbarcolor";
            this.btntextbarcolor.PaintStyle = DevExpress.XtraEditors.Controls.PaintStyles.Light;
            this.btntextbarcolor.Size = new System.Drawing.Size(138, 56);
            this.btntextbarcolor.TabIndex = 1;
            this.btntextbarcolor.Text = "TextBox Color";
            this.btntextbarcolor.Click += new System.EventHandler(this.btntextbarcolor_Click);
            // 
            // btnformcolor
            // 
            this.btnformcolor.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("simpleButton2.ImageOptions.Image")));
            this.btnformcolor.Location = new System.Drawing.Point(209, 113);
            this.btnformcolor.Name = "btnformcolor";
            this.btnformcolor.PaintStyle = DevExpress.XtraEditors.Controls.PaintStyles.Light;
            this.btnformcolor.Size = new System.Drawing.Size(138, 56);
            this.btnformcolor.TabIndex = 2;
            this.btnformcolor.Text = "Text color";
            this.btnformcolor.Click += new System.EventHandler(this.btnformcolor_Click);
            // 
            // frmColorDialog
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnformcolor);
            this.Controls.Add(this.btntextbarcolor);
            this.Controls.Add(this.textBox1);
            this.Name = "frmColorDialog";
            this.Text = "ColorDialog";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.ColorDialog colorDialog1;
        private System.Windows.Forms.TextBox textBox1;
        private DevExpress.XtraEditors.SimpleButton btntextbarcolor;
        private DevExpress.XtraEditors.SimpleButton btnformcolor;
    }
}