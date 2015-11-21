using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SISE.Entidad
{
    public class Aplicacion
    {
        public string APLICACION_ID { get; set; }            //APLICACION_ID CHAR(6),
        public string APLICACION_NOMBRE { get; set; }        //APLICACION_NOMBRE VARCHAR(50),
        public string APLICACION_DESCRIPCION { get; set; }   //APLICACION_DESCRIPCION VARCHAR(100),
        public string APLICACION_PATH { get; set; }          //APLICACION_PATH VARCHAR(100),
        public string APLICACION_ESTADO { get; set; }        //APLICACION_ESTADO CHAR(1)
    }
}
