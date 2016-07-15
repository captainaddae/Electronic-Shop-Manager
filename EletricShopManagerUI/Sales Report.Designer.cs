namespace EletricShopManagerUI
{
    partial class Sales_Report
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
            this.dassBElectricalsDataSet1 = new EletricShopManagerUI.dassBElectricalsDataSet1();
            this.salesBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.salesTableAdapter = new EletricShopManagerUI.dassBElectricalsDataSet1TableAdapters.salesTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.dassBElectricalsDataSet1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.salesBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // reportViewer1
            // 
            this.reportViewer1.DocumentMapWidth = 98;
            reportDataSource1.Name = "SalesData";
            reportDataSource1.Value = this.salesBindingSource;
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource1);
            this.reportViewer1.LocalReport.ReportEmbeddedResource = "EletricShopManagerUI.Report2.rdlc";
            this.reportViewer1.Location = new System.Drawing.Point(12, 27);
            this.reportViewer1.Name = "reportViewer1";
            this.reportViewer1.Size = new System.Drawing.Size(769, 409);
            this.reportViewer1.TabIndex = 0;
            // 
            // dassBElectricalsDataSet1
            // 
            this.dassBElectricalsDataSet1.DataSetName = "dassBElectricalsDataSet1";
            this.dassBElectricalsDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // salesBindingSource
            // 
            this.salesBindingSource.DataMember = "sales";
            this.salesBindingSource.DataSource = this.dassBElectricalsDataSet1;
            // 
            // salesTableAdapter
            // 
            this.salesTableAdapter.ClearBeforeFill = true;
            // 
            // Sales_Report
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(793, 448);
            this.Controls.Add(this.reportViewer1);
            this.Name = "Sales_Report";
            this.RightToLeftLayout = true;
            this.Text = "Sales Report";
            this.Load += new System.EventHandler(this.Sales_Report_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dassBElectricalsDataSet1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.salesBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Microsoft.Reporting.WinForms.ReportViewer reportViewer1;
        private System.Windows.Forms.BindingSource salesBindingSource;
        private dassBElectricalsDataSet1 dassBElectricalsDataSet1;
        private dassBElectricalsDataSet1TableAdapters.salesTableAdapter salesTableAdapter;
    }
}