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
    public partial class Stock_Report : Form
    {
        public Stock_Report()
        {
            InitializeComponent();
        }

        private void Stock_Report_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'dassBElectricalsDataSet.product' table. You can move, or remove it, as needed.
            this.productTableAdapter.Fill(this.dassBElectricalsDataSet.product);

            this.reportViewer1.RefreshReport();
        }
    }
}
