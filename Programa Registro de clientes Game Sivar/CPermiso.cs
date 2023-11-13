using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
using MySql.Data.MySqlClient;

namespace Programa_Registro_de_clientes_Game_Sivar
{
    class CPermiso
    {   //Serviria para mostrar determinados menus por usuario
        //public List<Permiso> Listar(int idusuario)
        //{

        //    List<Permiso> lista = new List<Permiso>();

        //    using (MySqlConnection oconexion = new MySqlConnection(CConexion.CadenaConexion))
        //    {
        //        try
        //        {
        //            StringBuilder query = new StringBuilder();
        //            query.AppendLine("select p.idrol, p.nombremenu from permisos p");
        //            query.AppendLine("inner join roles r on r.idrol = p.idrol");
        //            query.AppendLine("inner join usuarios_sistema u on u.idrol = r.idrol");
        //            query.AppendLine("where u.idusuarios = @idusuario");

        //            using (MySqlCommand cmd = new MySqlCommand(query.ToString(), oconexion))
        //            {
        //                cmd.Parameters.AddWithValue("@idusuario", idusuario);
        //                cmd.CommandType = CommandType.Text;

        //                oconexion.Open();

        //                using (MySqlDataReader dr = cmd.ExecuteReader())
        //                {
        //                    while (dr.Read())
        //                    {
        //                        lista.Add(new Permiso()
        //                        {
        //                            oRol = new Rol() { idrol = dr.GetInt32(dr.GetOrdinal("idrol")) },
        //                            NombreMenu = dr["nombremenu"].ToString(),
        //                        });
        //                    }
        //                }
        //            }
        //        }
        //        catch (Exception ex)
        //        {
                 
        //        }
        //    }

        //    return lista;
        //}

    }

    
}
