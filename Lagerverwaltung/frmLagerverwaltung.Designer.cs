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
            resources.ApplyResources(this.btnHinzufügen, "btnHinzufügen");
            this.btnHinzufügen.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btnHinzufügen.Name = "btnHinzufügen";
            this.btnHinzufügen.UseVisualStyleBackColor = true;
            // 
            // btnEntfernen
            // 
            resources.ApplyResources(this.btnEntfernen, "btnEntfernen");
            this.btnEntfernen.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btnEntfernen.Name = "btnEntfernen";
            this.btnEntfernen.UseVisualStyleBackColor = true;
            // 
            // lblOrt
            // 
            resources.ApplyResources(this.lblOrt, "lblOrt");
            this.lblOrt.BackColor = System.Drawing.Color.Transparent;
            this.lblOrt.ForeColor = System.Drawing.Color.White;
            this.lblOrt.Name = "lblOrt";
            this.lblOrt.Click += new System.EventHandler(this.label1_Click);
            // 
            // lblLagergröße
            // 
            resources.ApplyResources(this.lblLagergröße, "lblLagergröße");
            this.lblLagergröße.BackColor = System.Drawing.Color.Transparent;
            this.lblLagergröße.ForeColor = System.Drawing.Color.White;
            this.lblLagergröße.Name = "lblLagergröße";
            this.lblLagergröße.Click += new System.EventHandler(this.label1_Click_1);
            // 
            // label1
            // 
            resources.ApplyResources(this.label1, "label1");
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Name = "label1";
            // 
            // tbxLagerort
            // 
            resources.ApplyResources(this.tbxLagerort, "tbxLagerort");
            this.tbxLagerort.Name = "tbxLagerort";
            // 
            // tbxLagergröße
            // 
            resources.ApplyResources(this.tbxLagergröße, "tbxLagergröße");
            this.tbxLagergröße.Name = "tbxLagergröße";
            // 
            // tbxLagerbestand
            // 
            resources.ApplyResources(this.tbxLagerbestand, "tbxLagerbestand");
            this.tbxLagerbestand.Name = "tbxLagerbestand";
            this.tbxLagerbestand.TextChanged += new System.EventHandler(this.textBox3_TextChanged);
            // 
            // cbxLager
            // 
            resources.ApplyResources(this.cbxLager, "cbxLager");
            this.cbxLager.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbxLager.FormattingEnabled = true;
            this.cbxLager.Name = "cbxLager";
            // 
            // frmLagerverwaltung
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Black;
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

