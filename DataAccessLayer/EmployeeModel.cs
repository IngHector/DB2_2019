using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using EntitiesLayer;

namespace DataAccessLayer
{
    public class EmployeeModel
    {
        public List<EMPLOYEE> getAll() {
            using (DB2Entities context = new DB2Entities())
            {
                return context.EMPLOYEE.ToList();
            }
        }

        public dynamic query06()
        {
            using (DB2Entities context = new DB2Entities())
            {
                var qry = (from d in context.EMPLOYEE
                           orderby d.WORKDEPT,d.JOB
                           select new
                           {
                               d.WORKDEPT,
                               d.JOB
                           }).ToList();
                return qry;
            }
        }

        public dynamic query07()
        {
            using (DB2Entities context = new DB2Entities())
            {
                var qry = (from d in context.EMPLOYEE
                           orderby d.WORKDEPT, d.JOB
                           select new
                           {
                               d.WORKDEPT,
                               d.JOB
                           }).Distinct().ToList();
                return qry;
            }
        }

        public dynamic query09()
        {
            using (DB2Entities context = new DB2Entities())
            {
                var qry = (from d in context.EMPLOYEE
                           where d.EDLEVEL>=19
                           select new
                           {
                               d.LASTNAME,
                               d.EDLEVEL
                           }).ToList();
                return qry;
            }
        }

        public dynamic query10()
        {
            using (DB2Entities context = new DB2Entities())
            {
                var qry = (from d in context.EMPLOYEE
                           where d.JOB == "ANALYST" && d.EDLEVEL==16
                           select new
                           {
                               d.EMPNO,
                               d.JOB,
                               d.EDLEVEL
                           }).ToList();
                return qry;
            }
        }

        public dynamic query11()
        {
            using (DB2Entities context = new DB2Entities())
            {
                var qry = (from d in context.EMPLOYEE
                           where d.JOB == "ANALYST" || d.EDLEVEL==16
                           select new
                           {
                               d.EMPNO,
                               d.JOB,
                               d.EDLEVEL
                           }).ToList();
                return qry;
            }
        }

        public dynamic query12()
        {
            using (DB2Entities context = new DB2Entities())
            {
                var qry = (from d in context.EMPLOYEE
                           where d.JOB == "ANALYST" 
                           && d.EDLEVEL == 16
                           || d.EDLEVEL == 18
                           select new
                           {
                               d.EMPNO,
                               d.JOB,
                               d.EDLEVEL
                           }).ToList();
                return qry;
            }
        }

        public dynamic query13()
        {
            using (DB2Entities context = new DB2Entities())
            {
                var qry = (from d in context.EMPLOYEE
                           where d.JOB == "ANALYST" 
                           && (d.EDLEVEL == 16 || d.EDLEVEL==18)
                           select new
                           {
                               d.EMPNO,
                               d.JOB,
                               d.EDLEVEL
                           }).ToList();
                return qry;
            }
        }

        public dynamic query14()
        {
            using (DB2Entities context = new DB2Entities())
            {
                var qry = (from d in context.EMPLOYEE
                           where d.EDLEVEL==14|| d.EDLEVEL == 19 || d.EDLEVEL == 20
                           select new
                           {
                               d.LASTNAME,
                               d.EDLEVEL
                           }).ToList();
                return qry;
            }
        }

        public dynamic query15()
        {
            using (DB2Entities context = new DB2Entities())
            {
                var qry = (from d in context.EMPLOYEE
                           where d.EDLEVEL >= 14  && d.EDLEVEL <= 20
                           select new
                           {
                               d.LASTNAME,
                               d.EDLEVEL
                           }).ToList();
                return qry;
            }
        }

        public dynamic query17()
        {
            using (DB2Entities context = new DB2Entities())
            {
                var qry = (from d in context.EMPLOYEE
                           where d.LASTNAME.Contains("G")
                           select new
                           {
                               d.LASTNAME
                           }).ToList();
                return qry;
            }
        }

        public dynamic query18()
        {
            using (DB2Entities context = new DB2Entities())
            {
                var qry = (from d in context.EMPLOYEE
                           where d.SALARY>30000
                           orderby d.SALARY descending
                           select new
                           {
                               d.EMPNO,
                               d.LASTNAME,
                               d.BIRTHDATE,
                               d.SALARY
                           }).ToList();
                return qry;
            }
        }

        public dynamic query19()
        {
            using (DB2Entities context = new DB2Entities())
            {
                var qry = (from d in context.EMPLOYEE
                           orderby d.WORKDEPT descending,d.LASTNAME descending
                           select new
                           {
                               d.LASTNAME,
                               d.FIRSTNME,
                               d.WORKDEPT
                           }).ToList();
                return qry;
            }
        }

        public dynamic query20()
        {
            using (DB2Entities context = new DB2Entities())
            {
                var qry = (from d in context.EMPLOYEE
                           orderby d.EDLEVEL descending
                           select new
                           {
                               d.EDLEVEL
                           }).Distinct().ToList();
                return qry;
            }
        }

      
        public dynamic query22()
        {
            using (DB2Entities context = new DB2Entities())
            {
                var qry = (from d in context.EMPLOYEE
                           where d.SEX=="M"
                           select new
                           {
                               d.LASTNAME,
                               d.SALARY,
                               d.BONUS
                           }).ToList();
                return qry;
            }
        }

        public dynamic query23()
        {
            using (DB2Entities context = new DB2Entities())
            {
                var qry = (from d in context.EMPLOYEE
                           where d.SALARY > 20000 &&
                          d.HIREDATE.Value.Year>1979
                           select new
                           {
                               d.LASTNAME,
                               d.SALARY,
                               d.COMM
                           }).ToList();
                return qry;
            }
        }

        public dynamic query24()
        {
            using (DB2Entities context = new DB2Entities())
            {
                var qry = (from d in context.EMPLOYEE
                           where (d.SALARY > 22000 && d.BONUS==400)||
                           (d.BONUS==500 && d.COMM<1900)
                           orderby d.LASTNAME
                           select new
                           {
                               d.LASTNAME,
                               d.SALARY,
                               d.BONUS,
                               d.COMM
                           }).ToList();
                return qry;
            }
        }

        public dynamic query25()
        {
            using (DB2Entities context = new DB2Entities())
            {
                var qry = (from d in context.EMPLOYEE
                           where (d.SALARY > 22000 && (d.BONUS == 400|| d.BONUS==500)) &&
                           (d.COMM<1900)
                           orderby d.LASTNAME
                           select new
                           {
                               d.LASTNAME,
                               d.SALARY,
                               d.BONUS,
                               d.COMM
                           }).ToList();
                return qry;
            }
        }

        public dynamic query28()
        {
            using (DB2Entities context = new DB2Entities())
            {
                var qry = (from d in context.EMPLOYEE
                           where d.BONUS>=800 && d.BONUS<=1000
                           orderby d.EMPNO,d.BONUS ascending
                           select new
                           {
                               d.EMPNO,
                               d.LASTNAME,
                               d.SALARY,
                               d.BONUS
                           }).ToList();
                return qry;
            }
        }

        public dynamic query29()
        {
            using (DB2Entities context = new DB2Entities())
            {
                var qry = (from d in context.EMPLOYEE
                           where d.WORKDEPT=="A00"|| 
                           d.WORKDEPT == "B01"|| 
                           d.WORKDEPT == "C01"
                           orderby d.LASTNAME,d.EMPNO
                           select new
                           {
                               d.EMPNO,
                               d.LASTNAME,
                               d.SALARY,
                               d.WORKDEPT
                           }).ToList();
                return qry;
            }
        }

        public dynamic query32()
        {
            using (DB2Entities context = new DB2Entities())
            {
                var qry = (from d in context.EMPLOYEE
                           where d.JOB != "PRES" && d.JOB!="MANAGER"
                           orderby d.SALARY descending
                           select new
                           {
                               d.LASTNAME,
                               d.FIRSTNME,
                               d.MIDINIT,
                               d.SALARY
                           }).Take(5).ToList();
                return qry;
            }
        }
        
        public dynamic query35()
        {
            using (DB2Entities context = new DB2Entities())
            {
                var qry = (from e in context.EMPLOYEE
                           from d in context.DEPARTMENT
                           where e.WORKDEPT ==d.DEPTNO
                           select new
                           {
                               e.EMPNO,
                               e.LASTNAME,
                               e.WORKDEPT,
                               d.DEPTNAME
                           }).Take(10).ToList();
                return qry;
            }
        }

        public dynamic query36()
        {
            using (DB2Entities context = new DB2Entities())
            {
                var qry = (from e in context.EMPLOYEE
                           from a in context.EMP_ACT
                           where e.EMPNO ==a.EMPNO
                           select new
                           {
                               e.EMPNO,
                               e.LASTNAME,
                              a.ACTNO
                           }).Take(10).ToList();
                return qry;
            }
        }

        public dynamic query37()
        {
            using (DB2Entities context = new DB2Entities())
            {
                var qry = (from e in context.EMPLOYEE
                           from d in context.DEPARTMENT
                           where e.WORKDEPT ==d.DEPTNO
                           where e.JOB=="MANAGER"
                           select new
                           {
                               e.EMPNO,
                               e.FIRSTNME,
                               e.LASTNAME,
                               d.DEPTNAME
                           }).Take(15).ToList();
                return qry;
            }
        }
        
        public dynamic query38()
        {
            using (DB2Entities context = new DB2Entities())
            {
                var qry = (from e in context.EMPLOYEE
                           join d in context.DEPARTMENT
                           on e.WORKDEPT equals (d.DEPTNO)
                           select new
                           {
                               e.EMPNO,
                               e.LASTNAME,
                               e.WORKDEPT,
                               d.DEPTNAME
                           }).Take(10).ToList();
                return qry;
            }
        }

        public dynamic query39()
        {
            using (DB2Entities context = new DB2Entities())
            {
                var qry = (from e in context.EMPLOYEE
                           join a in context.EMP_ACT
                           on e.EMPNO equals (a.EMPNO)
                           select new
                           {
                               e.EMPNO,
                               e.LASTNAME,
                               a.ACTNO
                           }).Take(10).ToList();
                return qry;
            }
        }

        public dynamic query40()
        {
            using (DB2Entities context = new DB2Entities())
            {
                var qry = (from e in context.EMPLOYEE
                           join d in context.DEPARTMENT
                           on e.WORKDEPT equals (d.DEPTNO)
                           where e.JOB == "MANAGER"
                           select new
                           {
                               e.EMPNO,
                               e.FIRSTNME,
                               e.LASTNAME,
                               d.DEPTNAME
                           }).Take(15).ToList();
                return qry;
            }
        }

        public dynamic query41()
        {
            using (DB2Entities context = new DB2Entities())
            {
                var qry = (from e in context.EMPLOYEE
                           join d in context.DEPARTMENT on
                            e.WORKDEPT equals (d.DEPTNO)
                           join m in context.EMPLOYEE on
                           d.MGRNO equals (m.EMPNO)
                           where e.BIRTHDATE < m.BIRTHDATE
                           select new
                           {
                               e.EMPNO,
                               EMPLOYEE = e.LASTNAME,
                               E_BIRTHDATE = e.BIRTHDATE,
                               MANAGER = m.LASTNAME,
                               M_BIRTHDATE = m.BIRTHDATE,
                               

                           }).Distinct().ToList();
                return qry;
            }
        }

        public dynamic query42()
        {
            using (DB2Entities context = new DB2Entities())
            {
                var qry = (from e in context.EMPLOYEE
                           join d in context.DEPARTMENT
                           on e.WORKDEPT equals (d.DEPTNO)
                           orderby e.FIRSTNME,e.LASTNAME
                           orderby d.DEPTNAME
                           select new
                           {
                               e.LASTNAME,
                               e.FIRSTNME,
                               d.DEPTNAME
                           }).Take(15).ToList();
                return qry;
            }
        }
  

        public dynamic query43()
        {
            using (DB2Entities context = new DB2Entities())
            {
                var qry = (from e in context.EMPLOYEE
                           join d in context.DEPARTMENT
                           on e.WORKDEPT equals (d.DEPTNO)
                           where e.JOB=="CLERK"||e.JOB=="ANALYST"||e.JOB=="DESIGNER"
                           orderby d.DEPTNAME, e.JOB
                           select new
                           {
                               e.LASTNAME,
                               e.FIRSTNME,
                               d.DEPTNAME,
                               e.JOB

                           }).Take(15).ToList();
                return qry;
            }
        }

        public dynamic query47()
        {
            using (DB2Entities context = new DB2Entities())
            {
                var qry = (from e in context.EMPLOYEE
                           join d in context.DEPARTMENT
                           on e.WORKDEPT equals ( d.DEPTNO)
                           join p in context.PROJECT on
                           d.DEPTNO equals( p.DEPTNO)
                           where p.PROJNO=="AD3113"
                           select new
                           {
                               e.EMPNO,
                               e.LASTNAME,
                               p.PROJNO

                           }).Distinct().ToList();
                return qry;
            }
        }

        public dynamic query48()
        {
            using (DB2Entities context = new DB2Entities())
            {
                var qry = (from e in context.EMPLOYEE
                           join ea in context.EMP_ACT
                           on e.EMPNO equals (ea.EMPNO)
                           join p in context.PROJECT on
                           ea.PROJNO equals (p.PROJNO)
                           where ea.EMSTDATE.Value.Year==1982 &&
                           ea.EMSTDATE.Value.Month==10 &&
                           ea.EMSTDATE.Value.Day==1
                           select new
                           {
                               e.EMPNO,
                               p.PROJNO,
                               p.PROJNAME,
                               ea.ACTNO,
                               ea.EMSTDATE

                           }).ToList();
                return qry;
            }
        }

        public dynamic query49()
        {
            using (DB2Entities context = new DB2Entities())
            {
                var qry = (from e in context.EMPLOYEE
                           join ea in context.EMP_ACT
                           on e.EMPNO equals (ea.EMPNO)
                           join p in context.PROJECT on
                           ea.PROJNO equals (p.PROJNO)
                           where e.WORKDEPT=="A00"
                           select new
                           {
                               e.WORKDEPT,
                               e.LASTNAME,
                               p.PROJNAME,
                               ea.ACTNO,

                           }).ToList();
                return qry;
            }
        }

        public dynamic query50()
        {
            using (DB2Entities context = new DB2Entities())
            {
                var qry = (from e in context.EMPLOYEE
                           join ea in context.EMP_ACT
                           on e.EMPNO equals (ea.EMPNO)
                           join p in context.PROJECT on
                           ea.PROJNO equals (p.PROJNO)
                           where e.WORKDEPT == "A00"||
                           e.WORKDEPT == "B01"||
                           e.WORKDEPT == "C01"

                           orderby e.WORKDEPT, e.LASTNAME, ea.ACTNO
                           select new
                           {
                               e.WORKDEPT,
                               e.LASTNAME,
                               p.PROJNAME,
                               ea.ACTNO,

                           }).Distinct().ToList();
                return qry;
            }
        }

    }
}
