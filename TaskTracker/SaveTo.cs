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
        public static readonly string _path = "..\\..\\..\\JsonFiles\\Tasks.json";
        public static void JsonFile(List<Task> data)
        {
            Directory.CreateDirectory("..\\..\\..\\JsonFiles");

            string json = JsonSerializer.Serialize(data);
            File.WriteAllText(_path, json);
        }
    }
}
