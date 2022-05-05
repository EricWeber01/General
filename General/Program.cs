using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace General
{
    class Program
    {
        static void Main(string[] args)
        {
            /*Poind2D<int> pointINT = new Poind2D<int>(8, 6);
            pointINT.ShowPoint();
            Poind2D<double> pointDOUB = new Poind2D<double>(2.2, 3.3);
            pointDOUB.ShowPoint();
            Poind2D<string> pointSTR = new Poind2D<string>("dotX", "dotY");
            pointSTR.ShowPoint();*/
            /*Garage<string> garage = new Garage<string>();
            garage.Add(new Car<string>("Wolkswagen", "AE1111EA", 2000));
            garage.Add(new Car<string>("Wolkswagen", "AE2222EA", 3000));
            garage.Add(new Car<string>("Wolkswagen", "AE3333EA", 1000));
            garage.Add(new Car<string>("Wolkswagen", "AE4444EA", 1500));
            garage.Show();
            Console.WriteLine("SORT");
            garage.SortCars();
            garage.Show();*/
            Letter letter = new Letter(10);
            foreach (var item in letter)
                Console.WriteLine(item);
        }
    }
}