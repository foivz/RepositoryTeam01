﻿namespace PI
{
    partial class IzvjestajOtpremnice
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
            Microsoft.Reporting.WinForms.ReportDataSource reportDataSource2 = new Microsoft.Reporting.WinForms.ReportDataSource();
            this.dokumentBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.pekara_bazaDataSet = new PI.pekara_bazaDataSet();
            this.reportViewer1 = new Microsoft.Reporting.WinForms.ReportViewer();
            this.dokumentTableAdapter = new PI.pekara_bazaDataSetTableAdapters.dokumentTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.dokumentBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pekara_bazaDataSet)).BeginInit();
            this.SuspendLayout();
            // 
            // dokumentBindingSource
            // 
            this.dokumentBindingSource.DataMember = "dokument";
            this.dokumentBindingSource.DataSource = this.pekara_bazaDataSet;
            // 
            // pekara_bazaDataSet
            // 
            this.pekara_bazaDataSet.DataSetName = "pekara_bazaDataSet";
            this.pekara_bazaDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // reportViewer1
            // 
            reportDataSource2.Name = "DataSet1";
            reportDataSource2.Value = this.dokumentBindingSource;
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource2);
            this.reportViewer1.LocalReport.ReportEmbeddedResource = "PI.Otpremnica.rdlc";
            this.reportViewer1.Location = new System.Drawing.Point(12, 12);
            this.reportViewer1.Name = "reportViewer1";
            this.reportViewer1.Size = new System.Drawing.Size(686, 260);
            this.reportViewer1.TabIndex = 0;
            // 
            // dokumentTableAdapter
            // 
            this.dokumentTableAdapter.ClearBeforeFill = true;
            // 
            // IzvjestajOtpremnice
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(710, 284);
            this.Controls.Add(this.reportViewer1);
            this.Name = "IzvjestajOtpremnice";
            this.Text = "IzvjestajOtpremnice";
            this.Load += new System.EventHandler(this.IzvjestajOtpremnice_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dokumentBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pekara_bazaDataSet)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Microsoft.Reporting.WinForms.ReportViewer reportViewer1;
        private System.Windows.Forms.BindingSource dokumentBindingSource;
        private pekara_bazaDataSet pekara_bazaDataSet;
        private pekara_bazaDataSetTableAdapters.dokumentTableAdapter dokumentTableAdapter;
    }
}