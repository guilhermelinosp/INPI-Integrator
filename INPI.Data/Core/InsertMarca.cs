using System.Xml;

namespace INPI.Data.Core
{
    internal class InsertMarca
    {
        public static void Execute(XmlDocument file, string? connectionString)
        {

            XmlDocument xmlDocument = new();

            xmlDocument.LoadXml(file.InnerXml);







        }
    }
}
