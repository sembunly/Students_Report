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
    public partial class frmstudentAtt : Form
    {
        public frmstudentAtt()
        {
            InitializeComponent();
        }

        private void frmstudents_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'hOMEWORKDataSet.Books' table. You can move, or remove it, as needed.
            this.booksTableAdapter.Fill(this.hOMEWORKDataSet.Books);
            // TODO: This line of code loads data into the 'hOMEWORKDataSet.Staffs' table. You can move, or remove it, as needed.
            this.staffsTableAdapter.Fill(this.hOMEWORKDataSet.Staffs);
            // TODO: This line of code loads data into the 'hOMEWORKDataSet.Teachers' table. You can move, or remove it, as needed.
            this.teachersTableAdapter.Fill(this.hOMEWORKDataSet.Teachers);
            // TODO: This line of code loads data into the 'hOMEWORKDataSet.Students' table. You can move, or remove it, as needed.
            this.studentsTableAdapter.Fill(this.hOMEWORKDataSet.Students);

            this.reportViewer1.RefreshReport();
            this.reportViewer2.RefreshReport();
        }
    }
}
