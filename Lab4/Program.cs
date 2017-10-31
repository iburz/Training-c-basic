using System;
using System.Collections.Generic;

namespace Lab4
{
    class Program
    {
        static void Main(string[] args)
        {
            var cat1 = new Cat()
            {
                Name = "Tomas"
            };
            var cat2 = new Cat()
            {
                Name = "Viorel"
            };
            var cat3 = new Cat()
            {
                Name = "Fox"
            };
            var dog1 = new Dog()
            {
                Name = "Toto"
            };


            var CatList = new List<Cat>();
            CatList.Add(cat1);
            CatList.Add(cat2);
            CatList.Add(cat3);
            foreach (var cat in CatList)
            {
                cat.MakeNoise();
            }
        }
    }

}





