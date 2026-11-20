using System.Data;
using System.Data.SqlClient;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace Lab6
{
    public partial class Form1 : Form
    {
        SqlConnection cn;

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            string sql = "initial catalog = CourseRegistration; data source = TRAM\\TRAMPC; integrated security = true";
            cn = new SqlConnection(sql);
            cn.Open();

            htGRD("select * from faculty");
        }

        private void bAdd_Click(object sender, EventArgs e)
        {
            txtFName.Clear();
            txtLocation.Clear();
            txtPhone.Clear();

            txtFName.Focus();
        }

        private void txtFName_Leave(object sender, EventArgs e)
        {
            string s = txtFName.Text;
            string[] t = s.Split(' ');
            string res = "";
            for(int i = 0; i<t.Length; i++)
            {
                res += t[i].Substring(0,1).ToUpper();
            }
            txtFID.Text = res;
        }

        void htGRD(string sql)
        {
            SqlDataAdapter data = new SqlDataAdapter(sql, cn);
            DataTable tb = new DataTable();
            data.Fill(tb);
            grd.DataSource = tb;
        }

        private void bSave_Click(object sender, EventArgs e)
        {
            string s = "insert into faculty values ('" + txtFID.Text + "',N'" + txtFName.Text + "', '" + txtLocation.Text + "', '" + txtPhone.Text + "')";
            SqlCommand cm = new SqlCommand(s, cn);
            cm.ExecuteNonQuery();

            string sql = "select * from faculty";
            htGRD(sql);
        }
    }
}