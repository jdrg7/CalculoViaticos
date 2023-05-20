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

namespace CalculoViaticos
{
    public partial class FrmGeneral : Form
    {
        Alimentacion Alimentacion = new Alimentacion();
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

            if (tcGeneral.SelectedIndex == 2)
            {
                btSiguiente.Visible = true;
            }

            if (tcGeneral.SelectedIndex == 3)
            {
                btSiguiente.Text = "Finalizar";
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
        }

        private void txtnodiasdesayuno_TextChanged(object sender, EventArgs e)
        {
            diasDesayuno = int.Parse(txtnodiasdesayuno.Text);
            float subTotal = diasDesayuno * asignacionDesayuno;
            txtsubdesayuno.Text = subTotal.ToString();
        }

        private void txtasignaciondesayuno_TextChanged(object sender, EventArgs e)
        {
            asignacionDesayuno = float.Parse(txtasignaciondesayuno.Text);
            float subTotal = diasDesayuno * asignacionDesayuno;
            txtsubdesayuno.Text = subTotal.ToString();
        }

        private void txtsubdesayuno_TextChanged(object sender, EventArgs e)
        {
            totaldesayuno = float.Parse(txtsubdesayuno.Text);
            float subTotal = totaldesayuno + totalalmuerzo + totalcena;
            txttotalali.Text = subTotal.ToString();
        }

        private void txtsubalmuerzo_TextChanged(object sender, EventArgs e)
        {
            totalalmuerzo = float.Parse(txtsubalmuerzo.Text);
            float subTotal = totaldesayuno + totalalmuerzo + totalcena;
            txttotalali.Text = subTotal.ToString();
        }

        private void txtsubcena_TextChanged(object sender, EventArgs e)
        {
            totalcena = float.Parse(txtsubcena.Text);
            float subTotal = totaldesayuno + totalalmuerzo + totalcena;
            txttotalali.Text = subTotal.ToString();
        }

        private void txtnodiasalmuerzo_TextChanged(object sender, EventArgs e)
        {
            diasAlmuerzo = int.Parse(txtnodiasalmuerzo.Text);
            float subTotal = diasAlmuerzo * asignacionAlmuerzo;
            txtsubalmuerzo.Text = subTotal.ToString();
        }

        private void txtasignacionalmuerzo_TextChanged(object sender, EventArgs e)
        {
            asignacionAlmuerzo = float.Parse(txtasignacionalmuerzo.Text);
            float subTotal = diasAlmuerzo * asignacionAlmuerzo;
            txtsubalmuerzo.Text = subTotal.ToString();
        }

        private void txtnodiascena_TextChanged(object sender, EventArgs e)
        {
            diasCena = int.Parse(txtnodiascena.Text);
            float subTotal = diasCena * asignacionCena;
            txtsubcena.Text = subTotal.ToString();
        }

        private void txtasignacioncena_TextChanged(object sender, EventArgs e)
        {
            asignacionCena = float.Parse(txtasignacioncena.Text);
            float subTotal = diasCena * asignacionCena;
            txtsubcena.Text = subTotal.ToString();
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

    }
}
