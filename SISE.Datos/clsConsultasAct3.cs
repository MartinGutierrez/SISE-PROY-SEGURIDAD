using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
using SISE.Entidad;

namespace SISE.Datos
{
    class clsConsultasAct3
    {
        private SqlConnection cn = new SqlConnection("server=(local);initial catalog=PROY_SISE_SEGURIDAD;Integrated Security=True");
        public bool Conectar()
        {
            try
            {
                cn.Open();
                return true;
            }
            catch (Exception ex)
            {
                cn.Close();
                return false;
            }
        }
        public void Desconectar()
        {
            cn.Close();
        }

        public List<Aplicacion> ObtenerAplicaciones()
        {
            List<Aplicacion> app = new List<Aplicacion>();

            return app;
        }
        
    }
}
