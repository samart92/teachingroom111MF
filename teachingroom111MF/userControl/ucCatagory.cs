using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace teachingroom111MF.userControl
{
    public partial class ucCatagory : UserControl
    {
        public ucCatagory(string catagoryName)
        {
            InitializeComponent();
            btnCatagory.Text= catagoryName;
        }


        private void btnCatagory_Click(object sender, EventArgs e)
        {
            MessageBox.Show(btnCatagory.Text);
        }
    }
}
