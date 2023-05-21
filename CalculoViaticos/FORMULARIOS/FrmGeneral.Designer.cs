namespace CalculoViaticos
{
    partial class FrmGeneral
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.btSiguiente = new System.Windows.Forms.Button();
            this.btAtras = new System.Windows.Forms.Button();
            this.tpOtros = new System.Windows.Forms.TabPage();
            this.rtbDescripcionOtros = new System.Windows.Forms.RichTextBox();
            this.txtTotalOtros = new System.Windows.Forms.TextBox();
            this.txtXdiaotros = new System.Windows.Forms.TextBox();
            this.txtNodiasotro = new System.Windows.Forms.TextBox();
            this.label13 = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.label16 = new System.Windows.Forms.Label();
            this.label17 = new System.Windows.Forms.Label();
            this.label18 = new System.Windows.Forms.Label();
            this.tpTransporte = new System.Windows.Forms.TabPage();
            this.txtvenida = new System.Windows.Forms.TextBox();
            this.txttotaltrans = new System.Windows.Forms.TextBox();
            this.txtida = new System.Windows.Forms.TextBox();
            this.cmbtipotrans = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.tpHospedaje = new System.Windows.Forms.TabPage();
            this.txttotalhosp = new System.Windows.Forms.TextBox();
            this.txtasignacionxdiahosp = new System.Windows.Forms.TextBox();
            this.txtnodiashosp = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.tpAlimentacion = new System.Windows.Forms.TabPage();
            this.cmbEmpleado = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txttotalali = new System.Windows.Forms.TextBox();
            this.txtsubcena = new System.Windows.Forms.TextBox();
            this.txtsubdesayuno = new System.Windows.Forms.TextBox();
            this.txtsubalmuerzo = new System.Windows.Forms.TextBox();
            this.txtasignacioncena = new System.Windows.Forms.TextBox();
            this.txtasignacionalmuerzo = new System.Windows.Forms.TextBox();
            this.txtasignaciondesayuno = new System.Windows.Forms.TextBox();
            this.txtnodiascena = new System.Windows.Forms.TextBox();
            this.txtnodiasdesayuno = new System.Windows.Forms.TextBox();
            this.txtnodiasalmuerzo = new System.Windows.Forms.TextBox();
            this.lblTotal = new System.Windows.Forms.Label();
            this.lblSubtotal = new System.Windows.Forms.Label();
            this.lblAlimentacion = new System.Windows.Forms.Label();
            this.lblnodiasali = new System.Windows.Forms.Label();
            this.lblcena = new System.Windows.Forms.Label();
            this.asignacionxdiaalim = new System.Windows.Forms.Label();
            this.lblalmuerzo = new System.Windows.Forms.Label();
            this.lbldesayuno = new System.Windows.Forms.Label();
            this.tcGeneral = new System.Windows.Forms.TabControl();
            this.tpOtros.SuspendLayout();
            this.tpTransporte.SuspendLayout();
            this.tpHospedaje.SuspendLayout();
            this.tpAlimentacion.SuspendLayout();
            this.tcGeneral.SuspendLayout();
            this.SuspendLayout();
            // 
            // btSiguiente
            // 
            this.btSiguiente.Location = new System.Drawing.Point(958, 525);
            this.btSiguiente.Name = "btSiguiente";
            this.btSiguiente.Size = new System.Drawing.Size(110, 44);
            this.btSiguiente.TabIndex = 18;
            this.btSiguiente.Text = "SIGUIENTE";
            this.btSiguiente.UseVisualStyleBackColor = true;
            this.btSiguiente.Click += new System.EventHandler(this.btSiguiente_Click);
            // 
            // btAtras
            // 
            this.btAtras.Location = new System.Drawing.Point(47, 529);
            this.btAtras.Name = "btAtras";
            this.btAtras.Size = new System.Drawing.Size(110, 44);
            this.btAtras.TabIndex = 19;
            this.btAtras.Text = "ATRAS";
            this.btAtras.UseVisualStyleBackColor = true;
            this.btAtras.Visible = false;
            this.btAtras.Click += new System.EventHandler(this.btAtras_Click);
            // 
            // tpOtros
            // 
            this.tpOtros.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(40)))), ((int)(((byte)(70)))));
            this.tpOtros.Controls.Add(this.rtbDescripcionOtros);
            this.tpOtros.Controls.Add(this.txtTotalOtros);
            this.tpOtros.Controls.Add(this.txtXdiaotros);
            this.tpOtros.Controls.Add(this.txtNodiasotro);
            this.tpOtros.Controls.Add(this.label13);
            this.tpOtros.Controls.Add(this.label15);
            this.tpOtros.Controls.Add(this.label16);
            this.tpOtros.Controls.Add(this.label17);
            this.tpOtros.Controls.Add(this.label18);
            this.tpOtros.Location = new System.Drawing.Point(4, 25);
            this.tpOtros.Name = "tpOtros";
            this.tpOtros.Padding = new System.Windows.Forms.Padding(3);
            this.tpOtros.Size = new System.Drawing.Size(1013, 471);
            this.tpOtros.TabIndex = 3;
            this.tpOtros.Text = "OTROS";
            // 
            // rtbDescripcionOtros
            // 
            this.rtbDescripcionOtros.Location = new System.Drawing.Point(19, 167);
            this.rtbDescripcionOtros.Name = "rtbDescripcionOtros";
            this.rtbDescripcionOtros.Size = new System.Drawing.Size(268, 155);
            this.rtbDescripcionOtros.TabIndex = 64;
            this.rtbDescripcionOtros.Text = "";
            // 
            // txtTotalOtros
            // 
            this.txtTotalOtros.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.txtTotalOtros.Location = new System.Drawing.Point(313, 426);
            this.txtTotalOtros.Name = "txtTotalOtros";
            this.txtTotalOtros.Size = new System.Drawing.Size(161, 22);
            this.txtTotalOtros.TabIndex = 63;
            // 
            // txtXdiaotros
            // 
            this.txtXdiaotros.Location = new System.Drawing.Point(19, 426);
            this.txtXdiaotros.Name = "txtXdiaotros";
            this.txtXdiaotros.Size = new System.Drawing.Size(268, 22);
            this.txtXdiaotros.TabIndex = 59;
            this.txtXdiaotros.TextChanged += new System.EventHandler(this.txtXdiaotros_TextChanged);
            // 
            // txtNodiasotro
            // 
            this.txtNodiasotro.Location = new System.Drawing.Point(19, 358);
            this.txtNodiasotro.Name = "txtNodiasotro";
            this.txtNodiasotro.Size = new System.Drawing.Size(268, 22);
            this.txtNodiasotro.TabIndex = 55;
            this.txtNodiasotro.TextChanged += new System.EventHandler(this.txtNodiasotro_TextChanged);
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label13.ForeColor = System.Drawing.Color.White;
            this.label13.Location = new System.Drawing.Point(309, 400);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(122, 23);
            this.label13.TabIndex = 62;
            this.label13.Text = "TOTAL OTROS";
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label15.Font = new System.Drawing.Font("Elephant", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label15.ForeColor = System.Drawing.Color.White;
            this.label15.Location = new System.Drawing.Point(19, 35);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(294, 79);
            this.label15.TabIndex = 54;
            this.label15.Text = "OTROS";
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label16.ForeColor = System.Drawing.Color.White;
            this.label16.Location = new System.Drawing.Point(15, 332);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(110, 23);
            this.label16.TabIndex = 56;
            this.label16.Text = "No. DE DIAS";
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label17.ForeColor = System.Drawing.Color.White;
            this.label17.Location = new System.Drawing.Point(15, 400);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(190, 23);
            this.label17.TabIndex = 57;
            this.label17.Text = "ASIGNACION POR DIA";
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label18.ForeColor = System.Drawing.Color.White;
            this.label18.Location = new System.Drawing.Point(15, 141);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(216, 23);
            this.label18.TabIndex = 58;
            this.label18.Text = "ESPECIFIQUE IMPREVISTO";
            // 
            // tpTransporte
            // 
            this.tpTransporte.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(40)))), ((int)(((byte)(70)))));
            this.tpTransporte.Controls.Add(this.txtvenida);
            this.tpTransporte.Controls.Add(this.txttotaltrans);
            this.tpTransporte.Controls.Add(this.txtida);
            this.tpTransporte.Controls.Add(this.cmbtipotrans);
            this.tpTransporte.Controls.Add(this.label5);
            this.tpTransporte.Controls.Add(this.label9);
            this.tpTransporte.Controls.Add(this.label10);
            this.tpTransporte.Controls.Add(this.label11);
            this.tpTransporte.Controls.Add(this.label12);
            this.tpTransporte.Location = new System.Drawing.Point(4, 25);
            this.tpTransporte.Name = "tpTransporte";
            this.tpTransporte.Padding = new System.Windows.Forms.Padding(3);
            this.tpTransporte.Size = new System.Drawing.Size(1013, 471);
            this.tpTransporte.TabIndex = 2;
            this.tpTransporte.Text = "TRANSPORTE";
            // 
            // txtvenida
            // 
            this.txtvenida.Location = new System.Drawing.Point(18, 314);
            this.txtvenida.Name = "txtvenida";
            this.txtvenida.Size = new System.Drawing.Size(221, 22);
            this.txtvenida.TabIndex = 65;
            this.txtvenida.TextChanged += new System.EventHandler(this.txtvenida_TextChanged);
            // 
            // txttotaltrans
            // 
            this.txttotaltrans.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.txttotaltrans.Location = new System.Drawing.Point(18, 389);
            this.txttotaltrans.Name = "txttotaltrans";
            this.txttotaltrans.Size = new System.Drawing.Size(221, 22);
            this.txttotaltrans.TabIndex = 63;
            // 
            // txtida
            // 
            this.txtida.Location = new System.Drawing.Point(18, 240);
            this.txtida.Name = "txtida";
            this.txtida.Size = new System.Drawing.Size(221, 22);
            this.txtida.TabIndex = 55;
            this.txtida.TextChanged += new System.EventHandler(this.txtida_TextChanged);
            // 
            // cmbtipotrans
            // 
            this.cmbtipotrans.FormattingEnabled = true;
            this.cmbtipotrans.Items.AddRange(new object[] {
            "TRANSPORTE LOCAL",
            "TRANSPORTE AEREO",
            "TRANSPORTE TERRESTRE"});
            this.cmbtipotrans.Location = new System.Drawing.Point(18, 170);
            this.cmbtipotrans.Name = "cmbtipotrans";
            this.cmbtipotrans.Size = new System.Drawing.Size(221, 24);
            this.cmbtipotrans.TabIndex = 64;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.White;
            this.label5.Location = new System.Drawing.Point(14, 363);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(175, 23);
            this.label5.TabIndex = 62;
            this.label5.Text = "TOTAL TRANSPORTE";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label9.Font = new System.Drawing.Font("Elephant", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.ForeColor = System.Drawing.Color.White;
            this.label9.Location = new System.Drawing.Point(18, 26);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(548, 79);
            this.label9.TabIndex = 54;
            this.label9.Text = "TRANSPORTE";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.ForeColor = System.Drawing.Color.White;
            this.label10.Location = new System.Drawing.Point(14, 214);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(40, 23);
            this.label10.TabIndex = 56;
            this.label10.Text = "IDA";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.ForeColor = System.Drawing.Color.White;
            this.label11.Location = new System.Drawing.Point(14, 288);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(73, 23);
            this.label11.TabIndex = 57;
            this.label11.Text = "VENIDA";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.ForeColor = System.Drawing.Color.White;
            this.label12.Location = new System.Drawing.Point(14, 144);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(162, 23);
            this.label12.TabIndex = 58;
            this.label12.Text = "TIPO TRANSPORTE";
            // 
            // tpHospedaje
            // 
            this.tpHospedaje.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(40)))), ((int)(((byte)(70)))));
            this.tpHospedaje.Controls.Add(this.txttotalhosp);
            this.tpHospedaje.Controls.Add(this.txtasignacionxdiahosp);
            this.tpHospedaje.Controls.Add(this.txtnodiashosp);
            this.tpHospedaje.Controls.Add(this.label2);
            this.tpHospedaje.Controls.Add(this.label3);
            this.tpHospedaje.Controls.Add(this.label4);
            this.tpHospedaje.Controls.Add(this.label6);
            this.tpHospedaje.Controls.Add(this.label8);
            this.tpHospedaje.Location = new System.Drawing.Point(4, 25);
            this.tpHospedaje.Name = "tpHospedaje";
            this.tpHospedaje.Padding = new System.Windows.Forms.Padding(3);
            this.tpHospedaje.Size = new System.Drawing.Size(1013, 471);
            this.tpHospedaje.TabIndex = 1;
            this.tpHospedaje.Text = "HOSPEDAJE";
            // 
            // txttotalhosp
            // 
            this.txttotalhosp.Location = new System.Drawing.Point(27, 361);
            this.txttotalhosp.Name = "txttotalhosp";
            this.txttotalhosp.Size = new System.Drawing.Size(217, 22);
            this.txttotalhosp.TabIndex = 49;
            // 
            // txtasignacionxdiahosp
            // 
            this.txtasignacionxdiahosp.Location = new System.Drawing.Point(27, 292);
            this.txtasignacionxdiahosp.Name = "txtasignacionxdiahosp";
            this.txtasignacionxdiahosp.Size = new System.Drawing.Size(248, 22);
            this.txtasignacionxdiahosp.TabIndex = 45;
            this.txtasignacionxdiahosp.TextChanged += new System.EventHandler(this.txtasignacionxdiahosp_TextChanged);
            // 
            // txtnodiashosp
            // 
            this.txtnodiashosp.Location = new System.Drawing.Point(27, 223);
            this.txtnodiashosp.Name = "txtnodiashosp";
            this.txtnodiashosp.Size = new System.Drawing.Size(140, 22);
            this.txtnodiashosp.TabIndex = 37;
            this.txtnodiashosp.TextChanged += new System.EventHandler(this.txtnodiashosp_TextChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(23, 326);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(164, 23);
            this.label2.TabIndex = 48;
            this.label2.Text = "TOTAL HOSPEDAJE";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label3.Font = new System.Drawing.Font("Elephant", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(6, 21);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(494, 79);
            this.label3.TabIndex = 36;
            this.label3.Text = "HOSPEDAJE";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(23, 188);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(110, 23);
            this.label4.TabIndex = 38;
            this.label4.Text = "No. DE DIAS";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.White;
            this.label6.Location = new System.Drawing.Point(23, 257);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(190, 23);
            this.label6.TabIndex = 39;
            this.label6.Text = "ASIGNACION POR DIA";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.Color.White;
            this.label8.Location = new System.Drawing.Point(21, 144);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(264, 31);
            this.label8.TabIndex = 40;
            this.label8.Text = "HOTEL - 1 HABITACION";
            // 
            // tpAlimentacion
            // 
            this.tpAlimentacion.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(40)))), ((int)(((byte)(70)))));
            this.tpAlimentacion.Controls.Add(this.cmbEmpleado);
            this.tpAlimentacion.Controls.Add(this.label1);
            this.tpAlimentacion.Controls.Add(this.txttotalali);
            this.tpAlimentacion.Controls.Add(this.txtsubcena);
            this.tpAlimentacion.Controls.Add(this.txtsubdesayuno);
            this.tpAlimentacion.Controls.Add(this.txtsubalmuerzo);
            this.tpAlimentacion.Controls.Add(this.txtasignacioncena);
            this.tpAlimentacion.Controls.Add(this.txtasignacionalmuerzo);
            this.tpAlimentacion.Controls.Add(this.txtasignaciondesayuno);
            this.tpAlimentacion.Controls.Add(this.txtnodiascena);
            this.tpAlimentacion.Controls.Add(this.txtnodiasdesayuno);
            this.tpAlimentacion.Controls.Add(this.txtnodiasalmuerzo);
            this.tpAlimentacion.Controls.Add(this.lblTotal);
            this.tpAlimentacion.Controls.Add(this.lblSubtotal);
            this.tpAlimentacion.Controls.Add(this.lblAlimentacion);
            this.tpAlimentacion.Controls.Add(this.lblnodiasali);
            this.tpAlimentacion.Controls.Add(this.lblcena);
            this.tpAlimentacion.Controls.Add(this.asignacionxdiaalim);
            this.tpAlimentacion.Controls.Add(this.lblalmuerzo);
            this.tpAlimentacion.Controls.Add(this.lbldesayuno);
            this.tpAlimentacion.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.tpAlimentacion.Location = new System.Drawing.Point(4, 25);
            this.tpAlimentacion.Margin = new System.Windows.Forms.Padding(0);
            this.tpAlimentacion.Name = "tpAlimentacion";
            this.tpAlimentacion.Size = new System.Drawing.Size(1013, 471);
            this.tpAlimentacion.TabIndex = 0;
            this.tpAlimentacion.Text = "ALIMENTACION";
            // 
            // cmbEmpleado
            // 
            this.cmbEmpleado.FormattingEnabled = true;
            this.cmbEmpleado.Location = new System.Drawing.Point(877, 21);
            this.cmbEmpleado.Name = "cmbEmpleado";
            this.cmbEmpleado.Size = new System.Drawing.Size(121, 24);
            this.cmbEmpleado.TabIndex = 37;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(753, 15);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(117, 31);
            this.label1.TabIndex = 36;
            this.label1.Text = "Empleado";
            // 
            // txttotalali
            // 
            this.txttotalali.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.txttotalali.Location = new System.Drawing.Point(664, 373);
            this.txttotalali.Name = "txttotalali";
            this.txttotalali.Size = new System.Drawing.Size(140, 22);
            this.txttotalali.TabIndex = 35;
            this.txttotalali.Text = "0";
            this.txttotalali.TextChanged += new System.EventHandler(this.txttotalali_TextChanged);
            // 
            // txtsubcena
            // 
            this.txtsubcena.Location = new System.Drawing.Point(664, 307);
            this.txtsubcena.Name = "txtsubcena";
            this.txtsubcena.Size = new System.Drawing.Size(140, 22);
            this.txtsubcena.TabIndex = 33;
            this.txtsubcena.Text = "0";
            this.txtsubcena.TextChanged += new System.EventHandler(this.txtsubcena_TextChanged);
            // 
            // txtsubdesayuno
            // 
            this.txtsubdesayuno.Location = new System.Drawing.Point(664, 211);
            this.txtsubdesayuno.Name = "txtsubdesayuno";
            this.txtsubdesayuno.Size = new System.Drawing.Size(140, 22);
            this.txtsubdesayuno.TabIndex = 31;
            this.txtsubdesayuno.Text = "0";
            this.txtsubdesayuno.TextChanged += new System.EventHandler(this.txtsubdesayuno_TextChanged);
            // 
            // txtsubalmuerzo
            // 
            this.txtsubalmuerzo.Location = new System.Drawing.Point(664, 257);
            this.txtsubalmuerzo.Name = "txtsubalmuerzo";
            this.txtsubalmuerzo.Size = new System.Drawing.Size(140, 22);
            this.txtsubalmuerzo.TabIndex = 32;
            this.txtsubalmuerzo.Text = "0";
            this.txtsubalmuerzo.TextChanged += new System.EventHandler(this.txtsubalmuerzo_TextChanged);
            // 
            // txtasignacioncena
            // 
            this.txtasignacioncena.Location = new System.Drawing.Point(365, 307);
            this.txtasignacioncena.Name = "txtasignacioncena";
            this.txtasignacioncena.Size = new System.Drawing.Size(248, 22);
            this.txtasignacioncena.TabIndex = 6;
            this.txtasignacioncena.Text = "0";
            this.txtasignacioncena.TextChanged += new System.EventHandler(this.txtasignacioncena_TextChanged);
            // 
            // txtasignacionalmuerzo
            // 
            this.txtasignacionalmuerzo.Location = new System.Drawing.Point(365, 256);
            this.txtasignacionalmuerzo.Name = "txtasignacionalmuerzo";
            this.txtasignacionalmuerzo.Size = new System.Drawing.Size(248, 22);
            this.txtasignacionalmuerzo.TabIndex = 4;
            this.txtasignacionalmuerzo.Text = "0";
            this.txtasignacionalmuerzo.TextChanged += new System.EventHandler(this.txtasignacionalmuerzo_TextChanged);
            // 
            // txtasignaciondesayuno
            // 
            this.txtasignaciondesayuno.Location = new System.Drawing.Point(365, 211);
            this.txtasignaciondesayuno.Name = "txtasignaciondesayuno";
            this.txtasignaciondesayuno.Size = new System.Drawing.Size(248, 22);
            this.txtasignaciondesayuno.TabIndex = 2;
            this.txtasignaciondesayuno.Text = "0";
            this.txtasignaciondesayuno.TextChanged += new System.EventHandler(this.txtasignaciondesayuno_TextChanged);
            // 
            // txtnodiascena
            // 
            this.txtnodiascena.Location = new System.Drawing.Point(202, 307);
            this.txtnodiascena.Name = "txtnodiascena";
            this.txtnodiascena.Size = new System.Drawing.Size(140, 22);
            this.txtnodiascena.TabIndex = 5;
            this.txtnodiascena.Text = "0";
            this.txtnodiascena.TextChanged += new System.EventHandler(this.txtnodiascena_TextChanged);
            // 
            // txtnodiasdesayuno
            // 
            this.txtnodiasdesayuno.Location = new System.Drawing.Point(202, 211);
            this.txtnodiasdesayuno.Name = "txtnodiasdesayuno";
            this.txtnodiasdesayuno.Size = new System.Drawing.Size(140, 22);
            this.txtnodiasdesayuno.TabIndex = 1;
            this.txtnodiasdesayuno.Text = "0";
            this.txtnodiasdesayuno.TextChanged += new System.EventHandler(this.txtnodiasdesayuno_TextChanged);
            // 
            // txtnodiasalmuerzo
            // 
            this.txtnodiasalmuerzo.Location = new System.Drawing.Point(202, 257);
            this.txtnodiasalmuerzo.Name = "txtnodiasalmuerzo";
            this.txtnodiasalmuerzo.Size = new System.Drawing.Size(140, 22);
            this.txtnodiasalmuerzo.TabIndex = 3;
            this.txtnodiasalmuerzo.Text = "0";
            this.txtnodiasalmuerzo.TextChanged += new System.EventHandler(this.txtnodiasalmuerzo_TextChanged);
            // 
            // lblTotal
            // 
            this.lblTotal.AutoSize = true;
            this.lblTotal.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTotal.ForeColor = System.Drawing.Color.White;
            this.lblTotal.Location = new System.Drawing.Point(356, 361);
            this.lblTotal.Name = "lblTotal";
            this.lblTotal.Size = new System.Drawing.Size(257, 31);
            this.lblTotal.TabIndex = 34;
            this.lblTotal.Text = "TOTAL ALIMENTACION";
            // 
            // lblSubtotal
            // 
            this.lblSubtotal.AutoSize = true;
            this.lblSubtotal.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSubtotal.ForeColor = System.Drawing.Color.White;
            this.lblSubtotal.Location = new System.Drawing.Point(655, 161);
            this.lblSubtotal.Name = "lblSubtotal";
            this.lblSubtotal.Size = new System.Drawing.Size(125, 31);
            this.lblSubtotal.TabIndex = 30;
            this.lblSubtotal.Text = "SUBTOTAL";
            // 
            // lblAlimentacion
            // 
            this.lblAlimentacion.AutoSize = true;
            this.lblAlimentacion.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblAlimentacion.Font = new System.Drawing.Font("Elephant", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAlimentacion.ForeColor = System.Drawing.Color.White;
            this.lblAlimentacion.Location = new System.Drawing.Point(18, 21);
            this.lblAlimentacion.Name = "lblAlimentacion";
            this.lblAlimentacion.Size = new System.Drawing.Size(625, 79);
            this.lblAlimentacion.TabIndex = 18;
            this.lblAlimentacion.Text = "ALIMENTACION";
            // 
            // lblnodiasali
            // 
            this.lblnodiasali.AutoSize = true;
            this.lblnodiasali.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblnodiasali.ForeColor = System.Drawing.Color.White;
            this.lblnodiasali.Location = new System.Drawing.Point(193, 161);
            this.lblnodiasali.Name = "lblnodiasali";
            this.lblnodiasali.Size = new System.Drawing.Size(146, 31);
            this.lblnodiasali.TabIndex = 20;
            this.lblnodiasali.Text = "No. DE DIAS";
            // 
            // lblcena
            // 
            this.lblcena.AutoSize = true;
            this.lblcena.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblcena.ForeColor = System.Drawing.Color.White;
            this.lblcena.Location = new System.Drawing.Point(76, 299);
            this.lblcena.Name = "lblcena";
            this.lblcena.Size = new System.Drawing.Size(74, 31);
            this.lblcena.TabIndex = 24;
            this.lblcena.Text = "CENA";
            // 
            // asignacionxdiaalim
            // 
            this.asignacionxdiaalim.AutoSize = true;
            this.asignacionxdiaalim.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.asignacionxdiaalim.ForeColor = System.Drawing.Color.White;
            this.asignacionxdiaalim.Location = new System.Drawing.Point(356, 161);
            this.asignacionxdiaalim.Name = "asignacionxdiaalim";
            this.asignacionxdiaalim.Size = new System.Drawing.Size(254, 31);
            this.asignacionxdiaalim.TabIndex = 21;
            this.asignacionxdiaalim.Text = "ASIGNACION POR DIA";
            // 
            // lblalmuerzo
            // 
            this.lblalmuerzo.AutoSize = true;
            this.lblalmuerzo.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblalmuerzo.ForeColor = System.Drawing.Color.White;
            this.lblalmuerzo.Location = new System.Drawing.Point(29, 249);
            this.lblalmuerzo.Name = "lblalmuerzo";
            this.lblalmuerzo.Size = new System.Drawing.Size(139, 31);
            this.lblalmuerzo.TabIndex = 23;
            this.lblalmuerzo.Text = "ALMUERZO";
            // 
            // lbldesayuno
            // 
            this.lbldesayuno.AutoSize = true;
            this.lbldesayuno.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbldesayuno.ForeColor = System.Drawing.Color.White;
            this.lbldesayuno.Location = new System.Drawing.Point(30, 204);
            this.lbldesayuno.Name = "lbldesayuno";
            this.lbldesayuno.Size = new System.Drawing.Size(136, 31);
            this.lbldesayuno.TabIndex = 22;
            this.lbldesayuno.Text = "DESAYUNO";
            // 
            // tcGeneral
            // 
            this.tcGeneral.Controls.Add(this.tpAlimentacion);
            this.tcGeneral.Controls.Add(this.tpHospedaje);
            this.tcGeneral.Controls.Add(this.tpTransporte);
            this.tcGeneral.Controls.Add(this.tpOtros);
            this.tcGeneral.Location = new System.Drawing.Point(47, 23);
            this.tcGeneral.Multiline = true;
            this.tcGeneral.Name = "tcGeneral";
            this.tcGeneral.SelectedIndex = 0;
            this.tcGeneral.Size = new System.Drawing.Size(1021, 500);
            this.tcGeneral.TabIndex = 20;
            // 
            // FrmGeneral
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(40)))), ((int)(((byte)(70)))));
            this.ClientSize = new System.Drawing.Size(1106, 585);
            this.Controls.Add(this.tcGeneral);
            this.Controls.Add(this.btAtras);
            this.Controls.Add(this.btSiguiente);
            this.Name = "FrmGeneral";
            this.Text = "FrmGeneral";
            this.Load += new System.EventHandler(this.FrmGeneral_Load);
            this.tpOtros.ResumeLayout(false);
            this.tpOtros.PerformLayout();
            this.tpTransporte.ResumeLayout(false);
            this.tpTransporte.PerformLayout();
            this.tpHospedaje.ResumeLayout(false);
            this.tpHospedaje.PerformLayout();
            this.tpAlimentacion.ResumeLayout(false);
            this.tpAlimentacion.PerformLayout();
            this.tcGeneral.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button btSiguiente;
        private System.Windows.Forms.Button btAtras;
        private System.Windows.Forms.TabPage tpOtros;
        private System.Windows.Forms.RichTextBox rtbDescripcionOtros;
        private System.Windows.Forms.TextBox txtTotalOtros;
        private System.Windows.Forms.TextBox txtXdiaotros;
        private System.Windows.Forms.TextBox txtNodiasotro;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.Label label18;
        private System.Windows.Forms.TabPage tpTransporte;
        private System.Windows.Forms.TextBox txtvenida;
        private System.Windows.Forms.TextBox txttotaltrans;
        private System.Windows.Forms.TextBox txtida;
        private System.Windows.Forms.ComboBox cmbtipotrans;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.TabPage tpHospedaje;
        private System.Windows.Forms.TextBox txttotalhosp;
        private System.Windows.Forms.TextBox txtasignacionxdiahosp;
        private System.Windows.Forms.TextBox txtnodiashosp;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TabPage tpAlimentacion;
        private System.Windows.Forms.ComboBox cmbEmpleado;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txttotalali;
        private System.Windows.Forms.TextBox txtsubcena;
        private System.Windows.Forms.TextBox txtsubdesayuno;
        private System.Windows.Forms.TextBox txtsubalmuerzo;
        private System.Windows.Forms.TextBox txtasignacioncena;
        private System.Windows.Forms.TextBox txtasignacionalmuerzo;
        private System.Windows.Forms.TextBox txtasignaciondesayuno;
        private System.Windows.Forms.TextBox txtnodiascena;
        private System.Windows.Forms.TextBox txtnodiasdesayuno;
        private System.Windows.Forms.TextBox txtnodiasalmuerzo;
        private System.Windows.Forms.Label lblTotal;
        private System.Windows.Forms.Label lblSubtotal;
        private System.Windows.Forms.Label lblAlimentacion;
        private System.Windows.Forms.Label lblnodiasali;
        private System.Windows.Forms.Label lblcena;
        private System.Windows.Forms.Label asignacionxdiaalim;
        private System.Windows.Forms.Label lblalmuerzo;
        private System.Windows.Forms.Label lbldesayuno;
        private System.Windows.Forms.TabControl tcGeneral;
    }
}