namespace EletricShopManagerUI
{
    partial class Stock_Report
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
            this.dassBElectricalsDataSet = new EletricShopManagerUI.dassBElectricalsDataSet();
            this.productBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.productTableAdapter = new EletricShopManagerUI.dassBElectricalsDataSetTableAdapters.productTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.dassBElectricalsDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.productBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // reportViewer1
            // 
            reportDataSource1.Name = "Stockdata";
            reportDataSource1.Value = this.productBindingSource;
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource1);
            this.reportViewer1.LocalReport.ReportEmbeddedResource = "EletricShopManagerUI.Report1.rdlc";
            this.reportViewer1.Location = new System.Drawing.Point(7, 9);
            this.reportViewer1.Name = "reportViewer1";
            this.reportViewer1.Size = new System.Drawing.Size(798, 491);
            this.reportViewer1.TabIndex = 0;
            // 
            // dassBElectricalsDataSet
            // 
            this.dassBElectricalsDataSet.DataSetName = "dassBElectricalsDataSet";
            this.dassBElectricalsDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // productBindingSource
            // 
            this.productBindingSource.DataMember = "product";
            this.productBindingSource.DataSource = this.dassBElectricalsDataSet;
            // 
            // productTableAdapter
            // 
            this.productTableAdapter.ClearBeforeFill = true;
            // 
            // Stock_Report
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(810, 502);
            this.Controls.Add(this.reportViewer1);
            this.Name = "Stock_Report";
            this.Text = "Stock Report";
            this.Load += new System.EventHandler(this.Stock_Report_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dassBElectricalsDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.productBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Microsoft.Reporting.WinForms.ReportViewer reportViewer1;
        private System.Windows.Forms.BindingSource productBindingSource;
        private dassBElectricalsDataSet dassBElectricalsDataSet;
        private dassBElectricalsDataSetTableAdapters.productTableAdapter productTableAdapter;
    }
}