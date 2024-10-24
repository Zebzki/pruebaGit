using appAdsoM.datos;
using appAdsoM.entidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace appAdsoM.logica
{
    public class ClUsuarioL
    {

        public bool mtdIngresar(string user, string pass)
        {
            ClUsuarioD objusuarioD = new ClUsuarioD();
             bool resul = objusuarioD.mtdIngresar(user, pass);
            return resul;

        }
        public ClUsuarioE mtdIngreso(ClUsuarioE objDatos)
        {
            ClUsuarioD objusuarioD = new ClUsuarioD();
            ClUsuarioE oDatos = objusuarioD.mtdIngreso(objDatos);
            return oDatos;
        }
        public ClUsuarioE mtdIngresoStorageProcedure(ClUsuarioE objDatos)
        {
            ClUsuarioD objusuarioD = new ClUsuarioD();
            ClUsuarioE oDatos = objusuarioD.mtdIngresoSP(objDatos);
            return oDatos;
        }

    }
}
