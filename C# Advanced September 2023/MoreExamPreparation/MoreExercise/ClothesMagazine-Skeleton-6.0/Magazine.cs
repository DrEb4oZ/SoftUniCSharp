﻿using System.Collections.Generic;
using System.Linq;
using System.Security.Principal;
using System.Text;

namespace ClothesMagazine
{
    public class Magazine
    {

        public Magazine(string type, int capacity)
        {
            Type = type;
            Capacity = capacity;
            Clothes = new List<Cloth>();
        }

        public string Type { get; set; }

        public int Capacity { get; set; }

        public List<Cloth> Clothes { get; set; }


        public void AddCloth(Cloth cloth)
        {
            if (Clothes.Count < Capacity)
            {
                Clothes.Add(cloth);
            }
        }

        public bool RemoveCloth(string color) => Clothes.Remove(Clothes.FirstOrDefault(c => c.Color == color));

        public Cloth GetSmallestCloth() => Clothes.MinBy(c => c.Size);

        public Cloth GetCloth(string color) => Clothes.FirstOrDefault(c => c.Color == color);

        public int GetClothCount() => Clothes.Count;

        public string Report()
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine($"{Type} magazine contains:");
            foreach (Cloth cloth in Clothes.OrderBy(c => c.Size))
            {
                sb.AppendLine(cloth.ToString());
            }
            return sb.ToString().TrimEnd();
        }
    }
}
