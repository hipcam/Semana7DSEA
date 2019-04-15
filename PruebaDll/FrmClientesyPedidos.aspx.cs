using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using AlvaradoAlexis;

namespace PruebaDll
{
    public partial class FrmClientesyPedidos : System.Web.UI.Page
    {
        Datos obj = new Datos();
        protected void Page_Load(object sender, EventArgs e)
        {
            GvClientes.DataSource = obj.ListaDatosProcedimiento("usp_ListarCliente");
            GvClientes.DataBind();
            GvPedidos.DataSource = obj.ListaDatosProcedimiento("usp_listapedidoscliente");
            GvPedidos.DataBind();
        }

        protected void GvClientes_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        protected void GvClientes_PageIndexChanging(object sender, GridViewPageEventArgs e)
        {
            GvClientes.PageIndex = e.NewPageIndex; 
            GvClientes.DataBind();
            GvPedidos.PageIndex = e.NewPageIndex;
            GvPedidos.DataBind();
        }
    }
}