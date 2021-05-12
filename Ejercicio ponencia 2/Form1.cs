using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ejercicio_ponencia_2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
       

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            //MessageBox.Show("EL nombre es: " + txtNombre.Text);

            if (txtGenero.Text == "M" | txtGenero.Text == "m")
            {
                MessageBox.Show("E Sr." + txtNombre.Text + " a sido registado");
            }
            else 
            {
                bool v = (txtGenero.Text == "F" | txtGenero.Text == "f");
                MessageBox.Show("La Sra. " + txtNombre.Text + " a sido registrada");
            }
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            
        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
