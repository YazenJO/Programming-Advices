namespace Pizza_Project
{
    partial class frmPizzaMenu
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
            this.grpSize = new System.Windows.Forms.GroupBox();
            this.rdLarge = new System.Windows.Forms.RadioButton();
            this.rdMeduim = new System.Windows.Forms.RadioButton();
            this.rdSmall = new System.Windows.Forms.RadioButton();
            this.grpCrust = new System.Windows.Forms.GroupBox();
            this.rdThick = new System.Windows.Forms.RadioButton();
            this.rdThin = new System.Windows.Forms.RadioButton();
            this.grpToppings = new System.Windows.Forms.GroupBox();
            this.chkOlives = new System.Windows.Forms.CheckBox();
            this.chkOnion = new System.Windows.Forms.CheckBox();
            this.chkGreen = new System.Windows.Forms.CheckBox();
            this.chkTomatoes = new System.Windows.Forms.CheckBox();
            this.chkMuchrooms = new System.Windows.Forms.CheckBox();
            this.chkExtraChees = new System.Windows.Forms.CheckBox();
            this.rdEatIn = new System.Windows.Forms.RadioButton();
            this.grpWhereToEat = new System.Windows.Forms.GroupBox();
            this.rdEatOut = new System.Windows.Forms.RadioButton();
            this.grpSummary = new System.Windows.Forms.GroupBox();
            this.lbTotal = new System.Windows.Forms.Label();
            this.lbWhereToEat = new System.Windows.Forms.Label();
            this.lbCrust = new System.Windows.Forms.Label();
            this.lbToppings = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.lbSize = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.btnOrderPizza = new System.Windows.Forms.Button();
            this.btnResetOrder = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.numericUpDown1 = new System.Windows.Forms.NumericUpDown();
            this.label8 = new System.Windows.Forms.Label();
            this.grpSize.SuspendLayout();
            this.grpCrust.SuspendLayout();
            this.grpToppings.SuspendLayout();
            this.grpWhereToEat.SuspendLayout();
            this.grpSummary.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).BeginInit();
            this.SuspendLayout();
            // 
            // grpSize
            // 
            this.grpSize.Controls.Add(this.rdLarge);
            this.grpSize.Controls.Add(this.rdMeduim);
            this.grpSize.Controls.Add(this.rdSmall);
            this.grpSize.Location = new System.Drawing.Point(12, 98);
            this.grpSize.Name = "grpSize";
            this.grpSize.Size = new System.Drawing.Size(120, 117);
            this.grpSize.TabIndex = 0;
            this.grpSize.TabStop = false;
            this.grpSize.Text = "Size";
            this.grpSize.Enter += new System.EventHandler(this.groupBox1_Enter);
            // 
            // rdLarge
            // 
            this.rdLarge.AutoSize = true;
            this.rdLarge.Location = new System.Drawing.Point(6, 84);
            this.rdLarge.Name = "rdLarge";
            this.rdLarge.Size = new System.Drawing.Size(52, 17);
            this.rdLarge.TabIndex = 2;
            this.rdLarge.TabStop = true;
            this.rdLarge.Tag = "10";
            this.rdLarge.Text = "Large";
            this.rdLarge.UseVisualStyleBackColor = true;
            this.rdLarge.CheckedChanged += new System.EventHandler(this.rdLarge_CheckedChanged);
            // 
            // rdMeduim
            // 
            this.rdMeduim.AutoSize = true;
            this.rdMeduim.Location = new System.Drawing.Point(7, 52);
            this.rdMeduim.Name = "rdMeduim";
            this.rdMeduim.Size = new System.Drawing.Size(62, 17);
            this.rdMeduim.TabIndex = 1;
            this.rdMeduim.TabStop = true;
            this.rdMeduim.Tag = "7";
            this.rdMeduim.Text = "Meduim";
            this.rdMeduim.UseVisualStyleBackColor = true;
            this.rdMeduim.CheckedChanged += new System.EventHandler(this.radioButton2_CheckedChanged);
            // 
            // rdSmall
            // 
            this.rdSmall.AutoSize = true;
            this.rdSmall.Location = new System.Drawing.Point(7, 20);
            this.rdSmall.Name = "rdSmall";
            this.rdSmall.Size = new System.Drawing.Size(50, 17);
            this.rdSmall.TabIndex = 0;
            this.rdSmall.TabStop = true;
            this.rdSmall.Tag = "5";
            this.rdSmall.Text = "Small";
            this.rdSmall.UseVisualStyleBackColor = true;
            this.rdSmall.CheckedChanged += new System.EventHandler(this.rdSmall_CheckedChanged);
            // 
            // grpCrust
            // 
            this.grpCrust.Controls.Add(this.rdThick);
            this.grpCrust.Controls.Add(this.rdThin);
            this.grpCrust.Location = new System.Drawing.Point(19, 249);
            this.grpCrust.Name = "grpCrust";
            this.grpCrust.Size = new System.Drawing.Size(120, 117);
            this.grpCrust.TabIndex = 1;
            this.grpCrust.TabStop = false;
            this.grpCrust.Text = "CrustType";
            // 
            // rdThick
            // 
            this.rdThick.AutoSize = true;
            this.rdThick.Location = new System.Drawing.Point(7, 52);
            this.rdThick.Name = "rdThick";
            this.rdThick.Size = new System.Drawing.Size(79, 17);
            this.rdThick.TabIndex = 1;
            this.rdThick.TabStop = true;
            this.rdThick.Tag = "10";
            this.rdThick.Text = "Thick Crust";
            this.rdThick.UseVisualStyleBackColor = true;
            this.rdThick.CheckedChanged += new System.EventHandler(this.rdCru_CheckedChanged);
            // 
            // rdThin
            // 
            this.rdThin.AutoSize = true;
            this.rdThin.Location = new System.Drawing.Point(7, 20);
            this.rdThin.Name = "rdThin";
            this.rdThin.Size = new System.Drawing.Size(73, 17);
            this.rdThin.TabIndex = 0;
            this.rdThin.TabStop = true;
            this.rdThin.Tag = "5";
            this.rdThin.Text = "Thin Crust";
            this.rdThin.UseVisualStyleBackColor = true;
            this.rdThin.CheckedChanged += new System.EventHandler(this.rdThin_CheckedChanged);
            // 
            // grpToppings
            // 
            this.grpToppings.Controls.Add(this.chkOlives);
            this.grpToppings.Controls.Add(this.chkOnion);
            this.grpToppings.Controls.Add(this.chkGreen);
            this.grpToppings.Controls.Add(this.chkTomatoes);
            this.grpToppings.Controls.Add(this.chkMuchrooms);
            this.grpToppings.Controls.Add(this.chkExtraChees);
            this.grpToppings.Location = new System.Drawing.Point(221, 98);
            this.grpToppings.Name = "grpToppings";
            this.grpToppings.Size = new System.Drawing.Size(223, 117);
            this.grpToppings.TabIndex = 2;
            this.grpToppings.TabStop = false;
            this.grpToppings.Text = "Toppings";
            // 
            // chkOlives
            // 
            this.chkOlives.AutoSize = true;
            this.chkOlives.Location = new System.Drawing.Point(112, 44);
            this.chkOlives.Name = "chkOlives";
            this.chkOlives.Size = new System.Drawing.Size(55, 17);
            this.chkOlives.TabIndex = 5;
            this.chkOlives.Tag = "5";
            this.chkOlives.Text = "Olives";
            this.chkOlives.UseVisualStyleBackColor = true;
            this.chkOlives.CheckedChanged += new System.EventHandler(this.chk5_CheckedChanged);
            // 
            // chkOnion
            // 
            this.chkOnion.AutoSize = true;
            this.chkOnion.Location = new System.Drawing.Point(112, 21);
            this.chkOnion.Name = "chkOnion";
            this.chkOnion.Size = new System.Drawing.Size(54, 17);
            this.chkOnion.TabIndex = 4;
            this.chkOnion.Tag = "5";
            this.chkOnion.Text = "Onion";
            this.chkOnion.UseVisualStyleBackColor = true;
            this.chkOnion.CheckedChanged += new System.EventHandler(this.checkBox5_CheckedChanged);
            // 
            // chkGreen
            // 
            this.chkGreen.AutoSize = true;
            this.chkGreen.Location = new System.Drawing.Point(112, 67);
            this.chkGreen.Name = "chkGreen";
            this.chkGreen.Size = new System.Drawing.Size(55, 17);
            this.chkGreen.TabIndex = 3;
            this.chkGreen.Tag = "5";
            this.chkGreen.Text = "Green";
            this.chkGreen.UseVisualStyleBackColor = true;
            this.chkGreen.CheckedChanged += new System.EventHandler(this.chk6_CheckedChanged);
            // 
            // chkTomatoes
            // 
            this.chkTomatoes.AutoSize = true;
            this.chkTomatoes.Location = new System.Drawing.Point(6, 67);
            this.chkTomatoes.Name = "chkTomatoes";
            this.chkTomatoes.Size = new System.Drawing.Size(73, 17);
            this.chkTomatoes.TabIndex = 2;
            this.chkTomatoes.Tag = "5";
            this.chkTomatoes.Text = "Tomatoes";
            this.chkTomatoes.UseVisualStyleBackColor = true;
            this.chkTomatoes.CheckedChanged += new System.EventHandler(this.chkt3_CheckedChanged);
            // 
            // chkMuchrooms
            // 
            this.chkMuchrooms.AutoSize = true;
            this.chkMuchrooms.Location = new System.Drawing.Point(6, 44);
            this.chkMuchrooms.Name = "chkMuchrooms";
            this.chkMuchrooms.Size = new System.Drawing.Size(81, 17);
            this.chkMuchrooms.TabIndex = 1;
            this.chkMuchrooms.Tag = "5";
            this.chkMuchrooms.Text = "Muchrooms";
            this.chkMuchrooms.UseVisualStyleBackColor = true;
            this.chkMuchrooms.CheckedChanged += new System.EventHandler(this.chkt2_CheckedChanged);
            // 
            // chkExtraChees
            // 
            this.chkExtraChees.AutoSize = true;
            this.chkExtraChees.Location = new System.Drawing.Point(6, 21);
            this.chkExtraChees.Name = "chkExtraChees";
            this.chkExtraChees.Size = new System.Drawing.Size(83, 17);
            this.chkExtraChees.TabIndex = 0;
            this.chkExtraChees.Tag = "5";
            this.chkExtraChees.Text = "Extra Chees";
            this.chkExtraChees.UseVisualStyleBackColor = true;
            this.chkExtraChees.CheckedChanged += new System.EventHandler(this.chkt1_CheckedChanged);
            // 
            // rdEatIn
            // 
            this.rdEatIn.AutoSize = true;
            this.rdEatIn.Location = new System.Drawing.Point(6, 22);
            this.rdEatIn.Name = "rdEatIn";
            this.rdEatIn.Size = new System.Drawing.Size(53, 17);
            this.rdEatIn.TabIndex = 4;
            this.rdEatIn.TabStop = true;
            this.rdEatIn.Text = "Eat In";
            this.rdEatIn.UseVisualStyleBackColor = true;
            this.rdEatIn.CheckedChanged += new System.EventHandler(this.rdEatIn_CheckedChanged);
            // 
            // grpWhereToEat
            // 
            this.grpWhereToEat.Controls.Add(this.rdEatOut);
            this.grpWhereToEat.Controls.Add(this.rdEatIn);
            this.grpWhereToEat.Location = new System.Drawing.Point(221, 238);
            this.grpWhereToEat.Name = "grpWhereToEat";
            this.grpWhereToEat.Size = new System.Drawing.Size(209, 48);
            this.grpWhereToEat.TabIndex = 5;
            this.grpWhereToEat.TabStop = false;
            this.grpWhereToEat.Text = "Where to Eat";
            this.grpWhereToEat.Enter += new System.EventHandler(this.gpWhtoeat_Enter);
            // 
            // rdEatOut
            // 
            this.rdEatOut.AutoSize = true;
            this.rdEatOut.Location = new System.Drawing.Point(109, 22);
            this.rdEatOut.Name = "rdEatOut";
            this.rdEatOut.Size = new System.Drawing.Size(61, 17);
            this.rdEatOut.TabIndex = 5;
            this.rdEatOut.TabStop = true;
            this.rdEatOut.Text = "Eat Out";
            this.rdEatOut.UseVisualStyleBackColor = true;
            this.rdEatOut.CheckedChanged += new System.EventHandler(this.rdEatOut_CheckedChanged);
            // 
            // grpSummary
            // 
            this.grpSummary.Controls.Add(this.lbTotal);
            this.grpSummary.Controls.Add(this.lbWhereToEat);
            this.grpSummary.Controls.Add(this.lbCrust);
            this.grpSummary.Controls.Add(this.lbToppings);
            this.grpSummary.Controls.Add(this.label5);
            this.grpSummary.Controls.Add(this.label4);
            this.grpSummary.Controls.Add(this.label3);
            this.grpSummary.Controls.Add(this.label2);
            this.grpSummary.Controls.Add(this.lbSize);
            this.grpSummary.Controls.Add(this.label1);
            this.grpSummary.Location = new System.Drawing.Point(576, 98);
            this.grpSummary.Name = "grpSummary";
            this.grpSummary.Size = new System.Drawing.Size(200, 316);
            this.grpSummary.TabIndex = 6;
            this.grpSummary.TabStop = false;
            this.grpSummary.Text = "Order Summary";
            this.grpSummary.Enter += new System.EventHandler(this.groupBox4_Enter);
            // 
            // lbTotal
            // 
            this.lbTotal.AutoSize = true;
            this.lbTotal.Font = new System.Drawing.Font("Microsoft Sans Serif", 27.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbTotal.Location = new System.Drawing.Point(65, 251);
            this.lbTotal.Name = "lbTotal";
            this.lbTotal.Size = new System.Drawing.Size(0, 42);
            this.lbTotal.TabIndex = 9;
            this.lbTotal.Click += new System.EventHandler(this.lbTotal_Click);
            // 
            // lbWhereToEat
            // 
            this.lbWhereToEat.AutoSize = true;
            this.lbWhereToEat.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbWhereToEat.Location = new System.Drawing.Point(90, 183);
            this.lbWhereToEat.Name = "lbWhereToEat";
            this.lbWhereToEat.Size = new System.Drawing.Size(0, 16);
            this.lbWhereToEat.TabIndex = 8;
            // 
            // lbCrust
            // 
            this.lbCrust.AutoSize = true;
            this.lbCrust.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbCrust.Location = new System.Drawing.Point(103, 131);
            this.lbCrust.Name = "lbCrust";
            this.lbCrust.Size = new System.Drawing.Size(0, 16);
            this.lbCrust.TabIndex = 7;
            // 
            // lbToppings
            // 
            this.lbToppings.AutoSize = true;
            this.lbToppings.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbToppings.Location = new System.Drawing.Point(6, 101);
            this.lbToppings.Name = "lbToppings";
            this.lbToppings.Size = new System.Drawing.Size(0, 16);
            this.lbToppings.TabIndex = 6;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(6, 219);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(47, 16);
            this.label5.TabIndex = 5;
            this.label5.Text = "Total:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(6, 162);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(106, 16);
            this.label4.TabIndex = 4;
            this.label4.Text = "Where To Eat:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(6, 131);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(82, 16);
            this.label3.TabIndex = 3;
            this.label3.Text = "CrustType:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(6, 68);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(77, 16);
            this.label2.TabIndex = 2;
            this.label2.Text = "Toppings:";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // lbSize
            // 
            this.lbSize.AutoSize = true;
            this.lbSize.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbSize.Location = new System.Drawing.Point(53, 33);
            this.lbSize.Name = "lbSize";
            this.lbSize.Size = new System.Drawing.Size(0, 16);
            this.lbSize.TabIndex = 1;
            this.lbSize.Click += new System.EventHandler(this.lbSize_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(6, 33);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(41, 16);
            this.label1.TabIndex = 0;
            this.label1.Text = "Size:";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // btnOrderPizza
            // 
            this.btnOrderPizza.Location = new System.Drawing.Point(187, 358);
            this.btnOrderPizza.Name = "btnOrderPizza";
            this.btnOrderPizza.Size = new System.Drawing.Size(142, 42);
            this.btnOrderPizza.TabIndex = 7;
            this.btnOrderPizza.Text = "Order Pizza";
            this.btnOrderPizza.UseVisualStyleBackColor = true;
            this.btnOrderPizza.Click += new System.EventHandler(this.btnOrderPizza_Click);
            // 
            // btnResetOrder
            // 
            this.btnResetOrder.Location = new System.Drawing.Point(359, 358);
            this.btnResetOrder.Name = "btnResetOrder";
            this.btnResetOrder.Size = new System.Drawing.Size(142, 42);
            this.btnResetOrder.TabIndex = 8;
            this.btnResetOrder.Text = "Reset Order";
            this.btnResetOrder.UseVisualStyleBackColor = true;
            this.btnResetOrder.Click += new System.EventHandler(this.btnResetOrder_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(0, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(35, 13);
            this.label6.TabIndex = 9;
            this.label6.Text = "label6";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Blackadder ITC", 27.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(248, 21);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(281, 48);
            this.label7.TabIndex = 10;
            this.label7.Text = "Make Your  Pizza";
            // 
            // numericUpDown1
            // 
            this.numericUpDown1.Font = new System.Drawing.Font("Microsoft Tai Le", 11.25F, System.Drawing.FontStyle.Bold);
            this.numericUpDown1.Location = new System.Drawing.Point(333, 316);
            this.numericUpDown1.Name = "numericUpDown1";
            this.numericUpDown1.Size = new System.Drawing.Size(44, 27);
            this.numericUpDown1.TabIndex = 11;
            this.numericUpDown1.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numericUpDown1.ValueChanged += new System.EventHandler(this.numericUpDown1_ValueChanged);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Tai Le", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(278, 316);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(51, 19);
            this.label8.TabIndex = 6;
            this.label8.Text = "Count";
            // 
            // frmPizzaMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DarkSalmon;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.numericUpDown1);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.btnResetOrder);
            this.Controls.Add(this.btnOrderPizza);
            this.Controls.Add(this.grpSummary);
            this.Controls.Add(this.grpWhereToEat);
            this.Controls.Add(this.grpToppings);
            this.Controls.Add(this.grpCrust);
            this.Controls.Add(this.grpSize);
            this.Cursor = System.Windows.Forms.Cursors.Default;
            this.Name = "frmPizzaMenu";
            this.Text = "v";
            this.Load += new System.EventHandler(this.frmPizzaMenu_Load);
            this.grpSize.ResumeLayout(false);
            this.grpSize.PerformLayout();
            this.grpCrust.ResumeLayout(false);
            this.grpCrust.PerformLayout();
            this.grpToppings.ResumeLayout(false);
            this.grpToppings.PerformLayout();
            this.grpWhereToEat.ResumeLayout(false);
            this.grpWhereToEat.PerformLayout();
            this.grpSummary.ResumeLayout(false);
            this.grpSummary.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox grpSize;
        private System.Windows.Forms.RadioButton rdLarge;
        private System.Windows.Forms.RadioButton rdMeduim;
        private System.Windows.Forms.RadioButton rdSmall;
        private System.Windows.Forms.GroupBox grpCrust;
        private System.Windows.Forms.RadioButton rdThick;
        private System.Windows.Forms.RadioButton rdThin;
        private System.Windows.Forms.GroupBox grpToppings;
        private System.Windows.Forms.CheckBox chkOlives;
        private System.Windows.Forms.CheckBox chkOnion;
        private System.Windows.Forms.CheckBox chkGreen;
        private System.Windows.Forms.CheckBox chkTomatoes;
        private System.Windows.Forms.CheckBox chkMuchrooms;
        private System.Windows.Forms.CheckBox chkExtraChees;
        private System.Windows.Forms.RadioButton rdEatIn;
        private System.Windows.Forms.GroupBox grpWhereToEat;
        private System.Windows.Forms.RadioButton rdEatOut;
        private System.Windows.Forms.GroupBox grpSummary;
        private System.Windows.Forms.Label lbSize;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lbWhereToEat;
        private System.Windows.Forms.Label lbCrust;
        private System.Windows.Forms.Label lbToppings;
        private System.Windows.Forms.Label lbTotal;
        private System.Windows.Forms.Button btnOrderPizza;
        private System.Windows.Forms.Button btnResetOrder;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.NumericUpDown numericUpDown1;
        private System.Windows.Forms.Label label8;
    }
}