using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Tarea2
{
    public partial class Promedio : Form
    {
        public Promedio()
        {
            InitializeComponent();
        }

        private void Calcularbutton_Click(object sender, EventArgs e)
        {
            int nota1 = 0;
            int nota2 = 0;
            int nota3 = 0;
            int nota4 = 0;
            int prom = (nota1 + nota2 + nota3 + nota4) / 4;

            nota1 = Convert.ToInt32(Nota1TextBox.Text);
            nota2 = Convert.ToInt32(Nota2TextBox.Text);
            nota3 = Convert.ToInt32(Nota3TextBox.Text);
            nota4 = Convert.ToInt32(Nota4TextBox.Text);

            if (prom < 65)
            {
                MessageBox.Show("Reprobado");
            }
            else 
            {
                MessageBox.Show("Aprobado");
            }
            PromTextBox.Text=prom.ToString();
            

            
}
