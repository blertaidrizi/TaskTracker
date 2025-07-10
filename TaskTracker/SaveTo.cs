using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;

namespace TaskTracker
{
    public static class SaveTo
    {
        //The path string where we store the path to the Json file
        public static readonly string _path = "..\\..\\..\\JsonFiles\\Tasks.json";

        //Method for storing the data to the Json file
        public static void JsonFile(List<Task> data)
        {
            //Making sure that the folder exists, if not it will be created
            Directory.CreateDirectory("..\\..\\..\\JsonFiles");

            //Convert the data into json data
            string json = JsonSerializer.Serialize(data);
            //Store it in the Json File
            File.WriteAllText(_path, json);
        }
    }
}
