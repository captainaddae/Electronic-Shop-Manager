namespace EletricShopManagerUI
{
    partial class Salary_Payment
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
            this.dassBElectricalsDataSet2 = new EletricShopManagerUI.dassBElectricalsDataSet2();
            this.salaryBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.salaryTableAdapter = new EletricShopManagerUI.dassBElectricalsDataSet2TableAdapters.salaryTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.dassBElectricalsDataSet2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.salaryBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // reportViewer1
            // 
            reportDataSource1.Name = "SalaryData";
            reportDataSource1.Value = this.salaryBindingSource;
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource1);
            this.reportViewer1.LocalReport.ReportEmbeddedResource = "EletricShopManagerUI.Report3.rdlc";
            this.reportViewer1.Location = new System.Drawing.Point(5, 6);
            this.reportViewer1.Name = "reportViewer1";
            this.reportViewer1.Size = new System.Drawing.Size(784, 488);
            this.reportViewer1.TabIndex = 0;
            // 
            // dassBElectricalsDataSet2
            // 
            this.dassBElectricalsDataSet2.DataSetName = "dassBElectricalsDataSet2";
            this.dassBElectricalsDataSet2.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // salaryBindingSource
            // 
            this.salaryBindingSource.DataMember = "salary";
            this.salaryBindingSource.DataSource = this.dassBElectricalsDataSet2;
            // 
            // salaryTableAdapter
            // 
            this.salaryTableAdapter.ClearBeforeFill = true;
            // 
            // Salary_Payment
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(790, 506);
            this.Controls.Add(this.reportViewer1);
            this.Name = "Salary_Payment";
            this.Text = "Salary Payment";
            this.Load += new System.EventHandler(this.Salary_Payment_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dassBElectricalsDataSet2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.salaryBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Microsoft.Reporting.WinForms.ReportViewer reportViewer1;
        private System.Windows.Forms.BindingSource salaryBindingSource;
        private dassBElectricalsDataSet2 dassBElectricalsDataSet2;
        private dassBElectricalsDataSet2TableAdapters.salaryTableAdapter salaryTableAdapter;
    }
}