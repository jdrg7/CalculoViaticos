using CalculoViaticos.Clases;
using CalculoViaticos.CRUD;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CalculoViaticos.FORMULARIOS
{
    public partial class FrmEmpleados : Form
    {
        
        Metodos metodos = new Metodos();
        Empleados empleados = new Empleados();

        public FrmEmpleados()
        {
            InitializeComponent();
        }

        private void FrmEmpleados_Load(object sender, EventArgs e)
        {
            metodos.MostrarEmpleados(dgEmpleados);
            metodos.ListarPuestos(cmbPuesto);
            
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            empleados.guardar(txtNombre.Text, txtApellido.Text, int.Parse(cmbPuesto.SelectedValue.ToString()), txtDni.Text, txtCorreo.Text, txtDireccion.Text);
            MessageBox.Show("Empleado guardado exitosamente");
            limpiar();
            metodos.MostrarEmpleados(dgEmpleados);
        }

        private void btnActualizar_Click(object sender, EventArgs e)
        {
            try
            {
                empleados.actualizar(int.Parse(txtCodigo.Text), txtNombre.Text, txtApellido.Text, int.Parse(cmbPuesto.SelectedValue.ToString()), txtDni.Text, txtCorreo.Text, txtDireccion.Text);
                MessageBox.Show("Empleado actualizado correctamente");
                limpiar();
                metodos.MostrarEmpleados(dgEmpleados);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lo siento debe seleccionar un empleado");
            }
        }

        private void dgEmpleados_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            txtCodigo.Text = dgEmpleados.CurrentRow.Cells[0].Value.ToString();
            txtNombre.Text = dgEmpleados.CurrentRow.Cells[1].Value.ToString();
            txtApellido.Text = dgEmpleados.CurrentRow.Cells[2].Value.ToString();
            txtDni.Text = dgEmpleados.CurrentRow.Cells[3].Value.ToString();
            txtCorreo.Text = dgEmpleados.CurrentRow.Cells[4].Value.ToString();
            txtDireccion.Text = dgEmpleados.CurrentRow.Cells[5].Value.ToString();
            cmbPuesto.Text = dgEmpleados.CurrentRow.Cells[6].Value.ToString();
        }

        private void limpiar()
        {
            txtCodigo.Clear();
            txtNombre.Clear();
            txtDireccion.Clear();
            txtApellido.Clear();
            txtCorreo.Clear();
            txtDni.Clear();
            cmbPuesto.Text = dgEmpleados.CurrentRow.Cells[6].Value.ToString();
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            try
            {
                int Codigo = int.Parse(txtCodigo.Text);
                empleados.borrar(Codigo);
                MessageBox.Show("Empleado eliminado correctamente");
                limpiar();
                metodos.MostrarEmpleados(dgEmpleados);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lo siento debe selleccionar un empleado");
            }
        }

        private void cmbPuesto_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void txtNombre_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsLetter(e.KeyChar) && !char.IsControl(e.KeyChar))
            {
                e.Handled = true; // Bloquea la entrada del carácter no permitido
            }

        }

        private void txtApellido_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsLetter(e.KeyChar) && !char.IsControl(e.KeyChar))
            {
                e.Handled = true; // Bloquea la entrada del carácter no permitido
            }

        }

        private void txtDni_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar))
            {
                e.Handled = true; // Bloquea la entrada del carácter no permitido
            }
        }
    }
}
