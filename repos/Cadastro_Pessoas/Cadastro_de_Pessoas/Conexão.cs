using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient; // Biblioteca para manipulação de banco de dados
using System.CodeDom;

namespace Cadastro_de_Pessoas
{
    public class Conexão
    {
        SqlConnection con = new SqlConnection();
        // Método construtor 
        public Conexão() 
        {
            con.ConnectionString = "Data Source=(LocalDB)\\MSSQLLocalDB;AttachDbFilename=\"C:\\Users\\pc 1\\Documents\\Cadastro_de_Pessoas.mdf\";Integrated Security=True;Connect Timeout=30";//Aqui vai a cadeia de conexão do seu banco de dados.
        }

        // Metodo para Conectar com o Banco de dados
        public SqlConnection conectar()
        {
            /*
             * Se o estado do Objeto con (conexão com o banco), for Closed (fechado),
             * o Método conectar vai abrir e alterar o estado dele para Open (aberto).
             */
            if (con.State == System.Data.ConnectionState.Closed) 
            {
                con.Open();
            }
            return con;
        }

        //Método para Desconectar o Banco de dados

        public void desconectar() 
        {
            /*
             * Se o estado do Objeto con for Open, o Método Desconectar vai fechá-lo.
             */
            if (con.State == System.Data.ConnectionState.Open)
            {
                con.Close();
            }
        }
    }
}
