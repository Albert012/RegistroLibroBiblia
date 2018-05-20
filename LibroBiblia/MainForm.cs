using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using LibroBiblia.UI.Registros;
namespace LibroBiblia
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        private void libroToolStripMenuItem_Click(object sender, EventArgs e)
        {
            rLibros libro = new rLibros();
            libro.ShowDialog();
        }

        private void salirToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Esta Saliendo!!", "Salida Del Sistema!!", MessageBoxButtons.OK, MessageBoxIcon.Stop);
            this.Close();
        }
    }
}
