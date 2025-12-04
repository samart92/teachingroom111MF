using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data;
using MySql.Data.MySqlClient;

namespace teachingroom111MF.allForm
{
    public partial class frmProducts : Form
    {
        public frmProducts()
        {
            InitializeComponent();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            MySqlConnection cnn = new MySqlConnection(Properties.Settings.Default.mysqlConnection);
            string sql = $"INSERT INTO `tbproduct`( `categoryID`, `sku`, `name`, `price`, `taxRate`, `isActive`, `createAt`) VALUES ('1','{txtSKU.Text}','{txtProductName.Text}','{txtPrice.Text}','{txtTaxRate.Text}','{Convert.ToInt16(chkStatus.Checked)}','{DateTime.Today.ToString("yyyy-MM-dd")}')";
            //string sql = $"INSERT INTO `tbproduct`( `name`) VALUES ('{txtProductName.Text}')";
            MySqlCommand cm = new MySqlCommand(sql, cnn);
            cnn.Open();
            cm.ExecuteNonQuery();
            cnn.Close();


            //MessageBox.Show(Convert.ToInt32(chkStatus.Checked).ToString());
        }

        private void tbnSelect_Click(object sender, EventArgs e)
        {
            MySqlConnection cnn = new MySqlConnection(Properties.Settings.Default.mysqlConnection);
            string sql = "SELECT * FROM tbproduct";
            MySqlCommand cm = new MySqlCommand( sql, cnn);
            MySqlDataAdapter da = new MySqlDataAdapter(cm);
            DataTable dt = new DataTable();
            cnn.Open();
            da.Fill(dt);
            cnn.Close();

            dataGridView1.DataSource= dt;
        }
    }
}
