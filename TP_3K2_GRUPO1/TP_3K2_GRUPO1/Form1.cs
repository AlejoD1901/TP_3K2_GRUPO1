using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TP_3K2_GRUPO1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            string usuariopermitido;
            usuariopermitido = "admin";

            string contrapermitida;
            contrapermitida = "FACUNDO091123";

            var usuarioIngresado = TxtUsuario.Text.Trim();
            var contraIngresada = TxtContra.Text;

            if (usuarioIngresado == usuariopermitido && contraIngresada == contrapermitida)
            {
                MessageBox.Show("Hola Admin!!", "Bienvenido", MessageBoxButtons.YesNoCancel);
            }
            else
            {
                MessageBox.Show("Usuario y/o contra invalida", "Bienvenido", MessageBoxButtons.YesNoCancel);
            }
        }
    }
}
