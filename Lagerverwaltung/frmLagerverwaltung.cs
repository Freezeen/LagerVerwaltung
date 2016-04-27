using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lagerverwaltung
{
    public partial class frmLagerverwaltung : Form
    {
        public frmLagerverwaltung()
        {
            InitializeComponent();
        }

        private void frmLagerverwaltung_Load(object sender, EventArgs e)
        {

        }

        private void frmGameLauncher_FormClosing(object sender, FormClosingEventArgs e)
        {
            //try
            //{
            //    DialogResult result = MessageBox.Show("Soll die Anwendung beendet werden?", Application.ProductName, MessageBoxButtons.YesNo, MessageBoxIcon.None, MessageBoxDefaultButton.Button1);
            //    if (result == DialogResult.No)
            //        e.Cancel = true;
            //    else
            //        Funktionen.DateiSpeichern("Lagerdaten.csv");
            //}
            //catch
            //{
            //    MessageBox.Show("Die Daten konnten nicht gespeichert werden \noder es sind keine Daten verhanden.", Application.ProductName);
            //}

        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click_1(object sender, EventArgs e)
        {

        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void listView1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
