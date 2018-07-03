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
using System.Configuration;
using DataAccess;

namespace sample1
{
    public partial class FrmAddCustomer : Form
    {
        public FrmAddCustomer()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

            LoadCustomer();
        }

        private void LoadCustomer()
        {
            ClsSqlConnection obj = new ClsSqlConnection();
            DataSet objDS = obj.getCustomers();
           

            dataGridView1.DataSource = objDS.Tables[0];

            
        }
        private void btnSubmit_Click(object sender, EventArgs e)
        {
            CommonCode obj = new CommonCode();
            if (obj.Validate(txtCstmrName.Text) == false)
            {
                MessageBox.Show("Customer name is compulsory");

                return;
            }

            string sex = "";
            if (rbtnMale.Checked == true)
            {
                sex = "Male";
            }
            else if(rbtnFemale.Checked==true)
            {
                sex = "Female";
            }
            else
            {
                MessageBox.Show("Select a gender"); return;
            }

            string hobbies="No hobbies";
            if (chkbxReading.Checked == true)
            {
                hobbies = "Reading";
            }
            else if (chkbxPainting.Checked == true)
            {
                hobbies = "Painting";

            }

            string status = "";
            if (rbtnMarried.Checked == true)
            {
                status = "1";
            
            }
            else if (rbtnSingle.Checked == true)
            {
                status = "0";
            }
            else
            {
                MessageBox.Show("Select a status");return;
            }
            string stat = "";
            if (status == "0")
            {
                stat = "Single";
            }
            else
            {
                stat = "Married";
            }
                
            /*  FrmcstmrPreview PreObj = new FrmcstmrPreview();
              PreObj.getValues(txtCstmrName.Text, cBoxCountry.Text.ToString(), sex, hobbies, stat);

              PreObj.ShowDialog();
              */
            ClsSqlConnection obj1 = new ClsSqlConnection();
            obj1.insertCustomers(txtCstmrName.Text, cBoxCountry.Text, sex, hobbies, status);
            LoadCustomer();
            ClearData();
        }

        private void lblCstmrCountry_Click(object sender, EventArgs e)
        {
         
        }

       

        private void displayCustomer(string CustomerCode)
        {
            ClsSqlConnection obj = new ClsSqlConnection();
            DataSet objDataSet = obj.getCustomers(CustomerCode);

           

            string objCustName = objDataSet.Tables[0].Rows[0][0].ToString();
            string objCustCountry = objDataSet.Tables[0].Rows[0][1].ToString();
            string objGender = objDataSet.Tables[0].Rows[0][2].ToString();
            string objHobby = objDataSet.Tables[0].Rows[0][3].ToString();
            bool Married = false;
            if (objDataSet.Tables[0].Rows[0][4] != DBNull.Value)
            {

                Married = Convert.ToBoolean(objDataSet.Tables[0].Rows[0][4].ToString());
            }

            

            txtCstmrName.Text = objCustName;
            cBoxCountry.Text = objCustCountry;
            if ((objGender.Length == 0) || (objGender.Trim() == "Male"))
            {
                rbtnMale.Checked = true;
            }
            else
            {
                rbtnFemale.Checked = true;
            }

            if (objHobby.Trim() == "Reading")
            {
                chkbxReading.Checked = true;
                chkbxPainting.Checked = false;
            }
            else
            {
                chkbxPainting.Checked = true;
                chkbxReading.Checked = false;
            }

            if (Married)
            {
                rbtnMarried.Checked = true;
            }
            else
            {
                rbtnSingle.Checked = true;
            }
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                string strCustomerName = dataGridView1.Rows[e.RowIndex].Cells[0].Value.ToString();
                displayCustomer(strCustomerName);
            }
            else
            {
                MessageBox.Show("No data to show");
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            ClsSqlConnection obj = new ClsSqlConnection();
            obj.deleteCustomer(txtCstmrName.Text);

            LoadCustomer();
            ClearData();
        }

        private void ClearData()
        {
            txtCstmrName.Text = "";
            cBoxCountry.Text = "";
            rbtnFemale.Checked = false;
            rbtnMale.Checked = false;
            chkbxPainting.Checked = false;
            chkbxReading.Checked = false;
            rbtnSingle.Checked = false;
            rbtnMarried.Checked = false;

        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            string sex = "";
            if (rbtnMale.Checked == true)
            {
                sex = "Male";
            }
            else if (rbtnFemale.Checked == true)
            {
                sex = "Female";
            }
            else
            {
                MessageBox.Show("Select a gender"); return;
            }

            string hobbies = "No hobbies";
            if (chkbxReading.Checked == true)
            {
                hobbies = "Reading";
            }
            else if (chkbxPainting.Checked == true)
            {
                hobbies = "Painting";

            }

            string status = "";
            if (rbtnMarried.Checked == true)
            {
                status = "1";

            }
            else if (rbtnSingle.Checked == true)
            {
                status = "0";
            }
            else
            {
                MessageBox.Show("Select a status"); return;
            }
            string stat = "";
            if (status == "0")
            {
                stat = "Single";
            }
            else
            {
                stat = "Married";
            }

            /*  FrmcstmrPreview PreObj = new FrmcstmrPreview();
              PreObj.getValues(txtCstmrName.Text, cBoxCountry.Text.ToString(), sex, hobbies, stat);

              PreObj.ShowDialog();
              */
            ClsSqlConnection obj = new ClsSqlConnection();
            obj.updateCustomer(txtCstmrName.Text, cBoxCountry.Text, sex, hobbies, status);

            LoadCustomer();
            ClearData();
        }
    }
}
