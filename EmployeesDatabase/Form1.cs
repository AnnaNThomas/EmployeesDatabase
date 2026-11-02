using EmployeesDatabase.Properties;
using System.Data;
using System.Windows.Forms;
using static System.ComponentModel.Design.ObjectSelectorEditor;

namespace EmployeesDatabase
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }



        DatabaseConnection objConnect;  //The variable is called objConnect. It is of type DatabaseConnection, which is the name of our class.
        string conString;               //string to hold our connection string 

        DataSet ds;
        DataRow dRow;                        //DataSet contains rows, which correspond to a row in the database table


        int MaxRows;                       //tell us how many rows there are in the DataSet
        int inc = 0;                         //used to move from one record to another, and back again









        private void Form1_Load(object sender, EventArgs e)
        {
            try
            {
                objConnect = new DatabaseConnection();
                conString = Properties.Settings.Default.EmployeesDatabaseConnectionString;
                objConnect.connection_string = conString;
                objConnect.Sql = Properties.Settings.Default.SQL;
                ds = objConnect.GetConnection;
                MaxRows = ds.Tables[0].Rows.Count;
                NavigateRecords();
            }
            catch (Exception err)
            {

                MessageBox.Show(err.Message);

            }

        }

        private void NavigateRecords()
        {

            dRow = ds.Tables[0].Rows[inc];

            txtFirstName.Text = dRow.ItemArray.GetValue(1).ToString();
            txtSurname.Text = dRow.ItemArray.GetValue(2).ToString();
            txtJobTitle.Text = dRow.ItemArray.GetValue(3).ToString();
            txtDepartment.Text = dRow.ItemArray.GetValue(4).ToString();
            labelUpdate();

        }

        private void btnNext_Click(object sender, EventArgs e)
        {
            if (inc != MaxRows - 1)
            {
                inc++;
                NavigateRecords();

            }
            else
            {
                MessageBox.Show("No More Rows");
            }
        }

        private void btnPrevious_Click(object sender, EventArgs e)
        {
            if (inc > 0)
            {

                inc--;
                NavigateRecords();

            }
            else
            {

                MessageBox.Show("First Record");

            }

        }

        private void btnLast_Click(object sender, EventArgs e)
        {
            if (inc != MaxRows - 1)
            {

                inc = MaxRows - 1;
                NavigateRecords();

            }
        }

        private void btnFirst_Click(object sender, EventArgs e)
        {
            if (inc != 0)
            {

                inc = 0;
                NavigateRecords();

            }

        }

        private void button1_Click(object sender, EventArgs e)
        {
            NavigateRecords();

            btnCancel.Enabled = false;
            btnSave.Enabled = false;
            btnAddNew.Enabled = true;
        }

        private void btnAddNew_Click(object sender, EventArgs e)
        {
            txtFirstName.Clear();             //To clear the textboxes
            txtSurname.Clear();
            txtJobTitle.Clear();
            txtDepartment.Clear();
            btnAddNew.Enabled = false;
            btnSave.Enabled = true;
            btnCancel.Enabled = true;
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            DataRow row = ds.Tables[0].NewRow();     //To add a record to the Dataset, you need to create a new Row:
            row[1] = txtFirstName.Text;

            row[2] = txtSurname.Text;
            row[3] = txtJobTitle.Text;
            row[4] = txtDepartment.Text;

            ds.Tables[0].Rows.Add(row);
            try
            {
                objConnect.UpdateDatabase(ds);

                MaxRows = MaxRows + 1;
                labelUpdate();
                inc = MaxRows - 1;

                MessageBox.Show("Database updated");
            }
            catch (Exception err)
            {

                MessageBox.Show(err.Message);

            }
            btnCancel.Enabled = false;
            btnSave.Enabled = false;
            btnAddNew.Enabled = true;








        }



        private void btnUdate_Click(object sender, EventArgs e)
        {
            try
            {
                if (ds == null || ds.Tables.Count == 0 ||
                    inc < 0 || inc >= ds.Tables[0].Rows.Count)
                {
                    MessageBox.Show("No record selected.");
                    return;
                }

                DataRow row = ds.Tables[0].Rows[inc];

                row[1] = txtFirstName.Text;
                row[2] = txtSurname.Text;
                row[3] = txtJobTitle.Text;
                row[4] = txtDepartment.Text;

                objConnect.UpdateDatabase(ds);

                MessageBox.Show("Record Updated Successfully!");
            }
            catch (Exception err)
            {
                MessageBox.Show(err.ToString(), "Update Error");
            }

        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            try
            {
                ds.Tables[0].Rows[inc].Delete();
                objConnect.UpdateDatabase(ds);
                MaxRows = ds.Tables[0].Rows.Count;
                inc--;

                NavigateRecords();
                MessageBox.Show("Record Deleted");
            }
            catch (Exception err)

            {
                MessageBox.Show(err.Message);


            }





        }

        private void labelUpdate()
        {

            label5.Text = "Record " + (inc + 1) + " of " + MaxRows;
        }










    }
}
