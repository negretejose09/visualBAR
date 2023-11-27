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
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form3 trabajador = new Form3();
            trabajador.Show();
            Hide();
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
           
            if (string.IsNullOrEmpty(usuario.Text) ||
                string.IsNullOrEmpty(nombre.Text) ||
                string.IsNullOrEmpty(apellidos.Text) ||
                string.IsNullOrEmpty(contraseña.Text) ||
                string.IsNullOrEmpty(gmail.Text) ||
                string.IsNullOrEmpty(edad.Text) ||
                string.IsNullOrEmpty(cargo.Text) ||
                string.IsNullOrEmpty(horario.Text))
            {
                
                MessageBox.Show("Todos los campos son obligatorios. Por favor, llene todos los campos.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                MessageBox.Show("Registro exitoso", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                Hide();
                Form4 bebidas = new Form4();
                bebidas.Show();
            }
        

        }
    }
}
