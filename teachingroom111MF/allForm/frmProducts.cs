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
        string id;//globle variable 
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

            tbnSelect_Click(sender, e);

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



        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
             id = dataGridView1.Rows[e.RowIndex].Cells[0].Value.ToString();
            txtSKU.Text= dataGridView1.Rows[e.RowIndex].Cells[2].Value.ToString();
            txtProductName.Text = dataGridView1.Rows[e.RowIndex].Cells[3].Value.ToString();
            txtPrice.Text = dataGridView1.Rows[e.RowIndex].Cells[4].Value.ToString();
            txtTaxRate.Text = dataGridView1.Rows[e.RowIndex].Cells[5].Value.ToString();
           chkStatus.Checked = Convert.ToBoolean(dataGridView1.Rows[e.RowIndex].Cells[6].Value.ToString());




        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            MySqlConnection cnn = new MySqlConnection(Properties.Settings.Default.mysqlConnection);           
            string sql = $"UPDATE `tbproduct` SET `categoryID`='1',`sku`='{txtSKU.Text}',`name`='{txtProductName.Text}',`price`='{txtPrice.Text}',`taxRate`='{txtTaxRate.Text}',`isActive`='{Convert.ToInt16(chkStatus.Checked)}' WHERE `id`='{id}'";
            MySqlCommand cm = new MySqlCommand(sql, cnn);
            cnn.Open();
            cm.ExecuteNonQuery();
            cnn.Close();
            
            tbnSelect_Click(sender,e);

        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            MySqlConnection cnn = new MySqlConnection(Properties.Settings.Default.mysqlConnection);
            string sql = $"DELETE FROM tbproduct WHERE id='{id}'";
            MySqlCommand cm = new MySqlCommand(sql, cnn);
            cnn.Open();
            cm.ExecuteNonQuery();
            cnn.Close();

            tbnSelect_Click(sender, e);
        }
    }
}
