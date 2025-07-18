using System.ComponentModel;

namespace Test
{
    partial class ShowEditBorrowScreen
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

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.guna2ControlBox2 = new Guna.UI2.WinForms.Guna2ControlBox();
            this.guna2ControlBox1 = new Guna.UI2.WinForms.Guna2ControlBox();
            this.guna2HtmlLabel1 = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.guna2HtmlLabel4 = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.guna2HtmlLabel5 = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.txt = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.guna2HtmlLabel9 = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.chkPayment = new Guna.UI2.WinForms.Guna2CheckBox();
            this.picMode = new Guna.UI2.WinForms.Guna2PictureBox();
            this.btnClose = new Guna.UI2.WinForms.Guna2Button();
            this.btnSave = new Guna.UI2.WinForms.Guna2Button();
            this.cbUsersList = new Guna.UI2.WinForms.Guna2ComboBox();
            this.dtBorrowingDate = new Guna.UI2.WinForms.Guna2DateTimePicker();
            this.dtDueDate = new Guna.UI2.WinForms.Guna2DateTimePicker();
            this.dtActualReturnDate = new Guna.UI2.WinForms.Guna2DateTimePicker();
            ((System.ComponentModel.ISupportInitialize)(this.picMode)).BeginInit();
            this.SuspendLayout();
            // 
            // guna2ControlBox2
            // 
            this.guna2ControlBox2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.guna2ControlBox2.BackColor = System.Drawing.Color.Transparent;
            this.guna2ControlBox2.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(123)))), ((int)(((byte)(255)))));
            this.guna2ControlBox2.BorderRadius = 15;
            this.guna2ControlBox2.BorderThickness = 1;
            this.guna2ControlBox2.ControlBoxType = Guna.UI2.WinForms.Enums.ControlBoxType.MinimizeBox;
            this.guna2ControlBox2.CustomIconSize = 13F;
            this.guna2ControlBox2.FillColor = System.Drawing.Color.White;
            this.guna2ControlBox2.HoverState.Parent = this.guna2ControlBox2;
            this.guna2ControlBox2.IconColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(123)))), ((int)(((byte)(255)))));
            this.guna2ControlBox2.Location = new System.Drawing.Point(533, 12);
            this.guna2ControlBox2.Name = "guna2ControlBox2";
            this.guna2ControlBox2.ShadowDecoration.Parent = this.guna2ControlBox2;
            this.guna2ControlBox2.Size = new System.Drawing.Size(33, 36);
            this.guna2ControlBox2.TabIndex = 15;
            // 
            // guna2ControlBox1
            // 
            this.guna2ControlBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.guna2ControlBox1.BackColor = System.Drawing.Color.Transparent;
            this.guna2ControlBox1.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(123)))), ((int)(((byte)(255)))));
            this.guna2ControlBox1.BorderRadius = 15;
            this.guna2ControlBox1.BorderThickness = 1;
            this.guna2ControlBox1.CustomIconSize = 13F;
            this.guna2ControlBox1.FillColor = System.Drawing.Color.White;
            this.guna2ControlBox1.HoverState.Parent = this.guna2ControlBox1;
            this.guna2ControlBox1.IconColor = System.Drawing.Color.Red;
            this.guna2ControlBox1.Location = new System.Drawing.Point(572, 12);
            this.guna2ControlBox1.Name = "guna2ControlBox1";
            this.guna2ControlBox1.ShadowDecoration.Parent = this.guna2ControlBox1;
            this.guna2ControlBox1.Size = new System.Drawing.Size(33, 36);
            this.guna2ControlBox1.TabIndex = 14;
            // 
            // guna2HtmlLabel1
            // 
            this.guna2HtmlLabel1.BackColor = System.Drawing.Color.Transparent;
            this.guna2HtmlLabel1.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.guna2HtmlLabel1.Location = new System.Drawing.Point(79, 313);
            this.guna2HtmlLabel1.Name = "guna2HtmlLabel1";
            this.guna2HtmlLabel1.Size = new System.Drawing.Size(91, 23);
            this.guna2HtmlLabel1.TabIndex = 16;
            this.guna2HtmlLabel1.Text = "User Name:";
            this.guna2HtmlLabel1.Click += new System.EventHandler(this.guna2HtmlLabel1_Click);
            // 
            // guna2HtmlLabel4
            // 
            this.guna2HtmlLabel4.BackColor = System.Drawing.Color.Transparent;
            this.guna2HtmlLabel4.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.guna2HtmlLabel4.Location = new System.Drawing.Point(94, 444);
            this.guna2HtmlLabel4.Name = "guna2HtmlLabel4";
            this.guna2HtmlLabel4.Size = new System.Drawing.Size(78, 23);
            this.guna2HtmlLabel4.TabIndex = 26;
            this.guna2HtmlLabel4.Text = "DueDate :";
            // 
            // guna2HtmlLabel5
            // 
            this.guna2HtmlLabel5.BackColor = System.Drawing.Color.Transparent;
            this.guna2HtmlLabel5.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.guna2HtmlLabel5.Location = new System.Drawing.Point(43, 377);
            this.guna2HtmlLabel5.Name = "guna2HtmlLabel5";
            this.guna2HtmlLabel5.Size = new System.Drawing.Size(127, 23);
            this.guna2HtmlLabel5.TabIndex = 24;
            this.guna2HtmlLabel5.Text = "BorrowingDate :";
            // 
            // txt
            // 
            this.txt.BackColor = System.Drawing.Color.Transparent;
            this.txt.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt.Location = new System.Drawing.Point(40, 599);
            this.txt.Name = "txt";
            this.txt.Size = new System.Drawing.Size(130, 23);
            this.txt.TabIndex = 30;
            this.txt.Text = "Payment Status :";
            // 
            // guna2HtmlLabel9
            // 
            this.guna2HtmlLabel9.BackColor = System.Drawing.Color.Transparent;
            this.guna2HtmlLabel9.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.guna2HtmlLabel9.Location = new System.Drawing.Point(17, 524);
            this.guna2HtmlLabel9.Name = "guna2HtmlLabel9";
            this.guna2HtmlLabel9.Size = new System.Drawing.Size(155, 23);
            this.guna2HtmlLabel9.TabIndex = 28;
            this.guna2HtmlLabel9.Text = "Actuel Raturn Date :";
            // 
            // chkPayment
            // 
            this.chkPayment.BackColor = System.Drawing.Color.Transparent;
            this.chkPayment.CheckedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.chkPayment.CheckedState.BorderRadius = 2;
            this.chkPayment.CheckedState.BorderThickness = 0;
            this.chkPayment.CheckedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.chkPayment.Location = new System.Drawing.Point(332, 599);
            this.chkPayment.Name = "chkPayment";
            this.chkPayment.Size = new System.Drawing.Size(18, 37);
            this.chkPayment.TabIndex = 31;
            this.chkPayment.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.chkPayment.UncheckedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(125)))), ((int)(((byte)(137)))), ((int)(((byte)(149)))));
            this.chkPayment.UncheckedState.BorderRadius = 2;
            this.chkPayment.UncheckedState.BorderThickness = 0;
            this.chkPayment.UncheckedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(125)))), ((int)(((byte)(137)))), ((int)(((byte)(149)))));
            this.chkPayment.UseVisualStyleBackColor = false;
            this.chkPayment.CheckedChanged += new System.EventHandler(this.chkPayment_CheckedChanged);
            // 
            // picMode
            // 
            this.picMode.BackColor = System.Drawing.Color.Transparent;
            this.picMode.Image = global::Test.Properties.Resources.Edit_Borrow;
            this.picMode.Location = new System.Drawing.Point(195, 122);
            this.picMode.Name = "picMode";
            this.picMode.ShadowDecoration.Parent = this.picMode;
            this.picMode.Size = new System.Drawing.Size(227, 120);
            this.picMode.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picMode.TabIndex = 32;
            this.picMode.TabStop = false;
            this.picMode.Click += new System.EventHandler(this.picMode_Click);
            // 
            // btnClose
            // 
            this.btnClose.BorderRadius = 8;
            this.btnClose.BorderThickness = 1;
            this.btnClose.CheckedState.Parent = this.btnClose;
            this.btnClose.CustomImages.Parent = this.btnClose;
            this.btnClose.FillColor = System.Drawing.Color.White;
            this.btnClose.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnClose.ForeColor = System.Drawing.Color.Black;
            this.btnClose.HoverState.Parent = this.btnClose;
            this.btnClose.Image = global::Test.Properties.Resources.Close_B;
            this.btnClose.ImageAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.btnClose.ImageSize = new System.Drawing.Size(30, 30);
            this.btnClose.Location = new System.Drawing.Point(412, 684);
            this.btnClose.Name = "btnClose";
            this.btnClose.ShadowDecoration.Parent = this.btnClose;
            this.btnClose.Size = new System.Drawing.Size(95, 41);
            this.btnClose.TabIndex = 35;
            this.btnClose.Text = "Close";
            this.btnClose.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // btnSave
            // 
            this.btnSave.BorderRadius = 8;
            this.btnSave.BorderThickness = 1;
            this.btnSave.CheckedState.Parent = this.btnSave;
            this.btnSave.CustomImages.Parent = this.btnSave;
            this.btnSave.FillColor = System.Drawing.Color.White;
            this.btnSave.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSave.ForeColor = System.Drawing.Color.Black;
            this.btnSave.HoverState.Parent = this.btnSave;
            this.btnSave.Image = global::Test.Properties.Resources.save;
            this.btnSave.ImageAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.btnSave.ImageSize = new System.Drawing.Size(30, 30);
            this.btnSave.Location = new System.Drawing.Point(513, 684);
            this.btnSave.Name = "btnSave";
            this.btnSave.ShadowDecoration.Parent = this.btnSave;
            this.btnSave.Size = new System.Drawing.Size(92, 41);
            this.btnSave.TabIndex = 34;
            this.btnSave.Text = "Save";
            this.btnSave.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.btnSave.Visible = false;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // cbUsersList
            // 
            this.cbUsersList.BackColor = System.Drawing.Color.Transparent;
            this.cbUsersList.BorderRadius = 8;
            this.cbUsersList.BorderThickness = 2;
            this.cbUsersList.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.cbUsersList.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbUsersList.FocusedColor = System.Drawing.Color.Empty;
            this.cbUsersList.FocusedState.Parent = this.cbUsersList;
            this.cbUsersList.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.cbUsersList.ForeColor = System.Drawing.Color.Black;
            this.cbUsersList.FormattingEnabled = true;
            this.cbUsersList.HoverState.Parent = this.cbUsersList;
            this.cbUsersList.ItemHeight = 30;
            this.cbUsersList.ItemsAppearance.Parent = this.cbUsersList;
            this.cbUsersList.Location = new System.Drawing.Point(178, 313);
            this.cbUsersList.Name = "cbUsersList";
            this.cbUsersList.ShadowDecoration.Parent = this.cbUsersList;
            this.cbUsersList.Size = new System.Drawing.Size(329, 36);
            this.cbUsersList.TabIndex = 36;
            this.cbUsersList.SelectedIndexChanged += new System.EventHandler(this.cbUsersList_SelectedIndexChanged);
            // 
            // dtBorrowingDate
            // 
            this.dtBorrowingDate.CheckedState.Parent = this.dtBorrowingDate;
            this.dtBorrowingDate.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(210)))), ((int)(((byte)(234)))), ((int)(((byte)(241)))));
            this.dtBorrowingDate.Format = System.Windows.Forms.DateTimePickerFormat.Long;
            this.dtBorrowingDate.HoverState.Parent = this.dtBorrowingDate;
            this.dtBorrowingDate.Location = new System.Drawing.Point(178, 377);
            this.dtBorrowingDate.MaxDate = new System.DateTime(9998, 12, 31, 0, 0, 0, 0);
            this.dtBorrowingDate.MinDate = new System.DateTime(1753, 1, 1, 0, 0, 0, 0);
            this.dtBorrowingDate.Name = "dtBorrowingDate";
            this.dtBorrowingDate.ShadowDecoration.Parent = this.dtBorrowingDate;
            this.dtBorrowingDate.Size = new System.Drawing.Size(329, 36);
            this.dtBorrowingDate.TabIndex = 37;
            this.dtBorrowingDate.Value = new System.DateTime(2025, 2, 16, 9, 22, 14, 405);
            // 
            // dtDueDate
            // 
            this.dtDueDate.CheckedState.Parent = this.dtDueDate;
            this.dtDueDate.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(210)))), ((int)(((byte)(234)))), ((int)(((byte)(241)))));
            this.dtDueDate.Format = System.Windows.Forms.DateTimePickerFormat.Long;
            this.dtDueDate.HoverState.Parent = this.dtDueDate;
            this.dtDueDate.Location = new System.Drawing.Point(178, 444);
            this.dtDueDate.MaxDate = new System.DateTime(9998, 12, 31, 0, 0, 0, 0);
            this.dtDueDate.MinDate = new System.DateTime(1753, 1, 1, 0, 0, 0, 0);
            this.dtDueDate.Name = "dtDueDate";
            this.dtDueDate.ShadowDecoration.Parent = this.dtDueDate;
            this.dtDueDate.Size = new System.Drawing.Size(329, 36);
            this.dtDueDate.TabIndex = 38;
            this.dtDueDate.Value = new System.DateTime(2025, 2, 16, 9, 22, 14, 405);
            // 
            // dtActualReturnDate
            // 
            this.dtActualReturnDate.BackColor = System.Drawing.Color.Transparent;
            this.dtActualReturnDate.CheckedState.Parent = this.dtActualReturnDate;
            this.dtActualReturnDate.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(210)))), ((int)(((byte)(234)))), ((int)(((byte)(241)))));
            this.dtActualReturnDate.Format = System.Windows.Forms.DateTimePickerFormat.Long;
            this.dtActualReturnDate.HoverState.Parent = this.dtActualReturnDate;
            this.dtActualReturnDate.Location = new System.Drawing.Point(178, 524);
            this.dtActualReturnDate.MaxDate = new System.DateTime(9998, 12, 31, 0, 0, 0, 0);
            this.dtActualReturnDate.MinDate = new System.DateTime(1753, 1, 1, 0, 0, 0, 0);
            this.dtActualReturnDate.Name = "dtActualReturnDate";
            this.dtActualReturnDate.ShadowDecoration.Parent = this.dtActualReturnDate;
            this.dtActualReturnDate.ShowCheckBox = true;
            this.dtActualReturnDate.Size = new System.Drawing.Size(329, 36);
            this.dtActualReturnDate.TabIndex = 39;
            this.dtActualReturnDate.Value = new System.DateTime(1753, 1, 1, 0, 0, 0, 0);
            this.dtActualReturnDate.ValueChanged += new System.EventHandler(this.dtActualReturnDate_ValueChanged);
            // 
            // ShowEditBorrowScreen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Silver;
            this.ClientSize = new System.Drawing.Size(617, 737);
            this.Controls.Add(this.dtActualReturnDate);
            this.Controls.Add(this.dtDueDate);
            this.Controls.Add(this.dtBorrowingDate);
            this.Controls.Add(this.cbUsersList);
            this.Controls.Add(this.chkPayment);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.picMode);
            this.Controls.Add(this.txt);
            this.Controls.Add(this.guna2HtmlLabel9);
            this.Controls.Add(this.guna2HtmlLabel4);
            this.Controls.Add(this.guna2HtmlLabel5);
            this.Controls.Add(this.guna2HtmlLabel1);
            this.Controls.Add(this.guna2ControlBox2);
            this.Controls.Add(this.guna2ControlBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "ShowEditBorrowScreen";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ShowEditBorrowScreen";
            this.Load += new System.EventHandler(this.ShowEditBorrowScreen_Load);
            ((System.ComponentModel.ISupportInitialize)(this.picMode)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();
        }

        private Guna.UI2.WinForms.Guna2DateTimePicker dtBorrowingDate;
        private Guna.UI2.WinForms.Guna2DateTimePicker dtDueDate;
        private Guna.UI2.WinForms.Guna2DateTimePicker dtActualReturnDate;

        private Guna.UI2.WinForms.Guna2ComboBox cbUsersList;

        private Guna.UI2.WinForms.Guna2Button btnClose;
        private Guna.UI2.WinForms.Guna2Button btnSave;

        private Guna.UI2.WinForms.Guna2PictureBox picMode;

        private Guna.UI2.WinForms.Guna2HtmlLabel guna2HtmlLabel9;
        private Guna.UI2.WinForms.Guna2CheckBox chkPayment;

        private Guna.UI2.WinForms.Guna2HtmlLabel guna2HtmlLabel4;
        private Guna.UI2.WinForms.Guna2HtmlLabel guna2HtmlLabel5;
        private Guna.UI2.WinForms.Guna2HtmlLabel txt;

        private Guna.UI2.WinForms.Guna2ControlBox guna2ControlBox2;
        private Guna.UI2.WinForms.Guna2ControlBox guna2ControlBox1;
        private Guna.UI2.WinForms.Guna2HtmlLabel guna2HtmlLabel1;

        #endregion
    }
}