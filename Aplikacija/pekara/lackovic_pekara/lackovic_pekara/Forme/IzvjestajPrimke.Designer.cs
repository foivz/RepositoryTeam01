namespace PI.Forme
{
    partial class IzvjestajPrimke
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
            Microsoft.Reporting.WinForms.ReportDataSource reportDataSource2 = new Microsoft.Reporting.WinForms.ReportDataSource();
            this.bazaBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.baza = new PI.baza();
            this.poslovnipartnerBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.reportViewer1 = new Microsoft.Reporting.WinForms.ReportViewer();
            this.poslovnipartnerTableAdapter = new PI.bazaTableAdapters.poslovnipartnerTableAdapter();
            this.poslovnipartnerBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.repromaterijalproizvodBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.repromaterijalproizvodTableAdapter = new PI.bazaTableAdapters.repromaterijalproizvodTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.bazaBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.baza)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.poslovnipartnerBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.poslovnipartnerBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repromaterijalproizvodBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // bazaBindingSource
            // 
            this.bazaBindingSource.DataSource = this.baza;
            this.bazaBindingSource.Position = 0;
            // 
            // baza
            // 
            this.baza.DataSetName = "baza";
            this.baza.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // poslovnipartnerBindingSource
            // 
            this.poslovnipartnerBindingSource.DataMember = "poslovnipartner";
            this.poslovnipartnerBindingSource.DataSource = this.baza;
            // 
            // reportViewer1
            // 
            reportDataSource1.Name = "DataSet1";
            reportDataSource1.Value = this.poslovnipartnerBindingSource1;
            reportDataSource2.Name = "DataSet2";
            reportDataSource2.Value = this.repromaterijalproizvodBindingSource;
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource1);
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource2);
            this.reportViewer1.LocalReport.ReportEmbeddedResource = "PI.Forme.Primka.rdlc";
            this.reportViewer1.Location = new System.Drawing.Point(12, 12);
            this.reportViewer1.Name = "reportViewer1";
            this.reportViewer1.Size = new System.Drawing.Size(916, 582);
            this.reportViewer1.TabIndex = 0;
            // 
            // poslovnipartnerTableAdapter
            // 
            this.poslovnipartnerTableAdapter.ClearBeforeFill = true;
            // 
            // poslovnipartnerBindingSource1
            // 
            this.poslovnipartnerBindingSource1.DataMember = "poslovnipartner";
            this.poslovnipartnerBindingSource1.DataSource = this.bazaBindingSource;
            // 
            // repromaterijalproizvodBindingSource
            // 
            this.repromaterijalproizvodBindingSource.DataMember = "repromaterijalproizvod";
            this.repromaterijalproizvodBindingSource.DataSource = this.bazaBindingSource;
            // 
            // repromaterijalproizvodTableAdapter
            // 
            this.repromaterijalproizvodTableAdapter.ClearBeforeFill = true;
            // 
            // IzvjestajPrimke
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(940, 606);
            this.Controls.Add(this.reportViewer1);
            this.Name = "IzvjestajPrimke";
            this.Text = "IzvjestajPrimke";
            this.Load += new System.EventHandler(this.IzvjestajPrimke_Load);
            ((System.ComponentModel.ISupportInitialize)(this.bazaBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.baza)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.poslovnipartnerBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.poslovnipartnerBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repromaterijalproizvodBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Microsoft.Reporting.WinForms.ReportViewer reportViewer1;
        private System.Windows.Forms.BindingSource poslovnipartnerBindingSource;
        private baza baza;
        private bazaTableAdapters.poslovnipartnerTableAdapter poslovnipartnerTableAdapter;
        private System.Windows.Forms.BindingSource bazaBindingSource;
        private System.Windows.Forms.BindingSource poslovnipartnerBindingSource1;
        private System.Windows.Forms.BindingSource repromaterijalproizvodBindingSource;
        private bazaTableAdapters.repromaterijalproizvodTableAdapter repromaterijalproizvodTableAdapter;
    }
}