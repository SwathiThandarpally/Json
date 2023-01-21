using Json;
namespace Json
{
    class Program
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Displaying Json Inventory Program");

            const string INVENTORY_DATA_PATH = @"C:\Users\sai\source\repos\RFP-244\Json\Json\Json\InventoryModel.cs";
            JsonInventoryMain inventoryData = new JsonInventoryMain();
            Console.WriteLine("Display 1\n");
            bool check = true;
            while (check)
            {
                Console.WriteLine("Choose A number: ");
                int option = Convert.ToInt32(Console.ReadLine());
                switch (option)
                {
                    case 1:
                        inventoryData.DisplayInventory(INVENTORY_DATA_PATH);
                        break;
                    case 2:
                        Console.WriteLine("Enter the Inventory List and Name :");
                        string inventoryName1 = Console.ReadLine();
                        string grain1 = Console.ReadLine();
                        
                        data.Weight = Convert.ToInt32(Console.ReadLine());
                        data.PricePerKg = Convert.ToInt32(Console.ReadLine());
                        manager.AddInventory(data, inventoryName1, INVENTORY_MANAGEMENT_PATH);
                        break;
                    case 3:
                        Console.WriteLine("Enter the Inventory List and Grains :");
                        string inventoryName2 = Console.ReadLine();
                        string grain2 = Console.ReadLine();
                        manager.EditInventory(inventoryName2, grain2, INVENTORY_MANAGEMENT_PATH);
                        break;
                    case 4:
                        check = false;
                        break;
                    default:
                        Console.WriteLine("You chose the wrong option, please choose correctly");
                        break;
                }
            }

        }
    }
}