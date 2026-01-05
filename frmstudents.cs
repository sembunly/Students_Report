using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace School_Report
{
    public partial class frmstudents : Form
    {
        public frmstudents()
        {
            InitializeComponent();
        }

        private void frmstudents_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'hOMEWORKDataSet.Students' table. You can move, or remove it, as needed.
            this.studentsTableAdapter.Fill(this.hOMEWORKDataSet.Students);

            this.reportViewer1.RefreshReport();
        }
    }
}
