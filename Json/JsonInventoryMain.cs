using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Json
{
    internal class JsonInventoryMain
    {
        public void DisplayInventory(string filePath)
        {
            using (StreamReader reader = new StreamReader(filePath))
            {
                var json = reader.ReadToEnd();
                var inventory = JsonConvert.DeserializeObject<List<InventoryModel>>(json);
                Console.WriteLine("Name" + "\t" + "Weight" + "\t" + "PricePerKg" + "\t" + "TotalPrice");
                foreach (var data in inventory)
                {
                    Console.WriteLine(data.Name + "\t" + data.Weight + "\t" + data.Price + "\t\t" + (data.Weight * data.Price));
                }
            }
        }
    }
}
