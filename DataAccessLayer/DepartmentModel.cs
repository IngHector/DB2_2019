using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using EntitiesLayer;

namespace DataAccessLayer
{
    public class DepartmentModel
    {
        public List<DEPARTMENT> query01()
        {
            using (DB2Entities context = new DB2Entities())
            {
                return context.DEPARTMENT.ToList();
            }
        }

        public List<DEPARTMENT> query02()
        {
            using (DB2Entities context = new DB2Entities())
            {
                return context.DEPARTMENT.Take(5).ToList();
            }
        }

        public dynamic query03()
        {
            using (DB2Entities context = new DB2Entities())
            {
               var qry = (from d in context.DEPARTMENT
                           select new
                           {
                               d.DEPTNO,
                               d.DEPTNAME,
                               d.ADMRDEPT
                           }).ToList();
                return qry;
            }
        }
    }
}
