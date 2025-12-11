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

namespace teachingroom111MF.allForm
{
    public partial class frmCatagory : Form
    {
        string id;//globle variable
        public frmCatagory()
        {
            InitializeComponent();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            MySqlConnection cnn = new MySqlConnection(Properties.Settings.Default.mysqlConnection);
            string sql = $"INSERT INTO `tbcategories`( `category`) VALUES ('{txtCatagoryName.Text}')";           
            MySqlCommand cm = new MySqlCommand(sql, cnn);
            cnn.Open();
            cm.ExecuteNonQuery();
            cnn.Close();

            GetAllCatagory();

        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            MySqlConnection cnn = new MySqlConnection(Properties.Settings.Default.mysqlConnection);
            string sql = $"DELETE FROM `tbcategories` WHERE `id`='{id}'";
            MySqlCommand cm = new MySqlCommand(sql, cnn);
            cnn.Open();
            cm.ExecuteNonQuery();
            cnn.Close();

            GetAllCatagory();
        }

        private void btnUPdate_Click(object sender, EventArgs e)
        {
            MySqlConnection cnn = new MySqlConnection(Properties.Settings.Default.mysqlConnection);
            string sql = $"UPDATE `tbcategories` SET `category`='{txtCatagoryName.Text}' WHERE `id`='{id}'";
            MySqlCommand cm = new MySqlCommand(sql, cnn);
            cnn.Open();
            cm.ExecuteNonQuery();
            cnn.Close();

            GetAllCatagory();
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            id = dataGridView1.Rows[e.RowIndex].Cells[0].Value.ToString();
            txtCatagoryName.Text = dataGridView1.Rows[e.RowIndex ].Cells[1].Value.ToString();
        }


        private void GetAllCatagory()
        {
            MySqlConnection cnn = new MySqlConnection(Properties.Settings.Default.mysqlConnection);
            string sql = "SELECT * FROM `tbcategories`";
            MySqlCommand cm = new MySqlCommand(sql, cnn);
            MySqlDataAdapter da = new MySqlDataAdapter(cm);
            DataTable dt = new DataTable();
            cnn.Open();
            da.Fill(dt);
            cnn.Close();

            dataGridView1.DataSource = dt;
        }


    }
}
