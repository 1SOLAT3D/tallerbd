using System;
using System.Data;
using MySql.Data.MySqlClient;

namespace RegisComida
{
    public class BaseDato
    {
        public MySqlConnection con;
        //static DataTable dt;
        public MySqlCommand cmd;
        public MySqlDataReader dr;
        string server = "localhost";
        string database = "JsRegis_Comida";
        string user = "root";
        string password = "";
        public bool Estado = false;
        public BaseDato()
        {
            con = new MySqlConnection($"Server={server}; Database={database}; User={user}; Password={password}");
        }
        public void Conectar()
        {
            //Cadena de conexion
            if (!Estado)
            {
                try
                {

                    con.Open();
                    Estado = true;
                }
                catch (Exception ex)
                {
                    throw new Exception("" + ex);
                }
            }
            
        }
        public void Desconectar()
        {
            if(Estado)
            {
                con.Close();
                Estado = false;
            }
            
        }
        public void ConsultarComando(String consulta)
        {
            cmd = new MySqlCommand(consulta, con);
        }
        public MySqlCommand ConsultarComando(String consulta,String NoValor)
        {
            return new MySqlCommand(consulta, con);
        }
        public void Insertar(string sql)
        {
            try
            {
                
                Conectar();
                MySqlCommand comando = new MySqlCommand(sql, con);
                comando.ExecuteNonQuery();

            }
            catch (MySqlException myex)
            {
                throw new Exception("Error MySql" + myex);
            }
            catch (Exception ex)
            {
                throw new Exception("" + ex);
            }
            finally
            {
                if(Estado)
                {
                    Desconectar();
                }
            }
        }
        public void InsertarDos(string sql)
        {
            try
            {
                MySqlCommand comando = new MySqlCommand(sql, con);
                comando.ExecuteNonQuery();

            }
            catch (MySqlException myex)
            {
                throw new Exception("Error MySql" + myex);
            }
            catch (Exception ex)
            {
                throw new Exception("" + ex);
            }
            
        }
        public void AsignarParametro(String param, MySqlDbType tipo, Object valor) 
        {
            cmd.Parameters.Add(param, tipo).Value = valor;
        }
        public bool ComprobarBaseDato()
        {
            try
            {
                Conectar();
                MySqlCommand comando = new MySqlCommand("SELECT * FROM Perfil", con);
                comando.ExecuteNonQuery();
                Desconectar();
                return true;
            }
            catch (Exception)
            {
                return false;
            }
            finally
            {
                Desconectar();
            }
        }
        public void CambiarDatabase(string strserver, string strbasedato, string strUsuario, string strContraseña)
        {
            server = strserver;
            database = strbasedato;
            user = strUsuario;
            password = strContraseña;
            con = new MySqlConnection($"Server={server}; Database={database};User={user}; Password={password}");
        }
    }
}
