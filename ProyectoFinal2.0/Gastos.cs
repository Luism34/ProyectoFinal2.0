using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ProyectoFinal2._0
{
    public class Gastos
    {
        private string identificacion;
        private string nombre;
        private string tipodereparto;

        public string Identificacion
        {
            get
            {
                return identificacion;
            }

            set
            {
                identificacion = value;
            }
        }

        public string Nombre
        {
            get
            {
                return nombre;
            }

            set
            {
                nombre = value;
            }
        }

        public string Tipodereparto
        {
            get
            {
                return tipodereparto;
            }

            set
            {
                tipodereparto = value;
            }
        }
    }
}