using System.ComponentModel;

namespace Test
{
    partial class Borrows
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
            this.guna2PictureBox1 = new Guna.UI2.WinForms.Guna2PictureBox();
            this.guna2HtmlLabel1 = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.guna2HtmlLabel2 = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.guna2HtmlLabel3 = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.guna2HtmlLabel4 = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.guna2HtmlLabel5 = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.guna2ControlBox2 = new Guna.UI2.WinForms.Guna2ControlBox();
            this.guna2ControlBox1 = new Guna.UI2.WinForms.Guna2ControlBox();
            this.cbFilter = new Guna.UI2.WinForms.Guna2ComboBox();
            this.cbStatus = new Guna.UI2.WinForms.Guna2ComboBox();
            this.DttimeTo = new Guna.UI2.WinForms.Guna2DateTimePicker();
            this.DtimerFrom = new Guna.UI2.WinForms.Guna2DateTimePicker();
            this.btnAddNewBorrow = new Guna.UI2.WinForms.Guna2Button();
            this.BorrowDataGridView1 = new Guna.UI2.WinForms.Guna2DataGridView();
            this.BorrowsMenu = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.toolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.deleteToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.returnBookToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.extendDueDateToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.editToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.deleteToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.txtFilter = new Guna.UI2.WinForms.Guna2TextBox();
            this.AvailabilitySwitch = new Guna.UI2.WinForms.Guna2ToggleSwitch();
            ((System.ComponentModel.ISupportInitialize)(this.guna2PictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.BorrowDataGridView1)).BeginInit();
            this.BorrowsMenu.SuspendLayout();
            this.SuspendLayout();
            // 
            // guna2PictureBox1
            // 
            this.guna2PictureBox1.Image = global::Test.Properties.Resources.borrow_book_512px;
            this.guna2PictureBox1.Location = new System.Drawing.Point(555, 12);
            this.guna2PictureBox1.Name = "guna2PictureBox1";
            this.guna2PictureBox1.ShadowDecoration.Parent = this.guna2PictureBox1;
            this.guna2PictureBox1.Size = new System.Drawing.Size(300, 200);
            this.guna2PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.guna2PictureBox1.TabIndex = 0;
            this.guna2PictureBox1.TabStop = false;
            // 
            // guna2HtmlLabel1
            // 
            this.guna2HtmlLabel1.BackColor = System.Drawing.Color.Transparent;
            this.guna2HtmlLabel1.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.guna2HtmlLabel1.ForeColor = System.Drawing.Color.Black;
            this.guna2HtmlLabel1.Location = new System.Drawing.Point(12, 335);
            this.guna2HtmlLabel1.Name = "guna2HtmlLabel1";
            this.guna2HtmlLabel1.Size = new System.Drawing.Size(80, 27);
            this.guna2HtmlLabel1.TabIndex = 1;
            this.guna2HtmlLabel1.Text = "Filter by:";
            // 
            // guna2HtmlLabel2
            // 
            this.guna2HtmlLabel2.BackColor = System.Drawing.Color.Transparent;
            this.guna2HtmlLabel2.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.guna2HtmlLabel2.ForeColor = System.Drawing.Color.Black;
            this.guna2HtmlLabel2.Location = new System.Drawing.Point(481, 335);
            this.guna2HtmlLabel2.Name = "guna2HtmlLabel2";
            this.guna2HtmlLabel2.Size = new System.Drawing.Size(68, 27);
            this.guna2HtmlLabel2.TabIndex = 2;
            this.guna2HtmlLabel2.Text = "Status :";
            // 
            // guna2HtmlLabel3
            // 
            this.guna2HtmlLabel3.BackColor = System.Drawing.Color.Transparent;
            this.guna2HtmlLabel3.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.guna2HtmlLabel3.ForeColor = System.Drawing.Color.Black;
            this.guna2HtmlLabel3.Location = new System.Drawing.Point(755, 335);
            this.guna2HtmlLabel3.Name = "guna2HtmlLabel3";
            this.guna2HtmlLabel3.Size = new System.Drawing.Size(132, 27);
            this.guna2HtmlLabel3.TabIndex = 3;
            this.guna2HtmlLabel3.Text = "Borrows from:";
            // 
            // guna2HtmlLabel4
            // 
            this.guna2HtmlLabel4.BackColor = System.Drawing.Color.Transparent;
            this.guna2HtmlLabel4.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.guna2HtmlLabel4.ForeColor = System.Drawing.Color.Black;
            this.guna2HtmlLabel4.Location = new System.Drawing.Point(1046, 335);
            this.guna2HtmlLabel4.Name = "guna2HtmlLabel4";
            this.guna2HtmlLabel4.Size = new System.Drawing.Size(22, 27);
            this.guna2HtmlLabel4.TabIndex = 4;
            this.guna2HtmlLabel4.Text = "to ";
            // 
            // guna2HtmlLabel5
            // 
            this.guna2HtmlLabel5.BackColor = System.Drawing.Color.Transparent;
            this.guna2HtmlLabel5.Font = new System.Drawing.Font("Yu Gothic", 27.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.guna2HtmlLabel5.ForeColor = System.Drawing.Color.Black;
            this.guna2HtmlLabel5.Location = new System.Drawing.Point(568, 247);
            this.guna2HtmlLabel5.Name = "guna2HtmlLabel5";
            this.guna2HtmlLabel5.Size = new System.Drawing.Size(276, 50);
            this.guna2HtmlLabel5.TabIndex = 5;
            this.guna2HtmlLabel5.Text = "Books Borrows";
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
            this.guna2ControlBox2.Location = new System.Drawing.Point(1330, 12);
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
            this.guna2ControlBox1.Location = new System.Drawing.Point(1380, 12);
            this.guna2ControlBox1.Name = "guna2ControlBox1";
            this.guna2ControlBox1.ShadowDecoration.Parent = this.guna2ControlBox1;
            this.guna2ControlBox1.Size = new System.Drawing.Size(33, 36);
            this.guna2ControlBox1.TabIndex = 12;
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
            this.cbFilter.Items.AddRange(new object[] { "None", "Title ", "Genre", "Book Nubmer", "Availability" });
            this.cbFilter.ItemsAppearance.Parent = this.cbFilter;
            this.cbFilter.Location = new System.Drawing.Point(98, 335);
            this.cbFilter.Name = "cbFilter";
            this.cbFilter.ShadowDecoration.Parent = this.cbFilter;
            this.cbFilter.Size = new System.Drawing.Size(140, 36);
            this.cbFilter.TabIndex = 15;
            this.cbFilter.SelectedIndexChanged += new System.EventHandler(this.cbFilter_SelectedIndexChanged);
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
            this.cbStatus.Items.AddRange(new object[] { "None", "Borrowed -  On Time", "Borrowed -  OverDue" });
            this.cbStatus.ItemsAppearance.Parent = this.cbStatus;
            this.cbStatus.Location = new System.Drawing.Point(555, 335);
            this.cbStatus.Name = "cbStatus";
            this.cbStatus.ShadowDecoration.Parent = this.cbStatus;
            this.cbStatus.Size = new System.Drawing.Size(176, 36);
            this.cbStatus.TabIndex = 16;
            this.cbStatus.SelectedIndexChanged += new System.EventHandler(this.cbStatus_SelectedIndexChanged);
            // 
            // DttimeTo
            // 
            this.DttimeTo.CheckedState.Parent = this.DttimeTo;
            this.DttimeTo.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(202)))), ((int)(((byte)(158)))), ((int)(((byte)(167)))));
            this.DttimeTo.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.DttimeTo.HoverState.Parent = this.DttimeTo;
            this.DttimeTo.Location = new System.Drawing.Point(1093, 335);
            this.DttimeTo.MaxDate = new System.DateTime(9998, 12, 31, 0, 0, 0, 0);
            this.DttimeTo.MinDate = new System.DateTime(1753, 1, 1, 0, 0, 0, 0);
            this.DttimeTo.Name = "DttimeTo";
            this.DttimeTo.ShadowDecoration.Parent = this.DttimeTo;
            this.DttimeTo.Size = new System.Drawing.Size(106, 36);
            this.DttimeTo.TabIndex = 18;
            this.DttimeTo.Value = new System.DateTime(2025, 2, 3, 22, 13, 39, 415);
            this.DttimeTo.ValueChanged += new System.EventHandler(this.DttimeTo_ValueChanged);
            // 
            // DtimerFrom
            // 
            this.DtimerFrom.CheckedState.Parent = this.DtimerFrom;
            this.DtimerFrom.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(202)))), ((int)(((byte)(158)))), ((int)(((byte)(167)))));
            this.DtimerFrom.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.DtimerFrom.HoverState.Parent = this.DtimerFrom;
            this.DtimerFrom.Location = new System.Drawing.Point(911, 335);
            this.DtimerFrom.MaxDate = new System.DateTime(9998, 12, 31, 0, 0, 0, 0);
            this.DtimerFrom.MinDate = new System.DateTime(1753, 1, 1, 0, 0, 0, 0);
            this.DtimerFrom.Name = "DtimerFrom";
            this.DtimerFrom.ShadowDecoration.Parent = this.DtimerFrom;
            this.DtimerFrom.Size = new System.Drawing.Size(106, 36);
            this.DtimerFrom.TabIndex = 19;
            this.DtimerFrom.Value = new System.DateTime(2025, 2, 3, 22, 13, 39, 415);
            this.DtimerFrom.ValueChanged += new System.EventHandler(this.DtimerFrom_ValueChanged);
            // 
            // btnAddNewBorrow
            // 
            this.btnAddNewBorrow.CheckedState.Parent = this.btnAddNewBorrow;
            this.btnAddNewBorrow.CustomImages.Parent = this.btnAddNewBorrow;
            this.btnAddNewBorrow.FillColor = System.Drawing.Color.White;
            this.btnAddNewBorrow.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btnAddNewBorrow.ForeColor = System.Drawing.Color.White;
            this.btnAddNewBorrow.HoverState.Parent = this.btnAddNewBorrow;
            this.btnAddNewBorrow.Image = global::Test.Properties.Resources.Add;
            this.btnAddNewBorrow.ImageSize = new System.Drawing.Size(40, 40);
            this.btnAddNewBorrow.Location = new System.Drawing.Point(1322, 335);
            this.btnAddNewBorrow.Name = "btnAddNewBorrow";
            this.btnAddNewBorrow.ShadowDecoration.Parent = this.btnAddNewBorrow;
            this.btnAddNewBorrow.Size = new System.Drawing.Size(94, 45);
            this.btnAddNewBorrow.TabIndex = 20;
            this.btnAddNewBorrow.Click += new System.EventHandler(this.btnAddNewBorrow_Click);
            // 
            // BorrowDataGridView1
            // 
            this.BorrowDataGridView1.AllowUserToAddRows = false;
            this.BorrowDataGridView1.AllowUserToDeleteRows = false;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.White;
            this.BorrowDataGridView1.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.BorrowDataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.BorrowDataGridView1.BackgroundColor = System.Drawing.Color.White;
            this.BorrowDataGridView1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.BorrowDataGridView1.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.BorrowDataGridView1.ClipboardCopyMode = System.Windows.Forms.DataGridViewClipboardCopyMode.EnableAlwaysIncludeHeaderText;
            this.BorrowDataGridView1.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Sunken;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI", 10.5F);
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.BorrowDataGridView1.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.BorrowDataGridView1.ColumnHeadersHeight = 25;
            this.BorrowDataGridView1.ContextMenuStrip = this.BorrowsMenu;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Segoe UI", 10.5F);
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.BorrowDataGridView1.DefaultCellStyle = dataGridViewCellStyle3;
            this.BorrowDataGridView1.EnableHeadersVisualStyles = false;
            this.BorrowDataGridView1.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.BorrowDataGridView1.Location = new System.Drawing.Point(12, 403);
            this.BorrowDataGridView1.Name = "BorrowDataGridView1";
            this.BorrowDataGridView1.ReadOnly = true;
            this.BorrowDataGridView1.RowHeadersVisible = false;
            this.BorrowDataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.BorrowDataGridView1.Size = new System.Drawing.Size(1404, 360);
            this.BorrowDataGridView1.TabIndex = 21;
            this.BorrowDataGridView1.Theme = Guna.UI2.WinForms.Enums.DataGridViewPresetThemes.Default;
            this.BorrowDataGridView1.ThemeStyle.AlternatingRowsStyle.BackColor = System.Drawing.Color.White;
            this.BorrowDataGridView1.ThemeStyle.AlternatingRowsStyle.Font = null;
            this.BorrowDataGridView1.ThemeStyle.AlternatingRowsStyle.ForeColor = System.Drawing.Color.Empty;
            this.BorrowDataGridView1.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = System.Drawing.Color.Empty;
            this.BorrowDataGridView1.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = System.Drawing.Color.Empty;
            this.BorrowDataGridView1.ThemeStyle.BackColor = System.Drawing.Color.White;
            this.BorrowDataGridView1.ThemeStyle.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.BorrowDataGridView1.ThemeStyle.HeaderStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.BorrowDataGridView1.ThemeStyle.HeaderStyle.BorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Sunken;
            this.BorrowDataGridView1.ThemeStyle.HeaderStyle.Font = new System.Drawing.Font("Segoe UI", 10.5F);
            this.BorrowDataGridView1.ThemeStyle.HeaderStyle.ForeColor = System.Drawing.Color.White;
            this.BorrowDataGridView1.ThemeStyle.HeaderStyle.HeaightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            this.BorrowDataGridView1.ThemeStyle.HeaderStyle.Height = 25;
            this.BorrowDataGridView1.ThemeStyle.ReadOnly = true;
            this.BorrowDataGridView1.ThemeStyle.RowsStyle.BackColor = System.Drawing.Color.White;
            this.BorrowDataGridView1.ThemeStyle.RowsStyle.BorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.BorrowDataGridView1.ThemeStyle.RowsStyle.Font = new System.Drawing.Font("Segoe UI", 10.5F);
            this.BorrowDataGridView1.ThemeStyle.RowsStyle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            this.BorrowDataGridView1.ThemeStyle.RowsStyle.Height = 22;
            this.BorrowDataGridView1.ThemeStyle.RowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.BorrowDataGridView1.ThemeStyle.RowsStyle.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            // 
            // BorrowsMenu
            // 
            this.BorrowsMenu.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BorrowsMenu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] { this.toolStripMenuItem1, this.deleteToolStripMenuItem, this.returnBookToolStripMenuItem, this.extendDueDateToolStripMenuItem, this.editToolStripMenuItem, this.deleteToolStripMenuItem1 });
            this.BorrowsMenu.Name = "contextMenuStrip1";
            this.BorrowsMenu.Size = new System.Drawing.Size(228, 206);
            this.BorrowsMenu.Text = "BorrowsMenu";
            // 
            // toolStripMenuItem1
            // 
            this.toolStripMenuItem1.Image = global::Test.Properties.Resources.Add_New_Borrow;
            this.toolStripMenuItem1.Name = "toolStripMenuItem1";
            this.toolStripMenuItem1.Size = new System.Drawing.Size(227, 30);
            this.toolStripMenuItem1.Text = "Add New Borrow";
            this.toolStripMenuItem1.Click += new System.EventHandler(this.toolStripMenuItem1_Click);
            // 
            // deleteToolStripMenuItem
            // 
            this.deleteToolStripMenuItem.Image = global::Test.Properties.Resources.help__icon;
            this.deleteToolStripMenuItem.Name = "deleteToolStripMenuItem";
            this.deleteToolStripMenuItem.Size = new System.Drawing.Size(227, 30);
            this.deleteToolStripMenuItem.Text = "Show Details";
            this.deleteToolStripMenuItem.Click += new System.EventHandler(this.deleteToolStripMenuItem_Click);
            // 
            // returnBookToolStripMenuItem
            // 
            this.returnBookToolStripMenuItem.Image = global::Test.Properties.Resources.Return_Book_icon;
            this.returnBookToolStripMenuItem.Name = "returnBookToolStripMenuItem";
            this.returnBookToolStripMenuItem.Size = new System.Drawing.Size(227, 30);
            this.returnBookToolStripMenuItem.Text = "Return Book";
            this.returnBookToolStripMenuItem.Click += new System.EventHandler(this.returnBookToolStripMenuItem_Click);
            // 
            // extendDueDateToolStripMenuItem
            // 
            this.extendDueDateToolStripMenuItem.Image = global::Test.Properties.Resources.Extend_icon;
            this.extendDueDateToolStripMenuItem.Name = "extendDueDateToolStripMenuItem";
            this.extendDueDateToolStripMenuItem.Size = new System.Drawing.Size(227, 30);
            this.extendDueDateToolStripMenuItem.Text = "Extend due date";
            this.extendDueDateToolStripMenuItem.Click += new System.EventHandler(this.extendDueDateToolStripMenuItem_Click);
            // 
            // editToolStripMenuItem
            // 
            this.editToolStripMenuItem.Image = global::Test.Properties.Resources.Edit_icon;
            this.editToolStripMenuItem.Name = "editToolStripMenuItem";
            this.editToolStripMenuItem.Size = new System.Drawing.Size(227, 30);
            this.editToolStripMenuItem.Text = "Edit";
            this.editToolStripMenuItem.Click += new System.EventHandler(this.editToolStripMenuItem_Click);
            // 
            // deleteToolStripMenuItem1
            // 
            this.deleteToolStripMenuItem1.Image = global::Test.Properties.Resources.Delete_Book;
            this.deleteToolStripMenuItem1.Name = "deleteToolStripMenuItem1";
            this.deleteToolStripMenuItem1.Size = new System.Drawing.Size(227, 30);
            this.deleteToolStripMenuItem1.Text = "Delete";
            this.deleteToolStripMenuItem1.Click += new System.EventHandler(this.deleteToolStripMenuItem1_Click);
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
            this.txtFilter.Location = new System.Drawing.Point(253, 335);
            this.txtFilter.Name = "txtFilter";
            this.txtFilter.PasswordChar = '\0';
            this.txtFilter.PlaceholderText = "";
            this.txtFilter.SelectedText = "";
            this.txtFilter.ShadowDecoration.Parent = this.txtFilter;
            this.txtFilter.Size = new System.Drawing.Size(200, 36);
            this.txtFilter.TabIndex = 22;
            this.txtFilter.Visible = false;
            this.txtFilter.TextChanged += new System.EventHandler(this.txtFilter_TextChanged);
            // 
            // AvailabilitySwitch
            // 
            this.AvailabilitySwitch.CheckedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.AvailabilitySwitch.CheckedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.AvailabilitySwitch.CheckedState.InnerBorderColor = System.Drawing.Color.White;
            this.AvailabilitySwitch.CheckedState.InnerColor = System.Drawing.Color.White;
            this.AvailabilitySwitch.CheckedState.Parent = this.AvailabilitySwitch;
            this.AvailabilitySwitch.Location = new System.Drawing.Point(275, 342);
            this.AvailabilitySwitch.Name = "AvailabilitySwitch";
            this.AvailabilitySwitch.ShadowDecoration.Parent = this.AvailabilitySwitch;
            this.AvailabilitySwitch.Size = new System.Drawing.Size(35, 20);
            this.AvailabilitySwitch.TabIndex = 23;
            this.AvailabilitySwitch.UncheckedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(125)))), ((int)(((byte)(137)))), ((int)(((byte)(149)))));
            this.AvailabilitySwitch.UncheckedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(125)))), ((int)(((byte)(137)))), ((int)(((byte)(149)))));
            this.AvailabilitySwitch.UncheckedState.InnerBorderColor = System.Drawing.Color.White;
            this.AvailabilitySwitch.UncheckedState.InnerColor = System.Drawing.Color.White;
            this.AvailabilitySwitch.UncheckedState.Parent = this.AvailabilitySwitch;
            this.AvailabilitySwitch.Visible = false;
            this.AvailabilitySwitch.CheckedChanged += new System.EventHandler(this.AvailabilitySwitch_CheckedChanged);
            // 
            // Borrows
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(1428, 762);
            this.Controls.Add(this.AvailabilitySwitch);
            this.Controls.Add(this.txtFilter);
            this.Controls.Add(this.BorrowDataGridView1);
            this.Controls.Add(this.btnAddNewBorrow);
            this.Controls.Add(this.DtimerFrom);
            this.Controls.Add(this.DttimeTo);
            this.Controls.Add(this.cbStatus);
            this.Controls.Add(this.cbFilter);
            this.Controls.Add(this.guna2ControlBox2);
            this.Controls.Add(this.guna2ControlBox1);
            this.Controls.Add(this.guna2HtmlLabel5);
            this.Controls.Add(this.guna2HtmlLabel4);
            this.Controls.Add(this.guna2HtmlLabel3);
            this.Controls.Add(this.guna2HtmlLabel2);
            this.Controls.Add(this.guna2HtmlLabel1);
            this.Controls.Add(this.guna2PictureBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Location = new System.Drawing.Point(15, 15);
            this.Name = "Borrows";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Load += new System.EventHandler(this.Borrows_Load);
            ((System.ComponentModel.ISupportInitialize)(this.guna2PictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.BorrowDataGridView1)).EndInit();
            this.BorrowsMenu.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();
        }

        private System.Windows.Forms.ToolStripMenuItem deleteToolStripMenuItem1;

        private Guna.UI2.WinForms.Guna2ToggleSwitch AvailabilitySwitch;

        private System.Windows.Forms.ToolStripMenuItem editToolStripMenuItem;

        private System.Windows.Forms.ToolStripMenuItem extendDueDateToolStripMenuItem;

        private System.Windows.Forms.ToolStripMenuItem returnBookToolStripMenuItem;

        private System.Windows.Forms.ContextMenuStrip BorrowsMenu;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem deleteToolStripMenuItem;

        private System.Windows.Forms.DataGridView dataGridView1;


        private Guna.UI2.WinForms.Guna2TextBox txtFilter;

        private Guna.UI2.WinForms.Guna2DataGridView BorrowDataGridView1;


        private Guna.UI2.WinForms.Guna2Button btnAddNewBorrow;

        private Guna.UI2.WinForms.Guna2DateTimePicker DtimerFrom;

        private Guna.UI2.WinForms.Guna2DateTimePicker DttimeTo;

        private Guna.UI2.WinForms.Guna2ComboBox cbFilter;
        private Guna.UI2.WinForms.Guna2ComboBox cbStatus;

        private Guna.UI2.WinForms.Guna2ComboBox cbBorrows;

        private Guna.UI2.WinForms.Guna2ControlBox guna2ControlBox2;
        private Guna.UI2.WinForms.Guna2ControlBox guna2ControlBox1;

        private Guna.UI2.WinForms.Guna2HtmlLabel guna2HtmlLabel5;

        private Guna.UI2.WinForms.Guna2HtmlLabel guna2HtmlLabel2;
        private Guna.UI2.WinForms.Guna2HtmlLabel guna2HtmlLabel3;
        private Guna.UI2.WinForms.Guna2HtmlLabel guna2HtmlLabel4;

        private Guna.UI2.WinForms.Guna2HtmlLabel guna2HtmlLabel1;

        private Guna.UI2.WinForms.Guna2PictureBox guna2PictureBox1;

        #endregion
    }
}