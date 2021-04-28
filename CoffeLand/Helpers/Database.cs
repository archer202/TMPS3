using System.IO;
using System.Text.Json;
using System.Collections.Generic;
using CoffeLand.Models;

namespace CoffeLand.Helpers
{
    public class Database
    {
        /// <summary>
        /// O pseudo baza de date construita dupa Sablonul de proiectare Singelton
        /// Ce are la baza salvarea si incarcarea datelor dintr-un fisier a datelor
        /// prin intermediul serializarii si deserializare a acestora in format JSON
        /// </summary>
        private Database() { } //Constructor privat pentru a impiedica crearea mai multor instante

        private static Database _instance = null;
        private static readonly object _lock = new object();
        private static readonly string dbPath = @"database.txt";

        public List<Drink> DrinkContext { get; set; }

        //Metoda care returneaza o instanta deja existenta sau creaza una noua daca nu exista nici una
        public static Database GetInstance()
        {
            if (_instance == null)
            {
                lock (_lock) //lock pentru a impiedica crearea de mai multe instante in programarea multi Threading
                {
                    if (_instance == null)
                    {
                        if (!File.Exists(dbPath))
                        {
                            using (var newFile = File.Create(dbPath)) { }
                            _instance = new Database
                            {
                                DrinkContext = new List<Drink>()
                            };
                        }
                        else
                        {
                            _instance = new Database
                            {
                                DrinkContext = new List<Drink>()
                            };
                            if (new FileInfo("database.txt").Length != 0)
                            {
                                var jsonString = File.ReadAllText(dbPath);
                                _instance.DrinkContext = JsonSerializer.Deserialize<List<Drink>>(jsonString);
                            }
                        }
                    }
                }
            }
            return _instance;
        }

        public void SaveData()
        {
            var jsonString = JsonSerializer.Serialize(DrinkContext);
            File.WriteAllText(dbPath, jsonString);
        }
    }
}
