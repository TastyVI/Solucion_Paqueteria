﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Paqueteria.DLL
{
    class registrarse
    {
        string id, nombre_completo, tipo_usuario, usuario, contrasena;
        public string Id { get => id; set => id = value; }
        public string Nombre_Completo {  get => nombre_completo;set=> nombre_completo = value;}
        public string Tipo_Usuario {  get => tipo_usuario;set => tipo_usuario = value;}
        public string Usuario {  get => usuario;set=> usuario = value;}
        public string Contrasena {  get => contrasena;set => contrasena = value;}
    }
}
