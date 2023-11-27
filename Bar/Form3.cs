using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Bar
{
    public partial class Form3 : Form
    {
        public Form3()
        {
            InitializeComponent();
        }

        private void Form3_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
                // Realizar la validación de los campos
                if (string.IsNullOrEmpty(nombre.Text) ||
                    string.IsNullOrEmpty(materno.Text) ||
                    string.IsNullOrEmpty(paterno.Text) ||
                    string.IsNullOrEmpty(edad.Text) ||
                    string.IsNullOrEmpty(telefono.Text) ||
                    string.IsNullOrEmpty(curp.Text) ||
                    string.IsNullOrEmpty(salario.Text) ||
                    string.IsNullOrEmpty(ingreso.Text))
                {
                    // Mostrar mensaje de error si falta algún campo por llenar
                    MessageBox.Show("Todos los campos son obligatorios. Por favor, llene todos los campos.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    // Si todos los campos están llenos, realizar alguna acción (puede ser guardar los datos, etc.)
                    MessageBox.Show("Registro exitoso", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                Hide();
                Form4 bebidas = new Form4();
                bebidas.Show();

                }
            }
    }
}
