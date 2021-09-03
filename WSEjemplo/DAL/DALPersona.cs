using Model;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public class DALPersona
    {
        public static Persona ObtenerPersona(int id)
        {
            Persona persona = new Persona();
            string connection = @"Data Source=DESKTOP-0TQFLI4\SQLEXPRESS;Initial Catalog=ws;Integrated Security=True";
            string query = "select * from Persona where IdPersona=@id";
            using (var con = new SqlConnection(connection))
            {
                con.Open();
                SqlCommand command = new SqlCommand(query, con);
                command.CommandType = System.Data.CommandType.Text;
                command.Parameters.AddWithValue("@id", id);
                using (var dr = command.ExecuteReader())
                {
                    while(dr.Read())
                    {
                        persona.IdPersona = Convert.ToInt32(dr["IdPersona"]);
                        persona.Nombre = dr["Nombre"].ToString();
                        persona.Apellido = dr["Apellido"].ToString();
                        persona.Documento = dr["Documento"].ToString();
                        persona.IdTipoDocumento = Convert.ToInt32(dr["IdTipoDocumento"]);
                        persona.FechaNacimiento = Convert.ToDateTime(dr["FechaNacimiento"]);
                    }
                }
            }
            return persona;
        }
    }
}
