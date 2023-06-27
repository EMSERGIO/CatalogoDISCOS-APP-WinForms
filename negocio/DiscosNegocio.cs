using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using dominio;
using System.Data;

namespace negocio
{
    public class DiscosNegocio
    {
        public List<Discos> listar()
        {
            List<Discos> lista = new List<Discos>();
            SqlConnection conexion = new SqlConnection();
            SqlCommand comando = new SqlCommand();
            SqlDataReader lector;

            try
            {
                conexion.ConnectionString = "server=.\\SQLEXPRESS; database=DISCOS_DB; integrated security=true";
                comando.CommandType = System.Data.CommandType.Text;
                comando.CommandText = "select D.Titulo, FechaLanzamiento, UrlImagenTapa, CantidadCanciones, E.Descripcion Estilo, F.Descripcion TipoEdicion from DISCOS D, ESTILOS E, TIPOSEDICION F where  E.Id = D.IdEstilo and F.Id = D.IdTipoEdicion";

                comando.Connection = conexion;

                conexion.Open();
                lector = comando.ExecuteReader();

                while (lector.Read())
                {
                    Discos aux = new Discos();
                    aux.Titulo = (string)lector["Titulo"];
                    aux.FechaLanzamiento = lector.GetDateTime(1);
                    aux.CantidadCanciones = lector.GetInt32(3);

                    if(!(lector["UrlImagenTapa"] is DBNull))
                        aux.UrlImagen = (string)lector["UrlImagenTapa"];

                    aux.Estilo = new Estilo();
                    aux.Estilo.Descripcion = (string)lector["Estilo"];
                    aux.TipoEdicion = new Estilo();
                    aux.TipoEdicion.Descripcion = (String)lector["TipoEdicion"];

                    lista.Add(aux);
                }
                conexion.Close();
                return lista;
            }
            catch (Exception ex) 
            {
                throw ex;
            }

        }
        public void agregar(Discos nuevo)
        {
            AccesoDatos datos = new AccesoDatos();
            try
            {
                datos.setearConsulta("insert into DISCOS (Titulo, CantidadCanciones) values ('"+ nuevo.Titulo +"','"+ nuevo.CantidadCanciones +"')");
                datos.ejecutarAccion();
            }
            catch(Exception ex)
            {
                throw ex;
            }
            finally
            {
                datos.cerrarConexion();
            }
        
        }
        public void modificar(Discos modificar)
        {

        }
    }
}
