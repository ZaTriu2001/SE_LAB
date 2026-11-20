using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DTO;

namespace DAL
{
    public class DAL_Student
    {
        DTO_Student p;

        public DAL_Student(string sid, string name, string ht, string dob, double gpa)
        {
            p = new DTO.DTO_Student(sid, name, ht, dob, gpa);  
        }

        public void addQuery()
        {
            string query = "insert into Student values ('" + p._SID + "', N'" + p._SNAME + "', N'" + p._HOMETOWN + "', " + p._DOB + "', " + p._GPA + ")";
            Connection.actionQuery(query);
        }

        public void updateQuery()
        {
            string query = "update Student set SName = N'" + p._SNAME + "', Hometown = N'" + p._HOMETOWN + "', DOB = '" + p._DOB + "', GPA = " + p._GPA + "' where STID = '" + p._SID + "'";
            Connection.actionQuery(query);
        }

        public void deleteQuery()
        {
            string query = "delete from Student where STID = '" + p._SID + "'";
            Connection.actionQuery(query);
        }
        public DataTable selectQuery()
        {
            string s = "select * from Student";
            return Connection.selectQuery(s);
        }


        
    }
}
