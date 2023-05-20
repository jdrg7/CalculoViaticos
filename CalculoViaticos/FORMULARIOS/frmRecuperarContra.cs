﻿using CalculoViaticos.ConexionSql;
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
    public partial class frmRecuperarContra : Form
    {
        public frmRecuperarContra()
        {
            InitializeComponent();
        }

        private void btnEnviarCorreo_Click(object sender, EventArgs e)
        {
            var user = new InicioSesion();
            var rsultado = user.recoverPassword(tctCorreo.Text);
            lblMessage.Text = rsultado.ToString();
        }
    }
}
