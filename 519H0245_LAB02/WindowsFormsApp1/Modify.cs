using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;
using Lab02;

namespace Lab02
{
    internal class Modify
    {
        SqlDataAdapter dataAdapter; // Truy suất data vào bảng 
        SqlCommand sqlCommand; // Dùng để truy vấn và cập nhật tới CSDL
        public Modify()
        {
        }

        public DataTable getAllStudent()
        {
            DataTable dataTable = new DataTable();
            string query = "select * from student";

            using (SqlConnection sqlConnection = Connection.GetConnection())
            {
                sqlConnection.Open();

                dataAdapter = new SqlDataAdapter(query, sqlConnection);
                dataAdapter.Fill(dataTable);

                sqlConnection.Close();
            }
            return dataTable;
        }

        public void updateStudent(int maso, Student student)
        {
            SqlConnection sqlConnection = Connection.GetConnection();
            string query = "update student set hoten = @hoten, ngaysinh = @ngaysinh, gioiTinh = @gioiTinh, email = @email where maso = @maso";

            
            sqlConnection.Open();
            sqlCommand = new SqlCommand(query, sqlConnection);
            sqlCommand.Parameters.AddWithValue("@hoten", student.Name);
            sqlCommand.Parameters.AddWithValue("@ngaysinh", student.Bitrh);
            sqlCommand.Parameters.AddWithValue("@gioiTinh", student.Sex);
            sqlCommand.Parameters.AddWithValue("@email", student.Email);
            sqlCommand.Parameters.AddWithValue("@maso", maso);
            sqlCommand.ExecuteNonQuery();
            sqlConnection.Close();

        }

        public void deleteStudent(int maso) {
            SqlConnection sqlConnection = Connection.GetConnection();
            string query = "delete from student where maso = @maso";

            sqlConnection.Open();
            sqlCommand = new SqlCommand(query, sqlConnection);
            sqlCommand.Parameters.AddWithValue("@maso", maso);
            sqlCommand.ExecuteNonQuery();
            sqlConnection.Close();
        }

        public bool addHandler(Student student)
        {
            SqlConnection sqlConnection = Connection.GetConnection();
            string query = "insert student values (@hoTen,@ngaysinh,@gioiTinh,@email)";

            try
            {
                sqlConnection.Open();
                sqlCommand = new SqlCommand(query, sqlConnection);
                sqlCommand.Parameters.Add("@hoTen", SqlDbType.NVarChar).Value = student.Name;
                sqlCommand.Parameters.Add("@ngaysinh", SqlDbType.DateTime).Value = student.Bitrh.ToShortDateString(); // dd/mm/yyyy
                sqlCommand.Parameters.Add("@gioiTinh", SqlDbType.Bit).Value = student.Sex;
                sqlCommand.Parameters.Add("@email", SqlDbType.NVarChar).Value = student.Email;
                sqlCommand.ExecuteNonQuery(); // execute the query command
            }
            catch
            {
                return false;
            }
            finally { sqlConnection.Close(); }
            return true;
        }
    }
}
