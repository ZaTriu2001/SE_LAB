using Lab02;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class Form1 : Form
    {
        
        public Form1()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {

        }

        Modify modify;
        
        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            modify = new Modify();
            try
            {
                dataGridView1.DataSource = modify.getAllStudent();
            }
            catch (Exception ex) {
                MessageBox.Show("Error occoured: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

       
    

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        Student student;
        private void button4_Click(object sender, EventArgs e)
        {
            string name = this.txtNameBox.Text;
            bool sex = this.rbtnMale.Checked;
            DateTime birth = this.dateTimePicker1.Value;
            string email = this.txtEmailBox.Text;
            student = new Student(name, birth, sex, email);


            if (modify.addHandler(student))
            {
                dataGridView1.DataSource = modify.getAllStudent();
            }
            else
            {
                MessageBox.Show("Error occoured: " + "Cannot add student info", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            DataGridViewRow row = dataGridView1.CurrentRow;
            int maso = Convert.ToInt32(row.Cells["maso"].Value);
            
            clear();
            modify.deleteStudent(maso);
            dataGridView1.DataSource = modify.getAllStudent();
        }


        private void button1_Click(object sender, EventArgs e)
        {
            DataGridViewRow row = dataGridView1.CurrentRow;
            int maso = Convert.ToInt32(row.Cells["maso"].Value);
            string name = this.txtNameBox.Text;
            bool sex = this.rbtnMale.Checked;
            DateTime birth = this.dateTimePicker1.Value;
            string email = this.txtEmailBox.Text;

            student = new Student(name, birth, sex, email);
            modify.updateStudent(maso, student);
            dataGridView1.DataSource = modify.getAllStudent();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            clear();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            DataGridViewRow row = dataGridView1.CurrentRow;
            txtNameBox.Text = row.Cells["hoTen"].Value.ToString();
            txtEmailBox.Text = row.Cells["email"].Value.ToString(); ;
            dateTimePicker1.Value = Convert.ToDateTime(row.Cells["ngaySinh"].Value);
            setAddState(false);

            bool isMale = Convert.ToBoolean(row.Cells["gioiTinh"].Value);

            if (isMale)
            {
                rbtnMale.Checked = true;
                radioButton2.Checked = false;
            } else
            {
                rbtnMale.Checked = false;
                radioButton2.Checked = true;
            }

        }

        private void clear()
        {
            txtNameBox.Text = "";
            txtEmailBox.Text = "";
            rbtnMale.Checked = false;
            radioButton2.Checked = false;
            dateTimePicker1.Text = "";
            setAddState(true);
        }

        private void setAddState(bool state)
        {
            button4.Enabled = state;
            button1.Enabled = !state;
            button2.Enabled = !state;
            button3.Enabled = !state;
        }
    }
}
