using System;
using DatosAcceso;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using LogicaNego.logicaLogin;

namespace ASPLOGIN.formulario
{
    public partial class WebForm1 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if(!IsPostBack)
            {

            }
        }

        protected void Btningreso_Click(object sender, EventArgs e)
        {
            try
            {
                TBL_USUARIO _infoUsuario = new TBL_USUARIO();
                Encriptacion encriptar = new Encriptacion();
                _infoUsuario = LogicaNego.logicaLogin.Login.getUserLogin(TxtEmail.Text,
                                                                encriptar.sha1encriptacion(Txtpassword.Text));
                if(_infoUsuario !=null)
                {
                    Response.Write("<script>alert('Acceso Correcto');location='Admin.aspx'</script>");
                }
                else
                {
                    Response.Write("<script>alert('usuario correcto');</script>");
                }
            }
            catch (Exception ex)
            {
                Response.Write("<script>alert('"+ex.Message.ToString()+"');</script>");
            }
        }

        protected void TxtEmail_TextChanged(object sender, EventArgs e)
        {

        }
    }
}