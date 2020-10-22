using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;


namespace MyEmployeeDirectory
{
    public partial class EmployeeDirectory : Form
    {
       private EmployeeContext empcntxt;
      
       EmployeeInfo _empinfo;
        public EmployeeDirectory()
        {
            InitializeComponent();

        }
        private void btnInsert_Click(object sender, EventArgs e)
        {
            try
            {
                using (EmployeeContext _empcntx = new EmployeeContext())
                {
                    //The new record should atleast have an Employee Name
                    if (txtBxName.Text != "")
                    {
                        _empinfo = new EmployeeInfo();//new row
                        _empinfo.EmployeeName = txtBxName.Text.Trim();
                        _empinfo.JobTitle = txtBxTitle.Text.Trim();
                        empcntxt.EmployeeInfoes.Add(_empinfo);
                        empcntxt.SaveChanges();
                        refreshGridView();
                        refreshDataGridView();
                        MessageBox.Show("An employee detail is Added");
                        ClearTxtBx();
                    }
                    else
                    {
                        //If the employee name field was empty
                        MessageBox.Show("Please enter a Name");
                    }
                }
            }
            catch (Exception exc)
            {
                Console.WriteLine("Error while adding a record. Exception :{0}",exc .ToString ());
            }
        }
        private void btnUpdate_Click(object sender, EventArgs e)
        {
            try
            {            
                int recToUpdate = getEmpIDforselectedDataGridIndex();//get the selected row from table
                if (recToUpdate >= 0)
                {          
                    txtBxName.Refresh();
                    txtBxTitle.Refresh();
                    using (EmployeeContext _empcntx = new EmployeeContext())
                    {
                        var _empinfoToUpdate = _empcntx.EmployeeInfoes.Where(x => x.Id == recToUpdate).FirstOrDefault();
                        _empinfoToUpdate.EmployeeName = txtBxName.Text.Trim();
                        _empinfoToUpdate.JobTitle = txtBxTitle.Text.Trim();
                        _empcntx.SaveChanges();
                    }
                refreshGridView();
                refreshDataGridView();
                ClearTxtBx();
                MessageBox.Show("An employee detail is Updated");
            }
            }
            catch (Exception exc)
            {
                Console.WriteLine("Error while updating the record. Exception :{0}", exc.ToString());
            }
        }
        private void btnDelete_Click(object sender, EventArgs e)
        {
            try
            {
                DialogResult dialogResult = MessageBox.Show("Do you want to delete the record", "Alert", MessageBoxButtons.YesNo);
                if (dialogResult == DialogResult.Yes)
                {
                    int recToDelete = getEmpIDforselectedDataGridIndex();
                    using (EmployeeContext _empcntx = new EmployeeContext())
                    {
                        var _empinfoToDelete = _empcntx.EmployeeInfoes.Where(x => x.Id == recToDelete).FirstOrDefault();
                        _empcntx.EmployeeInfoes.Remove(_empinfoToDelete);
                        _empcntx.SaveChanges();
                    }
                    
                    refreshGridView();
                    refreshDataGridView();
                    MessageBox.Show("An employee detail is Deleted");
                    ClearTxtBx();

                }

            }
            catch (Exception exc)
            {
                Console.WriteLine("Error while deleting a record. Exception :{0}", exc.ToString());
            }
        }
        private void refreshGridView()
        {
            dataGridView1.Update();
            dataGridView1.Refresh();
        }
        private void EmployeeDirectory_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'myEmployeeDBDataSet.EmployeeInfo' table. You can move, or remove it, as needed.
            this.employeeInfoTableAdapter.Fill(this.myEmployeeDBDataSet.EmployeeInfo);

            //this.employeeInfoTableAdapter.Fill(this.myEmployeeDBDataSet.EmployeeInfo);

            refreshDataGridView();
        }
        private void refreshDataGridView()
        {
            empcntxt = new EmployeeContext();
            dataGridView1.DataSource = null;
            dataGridView1.AutoGenerateColumns = false;
            dataGridView1.DataSource = empcntxt.EmployeeInfoes.ToList<EmployeeInfo>();
        }
        private void EmployeeDirectory_FormClosed(object sender, FormClosedEventArgs e)
        {
            dataGridView1.DataSource = null;
        }
        private int getEmpIDforselectedDataGridIndex()
        {
            if (dataGridView1.CurrentRow.Index >= 0)
            {
                
                int empId = Convert.ToInt32(dataGridView1.Rows[dataGridView1.CurrentRow.Index].Cells[2].Value);

                return empId;     
           }
            else
                return -1;
        }
        private void dataGridView1_DoubleClick(object sender, EventArgs e)
        {
            if (dataGridView1.CurrentRow.Index >= 0)
            {
                UpdatextBox();

            }
        }
           
        void UpdatextBox( )
        {
            txtBxName.Text = dataGridView1.CurrentRow.Cells["NameCol"].Value.ToString();
            txtBxTitle.Text = dataGridView1.CurrentRow.Cells["TitleCol"].Value.ToString();
        }

        void ClearTxtBx()
        {
            txtBxName.Clear();
            txtBxTitle.Clear();
        }

       
    }
}
