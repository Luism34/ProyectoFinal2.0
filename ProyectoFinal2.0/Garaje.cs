using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ProyectoFinal2._0
{
    public class Garaje:Propiedades
    {
        private string abierta;
        private string bodega;

        public string Abierta
        {
            get
            {
                return abierta;
            }

            set
            {
                abierta = value;
            }
        }

        public string Bodega
        {
            get
            {
                return bodega;
            }

            set
            {
                bodega = value;
            }
        }
    }
}