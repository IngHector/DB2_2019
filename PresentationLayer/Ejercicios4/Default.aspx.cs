using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using DataAccessLayer;

namespace PresentationLayer.Ejercicios4
{
    public partial class Default : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            DepartmentModel dm = new DepartmentModel();
            EmployeeModel em = new EmployeeModel();
            ProjectModel pm = new ProjectModel();
            Emp_ActModel ea = new Emp_ActModel();

            gv42.DataSource = em.query42();
            gv42.DataBind();
            gv43.DataSource = em.query43();
            gv43.DataBind();

            gv44.DataSource = dm.query44();
            gv44.DataBind();
            gv45.DataSource = dm.query45();
            gv45.DataBind();

            gv46.DataSource = pm.query46();
            gv46.DataBind();

            gv47.DataSource = em.query47();
            gv47.DataBind();
            gv48.DataSource = em.query48();
            gv48.DataBind();
            gv49.DataSource = em.query49();
            gv49.DataBind();
            gv50.DataSource = em.query50();
            gv50.DataBind();
            gv51.DataSource = ea.query51();
            gv51.DataBind();

            gv52.DataSource = dm.query52();
            gv52.DataBind();
        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            Response.Redirect("/Ejercicios3/Default.aspx");
        }
    }
}