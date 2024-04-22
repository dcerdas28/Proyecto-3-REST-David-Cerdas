﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Proyecto_3_REST_David_Cerdas.CSD
{
    public class Usuario
    {

        public string gender { get; set; }
        public Nombre name { get; set; }
        public Localizacion location { get; set; }
        public string email { get; set; }
        public Acceso login { get; set; }
        public FechaNacim dob { get; set; } //dob (Date of Birth)
        public Registro registered { get; set; }
        public string phone { get; set; }
        public string cell { get; set; }
        public Identificacion id { get; set; }
        public Fotografia picture { get; set; }
        public string nat { get; set; } //Nacionalidad 


    }//class
}//space