using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace LogicaNego.logicaLogin
{
    public class Encriptacion
    {
    

        public string sha1encriptacion(string password)
        {

            SHA1 sHA1 = SHA1Managed.Create();
            ASCIIEncoding encoding = new ASCIIEncoding();
            byte[] stream = null;
            StringBuilder sbu = new StringBuilder();
            stream = sHA1.ComputeHash(encoding.GetBytes(password));
            for (int i = 0; i < stream.Length; i++) 
            {
                sbu.AppendFormat("{0:x2}", stream[i]);
            }
            return sbu.ToString();  
            
        }
    }
}
