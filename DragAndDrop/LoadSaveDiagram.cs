using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;

namespace DragAndDrop
{
    public  class LoadSaveDiagram
    {
        public static void Save(List<Box> boxes, string filePath)
        {
            string json = JsonSerializer.Serialize(boxes);
            File.WriteAllText(filePath, json);
        }

        public static List<Box> Load(string filePath)
        {
            string json = File.ReadAllText(filePath);
            var boxes = JsonSerializer.Deserialize<List<Box>>(json);
            return boxes ?? new List<Box>();
            
        }
    }
}
