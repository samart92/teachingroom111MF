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

namespace teachingroom111MF.allForm
{
    public partial class frmAddUser : Form
    {
        public frmAddUser()
        {
            InitializeComponent();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            //connection
            MySqlConnection conn = new MySqlConnection(Properties.Settings.Default.mysqlConnection);
            //Sql staterment
          string sql=  $"INSERT INTO tbuser(fullname) VALUES('{txtUserName.Text}')";
            //command
            MySqlCommand cm = new MySqlCommand(sql, conn);
            //open
            conn.Open();
            cm.ExecuteNonQuery();
            conn.Close();
            
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            
            var msg = MessageBox.Show("Do you want to Delete this recode?","Delete",MessageBoxButtons.YesNo);
            if (msg == DialogResult.Yes)
            {
                MySqlConnection conn = new MySqlConnection(Properties.Settings.Default.mysqlConnection);
                string sql = $"DELETE FROM tbuser WHERE id='{txtID.Text}'";
                MySqlCommand cm = new MySqlCommand(sql, conn);
                conn.Open();
                cm.ExecuteNonQuery();
                conn.Close();
            }
            



            
        }
    }
}
