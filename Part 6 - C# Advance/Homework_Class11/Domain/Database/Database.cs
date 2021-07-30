using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.IO;
using System.Text;

namespace Domain.Database
{
    public class Database
    {
        private string _folderPath;
        private string _filePath;
        private int _id;

        public Database()
        {
            _id = 0;
            _folderPath = @"..\..\..\Db";
            _filePath = _folderPath + @$"\Dog.json";
            if (!Directory.Exists(_folderPath))
            {
                Directory.CreateDirectory(_folderPath);
            }
            if (!File.Exists(_filePath))
            {
                File.Create(_filePath).Close();
                WriteData(new List<Dog>());
            }
        }


        public List<Dog> GetAll()
        {
            return GetAllEntitiesFromDb();
        }

        private void WriteData(List<Dog> dbEntities)
        {
            using (StreamWriter streamWriter = new StreamWriter(_filePath))
            {
                streamWriter.WriteLine(JsonConvert.SerializeObject(dbEntities));
            }
        }

        public int Insert(Dog dog)
        {
            List<Dog> dbEntities = GetAllEntitiesFromDb();
            if (dbEntities == null)
            {
                dbEntities = new List<Dog>();
                _id = 1;
            }
            else
            {
                _id = dbEntities.Count + 1;
            }
            dog.Id = _id;
            dbEntities.Add(dog);
            WriteData(dbEntities);
            return dog.Id;
        }


        private List<Dog> GetAllEntitiesFromDb()
        {
            using (StreamReader streamReader = new StreamReader(_filePath))
            {
                return JsonConvert.DeserializeObject<List<Dog>>(streamReader.ReadToEnd());
            }
        }
    }
}
