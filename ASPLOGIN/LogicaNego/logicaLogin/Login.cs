using System;
using DatosAcceso;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LogicaNego.logicaLogin
{
    public class Login
    {
        private static DBloginDataContext db = new DBloginDataContext();

        public static TBL_USUARIO getUserLogin(string Email, string password)
        {
            try
            {

                var datosuser = db.TBL_USUARIO.FirstOrDefault(data => data.USU_STATUS == "A"
                                                          && data.USU_EMAIL.Equals(Email)
                                                          && data.USU_PASSWORD.Equals(password));
            return datosuser;
            }
            catch (Exception )
            {
                throw new ArgumentException("Error en la coneccion"); 
            }
        }
        
    }
}
