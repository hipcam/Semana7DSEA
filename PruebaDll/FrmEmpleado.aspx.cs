using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using AlvaradoAlexis;

namespace PruebaDll
{
    public partial class FrmEmpleado : System.Web.UI.Page
    {
        Datos obj = new Datos();
        protected void Page_Load(object sender, EventArgs e)
        {
            GvEmpleados.DataSource = obj.ListaDatosProcedimiento("Usp_ListaEmpleados");
            GvEmpleados.DataBind();
        }

        protected void GridView1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        protected void GvEmpleados_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}