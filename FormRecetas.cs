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
    public partial class FormRecetas : Form
    {
        public FormRecetas()
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
            dgvRecetas.DataSource = proyecto.Recetas.ToList();
        }

        private void btnMostrar_Click(object sender, EventArgs e)
        {
            Mostrar();
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            Recetas recetas = new Recetas();
            recetas.Nombre = txtNombre.Text;
            recetas.Descripcion = txtDescripcion.Text;
            recetas.Origen = txtOrigen.Text;
            proyecto.Recetas.Add(recetas);
            if (proyecto.SaveChanges() == 1)
            {
                MessageBox.Show("Receta agregada correctamente");
            }
            else
            {
                MessageBox.Show("Receta no agregadada correctamente");
            }
            Mostrar();
        }

        private void btnModificar_Click(object sender, EventArgs e)
        {
            int filtro = Convert.ToInt32(txtId.Text);
            var ModificarReceta = proyecto.Recetas.Where(x => x.Id == filtro).FirstOrDefault();
            ModificarReceta.Nombre = txtNombre.Text;
            ModificarReceta.Descripcion = txtDescripcion.Text;
            ModificarReceta.Origen = txtOrigen.Text;
            if (proyecto.SaveChanges() == 1)
            {
                MessageBox.Show("Receta modificada correctamente");
            }
            else
            {
                MessageBox.Show("Receta no modificada correctamente");
            }
            Mostrar();
        }

        private void btnEliminar_Click_1(object sender, EventArgs e)
        {
            int Borrar = Convert.ToInt32(txtId.Text);
            using (ProyectoEntities BorrarReceta = new ProyectoEntities())
            {
                Recetas borrar = (from a in BorrarReceta.Recetas
                                  where a.Id == Borrar
                                  select a).First();

                BorrarReceta.Recetas.Remove(borrar);
                BorrarReceta.SaveChanges();
                MessageBox.Show("Receta eliminada correctamente");
                Mostrar();
            }
        }
    }
}
