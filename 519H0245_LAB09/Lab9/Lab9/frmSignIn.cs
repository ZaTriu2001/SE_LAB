using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BUS;
using Lab9;

namespace GUI
{
    public partial class frmSignIn : Form
    {
        BUS_Account ba;
        public frmSignIn()
        {
            InitializeComponent();
        }

        private void frmSignIn_Load(object sender, EventArgs e)
        {
            ba = new BUS_Account("", "", "");
        }

        public bool signin(string username, string password)
        {
            DataTable dt = new DataTable();
            dt = ba.selectQuery(username, password);
            if (dt.Rows.Count > 0)
            {
                Program.user = dt.Rows[0][0].ToString();
                Program.quyen = dt.Rows[0][2].ToString();
                return true;
            }
            else
                return false;
        }

        private void bSignIn_Click(object sender, EventArgs e)
        {
            if (signin(txtUser.Text, txtPass.Text) == true)
            {
                frmMain frm = new frmMain();   
                frm.ShowDialog();
            }
        }
    }
}
