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
    public partial class FormDesignation : Form
    {
        private object btnNew;
        private object btnDelete;
        private object txtDesignation;
        private object grdDesignationList;
        private object btnEdit;
        private object btnSave;
        private object txtDepartmentId;
        private object txtDesignationId;
        private bool IsEditMode = false;

        public FormDesignation()
        {
            InitializeComponent();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
        private int GetDesignationId()//to generate designation id
        {
            try {
                string Id = "SELECT max(designationId)+1 as"+" designation from Designation";
                    var data = Dbconnection.GetTableByQuery(Id);
                return Convert.ToInt32(data.Rows[0][0]);
            }
            catch ( Exception)
            {
                return 1;
            }
        }
        private void EnableDisableControl(string mode)
        {
            switch (mode)
            {
                case "Reset"://to reset form
                    btnnew.Enabled = true;
                    btndelete.Enabled = false;
                    btnedit.Enabled = true;
                    btnsave.Enabled = false;
                    txtdesignation1.Clear();
                    txtdesignationId1.Clear();
                    gradedesignationList.Enabled = true;
                    txtdesignation1.ReadOnly = true;
                    break;
                case "New"://setting when new is click
                    btnnew.Enabled = false;
                    btndelete.Enabled = false;
                    btnedit.Enabled = false;
                    btnsave.Enabled = true;
                    gradedesignationList.Enabled = false;
                    txtdesignation1.ReadOnly = false;
                    txtdesignation1.Clear();
                    txtdesignationId1.Clear();
                    break;
                case "Edit":
                    btnnew.Enabled = false;
                    btndelete.Enabled = true;
                    btnedit.Enabled = false;
                    btnsave.Enabled = true;
                    gradedesignationList.Enabled = false;
                    txtdesignation1.ReadOnly = false;
                    break;

            }
        }

        private void btnNew_Click(object sender, EventArgs e)
        {
            //making form ready to insert data
            IsEditMode = false;
            EnableDisableControl("New");
            txtdesignationId1.Text = GetDesignationId().ToString();
        }
    }
}
