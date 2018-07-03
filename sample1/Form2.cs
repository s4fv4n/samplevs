using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace sample1
{
    public partial class FrmcstmrPreview : Form
    {
        public FrmcstmrPreview()
        {
            InitializeComponent();
        }

        private void FrmcstmrPreview_Load(object sender, EventArgs e)
        {

        }
        public void getValues(string Name,string Country,string Gender, string Hobbies, string Status)
        {
            lblCstmrNameData.Text = Name;
            lblCstmrCountryData.Text = Country;
            lblGenderData.Text = Gender;
            lblHobbiesData.Text = Hobbies;
            lblStatusData.Text = Status;
        
        }
    }
}
