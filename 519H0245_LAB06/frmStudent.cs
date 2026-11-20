using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using System.Data;
using System.Data.SqlClient;
    
namespace Lab6
{
    public partial class frmStudent : Form
    {
        SqlConnection cn;
        SqlDataAdapter data;
        DataTable tb;

        public frmStudent()
        {
            InitializeComponent();
        }

        void htKhoa()
        {
            string s = "select * from Faculty";
            data = new SqlDataAdapter(s, cn);
            tb = new DataTable();
            data.Fill(tb);
            cbFID.DataSource = tb;
            cbFID.DisplayMember = "FName";
            cbFID.ValueMember = "FID";
        }

        void htGRD(string sql)
        {
            data = new SqlDataAdapter(sql, cn);
            tb = new DataTable();
            data.Fill(tb);
            grd.DataSource = tb;
        }

        void vohieuhoa(bool b)
        {
            txtSID.Enabled = b;
            txtName.Enabled = b;
            dp.Enabled = b;
            txtAddress.Enabled = b;
            rdMale.Enabled = b;
            rdFemale.Enabled = b;

        }

        private void frmStudent_Load(object sender, EventArgs e)
        {
            string sql = "initial catalog = CourseRegistration; data source = TRAM\\TRAMPC; integrated security = true";
            cn = new SqlConnection(sql);
            cn.Open();
            htKhoa();

            vohieuhoa(false);
            sql = "select * from Student where FID = '" + cbFID.SelectedValue.ToString() + "'";
            htGRD(sql);
        }

        private void bAdd_Click(object sender, EventArgs e)
        {
            vohieuhoa(true);
            txtName.Clear();
            dp.Text = "";
            txtAddress.Clear();
            rdMale.Checked = true;
            txtHT.Clear();

            txtSID.Text = phatsinhTudong(cbFID.SelectedValue.ToString());
            txtSID.ReadOnly = true;
            txtName.Focus();
        }

        public string phatsinhTudong(string mk)
        {
            string s = "select top 1 SID from Student where FID = '" + mk + "' order by SID desc";
            data = new SqlDataAdapter(s, cn);
            tb = new DataTable();
            data.Fill(tb);

            if (tb.Rows.Count > 0)
            {
                s = tb.Rows[0][0].ToString();
                s = s.Substring(s.Length - 4, 4);
                int stt = int.Parse(s) + 1;
                if (stt < 10)
                    s = mk + "000" + stt.ToString();
                else if (stt < 100)
                    s = mk + "00" + stt.ToString();
                else if (stt < 1000)
                    s = mk + "0" + stt.ToString();
                else
                    s = mk + stt.ToString();
            }
            else
                s = mk + "0001";


            return s;
        }

        private void bSave_Click(object sender, EventArgs e)
        {
            string gender = "Male";
            if(rdFemale.Checked)
            {
                gender= rdFemale.Text;
            }
            string s = "insert into Student values ('" + txtSID.Text + "',N'" + txtName.Text + "', '" + dp.Value.ToShortDateString() + "', N'" + txtHT.Text + "', N'" + gender + "', N'" + txtAddress.Text + "', '" + cbFID.SelectedValue.ToString() + "')";
            SqlCommand cm = new SqlCommand(s, cn);
            cm.ExecuteNonQuery();

            string sql = "select * from Student where FID = '" + cbFID.SelectedValue.ToString() + "'";
            htGRD(sql);
        }

        private void cbFID_SelectedIndexChanged(object sender, EventArgs e)
        {
            string sql = "select * from Student where FID = '" + cbFID.SelectedValue.ToString() + "'";
            htGRD(sql);
        }
    }
}
