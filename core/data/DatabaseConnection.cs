using core.models;
using SQLite;
using System;
using System.Collections.Generic;
using System.IO;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace core.data
{
    internal class DatabaseConnection
    {

        private static SQLiteAsyncConnection connection;

        private static void initialize()
        {

            // NOTE jfp The database is copied from the assembly to the mobile device the first time the application starts.
            //          Deleting the file simulates a "first time".

            string filename = "redmoon.db";

            Assembly assembly = IntrospectionExtensions.GetTypeInfo(typeof(DatabaseConnection)).Assembly;
            Stream stream = assembly.GetManifestResourceStream("core." + filename);

            string localFilename = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.LocalApplicationData), filename);

#if DEBUG 
            File.Delete(localFilename);
#endif

            if (!File.Exists(localFilename))
            {
                using (FileStream fileStream = File.Create(localFilename))
                {
                    stream.Seek(0, SeekOrigin.Begin);
                    stream.CopyTo(fileStream);
                }
            }

            connection = new SQLiteAsyncConnection(localFilename);

        }

        internal static Task<List<T>> findAll<T>() where T : new()
        {
            return connection.Table<T>().ToListAsync();
        }

        static DatabaseConnection()
        {
            initialize();
        }
    }
}
