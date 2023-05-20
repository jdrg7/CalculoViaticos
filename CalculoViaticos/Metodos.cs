using CalculoViaticos.CRUD;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using ComboBox = System.Windows.Forms.ComboBox;

namespace CalculoViaticos
{
    public class Metodos
    {
        public void MostrarEmpleados(DataGridView dgEmpleados)
        {
            Empleados empleados = new Empleados();
            dgEmpleados.DataSource = empleados.Mostrar();
        }

        public void ListarPuestos(ComboBox cmbPuesto)
        {
            Puestos objeto = new Puestos();
            cmbPuesto.DataSource = objeto.ListarPuestos();
            cmbPuesto.DisplayMember = "Puesto";
            cmbPuesto.ValueMember = "ID";
        }

        public void ListarEmpleados(ComboBox cmbEmpleados)
        {
            Puestos objeto = new Puestos();
            cmbEmpleados.DataSource = objeto.ListarEmpleados();
            cmbEmpleados.DisplayMember = "Nombre Completo";
            cmbEmpleados.ValueMember = "Codigo";
        }
    }
}
