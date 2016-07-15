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
    public partial class Sales_Report : Form
    {
        public Sales_Report()
        {
            InitializeComponent();
        }

        private void Sales_Report_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'dassBElectricalsDataSet1.sales' table. You can move, or remove it, as needed.
            this.salesTableAdapter.Fill(this.dassBElectricalsDataSet1.sales);

            this.reportViewer1.RefreshReport();
        }
    }
}
