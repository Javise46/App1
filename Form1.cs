using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ejercicio_1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

            Etiqueta1.Text = "Hola Como Estas.";
            Etiqueta2.Text = "Bien y Tu?";
            Etiqueta3.Text = "Pues Bien ahi pasando el rato.";
            Etiqueta4.Text = "Oh que bien.";
            Etiqueta5.Text = "Me tengo que ir Adios.";
            Etiqueta6.Text = "Yo tambien Adios.";
           
        }
    }
}
