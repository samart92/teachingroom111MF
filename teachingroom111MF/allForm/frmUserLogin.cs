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

namespace teachingroom111MF
{
    public partial class frmUserLogin : Form
    {
        public frmUserLogin()
        {
            InitializeComponent();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            string[] userName = {"a","b","c" };
            string[] password = {"a","b","c" };
            string[] role = { "admin", "user", "guest" };
            bool t = false;
            
            string getRole=null;
            
            for (int i = 0; i <userName.Length; i++)
            {
                if(userName[i] ==txtUserName.Text && password[i] == txtPassword.Text) { 
                    t = true;
                    getRole = role[i];
                    break; }
                
            }

            if (t) {
                frmDashboard fm = new frmDashboard();
                fm.role = getRole;
                fm.Show();
                Hide();
            } else {
                MessageBox.Show("User name and password not correct!");
            }




            
        }

       
    }
}
