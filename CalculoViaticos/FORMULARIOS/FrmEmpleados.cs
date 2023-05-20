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
            empleados.actualizar(int.Parse(txtCodigo.Text), txtNombre.Text, txtApellido.Text, int.Parse(cmbPuesto.SelectedValue.ToString()), txtDni.Text, txtCorreo.Text, txtDireccion.Text);
            MessageBox.Show("Empleado actualizado correctamente");
            limpiar();
            metodos.MostrarEmpleados(dgEmpleados);
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
            int Codigo = int.Parse(dgEmpleados.CurrentRow.Cells[0].Value.ToString());
            empleados.borrar(Codigo);
            MessageBox.Show("Empleado eliminado correctamente");
            limpiar();
            metodos.MostrarEmpleados(dgEmpleados);
        }

        private void cmbPuesto_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
