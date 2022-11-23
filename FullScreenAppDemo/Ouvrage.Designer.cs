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
            System.Windows.Forms.ListViewItem listViewItem2 = new System.Windows.Forms.ListViewItem("1");
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Ouvrage));
            this.guna2ContainerControl1 = new Guna.UI2.WinForms.Guna2ContainerControl();
            this.tableOuvrage = new System.Windows.Forms.ListView();
            this.ID = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.nomcomplet = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.cin = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.active = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.action = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.newOuvrageButton = new Guna.UI2.WinForms.Guna2GradientButton();
            this.chercherOuvrage = new Guna.UI2.WinForms.Guna2TextBox();
            this.guna2ContainerControl1.SuspendLayout();
            this.SuspendLayout();
            // 
            // guna2ContainerControl1
            // 
            this.guna2ContainerControl1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(226)))), ((int)(((byte)(230)))));
            this.guna2ContainerControl1.Controls.Add(this.tableOuvrage);
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
            // tableOuvrage
            // 
            this.tableOuvrage.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(226)))), ((int)(((byte)(230)))));
            this.tableOuvrage.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.ID,
            this.nomcomplet,
            this.cin,
            this.active,
            this.action});
            this.tableOuvrage.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.tableOuvrage.HideSelection = false;
            this.tableOuvrage.Items.AddRange(new System.Windows.Forms.ListViewItem[] {
            listViewItem2});
            this.tableOuvrage.Location = new System.Drawing.Point(0, 81);
            this.tableOuvrage.Name = "tableOuvrage";
            this.tableOuvrage.Size = new System.Drawing.Size(1120, 587);
            this.tableOuvrage.TabIndex = 3;
            this.tableOuvrage.UseCompatibleStateImageBehavior = false;
            this.tableOuvrage.View = System.Windows.Forms.View.Details;
            // 
            // ID
            // 
            this.ID.Text = "id";
            this.ID.Width = 124;
            // 
            // nomcomplet
            // 
            this.nomcomplet.Text = "Nom complet";
            this.nomcomplet.Width = 349;
            // 
            // cin
            // 
            this.cin.Text = "cin";
            this.cin.Width = 233;
            // 
            // active
            // 
            this.active.Text = "active";
            this.active.Width = 214;
            // 
            // action
            // 
            this.action.Text = "action";
            this.action.Width = 171;
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
            this.newOuvrageButton.Location = new System.Drawing.Point(883, 17);
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
            this.chercherOuvrage.Location = new System.Drawing.Point(8, 17);
            this.chercherOuvrage.Name = "chercherOuvrage";
            this.chercherOuvrage.PasswordChar = '\0';
            this.chercherOuvrage.PlaceholderText = "";
            this.chercherOuvrage.SelectedText = "";
            this.chercherOuvrage.ShadowDecoration.Parent = this.chercherOuvrage;
            this.chercherOuvrage.Size = new System.Drawing.Size(335, 44);
            this.chercherOuvrage.TabIndex = 1;
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
            this.ResumeLayout(false);

        }

        #endregion

        private Guna.UI2.WinForms.Guna2ContainerControl guna2ContainerControl1;
        private System.Windows.Forms.ListView tableOuvrage;
        private System.Windows.Forms.ColumnHeader ID;
        private System.Windows.Forms.ColumnHeader nomcomplet;
        private System.Windows.Forms.ColumnHeader cin;
        private System.Windows.Forms.ColumnHeader active;
        private System.Windows.Forms.ColumnHeader action;
        private Guna.UI2.WinForms.Guna2GradientButton newOuvrageButton;
        private Guna.UI2.WinForms.Guna2TextBox chercherOuvrage;
    }
}
