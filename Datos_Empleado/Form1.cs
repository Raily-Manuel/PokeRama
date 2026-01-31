using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Datos_Empleado
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void textBox10_TextChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click_1(object sender, EventArgs e)
        {

        }

        private void btnguardar_Click(object sender, EventArgs e)
        {
            int id_empleado = txtid.TabIndex;
            string nombre = txtnombre.Text;
            string apellidos = txtapellidos.Text;
            string telefono = masktelefono.Text;
            string genero = txtgenero.Text;
            string direccion = txtdireccion.Text;
            string email = txtemail.Text;
            string cargo = txtcargo.Text;
            string salario = txtsalario.Text;
            string fecha_ingreso = maskfecha.Text;

            if (string.IsNullOrEmpty(txtid.Text) || string.IsNullOrEmpty(txtnombre.Text) || string.IsNullOrEmpty(txtapellidos.Text) || string.IsNullOrEmpty(txtgenero.Text) || string.IsNullOrEmpty(txtdireccion.Text) || string.IsNullOrEmpty(txtemail.Text) || string.IsNullOrEmpty(txtcargo.Text) || string.IsNullOrEmpty(txtsalario.Text))
            {
                MessageBox.Show("Complete el campo con los datos correspondientes");
            }
            if (masktelefono.MaskCompleted || maskfecha.MaskCompleted)
            {
                MessageBox.Show("Complete el campo correctamente");
                return;
            }
        }

        private void maskedTextBox1_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void lblgenero_Click(object sender, EventArgs e)
        {

        }
    }
}
