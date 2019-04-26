using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using DataAccessLayer;
using EntitiesLayer;

namespace PresentationLayer.Department
{
    public partial class Default : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            querys();
        }

        private void querys()
        {
            DepartmentModel dm = new DepartmentModel();
            EmployeeModel em = new EmployeeModel();

            //Department
            gv1.DataSource = dm.query01();
            gv1.DataBind();
            gv2.DataSource = dm.query02();
            gv2.DataBind();
            gv3.DataSource = dm.query03();
            gv3.DataBind();
            gv4.DataSource = dm.query04();
            gv4.DataBind();
            gv5.DataSource = dm.query05();
            gv5.DataBind();

            //Empoyee
            gv6.DataSource = em.query06();
            gv6.DataBind();
            gv7.DataSource = em.query07();
            gv7.DataBind();

            //Department
            gv8.DataSource = dm.query08();
            gv8.DataBind();

            //employee
            gv9.DataSource = em.query09();
            gv9.DataBind();
            gv10.DataSource = em.query10();
            gv10.DataBind();
            gv11.DataSource = em.query11();
            gv11.DataBind();
            gv12.DataSource = em.query12();
            gv12.DataBind();
            gv13.DataSource = em.query13();
            gv13.DataBind();
            gv14.DataSource = em.query14();
            gv14.DataBind();
            gv15.DataSource = em.query15();
            gv15.DataBind();

            //department
            gv16.DataSource = dm.query16();
            gv16.DataBind();

            //employee
            gv17.DataSource = em.query17();
            gv17.DataBind();

        }

        protected void gridData_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            Response.Redirect("/Ejercicios2/Default.aspx");
        }

    }
}