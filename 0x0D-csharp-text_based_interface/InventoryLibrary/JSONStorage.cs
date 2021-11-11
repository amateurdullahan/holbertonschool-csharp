using System;
using System.Collections;
using System.Collections.Generic;
using System.Text.Json;
using System.IO;

namespace InventoryLibrary
{
    public class JSONStorage
    {
        public Dictionary<string, Object> objects = new Dictionary<string, Object>();
        public string mode = "normal";

        public JSONStorage()
        {
            //this.Load();
        }


        public Dictionary<string, Object> All()
        {
            return objects;
        }

        public void New(Object obj)
        {
            Type ClassName = obj.GetType();
            string id = ClassName.GetProperty("id").GetValue(obj).ToString();

            string key = $"{ClassName.Name}.{id}";

            if (objects == null)
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("No objects");
                Console.ResetColor();
            }
            this.objects.Add(key, obj);
            this.Save();

            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine($"Created {key.ToString()}");
            Console.ResetColor();
        }

        public void Save()
        {
            string json = JsonSerializer.Serialize(objects);
            string fileName = "storage/inventory_manager.json";
            if (mode == "test")
                fileName = "../../../../storage/inventory_manager.json";             
            File.WriteAllText(fileName, json);
        }


        public void Load()
        {
            string fileName = "storage/inventory_manager.json";
            if (mode == "test")
                fileName = "../../../../storage/inventory_manager.json"; 
            string jsonString = File.ReadAllText(fileName);
            objects = JsonSerializer.Deserialize<Dictionary<string, Object>>(jsonString);
        }
    }
}
