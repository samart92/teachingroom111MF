using MySql.Data.MySqlClient;
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
    public partial class ucCatagory : UserControl
    {
        string id = null;
        public ucCatagory(string catagoryName ,string _id)
        {
            InitializeComponent();
            btnCatagory.Text= catagoryName;
            id=_id;
        }


        private void btnCatagory_Click(object sender, EventArgs e)
        {

            frmOrder order = (frmOrder)Application.OpenForms["frmOrder"];
            order.flpProduct.Controls.Clear();
            var cnn = new MySqlConnection(Properties.Settings.Default.mysqlConnection);
            var sql = $"SELECT * FROM tbproduct WHERE categoryID ='{id}'";
            var cm = new MySqlCommand(sql, cnn);
            cnn.Open();
            MySqlDataReader dr = cm.ExecuteReader();
            while (dr.Read())
            {
                var a = new ucProductitem(dr.GetValue(2).ToString(), dr.GetValue(3).ToString(), dr.GetValue(4).ToString());
                order.flpProduct.Controls.Add(a);
            }
            cnn.Close();
        }
    }
}
