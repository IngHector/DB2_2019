using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using EntitiesLayer;

namespace DataAccessLayer
{
    public class Emp_ActModel
    {

        public dynamic query21()
      {
          using (DB2Entities context = new DB2Entities())
          {
                var qry = (from ea in context.EMP_ACT
                           join e in context.EMPLOYEE
                           on ea.EMPNO equals (e.EMPNO)
                           where e.EMPNO.CompareTo("0001000")<=0
                           select new
                         {
                             ea.EMPNO,
                             ea.PROJNO
                         }).Distinct().ToList();
              return qry;
          }
      }
        public dynamic query26()
        {
            using (DB2Entities context = new DB2Entities())
            {
                var qry = (from e in context.EMP_ACT
                           join p in context.PROJECT
                           on e.PROJNO equals (p.PROJNO)
                           where e.PROJNO.Contains("AD") &&
                           (e.ACTNO==10 ||
                           e.ACTNO == 80 ||
                           e.ACTNO == 180)
                           orderby e.ACTNO, e.PROJNO
                           select new
                           {
                               e.PROJNO,
                               e.ACTNO,
                               e.EMSTDATE,
                               e.EMENDATE
                           }).Distinct().ToList();
                return qry;
            }
        }

        public dynamic query51()
        {
            using (DB2Entities context = new DB2Entities())
            {
                DateTime date = Convert.ToDateTime("15/10/1982");
                var qry = (from ea in context.EMP_ACT
                           join p in context.PROJECT
                           on ea.PROJNO equals (p.PROJNO)
                           join e in context.EMPLOYEE on
                           ea.EMPNO equals (e.EMPNO)
                           join d in context.DEPARTMENT on
                           e.WORKDEPT equals(d.DEPTNO)
                           where ea.EMSTDATE>=date
                           orderby ea.ACTNO,ea.EMSTDATE
                           select new
                           {
                               ea.ACTNO,
                               d.MGRNO,
                               ea.EMSTDATE,
                               p.PROJNO,
                               e.LASTNAME,

                           }).ToList();
                return qry;
            }
        }
    }
}
