using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ProyectoFinal2._0
{
    public class Local:Propiedades
    {
        private string nombrecomercial;
        private string actividad;

        public string Nombrecomercial
        {
            get
            {
                return nombrecomercial;
            }

            set
            {
                nombrecomercial = value;
            }
        }

        public string Actividad
        {
            get
            {
                return actividad;
            }

            set
            {
                actividad = value;
            }
        }
    }
}