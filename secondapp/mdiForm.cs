using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace secondapp
{
    public partial class mdiForm : Form
    {
        public mdiForm()
        {
            InitializeComponent();
        }

        private void designationToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormDesignation f = new FormDesignation();
            f.MdiParent = this;
            f.Show();

        }

        private void departmentToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormDepartment f = new FormDepartment();
            f.MdiParent = this;
            f.Show();
        }

        private void employeeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Formemployee f = new Formemployee();
            f.MdiParent = this;
            f.Show();
        }

        private void loginToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormLogin f = new FormLogin();
            f.MdiParent = this;
            f.Show();
        }

        private void mdiForm_Load(object sender, EventArgs e)
        {

        }
    }
}
