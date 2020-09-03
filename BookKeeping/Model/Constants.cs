using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using SQLite;
using Xamarin.Essentials;

namespace BookKeeping.Model
{
    public class Constants
    {
        public const string DatabaseFilename = "BookKeeping.db";
        SQLiteConnection conn;

        public Constants()
        {
            string dbPath = System.IO.Path.Combine(FileSystem.AppDataDirectory, DatabaseFilename);
            
            conn = new SQLiteConnection(dbPath);
            conn.CreateTable<ObjectClass>();

            List<ObjectClass> CheckList = new List<ObjectClass>();
            CheckList = conn.Table<ObjectClass>().ToList();

            if(CheckList.ToLookup(m => m.Year == DateTime.Now.Year).Count == 0)
            {
                for (int index = 0; index < 12; index++)
                {
                    ObjectClass objectClass = new ObjectClass()
                    {
                        Year = DateTime.Now.Year,
                        Month = index + 1,
                        Spend0 = 0,
                        Spend1 = 0,
                        Spend2 = 0,
                        Spend3 = 0,
                        Spend4 = 0,
                        Spend5 = 0,
                        Target0 = 12000,
                        Target1 = 18000,
                        Target2 = 10000,
                        Target3 = 17000,
                        Target4 = 0,
                    };

                    conn.Insert(objectClass);
                }
            }
        }

        public static string DatabasePath
        {
            get
            {
                var basePath = Environment.GetFolderPath(Environment.SpecialFolder.LocalApplicationData);
                return Path.Combine(basePath, DatabaseFilename);
            }
        }

        public List<ObjectClass> GetItemsAsync()
        {
            return conn.Table<ObjectClass>().ToList();
        }

        public ObjectClass GetItemAsync(int Year, int Month)
        {
            return conn.Table<ObjectClass>().Where(i => (i.Year == Year && i.Month == Month)).FirstOrDefault();
        }

        public void SaveItemAsync(ObjectClass objectClass)
        {
            if (objectClass.Year != 0 && objectClass.Month != 0)
            {
                conn.Update(objectClass);
            }
            else
            {
                conn.Insert(objectClass);
            }
        }

        public void DeleteItemAsync(ObjectClass objectClass)
        {
            conn.Delete(objectClass);
        }
    }
}
