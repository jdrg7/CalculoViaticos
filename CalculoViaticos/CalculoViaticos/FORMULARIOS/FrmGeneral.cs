using CalculoViaticos.Clases;
using CalculoViaticos.ConexionSql;
using CalculoViaticos.CRUD;
using CalculoViaticos.FORMULARIOS;
using Microsoft.Reporting.WinForms;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Controls;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace CalculoViaticos
{
    public partial class FrmGeneral : Form
    {
        Reporte reporte = new Reporte();
        private Form currentChildForm;
        int diasDesayuno = 0;
        float asignacionDesayuno = 0;
        int diasAlmuerzo = 0;
        float asignacionAlmuerzo = 0;
        int diasCena = 0;
        float asignacionCena = 0;
        int diashosp = 0;
        float asignacionHosp = 0;
        int ida = 0;
        int venida = 0;
        int diasOtro = 0;
        float asignacionOtro = 0;
        float totaldesayuno = 0;
        float totalalmuerzo = 0;
        float totalcena = 0;

        int alimentacion;
        int hospedaje;
        int transporte;
        int otros;

        public FrmGeneral()
        {
            InitializeComponent();
        }

        

        private void btSiguiente_Click(object sender, EventArgs e)
        {
            tcGeneral.SelectedIndex += 1;

            if (tcGeneral.SelectedIndex == 0)
            {
                btAtras.Visible = false;
            }
            else
            {
                btAtras.Visible = true;
            }

            if (tcGeneral.SelectedIndex == 3)
            {
                btSiguiente.Visible = false;
                btnGuardar.Visible = true;
            } else
            {
                btSiguiente.Visible = true;
                btnGuardar.Visible = false;
            }
        }

        private void btAtras_Click(object sender, EventArgs e)
        {
            tcGeneral.SelectedIndex -= 1;

            if (tcGeneral.SelectedIndex == 0)
            {
                btAtras.Visible = false;
            }
            else
            {
                btSiguiente.Visible = true;
            }
        }

        private void FrmGeneral_Load(object sender, EventArgs e)
        {
            Metodos metodos = new Metodos();
            metodos.ListarEmpleados(cmbEmpleado);
            metodos.ListarTipoTransporte(cmbtipotrans);
            metodos.ListarAlimentacion(cmbAlimentacion);
            metodos.ListarHospedaje(cmbHospedaje);
            metodos.ListarTransporte(cmbTransporte);
            metodos.ListarOtros(cmbOtros);


            alimentacion = cmbAlimentacion.Items.Count - 1;
            hospedaje = cmbHospedaje.Items.Count - 1;
            transporte = cmbTransporte.Items.Count - 1;
            otros = cmbOtros.Items.Count - 1;
            cmbAlimentacion.SelectedIndex = alimentacion;
            cmbHospedaje.SelectedIndex = hospedaje;
            cmbTransporte.SelectedIndex = transporte;
            cmbOtros.SelectedIndex = otros;

        }

        private void txtnodiasdesayuno_TextChanged(object sender, EventArgs e)
        {
            string texto = txtnodiasdesayuno.Text;

            if (string.IsNullOrEmpty(texto))
            {
                MessageBox.Show("El campo de texto no puede estar vacío.");
            }
            else
            {
                diasDesayuno = int.Parse(txtnodiasdesayuno.Text);
                float subTotal = diasDesayuno * asignacionDesayuno;
                txtsubdesayuno.Text = subTotal.ToString();
            }
        }

        private void txtasignaciondesayuno_TextChanged(object sender, EventArgs e)
        {
            string texto = txtasignaciondesayuno.Text;

            if (string.IsNullOrEmpty(texto))
            {
                MessageBox.Show("El campo de texto no puede estar vacío.");
            }
            else
            {
                asignacionDesayuno = float.Parse(txtasignaciondesayuno.Text);
                float subTotal = diasDesayuno * asignacionDesayuno;
                txtsubdesayuno.Text = subTotal.ToString();
            }
        }

        private void txtsubdesayuno_TextChanged(object sender, EventArgs e)
        {
            string texto = txtsubdesayuno.Text;

            if (string.IsNullOrEmpty(texto))
            {
                MessageBox.Show("El campo de texto no puede estar vacío.");
            }
            else
            {
                totaldesayuno = float.Parse(txtsubdesayuno.Text);
                float subTotal = totaldesayuno + totalalmuerzo + totalcena;
                txttotalali.Text = subTotal.ToString();
            }
        }

        private void txtsubalmuerzo_TextChanged(object sender, EventArgs e)
        {
            string texto = txtsubalmuerzo.Text;

            if (string.IsNullOrEmpty(texto))
            {
                MessageBox.Show("El campo de texto no puede estar vacío.");
            }
            else
            {
                totalalmuerzo = float.Parse(txtsubalmuerzo.Text);
                float subTotal = totaldesayuno + totalalmuerzo + totalcena;
                txttotalali.Text = subTotal.ToString();
            }
        }

        private void txtsubcena_TextChanged(object sender, EventArgs e)
        {
            string texto = txtsubcena.Text;

            if (string.IsNullOrEmpty(texto))
            {
                MessageBox.Show("El campo de texto no puede estar vacío.");
            }
            else
            {
                totalcena = float.Parse(txtsubcena.Text);
                float subTotal = totaldesayuno + totalalmuerzo + totalcena;
                txttotalali.Text = subTotal.ToString();
            }
        }

        private void txtnodiasalmuerzo_TextChanged(object sender, EventArgs e)
        {
            string texto = txtnodiasalmuerzo.Text;

            if (string.IsNullOrEmpty(texto))
            {
                MessageBox.Show("El campo de texto no puede estar vacío.");
            }
            else
            {
                diasAlmuerzo = int.Parse(txtnodiasalmuerzo.Text);
                float subTotal = diasAlmuerzo * asignacionAlmuerzo;
                txtsubalmuerzo.Text = subTotal.ToString();
            }
        }

        private void txtasignacionalmuerzo_TextChanged(object sender, EventArgs e)
        {
            string texto = txtasignacionalmuerzo.Text;

            if (string.IsNullOrEmpty(texto))
            {
                MessageBox.Show("El campo de texto no puede estar vacío.");
            }
            else
            {
                asignacionAlmuerzo = float.Parse(txtasignacionalmuerzo.Text);
                float subTotal = diasAlmuerzo * asignacionAlmuerzo;
                txtsubalmuerzo.Text = subTotal.ToString();
            }
        }

        private void txtnodiascena_TextChanged(object sender, EventArgs e)
        {
            string texto = txtnodiascena.Text;

            if (string.IsNullOrEmpty(texto))
            {
                MessageBox.Show("El campo de texto no puede estar vacío.");
            }
            else
            {
                diasCena = int.Parse(txtnodiascena.Text);
                float subTotal = diasCena * asignacionCena;
                txtsubcena.Text = subTotal.ToString();
            }
        }

        private void txtasignacioncena_TextChanged(object sender, EventArgs e)
        {
            string texto = txtasignacioncena.Text;

            if (string.IsNullOrEmpty(texto))
            {
                MessageBox.Show("El campo de texto no puede estar vacío.");
            }
            else
            {
                asignacionCena = float.Parse(txtasignacioncena.Text);
                float subTotal = diasCena * asignacionCena;
                txtsubcena.Text = subTotal.ToString();
            }
        }

        private void txttotalali_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtnodiashosp_TextChanged(object sender, EventArgs e)
        {
            diashosp = int.Parse(txtnodiashosp.Text);
            float subTotal = diashosp * asignacionHosp;
            txttotalhosp.Text = subTotal.ToString();
        }

        private void txtasignacionxdiahosp_TextChanged(object sender, EventArgs e)
        {
            asignacionHosp = float.Parse(txtasignacionxdiahosp.Text);
            float subTotal = diashosp * asignacionHosp;
            txttotalhosp.Text = subTotal.ToString();
        }

        private void txtida_TextChanged(object sender, EventArgs e)
        {
            ida = int.Parse(txtida.Text);
            float subTotal = ida + venida;
            txttotaltrans.Text = subTotal.ToString();
        }

        private void txtvenida_TextChanged(object sender, EventArgs e)
        {
            venida = int.Parse(txtvenida.Text);
            float subTotal = venida + ida;
            txttotaltrans.Text = subTotal.ToString();
        }

        private void txtNodiasotro_TextChanged(object sender, EventArgs e)
        {
            diasOtro = int.Parse(txtNodiasotro.Text);
            float subTotal = diasOtro * asignacionOtro;
            txtTotalOtros.Text = subTotal.ToString();
        }

        private void txtXdiaotros_TextChanged(object sender, EventArgs e)
        {
            asignacionOtro = float.Parse(txtXdiaotros.Text);
            float subTotal = diasOtro * asignacionOtro;
            txtTotalOtros.Text = subTotal.ToString();
        }

        private void btnFin_Click(object sender, EventArgs e)
        {
            
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            try
            {
                const string message = "¿Esta seguro de guardar? \n Si lo hace no podra editar el registro";
                const string caption = "Tecnasa Honduras";
                var result = MessageBox.Show(message, caption,
                                             MessageBoxButtons.YesNo,
                                             MessageBoxIcon.Warning);




                if (result == DialogResult.Yes)
                {
                    reporte.InsertarAlimentacion(int.Parse(txtnodiasdesayuno.Text), float.Parse(txtasignaciondesayuno.Text), int.Parse(txtnodiasalmuerzo.Text), float.Parse(txtasignacionalmuerzo.Text), int.Parse(txtnodiascena.Text), float.Parse(txtasignacioncena.Text), int.Parse(txtsubdesayuno.Text), int.Parse(txtsubalmuerzo.Text), int.Parse(txtsubcena.Text),
                        int.Parse(cmbEmpleado.SelectedValue.ToString()));

                    reporte.InsertarHospedaje(int.Parse(txtnodiashosp.Text), float.Parse(txtasignacionxdiahosp.Text), int.Parse(cmbEmpleado.SelectedValue.ToString()));
                    reporte.InsertarTransporte(int.Parse(cmbtipotrans.SelectedValue.ToString()), float.Parse(txtida.Text), float.Parse(txtvenida.Text), int.Parse(cmbEmpleado.SelectedValue.ToString()));
                    reporte.InsertarOtros(int.Parse(txtNodiasotro.Text), float.Parse(txtXdiaotros.Text), rtbDescripcionOtros.Text, int.Parse(cmbEmpleado.SelectedValue.ToString()));
                    MessageBox.Show("Datos guardados con exito");

                    Metodos metodos = new Metodos();
                    metodos.ListarAlimentacion(cmbAlimentacion);
                    metodos.ListarHospedaje(cmbHospedaje);
                    metodos.ListarTransporte(cmbTransporte);
                    metodos.ListarOtros(cmbOtros);
                    reporte.InsertarViaticos(dtpFechaSalida.Value, dtpFechaRegreso.Value, int.Parse(cmbTransporte.SelectedValue.ToString()), int.Parse(cmbAlimentacion.SelectedValue.ToString()), int.Parse(cmbHospedaje.SelectedValue.ToString()), int.Parse(cmbOtros.SelectedValue.ToString()), int.Parse(cmbEmpleado.SelectedValue.ToString()));

                    
                    btnGuardar.Visible = false;
                    btSiguiente.Visible = false;
                    btAtras.Visible = false;
                    frmViaticos frm = new frmViaticos();
                    frm.ShowDialog();
                }
        }
            catch (Exception ex)
            {
                MessageBox.Show("Lo siento error al guardar los datos");
            }
}
            

        private void dgViaticos_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            

            
        }
    }
}
