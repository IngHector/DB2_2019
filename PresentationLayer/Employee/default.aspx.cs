using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using EntitiesLayer;
using DataAccessLayer;

namespace PresentationLayer.Employee
{
    public partial class _default : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            loadTable();
        }

        private void loadTable() {
            EmployeeModel em = new EmployeeModel();
            gridEmployees.DataSource = em.getAll();
            gridEmployees.DataBind();
        }
    }
}