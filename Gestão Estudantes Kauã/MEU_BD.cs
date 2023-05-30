using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;

namespace Gestão_Estudantes_Kauã
{
    // A classe do nosso banco de dados.
    internal class MEU_BD
    {
        private MySqlConnection conexao = new MySqlConnection("datasource=localhost; username=root; password=;database=sga_estudantes_bd_t4");
    }
}
