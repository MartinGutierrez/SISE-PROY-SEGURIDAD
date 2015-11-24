using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SISE.Entidad
{
    public class Perfiles
    {
        public int PERFIL_ID { set; get; }                   //PERFIL_ID INT,
        public string PERFIL_DESCRIPCION { set; get; }       //PERFIL_DESCRIPCION VARCHAR(100),
        public string PERFIL_P_RANGO_HORARIO { set; get; }   //PERFIL_P_RANGO_HORARIO CHAR(1),
        public string PERFIL_P_VIGENCIA { set; get; }        //PERFIL_P_VIGENCIA VARCHAR(10),
        public string PERFIL_P_RANGO_DIAS { set; get; }      //PERFIL_P_RANGO_DIAS CHAR(7),
        public string PERFIL_ESTADO { set; get; }            //PERFIL_ESTADO CHAR(1)
    }
}
