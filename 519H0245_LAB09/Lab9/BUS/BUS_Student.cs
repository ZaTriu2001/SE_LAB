using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAL;

namespace BUS
{
    public class BUS_Student
    {
        DAL_Student p;

        public BUS_Student(string sid, string name, string ht, string dob, double gpa)
        {
            p = new DAL_Student(sid, name, ht, dob, gpa);
        }

        public void addQuery()
        {
            p.addQuery();
        }

        public void updateQuere()
        {
            p.updateQuery();
        }

        public void deleteQuery()
        {
            p.deleteQuery();
        }

        public DataTable selectQuery()
        {
            return p.selectQuery();
        }

        
    }
}
