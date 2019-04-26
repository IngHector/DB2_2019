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

        public dynamic query04()
        {
            using (DB2Entities context = new DB2Entities())
            {
                var qry = (from d in context.DEPARTMENT
                           orderby d.ADMRDEPT ascending
                           select new
                           {
                               d.DEPTNO,
                               d.DEPTNAME,
                               d.ADMRDEPT
                           }).ToList();
                return qry;
            }
        }
        public dynamic query05()
        {
            using (DB2Entities context = new DB2Entities())
            {
                var qry = (from d in context.DEPARTMENT
                           orderby d.ADMRDEPT ascending,d.DEPTNAME descending                           select new
                           {
                               d.DEPTNO,
                               d.DEPTNAME,
                               d.ADMRDEPT
                           }).ToList();
                return qry;
            }
        }

        public dynamic query08()
        {
            using (DB2Entities context = new DB2Entities())
            {
                var qry = (from d in context.DEPARTMENT
                           where d.ADMRDEPT=="A00"
                           select new
                           {
                               d.DEPTNO,
                               d.ADMRDEPT
                           }).ToList();
                return qry;
            }
        }

        public dynamic query16()
        {
            using (DB2Entities context = new DB2Entities())
            {
                var qry = (from d in context.DEPARTMENT
                           where d.MGRNO == null
                           select new
                           {
                               d.DEPTNO,
                               d.DEPTNAME,
                               d.MGRNO
                           }).ToList();
                return qry;
            }
        }

        public dynamic query27()
        {
            using (DB2Entities context = new DB2Entities())
            {
                var qry = (from d in context.DEPARTMENT
                           where d.MGRNO != null
                           orderby d.MGRNO
                           select new
                           {
                               d.MGRNO,
                               d.DEPTNO
                           }).ToList();
                return qry;
            }
        }

        public dynamic query31()
        {
            using (DB2Entities context = new DB2Entities())
            {
                var qry = (from d in context.DEPARTMENT
                           where d.DEPTNO.Contains("11")
                           orderby d.DEPTNO
                           select new
                           {
                               d.DEPTNO,
                               d.DEPTNAME
                           }).ToList();
                return qry;
            }
        }

        public dynamic query33()
        {
            using (DB2Entities context = new DB2Entities())
            {
                var qry = (from d in context.DEPARTMENT
                           join p in context.PROJECT
                           on d.DEPTNO equals(p.DEPTNO)
                           orderby p.PROJNO
                           select new
                           {
                               p.PROJNO,
                               p.PROJNAME,
                               d.DEPTNO,
                               d.DEPTNAME
                           }).Take(8).ToList();
                return qry;
            }
        }

        public dynamic query34()
        {
            using (DB2Entities context = new DB2Entities())
            {
                var qry = (from d in context.DEPARTMENT
                           from p in context.PROJECT  
                           from e in context.EMPLOYEE
                           where p.DEPTNO == d.DEPTNO &&
                           d.MGRNO==e.EMPNO && d.DEPTNO=="D21"
                           orderby p.PROJNO
                           select new
                           {
                               p.PROJNO,
                               d.DEPTNO,
                               d.DEPTNAME,
                               d.MGRNO,
                               e.LASTNAME
                           }).ToList();
                return qry;
            }
        }

        public dynamic query44()
        {
            using (DB2Entities context = new DB2Entities())
            {
                var qry = (from d in context.DEPARTMENT
                           from e in context.EMPLOYEE
                           where d.MGRNO== e.EMPNO
                           orderby d.DEPTNAME
                           select new
                           {
                              d.DEPTNAME,
                              e.LASTNAME,
                              e.FIRSTNME
                           }).ToList();
                return qry;
            }
        }

        public dynamic query45()
        {
            using (DB2Entities context = new DB2Entities())
            {
                var qry = (from d in context.DEPARTMENT
                           from e in context.EMPLOYEE
                           where e.WORKDEPT== d.DEPTNO
                           orderby d.DEPTNAME
                           select new
                           {
                               d.DEPTNAME,
                               e.LASTNAME,
                               e.FIRSTNME
                           }).Take(20).ToList();
                return qry;
            }
        }

        public dynamic query52()
        {
            using (DB2Entities context = new DB2Entities())
            {
                var qry = (from d in context.DEPARTMENT
                           join e in context.EMPLOYEE on
                            d.DEPTNO equals (e.WORKDEPT)
                           join m in context.EMPLOYEE on
                           d.MGRNO equals (m.EMPNO)
                           where e.HIREDATE < m.HIREDATE
                           && e.EMPNO!=m.EMPNO && d.DEPTNO=="A00"
                           select new
                           {
                               d.DEPTNO,
                               MANAGER=m.LASTNAME,
                               EMPLOYEE=e.LASTNAME,
                               M_HIREDAATE=m.HIREDATE,
                               E_HIREDATE=e.HIREDATE
                               
                           }).Distinct().ToList();
                return qry;
            }
        }
    }
}
