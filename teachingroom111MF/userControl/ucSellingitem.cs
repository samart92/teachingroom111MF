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
    public partial class ucSellingitem : UserControl
    {
        string price = null;
        int count = 1;
        public ucSellingitem(string _proName, string _price)
        {
            InitializeComponent();
            lblProName.Text = _proName;
            price = _price;
            lblPrice.Text = $"$ {price} X {count}";
            lblTotal.Text = $"$ {_price}";
        }

        private void btnclose_Click(object sender, EventArgs e)
        {
            frmOrder order = (frmOrder)Application.OpenForms["frmOrder"];
            order.flpSelling.Controls.Remove(this);
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            count += 1;
            lblPrice.Text = $"$ {price} X {count}";
            lblTotal.Text = $"$ {Convert.ToDecimal(price) * count}";
        }

        private void btnSubstrack_Click(object sender, EventArgs e)
        {
            if (count>1)
            {
                count -= 1;
            lblPrice.Text = $"$ {price} X {count}";
            lblTotal.Text = $"$ {Convert.ToDecimal(price) * count}";
            }

            
        }
    }
}
