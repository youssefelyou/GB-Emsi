namespace FullScreenAppDemo
{
    partial class CreateOuvrage
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.auteur = new Guna.UI2.WinForms.Guna2TextBox();
            this.titre = new Guna.UI2.WinForms.Guna2TextBox();
            this.editeur = new Guna.UI2.WinForms.Guna2TextBox();
            this.nom = new Guna.UI2.WinForms.Guna2TextBox();
            this.numero = new Guna.UI2.WinForms.Guna2TextBox();
            this.periodicite = new Guna.UI2.WinForms.Guna2TextBox();
            this.dateBox = new Guna.UI2.WinForms.Guna2TextBox();
            this.typeOuvrages = new Guna.UI2.WinForms.Guna2ComboBox();
            this.guna2GradientButton2 = new Guna.UI2.WinForms.Guna2GradientButton();
            this.guna2GradientButton1 = new Guna.UI2.WinForms.Guna2GradientButton();
            this.label2 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.flowLayoutPanel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(206)))), ((int)(((byte)(212)))), ((int)(((byte)(218)))));
            this.panel1.Controls.Add(this.flowLayoutPanel1);
            this.panel1.Controls.Add(this.typeOuvrages);
            this.panel1.Controls.Add(this.guna2GradientButton2);
            this.panel1.Controls.Add(this.guna2GradientButton1);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(900, 610);
            this.panel1.TabIndex = 1;
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.Controls.Add(this.auteur);
            this.flowLayoutPanel1.Controls.Add(this.titre);
            this.flowLayoutPanel1.Controls.Add(this.editeur);
            this.flowLayoutPanel1.Controls.Add(this.nom);
            this.flowLayoutPanel1.Controls.Add(this.numero);
            this.flowLayoutPanel1.Controls.Add(this.periodicite);
            this.flowLayoutPanel1.Controls.Add(this.dateBox);
            this.flowLayoutPanel1.Location = new System.Drawing.Point(0, 163);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Padding = new System.Windows.Forms.Padding(5, 15, 75, 15);
            this.flowLayoutPanel1.Size = new System.Drawing.Size(900, 373);
            this.flowLayoutPanel1.TabIndex = 13;
            // 
            // auteur
            // 
            this.auteur.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(198)))), ((int)(((byte)(35)))), ((int)(((byte)(255)))));
            this.auteur.BorderRadius = 5;
            this.auteur.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.auteur.DefaultText = "";
            this.auteur.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.auteur.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.auteur.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.auteur.DisabledState.Parent = this.auteur;
            this.auteur.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.auteur.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(206)))), ((int)(((byte)(212)))), ((int)(((byte)(218)))));
            this.auteur.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.auteur.FocusedState.Parent = this.auteur;
            this.auteur.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.auteur.ForeColor = System.Drawing.Color.Black;
            this.auteur.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.auteur.HoverState.Parent = this.auteur;
            this.auteur.Location = new System.Drawing.Point(8, 18);
            this.auteur.Margin = new System.Windows.Forms.Padding(3, 3, 30, 30);
            this.auteur.Name = "auteur";
            this.auteur.PasswordChar = '\0';
            this.auteur.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(198)))), ((int)(((byte)(35)))), ((int)(((byte)(255)))));
            this.auteur.PlaceholderText = "Auteur";
            this.auteur.SelectedText = "";
            this.auteur.ShadowDecoration.Parent = this.auteur;
            this.auteur.Size = new System.Drawing.Size(335, 44);
            this.auteur.TabIndex = 5;
            this.auteur.Visible = false;
            this.auteur.TextChanged += new System.EventHandler(this.auteur_TextChanged);
            // 
            // titre
            // 
            this.titre.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(198)))), ((int)(((byte)(35)))), ((int)(((byte)(255)))));
            this.titre.BorderRadius = 5;
            this.titre.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.titre.DefaultText = "";
            this.titre.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.titre.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.titre.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.titre.DisabledState.Parent = this.titre;
            this.titre.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.titre.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(206)))), ((int)(((byte)(212)))), ((int)(((byte)(218)))));
            this.titre.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.titre.FocusedState.Parent = this.titre;
            this.titre.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.titre.ForeColor = System.Drawing.Color.Black;
            this.titre.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.titre.HoverState.Parent = this.titre;
            this.titre.Location = new System.Drawing.Point(376, 18);
            this.titre.Margin = new System.Windows.Forms.Padding(3, 3, 30, 30);
            this.titre.Name = "titre";
            this.titre.PasswordChar = '\0';
            this.titre.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(198)))), ((int)(((byte)(35)))), ((int)(((byte)(255)))));
            this.titre.PlaceholderText = "Titre";
            this.titre.SelectedText = "";
            this.titre.ShadowDecoration.Parent = this.titre;
            this.titre.Size = new System.Drawing.Size(335, 44);
            this.titre.TabIndex = 2;
            this.titre.Visible = false;
            // 
            // editeur
            // 
            this.editeur.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(198)))), ((int)(((byte)(35)))), ((int)(((byte)(255)))));
            this.editeur.BorderRadius = 5;
            this.editeur.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.editeur.DefaultText = "";
            this.editeur.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.editeur.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.editeur.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.editeur.DisabledState.Parent = this.editeur;
            this.editeur.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.editeur.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(206)))), ((int)(((byte)(212)))), ((int)(((byte)(218)))));
            this.editeur.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.editeur.FocusedState.Parent = this.editeur;
            this.editeur.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.editeur.ForeColor = System.Drawing.Color.Black;
            this.editeur.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.editeur.HoverState.Parent = this.editeur;
            this.editeur.Location = new System.Drawing.Point(8, 95);
            this.editeur.Margin = new System.Windows.Forms.Padding(3, 3, 30, 30);
            this.editeur.Name = "editeur";
            this.editeur.PasswordChar = '\0';
            this.editeur.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(198)))), ((int)(((byte)(35)))), ((int)(((byte)(255)))));
            this.editeur.PlaceholderText = "Editeur";
            this.editeur.SelectedText = "";
            this.editeur.ShadowDecoration.Parent = this.editeur;
            this.editeur.Size = new System.Drawing.Size(335, 44);
            this.editeur.TabIndex = 7;
            this.editeur.Visible = false;
            // 
            // nom
            // 
            this.nom.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(198)))), ((int)(((byte)(35)))), ((int)(((byte)(255)))));
            this.nom.BorderRadius = 5;
            this.nom.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.nom.DefaultText = "";
            this.nom.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.nom.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.nom.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.nom.DisabledState.Parent = this.nom;
            this.nom.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.nom.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(206)))), ((int)(((byte)(212)))), ((int)(((byte)(218)))));
            this.nom.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.nom.FocusedState.Parent = this.nom;
            this.nom.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.nom.ForeColor = System.Drawing.Color.Black;
            this.nom.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.nom.HoverState.Parent = this.nom;
            this.nom.Location = new System.Drawing.Point(376, 95);
            this.nom.Margin = new System.Windows.Forms.Padding(3, 3, 3, 30);
            this.nom.Name = "nom";
            this.nom.PasswordChar = '\0';
            this.nom.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(198)))), ((int)(((byte)(35)))), ((int)(((byte)(255)))));
            this.nom.PlaceholderText = "Nom";
            this.nom.SelectedText = "";
            this.nom.ShadowDecoration.Parent = this.nom;
            this.nom.Size = new System.Drawing.Size(335, 44);
            this.nom.TabIndex = 6;
            this.nom.Visible = false;
            // 
            // numero
            // 
            this.numero.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(198)))), ((int)(((byte)(35)))), ((int)(((byte)(255)))));
            this.numero.BorderRadius = 5;
            this.numero.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.numero.DefaultText = "";
            this.numero.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.numero.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.numero.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.numero.DisabledState.Parent = this.numero;
            this.numero.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.numero.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(206)))), ((int)(((byte)(212)))), ((int)(((byte)(218)))));
            this.numero.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.numero.FocusedState.Parent = this.numero;
            this.numero.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.numero.ForeColor = System.Drawing.Color.Black;
            this.numero.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.numero.HoverState.Parent = this.numero;
            this.numero.Location = new System.Drawing.Point(8, 172);
            this.numero.Margin = new System.Windows.Forms.Padding(3, 3, 30, 30);
            this.numero.Name = "numero";
            this.numero.PasswordChar = '\0';
            this.numero.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(198)))), ((int)(((byte)(35)))), ((int)(((byte)(255)))));
            this.numero.PlaceholderText = "Numero";
            this.numero.SelectedText = "";
            this.numero.ShadowDecoration.Parent = this.numero;
            this.numero.Size = new System.Drawing.Size(335, 44);
            this.numero.TabIndex = 9;
            this.numero.Visible = false;
            // 
            // periodicite
            // 
            this.periodicite.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(198)))), ((int)(((byte)(35)))), ((int)(((byte)(255)))));
            this.periodicite.BorderRadius = 5;
            this.periodicite.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.periodicite.DefaultText = "";
            this.periodicite.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.periodicite.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.periodicite.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.periodicite.DisabledState.Parent = this.periodicite;
            this.periodicite.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.periodicite.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(206)))), ((int)(((byte)(212)))), ((int)(((byte)(218)))));
            this.periodicite.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.periodicite.FocusedState.Parent = this.periodicite;
            this.periodicite.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.periodicite.ForeColor = System.Drawing.Color.Black;
            this.periodicite.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.periodicite.HoverState.Parent = this.periodicite;
            this.periodicite.Location = new System.Drawing.Point(376, 172);
            this.periodicite.Margin = new System.Windows.Forms.Padding(3, 3, 30, 30);
            this.periodicite.Name = "periodicite";
            this.periodicite.PasswordChar = '\0';
            this.periodicite.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(198)))), ((int)(((byte)(35)))), ((int)(((byte)(255)))));
            this.periodicite.PlaceholderText = "Periodicite";
            this.periodicite.SelectedText = "";
            this.periodicite.ShadowDecoration.Parent = this.periodicite;
            this.periodicite.Size = new System.Drawing.Size(335, 44);
            this.periodicite.TabIndex = 8;
            this.periodicite.Visible = false;
            // 
            // dateBox
            // 
            this.dateBox.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(198)))), ((int)(((byte)(35)))), ((int)(((byte)(255)))));
            this.dateBox.BorderRadius = 5;
            this.dateBox.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.dateBox.DefaultText = "";
            this.dateBox.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.dateBox.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.dateBox.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.dateBox.DisabledState.Parent = this.dateBox;
            this.dateBox.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.dateBox.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(206)))), ((int)(((byte)(212)))), ((int)(((byte)(218)))));
            this.dateBox.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.dateBox.FocusedState.Parent = this.dateBox;
            this.dateBox.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.dateBox.ForeColor = System.Drawing.Color.Black;
            this.dateBox.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.dateBox.HoverState.Parent = this.dateBox;
            this.dateBox.Location = new System.Drawing.Point(8, 249);
            this.dateBox.Margin = new System.Windows.Forms.Padding(3, 3, 30, 30);
            this.dateBox.Name = "dateBox";
            this.dateBox.PasswordChar = '\0';
            this.dateBox.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(198)))), ((int)(((byte)(35)))), ((int)(((byte)(255)))));
            this.dateBox.PlaceholderText = "Date";
            this.dateBox.SelectedText = "";
            this.dateBox.ShadowDecoration.Parent = this.dateBox;
            this.dateBox.Size = new System.Drawing.Size(335, 44);
            this.dateBox.TabIndex = 11;
            // 
            // typeOuvrages
            // 
            this.typeOuvrages.BackColor = System.Drawing.Color.Transparent;
            this.typeOuvrages.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(198)))), ((int)(((byte)(35)))), ((int)(((byte)(255)))));
            this.typeOuvrages.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.typeOuvrages.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.typeOuvrages.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(206)))), ((int)(((byte)(212)))), ((int)(((byte)(218)))));
            this.typeOuvrages.FocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.typeOuvrages.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.typeOuvrages.FocusedState.Parent = this.typeOuvrages;
            this.typeOuvrages.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.typeOuvrages.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(88)))), ((int)(((byte)(112)))));
            this.typeOuvrages.HoverState.Parent = this.typeOuvrages;
            this.typeOuvrages.ItemHeight = 30;
            this.typeOuvrages.ItemsAppearance.Parent = this.typeOuvrages;
            this.typeOuvrages.Location = new System.Drawing.Point(12, 107);
            this.typeOuvrages.Name = "typeOuvrages";
            this.typeOuvrages.ShadowDecoration.Parent = this.typeOuvrages;
            this.typeOuvrages.Size = new System.Drawing.Size(335, 36);
            this.typeOuvrages.TabIndex = 12;
            this.typeOuvrages.SelectedIndexChanged += new System.EventHandler(this.typeOuvrages_SelectedIndexChanged);
            // 
            // guna2GradientButton2
            // 
            this.guna2GradientButton2.BorderRadius = 5;
            this.guna2GradientButton2.CheckedState.Parent = this.guna2GradientButton2;
            this.guna2GradientButton2.CustomImages.Parent = this.guna2GradientButton2;
            this.guna2GradientButton2.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.guna2GradientButton2.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.guna2GradientButton2.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.guna2GradientButton2.DisabledState.FillColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.guna2GradientButton2.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.guna2GradientButton2.DisabledState.Parent = this.guna2GradientButton2;
            this.guna2GradientButton2.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(173)))), ((int)(((byte)(181)))), ((int)(((byte)(189)))));
            this.guna2GradientButton2.FillColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(173)))), ((int)(((byte)(181)))), ((int)(((byte)(189)))));
            this.guna2GradientButton2.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.guna2GradientButton2.ForeColor = System.Drawing.Color.Black;
            this.guna2GradientButton2.HoverState.Parent = this.guna2GradientButton2;
            this.guna2GradientButton2.Location = new System.Drawing.Point(434, 542);
            this.guna2GradientButton2.Name = "guna2GradientButton2";
            this.guna2GradientButton2.ShadowDecoration.Parent = this.guna2GradientButton2;
            this.guna2GradientButton2.Size = new System.Drawing.Size(199, 44);
            this.guna2GradientButton2.TabIndex = 11;
            this.guna2GradientButton2.Text = "Annuler";
            this.guna2GradientButton2.Click += new System.EventHandler(this.guna2GradientButton2_Click);
            // 
            // guna2GradientButton1
            // 
            this.guna2GradientButton1.BorderRadius = 5;
            this.guna2GradientButton1.CheckedState.Parent = this.guna2GradientButton1;
            this.guna2GradientButton1.CustomImages.Parent = this.guna2GradientButton1;
            this.guna2GradientButton1.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.guna2GradientButton1.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.guna2GradientButton1.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.guna2GradientButton1.DisabledState.FillColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.guna2GradientButton1.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.guna2GradientButton1.DisabledState.Parent = this.guna2GradientButton1;
            this.guna2GradientButton1.FillColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.guna2GradientButton1.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.guna2GradientButton1.ForeColor = System.Drawing.Color.White;
            this.guna2GradientButton1.HoverState.Parent = this.guna2GradientButton1;
            this.guna2GradientButton1.Location = new System.Drawing.Point(692, 542);
            this.guna2GradientButton1.Name = "guna2GradientButton1";
            this.guna2GradientButton1.ShadowDecoration.Parent = this.guna2GradientButton1;
            this.guna2GradientButton1.Size = new System.Drawing.Size(199, 44);
            this.guna2GradientButton1.TabIndex = 10;
            this.guna2GradientButton1.Text = "Save";
            this.guna2GradientButton1.Click += new System.EventHandler(this.guna2GradientButton1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Arial Rounded MT Bold", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(9)))), ((int)(((byte)(43)))));
            this.label2.Location = new System.Drawing.Point(8, 84);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(228, 20);
            this.label2.TabIndex = 7;
            this.label2.Text = "Choisir une type d\'ouvrage";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(9)))), ((int)(((byte)(43)))));
            this.panel2.Controls.Add(this.label1);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(900, 72);
            this.panel2.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Cooper Black", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(334, 18);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(160, 38);
            this.label1.TabIndex = 0;
            this.label1.Text = "Ouvrage";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // CreateOuvrage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(226)))), ((int)(((byte)(230)))));
            this.ClientSize = new System.Drawing.Size(900, 610);
            this.ControlBox = false;
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "CreateOuvrage";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Show;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Ouvrage";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.flowLayoutPanel1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private Guna.UI2.WinForms.Guna2GradientButton guna2GradientButton2;
        private Guna.UI2.WinForms.Guna2GradientButton guna2GradientButton1;
        private System.Windows.Forms.Label label2;
        private Guna.UI2.WinForms.Guna2TextBox auteur;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label1;
        private Guna.UI2.WinForms.Guna2ComboBox typeOuvrages;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private Guna.UI2.WinForms.Guna2TextBox titre;
        private Guna.UI2.WinForms.Guna2TextBox editeur;
        private Guna.UI2.WinForms.Guna2TextBox nom;
        private Guna.UI2.WinForms.Guna2TextBox numero;
        private Guna.UI2.WinForms.Guna2TextBox periodicite;
        private Guna.UI2.WinForms.Guna2TextBox dateBox;
    }
}