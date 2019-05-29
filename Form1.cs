using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EjercicioEntityFramework
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnRecetas_Click(object sender, EventArgs e)
        {
            FormRecetas recetas = new FormRecetas();
            recetas.Show();
        }

        private void btnMascotas_Click(object sender, EventArgs e)
        {
            FormMascotas mascotas = new FormMascotas();
            mascotas.Show();
        }
    }
}
