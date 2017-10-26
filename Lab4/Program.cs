using System;

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
       
           cat1.MakeNoise();
           cat2.MakeNoise();
           cat3.MakeNoise();
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

