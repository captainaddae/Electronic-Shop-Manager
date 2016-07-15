namespace EletricShopManagerUI
{
    partial class Expenditure_Report
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
            this.dassBElectricalsDataSet3 = new EletricShopManagerUI.dassBElectricalsDataSet3();
            this.expensesBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.expensesTableAdapter = new EletricShopManagerUI.dassBElectricalsDataSet3TableAdapters.expensesTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.dassBElectricalsDataSet3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.expensesBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // reportViewer1
            // 
            reportDataSource1.Name = "ExpensesData";
            reportDataSource1.Value = this.expensesBindingSource;
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource1);
            this.reportViewer1.LocalReport.ReportEmbeddedResource = "EletricShopManagerUI.Report4.rdlc";
            this.reportViewer1.Location = new System.Drawing.Point(2, 5);
            this.reportViewer1.Name = "reportViewer1";
            this.reportViewer1.Size = new System.Drawing.Size(765, 500);
            this.reportViewer1.TabIndex = 0;
            // 
            // dassBElectricalsDataSet3
            // 
            this.dassBElectricalsDataSet3.DataSetName = "dassBElectricalsDataSet3";
            this.dassBElectricalsDataSet3.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // expensesBindingSource
            // 
            this.expensesBindingSource.DataMember = "expenses";
            this.expensesBindingSource.DataSource = this.dassBElectricalsDataSet3;
            // 
            // expensesTableAdapter
            // 
            this.expensesTableAdapter.ClearBeforeFill = true;
            // 
            // Expenditure_Report
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(767, 501);
            this.Controls.Add(this.reportViewer1);
            this.Name = "Expenditure_Report";
            this.Text = "Expenditure Report";
            this.Load += new System.EventHandler(this.Expenditure_Report_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dassBElectricalsDataSet3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.expensesBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Microsoft.Reporting.WinForms.ReportViewer reportViewer1;
        private System.Windows.Forms.BindingSource expensesBindingSource;
        private dassBElectricalsDataSet3 dassBElectricalsDataSet3;
        private dassBElectricalsDataSet3TableAdapters.expensesTableAdapter expensesTableAdapter;
    }
}