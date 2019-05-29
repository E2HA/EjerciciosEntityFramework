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
    public partial class FormMascotas : Form
    {
        public FormMascotas()
        {
            InitializeComponent();
        }

        private void btnVolver_Click(object sender, EventArgs e)
        {
            Form1 menu = new Form1();
            menu.Show();
        }

        ProyectoEntities proyecto = new ProyectoEntities();
        private void Mostrar()
        {
            dgvMascotas.DataSource = proyecto.Mascota.ToList();
        }
        
        private void btnMostrar_Click(object sender, EventArgs e)
        {
            Mostrar();
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            Mascota mascota = new Mascota();
            mascota.Especie = txtEspecie.Text;
            mascota.Descripcion = txtDescripcion.Text;
            mascota.Raza = txtRaza.Text;
            proyecto.Mascota.Add(mascota);
            if (proyecto.SaveChanges() == 1)
            {
                MessageBox.Show("Mascota agregada correctamente");
            }
            else
            {
                MessageBox.Show("Mascota no agregadada correctamente");
            }
            Mostrar();
        }

        private void btnModificar_Click(object sender, EventArgs e)
        {
            int filtro = Convert.ToInt32(txtId.Text);
            var ModificarMascota = proyecto.Mascota.Where(x => x.Id == filtro).FirstOrDefault();
            ModificarMascota.Especie = txtEspecie.Text;
            ModificarMascota.Descripcion = txtDescripcion.Text;
            ModificarMascota.Raza = txtRaza.Text;
            if (proyecto.SaveChanges() == 1)
            {
                MessageBox.Show("Mascota modificada correctamente");
            }
            else
            {
                MessageBox.Show("Mascota no modificada correctamente");
            }
            Mostrar();
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            int filtro1 = Convert.ToInt32(txtId.Text);
            Mascota Borrar = proyecto.Mascota.Where(x => x.Id == filtro1).FirstOrDefault();
            proyecto.Mascota.Remove(Borrar);
            if (proyecto.SaveChanges() == 1)
            {
                MessageBox.Show("Mascota Eliminada correctamente");
            }
            else
            {
                MessageBox.Show("Mascota no Eliminada correctamente");
            }
            Mostrar();
        }
    }
}
