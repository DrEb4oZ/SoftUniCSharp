namespace _06.StoreBoxes
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string boxParameters;
            List<Box> boxes = new List<Box>();
            while ((boxParameters = Console.ReadLine()) != "end")
            {
                string[] currentBoxParametersInput = boxParameters
                    .Split()
                    .ToArray();
                string serialNumber = currentBoxParametersInput[0];
                string itemName = currentBoxParametersInput[1];
                int itemQuantity = int.Parse(currentBoxParametersInput[2]);
                decimal itemPrice = decimal.Parse(currentBoxParametersInput[3]);
                Item currentItem = new Item(itemName, itemPrice);
                Box currentBox = new Box();
                currentBox.SerialNumber = serialNumber;
                currentBox.Item = currentItem;
                currentBox.ItemQuantity = itemQuantity;
                boxes.Add(currentBox);
            }
            List<Box> sortedByPriceBoxes = boxes
                .OrderByDescending(x => x.BoxPrice)
                .ToList();
            foreach (Box box in sortedByPriceBoxes)
            {
                Console.WriteLine(box.PrintResult());
            }
        }
    }

    public class Item
    {
        public Item(string name, decimal price)
        {
            Name = name;
            Price = price;
        }

        public string Name { get; set; }
        
        public decimal Price { get; set; }
    }
    
    public class Box
    {
        public string SerialNumber { get; set; }

        public Item Item { get; set; }

        public int ItemQuantity { get; set; }

        public decimal BoxPrice 
        { 
            get => Item.Price * ItemQuantity;
        }

        public string PrintResult()
        {
            string result = $"{SerialNumber}\n" +
                $"-- {Item.Name} - ${Item.Price:f2}: {ItemQuantity}\n" +
                $"-- ${BoxPrice:f2}";
            return result;
        }
    }
}