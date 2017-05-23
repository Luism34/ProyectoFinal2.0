using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ProyectoFinal2._0
{
    public class Propiedades
    {
        private string tipodpropiedad;
        private string codigodpropiedad;
        private int metroscuadrados;
        private string codigopropietario;
        private List <string> listadegastos;


        public string Tipodpropiedad
        {
            get
            {
                return tipodpropiedad;
            }

            set
            {
                tipodpropiedad = value;
            }
        }
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

        public int Metroscuadrados
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

        public List <string> Listadegastos
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