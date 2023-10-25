using System.Collections.Generic;
using System.Linq;
using System.Reflection.PortableExecutable;
using System.Text;
using System.Threading.Channels;

namespace ShoeStore
{
    public class ShoeStore
    {
        public ShoeStore(string name, int storageCapacity)
        {
            Name = name;
            StorageCapacity = storageCapacity;
            Shoes = new List<Shoe>();
        }

        public string Name { get; set; }

        public int StorageCapacity { get; set; }

        public List<Shoe> Shoes { get; set; }

        public int Count => Shoes.Count;

        public string AddShoe(Shoe shoe)
        {
            if (Shoes.Count < StorageCapacity)
            {
                Shoes.Add(shoe);
                return $"Successfully added {shoe.Type} {shoe.Material} pair of shoes to the store.";
            }

            return "No more space in the storage room.";
        }

        public int RemoveShoes(string material) => Shoes.RemoveAll(sh => sh.Material == material);

        public List<Shoe> GetShoesByType(string type)
        {
            List<Shoe> filteredShoes = new List<Shoe>();
            foreach (Shoe shoe in Shoes)
            {
                if (shoe.Type.ToLower() == type.ToLower())
                {
                    filteredShoes.Add(shoe);
                }
            }
            return filteredShoes;
        }

        public Shoe GetShoeBySize(double size) => Shoes.FirstOrDefault(sh => sh.Size == size);

        public string StockList(double size, string type)
        {
            StringBuilder sb = new StringBuilder();
            if (Shoes.Any(sh => sh.Size == size && sh.Type == type))
            {
                sb.AppendLine($"Stock list for size {size} - {type} shoes:");
                foreach (Shoe shoe in Shoes)
                {
                    if (shoe.Size == size && shoe.Type == type)
                    {
                        sb.AppendLine(shoe.ToString());
                    }
                }
                return sb.ToString().TrimEnd();
            }
            else
            {
                return "No matches found!";
            }
        }
    }
}
