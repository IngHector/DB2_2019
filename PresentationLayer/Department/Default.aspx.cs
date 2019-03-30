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
            query01();
        }

        private void query01()
        {
            DepartmentModel dm = new DepartmentModel();
            gridData.DataSource = dm.query03();
            gridData.DataBind();
        }
    }

    
}