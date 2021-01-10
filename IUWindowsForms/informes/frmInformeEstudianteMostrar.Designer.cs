
namespace IUWindowsForms.informes
{
    partial class frmInformeEstudianteMostrar
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
            this.personas1BindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dsEstudiante = new IUWindowsForms.DS.dsEstudiante();
            this.personas1TableAdapter = new IUWindowsForms.DS.dsEstudianteTableAdapters.Personas1TableAdapter();
            this.reportViewer1 = new Microsoft.Reporting.WinForms.ReportViewer();
            this.personas1BindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.personas1BindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsEstudiante)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.personas1BindingSource1)).BeginInit();
            this.SuspendLayout();
            // 
            // personas1BindingSource
            // 
            this.personas1BindingSource.DataMember = "Personas1";
            this.personas1BindingSource.DataSource = this.dsEstudiante;
            // 
            // dsEstudiante
            // 
            this.dsEstudiante.DataSetName = "dsEstudiante";
            this.dsEstudiante.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // personas1TableAdapter
            // 
            this.personas1TableAdapter.ClearBeforeFill = true;
            // 
            // reportViewer1
            // 
            this.reportViewer1.Dock = System.Windows.Forms.DockStyle.Fill;
            reportDataSource1.Name = "DataSet1";
            reportDataSource1.Value = this.personas1BindingSource1;
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource1);
            this.reportViewer1.LocalReport.ReportEmbeddedResource = "IUWindowsForms.informes.rptInformeEstudiantePorCedula.rdlc";
            this.reportViewer1.Location = new System.Drawing.Point(0, 0);
            this.reportViewer1.Name = "reportViewer1";
            this.reportViewer1.ServerReport.BearerToken = null;
            this.reportViewer1.Size = new System.Drawing.Size(800, 450);
            this.reportViewer1.TabIndex = 0;
            this.reportViewer1.Load += new System.EventHandler(this.reportViewer1_Load_1);
            // 
            // personas1BindingSource1
            // 
            this.personas1BindingSource1.DataMember = "Personas1";
            this.personas1BindingSource1.DataSource = this.dsEstudiante;
            // 
            // frmInformeEstudianteMostrar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.reportViewer1);
            this.Name = "frmInformeEstudianteMostrar";
            this.Text = "frmInformeEstudianteMostrar";
            this.Load += new System.EventHandler(this.frmInformeEstudianteMostrar_Load);
            ((System.ComponentModel.ISupportInitialize)(this.personas1BindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsEstudiante)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.personas1BindingSource1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.BindingSource personas1BindingSource;
        private DS.dsEstudiante dsEstudiante;
        private DS.dsEstudianteTableAdapters.Personas1TableAdapter personas1TableAdapter;
        private Microsoft.Reporting.WinForms.ReportViewer reportViewer1;
        private System.Windows.Forms.BindingSource personas1BindingSource1;
    }
}