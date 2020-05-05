using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ZooStore
{
    class Program
    {
        static void Main(string[] args)
        {
            int dogs = int.Parse(Console.ReadLine());
            int animals = int.Parse(Console.ReadLine());

            double DogFood = 2.50;
            int AnimalFood = 4;

            double TotalDogFood = dogs * DogFood;
            double TotalAnimalFood = animals * AnimalFood;

            double all = TotalDogFood + TotalAnimalFood;

            Console.WriteLine($"{all:f2}");

            

        }
    }
}
