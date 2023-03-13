using INPI.Data;

namespace INPI
{
    internal class Program
    {
        public static void Main()
        {
            SqlHelper sqlHelper = new();
            _ = sqlHelper.Execulte();


        }
    }
}
