using System.Data.SqlClient;
using System.Xml;


namespace INPI.Data
{
    public class SqlHelper
    {
        private SqlConnection? sqlConnection;

        public static SqlConnection Execulte()
        {
            string connectionString = "Server=tcp:guilhermelino.database.windows.net,1433;Initial Catalog=InipIntegration;Persist Security Info=False;User ID=guilhermelinosp;Password=!@#Newpoint0@;MultipleActiveResultSets=False;Encrypt=True;TrustServerCertificate=False;Connection Timeout=30;";

            sqlConnection = new SqlConnection(connectionString);

            sqlConnection.Open();

            Console.WriteLine(DateTime.Now + " - Conectado ao Azure Database");

            Insert(connectionString);

            return sqlConnection;
        }

        public static void Insert(string? connectionString)
        {
            string pathDownload = @"C:\developer\INPI Integrator\INPI\Storage\";

            foreach (string file in Directory.GetFiles(pathDownload))
            {
                try
                {


                    Console.WriteLine(file);

                    XmlDocument xmlDocument = new();

                    xmlDocument.Load(file);


                }
                catch (Exception error)
                {
                    Console.WriteLine($"{DateTime.Now} - Não foram encontrado arquivos xml: {error.Message}");
                }
            }


        }

    }

}