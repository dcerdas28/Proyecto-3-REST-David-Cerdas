using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Proyecto_3_REST_David_Cerdas.CSD
{
    public class Acceso
    {
        public string uuid { get; set; } //UUID Identificador Único Universalmente Único  (Universally Unique Identifier)
        public string username { get; set; }
        public string password { get; set; }
        public string salt { get; set; } // "salt" se refiere a una cadena aleatoria de caracteres que se agrega a una contraseña antes de que sea almacenada o procesada por un sistema de autenticación//
        public string md5 { get; set; }            
        public string sha1 { get; set; }
        public string sha256 { get; set; }

        /*MD5, SHA1, SHA256: Algoritmos de hash criptográficos que se utilizan para convertir datos en una cadena de longitud fija,
         * conocida como hash, con el propósito de verificar la integridad de los datos y garantizar la seguridad en diversos sistemas
         * y aplicaciones.*/

    }//class
}//space