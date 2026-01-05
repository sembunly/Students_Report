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
    public partial class MainFrm : Form
    {
        public MainFrm()
        {
            InitializeComponent();
        }

        private void របយករណរយនមToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void របយករណរយនមសសសToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmstudents frm = new frmstudents();
            frm.WindowState = FormWindowState.Maximized;
            frm.ShowDialog();
        }

        private void របយករណរយនមToolStripMenuItem_Click_1(object sender, EventArgs e)
        {

        }

        private void របយករណរយនមករToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmTeacher frm = new frmTeacher();
            frm.WindowState = FormWindowState.Maximized;
            frm.ShowDialog();
        }

        private void របយករណរយនមបគគលកToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmStaff frm = new frmStaff();
            frm.WindowState = FormWindowState.Maximized;
            frm.ShowDialog();
        }

        private void បញជសវភToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmBooks frm = new frmBooks();
            frm.WindowState = FormWindowState.Maximized;
            frm.ShowDialog();
        }

        private void បញជមខវជជToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmSubject frm = new frmSubject();
            frm.WindowState = FormWindowState.Maximized;
            frm.ShowDialog();
        }

        private void ករករបគរងToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void វតតមនសសសToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmstudentAtt frm = new frmstudentAtt ();
            frm.WindowState = FormWindowState.Maximized;
            frm.ShowDialog();
        }

        private void វតតមននងមToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmTeacherAttendance frm = new frmTeacherAttendance();
            frm.WindowState = FormWindowState.Maximized;
            frm.ShowDialog();
        }
    }
}
