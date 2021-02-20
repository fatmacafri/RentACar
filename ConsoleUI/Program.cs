using Business.Concrete;
using DataAccess.Concrete.InMemory;
using System;

namespace ConsoleUI
{
    class Program
    {
        static void Main(string[] args)
        {
            CarManager carManager = new CarManager(new InMemoryCarDal());
            Console.WriteLine("------------------------CARS------------------------");
            foreach (var car in carManager.GetAll())
            {
                Console.WriteLine("Id : " + car.Id + " Brand Id :" + car.BrandId + " Color Id :" + car.ColorId + " Daily Price :" + car.DailyPrice + " Description :" + car.Description + " Model Year :" + car.ModelYear);
            }
        }
    }
}
