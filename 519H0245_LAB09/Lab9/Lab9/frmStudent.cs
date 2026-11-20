using System.Data;
using BUS;
namespace Lab9
{
    public partial class frmStudent : Form
    {
        BUS_Student bs = new BUS_Student("","","","",0);
        public frmStudent()
        {
            InitializeComponent();
        }
        public void vohieuhoa(bool b)
        {
            this.txtSID.ReadOnly = b;
            txtName.ReadOnly = b;
            txtHometown.ReadOnly = b;
            txtDOB.ReadOnly = b;
            txtGPA.ReadOnly = b;
        }
        private void frmStudent_Load(object sender, EventArgs e)
        {
            vohieuhoa(true);
            if (Program.quyen == "Student")
            {
                txtSID.ReadOnly = false;
                txtSID.Focus();

            }
        }

        private void txtSID_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                DataTable tb = bs.selectQuery();
                grd.DataSource = tb;
            }
        }
    }
}
