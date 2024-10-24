using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace appAdsoM.entidades
{
    public class ClUsuarioE
    {
        public int idUsuario { get; set; }
        public string documento { get; set; }
        public string nombres { get; set; }
        public string apellidos { get; set; }
        public string email { get; set; }
        public string clave { get; set; }

    }
}