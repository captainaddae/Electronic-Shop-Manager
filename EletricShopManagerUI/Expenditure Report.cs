using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EletricShopManagerUI
{
    public partial class Expenditure_Report : Form
    {
        public Expenditure_Report()
        {
            InitializeComponent();
        }

        private void Expenditure_Report_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'dassBElectricalsDataSet3.expenses' table. You can move, or remove it, as needed.
            this.expensesTableAdapter.Fill(this.dassBElectricalsDataSet3.expenses);

            this.reportViewer1.RefreshReport();
        }
    }
}
