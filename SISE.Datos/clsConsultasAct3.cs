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
    public class clsConsultasAct3
    {
        private SqlConnection cn = new SqlConnection("server=(local);initial catalog=PROY_SISE_SEGURIDAD;Integrated Security=True");

        public List<Aplicacion> ObtenerAplicaciones()
        {
            List<Aplicacion> lstAplicacion = new List<Aplicacion>();
            using (SqlCommand cmd = new SqlCommand())
            {
                cmd.CommandText = "SP_LISTAR_APLICACION";
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Connection = cn;
                cn.Open();
                
                using(SqlDataReader dr = cmd.ExecuteReader()){
                    if(dr.HasRows){
                        int col01 = dr.GetOrdinal("APLICACION_ID");
                        int col02 = dr.GetOrdinal("APLICACION_NOMBRE");
                        int col03 = dr.GetOrdinal("APLICACION_DESCRIPCION");
                        int col04 = dr.GetOrdinal("APLICACION_PATH");
                        int col05 = dr.GetOrdinal("APLICACION_ESTADO");
                        object[] item = new object[dr.FieldCount];
                        Aplicacion apli = null;
                        while (dr.Read())
                        {
                            dr.GetValues(item);
                            apli = new Aplicacion();
                            apli.APLICACION_ID = Convert.ToString(item[col01]);
                            apli.APLICACION_NOMBRE = Convert.ToString(item[col02]);
                            apli.APLICACION_DESCRIPCION = Convert.ToString(item[col03]);
                            apli.APLICACION_PATH = Convert.ToString(item[col04]);
                            apli.APLICACION_ESTADO = Convert.ToString(item[col05]);
                            lstAplicacion.Add(apli);
                        }
                    }
                }
            }
            return lstAplicacion;
        }

        public List<Perfiles> ObtenerPerfiles()
        {
            List<Perfiles> lstPerfiles = new List<Perfiles>();
            using (SqlCommand cmd = new SqlCommand())
            {
                cmd.CommandText = "";
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Connection = cn;
                cn.Open();

                using (SqlDataReader dr = cmd.ExecuteReader())
                {
                    if (dr.HasRows)
                    {
                        int col01 = dr.GetOrdinal("PERFIL_ID");
                        int col02 = dr.GetOrdinal("PERFIL_DESCRIPCION");
                        int col03 = dr.GetOrdinal("PERFIL_P_RANGO_HORARIO");
                        int col04 = dr.GetOrdinal("PERFIL_P_VIGENCIA");
                        int col05 = dr.GetOrdinal("PERFIL_P_RANGO_DIAS");
                        int col06 = dr.GetOrdinal("PERFIL_ESTADO");
                        object[] item = new object[dr.FieldCount];
                        Perfiles prf = null;
                        while (dr.Read())
                        {
                            dr.GetValues(item);
                            prf = new Perfiles();
                            prf.PERFIL_ID = Convert.ToInt16(item[col01]);
                            prf.PERFIL_DESCRIPCION = Convert.ToString(item[col02]);
                            prf.PERFIL_P_RANGO_HORARIO = Convert.ToString(item[col03]);
                            prf.PERFIL_P_VIGENCIA = Convert.ToString(item[col04]);
                            prf.PERFIL_P_RANGO_DIAS = Convert.ToString(item[col05]);
                            prf.PERFIL_ESTADO = Convert.ToString(item[col06]);
                            lstPerfiles.Add(prf);
                        }
                    }
                }
            }
            return lstPerfiles;
        }
        
    }
}
