using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ProyectoFinal2._0
{
    public class Propiedades
    {
        private string codigodpropiedad;
        private string metroscuadrados;
        private string codigopropietario;
        private string listadegastos;

        public string Codigodpropiedad
        {
            get
            {
                return codigodpropiedad;
            }

            set
            {
                codigodpropiedad = value;
            }
        }

        public string Metroscuadrados
        {
            get
            {
                return metroscuadrados;
            }

            set
            {
                metroscuadrados = value;
            }
        }

        public string Codigopropietario
        {
            get
            {
                return codigopropietario;
            }

            set
            {
                codigopropietario = value;
            }
        }

        public string Listadegastos
        {
            get
            {
                return listadegastos;
            }

            set
            {
                listadegastos = value;
            }
        }
    }
}