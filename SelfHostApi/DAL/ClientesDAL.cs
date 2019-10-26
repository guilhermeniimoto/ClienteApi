using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;
using ClienteHostApi.Model;
using System.Configuration;

namespace ClienteHostApi.DAL
{
    public class ClientesDAL
    {
        //private string connectionString = "server=mysql333745.mysql.database.azure.com;User Id = fiap@mysql333745;database=fiap; password=senha@123";
        private string connectionString  = ConfigurationManager.ConnectionStrings["connString"].ConnectionString;

        public List<Cliente> retornaClientes() 
        {
            MySqlConnection conn = new MySqlConnection(connectionString);
            MySqlCommand comando = new MySqlCommand("SELECT * FROM `clientes`.`clientes`", conn);
            List<Cliente> lista = new List<Cliente>();

            try
            {
                conn.Open();
                MySqlDataReader dr = comando.ExecuteReader();

                if (dr.HasRows) { 
                while (dr.Read())
                {
                        Cliente cliente = new Cliente();

                        cliente.Id = Convert.ToInt32(dr.GetValue(0));
                        cliente.Nome = dr.GetValue(1).ToString();
                        cliente.Idade = Convert.ToInt32(dr.GetValue(2));
                        cliente.Email = dr.GetValue(3).ToString();

                        lista.Add(cliente);
                }
            }
            }
            catch (Exception ex)
            {
                throw ex;
            }
            finally 
            {
                conn.Close();
            }

            return lista;
        }

    }
}


//MySqlCommand comando = new MySqlCommand("SELECT * FROM PRODUTOS");
//DataTable tabela = new DataTable();
//    try
//    {
//        conexao.Open();
//        gdvDados.DataSource = comando.ExecuteReader();
//        gdvDados.DataBind();
//    }
//    finally
//    {
//        conexao.Close();
//    }