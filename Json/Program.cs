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
                    default:
                        break;

                }
            }

        }
    }
}