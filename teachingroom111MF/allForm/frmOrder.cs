using MySql.Data.MySqlClient;
using Org.BouncyCastle.Asn1.Cmp;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
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
            GetAllProduct();
        }

        private void GetAllCatagory()
        {
            var cnn = new MySqlConnection(Properties.Settings.Default.mysqlConnection);
            
            var sql = "SELECT * FROM tbcategories";
            var cm = new MySqlCommand(sql, cnn);            
            cnn.Open();
            MySqlDataReader dr = cm.ExecuteReader();
            while (dr.Read()) { 
                var a = new ucCatagory(dr.GetValue(1).ToString(), dr.GetValue(0).ToString());
                flpCategory.Controls.Add(a);            
            }
            cnn.Close();


        }

        private void GetAllProduct()
        {
            var cnn = new MySqlConnection(Properties.Settings.Default.mysqlConnection);
            var sql = "SELECT * FROM tbproduct ";
            var cm = new MySqlCommand(sql, cnn);
            cnn.Open();
            MySqlDataReader dr = cm.ExecuteReader();
            while (dr.Read())
            {
                var a = new ucProductitem(dr.GetValue(2).ToString(), dr.GetValue(3).ToString(), dr.GetValue(4).ToString());
                flpProduct.Controls.Add(a);
            }
            cnn.Close();

        }

        private void btnPay_Click(object sender, EventArgs e)
        {
            MySqlConnection cnn = new MySqlConnection(Properties.Settings.Default.mysqlConnection);
            string sql = $"INSERT INTO `tborders`(`subtotal`,`tax_total`,`discount_total`,`grand_total`) VALUES ('{TotalOreder()}','0','0','{TotalOreder()}')";            
            MySqlCommand cm = new MySqlCommand(sql, cnn);
            cnn.Open();
            cm.ExecuteNonQuery();
            cnn.Close();
        }

        private string TotalOreder() { 
            decimal total = 0;
            foreach (ucSellingitem item in flpSelling.Controls)
            {
                string[] val = item.lblTotal.Text.Split(' ');
                total += Convert.ToDecimal(val[1]);
            }
            return total.ToString();
        }
    }
}
