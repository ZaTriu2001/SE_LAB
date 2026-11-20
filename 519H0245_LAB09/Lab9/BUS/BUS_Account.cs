using DAL;
using System.Data;

namespace BUS
{
    public class BUS_Account
    {
        DAL_Account p;

        public BUS_Account(string user, string pass, string quyen)
        {
            p = new DAL_Account(user, pass, quyen);
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

        public DataTable selectQuery(string user, string pass)
        {
            return p.selectQuery(user, pass);
        }

        
    }
}
