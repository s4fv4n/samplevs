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
    public partial class frmSearchCustomer : Form
    {
        public frmSearchCustomer()
        {
            InitializeComponent();
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            CommonCode obj = new CommonCode();
            if(obj.Validate(txtCustomerName.Text)== false)
            {
                MessageBox.Show("Customer name is compulsory");
                return;
            }

            ClsSqlConnection obj1 = new ClsSqlConnection();

            DataSet objDS = obj1.getCustomers(txtCustomerName.Text);
            

            dataGridView1.DataSource = objDS.Tables[0];

            
        }
    }
}
