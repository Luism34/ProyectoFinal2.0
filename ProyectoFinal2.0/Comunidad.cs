﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ProyectoFinal2._0
{
    public class Comunidad
    {
        private string identificacion;
        private string nombre;
        private string poblacion;

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

        public string Poblacion
        {
            get
            {
                return poblacion;
            }

            set
            {
                poblacion = value;
            }
        }
    }
}