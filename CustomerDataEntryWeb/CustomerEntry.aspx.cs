using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using DataAccess;

namespace CustomerDataEntryWeb
{
    public partial class CustomerEntry : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            LoadCustomers();
        }

        private void LoadCustomers()
        {
            ClsSqlConnection obj = new ClsSqlConnection();
            GridCustomers.DataSource = obj.getCustomers();
            GridCustomers.DataBind();
        }
    }
}