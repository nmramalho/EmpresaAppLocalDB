using System.Configuration;

namespace EmpresaApp
{
    internal class Utility
    {

        //obter a string de ligação a partir do ficheiro de configuração da Aplicação.  
        internal static string GetConnectionString()
        {  
            string strConnectionString = null;

            // Localizar o nome da definição da string de ligação (connectionStrings).  
            ConnectionStringSettings settings =
            ConfigurationManager.ConnectionStrings["EmpresaApp.Properties.Settings.connString"];
 
            //Caso tenha encontrado devolve a string de ligação.  
            if (settings != null)
                strConnectionString = settings.ConnectionString;

            return strConnectionString;
        }
    }
}
