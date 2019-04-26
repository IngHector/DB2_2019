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
            querys();
        }

        private void querys()
        {
            DepartmentModel dm = new DepartmentModel();
            EmployeeModel em = new EmployeeModel();
            Emp_ActModel am = new Emp_ActModel();
            ProjectModel pm = new ProjectModel();

            gv18.DataSource = em.query18();
            gv18.DataBind();
            gv19.DataSource = em.query19();
            gv19.DataBind();
            gv20.DataSource = em.query20();
            gv20.DataBind();
            gv21.DataSource = am.query21();
            gv21.DataBind();
            gv22.DataSource = em.query22();
            gv22.DataBind();
            gv23.DataSource = em.query23();
            gv23.DataBind();
            gv24.DataSource = em.query24();
            gv24.DataBind();
            gv25.DataSource = em.query25();
            gv25.DataBind();


            gv26.DataSource = am.query26();
            gv26.DataBind();

            gv27.DataSource = dm.query27();
            gv27.DataBind();

            gv28.DataSource = em.query28();
            gv28.DataBind();
            gv29.DataSource = em.query29();
            gv29.DataBind();

            gv30.DataSource = pm.query30();
            gv30.DataBind();

            gv31.DataSource = dm.query31();
            gv31.DataBind();

            gv32.DataSource = em.query32();
            gv32.DataBind();
        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            Response.Redirect("/Ejercicios3/Default.aspx");
        }

        protected void Button2_Click(object sender, EventArgs e)
        {
            Response.Redirect("/Ejercicios1/Default.aspx");
        }
    }
}