﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Util
{
    public class Configuracion
    {

        public enum Database {
            SQLite,
            Texto
        }


        public static Int32 tiempoSesion = 30;
        public static Database baseDatos = Database.SQLite;
        public static String baseDatosNombre = "Tareas";
    }
}
