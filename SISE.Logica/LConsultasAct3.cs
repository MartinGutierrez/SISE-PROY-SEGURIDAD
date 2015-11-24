using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SISE.Datos;
using SISE.Entidad;

namespace SISE.Logica
{
    class LConsultasAct3
    {
        // --------------- OPERACIONES PARA LA ACTIVIDAD NUMERO 3 ---------------------
        clsConsultasAct3 cls = new clsConsultasAct3();
        public List<Aplicacion> getAplicaciones() {
            return cls.ObtenerAplicaciones();
        }
        public List<Perfiles> getPerfiles()
        {
            return cls.ObtenerPerfiles();
        }
        // --------------- FIN DE OPERACIONES PARA LA ACTIVIDAD NUMERO 3 -----------------


    
    }
}
