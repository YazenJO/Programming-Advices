using System.ComponentModel;

namespace Test
{
    partial class PaymentsScreen
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
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            this.txtFilter = new Guna.UI2.WinForms.Guna2TextBox();
            this.PaymentsManagmentDataGrid = new Guna.UI2.WinForms.Guna2DataGridView();
            this.PaymentsMenu = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.AddtoolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.editToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.deleteToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.btnAddNewBook = new Guna.UI2.WinForms.Guna2Button();
            this.DtimerFrom = new Guna.UI2.WinForms.Guna2DateTimePicker();
            this.DttimeTo = new Guna.UI2.WinForms.Guna2DateTimePicker();
            this.cbFilter = new Guna.UI2.WinForms.Guna2ComboBox();
            this.guna2HtmlLabel5 = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.guna2HtmlLabel4 = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.guna2HtmlLabel3 = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.guna2HtmlLabel1 = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.guna2PictureBox1 = new Guna.UI2.WinForms.Guna2PictureBox();
            this.guna2ControlBox2 = new Guna.UI2.WinForms.Guna2ControlBox();
            this.guna2ControlBox1 = new Guna.UI2.WinForms.Guna2ControlBox();
            ((System.ComponentModel.ISupportInitialize)(this.PaymentsManagmentDataGrid)).BeginInit();
            this.PaymentsMenu.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.guna2PictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // txtFilter
            // 
            this.txtFilter.BorderRadius = 8;
            this.txtFilter.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtFilter.DefaultText = "";
            this.txtFilter.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtFilter.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtFilter.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtFilter.DisabledState.Parent = this.txtFilter;
            this.txtFilter.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtFilter.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtFilter.FocusedState.Parent = this.txtFilter;
            this.txtFilter.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtFilter.HoverState.Parent = this.txtFilter;
            this.txtFilter.Location = new System.Drawing.Point(370, 351);
            this.txtFilter.Name = "txtFilter";
            this.txtFilter.PasswordChar = '\0';
            this.txtFilter.PlaceholderText = "";
            this.txtFilter.SelectedText = "";
            this.txtFilter.ShadowDecoration.Parent = this.txtFilter;
            this.txtFilter.Size = new System.Drawing.Size(205, 36);
            this.txtFilter.TabIndex = 66;
            this.txtFilter.Visible = false;
            this.txtFilter.TextChanged += new System.EventHandler(this.txtFilter_TextChanged);
            // 
            // PaymentsManagmentDataGrid
            // 
            this.PaymentsManagmentDataGrid.AllowUserToAddRows = false;
            this.PaymentsManagmentDataGrid.AllowUserToDeleteRows = false;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.White;
            this.PaymentsManagmentDataGrid.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.PaymentsManagmentDataGrid.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.PaymentsManagmentDataGrid.BackgroundColor = System.Drawing.Color.White;
            this.PaymentsManagmentDataGrid.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.PaymentsManagmentDataGrid.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.PaymentsManagmentDataGrid.ClipboardCopyMode = System.Windows.Forms.DataGridViewClipboardCopyMode.EnableAlwaysIncludeHeaderText;
            this.PaymentsManagmentDataGrid.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Sunken;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI", 10.5F);
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.PaymentsManagmentDataGrid.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.PaymentsManagmentDataGrid.ColumnHeadersHeight = 25;
            this.PaymentsManagmentDataGrid.ContextMenuStrip = this.PaymentsMenu;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Segoe UI", 10.5F);
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.PaymentsManagmentDataGrid.DefaultCellStyle = dataGridViewCellStyle3;
            this.PaymentsManagmentDataGrid.EnableHeadersVisualStyles = false;
            this.PaymentsManagmentDataGrid.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.PaymentsManagmentDataGrid.Location = new System.Drawing.Point(19, 419);
            this.PaymentsManagmentDataGrid.Name = "PaymentsManagmentDataGrid";
            this.PaymentsManagmentDataGrid.ReadOnly = true;
            this.PaymentsManagmentDataGrid.RowHeadersVisible = false;
            this.PaymentsManagmentDataGrid.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.PaymentsManagmentDataGrid.Size = new System.Drawing.Size(1404, 360);
            this.PaymentsManagmentDataGrid.TabIndex = 65;
            this.PaymentsManagmentDataGrid.Theme = Guna.UI2.WinForms.Enums.DataGridViewPresetThemes.Default;
            this.PaymentsManagmentDataGrid.ThemeStyle.AlternatingRowsStyle.BackColor = System.Drawing.Color.White;
            this.PaymentsManagmentDataGrid.ThemeStyle.AlternatingRowsStyle.Font = null;
            this.PaymentsManagmentDataGrid.ThemeStyle.AlternatingRowsStyle.ForeColor = System.Drawing.Color.Empty;
            this.PaymentsManagmentDataGrid.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = System.Drawing.Color.Empty;
            this.PaymentsManagmentDataGrid.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = System.Drawing.Color.Empty;
            this.PaymentsManagmentDataGrid.ThemeStyle.BackColor = System.Drawing.Color.White;
            this.PaymentsManagmentDataGrid.ThemeStyle.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.PaymentsManagmentDataGrid.ThemeStyle.HeaderStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.PaymentsManagmentDataGrid.ThemeStyle.HeaderStyle.BorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Sunken;
            this.PaymentsManagmentDataGrid.ThemeStyle.HeaderStyle.Font = new System.Drawing.Font("Segoe UI", 10.5F);
            this.PaymentsManagmentDataGrid.ThemeStyle.HeaderStyle.ForeColor = System.Drawing.Color.White;
            this.PaymentsManagmentDataGrid.ThemeStyle.HeaderStyle.HeaightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            this.PaymentsManagmentDataGrid.ThemeStyle.HeaderStyle.Height = 25;
            this.PaymentsManagmentDataGrid.ThemeStyle.ReadOnly = true;
            this.PaymentsManagmentDataGrid.ThemeStyle.RowsStyle.BackColor = System.Drawing.Color.White;
            this.PaymentsManagmentDataGrid.ThemeStyle.RowsStyle.BorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.PaymentsManagmentDataGrid.ThemeStyle.RowsStyle.Font = new System.Drawing.Font("Segoe UI", 10.5F);
            this.PaymentsManagmentDataGrid.ThemeStyle.RowsStyle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            this.PaymentsManagmentDataGrid.ThemeStyle.RowsStyle.Height = 22;
            this.PaymentsManagmentDataGrid.ThemeStyle.RowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.PaymentsManagmentDataGrid.ThemeStyle.RowsStyle.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            // 
            // PaymentsMenu
            // 
            this.PaymentsMenu.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PaymentsMenu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] { this.AddtoolStripMenuItem1, this.editToolStripMenuItem, this.deleteToolStripMenuItem });
            this.PaymentsMenu.Name = "contextMenuStrip1";
            this.PaymentsMenu.Size = new System.Drawing.Size(259, 106);
            this.PaymentsMenu.Text = "PaymentMenu";
            // 
            // AddtoolStripMenuItem1
            // 
            this.AddtoolStripMenuItem1.Image = global::Test.Properties.Resources.add_dollar_240px;
            this.AddtoolStripMenuItem1.Name = "AddtoolStripMenuItem1";
            this.AddtoolStripMenuItem1.Size = new System.Drawing.Size(258, 34);
            this.AddtoolStripMenuItem1.Text = "Add New Payment";
            this.AddtoolStripMenuItem1.Click += new System.EventHandler(this.AddtoolStripMenuItem1_Click);
            // 
            // editToolStripMenuItem
            // 
            this.editToolStripMenuItem.Image = global::Test.Properties.Resources.edit_property_240px;
            this.editToolStripMenuItem.Name = "editToolStripMenuItem";
            this.editToolStripMenuItem.Size = new System.Drawing.Size(258, 34);
            this.editToolStripMenuItem.Text = "Edit";
            this.editToolStripMenuItem.Click += new System.EventHandler(this.editToolStripMenuItem_Click);
            // 
            // deleteToolStripMenuItem
            // 
            this.deleteToolStripMenuItem.Image = global::Test.Properties.Resources.Delete_credit_cards_240px;
            this.deleteToolStripMenuItem.Name = "deleteToolStripMenuItem";
            this.deleteToolStripMenuItem.Size = new System.Drawing.Size(258, 34);
            this.deleteToolStripMenuItem.Text = "Delete";
            this.deleteToolStripMenuItem.Click += new System.EventHandler(this.deleteToolStripMenuItem_Click);
            // 
            // btnAddNewBook
            // 
            this.btnAddNewBook.BorderRadius = 8;
            this.btnAddNewBook.CheckedState.Parent = this.btnAddNewBook;
            this.btnAddNewBook.CustomImages.Parent = this.btnAddNewBook;
            this.btnAddNewBook.FillColor = System.Drawing.Color.White;
            this.btnAddNewBook.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btnAddNewBook.ForeColor = System.Drawing.Color.White;
            this.btnAddNewBook.HoverState.Parent = this.btnAddNewBook;
            this.btnAddNewBook.Image = global::Test.Properties.Resources.add_dollar_240px;
            this.btnAddNewBook.ImageSize = new System.Drawing.Size(50, 50);
            this.btnAddNewBook.Location = new System.Drawing.Point(1322, 341);
            this.btnAddNewBook.Name = "btnAddNewBook";
            this.btnAddNewBook.ShadowDecoration.Parent = this.btnAddNewBook;
            this.btnAddNewBook.Size = new System.Drawing.Size(94, 55);
            this.btnAddNewBook.TabIndex = 64;
            this.btnAddNewBook.Click += new System.EventHandler(this.btnAddNewBook_Click);
            // 
            // DtimerFrom
            // 
            this.DtimerFrom.BorderRadius = 8;
            this.DtimerFrom.CheckedState.Parent = this.DtimerFrom;
            this.DtimerFrom.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(150)))), ((int)(((byte)(243)))));
            this.DtimerFrom.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.DtimerFrom.HoverState.Parent = this.DtimerFrom;
            this.DtimerFrom.Location = new System.Drawing.Point(1009, 360);
            this.DtimerFrom.MaxDate = new System.DateTime(9998, 12, 31, 0, 0, 0, 0);
            this.DtimerFrom.MinDate = new System.DateTime(1753, 1, 1, 0, 0, 0, 0);
            this.DtimerFrom.Name = "DtimerFrom";
            this.DtimerFrom.ShadowDecoration.Parent = this.DtimerFrom;
            this.DtimerFrom.Size = new System.Drawing.Size(106, 36);
            this.DtimerFrom.TabIndex = 63;
            this.DtimerFrom.Value = new System.DateTime(2025, 2, 3, 22, 13, 39, 415);
            this.DtimerFrom.ValueChanged += new System.EventHandler(this.DtimerFrom_ValueChanged);
            // 
            // DttimeTo
            // 
            this.DttimeTo.BorderRadius = 8;
            this.DttimeTo.CheckedState.Parent = this.DttimeTo;
            this.DttimeTo.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(150)))), ((int)(((byte)(243)))));
            this.DttimeTo.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.DttimeTo.HoverState.Parent = this.DttimeTo;
            this.DttimeTo.Location = new System.Drawing.Point(1191, 360);
            this.DttimeTo.MaxDate = new System.DateTime(9998, 12, 31, 0, 0, 0, 0);
            this.DttimeTo.MinDate = new System.DateTime(1753, 1, 1, 0, 0, 0, 0);
            this.DttimeTo.Name = "DttimeTo";
            this.DttimeTo.ShadowDecoration.Parent = this.DttimeTo;
            this.DttimeTo.Size = new System.Drawing.Size(106, 36);
            this.DttimeTo.TabIndex = 62;
            this.DttimeTo.Value = new System.DateTime(2025, 2, 3, 22, 13, 39, 415);
            this.DttimeTo.ValueChanged += new System.EventHandler(this.DttimeTo_ValueChanged);
            // 
            // cbFilter
            // 
            this.cbFilter.BackColor = System.Drawing.Color.Transparent;
            this.cbFilter.BorderRadius = 8;
            this.cbFilter.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.cbFilter.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbFilter.FocusedColor = System.Drawing.Color.Empty;
            this.cbFilter.FocusedState.Parent = this.cbFilter;
            this.cbFilter.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.cbFilter.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(88)))), ((int)(((byte)(112)))));
            this.cbFilter.FormattingEnabled = true;
            this.cbFilter.HoverState.Parent = this.cbFilter;
            this.cbFilter.ItemHeight = 30;
            this.cbFilter.Items.AddRange(new object[] { "None", "Reader Name", "Payment Amount", "User Name" });
            this.cbFilter.ItemsAppearance.Parent = this.cbFilter;
            this.cbFilter.Location = new System.Drawing.Point(123, 351);
            this.cbFilter.Name = "cbFilter";
            this.cbFilter.ShadowDecoration.Parent = this.cbFilter;
            this.cbFilter.Size = new System.Drawing.Size(241, 36);
            this.cbFilter.TabIndex = 61;
            this.cbFilter.SelectedIndexChanged += new System.EventHandler(this.cbFilter_SelectedIndexChanged);
            // 
            // guna2HtmlLabel5
            // 
            this.guna2HtmlLabel5.BackColor = System.Drawing.Color.Transparent;
            this.guna2HtmlLabel5.Font = new System.Drawing.Font("Yu Gothic", 27.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.guna2HtmlLabel5.ForeColor = System.Drawing.Color.DarkBlue;
            this.guna2HtmlLabel5.Location = new System.Drawing.Point(472, 253);
            this.guna2HtmlLabel5.Name = "guna2HtmlLabel5";
            this.guna2HtmlLabel5.Size = new System.Drawing.Size(392, 50);
            this.guna2HtmlLabel5.TabIndex = 60;
            this.guna2HtmlLabel5.Text = "Payment Managment";
            // 
            // guna2HtmlLabel4
            // 
            this.guna2HtmlLabel4.BackColor = System.Drawing.Color.Transparent;
            this.guna2HtmlLabel4.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.guna2HtmlLabel4.ForeColor = System.Drawing.Color.DarkBlue;
            this.guna2HtmlLabel4.Location = new System.Drawing.Point(1144, 360);
            this.guna2HtmlLabel4.Name = "guna2HtmlLabel4";
            this.guna2HtmlLabel4.Size = new System.Drawing.Size(22, 27);
            this.guna2HtmlLabel4.TabIndex = 59;
            this.guna2HtmlLabel4.Text = "to ";
            // 
            // guna2HtmlLabel3
            // 
            this.guna2HtmlLabel3.BackColor = System.Drawing.Color.Transparent;
            this.guna2HtmlLabel3.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.guna2HtmlLabel3.ForeColor = System.Drawing.Color.DarkBlue;
            this.guna2HtmlLabel3.Location = new System.Drawing.Point(871, 360);
            this.guna2HtmlLabel3.Name = "guna2HtmlLabel3";
            this.guna2HtmlLabel3.Size = new System.Drawing.Size(132, 27);
            this.guna2HtmlLabel3.TabIndex = 58;
            this.guna2HtmlLabel3.Text = "PaymentDate :";
            // 
            // guna2HtmlLabel1
            // 
            this.guna2HtmlLabel1.BackColor = System.Drawing.Color.Transparent;
            this.guna2HtmlLabel1.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.guna2HtmlLabel1.ForeColor = System.Drawing.Color.DarkBlue;
            this.guna2HtmlLabel1.Location = new System.Drawing.Point(19, 351);
            this.guna2HtmlLabel1.Name = "guna2HtmlLabel1";
            this.guna2HtmlLabel1.Size = new System.Drawing.Size(80, 27);
            this.guna2HtmlLabel1.TabIndex = 57;
            this.guna2HtmlLabel1.Text = "Filter by:";
            // 
            // guna2PictureBox1
            // 
            this.guna2PictureBox1.Image = global::Test.Properties.Resources.cash_and_credit_card_240px;
            this.guna2PictureBox1.Location = new System.Drawing.Point(515, 29);
            this.guna2PictureBox1.Name = "guna2PictureBox1";
            this.guna2PictureBox1.ShadowDecoration.Parent = this.guna2PictureBox1;
            this.guna2PictureBox1.Size = new System.Drawing.Size(300, 200);
            this.guna2PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.guna2PictureBox1.TabIndex = 56;
            this.guna2PictureBox1.TabStop = false;
            // 
            // guna2ControlBox2
            // 
            this.guna2ControlBox2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.guna2ControlBox2.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(123)))), ((int)(((byte)(255)))));
            this.guna2ControlBox2.BorderRadius = 15;
            this.guna2ControlBox2.BorderThickness = 1;
            this.guna2ControlBox2.ControlBoxType = Guna.UI2.WinForms.Enums.ControlBoxType.MinimizeBox;
            this.guna2ControlBox2.CustomIconSize = 13F;
            this.guna2ControlBox2.FillColor = System.Drawing.Color.White;
            this.guna2ControlBox2.HoverState.Parent = this.guna2ControlBox2;
            this.guna2ControlBox2.IconColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(123)))), ((int)(((byte)(255)))));
            this.guna2ControlBox2.Location = new System.Drawing.Point(1333, 12);
            this.guna2ControlBox2.Name = "guna2ControlBox2";
            this.guna2ControlBox2.ShadowDecoration.Parent = this.guna2ControlBox2;
            this.guna2ControlBox2.Size = new System.Drawing.Size(33, 36);
            this.guna2ControlBox2.TabIndex = 55;
            // 
            // guna2ControlBox1
            // 
            this.guna2ControlBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.guna2ControlBox1.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(123)))), ((int)(((byte)(255)))));
            this.guna2ControlBox1.BorderRadius = 15;
            this.guna2ControlBox1.BorderThickness = 1;
            this.guna2ControlBox1.CustomIconSize = 13F;
            this.guna2ControlBox1.FillColor = System.Drawing.Color.White;
            this.guna2ControlBox1.HoverState.Parent = this.guna2ControlBox1;
            this.guna2ControlBox1.IconColor = System.Drawing.Color.Red;
            this.guna2ControlBox1.Location = new System.Drawing.Point(1383, 12);
            this.guna2ControlBox1.Name = "guna2ControlBox1";
            this.guna2ControlBox1.ShadowDecoration.Parent = this.guna2ControlBox1;
            this.guna2ControlBox1.Size = new System.Drawing.Size(33, 36);
            this.guna2ControlBox1.TabIndex = 54;
            // 
            // PaymentsScreen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1428, 798);
            this.Controls.Add(this.txtFilter);
            this.Controls.Add(this.PaymentsManagmentDataGrid);
            this.Controls.Add(this.btnAddNewBook);
            this.Controls.Add(this.DtimerFrom);
            this.Controls.Add(this.DttimeTo);
            this.Controls.Add(this.cbFilter);
            this.Controls.Add(this.guna2HtmlLabel5);
            this.Controls.Add(this.guna2HtmlLabel4);
            this.Controls.Add(this.guna2HtmlLabel3);
            this.Controls.Add(this.guna2HtmlLabel1);
            this.Controls.Add(this.guna2PictureBox1);
            this.Controls.Add(this.guna2ControlBox2);
            this.Controls.Add(this.guna2ControlBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "PaymentsScreen";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "PaymentsScreen";
            this.Load += new System.EventHandler(this.PaymentsScreen_Load);
            ((System.ComponentModel.ISupportInitialize)(this.PaymentsManagmentDataGrid)).EndInit();
            this.PaymentsMenu.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.guna2PictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();
        }

        private System.Windows.Forms.ContextMenuStrip PaymentsMenu;
        private System.Windows.Forms.ToolStripMenuItem AddtoolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem editToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem deleteToolStripMenuItem;

        private Guna.UI2.WinForms.Guna2TextBox txtFilter;
        private Guna.UI2.WinForms.Guna2DataGridView PaymentsManagmentDataGrid;
        private Guna.UI2.WinForms.Guna2Button btnAddNewBook;
        private Guna.UI2.WinForms.Guna2DateTimePicker DtimerFrom;
        private Guna.UI2.WinForms.Guna2DateTimePicker DttimeTo;
        private Guna.UI2.WinForms.Guna2ComboBox cbFilter;
        private Guna.UI2.WinForms.Guna2HtmlLabel guna2HtmlLabel5;
        private Guna.UI2.WinForms.Guna2HtmlLabel guna2HtmlLabel4;
        private Guna.UI2.WinForms.Guna2HtmlLabel guna2HtmlLabel3;
        private Guna.UI2.WinForms.Guna2HtmlLabel guna2HtmlLabel1;
        private Guna.UI2.WinForms.Guna2PictureBox guna2PictureBox1;
        private Guna.UI2.WinForms.Guna2ControlBox guna2ControlBox2;
        private Guna.UI2.WinForms.Guna2ControlBox guna2ControlBox1;

        #endregion
    }
}