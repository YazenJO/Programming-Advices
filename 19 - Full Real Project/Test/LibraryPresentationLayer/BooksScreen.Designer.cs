using System.ComponentModel;

namespace Test
{
    partial class BooksScreen
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
            this.guna2ControlBox2 = new Guna.UI2.WinForms.Guna2ControlBox();
            this.guna2ControlBox1 = new Guna.UI2.WinForms.Guna2ControlBox();
            this.AvailabilitySwitch = new Guna.UI2.WinForms.Guna2ToggleSwitch();
            this.txtFilter = new Guna.UI2.WinForms.Guna2TextBox();
            this.BooksManagmentDataGrid = new Guna.UI2.WinForms.Guna2DataGridView();
            this.BooksMenu = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.toolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.editToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.deleteToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.btnAddNewBook = new Guna.UI2.WinForms.Guna2Button();
            this.DtimerFrom = new Guna.UI2.WinForms.Guna2DateTimePicker();
            this.DttimeTo = new Guna.UI2.WinForms.Guna2DateTimePicker();
            this.cbStatus = new Guna.UI2.WinForms.Guna2ComboBox();
            this.cbFilter = new Guna.UI2.WinForms.Guna2ComboBox();
            this.guna2HtmlLabel5 = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.guna2HtmlLabel4 = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.guna2HtmlLabel3 = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.guna2HtmlLabel2 = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.guna2HtmlLabel1 = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.guna2PictureBox1 = new Guna.UI2.WinForms.Guna2PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.BooksManagmentDataGrid)).BeginInit();
            this.BooksMenu.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.guna2PictureBox1)).BeginInit();
            this.SuspendLayout();
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
            this.guna2ControlBox2.TabIndex = 13;
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
            this.guna2ControlBox1.TabIndex = 12;
            // 
            // AvailabilitySwitch
            // 
            this.AvailabilitySwitch.CheckedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.AvailabilitySwitch.CheckedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.AvailabilitySwitch.CheckedState.InnerBorderColor = System.Drawing.Color.White;
            this.AvailabilitySwitch.CheckedState.InnerColor = System.Drawing.Color.White;
            this.AvailabilitySwitch.CheckedState.Parent = this.AvailabilitySwitch;
            this.AvailabilitySwitch.Location = new System.Drawing.Point(300, 358);
            this.AvailabilitySwitch.Name = "AvailabilitySwitch";
            this.AvailabilitySwitch.ShadowDecoration.Parent = this.AvailabilitySwitch;
            this.AvailabilitySwitch.Size = new System.Drawing.Size(35, 20);
            this.AvailabilitySwitch.TabIndex = 37;
            this.AvailabilitySwitch.UncheckedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(125)))), ((int)(((byte)(137)))), ((int)(((byte)(149)))));
            this.AvailabilitySwitch.UncheckedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(125)))), ((int)(((byte)(137)))), ((int)(((byte)(149)))));
            this.AvailabilitySwitch.UncheckedState.InnerBorderColor = System.Drawing.Color.White;
            this.AvailabilitySwitch.UncheckedState.InnerColor = System.Drawing.Color.White;
            this.AvailabilitySwitch.UncheckedState.Parent = this.AvailabilitySwitch;
            this.AvailabilitySwitch.Visible = false;
            this.AvailabilitySwitch.CheckedChanged += new System.EventHandler(this.AvailabilitySwitch_CheckedChanged);
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
            this.txtFilter.TabIndex = 36;
            this.txtFilter.Visible = false;
            this.txtFilter.TextChanged += new System.EventHandler(this.txtFilter_TextChanged);
            // 
            // BooksManagmentDataGrid
            // 
            this.BooksManagmentDataGrid.AllowUserToAddRows = false;
            this.BooksManagmentDataGrid.AllowUserToDeleteRows = false;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.White;
            this.BooksManagmentDataGrid.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.BooksManagmentDataGrid.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.BooksManagmentDataGrid.BackgroundColor = System.Drawing.Color.White;
            this.BooksManagmentDataGrid.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.BooksManagmentDataGrid.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.BooksManagmentDataGrid.ClipboardCopyMode = System.Windows.Forms.DataGridViewClipboardCopyMode.EnableAlwaysIncludeHeaderText;
            this.BooksManagmentDataGrid.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Sunken;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI", 10.5F);
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.BooksManagmentDataGrid.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.BooksManagmentDataGrid.ColumnHeadersHeight = 25;
            this.BooksManagmentDataGrid.ContextMenuStrip = this.BooksMenu;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Segoe UI", 10.5F);
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.BooksManagmentDataGrid.DefaultCellStyle = dataGridViewCellStyle3;
            this.BooksManagmentDataGrid.EnableHeadersVisualStyles = false;
            this.BooksManagmentDataGrid.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.BooksManagmentDataGrid.Location = new System.Drawing.Point(19, 419);
            this.BooksManagmentDataGrid.Name = "BooksManagmentDataGrid";
            this.BooksManagmentDataGrid.ReadOnly = true;
            this.BooksManagmentDataGrid.RowHeadersVisible = false;
            this.BooksManagmentDataGrid.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.BooksManagmentDataGrid.Size = new System.Drawing.Size(1404, 360);
            this.BooksManagmentDataGrid.TabIndex = 35;
            this.BooksManagmentDataGrid.Theme = Guna.UI2.WinForms.Enums.DataGridViewPresetThemes.Default;
            this.BooksManagmentDataGrid.ThemeStyle.AlternatingRowsStyle.BackColor = System.Drawing.Color.White;
            this.BooksManagmentDataGrid.ThemeStyle.AlternatingRowsStyle.Font = null;
            this.BooksManagmentDataGrid.ThemeStyle.AlternatingRowsStyle.ForeColor = System.Drawing.Color.Empty;
            this.BooksManagmentDataGrid.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = System.Drawing.Color.Empty;
            this.BooksManagmentDataGrid.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = System.Drawing.Color.Empty;
            this.BooksManagmentDataGrid.ThemeStyle.BackColor = System.Drawing.Color.White;
            this.BooksManagmentDataGrid.ThemeStyle.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.BooksManagmentDataGrid.ThemeStyle.HeaderStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.BooksManagmentDataGrid.ThemeStyle.HeaderStyle.BorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Sunken;
            this.BooksManagmentDataGrid.ThemeStyle.HeaderStyle.Font = new System.Drawing.Font("Segoe UI", 10.5F);
            this.BooksManagmentDataGrid.ThemeStyle.HeaderStyle.ForeColor = System.Drawing.Color.White;
            this.BooksManagmentDataGrid.ThemeStyle.HeaderStyle.HeaightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            this.BooksManagmentDataGrid.ThemeStyle.HeaderStyle.Height = 25;
            this.BooksManagmentDataGrid.ThemeStyle.ReadOnly = true;
            this.BooksManagmentDataGrid.ThemeStyle.RowsStyle.BackColor = System.Drawing.Color.White;
            this.BooksManagmentDataGrid.ThemeStyle.RowsStyle.BorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.BooksManagmentDataGrid.ThemeStyle.RowsStyle.Font = new System.Drawing.Font("Segoe UI", 10.5F);
            this.BooksManagmentDataGrid.ThemeStyle.RowsStyle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            this.BooksManagmentDataGrid.ThemeStyle.RowsStyle.Height = 22;
            this.BooksManagmentDataGrid.ThemeStyle.RowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.BooksManagmentDataGrid.ThemeStyle.RowsStyle.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            // 
            // BooksMenu
            // 
            this.BooksMenu.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BooksMenu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] { this.toolStripMenuItem1, this.editToolStripMenuItem, this.deleteToolStripMenuItem });
            this.BooksMenu.Name = "contextMenuStrip1";
            this.BooksMenu.Size = new System.Drawing.Size(244, 106);
            this.BooksMenu.Text = "BooksMenu";
            // 
            // toolStripMenuItem1
            // 
            this.toolStripMenuItem1.Image = global::Test.Properties.Resources.Add_Book;
            this.toolStripMenuItem1.Name = "toolStripMenuItem1";
            this.toolStripMenuItem1.Size = new System.Drawing.Size(243, 34);
            this.toolStripMenuItem1.Text = "Add New Borrow";
            this.toolStripMenuItem1.Click += new System.EventHandler(this.toolStripMenuItem1_Click);
            // 
            // editToolStripMenuItem
            // 
            this.editToolStripMenuItem.Image = global::Test.Properties.Resources.book_Title;
            this.editToolStripMenuItem.Name = "editToolStripMenuItem";
            this.editToolStripMenuItem.Size = new System.Drawing.Size(243, 34);
            this.editToolStripMenuItem.Text = "Edit";
            this.editToolStripMenuItem.Click += new System.EventHandler(this.editToolStripMenuItem_Click);
            // 
            // deleteToolStripMenuItem
            // 
            this.deleteToolStripMenuItem.Image = global::Test.Properties.Resources.Delete_Book;
            this.deleteToolStripMenuItem.Name = "deleteToolStripMenuItem";
            this.deleteToolStripMenuItem.Size = new System.Drawing.Size(243, 34);
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
            this.btnAddNewBook.Image = global::Test.Properties.Resources.BookAdd;
            this.btnAddNewBook.ImageSize = new System.Drawing.Size(40, 40);
            this.btnAddNewBook.Location = new System.Drawing.Point(1322, 351);
            this.btnAddNewBook.Name = "btnAddNewBook";
            this.btnAddNewBook.ShadowDecoration.Parent = this.btnAddNewBook;
            this.btnAddNewBook.Size = new System.Drawing.Size(94, 45);
            this.btnAddNewBook.TabIndex = 34;
            this.btnAddNewBook.Click += new System.EventHandler(this.btnAddNewBook_Click);
            // 
            // DtimerFrom
            // 
            this.DtimerFrom.CheckedState.Parent = this.DtimerFrom;
            this.DtimerFrom.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(150)))), ((int)(((byte)(243)))));
            this.DtimerFrom.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.DtimerFrom.HoverState.Parent = this.DtimerFrom;
            this.DtimerFrom.Location = new System.Drawing.Point(1016, 351);
            this.DtimerFrom.MaxDate = new System.DateTime(9998, 12, 31, 0, 0, 0, 0);
            this.DtimerFrom.MinDate = new System.DateTime(1753, 1, 1, 0, 0, 0, 0);
            this.DtimerFrom.Name = "DtimerFrom";
            this.DtimerFrom.ShadowDecoration.Parent = this.DtimerFrom;
            this.DtimerFrom.Size = new System.Drawing.Size(106, 36);
            this.DtimerFrom.TabIndex = 33;
            this.DtimerFrom.Value = new System.DateTime(2025, 2, 3, 22, 13, 39, 415);
            this.DtimerFrom.ValueChanged += new System.EventHandler(this.DtimerFrom_ValueChanged);
            // 
            // DttimeTo
            // 
            this.DttimeTo.CheckedState.Parent = this.DttimeTo;
            this.DttimeTo.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(150)))), ((int)(((byte)(243)))));
            this.DttimeTo.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.DttimeTo.HoverState.Parent = this.DttimeTo;
            this.DttimeTo.Location = new System.Drawing.Point(1182, 351);
            this.DttimeTo.MaxDate = new System.DateTime(9998, 12, 31, 0, 0, 0, 0);
            this.DttimeTo.MinDate = new System.DateTime(1753, 1, 1, 0, 0, 0, 0);
            this.DttimeTo.Name = "DttimeTo";
            this.DttimeTo.ShadowDecoration.Parent = this.DttimeTo;
            this.DttimeTo.Size = new System.Drawing.Size(106, 36);
            this.DttimeTo.TabIndex = 32;
            this.DttimeTo.Value = new System.DateTime(2025, 2, 3, 22, 13, 39, 415);
            this.DttimeTo.ValueChanged += new System.EventHandler(this.DttimeTo_ValueChanged);
            // 
            // cbStatus
            // 
            this.cbStatus.BackColor = System.Drawing.Color.Transparent;
            this.cbStatus.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.cbStatus.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbStatus.FocusedColor = System.Drawing.Color.Empty;
            this.cbStatus.FocusedState.Parent = this.cbStatus;
            this.cbStatus.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.cbStatus.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(88)))), ((int)(((byte)(112)))));
            this.cbStatus.FormattingEnabled = true;
            this.cbStatus.HoverState.Parent = this.cbStatus;
            this.cbStatus.ItemHeight = 30;
            this.cbStatus.Items.AddRange(new object[] { "None", "Arabic ", "English" });
            this.cbStatus.ItemsAppearance.Parent = this.cbStatus;
            this.cbStatus.Location = new System.Drawing.Point(613, 351);
            this.cbStatus.Name = "cbStatus";
            this.cbStatus.ShadowDecoration.Parent = this.cbStatus;
            this.cbStatus.Size = new System.Drawing.Size(176, 36);
            this.cbStatus.TabIndex = 31;
            this.cbStatus.SelectedIndexChanged += new System.EventHandler(this.cbStatus_SelectedIndexChanged);
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
            this.cbFilter.Items.AddRange(new object[] { "None", "Title ", "Genre", "Book Nubmer", "Availability", "AuthorName" });
            this.cbFilter.ItemsAppearance.Parent = this.cbFilter;
            this.cbFilter.Location = new System.Drawing.Point(123, 351);
            this.cbFilter.Name = "cbFilter";
            this.cbFilter.ShadowDecoration.Parent = this.cbFilter;
            this.cbFilter.Size = new System.Drawing.Size(140, 36);
            this.cbFilter.TabIndex = 30;
            this.cbFilter.SelectedIndexChanged += new System.EventHandler(this.cbFilter_SelectedIndexChanged);
            // 
            // guna2HtmlLabel5
            // 
            this.guna2HtmlLabel5.BackColor = System.Drawing.Color.Transparent;
            this.guna2HtmlLabel5.Font = new System.Drawing.Font("Yu Gothic", 27.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.guna2HtmlLabel5.ForeColor = System.Drawing.Color.DarkBlue;
            this.guna2HtmlLabel5.Location = new System.Drawing.Point(537, 265);
            this.guna2HtmlLabel5.Name = "guna2HtmlLabel5";
            this.guna2HtmlLabel5.Size = new System.Drawing.Size(342, 50);
            this.guna2HtmlLabel5.TabIndex = 29;
            this.guna2HtmlLabel5.Text = "Books Managment";
            // 
            // guna2HtmlLabel4
            // 
            this.guna2HtmlLabel4.BackColor = System.Drawing.Color.Transparent;
            this.guna2HtmlLabel4.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.guna2HtmlLabel4.ForeColor = System.Drawing.Color.DarkBlue;
            this.guna2HtmlLabel4.Location = new System.Drawing.Point(1138, 351);
            this.guna2HtmlLabel4.Name = "guna2HtmlLabel4";
            this.guna2HtmlLabel4.Size = new System.Drawing.Size(26, 27);
            this.guna2HtmlLabel4.TabIndex = 28;
            this.guna2HtmlLabel4.Text = "To";
            // 
            // guna2HtmlLabel3
            // 
            this.guna2HtmlLabel3.BackColor = System.Drawing.Color.Transparent;
            this.guna2HtmlLabel3.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.guna2HtmlLabel3.ForeColor = System.Drawing.Color.DarkBlue;
            this.guna2HtmlLabel3.Location = new System.Drawing.Point(817, 351);
            this.guna2HtmlLabel3.Name = "guna2HtmlLabel3";
            this.guna2HtmlLabel3.Size = new System.Drawing.Size(193, 27);
            this.guna2HtmlLabel3.TabIndex = 27;
            this.guna2HtmlLabel3.Text = "Published Date  From:";
            // 
            // guna2HtmlLabel2
            // 
            this.guna2HtmlLabel2.BackColor = System.Drawing.Color.Transparent;
            this.guna2HtmlLabel2.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.guna2HtmlLabel2.ForeColor = System.Drawing.Color.DarkBlue;
            this.guna2HtmlLabel2.Location = new System.Drawing.Point(506, 351);
            this.guna2HtmlLabel2.Name = "guna2HtmlLabel2";
            this.guna2HtmlLabel2.Size = new System.Drawing.Size(101, 27);
            this.guna2HtmlLabel2.TabIndex = 26;
            this.guna2HtmlLabel2.Text = "Language :";
            // 
            // guna2HtmlLabel1
            // 
            this.guna2HtmlLabel1.BackColor = System.Drawing.Color.Transparent;
            this.guna2HtmlLabel1.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.guna2HtmlLabel1.ForeColor = System.Drawing.Color.DarkBlue;
            this.guna2HtmlLabel1.Location = new System.Drawing.Point(19, 351);
            this.guna2HtmlLabel1.Name = "guna2HtmlLabel1";
            this.guna2HtmlLabel1.Size = new System.Drawing.Size(80, 27);
            this.guna2HtmlLabel1.TabIndex = 25;
            this.guna2HtmlLabel1.Text = "Filter by:";
            // 
            // guna2PictureBox1
            // 
            this.guna2PictureBox1.Image = global::Test.Properties.Resources.book_shelf;
            this.guna2PictureBox1.Location = new System.Drawing.Point(562, 29);
            this.guna2PictureBox1.Name = "guna2PictureBox1";
            this.guna2PictureBox1.ShadowDecoration.Parent = this.guna2PictureBox1;
            this.guna2PictureBox1.Size = new System.Drawing.Size(300, 200);
            this.guna2PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.guna2PictureBox1.TabIndex = 24;
            this.guna2PictureBox1.TabStop = false;
            // 
            // BooksScreen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1428, 798);
            this.Controls.Add(this.AvailabilitySwitch);
            this.Controls.Add(this.txtFilter);
            this.Controls.Add(this.BooksManagmentDataGrid);
            this.Controls.Add(this.btnAddNewBook);
            this.Controls.Add(this.DtimerFrom);
            this.Controls.Add(this.DttimeTo);
            this.Controls.Add(this.cbStatus);
            this.Controls.Add(this.cbFilter);
            this.Controls.Add(this.guna2HtmlLabel5);
            this.Controls.Add(this.guna2HtmlLabel4);
            this.Controls.Add(this.guna2HtmlLabel3);
            this.Controls.Add(this.guna2HtmlLabel2);
            this.Controls.Add(this.guna2HtmlLabel1);
            this.Controls.Add(this.guna2PictureBox1);
            this.Controls.Add(this.guna2ControlBox2);
            this.Controls.Add(this.guna2ControlBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "BooksScreen";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "BooksScreen";
            this.Load += new System.EventHandler(this.BooksScreen_Load);
            ((System.ComponentModel.ISupportInitialize)(this.BooksManagmentDataGrid)).EndInit();
            this.BooksMenu.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.guna2PictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();
        }

        private System.Windows.Forms.ToolStripMenuItem deleteToolStripMenuItem;

        private System.Windows.Forms.ContextMenuStrip BooksMenu;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem editToolStripMenuItem;

        private Guna.UI2.WinForms.Guna2ToggleSwitch AvailabilitySwitch;
        private Guna.UI2.WinForms.Guna2TextBox txtFilter;
        private Guna.UI2.WinForms.Guna2DataGridView BooksManagmentDataGrid;
        private Guna.UI2.WinForms.Guna2Button btnAddNewBook;
        private Guna.UI2.WinForms.Guna2DateTimePicker DtimerFrom;
        private Guna.UI2.WinForms.Guna2DateTimePicker DttimeTo;
        private Guna.UI2.WinForms.Guna2ComboBox cbStatus;
        private Guna.UI2.WinForms.Guna2ComboBox cbFilter;
        private Guna.UI2.WinForms.Guna2HtmlLabel guna2HtmlLabel5;
        private Guna.UI2.WinForms.Guna2HtmlLabel guna2HtmlLabel4;
        private Guna.UI2.WinForms.Guna2HtmlLabel guna2HtmlLabel3;
        private Guna.UI2.WinForms.Guna2HtmlLabel guna2HtmlLabel2;
        private Guna.UI2.WinForms.Guna2HtmlLabel guna2HtmlLabel1;
        private Guna.UI2.WinForms.Guna2PictureBox guna2PictureBox1;

        private Guna.UI2.WinForms.Guna2ControlBox guna2ControlBox2;
        private Guna.UI2.WinForms.Guna2ControlBox guna2ControlBox1;

        #endregion
    }
}