namespace PI.Forme
{
    partial class IzvjestajPredatnice
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
            this.bazaBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.baza = new PI.baza();
            this.reportViewer1 = new Microsoft.Reporting.WinForms.ReportViewer();
            this.poslovnipartnerBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.poslovnipartnerTableAdapter = new PI.bazaTableAdapters.poslovnipartnerTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.bazaBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.baza)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.poslovnipartnerBindingSource)).BeginInit();
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
            // reportViewer1
            // 
            reportDataSource1.Name = "DataSet1";
            reportDataSource1.Value = this.poslovnipartnerBindingSource;
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource1);
            this.reportViewer1.LocalReport.ReportEmbeddedResource = "PI.Forme.Predatnica.rdlc";
            this.reportViewer1.Location = new System.Drawing.Point(12, 12);
            this.reportViewer1.Name = "reportViewer1";
            this.reportViewer1.Size = new System.Drawing.Size(777, 361);
            this.reportViewer1.TabIndex = 0;
            // 
            // poslovnipartnerBindingSource
            // 
            this.poslovnipartnerBindingSource.DataMember = "poslovnipartner";
            this.poslovnipartnerBindingSource.DataSource = this.bazaBindingSource;
            // 
            // poslovnipartnerTableAdapter
            // 
            this.poslovnipartnerTableAdapter.ClearBeforeFill = true;
            // 
            // IzvjestajPredatnice
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(801, 385);
            this.Controls.Add(this.reportViewer1);
            this.Name = "IzvjestajPredatnice";
            this.Text = "IzvjestajPredatnice";
            this.Load += new System.EventHandler(this.IzvjestajPredatnice_Load);
            ((System.ComponentModel.ISupportInitialize)(this.bazaBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.baza)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.poslovnipartnerBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Microsoft.Reporting.WinForms.ReportViewer reportViewer1;
        private System.Windows.Forms.BindingSource bazaBindingSource;
        private baza baza;
        private System.Windows.Forms.BindingSource poslovnipartnerBindingSource;
        private bazaTableAdapters.poslovnipartnerTableAdapter poslovnipartnerTableAdapter;
    }
}