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

namespace teachingroom111MF.allForm
{

    

    
    public partial class Form2 : Form
    {
        

        public Form2()
        {
            InitializeComponent();
        }

        private void Form2_Load(object sender, EventArgs e)
        {
            string n="";
            MySqlConnection cnn = new MySqlConnection(Properties.Settings.Default.mysqlConnection);
            string sql = "SELECT Count(id) FROM tbproduct";
            MySqlCommand cm = new MySqlCommand(sql, cnn);         
            
            cnn.Open();
            MySqlDataReader rd = cm.ExecuteReader();
            while (rd.Read()) { 
                n = rd.GetValue(0).ToString();
            }
            
            cnn.Close();

            ucCountNumber1.Counts = n;
        }
    }
}
