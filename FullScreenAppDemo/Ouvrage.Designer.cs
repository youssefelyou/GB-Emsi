namespace FullScreenAppDemo
{
    partial class Ouvrage
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Ouvrage));
            this.guna2ContainerControl1 = new Guna.UI2.WinForms.Guna2ContainerControl();
            this.label1 = new System.Windows.Forms.Label();
            this.filterOuvrages = new Guna.UI2.WinForms.Guna2ComboBox();
            this.listOfOuvrage = new Guna.UI2.WinForms.Guna2DataGridView();
            this.newOuvrageButton = new Guna.UI2.WinForms.Guna2GradientButton();
            this.chercherOuvrage = new Guna.UI2.WinForms.Guna2TextBox();
            this.guna2ContainerControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.listOfOuvrage)).BeginInit();
            this.SuspendLayout();
            // 
            // guna2ContainerControl1
            // 
            this.guna2ContainerControl1.AutoScroll = true;
            this.guna2ContainerControl1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(226)))), ((int)(((byte)(230)))));
            this.guna2ContainerControl1.Controls.Add(this.label1);
            this.guna2ContainerControl1.Controls.Add(this.filterOuvrages);
            this.guna2ContainerControl1.Controls.Add(this.listOfOuvrage);
            this.guna2ContainerControl1.Controls.Add(this.newOuvrageButton);
            this.guna2ContainerControl1.Controls.Add(this.chercherOuvrage);
            this.guna2ContainerControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.guna2ContainerControl1.Location = new System.Drawing.Point(0, 0);
            this.guna2ContainerControl1.Name = "guna2ContainerControl1";
            this.guna2ContainerControl1.ShadowDecoration.Parent = this.guna2ContainerControl1;
            this.guna2ContainerControl1.Size = new System.Drawing.Size(1120, 668);
            this.guna2ContainerControl1.TabIndex = 6;
            this.guna2ContainerControl1.Text = "guna2ContainerControl1";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(399, 36);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(44, 16);
            this.label1.TabIndex = 14;
            this.label1.Text = "label1";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // filterOuvrages
            // 
            this.filterOuvrages.BackColor = System.Drawing.Color.Transparent;
            this.filterOuvrages.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(198)))), ((int)(((byte)(35)))), ((int)(((byte)(255)))));
            this.filterOuvrages.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.filterOuvrages.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.filterOuvrages.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(206)))), ((int)(((byte)(212)))), ((int)(((byte)(218)))));
            this.filterOuvrages.FocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.filterOuvrages.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.filterOuvrages.FocusedState.Parent = this.filterOuvrages;
            this.filterOuvrages.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.filterOuvrages.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(88)))), ((int)(((byte)(112)))));
            this.filterOuvrages.HoverState.Parent = this.filterOuvrages;
            this.filterOuvrages.ItemHeight = 30;
            this.filterOuvrages.ItemsAppearance.Parent = this.filterOuvrages;
            this.filterOuvrages.Location = new System.Drawing.Point(993, 25);
            this.filterOuvrages.Name = "filterOuvrages";
            this.filterOuvrages.ShadowDecoration.Parent = this.filterOuvrages;
            this.filterOuvrages.Size = new System.Drawing.Size(124, 36);
            this.filterOuvrages.TabIndex = 13;
            this.filterOuvrages.SelectedIndexChanged += new System.EventHandler(this.filterOuvrages_SelectedIndexChanged);
            // 
            // listOfOuvrage
            // 
            this.listOfOuvrage.AllowUserToAddRows = false;
            this.listOfOuvrage.AllowUserToDeleteRows = false;
            this.listOfOuvrage.AllowUserToResizeColumns = false;
            this.listOfOuvrage.AllowUserToResizeRows = false;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.White;
            this.listOfOuvrage.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.listOfOuvrage.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.listOfOuvrage.BackgroundColor = System.Drawing.Color.White;
            this.listOfOuvrage.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.listOfOuvrage.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.listOfOuvrage.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI", 13F);
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.Padding = new System.Windows.Forms.Padding(5);
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.listOfOuvrage.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.listOfOuvrage.ColumnHeadersHeight = 42;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Segoe UI", 11F);
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.listOfOuvrage.DefaultCellStyle = dataGridViewCellStyle3;
            this.listOfOuvrage.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.listOfOuvrage.EnableHeadersVisualStyles = false;
            this.listOfOuvrage.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.listOfOuvrage.Location = new System.Drawing.Point(0, 80);
            this.listOfOuvrage.Name = "listOfOuvrage";
            this.listOfOuvrage.RowHeadersVisible = false;
            this.listOfOuvrage.RowHeadersWidth = 51;
            this.listOfOuvrage.RowTemplate.Height = 50;
            this.listOfOuvrage.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.listOfOuvrage.Size = new System.Drawing.Size(1120, 588);
            this.listOfOuvrage.TabIndex = 3;
            this.listOfOuvrage.ThemeStyle.AlternatingRowsStyle.BackColor = System.Drawing.Color.White;
            this.listOfOuvrage.ThemeStyle.AlternatingRowsStyle.Font = null;
            this.listOfOuvrage.ThemeStyle.AlternatingRowsStyle.ForeColor = System.Drawing.Color.Empty;
            this.listOfOuvrage.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = System.Drawing.Color.Empty;
            this.listOfOuvrage.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = System.Drawing.Color.Empty;
            this.listOfOuvrage.ThemeStyle.BackColor = System.Drawing.Color.White;
            this.listOfOuvrage.ThemeStyle.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.listOfOuvrage.ThemeStyle.HeaderStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.listOfOuvrage.ThemeStyle.HeaderStyle.BorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.listOfOuvrage.ThemeStyle.HeaderStyle.Font = new System.Drawing.Font("Segoe UI", 10.5F);
            this.listOfOuvrage.ThemeStyle.HeaderStyle.ForeColor = System.Drawing.Color.White;
            this.listOfOuvrage.ThemeStyle.HeaderStyle.HeaightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            this.listOfOuvrage.ThemeStyle.HeaderStyle.Height = 42;
            this.listOfOuvrage.ThemeStyle.ReadOnly = false;
            this.listOfOuvrage.ThemeStyle.RowsStyle.BackColor = System.Drawing.Color.White;
            this.listOfOuvrage.ThemeStyle.RowsStyle.BorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.listOfOuvrage.ThemeStyle.RowsStyle.Font = new System.Drawing.Font("Segoe UI", 10.5F);
            this.listOfOuvrage.ThemeStyle.RowsStyle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            this.listOfOuvrage.ThemeStyle.RowsStyle.Height = 50;
            this.listOfOuvrage.ThemeStyle.RowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.listOfOuvrage.ThemeStyle.RowsStyle.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            this.listOfOuvrage.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.listOfOuvrage_CellContentClick);
            this.listOfOuvrage.CellMouseClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.listOfOuvrage_CellMouseClick);
            this.listOfOuvrage.CellMouseDoubleClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.listOfOuvrage_CellMouseDoubleClick);
            // 
            // newOuvrageButton
            // 
            this.newOuvrageButton.BorderRadius = 5;
            this.newOuvrageButton.CheckedState.Parent = this.newOuvrageButton;
            this.newOuvrageButton.CustomImages.Parent = this.newOuvrageButton;
            this.newOuvrageButton.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.newOuvrageButton.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.newOuvrageButton.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.newOuvrageButton.DisabledState.FillColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.newOuvrageButton.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.newOuvrageButton.DisabledState.Parent = this.newOuvrageButton;
            this.newOuvrageButton.FillColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(198)))), ((int)(((byte)(35)))), ((int)(((byte)(255)))));
            this.newOuvrageButton.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.newOuvrageButton.ForeColor = System.Drawing.Color.White;
            this.newOuvrageButton.HoverState.Parent = this.newOuvrageButton;
            this.newOuvrageButton.Location = new System.Drawing.Point(770, 17);
            this.newOuvrageButton.Name = "newOuvrageButton";
            this.newOuvrageButton.ShadowDecoration.Parent = this.newOuvrageButton;
            this.newOuvrageButton.Size = new System.Drawing.Size(199, 44);
            this.newOuvrageButton.TabIndex = 2;
            this.newOuvrageButton.Text = "Nouveau ouvrage";
            this.newOuvrageButton.Click += new System.EventHandler(this.newOuvrageButton_Click);
            // 
            // chercherOuvrage
            // 
            this.chercherOuvrage.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(198)))), ((int)(((byte)(35)))), ((int)(((byte)(255)))));
            this.chercherOuvrage.BorderRadius = 5;
            this.chercherOuvrage.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.chercherOuvrage.DefaultText = "chercher ouvrage..";
            this.chercherOuvrage.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.chercherOuvrage.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.chercherOuvrage.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.chercherOuvrage.DisabledState.Parent = this.chercherOuvrage;
            this.chercherOuvrage.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.chercherOuvrage.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.chercherOuvrage.FocusedState.Parent = this.chercherOuvrage;
            this.chercherOuvrage.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.chercherOuvrage.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.chercherOuvrage.HoverState.Parent = this.chercherOuvrage;
            this.chercherOuvrage.IconRight = ((System.Drawing.Image)(resources.GetObject("chercherOuvrage.IconRight")));
            this.chercherOuvrage.Location = new System.Drawing.Point(3, 17);
            this.chercherOuvrage.Name = "chercherOuvrage";
            this.chercherOuvrage.PasswordChar = '\0';
            this.chercherOuvrage.PlaceholderText = "";
            this.chercherOuvrage.SelectedText = "";
            this.chercherOuvrage.SelectionStart = 18;
            this.chercherOuvrage.ShadowDecoration.Parent = this.chercherOuvrage;
            this.chercherOuvrage.Size = new System.Drawing.Size(335, 44);
            this.chercherOuvrage.TabIndex = 1;
            this.chercherOuvrage.TextChanged += new System.EventHandler(this.chercherOuvrage_TextChanged);
            // 
            // Ouvrage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(226)))), ((int)(((byte)(230)))));
            this.Controls.Add(this.guna2ContainerControl1);
            this.Name = "Ouvrage";
            this.Size = new System.Drawing.Size(1120, 668);
            this.guna2ContainerControl1.ResumeLayout(false);
            this.guna2ContainerControl1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.listOfOuvrage)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Guna.UI2.WinForms.Guna2ContainerControl guna2ContainerControl1;
        private Guna.UI2.WinForms.Guna2GradientButton newOuvrageButton;
        private Guna.UI2.WinForms.Guna2TextBox chercherOuvrage;
        private Guna.UI2.WinForms.Guna2DataGridView listOfOuvrage;
        private Guna.UI2.WinForms.Guna2ComboBox filterOuvrages;
        private System.Windows.Forms.Label label1;
    }
}
