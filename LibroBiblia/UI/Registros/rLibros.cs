using LibroBiblia.Entidades;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace LibroBiblia.UI.Registros
{
    public partial class rLibros : Form
    {
        public rLibros()
        {
            InitializeComponent();
        }

        private void Guardar_button_Click(object sender, EventArgs e)
        {
            Libros libro = LLenaClase();
            bool paso = false;

            if (Validar() != paso)
            {


                if (LibroId_numericUpDown.Value == 0)
                    paso = BLL.LibrosBLL.Guardar(libro);
                else
                    paso = BLL.LibrosBLL.Modificar(LLenaClase());

                if (paso)
                {
                    MessageBox.Show("Guardado!!", "Exito!!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show("No se Puso!!", "Fallo!!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
        }

        public bool Validar()
        {
            bool paso = true;
            if(Descripcion_textBox.Text == string.Empty)
            {
                errorProvider1.SetError(Descripcion_textBox, "Debe Introducir La Descripcion");
                paso = false;
            }
            else
            if(Siglas_textBox.Text == string.Empty)
            {
                errorProvider1.SetError(Siglas_textBox, "Debe Introducir Las Siglas");
                paso = false;
            }
            else
            if(TipoId_comboBox.Text == "")
            {
                errorProvider1.SetError(TipoId_comboBox, "Debe Seleccionar El Tipo De Id");
                paso = false;
            }
           
            return paso;
        }

        private Libros LLenaClase()
        {
            Libros libro = new Libros();
            libro.LibroId = Convert.ToInt32(LibroId_numericUpDown.Value);
            libro.Descripcion = Descripcion_textBox.Text;
            libro.Siglas = Siglas_textBox.Text;
            libro.TipoID = TipoId_comboBox.Text;

            return libro;

        }

        private void Nuevo_button_Click(object sender, EventArgs e)
        {
            LibroId_numericUpDown.Value = 0;
            Descripcion_textBox.Clear();
            Siglas_textBox.Clear();
            TipoId_comboBox.Text = "";

        }

        private void Eliminar_button_Click(object sender, EventArgs e)
        {
            int id = Convert.ToInt32(LibroId_numericUpDown.Value);
            if (BLL.LibrosBLL.Eliminar(id))
                MessageBox.Show("Eliminado!!", "Exito", MessageBoxButtons.OK, MessageBoxIcon.Information);
            else
                MessageBox.Show("No se pudo Eliminar!!", "Fallo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
        }
    }
}
