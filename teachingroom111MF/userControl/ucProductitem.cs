using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using teachingroom111MF.allForm;

namespace teachingroom111MF.userControl
{
    public partial class ucProductitem : UserControl
    {
        public ucProductitem(string sku,string proName,string price)
        {
            InitializeComponent();
            lblSKU.Text = sku;
            lblProName.Text = proName;
            lblPrice.Text = price;
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            //MessageBox.Show(lblProName.Text +"- $ " + lblPrice.Text);

            ucSellingitem selling = new ucSellingitem(lblProName.Text,lblPrice.Text);
            frmOrder order= (frmOrder)Application.OpenForms["frmOrder"];

            order.flpSelling.Controls.Add(selling);

        }
    }
}
