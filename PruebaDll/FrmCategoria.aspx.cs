using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using AlvaradoAlexis;

namespace PruebaDll
{
    public partial class FrmCategoria : System.Web.UI.Page
    {
        Datos obj = new Datos();
        protected void Page_Load(object sender, EventArgs e)
        {
            if (IsPostBack == true)
            {
                return;
            }
            //cargar Datos
            DdCategoria.DataSource = obj.ProcedimientoConParametros("usp_ListaCate");
            //dato a visualizar
            DdCategoria.DataTextField = "NombreCategoria";
            //dato a comparar
            DdCategoria.DataValueField = "IdCategoria";
            DdCategoria.DataBind();
        }

        protected void GvProductos_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        protected void DdCategoria_SelectedIndexChanged(object sender, EventArgs e)
        {
            //capturar el codigo del combo
            object x = DdCategoria.SelectedValue.ToString();
            GvProductos.DataSource = obj.ProcedimientoConParametros("usp_Productos_Categoria", x);
            GvProductos.DataBind();
        }
    }
}