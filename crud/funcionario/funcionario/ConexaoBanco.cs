using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace funcionario
{
    static class ConexaoBanco
    {
       private const string servidor = "localhost";
       private const string bancoDados = "dbFuncionarios";
       private const string usuario = "root";
       private const string password = "161226bhM.";

        static public string conexaoServer = $"server={servidor}; user id={usuario}; database={bancoDados}; password={password}";

        //Nome.Text = $"A conexão com o {bancoDados} foi realizada com sucesso";
    }
}
