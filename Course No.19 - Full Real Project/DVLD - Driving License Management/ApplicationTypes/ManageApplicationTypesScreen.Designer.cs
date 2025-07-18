namespace DVLD___Driving_License_Management
{
    partial class ManageApplicationTypesScreen
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
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            this.label1 = new System.Windows.Forms.Label();
            this.lblNOfRecords = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.guna2HtmlLabel2 = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.ManageAppTypesMenu = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.btnClose = new Guna.UI2.WinForms.Guna2Button();
            this.editToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.ManageApplicationTypesList = new Guna.UI2.WinForms.Guna2DataGridView();
            this.ManageAppTypesMenu.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ManageApplicationTypesList)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Firebrick;
            this.label1.Location = new System.Drawing.Point(127, 234);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(381, 40);
            this.label1.TabIndex = 1;
            this.label1.Text = "Manage Application Types";
            // 
            // lblNOfRecords
            // 
            this.lblNOfRecords.BackColor = System.Drawing.Color.Transparent;
            this.lblNOfRecords.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNOfRecords.ForeColor = System.Drawing.Color.Black;
            this.lblNOfRecords.Location = new System.Drawing.Point(102, 612);
            this.lblNOfRecords.Name = "lblNOfRecords";
            this.lblNOfRecords.Size = new System.Drawing.Size(27, 27);
            this.lblNOfRecords.TabIndex = 44;
            this.lblNOfRecords.Text = "???";
            // 
            // guna2HtmlLabel2
            // 
            this.guna2HtmlLabel2.BackColor = System.Drawing.Color.Transparent;
            this.guna2HtmlLabel2.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.guna2HtmlLabel2.ForeColor = System.Drawing.Color.Black;
            this.guna2HtmlLabel2.Location = new System.Drawing.Point(12, 612);
            this.guna2HtmlLabel2.Name = "guna2HtmlLabel2";
            this.guna2HtmlLabel2.Size = new System.Drawing.Size(84, 27);
            this.guna2HtmlLabel2.TabIndex = 43;
            this.guna2HtmlLabel2.Text = "Records :";
            // 
            // ManageAppTypesMenu
            // 
            this.ManageAppTypesMenu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.editToolStripMenuItem});
            this.ManageAppTypesMenu.Name = "ManageAppTypesMenu";
            this.ManageAppTypesMenu.Size = new System.Drawing.Size(191, 26);
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
            this.btnClose.Image = global::DVLD___Driving_License_Management.Properties.Resources.Close_32;
            this.btnClose.ImageAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.btnClose.Location = new System.Drawing.Point(550, 603);
            this.btnClose.Name = "btnClose";
            this.btnClose.ShadowDecoration.Parent = this.btnClose;
            this.btnClose.Size = new System.Drawing.Size(123, 45);
            this.btnClose.TabIndex = 45;
            this.btnClose.Text = "Close";
            this.btnClose.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // editToolStripMenuItem
            // 
            this.editToolStripMenuItem.Image = global::DVLD___Driving_License_Management.Properties.Resources.edit_321;
            this.editToolStripMenuItem.Name = "editToolStripMenuItem";
            this.editToolStripMenuItem.Size = new System.Drawing.Size(190, 22);
            this.editToolStripMenuItem.Text = "Edit Applications Type";
            this.editToolStripMenuItem.Click += new System.EventHandler(this.editToolStripMenuItem_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::DVLD___Driving_License_Management.Properties.Resources.Application_Types_512;
            this.pictureBox1.Location = new System.Drawing.Point(189, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(261, 219);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // ManageApplicationTypesList
            // 
            this.ManageApplicationTypesList.AllowUserToAddRows = false;
            this.ManageApplicationTypesList.AllowUserToDeleteRows = false;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.White;
            this.ManageApplicationTypesList.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.ManageApplicationTypesList.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.ManageApplicationTypesList.BackgroundColor = System.Drawing.Color.White;
            this.ManageApplicationTypesList.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.ManageApplicationTypesList.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.ManageApplicationTypesList.ClipboardCopyMode = System.Windows.Forms.DataGridViewClipboardCopyMode.EnableAlwaysIncludeHeaderText;
            this.ManageApplicationTypesList.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Sunken;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI", 10.5F);
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.ManageApplicationTypesList.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.ManageApplicationTypesList.ColumnHeadersHeight = 25;
            this.ManageApplicationTypesList.ContextMenuStrip = this.ManageAppTypesMenu;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Segoe UI", 10.5F);
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.ManageApplicationTypesList.DefaultCellStyle = dataGridViewCellStyle3;
            this.ManageApplicationTypesList.EnableHeadersVisualStyles = false;
            this.ManageApplicationTypesList.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.ManageApplicationTypesList.Location = new System.Drawing.Point(12, 290);
            this.ManageApplicationTypesList.Name = "ManageApplicationTypesList";
            this.ManageApplicationTypesList.ReadOnly = true;
            this.ManageApplicationTypesList.RowHeadersVisible = false;
            this.ManageApplicationTypesList.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.ManageApplicationTypesList.Size = new System.Drawing.Size(661, 305);
            this.ManageApplicationTypesList.TabIndex = 47;
            this.ManageApplicationTypesList.Theme = Guna.UI2.WinForms.Enums.DataGridViewPresetThemes.Default;
            this.ManageApplicationTypesList.ThemeStyle.AlternatingRowsStyle.BackColor = System.Drawing.Color.White;
            this.ManageApplicationTypesList.ThemeStyle.AlternatingRowsStyle.Font = null;
            this.ManageApplicationTypesList.ThemeStyle.AlternatingRowsStyle.ForeColor = System.Drawing.Color.Empty;
            this.ManageApplicationTypesList.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = System.Drawing.Color.Empty;
            this.ManageApplicationTypesList.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = System.Drawing.Color.Empty;
            this.ManageApplicationTypesList.ThemeStyle.BackColor = System.Drawing.Color.White;
            this.ManageApplicationTypesList.ThemeStyle.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.ManageApplicationTypesList.ThemeStyle.HeaderStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.ManageApplicationTypesList.ThemeStyle.HeaderStyle.BorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Sunken;
            this.ManageApplicationTypesList.ThemeStyle.HeaderStyle.Font = new System.Drawing.Font("Segoe UI", 10.5F);
            this.ManageApplicationTypesList.ThemeStyle.HeaderStyle.ForeColor = System.Drawing.Color.White;
            this.ManageApplicationTypesList.ThemeStyle.HeaderStyle.HeaightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            this.ManageApplicationTypesList.ThemeStyle.HeaderStyle.Height = 25;
            this.ManageApplicationTypesList.ThemeStyle.ReadOnly = true;
            this.ManageApplicationTypesList.ThemeStyle.RowsStyle.BackColor = System.Drawing.Color.White;
            this.ManageApplicationTypesList.ThemeStyle.RowsStyle.BorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.ManageApplicationTypesList.ThemeStyle.RowsStyle.Font = new System.Drawing.Font("Segoe UI", 10.5F);
            this.ManageApplicationTypesList.ThemeStyle.RowsStyle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            this.ManageApplicationTypesList.ThemeStyle.RowsStyle.Height = 22;
            this.ManageApplicationTypesList.ThemeStyle.RowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.ManageApplicationTypesList.ThemeStyle.RowsStyle.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            // 
            // ManageApplicationTypesScreen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(685, 652);
            this.Controls.Add(this.ManageApplicationTypesList);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.lblNOfRecords);
            this.Controls.Add(this.guna2HtmlLabel2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pictureBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "ManageApplicationTypesScreen";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ManageApplicationTypesScreen";
            this.Load += new System.EventHandler(this.ManageApplicationTypesScreen_Load);
            this.ManageAppTypesMenu.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ManageApplicationTypesList)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label1;
        private Guna.UI2.WinForms.Guna2HtmlLabel lblNOfRecords;
        private Guna.UI2.WinForms.Guna2HtmlLabel guna2HtmlLabel2;
        private System.Windows.Forms.ContextMenuStrip ManageAppTypesMenu;
        private Guna.UI2.WinForms.Guna2Button btnClose;
        private System.Windows.Forms.ToolStripMenuItem editToolStripMenuItem;
        private Guna.UI2.WinForms.Guna2DataGridView ManageApplicationTypesList;
    }
}