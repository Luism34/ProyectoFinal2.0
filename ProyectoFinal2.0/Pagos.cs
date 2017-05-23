using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ProyectoFinal2._0
{
    public class Pagos
    {
        private string idgastos;
        private string descripcion;
        private string importe;
        private string tipodzonadreparto;

        public string Idgastos
        {
            get
            {
                return idgastos;
            }

            set
            {
                idgastos = value;
            }
        }

        public string Descripcion
        {
            get
            {
                return descripcion;
            }

            set
            {
                descripcion = value;
            }
        }

        public string Importe
        {
            get
            {
                return importe;
            }

            set
            {
                importe = value;
            }
        }

        public string Tipodzonadreparto
        {
            get
            {
                return tipodzonadreparto;
            }

            set
            {
                tipodzonadreparto = value;
            }
        }
    }
}