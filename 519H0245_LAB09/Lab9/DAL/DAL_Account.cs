using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DTO;

namespace DAL
{
    public class DAL_Account
    {
        DTO_Account p;

        public DAL_Account(string tnd, string mk, string quyen)
        {
            p = new DTO_Account(tnd, mk, quyen);
        }

        public void addQuery()
        {
            string query = "insert into Taikhoan values ('" + p._TENND + "', '" + p._MATKHAU + "', '" + p._QUYEN + "')";
            Connection.actionQuery(query);
        }

        public void updateQuery()
        {
            string query = "update Taikhoan set Matkhau = N'" + p._MATKHAU + "', Quyen = '" + p._QUYEN + "' where TenND = '" + p._TENND + "'";
            Connection.actionQuery(query);
        }

        public void deleteQuery()
        {
            string query = "delete from Taikhoan where TenND = '" + p._TENND + "'";
            Connection.actionQuery(query);
        }
        public DataTable selectQuery(string user, string pass)
        {
            string s = "select * from Taikhoan where TenND = '" + user + "' and Matkhau = '" + pass + "'";
            return Connection.selectQuery(s);
        }


       
    }
}
