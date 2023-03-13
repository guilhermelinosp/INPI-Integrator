using System.IO.Compression;

namespace INPI.Core
{
    public static class BotZip
    {
        private const string StoragePath = @"C:\developer\INPI Integrator\INPI\Storage\";

        public static void Execute()
        {
            foreach (string file in Directory.GetFiles(StoragePath, "*.zip"))
            {
                try
                {
                    string fileName = Path.GetFileName(file);

                    string extractPath = Path.Combine(StoragePath, System.IO.Path.GetFileNameWithoutExtension(fileName));

                    using (ZipArchive zip = ZipFile.OpenRead(file))
                    {
                        zip.ExtractToDirectory(extractPath);
                    }

                    File.Delete(file);
                }
                catch (Exception error)
                {
                    Console.WriteLine($"Error extracting file: {error.Message}");
                }
            }


            foreach (string subdirectory in Directory.GetDirectories(StoragePath))
            {
                string newPathStorage = StoragePath + Path.GetFileName(subdirectory);

                foreach (string file in Directory.GetFiles(newPathStorage, "*.xml"))
                {
                    string fileName = Path.GetFileName(file);

                    if (fileName.Contains("Patente"))
                    {
                        string newFileName = fileName.Replace(fileName, "Patente" + BotDownload.NumberFile + ".xml");

                        File.Move(file, StoragePath + newFileName);

                        Directory.Delete(newPathStorage, true);
                    }
                    else
                    {
                        string newFileName = fileName.Replace(fileName, "Marca" + BotDownload.NumberFile + ".xml");

                        File.Move(file, StoragePath + newFileName);

                        Directory.Delete(newPathStorage, true);
                    }
                }
            }
        }


    }
}
