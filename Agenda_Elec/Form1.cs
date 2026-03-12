using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Agenda_Elec
{
    public partial class Form1 : Form
    {

        private List <Contactos> Contactos =   new List<Contactos>();

        public Form1()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            Contactos Persona = new Contactos();
            Persona.Nombres = tbNombres.Text;
            Persona.Apellidos = tbApellidos.Text;
            Persona.FechNacimiento = tbFechNacimiento.Text;
            Persona.Direccion = tbDireccion.Text;
            Persona.Correo = tbCorreo.Text;
            Persona.NumeroMovil = tbNumMovil.Text;
            Persona.NumeroTelefono = tbNumTelefono.Text;
            Persona.Genero = tbGenero.Text;
            Persona.EstadoCivil = tbEstado.Text;
            Contactos.Add(Persona);
            actualizaVista();

        }
        private void actualizaVista()
        {
            dgvContactos.DataSource = null;
            dgvContactos.DataSource = Contactos;
        }

        private void btnNuevo_Click(object sender, EventArgs e)
        {
            tbNombres.Text = "";
            tbApellidos.Text = "";
            tbFechNacimiento.Text = "";
            tbDireccion.Text = "";
            tbCorreo.Text = "";
            tbNumMovil.Text = "";
            tbNumTelefono.Text = "";
            tbGenero.Text = "";
            tbEstado.Text = "";
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox6_TextChanged(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void Nombres_Click(object sender, EventArgs e)
        {

        }

        private void textBox5_TextChanged(object sender, EventArgs e)
        {

        }

        private void NumMovil_Click(object sender, EventArgs e)
        {

        }
        // Buscar: busca por nombre, apellido, correo o número móvil usando btnBuscar
        private void btnBuscar_Click(object sender, EventArgs e)
        {
            string termino = btnBuscar.Text.Trim().ToLower();
            if (string.IsNullOrEmpty(termino))
            {
                MessageBox.Show("Ingrese un término de búsqueda (nombre, apellido, correo o móvil).", "Buscar", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            // Buscar primer indice que coincida
            int indice = Contactos.FindIndex(c =>
                (!string.IsNullOrEmpty(c.Nombres) && c.Nombres.ToLower().Contains(termino)) ||
                (!string.IsNullOrEmpty(c.Apellidos) && c.Apellidos.ToLower().Contains(termino)) ||
                (!string.IsNullOrEmpty(c.Correo) && c.Correo.ToLower().Contains(termino)) ||
                (!string.IsNullOrEmpty(c.NumeroMovil) && c.NumeroMovil.ToLower().Contains(termino))
            );

            if (indice >= 0)
            {
                // Seleccionar fila en el DataGridView
                dgvContactos.ClearSelection();
                dgvContactos.Rows[indice].Selected = true;
                dgvContactos.FirstDisplayedScrollingRowIndex = indice;

                // Mostrar datos en los TextBox (opcional)
                CargarContactoEnCampos(Contactos[indice]);
            }
            else
            {
                MessageBox.Show("No se encontró ningún contacto que coincida.", "Buscar", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        // Modificar: actualiza el contacto seleccionado con los valores de los TextBox
        private void btnModificar_Click(object sender, EventArgs e)
        {
            if (dgvContactos.SelectedRows.Count == 0)
            {
                MessageBox.Show("Seleccione un contacto en la lista para modificar.", "Modificar", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            int indice = dgvContactos.SelectedRows[0].Index;
            if (indice < 0 || indice >= Contactos.Count) return;

            // Validaciones básicas (puedes ampliarlas)
            if (string.IsNullOrWhiteSpace(tbNombres.Text))
            {
                MessageBox.Show("El nombre no puede estar vacío.", "Validación", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // Actualizar objeto
            Contactos contacto = Contactos[indice];
            contacto.Nombres = tbNombres.Text.Trim();
            contacto.Apellidos = tbApellidos.Text.Trim();
            contacto.FechNacimiento = tbFechNacimiento.Text.Trim();
            contacto.Direccion = tbDireccion.Text.Trim();
            contacto.Correo = tbCorreo.Text.Trim();
            contacto.NumeroMovil = tbNumMovil.Text.Trim();
            contacto.NumeroTelefono = tbNumTelefono.Text.Trim();
            contacto.Genero = tbGenero.Text.Trim();
            contacto.EstadoCivil = tbEstado.Text.Trim();

            actualizaVista();
            dgvContactos.ClearSelection();
            dgvContactos.Rows[indice].Selected = true;
            MessageBox.Show("Contacto modificado correctamente.", "Modificar", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        // Eliminar: borra el contacto seleccionado (pide confirmación)
        private void btnEliminar_Click(object sender, EventArgs e)
        {
            if (dgvContactos.SelectedRows.Count == 0)
            {
                MessageBox.Show("Seleccione un contacto en la lista para eliminar.", "Eliminar", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            int indice = dgvContactos.SelectedRows[0].Index;
            if (indice < 0 || indice >= Contactos.Count) return;

            var resultado = MessageBox.Show($"¿Eliminar a {Contactos[indice].Nombres} {Contactos[indice].Apellidos}?", "Confirmar eliminación", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (resultado == DialogResult.Yes)
            {
                Contactos.RemoveAt(indice);
                actualizaVista();
                LimpiarCampos();
                MessageBox.Show("Contacto eliminado.", "Eliminar", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        // Método auxiliar para cargar un Contacto en los TextBox
        private void CargarContactoEnCampos(Contactos persona)
        {
            if (persona == null) return;
            tbNombres.Text = persona.Nombres;
            tbApellidos.Text = persona.Apellidos;
            tbFechNacimiento.Text = persona.FechNacimiento;
            tbDireccion.Text = persona.Direccion;
            tbCorreo.Text = persona.Correo;
            tbNumMovil.Text = persona.NumeroMovil;
            tbNumTelefono.Text = persona.NumeroTelefono;
            tbGenero.Text = persona.Genero;
            tbEstado.Text = persona.EstadoCivil;
        }

        // Método auxiliar para limpiar campos (puedes reutilizar btnNuevo_Click)
        private void LimpiarCampos()
        {
            tbNombres.Text = "";
            tbApellidos.Text = "";
            tbFechNacimiento.Text = "";
            tbDireccion.Text = "";
            tbCorreo.Text = "";
            tbNumMovil.Text = "";
            tbNumTelefono.Text = "";
            tbGenero.Text = "";
            tbEstado.Text = "";
            btnBuscar.Text = "";
        }

        private void Correo_Click(object sender, EventArgs e)
        {

        }
        private void dgvContactos_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void dgvContactos_DoubleClick(object sender, EventArgs e)
        {
            DataGridViewRow renglon = dgvContactos.SelectedRows[0];
            int indice = dgvContactos.Rows.IndexOf(renglon);
            Contactos Persona = Contactos[indice];
            tbNombres.Text = Persona.Nombres;
            tbApellidos.Text = Persona.Apellidos;
            tbFechNacimiento.Text = Persona.FechNacimiento;
            tbDireccion.Text = Persona.Direccion;
            tbCorreo.Text = Persona.Correo;
            tbNumMovil.Text = Persona.NumeroMovil;
            tbNumTelefono.Text = Persona.NumeroTelefono;
            tbGenero.Text = Persona.Genero;
            tbEstado.Text = Persona.EstadoCivil;
        }
    }
}
