namespace autoEcoleEF
{
    partial class FrmMenu
    {
        /// <summary>
        /// Variable nécessaire au concepteur.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Nettoyage des ressources utilisées.
        /// </summary>
        /// <param name="disposing">true si les ressources managées doivent être supprimées ; sinon, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Code généré par le Concepteur Windows Form

        /// <summary>
        /// Méthode requise pour la prise en charge du concepteur - ne modifiez pas
        /// le contenu de cette méthode avec l'éditeur de code.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.hhhhToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.quitterToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.Eleve = new System.Windows.Forms.ToolStripMenuItem();
            this.gérerToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.véhiculeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.gérerToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.listeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.leçonToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ajouterToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.validerToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.GripMargin = new System.Windows.Forms.Padding(2, 2, 0, 2);
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.hhhhToolStripMenuItem,
            this.Eleve,
            this.véhiculeToolStripMenuItem,
            this.leçonToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(930, 33);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // hhhhToolStripMenuItem
            // 
            this.hhhhToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.quitterToolStripMenuItem});
            this.hhhhToolStripMenuItem.Name = "hhhhToolStripMenuItem";
            this.hhhhToolStripMenuItem.Size = new System.Drawing.Size(78, 29);
            this.hhhhToolStripMenuItem.Text = "Fichier";
            // 
            // quitterToolStripMenuItem
            // 
            this.quitterToolStripMenuItem.Name = "quitterToolStripMenuItem";
            this.quitterToolStripMenuItem.Size = new System.Drawing.Size(169, 34);
            this.quitterToolStripMenuItem.Text = "Quitter";
            // 
            // Eleve
            // 
            this.Eleve.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.gérerToolStripMenuItem});
            this.Eleve.Name = "Eleve";
            this.Eleve.Size = new System.Drawing.Size(68, 29);
            this.Eleve.Text = "Elève";
            this.Eleve.Click += new System.EventHandler(this.FrmEleve_Click);
            // 
            // gérerToolStripMenuItem
            // 
            this.gérerToolStripMenuItem.Name = "gérerToolStripMenuItem";
            this.gérerToolStripMenuItem.Size = new System.Drawing.Size(156, 34);
            this.gérerToolStripMenuItem.Text = "Gérer";
            this.gérerToolStripMenuItem.Click += new System.EventHandler(this.gérerToolStripMenuItem_Click);
            // 
            // véhiculeToolStripMenuItem
            // 
            this.véhiculeToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.gérerToolStripMenuItem1,
            this.listeToolStripMenuItem});
            this.véhiculeToolStripMenuItem.Name = "véhiculeToolStripMenuItem";
            this.véhiculeToolStripMenuItem.Size = new System.Drawing.Size(92, 29);
            this.véhiculeToolStripMenuItem.Text = "Véhicule";
            // 
            // gérerToolStripMenuItem1
            // 
            this.gérerToolStripMenuItem1.Name = "gérerToolStripMenuItem1";
            this.gérerToolStripMenuItem1.Size = new System.Drawing.Size(156, 34);
            this.gérerToolStripMenuItem1.Text = "Gérer";
            // 
            // listeToolStripMenuItem
            // 
            this.listeToolStripMenuItem.Name = "listeToolStripMenuItem";
            this.listeToolStripMenuItem.Size = new System.Drawing.Size(156, 34);
            this.listeToolStripMenuItem.Text = "Liste";
            // 
            // leçonToolStripMenuItem
            // 
            this.leçonToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ajouterToolStripMenuItem,
            this.validerToolStripMenuItem});
            this.leçonToolStripMenuItem.Name = "leçonToolStripMenuItem";
            this.leçonToolStripMenuItem.Size = new System.Drawing.Size(74, 29);
            this.leçonToolStripMenuItem.Text = "Leçon";
            // 
            // ajouterToolStripMenuItem
            // 
            this.ajouterToolStripMenuItem.Name = "ajouterToolStripMenuItem";
            this.ajouterToolStripMenuItem.Size = new System.Drawing.Size(172, 34);
            this.ajouterToolStripMenuItem.Text = "Ajouter";
            // 
            // validerToolStripMenuItem
            // 
            this.validerToolStripMenuItem.Name = "validerToolStripMenuItem";
            this.validerToolStripMenuItem.Size = new System.Drawing.Size(172, 34);
            this.validerToolStripMenuItem.Text = "Valider";
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(61, 4);
            // 
            // FrmMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(930, 450);
            this.Controls.Add(this.menuStrip1);
            this.IsMdiContainer = true;
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "FrmMenu";
            this.Text = "Gestion des leçons de conduite";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem hhhhToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem leçonToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem quitterToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem gérerToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem gérerToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem listeToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ajouterToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem validerToolStripMenuItem;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        public System.Windows.Forms.ToolStripMenuItem véhiculeToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem Eleve;
    }
}

