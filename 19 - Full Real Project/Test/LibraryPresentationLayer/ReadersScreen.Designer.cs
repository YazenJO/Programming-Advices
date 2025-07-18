using System.ComponentModel;

namespace Test
{
    partial class ReadersScreen
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
            this.ReadersManagmentDataGrid = new Guna.UI2.WinForms.Guna2DataGridView();
            this.ReaderMenu = new System.Windows.Forms.ContextMenuStrip(this.components);
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
            this.toolStripAddReader = new System.Windows.Forms.ToolStripMenuItem();
            ((System.ComponentModel.ISupportInitialize)(this.ReadersManagmentDataGrid)).BeginInit();
            this.ReaderMenu.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.guna2PictureBox1)).BeginInit();
            this.grbGender.SuspendLayout();
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
            this.txtFilter.Location = new System.Drawing.Point(278, 351);
            this.txtFilter.Name = "txtFilter";
            this.txtFilter.PasswordChar = '\0';
            this.txtFilter.PlaceholderText = "";
            this.txtFilter.SelectedText = "";
            this.txtFilter.ShadowDecoration.Parent = this.txtFilter;
            this.txtFilter.Size = new System.Drawing.Size(200, 36);
            this.txtFilter.TabIndex = 52;
            this.txtFilter.Visible = false;
            this.txtFilter.TextChanged += new System.EventHandler(this.txtFilter_TextChanged);
            // 
            // ReadersManagmentDataGrid
            // 
            this.ReadersManagmentDataGrid.AllowUserToAddRows = false;
            this.ReadersManagmentDataGrid.AllowUserToDeleteRows = false;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.White;
            this.ReadersManagmentDataGrid.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.ReadersManagmentDataGrid.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.ReadersManagmentDataGrid.BackgroundColor = System.Drawing.Color.White;
            this.ReadersManagmentDataGrid.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.ReadersManagmentDataGrid.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.ReadersManagmentDataGrid.ClipboardCopyMode = System.Windows.Forms.DataGridViewClipboardCopyMode.EnableAlwaysIncludeHeaderText;
            this.ReadersManagmentDataGrid.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Sunken;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI", 10.5F);
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.ReadersManagmentDataGrid.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.ReadersManagmentDataGrid.ColumnHeadersHeight = 25;
            this.ReadersManagmentDataGrid.ContextMenuStrip = this.ReaderMenu;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Segoe UI", 10.5F);
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.ReadersManagmentDataGrid.DefaultCellStyle = dataGridViewCellStyle3;
            this.ReadersManagmentDataGrid.EnableHeadersVisualStyles = false;
            this.ReadersManagmentDataGrid.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.ReadersManagmentDataGrid.Location = new System.Drawing.Point(19, 419);
            this.ReadersManagmentDataGrid.Name = "ReadersManagmentDataGrid";
            this.ReadersManagmentDataGrid.ReadOnly = true;
            this.ReadersManagmentDataGrid.RowHeadersVisible = false;
            this.ReadersManagmentDataGrid.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.ReadersManagmentDataGrid.Size = new System.Drawing.Size(1404, 360);
            this.ReadersManagmentDataGrid.TabIndex = 51;
            this.ReadersManagmentDataGrid.Theme = Guna.UI2.WinForms.Enums.DataGridViewPresetThemes.Default;
            this.ReadersManagmentDataGrid.ThemeStyle.AlternatingRowsStyle.BackColor = System.Drawing.Color.White;
            this.ReadersManagmentDataGrid.ThemeStyle.AlternatingRowsStyle.Font = null;
            this.ReadersManagmentDataGrid.ThemeStyle.AlternatingRowsStyle.ForeColor = System.Drawing.Color.Empty;
            this.ReadersManagmentDataGrid.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = System.Drawing.Color.Empty;
            this.ReadersManagmentDataGrid.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = System.Drawing.Color.Empty;
            this.ReadersManagmentDataGrid.ThemeStyle.BackColor = System.Drawing.Color.White;
            this.ReadersManagmentDataGrid.ThemeStyle.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.ReadersManagmentDataGrid.ThemeStyle.HeaderStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.ReadersManagmentDataGrid.ThemeStyle.HeaderStyle.BorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Sunken;
            this.ReadersManagmentDataGrid.ThemeStyle.HeaderStyle.Font = new System.Drawing.Font("Segoe UI", 10.5F);
            this.ReadersManagmentDataGrid.ThemeStyle.HeaderStyle.ForeColor = System.Drawing.Color.White;
            this.ReadersManagmentDataGrid.ThemeStyle.HeaderStyle.HeaightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            this.ReadersManagmentDataGrid.ThemeStyle.HeaderStyle.Height = 25;
            this.ReadersManagmentDataGrid.ThemeStyle.ReadOnly = true;
            this.ReadersManagmentDataGrid.ThemeStyle.RowsStyle.BackColor = System.Drawing.Color.White;
            this.ReadersManagmentDataGrid.ThemeStyle.RowsStyle.BorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.ReadersManagmentDataGrid.ThemeStyle.RowsStyle.Font = new System.Drawing.Font("Segoe UI", 10.5F);
            this.ReadersManagmentDataGrid.ThemeStyle.RowsStyle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            this.ReadersManagmentDataGrid.ThemeStyle.RowsStyle.Height = 22;
            this.ReadersManagmentDataGrid.ThemeStyle.RowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.ReadersManagmentDataGrid.ThemeStyle.RowsStyle.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            // 
            // ReaderMenu
            // 
            this.ReaderMenu.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ReaderMenu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] { this.toolStripMenuItem1, this.editToolStripMenuItem, this.deleteToolStripMenuItem });
            this.ReaderMenu.Name = "contextMenuStrip1";
            this.ReaderMenu.Size = new System.Drawing.Size(243, 106);
            this.ReaderMenu.Text = "contextMenuStrip1";
            // 
            // toolStripMenuItem1
            // 
            this.toolStripMenuItem1.Image = global::Test.Properties.Resources.Add_Image_iconReader;
            this.toolStripMenuItem1.Name = "toolStripMenuItem1";
            this.toolStripMenuItem1.Size = new System.Drawing.Size(242, 34);
            this.toolStripMenuItem1.Text = "Add New Reader";
            this.toolStripMenuItem1.Click += new System.EventHandler(this.toolStripMenuItem1_Click);
            // 
            // editToolStripMenuItem
            // 
            this.editToolStripMenuItem.Image = global::Test.Properties.Resources.Edit_icon1;
            this.editToolStripMenuItem.Name = "editToolStripMenuItem";
            this.editToolStripMenuItem.Size = new System.Drawing.Size(242, 34);
            this.editToolStripMenuItem.Text = "Edit";
            this.editToolStripMenuItem.Click += new System.EventHandler(this.editToolStripMenuItem_Click);
            // 
            // deleteToolStripMenuItem
            // 
            this.deleteToolStripMenuItem.Image = global::Test.Properties.Resources.Delete_Book;
            this.deleteToolStripMenuItem.Name = "deleteToolStripMenuItem";
            this.deleteToolStripMenuItem.Size = new System.Drawing.Size(242, 34);
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
            this.btnAddNewBook.Image = global::Test.Properties.Resources.Add_Readers;
            this.btnAddNewBook.ImageSize = new System.Drawing.Size(50, 50);
            this.btnAddNewBook.Location = new System.Drawing.Point(1322, 351);
            this.btnAddNewBook.Name = "btnAddNewBook";
            this.btnAddNewBook.ShadowDecoration.Parent = this.btnAddNewBook;
            this.btnAddNewBook.Size = new System.Drawing.Size(94, 45);
            this.btnAddNewBook.TabIndex = 50;
            this.btnAddNewBook.Click += new System.EventHandler(this.btnAddNewBook_Click);
            // 
            // DtimerFrom
            // 
            this.DtimerFrom.BorderRadius = 8;
            this.DtimerFrom.CheckedState.Parent = this.DtimerFrom;
            this.DtimerFrom.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(107)))), ((int)(((byte)(106)))), ((int)(((byte)(173)))));
            this.DtimerFrom.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.DtimerFrom.HoverState.Parent = this.DtimerFrom;
            this.DtimerFrom.Location = new System.Drawing.Point(1009, 360);
            this.DtimerFrom.MaxDate = new System.DateTime(9998, 12, 31, 0, 0, 0, 0);
            this.DtimerFrom.MinDate = new System.DateTime(1753, 1, 1, 0, 0, 0, 0);
            this.DtimerFrom.Name = "DtimerFrom";
            this.DtimerFrom.ShadowDecoration.Parent = this.DtimerFrom;
            this.DtimerFrom.Size = new System.Drawing.Size(106, 36);
            this.DtimerFrom.TabIndex = 49;
            this.DtimerFrom.Value = new System.DateTime(2025, 2, 3, 22, 13, 39, 415);
            this.DtimerFrom.ValueChanged += new System.EventHandler(this.DtimerFrom_ValueChanged_1);
            // 
            // DttimeTo
            // 
            this.DttimeTo.BorderRadius = 8;
            this.DttimeTo.CheckedState.Parent = this.DttimeTo;
            this.DttimeTo.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(107)))), ((int)(((byte)(106)))), ((int)(((byte)(173)))));
            this.DttimeTo.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.DttimeTo.HoverState.Parent = this.DttimeTo;
            this.DttimeTo.Location = new System.Drawing.Point(1191, 360);
            this.DttimeTo.MaxDate = new System.DateTime(9998, 12, 31, 0, 0, 0, 0);
            this.DttimeTo.MinDate = new System.DateTime(1753, 1, 1, 0, 0, 0, 0);
            this.DttimeTo.Name = "DttimeTo";
            this.DttimeTo.ShadowDecoration.Parent = this.DttimeTo;
            this.DttimeTo.Size = new System.Drawing.Size(106, 36);
            this.DttimeTo.TabIndex = 48;
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
            this.cbFilter.Items.AddRange(new object[] { "None", "Name", "Email", "MobileNumber", "Gender", "Address" });
            this.cbFilter.ItemsAppearance.Parent = this.cbFilter;
            this.cbFilter.Location = new System.Drawing.Point(123, 351);
            this.cbFilter.Name = "cbFilter";
            this.cbFilter.ShadowDecoration.Parent = this.cbFilter;
            this.cbFilter.Size = new System.Drawing.Size(140, 36);
            this.cbFilter.TabIndex = 46;
            this.cbFilter.SelectedIndexChanged += new System.EventHandler(this.cbFilter_SelectedIndexChanged);
            // 
            // guna2HtmlLabel5
            // 
            this.guna2HtmlLabel5.BackColor = System.Drawing.Color.Transparent;
            this.guna2HtmlLabel5.Font = new System.Drawing.Font("Yu Gothic", 27.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.guna2HtmlLabel5.ForeColor = System.Drawing.Color.DarkBlue;
            this.guna2HtmlLabel5.Location = new System.Drawing.Point(537, 265);
            this.guna2HtmlLabel5.Name = "guna2HtmlLabel5";
            this.guna2HtmlLabel5.Size = new System.Drawing.Size(381, 50);
            this.guna2HtmlLabel5.TabIndex = 45;
            this.guna2HtmlLabel5.Text = "Readers Managment";
            // 
            // guna2HtmlLabel4
            // 
            this.guna2HtmlLabel4.BackColor = System.Drawing.Color.Transparent;
            this.guna2HtmlLabel4.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.guna2HtmlLabel4.ForeColor = System.Drawing.Color.DarkBlue;
            this.guna2HtmlLabel4.Location = new System.Drawing.Point(1144, 360);
            this.guna2HtmlLabel4.Name = "guna2HtmlLabel4";
            this.guna2HtmlLabel4.Size = new System.Drawing.Size(22, 27);
            this.guna2HtmlLabel4.TabIndex = 44;
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
            this.guna2HtmlLabel3.TabIndex = 43;
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
            this.guna2HtmlLabel1.TabIndex = 41;
            this.guna2HtmlLabel1.Text = "Filter by:";
            // 
            // guna2PictureBox1
            // 
            this.guna2PictureBox1.Image = global::Test.Properties.Resources.Reader_Icon;
            this.guna2PictureBox1.Location = new System.Drawing.Point(562, 29);
            this.guna2PictureBox1.Name = "guna2PictureBox1";
            this.guna2PictureBox1.ShadowDecoration.Parent = this.guna2PictureBox1;
            this.guna2PictureBox1.Size = new System.Drawing.Size(300, 200);
            this.guna2PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.guna2PictureBox1.TabIndex = 40;
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
            this.guna2ControlBox2.TabIndex = 39;
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
            this.guna2ControlBox1.TabIndex = 38;
            // 
            // grbGender
            // 
            this.grbGender.Controls.Add(this.rdMale);
            this.grbGender.Controls.Add(this.rdFemale);
            this.grbGender.Location = new System.Drawing.Point(279, 323);
            this.grbGender.Name = "grbGender";
            this.grbGender.Size = new System.Drawing.Size(200, 64);
            this.grbGender.TabIndex = 0;
            this.grbGender.TabStop = false;
            this.grbGender.Text = "Gender";
            this.grbGender.Visible = false;
            this.grbGender.Enter += new System.EventHandler(this.grbGender_Enter);
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
            this.rdFemale.CheckedChanged += new System.EventHandler(this.guna2RadioButton1_CheckedChanged);
            // 
            // toolStripAddReader
            // 
            this.toolStripAddReader.Name = "toolStripAddReader";
            this.toolStripAddReader.Size = new System.Drawing.Size(242, 34);
            this.toolStripAddReader.Text = "Add New Reader";
            this.toolStripAddReader.Click += new System.EventHandler(this.toolStripAddReader_Click);
            // 
            // ReadersScreen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1428, 798);
            this.Controls.Add(this.txtFilter);
            this.Controls.Add(this.ReadersManagmentDataGrid);
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
            this.Controls.Add(this.grbGender);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "ReadersScreen";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ReadersScreen";
            this.Load += new System.EventHandler(this.ReadersScreen_Load);
            ((System.ComponentModel.ISupportInitialize)(this.ReadersManagmentDataGrid)).EndInit();
            this.ReaderMenu.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.guna2PictureBox1)).EndInit();
            this.grbGender.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();
        }

        private System.Windows.Forms.ContextMenuStrip ReaderMenu;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem editToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem deleteToolStripMenuItem;

        private System.Windows.Forms.ToolStripMenuItem toolStripAddReader;

        private Guna.UI2.WinForms.Guna2RadioButton rdMale;

        private Guna.UI2.WinForms.Guna2RadioButton rdFemale;
        private System.Windows.Forms.GroupBox grbGender;

        private Guna.UI2.WinForms.Guna2TextBox txtFilter;
        private Guna.UI2.WinForms.Guna2DataGridView ReadersManagmentDataGrid;
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