namespace My_First_Win_Forms_Project
{
    partial class frmMassageBox
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
            this.btrnShowMassageBox = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.chBEnablebtn = new System.Windows.Forms.CheckBox();
            this.radioButton1 = new System.Windows.Forms.RadioButton();
            this.radioButton2 = new System.Windows.Forms.RadioButton();
            this.radioButton3 = new System.Windows.Forms.RadioButton();
            this.grbPizzaSize = new System.Windows.Forms.GroupBox();
            this.btnListMange = new System.Windows.Forms.Button();
            this.grbPizzaSize.SuspendLayout();
            this.SuspendLayout();
            // 
            // btrnShowMassageBox
            // 
            this.btrnShowMassageBox.Location = new System.Drawing.Point(34, 43);
            this.btrnShowMassageBox.Name = "btrnShowMassageBox";
            this.btrnShowMassageBox.Size = new System.Drawing.Size(215, 87);
            this.btrnShowMassageBox.TabIndex = 1;
            this.btrnShowMassageBox.Text = "ShowMassageBox";
            this.btrnShowMassageBox.UseVisualStyleBackColor = true;
            this.btrnShowMassageBox.Click += new System.EventHandler(this.btrnShowMassageBox_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(129, 244);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(230, 102);
            this.button1.TabIndex = 2;
            this.button1.Text = "button1";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // chBEnablebtn
            // 
            this.chBEnablebtn.AutoSize = true;
            this.chBEnablebtn.Location = new System.Drawing.Point(115, 181);
            this.chBEnablebtn.Name = "chBEnablebtn";
            this.chBEnablebtn.Size = new System.Drawing.Size(78, 17);
            this.chBEnablebtn.TabIndex = 3;
            this.chBEnablebtn.Text = "Enable Btn";
            this.chBEnablebtn.UseVisualStyleBackColor = true;
            this.chBEnablebtn.CheckedChanged += new System.EventHandler(this.chBEnablebtn_CheckedChanged);
            // 
            // radioButton1
            // 
            this.radioButton1.AutoSize = true;
            this.radioButton1.Location = new System.Drawing.Point(6, 19);
            this.radioButton1.Name = "radioButton1";
            this.radioButton1.Size = new System.Drawing.Size(50, 17);
            this.radioButton1.TabIndex = 4;
            this.radioButton1.TabStop = true;
            this.radioButton1.Text = "Small";
            this.radioButton1.UseVisualStyleBackColor = true;
            // 
            // radioButton2
            // 
            this.radioButton2.AutoSize = true;
            this.radioButton2.Location = new System.Drawing.Point(6, 48);
            this.radioButton2.Name = "radioButton2";
            this.radioButton2.Size = new System.Drawing.Size(45, 17);
            this.radioButton2.TabIndex = 5;
            this.radioButton2.TabStop = true;
            this.radioButton2.Text = "med";
            this.radioButton2.UseVisualStyleBackColor = true;
            // 
            // radioButton3
            // 
            this.radioButton3.AutoSize = true;
            this.radioButton3.Location = new System.Drawing.Point(6, 77);
            this.radioButton3.Name = "radioButton3";
            this.radioButton3.Size = new System.Drawing.Size(52, 17);
            this.radioButton3.TabIndex = 6;
            this.radioButton3.TabStop = true;
            this.radioButton3.Text = "Large";
            this.radioButton3.UseVisualStyleBackColor = true;
            // 
            // grbPizzaSize
            // 
            this.grbPizzaSize.Controls.Add(this.radioButton3);
            this.grbPizzaSize.Controls.Add(this.radioButton2);
            this.grbPizzaSize.Controls.Add(this.radioButton1);
            this.grbPizzaSize.Location = new System.Drawing.Point(409, 67);
            this.grbPizzaSize.Name = "grbPizzaSize";
            this.grbPizzaSize.Size = new System.Drawing.Size(200, 100);
            this.grbPizzaSize.TabIndex = 7;
            this.grbPizzaSize.TabStop = false;
            this.grbPizzaSize.Text = "PizzaSize";
            this.grbPizzaSize.Enter += new System.EventHandler(this.groupBox1_Enter_1);
            // 
            // btnListMange
            // 
            this.btnListMange.Location = new System.Drawing.Point(409, 244);
            this.btnListMange.Name = "btnListMange";
            this.btnListMange.Size = new System.Drawing.Size(178, 64);
            this.btnListMange.TabIndex = 8;
            this.btnListMange.Text = "ListManage";
            this.btnListMange.UseVisualStyleBackColor = true;
            this.btnListMange.Click += new System.EventHandler(this.button2_Click);
            // 
            // frmMassageBox
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnListMange);
            this.Controls.Add(this.grbPizzaSize);
            this.Controls.Add(this.chBEnablebtn);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.btrnShowMassageBox);
            this.Name = "frmMassageBox";
            this.Text = "Form2";
            this.grbPizzaSize.ResumeLayout(false);
            this.grbPizzaSize.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btrnShowMassageBox;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.CheckBox chBEnablebtn;
        private System.Windows.Forms.RadioButton radioButton1;
        private System.Windows.Forms.RadioButton radioButton2;
        private System.Windows.Forms.RadioButton radioButton3;
        private System.Windows.Forms.GroupBox grbPizzaSize;
        private System.Windows.Forms.Button btnListMange;
    }
}