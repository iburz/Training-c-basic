using System;
using System.Collections.Generic;

namespace Lab4
{
    class Program
    {
        static void Main(string[] args)
        {
            var cat1 = new Kitty()
            {
                Name = "Tomas"
            };
            var cat2 = new Kitty()
            {
                Name = "Viorel"
            };
            var cat3 = new Kitty()
            {
                Name = "Fox"
            };

            var CatList = new List<Kitty>();
            CatList.Add(cat1);
            CatList.Add(cat2);
            CatList.Add(cat3);
            for (var i = 0; i < CatList.Count; i++)
            {
                CatList[i].MakeNoise();
            }

            foreach (var cat in CatList)
            {
                cat.MakeNoise();
            }
        }
    }
    public class Kitty
    {

        public string Name { get; set; }
        public void MakeNoise()
        {
            Console.WriteLine(Name + " says Miau");

        }
    }
}

