﻿namespace CalculoViaticos.Reportes.Formularios
{
    partial class frmReporteMasViajes
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
            this.components = new System.ComponentModel.Container();
            Microsoft.Reporting.WinForms.ReportDataSource reportDataSource1 = new Microsoft.Reporting.WinForms.ReportDataSource();
            this.reportViewer1 = new Microsoft.Reporting.WinForms.ReportViewer();
            this.dataSet1 = new CalculoViaticos.Reportes.Conexiones.DataSet1();
            this.dataSet1BindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.reporteEmpleadoMasViajesBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.reporte_Empleado_Mas_ViajesTableAdapter = new CalculoViaticos.Reportes.Conexiones.DataSet1TableAdapters.Reporte_Empleado_Mas_ViajesTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.dataSet1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSet1BindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.reporteEmpleadoMasViajesBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // reportViewer1
            // 
            this.reportViewer1.Dock = System.Windows.Forms.DockStyle.Fill;
            reportDataSource1.Name = "DataSet1";
            reportDataSource1.Value = this.reporteEmpleadoMasViajesBindingSource;
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource1);
            this.reportViewer1.LocalReport.ReportEmbeddedResource = "CalculoViaticos.Reportes.Conexiones.Report2.rdlc";
            this.reportViewer1.Location = new System.Drawing.Point(0, 0);
            this.reportViewer1.Name = "reportViewer1";
            this.reportViewer1.ServerReport.BearerToken = null;
            this.reportViewer1.Size = new System.Drawing.Size(800, 450);
            this.reportViewer1.TabIndex = 0;
            // 
            // dataSet1
            // 
            this.dataSet1.DataSetName = "DataSet1";
            this.dataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // dataSet1BindingSource
            // 
            this.dataSet1BindingSource.DataSource = this.dataSet1;
            this.dataSet1BindingSource.Position = 0;
            // 
            // reporteEmpleadoMasViajesBindingSource
            // 
            this.reporteEmpleadoMasViajesBindingSource.DataMember = "Reporte_Empleado_Mas_Viajes";
            this.reporteEmpleadoMasViajesBindingSource.DataSource = this.dataSet1BindingSource;
            // 
            // reporte_Empleado_Mas_ViajesTableAdapter
            // 
            this.reporte_Empleado_Mas_ViajesTableAdapter.ClearBeforeFill = true;
            // 
            // frmReporteMasViajes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.reportViewer1);
            this.Name = "frmReporteMasViajes";
            this.Text = "frmReporteMasViajes";
            this.Load += new System.EventHandler(this.frmReporteMasViajes_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataSet1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSet1BindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.reporteEmpleadoMasViajesBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Microsoft.Reporting.WinForms.ReportViewer reportViewer1;
        private System.Windows.Forms.BindingSource reporteEmpleadoMasViajesBindingSource;
        private System.Windows.Forms.BindingSource dataSet1BindingSource;
        private Conexiones.DataSet1 dataSet1;
        private Conexiones.DataSet1TableAdapters.Reporte_Empleado_Mas_ViajesTableAdapter reporte_Empleado_Mas_ViajesTableAdapter;
    }
}