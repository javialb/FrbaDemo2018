using System;

namespace Models.Comun
{
    public class Seguridad
    {
        public bool verificarPassword(string pass,string hashPass) {
            try
            {
               return(HashHelpers.SHA256(pass) == hashPass?true:false); 
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
    }
}
