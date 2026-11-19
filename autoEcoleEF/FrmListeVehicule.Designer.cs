namespace autoEcoleEF
{
    partial class FrmListeVehicule
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
            this.bdgVehicule = new System.Windows.Forms.BindingSource(this.components);
            this.dgvVehicule = new System.Windows.Forms.DataGridView();
            this.numImmaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.modeleDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.couleurDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.enEtatDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnEnregistrer = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.bdgVehicule)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvVehicule)).BeginInit();
            this.SuspendLayout();
            // 
            // bdgVehicule
            // 
            this.bdgVehicule.DataSource = typeof(autoEcoleEF.vehicule);
            // 
            // dgvVehicule
            // 
            this.dgvVehicule.AutoGenerateColumns = false;
            this.dgvVehicule.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvVehicule.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.numImmaDataGridViewTextBoxColumn,
            this.modeleDataGridViewTextBoxColumn,
            this.couleurDataGridViewTextBoxColumn,
            this.enEtatDataGridViewTextBoxColumn});
            this.dgvVehicule.DataSource = this.bdgVehicule;
            this.dgvVehicule.Location = new System.Drawing.Point(46, 46);
            this.dgvVehicule.Name = "dgvVehicule";
            this.dgvVehicule.RowHeadersWidth = 62;
            this.dgvVehicule.RowTemplate.Height = 28;
            this.dgvVehicule.Size = new System.Drawing.Size(658, 392);
            this.dgvVehicule.TabIndex = 0;
            this.dgvVehicule.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvVehicule_CellContentClick);
            // 
            // numImmaDataGridViewTextBoxColumn
            // 
            this.numImmaDataGridViewTextBoxColumn.DataPropertyName = "numImma";
            this.numImmaDataGridViewTextBoxColumn.HeaderText = "numImma";
            this.numImmaDataGridViewTextBoxColumn.MinimumWidth = 8;
            this.numImmaDataGridViewTextBoxColumn.Name = "numImmaDataGridViewTextBoxColumn";
            this.numImmaDataGridViewTextBoxColumn.ReadOnly = true;
            this.numImmaDataGridViewTextBoxColumn.Width = 150;
            // 
            // modeleDataGridViewTextBoxColumn
            // 
            this.modeleDataGridViewTextBoxColumn.DataPropertyName = "modele";
            this.modeleDataGridViewTextBoxColumn.HeaderText = "modele";
            this.modeleDataGridViewTextBoxColumn.MinimumWidth = 8;
            this.modeleDataGridViewTextBoxColumn.Name = "modeleDataGridViewTextBoxColumn";
            this.modeleDataGridViewTextBoxColumn.ReadOnly = true;
            this.modeleDataGridViewTextBoxColumn.Width = 150;
            // 
            // couleurDataGridViewTextBoxColumn
            // 
            this.couleurDataGridViewTextBoxColumn.DataPropertyName = "couleur";
            this.couleurDataGridViewTextBoxColumn.HeaderText = "couleur";
            this.couleurDataGridViewTextBoxColumn.MinimumWidth = 8;
            this.couleurDataGridViewTextBoxColumn.Name = "couleurDataGridViewTextBoxColumn";
            this.couleurDataGridViewTextBoxColumn.ReadOnly = true;
            this.couleurDataGridViewTextBoxColumn.Width = 150;
            // 
            // enEtatDataGridViewTextBoxColumn
            // 
            this.enEtatDataGridViewTextBoxColumn.DataPropertyName = "enEtat";
            this.enEtatDataGridViewTextBoxColumn.HeaderText = "enEtat";
            this.enEtatDataGridViewTextBoxColumn.MinimumWidth = 8;
            this.enEtatDataGridViewTextBoxColumn.Name = "enEtatDataGridViewTextBoxColumn";
            this.enEtatDataGridViewTextBoxColumn.Width = 150;
            // 
            // btnEnregistrer
            // 
            this.btnEnregistrer.Location = new System.Drawing.Point(486, 12);
            this.btnEnregistrer.Name = "btnEnregistrer";
            this.btnEnregistrer.Size = new System.Drawing.Size(126, 34);
            this.btnEnregistrer.TabIndex = 1;
            this.btnEnregistrer.Text = "Enregistrer";
            this.btnEnregistrer.UseVisualStyleBackColor = true;
            // 
            // FrmListeVehicule
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(775, 450);
            this.Controls.Add(this.btnEnregistrer);
            this.Controls.Add(this.dgvVehicule);
            this.Name = "FrmListeVehicule";
            this.Text = "FrmListeVehicule";
            this.Load += new System.EventHandler(this.FrmListeVehicule_Load);
            ((System.ComponentModel.ISupportInitialize)(this.bdgVehicule)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvVehicule)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.BindingSource bdgVehicule;
        private System.Windows.Forms.DataGridView dgvVehicule;
        private System.Windows.Forms.DataGridViewTextBoxColumn numImmaDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn modeleDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn couleurDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn enEtatDataGridViewTextBoxColumn;
        private System.Windows.Forms.Button btnEnregistrer;
    }
}