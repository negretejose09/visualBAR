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
    public partial class Form4 : Form
    {

        public Form4()
        {
            InitializeComponent();

        }





        private void button7_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Form2 usuario = new Form2();
            usuario.Show();
            Hide();

        }

        private void textBoxdos_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBoxtres_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBoxcuatro_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBoxocho_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBoxsiete_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBoxseis_TextChanged(object sender, EventArgs e)
        {

        }

        private void añadir_Click(object sender, EventArgs e)
        {
            try
            {
                DataGridViewRow renglon = (DataGridViewRow)dataGridView2.Rows[0].Clone();

                renglon.Cells[0].Value = textBoxuno.Text;
                renglon.Cells[1].Value = textBoxdos.Text;
                renglon.Cells[2].Value = textBoxtres.Text;
                renglon.Cells[3].Value = textBoxcuatro.Text;
                renglon.Cells[4].Value = textBoxcinco.Text;
                renglon.Cells[5].Value = textBoxseis.Text;
                renglon.Cells[6].Value = textBoxsiete.Text;
                renglon.Cells[7].Value = textBoxocho.Text;

                dataGridView2.Rows.Add(renglon);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Agregando producto",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void eliminar_Click(object sender, EventArgs e)
        {
            string mensaje = "¿Deseo eliminar el registro";
            string titulo = "eliminando el registro";

            if (!(dataGridView2.CurrentRow is null))
            {
                if (MessageBox.Show(mensaje, titulo, MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    try
                    {
                        dataGridView2.Rows.Remove(dataGridView2.CurrentRow);
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.Message, "Estudiante Eliminado",
                            MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
            else
            {
                MessageBox.Show("debes seleccionar un rengoln", "Eliminado Estudiante",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void editar_Click(object sender, EventArgs e)
        {
            if (dataGridView2.SelectedRows.Count <= 0)
            {
                MessageBox.Show("selecciona un renglon", "correciones", MessageBoxButtons.OK,
                    MessageBoxIcon.Information);
            }
            else
            {
                textBoxuno.Text = dataGridView2.CurrentRow.Cells["codigoss"].Value.ToString();
                textBoxdos.Text = dataGridView2.CurrentRow.Cells["precioventass"].Value.ToString();
                textBoxtres.Text = dataGridView2.CurrentRow.Cells["tiporefrescoss"].Value.ToString();
                textBoxcuatro.Text = dataGridView2.CurrentRow.Cells["recomendadoparaa"].Value.ToString();
                textBoxcinco.Text = dataGridView2.CurrentRow.Cells["nombress"].Value.ToString();
                textBoxseis.Text = dataGridView2.CurrentRow.Cells["costoss"].Value.ToString();
                textBoxsiete.Text = dataGridView2.CurrentRow.Cells["tipoalcoholl"].Value.ToString();
                textBoxocho.Text = dataGridView2.CurrentRow.Cells["horarioo"].Value.ToString();
            }
        }

        private void buscar_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Ingresa los datos de el producto y el trabajador, " +
"usa los botones que te ayudaran en poner columnas, " +
"eliminar estas columnas y modificarlas :)", "ayuda", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
    }
}