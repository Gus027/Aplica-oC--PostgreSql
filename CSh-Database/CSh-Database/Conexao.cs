using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSh_Database
{
    internal class Conexao
    {
        static private String servidor = "localhost";
        static private String bd = "Dados";
        static private String user = "postgres";
        static private String pass = "123456";
        static private String port = "5432";


       // static public String Conn = "server=" + servidor + ";user=" + user + ";bd=" + bd + ";pass=" + pass;

        static public String Conn = $"server={servidor};User Id={user};port={port};database={bd};password={pass}";
    }
}
