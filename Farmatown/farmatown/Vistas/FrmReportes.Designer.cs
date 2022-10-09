
namespace farmatown.Vistas
{
    partial class FrmReportes
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
            this.articulosMasVendidosBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.farmatown3DataSet1BindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.reportViewer1 = new Microsoft.Reporting.WinForms.ReportViewer();
            this.articulosVendidosBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dataVista = new farmatown.DataVista();
            this.articulosVendidosTableAdapter = new farmatown.DataVistaTableAdapters.articulosVendidosTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.articulosMasVendidosBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.farmatown3DataSet1BindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.articulosVendidosBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataVista)).BeginInit();
            this.SuspendLayout();
            // 
            // articulosMasVendidosBindingSource
            // 
            this.articulosMasVendidosBindingSource.DataMember = "articulosMasVendidos";
            // 
            // reportViewer1
            // 
            reportDataSource1.Name = "DataSet1";
            reportDataSource1.Value = this.articulosVendidosBindingSource;
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource1);
            this.reportViewer1.LocalReport.ReportEmbeddedResource = "farmatown.ReporteArticulo.rdlc";
            this.reportViewer1.Location = new System.Drawing.Point(59, 21);
            this.reportViewer1.Name = "reportViewer1";
            this.reportViewer1.ServerReport.BearerToken = null;
            this.reportViewer1.Size = new System.Drawing.Size(672, 322);
            this.reportViewer1.TabIndex = 0;
            // 
            // articulosVendidosBindingSource
            // 
            this.articulosVendidosBindingSource.DataMember = "articulosVendidos";
            this.articulosVendidosBindingSource.DataSource = this.dataVista;
            // 
            // dataVista
            // 
            this.dataVista.DataSetName = "DataVista";
            this.dataVista.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // articulosVendidosTableAdapter
            // 
            this.articulosVendidosTableAdapter.ClearBeforeFill = true;
            // 
            // FrmReportes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(966, 450);
            this.Controls.Add(this.reportViewer1);
            this.Name = "FrmReportes";
            this.Text = "FromReportes";
            this.Load += new System.EventHandler(this.FrmReportes_Load);
            ((System.ComponentModel.ISupportInitialize)(this.articulosMasVendidosBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.farmatown3DataSet1BindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.articulosVendidosBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataVista)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.BindingSource farmatown3DataSet1BindingSource;

        private System.Windows.Forms.BindingSource articulosMasVendidosBindingSource;
        private Microsoft.Reporting.WinForms.ReportViewer reportViewer1;
        private DataVista dataVista;
        private System.Windows.Forms.BindingSource articulosVendidosBindingSource;
        private DataVistaTableAdapters.articulosVendidosTableAdapter articulosVendidosTableAdapter;
    }
}