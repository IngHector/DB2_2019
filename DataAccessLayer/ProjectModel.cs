using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DataAccessLayer
{
    public class ProjectModel
    {
        public dynamic query30()
        {
            using (DB2Entities context = new DB2Entities())
            {
                var qry = (from p in context.PROJECT
                           where p.PROJNAME.Contains("SUPPORT")
                           orderby p.PROJNO
                           select new
                           {
                             p.PROJNO,
                             p.PROJNAME
                           }).ToList();
                return qry;
            }
        }

        public dynamic query46()
        {
            using (DB2Entities context = new DB2Entities())
            {
                var qry = (from p in context.PROJECT
                           join ea in context.EMP_ACT on
                           p.PROJNO equals (ea.PROJNO)
                           where p.PROJNO.Contains("AD")
                           orderby p.PROJNO,ea.ACTNO
                           select new
                           {
                             p.PROJNO,
                             p.PROJNAME,
                             ea.ACTNO
                           }).Take(15).ToList();
                return qry;
            }
        }
    }
}
