using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ProyectoFinal2._0
{
    public class Piso : Propiedades
    {
        private string vhvn;
       
        private string numerodormitorios;

        public string Numerodormitorios
        {
            get
            {
                return numerodormitorios;
            }

            set
            {
                numerodormitorios = value;
            }
        }

        public string Vhvn
        {
            get
            {
                return vhvn;
            }

            set
            {
                vhvn = value;
            }
        }
    }
}