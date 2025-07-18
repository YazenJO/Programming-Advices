using System.ComponentModel;

namespace Test
{
    partial class UsersScreen
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
            this.UsersManagmentDataGrid = new Guna.UI2.WinForms.Guna2DataGridView();
            this.UsersMenu = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.showUserDetailsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
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
            this.grbGender = new System.Windows.Forms.GroupBox();
            this.rdMale = new Guna.UI2.WinForms.Guna2RadioButton();
            this.rdFemale = new Guna.UI2.WinForms.Guna2RadioButton();
            this.guna2Button1 = new Guna.UI2.WinForms.Guna2Button();
            this.guna2HtmlLabel2 = new Guna.UI2.WinForms.Guna2HtmlLabel();
            ((System.ComponentModel.ISupportInitialize)(this.UsersManagmentDataGrid)).BeginInit();
            this.UsersMenu.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.guna2PictureBox1)).BeginInit();
            this.grbGender.SuspendLayout();
            this.SuspendLayout();
            // 
            // txtFilter
            // 
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
            this.txtFilter.Location = new System.Drawing.Point(278, 351);
            this.txtFilter.Name = "txtFilter";
            this.txtFilter.PasswordChar = '\0';
            this.txtFilter.PlaceholderText = "";
            this.txtFilter.SelectedText = "";
            this.txtFilter.ShadowDecoration.Parent = this.txtFilter;
            this.txtFilter.Size = new System.Drawing.Size(200, 36);
            this.txtFilter.TabIndex = 66;
            this.txtFilter.Visible = false;
            this.txtFilter.TextChanged += new System.EventHandler(this.txtFilter_TextChanged);
            // 
            // UsersManagmentDataGrid
            // 
            this.UsersManagmentDataGrid.AllowUserToAddRows = false;
            this.UsersManagmentDataGrid.AllowUserToDeleteRows = false;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.White;
            this.UsersManagmentDataGrid.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.UsersManagmentDataGrid.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.UsersManagmentDataGrid.BackgroundColor = System.Drawing.Color.White;
            this.UsersManagmentDataGrid.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.UsersManagmentDataGrid.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.UsersManagmentDataGrid.ClipboardCopyMode = System.Windows.Forms.DataGridViewClipboardCopyMode.EnableAlwaysIncludeHeaderText;
            this.UsersManagmentDataGrid.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Sunken;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI", 10.5F);
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.UsersManagmentDataGrid.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.UsersManagmentDataGrid.ColumnHeadersHeight = 25;
            this.UsersManagmentDataGrid.ContextMenuStrip = this.UsersMenu;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Segoe UI", 10.5F);
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.UsersManagmentDataGrid.DefaultCellStyle = dataGridViewCellStyle3;
            this.UsersManagmentDataGrid.EnableHeadersVisualStyles = false;
            this.UsersManagmentDataGrid.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.UsersManagmentDataGrid.Location = new System.Drawing.Point(19, 419);
            this.UsersManagmentDataGrid.Name = "UsersManagmentDataGrid";
            this.UsersManagmentDataGrid.ReadOnly = true;
            this.UsersManagmentDataGrid.RowHeadersVisible = false;
            this.UsersManagmentDataGrid.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.UsersManagmentDataGrid.Size = new System.Drawing.Size(1404, 360);
            this.UsersManagmentDataGrid.TabIndex = 65;
            this.UsersManagmentDataGrid.Theme = Guna.UI2.WinForms.Enums.DataGridViewPresetThemes.Default;
            this.UsersManagmentDataGrid.ThemeStyle.AlternatingRowsStyle.BackColor = System.Drawing.Color.White;
            this.UsersManagmentDataGrid.ThemeStyle.AlternatingRowsStyle.Font = null;
            this.UsersManagmentDataGrid.ThemeStyle.AlternatingRowsStyle.ForeColor = System.Drawing.Color.Empty;
            this.UsersManagmentDataGrid.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = System.Drawing.Color.Empty;
            this.UsersManagmentDataGrid.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = System.Drawing.Color.Empty;
            this.UsersManagmentDataGrid.ThemeStyle.BackColor = System.Drawing.Color.White;
            this.UsersManagmentDataGrid.ThemeStyle.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.UsersManagmentDataGrid.ThemeStyle.HeaderStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.UsersManagmentDataGrid.ThemeStyle.HeaderStyle.BorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Sunken;
            this.UsersManagmentDataGrid.ThemeStyle.HeaderStyle.Font = new System.Drawing.Font("Segoe UI", 10.5F);
            this.UsersManagmentDataGrid.ThemeStyle.HeaderStyle.ForeColor = System.Drawing.Color.White;
            this.UsersManagmentDataGrid.ThemeStyle.HeaderStyle.HeaightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            this.UsersManagmentDataGrid.ThemeStyle.HeaderStyle.Height = 25;
            this.UsersManagmentDataGrid.ThemeStyle.ReadOnly = true;
            this.UsersManagmentDataGrid.ThemeStyle.RowsStyle.BackColor = System.Drawing.Color.White;
            this.UsersManagmentDataGrid.ThemeStyle.RowsStyle.BorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.UsersManagmentDataGrid.ThemeStyle.RowsStyle.Font = new System.Drawing.Font("Segoe UI", 10.5F);
            this.UsersManagmentDataGrid.ThemeStyle.RowsStyle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            this.UsersManagmentDataGrid.ThemeStyle.RowsStyle.Height = 22;
            this.UsersManagmentDataGrid.ThemeStyle.RowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.UsersManagmentDataGrid.ThemeStyle.RowsStyle.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            // 
            // UsersMenu
            // 
            this.UsersMenu.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.UsersMenu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] { this.showUserDetailsToolStripMenuItem, this.toolStripMenuItem1, this.editToolStripMenuItem, this.deleteToolStripMenuItem });
            this.UsersMenu.Name = "contextMenuStrip1";
            this.UsersMenu.Size = new System.Drawing.Size(253, 140);
            this.UsersMenu.Text = "contextMenuStrip1";
            // 
            // showUserDetailsToolStripMenuItem
            // 
            this.showUserDetailsToolStripMenuItem.Image = global::Test.Properties.Resources.eye_480px;
            this.showUserDetailsToolStripMenuItem.Name = "showUserDetailsToolStripMenuItem";
            this.showUserDetailsToolStripMenuItem.Size = new System.Drawing.Size(252, 34);
            this.showUserDetailsToolStripMenuItem.Text = "Show User Details";
            this.showUserDetailsToolStripMenuItem.Click += new System.EventHandler(this.showUserDetailsToolStripMenuItem_Click);
            // 
            // toolStripMenuItem1
            // 
            this.toolStripMenuItem1.Image = global::Test.Properties.Resources.add_user_group_woman_man_240px;
            this.toolStripMenuItem1.Name = "toolStripMenuItem1";
            this.toolStripMenuItem1.Size = new System.Drawing.Size(252, 34);
            this.toolStripMenuItem1.Text = "Add New User";
            this.toolStripMenuItem1.Click += new System.EventHandler(this.toolStripMenuItem1_Click);
            // 
            // editToolStripMenuItem
            // 
            this.editToolStripMenuItem.Image = global::Test.Properties.Resources.Edit_icon1;
            this.editToolStripMenuItem.Name = "editToolStripMenuItem";
            this.editToolStripMenuItem.Size = new System.Drawing.Size(252, 34);
            this.editToolStripMenuItem.Text = "Edit";
            this.editToolStripMenuItem.Click += new System.EventHandler(this.editToolStripMenuItem_Click);
            // 
            // deleteToolStripMenuItem
            // 
            this.deleteToolStripMenuItem.Image = global::Test.Properties.Resources.Delete_Book;
            this.deleteToolStripMenuItem.Name = "deleteToolStripMenuItem";
            this.deleteToolStripMenuItem.Size = new System.Drawing.Size(252, 34);
            this.deleteToolStripMenuItem.Text = "Delete";
            this.deleteToolStripMenuItem.Click += new System.EventHandler(this.deleteToolStripMenuItem_Click);
            // 
            // btnAddNewBook
            // 
            this.btnAddNewBook.CheckedState.Parent = this.btnAddNewBook;
            this.btnAddNewBook.CustomImages.Parent = this.btnAddNewBook;
            this.btnAddNewBook.FillColor = System.Drawing.Color.White;
            this.btnAddNewBook.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btnAddNewBook.ForeColor = System.Drawing.Color.White;
            this.btnAddNewBook.HoverState.Parent = this.btnAddNewBook;
            this.btnAddNewBook.Image = global::Test.Properties.Resources.add_user_group_woman_man_240px;
            this.btnAddNewBook.ImageSize = new System.Drawing.Size(40, 40);
            this.btnAddNewBook.Location = new System.Drawing.Point(1322, 354);
            this.btnAddNewBook.Name = "btnAddNewBook";
            this.btnAddNewBook.ShadowDecoration.Parent = this.btnAddNewBook;
            this.btnAddNewBook.Size = new System.Drawing.Size(94, 42);
            this.btnAddNewBook.TabIndex = 64;
            this.btnAddNewBook.Click += new System.EventHandler(this.btnAddNewBook_Click);
            // 
            // DtimerFrom
            // 
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
            this.cbFilter.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.cbFilter.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbFilter.FocusedColor = System.Drawing.Color.Empty;
            this.cbFilter.FocusedState.Parent = this.cbFilter;
            this.cbFilter.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.cbFilter.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(88)))), ((int)(((byte)(112)))));
            this.cbFilter.FormattingEnabled = true;
            this.cbFilter.HoverState.Parent = this.cbFilter;
            this.cbFilter.ItemHeight = 30;
            this.cbFilter.Items.AddRange(new object[] { "None", "Name", "Email", "MobileNumber", "Gender", "Address" });
            this.cbFilter.ItemsAppearance.Parent = this.cbFilter;
            this.cbFilter.Location = new System.Drawing.Point(123, 351);
            this.cbFilter.Name = "cbFilter";
            this.cbFilter.ShadowDecoration.Parent = this.cbFilter;
            this.cbFilter.Size = new System.Drawing.Size(140, 36);
            this.cbFilter.TabIndex = 61;
            this.cbFilter.SelectedIndexChanged += new System.EventHandler(this.cbFilter_SelectedIndexChanged);
            // 
            // guna2HtmlLabel5
            // 
            this.guna2HtmlLabel5.BackColor = System.Drawing.Color.Transparent;
            this.guna2HtmlLabel5.Font = new System.Drawing.Font("Yu Gothic", 27.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.guna2HtmlLabel5.ForeColor = System.Drawing.Color.DarkBlue;
            this.guna2HtmlLabel5.Location = new System.Drawing.Point(538, 259);
            this.guna2HtmlLabel5.Name = "guna2HtmlLabel5";
            this.guna2HtmlLabel5.Size = new System.Drawing.Size(337, 50);
            this.guna2HtmlLabel5.TabIndex = 60;
            this.guna2HtmlLabel5.Text = "Users Managment";
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
            this.guna2HtmlLabel3.Location = new System.Drawing.Point(885, 363);
            this.guna2HtmlLabel3.Name = "guna2HtmlLabel3";
            this.guna2HtmlLabel3.Size = new System.Drawing.Size(118, 27);
            this.guna2HtmlLabel3.TabIndex = 58;
            this.guna2HtmlLabel3.Text = "DateOfBrith :";
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
            this.guna2PictureBox1.Image = global::Test.Properties.Resources.users_240px;
            this.guna2PictureBox1.Location = new System.Drawing.Point(562, 29);
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
            // grbGender
            // 
            this.grbGender.Controls.Add(this.rdMale);
            this.grbGender.Controls.Add(this.rdFemale);
            this.grbGender.Location = new System.Drawing.Point(279, 323);
            this.grbGender.Name = "grbGender";
            this.grbGender.Size = new System.Drawing.Size(200, 64);
            this.grbGender.TabIndex = 53;
            this.grbGender.TabStop = false;
            this.grbGender.Text = "Gender";
            this.grbGender.Visible = false;
            // 
            // rdMale
            // 
            this.rdMale.CheckedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.rdMale.CheckedState.BorderThickness = 0;
            this.rdMale.CheckedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.rdMale.CheckedState.InnerColor = System.Drawing.Color.White;
            this.rdMale.CheckedState.InnerOffset = -4;
            this.rdMale.Image = global::Test.Properties.Resources.male_icon;
            this.rdMale.Location = new System.Drawing.Point(111, 31);
            this.rdMale.Name = "rdMale";
            this.rdMale.Size = new System.Drawing.Size(83, 24);
            this.rdMale.TabIndex = 54;
            this.rdMale.TabStop = true;
            this.rdMale.Text = "Male";
            this.rdMale.UncheckedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(125)))), ((int)(((byte)(137)))), ((int)(((byte)(149)))));
            this.rdMale.UncheckedState.BorderThickness = 2;
            this.rdMale.UncheckedState.FillColor = System.Drawing.Color.Transparent;
            this.rdMale.UncheckedState.InnerColor = System.Drawing.Color.Transparent;
            this.rdMale.UseVisualStyleBackColor = true;
            this.rdMale.CheckedChanged += new System.EventHandler(this.rdMale_CheckedChanged);
            // 
            // rdFemale
            // 
            this.rdFemale.CheckedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.rdFemale.CheckedState.BorderThickness = 0;
            this.rdFemale.CheckedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.rdFemale.CheckedState.InnerColor = System.Drawing.Color.White;
            this.rdFemale.CheckedState.InnerOffset = -4;
            this.rdFemale.Image = global::Test.Properties.Resources.female_Icon;
            this.rdFemale.Location = new System.Drawing.Point(6, 31);
            this.rdFemale.Name = "rdFemale";
            this.rdFemale.Size = new System.Drawing.Size(78, 24);
            this.rdFemale.TabIndex = 53;
            this.rdFemale.TabStop = true;
            this.rdFemale.Text = "Female";
            this.rdFemale.UncheckedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(125)))), ((int)(((byte)(137)))), ((int)(((byte)(149)))));
            this.rdFemale.UncheckedState.BorderThickness = 2;
            this.rdFemale.UncheckedState.FillColor = System.Drawing.Color.Transparent;
            this.rdFemale.UncheckedState.InnerColor = System.Drawing.Color.Transparent;
            this.rdFemale.UseVisualStyleBackColor = true;
            this.rdFemale.CheckedChanged += new System.EventHandler(this.rdFemale_CheckedChanged);
            // 
            // guna2Button1
            // 
            this.guna2Button1.CheckedState.Parent = this.guna2Button1;
            this.guna2Button1.CustomImages.Parent = this.guna2Button1;
            this.guna2Button1.FillColor = System.Drawing.Color.White;
            this.guna2Button1.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.guna2Button1.ForeColor = System.Drawing.Color.White;
            this.guna2Button1.HoverState.Parent = this.guna2Button1;
            this.guna2Button1.Image = global::Test.Properties.Resources.male_user_512px;
            this.guna2Button1.ImageSize = new System.Drawing.Size(40, 40);
            this.guna2Button1.Location = new System.Drawing.Point(35, 12);
            this.guna2Button1.Name = "guna2Button1";
            this.guna2Button1.ShadowDecoration.Parent = this.guna2Button1;
            this.guna2Button1.Size = new System.Drawing.Size(94, 42);
            this.guna2Button1.TabIndex = 67;
            this.guna2Button1.Click += new System.EventHandler(this.guna2Button1_Click);
            // 
            // guna2HtmlLabel2
            // 
            this.guna2HtmlLabel2.BackColor = System.Drawing.Color.Transparent;
            this.guna2HtmlLabel2.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.guna2HtmlLabel2.ForeColor = System.Drawing.Color.Black;
            this.guna2HtmlLabel2.Location = new System.Drawing.Point(19, 60);
            this.guna2HtmlLabel2.Name = "guna2HtmlLabel2";
            this.guna2HtmlLabel2.Size = new System.Drawing.Size(117, 27);
            this.guna2HtmlLabel2.TabIndex = 68;
            this.guna2HtmlLabel2.Text = "Current User";
            // 
            // UsersScreen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1428, 798);
            this.Controls.Add(this.grbGender);
            this.Controls.Add(this.guna2HtmlLabel2);
            this.Controls.Add(this.guna2Button1);
            this.Controls.Add(this.txtFilter);
            this.Controls.Add(this.UsersManagmentDataGrid);
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
            this.Name = "UsersScreen";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "UsersScreen";
            this.Load += new System.EventHandler(this.UsersScreen_Load);
            ((System.ComponentModel.ISupportInitialize)(this.UsersManagmentDataGrid)).EndInit();
            this.UsersMenu.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.guna2PictureBox1)).EndInit();
            this.grbGender.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();
        }

        private System.Windows.Forms.ToolStripMenuItem showUserDetailsToolStripMenuItem;

        private System.Windows.Forms.ContextMenuStrip UsersMenu;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem editToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem deleteToolStripMenuItem;

        private Guna.UI2.WinForms.Guna2HtmlLabel guna2HtmlLabel2;

        private Guna.UI2.WinForms.Guna2Button guna2Button1;

        private Guna.UI2.WinForms.Guna2TextBox txtFilter;
        private Guna.UI2.WinForms.Guna2DataGridView UsersManagmentDataGrid;
        private Guna.UI2.WinForms.Guna2Button btnAddNewBook;
        private Guna.UI2.WinForms.Guna2DateTimePicker DtimerFrom;
        private Guna.UI2.WinForms.Guna2DateTimePicker DttimeTo;
        private Guna.UI2.WinForms.Guna2ComboBox cbFilter;
        private Guna.UI2.WinForms.Guna2HtmlLabel guna2HtmlLabel5;
        private Guna.UI2.WinForms.Guna2HtmlLabel guna2HtmlLabel4;
        private Guna.UI2.WinForms.Guna2HtmlLabel guna2HtmlLabel3;
        private Guna.UI2.WinForms.Guna2HtmlLabel guna2HtmlLabel1;
        private Guna.UI2.WinForms.Guna2PictureBox guna2PictureBox1;
        private System.Windows.Forms.GroupBox grbGender;
        private Guna.UI2.WinForms.Guna2RadioButton rdMale;
        private Guna.UI2.WinForms.Guna2RadioButton rdFemale;

        private Guna.UI2.WinForms.Guna2ControlBox guna2ControlBox2;
        private Guna.UI2.WinForms.Guna2ControlBox guna2ControlBox1;

        #endregion
    }
}