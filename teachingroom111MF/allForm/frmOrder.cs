using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;
using teachingroom111MF.userControl;

namespace teachingroom111MF.allForm
{
    public partial class frmOrder : Form
    {
        public frmOrder()
        {
            InitializeComponent();
        }

        private void frmOrder_Load(object sender, EventArgs e)
        {
            GetAllCatagory();
        }

        private void GetAllCatagory()
        {
            var cnn = new MySqlConnection(Properties.Settings.Default.mysqlConnection);
            var sql = "SELECT * FROM tbcategories";
            var cm = new MySqlCommand(sql, cnn);            
            cnn.Open();
            MySqlDataReader dr = cm.ExecuteReader();
            while (dr.Read()) { 
                var a = new ucCatagory(dr.GetValue(1).ToString());
                flpCategory.Controls.Add(a);            
            }
            cnn.Close();


        }
    }
}
