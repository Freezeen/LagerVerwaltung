namespace Lagerverwaltung
{
    partial class frmLagerverwaltung
    {
        /// <summary>
        /// Erforderliche Designervariable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Verwendete Ressourcen bereinigen.
        /// </summary>
        /// <param name="disposing">True, wenn verwaltete Ressourcen gelöscht werden sollen; andernfalls False.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Vom Windows Form-Designer generierter Code

        /// <summary>
        /// Erforderliche Methode für die Designerunterstützung.
        /// Der Inhalt der Methode darf nicht mit dem Code-Editor geändert werden.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmLagerverwaltung));
            this.btnHinzufügen = new System.Windows.Forms.Button();
            this.btnEntfernen = new System.Windows.Forms.Button();
            this.lblOrt = new System.Windows.Forms.Label();
            this.lblLagergröße = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.tbxLagerort = new System.Windows.Forms.TextBox();
            this.tbxLagergröße = new System.Windows.Forms.TextBox();
            this.tbxLagerbestand = new System.Windows.Forms.TextBox();
            this.cbxLager = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // btnHinzufügen
            // 
            this.btnHinzufügen.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btnHinzufügen.Location = new System.Drawing.Point(12, 43);
            this.btnHinzufügen.Name = "btnHinzufügen";
            this.btnHinzufügen.Size = new System.Drawing.Size(75, 23);
            this.btnHinzufügen.TabIndex = 1;
            this.btnHinzufügen.Text = "Hinzufügen";
            this.btnHinzufügen.UseVisualStyleBackColor = true;
            // 
            // btnEntfernen
            // 
            this.btnEntfernen.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btnEntfernen.Location = new System.Drawing.Point(163, 43);
            this.btnEntfernen.Name = "btnEntfernen";
            this.btnEntfernen.Size = new System.Drawing.Size(75, 23);
            this.btnEntfernen.TabIndex = 2;
            this.btnEntfernen.Text = "Entfernen";
            this.btnEntfernen.UseVisualStyleBackColor = true;
            // 
            // lblOrt
            // 
            this.lblOrt.AutoSize = true;
            this.lblOrt.BackColor = System.Drawing.Color.Transparent;
            this.lblOrt.Font = new System.Drawing.Font("Calibri", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblOrt.ForeColor = System.Drawing.Color.Black;
            this.lblOrt.Location = new System.Drawing.Point(9, 76);
            this.lblOrt.Name = "lblOrt";
            this.lblOrt.Size = new System.Drawing.Size(97, 18);
            this.lblOrt.TabIndex = 4;
            this.lblOrt.Text = "Lagerstandort:";
            this.lblOrt.Click += new System.EventHandler(this.label1_Click);
            // 
            // lblLagergröße
            // 
            this.lblLagergröße.AutoSize = true;
            this.lblLagergröße.BackColor = System.Drawing.Color.Transparent;
            this.lblLagergröße.Font = new System.Drawing.Font("Calibri", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblLagergröße.ForeColor = System.Drawing.Color.Black;
            this.lblLagergröße.Location = new System.Drawing.Point(9, 102);
            this.lblLagergröße.Name = "lblLagergröße";
            this.lblLagergröße.Size = new System.Drawing.Size(81, 18);
            this.lblLagergröße.TabIndex = 5;
            this.lblLagergröße.Text = "Lagergröße:";
            this.lblLagergröße.Click += new System.EventHandler(this.label1_Click_1);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Calibri", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Black;
            this.label1.Location = new System.Drawing.Point(9, 128);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(62, 18);
            this.label1.TabIndex = 6;
            this.label1.Text = "Bestand:";
            // 
            // tbxLagerort
            // 
            this.tbxLagerort.Location = new System.Drawing.Point(112, 73);
            this.tbxLagerort.Name = "tbxLagerort";
            this.tbxLagerort.Size = new System.Drawing.Size(126, 20);
            this.tbxLagerort.TabIndex = 8;
            // 
            // tbxLagergröße
            // 
            this.tbxLagergröße.Location = new System.Drawing.Point(112, 99);
            this.tbxLagergröße.Name = "tbxLagergröße";
            this.tbxLagergröße.Size = new System.Drawing.Size(126, 20);
            this.tbxLagergröße.TabIndex = 9;
            // 
            // tbxLagerbestand
            // 
            this.tbxLagerbestand.Location = new System.Drawing.Point(112, 125);
            this.tbxLagerbestand.Name = "tbxLagerbestand";
            this.tbxLagerbestand.Size = new System.Drawing.Size(56, 20);
            this.tbxLagerbestand.TabIndex = 10;
            this.tbxLagerbestand.TextChanged += new System.EventHandler(this.textBox3_TextChanged);
            // 
            // cbxLager
            // 
            this.cbxLager.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbxLager.FormattingEnabled = true;
            this.cbxLager.Location = new System.Drawing.Point(12, 12);
            this.cbxLager.Name = "cbxLager";
            this.cbxLager.Size = new System.Drawing.Size(226, 21);
            this.cbxLager.TabIndex = 12;
            // 
            // frmLagerverwaltung
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Black;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(268, 265);
            this.Controls.Add(this.cbxLager);
            this.Controls.Add(this.tbxLagerbestand);
            this.Controls.Add(this.tbxLagergröße);
            this.Controls.Add(this.tbxLagerort);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lblLagergröße);
            this.Controls.Add(this.lblOrt);
            this.Controls.Add(this.btnEntfernen);
            this.Controls.Add(this.btnHinzufügen);
            this.ForeColor = System.Drawing.SystemColors.Control;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.MaximizeBox = false;
            this.Name = "frmLagerverwaltung";
            this.ShowIcon = false;
            this.Text = "Lagerverwaltung";
            this.Load += new System.EventHandler(this.frmLagerverwaltung_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnHinzufügen;
        private System.Windows.Forms.Button btnEntfernen;
        private System.Windows.Forms.Label lblOrt;
        private System.Windows.Forms.Label lblLagergröße;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox tbxLagerort;
        private System.Windows.Forms.TextBox tbxLagergröße;
        private System.Windows.Forms.TextBox tbxLagerbestand;
        private System.Windows.Forms.ComboBox cbxLager;
    }
}

