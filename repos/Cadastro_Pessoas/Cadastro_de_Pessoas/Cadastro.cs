using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Security.Cryptography;
using System.Data.SqlClient;

namespace Cadastro_de_Pessoas
{
    public class Cadastro
    {
        Conexão conexão = new Conexão();
        SqlCommand cmd = new SqlCommand();
        public string mensagem = "";

        public class Cadastro (string nome, string cpf, string Data)
        {
            // Comandos SQL ( insert, update , delete e etc) -- SqlCommand
            cmd.CommandText = "insert into Pessoas (nome, cpf ,dataDeNascimento) values (@nome,@cpf,@dataDeNascimento)";
            
            //Parametros ( para trocar os valores)
            cmd.Parameters.AddWithValue("");
            cmd.Parameters.AddWithValue("");
            cmd.Parameters.addWithValue("");

            try 
	        {	        
                cmd.Connection = conexão.Conectar();
		
	            }
	        catch (global::System.Exception)
	        {

		    throw;
	        }
	    }
    }
}

            
 
    