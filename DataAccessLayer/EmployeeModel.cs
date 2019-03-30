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
    }
}
