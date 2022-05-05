using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace General
{
    class CarComp<T, S> : IComparer<T> where T : Car<S>
    {
        public int Compare(T x, T y)
        {
            if (x.Price < y.Price)
                return -1;
            else if (x.Price > y.Price)
                return 1;
            else
                return 0;
        }
    }
    class Car<T>
    {
        string Name { get; set; }
        T Number { get; set; }
        public int Price { get; set; }
        public Car(string _name, T _number, int _price)
        {
            Name = _name;
            Number = _number;
            Price = _price;
        }
        public void ShowCar()
        {
            Console.WriteLine($"{Name} | [{Number}] | {Price}$");
        }
    }
    class Garage<T>
    {
        List<Car<T>> cars;
        public Garage()
        {
            cars = new List<Car<T>>();
        }
        public void Add(Car<T> obj) => cars.Add(obj);

        public void Show()
        {
            foreach (var item in cars)
                item.ShowCar();
        }
        public void SortCars() => cars.Sort(new CarComp<Car<T>, T>());
    }
}