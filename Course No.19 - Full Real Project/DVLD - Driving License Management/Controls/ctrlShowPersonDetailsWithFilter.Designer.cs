namespace DVLD___Driving_License_Management
{
    partial class ctrlShowPersonDetailsWithFilter
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.guna2HtmlLabel1 = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.cbUserFilterBy = new Guna.UI2.WinForms.Guna2ComboBox();
            this.btnSearchPerson = new Guna.UI2.WinForms.Guna2Button();
            this.txtAccountNSearch = new Guna.UI2.WinForms.Guna2TextBox();
            this.btnAddNewPerson = new Guna.UI2.WinForms.Guna2Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.ctrlShowPersonDetails1 = new DVLD___Driving_License_Management.ctrlShowPersonDetails();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.guna2HtmlLabel1);
            this.groupBox1.Controls.Add(this.cbUserFilterBy);
            this.groupBox1.Controls.Add(this.btnSearchPerson);
            this.groupBox1.Controls.Add(this.txtAccountNSearch);
            this.groupBox1.Controls.Add(this.btnAddNewPerson);
            this.groupBox1.Location = new System.Drawing.Point(3, 17);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(927, 118);
            this.groupBox1.TabIndex = 2;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Filter";
            // 
            // guna2HtmlLabel1
            // 
            this.guna2HtmlLabel1.BackColor = System.Drawing.Color.Transparent;
            this.guna2HtmlLabel1.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.guna2HtmlLabel1.Location = new System.Drawing.Point(6, 55);
            this.guna2HtmlLabel1.Name = "guna2HtmlLabel1";
            this.guna2HtmlLabel1.Size = new System.Drawing.Size(74, 27);
            this.guna2HtmlLabel1.TabIndex = 84;
            this.guna2HtmlLabel1.Text = "Find By:";
            // 
            // cbUserFilterBy
            // 
            this.cbUserFilterBy.BackColor = System.Drawing.Color.Transparent;
            this.cbUserFilterBy.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.cbUserFilterBy.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbUserFilterBy.FocusedColor = System.Drawing.Color.Empty;
            this.cbUserFilterBy.FocusedState.Parent = this.cbUserFilterBy;
            this.cbUserFilterBy.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbUserFilterBy.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(88)))), ((int)(((byte)(112)))));
            this.cbUserFilterBy.FormattingEnabled = true;
            this.cbUserFilterBy.HoverState.Parent = this.cbUserFilterBy;
            this.cbUserFilterBy.ItemHeight = 30;
            this.cbUserFilterBy.Items.AddRange(new object[] {
            "Person ID",
            "National No."});
            this.cbUserFilterBy.ItemsAppearance.Parent = this.cbUserFilterBy;
            this.cbUserFilterBy.Location = new System.Drawing.Point(86, 50);
            this.cbUserFilterBy.Name = "cbUserFilterBy";
            this.cbUserFilterBy.ShadowDecoration.Parent = this.cbUserFilterBy;
            this.cbUserFilterBy.Size = new System.Drawing.Size(152, 36);
            this.cbUserFilterBy.TabIndex = 83;
            this.cbUserFilterBy.SelectedIndexChanged += new System.EventHandler(this.cbUserFilterBy_SelectedIndexChanged);
            // 
            // btnSearchPerson
            // 
            this.btnSearchPerson.CheckedState.Parent = this.btnSearchPerson;
            this.btnSearchPerson.CustomImages.Parent = this.btnSearchPerson;
            this.btnSearchPerson.FillColor = System.Drawing.Color.White;
            this.btnSearchPerson.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btnSearchPerson.ForeColor = System.Drawing.Color.Black;
            this.btnSearchPerson.HoverState.Parent = this.btnSearchPerson;
            this.btnSearchPerson.Image = global::DVLD___Driving_License_Management.Properties.Resources.SearchPerson;
            this.btnSearchPerson.ImageSize = new System.Drawing.Size(30, 30);
            this.btnSearchPerson.Location = new System.Drawing.Point(588, 50);
            this.btnSearchPerson.Name = "btnSearchPerson";
            this.btnSearchPerson.ShadowDecoration.Parent = this.btnSearchPerson;
            this.btnSearchPerson.Size = new System.Drawing.Size(65, 41);
            this.btnSearchPerson.TabIndex = 82;
            this.btnSearchPerson.Click += new System.EventHandler(this.guna2Button2_Click);
            // 
            // txtAccountNSearch
            // 
            this.txtAccountNSearch.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtAccountNSearch.DefaultText = "";
            this.txtAccountNSearch.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtAccountNSearch.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtAccountNSearch.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtAccountNSearch.DisabledState.Parent = this.txtAccountNSearch;
            this.txtAccountNSearch.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtAccountNSearch.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtAccountNSearch.FocusedState.Parent = this.txtAccountNSearch;
            this.txtAccountNSearch.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtAccountNSearch.HoverState.Parent = this.txtAccountNSearch;
            this.txtAccountNSearch.Location = new System.Drawing.Point(244, 50);
            this.txtAccountNSearch.Name = "txtAccountNSearch";
            this.txtAccountNSearch.PasswordChar = '\0';
            this.txtAccountNSearch.PlaceholderText = "";
            this.txtAccountNSearch.SelectedText = "";
            this.txtAccountNSearch.ShadowDecoration.Parent = this.txtAccountNSearch;
            this.txtAccountNSearch.Size = new System.Drawing.Size(324, 36);
            this.txtAccountNSearch.TabIndex = 80;
            this.txtAccountNSearch.TextChanged += new System.EventHandler(this.txtAccountNSearch_TextChanged);
            // 
            // btnAddNewPerson
            // 
            this.btnAddNewPerson.CheckedState.Parent = this.btnAddNewPerson;
            this.btnAddNewPerson.CustomImages.Parent = this.btnAddNewPerson;
            this.btnAddNewPerson.FillColor = System.Drawing.Color.White;
            this.btnAddNewPerson.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btnAddNewPerson.ForeColor = System.Drawing.Color.Black;
            this.btnAddNewPerson.HoverState.Parent = this.btnAddNewPerson;
            this.btnAddNewPerson.Image = global::DVLD___Driving_License_Management.Properties.Resources.Add_Person_40;
            this.btnAddNewPerson.ImageSize = new System.Drawing.Size(30, 30);
            this.btnAddNewPerson.Location = new System.Drawing.Point(659, 50);
            this.btnAddNewPerson.Name = "btnAddNewPerson";
            this.btnAddNewPerson.ShadowDecoration.Parent = this.btnAddNewPerson;
            this.btnAddNewPerson.Size = new System.Drawing.Size(72, 41);
            this.btnAddNewPerson.TabIndex = 81;
            this.btnAddNewPerson.Click += new System.EventHandler(this.guna2Button1_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.ctrlShowPersonDetails1);
            this.groupBox2.Location = new System.Drawing.Point(3, 141);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(927, 446);
            this.groupBox2.TabIndex = 3;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Person Info";
            // 
            // ctrlShowPersonDetails1
            // 
            this.ctrlShowPersonDetails1.Location = new System.Drawing.Point(15, 19);
            this.ctrlShowPersonDetails1.Name = "ctrlShowPersonDetails1";
            this.ctrlShowPersonDetails1.Size = new System.Drawing.Size(878, 407);
            this.ctrlShowPersonDetails1.TabIndex = 0;
            // 
            // ctrlShowPersonDetailsWithFilter
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Name = "ctrlShowPersonDetailsWithFilter";
            this.Size = new System.Drawing.Size(963, 646);
            this.Load += new System.EventHandler(this.ctrlShowPersonDetailsWithFilter_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private ctrlShowPersonDetails ctrlShowPersonDetails1;
        private System.Windows.Forms.GroupBox groupBox1;
        private Guna.UI2.WinForms.Guna2HtmlLabel guna2HtmlLabel1;
        private Guna.UI2.WinForms.Guna2ComboBox cbUserFilterBy;
        private Guna.UI2.WinForms.Guna2Button btnSearchPerson;
        private Guna.UI2.WinForms.Guna2TextBox txtAccountNSearch;
        private Guna.UI2.WinForms.Guna2Button btnAddNewPerson;
        private System.Windows.Forms.GroupBox groupBox2;
    }
}
