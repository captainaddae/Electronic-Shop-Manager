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
    public partial class Salary_Payment : Form
    {
        public Salary_Payment()
        {
            InitializeComponent();
        }

        private void Salary_Payment_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'dassBElectricalsDataSet2.salary' table. You can move, or remove it, as needed.
            this.salaryTableAdapter.Fill(this.dassBElectricalsDataSet2.salary);

            this.reportViewer1.RefreshReport();
        }
    }
}
