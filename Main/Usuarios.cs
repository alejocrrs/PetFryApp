using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Data;

namespace Main
{
    public static class Usuarios
    {
        public static int BuscarIdPorDocumento(string documento)
        {
            return Convertir.Int(DataUsuarios.SelecIdByDocumento(documento));
        }

        public static int BuscarIdPorDocumentoYClave(string documento, string clave)
        {
            return Convertir.Int(DataUsuarios.SelecIdByDocumentoAndClave(documento, clave));
        }

        public static int BuscarBloqueoPorId(string id)
        {
            return Convertir.Int(DataUsuarios.SelectBloqueoById(id));
        }
    }
}
