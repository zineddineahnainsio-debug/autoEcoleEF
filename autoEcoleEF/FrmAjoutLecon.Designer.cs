namespace autoEcoleEF
{
    partial class FrmAjoutLecon
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.cmbEleve = new System.Windows.Forms.ComboBox();
            this.cmbHeure = new System.Windows.Forms.ComboBox();
            this.dtLecon = new System.Windows.Forms.DateTimePicker();
            this.radioButton1 = new System.Windows.Forms.RadioButton();
            this.rdButton1 = new System.Windows.Forms.RadioButton();
            this.button1 = new System.Windows.Forms.Button();
            this.bdgEleve = new System.Windows.Forms.BindingSource(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.bdgEleve)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(209, 95);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(48, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Elève";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(209, 135);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(44, 20);
            this.label2.TabIndex = 1;
            this.label2.Text = "Date";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(209, 175);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(53, 20);
            this.label3.TabIndex = 2;
            this.label3.Text = "Heure";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(209, 209);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(53, 20);
            this.label4.TabIndex = 3;
            this.label4.Text = "Durée";
            // 
            // cmbEleve
            // 
            this.cmbEleve.DataSource = this.bdgEleve;
            this.cmbEleve.FormattingEnabled = true;
            this.cmbEleve.Location = new System.Drawing.Point(300, 92);
            this.cmbEleve.Name = "cmbEleve";
            this.cmbEleve.Size = new System.Drawing.Size(121, 28);
            this.cmbEleve.TabIndex = 4;
            // 
            // cmbHeure
            // 
            this.cmbHeure.FormattingEnabled = true;
            this.cmbHeure.Location = new System.Drawing.Point(300, 172);
            this.cmbHeure.Name = "cmbHeure";
            this.cmbHeure.Size = new System.Drawing.Size(121, 28);
            this.cmbHeure.TabIndex = 5;
            // 
            // dtLecon
            // 
            this.dtLecon.Location = new System.Drawing.Point(300, 135);
            this.dtLecon.Name = "dtLecon";
            this.dtLecon.Size = new System.Drawing.Size(249, 26);
            this.dtLecon.TabIndex = 6;
            // 
            // radioButton1
            // 
            this.radioButton1.AutoSize = true;
            this.radioButton1.Location = new System.Drawing.Point(300, 205);
            this.radioButton1.Name = "radioButton1";
            this.radioButton1.Size = new System.Drawing.Size(109, 24);
            this.radioButton1.TabIndex = 7;
            this.radioButton1.TabStop = true;
            this.radioButton1.Text = "Une heure";
            this.radioButton1.UseVisualStyleBackColor = true;
            // 
            // rdButton1
            // 
            this.rdButton1.AutoSize = true;
            this.rdButton1.Location = new System.Drawing.Point(415, 205);
            this.rdButton1.Name = "rdButton1";
            this.rdButton1.Size = new System.Drawing.Size(124, 24);
            this.rdButton1.TabIndex = 8;
            this.rdButton1.TabStop = true;
            this.rdButton1.Text = "Deux heures";
            this.rdButton1.UseVisualStyleBackColor = true;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(260, 267);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(124, 41);
            this.button1.TabIndex = 9;
            this.button1.Text = "Enregistrer";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // bdgEleve
            // 
            this.bdgEleve.DataSource = typeof(autoEcoleEF.eleve);
            // 
            // FrmAjoutLecon
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.rdButton1);
            this.Controls.Add(this.radioButton1);
            this.Controls.Add(this.dtLecon);
            this.Controls.Add(this.cmbHeure);
            this.Controls.Add(this.cmbEleve);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "FrmAjoutLecon";
            this.Text = "Ajouter une leçon";
            ((System.ComponentModel.ISupportInitialize)(this.bdgEleve)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox cmbEleve;
        private System.Windows.Forms.ComboBox cmbHeure;
        private System.Windows.Forms.BindingSource bdgEleve;
        private System.Windows.Forms.DateTimePicker dtLecon;
        private System.Windows.Forms.RadioButton radioButton1;
        private System.Windows.Forms.RadioButton rdButton1;
        private System.Windows.Forms.Button button1;
    }
}