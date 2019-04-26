using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using EntitiesLayer;
using DataAccessLayer;

namespace PresentationLayer.Ejercicios3y4
{
    public partial class Default : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            DepartmentModel dm = new DepartmentModel();
            EmployeeModel em = new EmployeeModel();
            ProjectModel pm = new ProjectModel();
            Emp_ActModel ea = new Emp_ActModel();

            gv33.DataSource = dm.query33();
            gv33.DataBind();
            gv34.DataSource = dm.query34();
            gv34.DataBind();
            gv35.DataSource = em.query35();
            gv35.DataBind();
            gv36.DataSource = em.query36();
            gv36.DataBind();

            gv37.DataSource = em.query37();
            gv37.DataBind();
            gv38.DataSource = em.query38();
            gv38.DataBind();

            gv39.DataSource = em.query39();
            gv39.DataBind();

            gv40.DataSource = em.query40();
            gv40.DataBind();
            gv41.DataSource = em.query41();
            gv41.DataBind();
        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            Response.Redirect("/Ejercicios2/Default.aspx");
        }

        protected void Button2_Click(object sender, EventArgs e)
        {
            Response.Redirect("/Ejercicios4/Default.aspx");
        }
    }
}