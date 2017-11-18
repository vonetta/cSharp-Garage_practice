using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Garage
{
    class Program
    {
        static void Main(string[] args)
        {
            //create a car class
            //Make, Model, Color, Price, Sold

            //create a list of cars(3-4 cars)
            //build a for loop and output all the cars

            List<Car> carList = new List<Car>();

            //three ways to add a car
            //1 - standard for user input
            Car c1 = new Car()
            {
                Make = "BMW",
                Model = "X5",
                Color = "Blue",
                Price = 1.00m,
                Sold = false
            };
            carList.Add(c1);

            //2
            carList.Add(new Car { Make = "Audi", Model = "X4", Color = "Green", Price = 1.2m,
                Sold = true });

            //3
            Car c3 = new Car();
            c3.Make = "Toyota";
            c3.Model = "Corolla";
            c3.Color = "Gray";
            c3.Price = 5m;
            c3.Sold = true;

            carList.Insert(0, c3); //adds c3 as the first car

            Car c4 = new Car("Honda");
            //c4.Make = "Honda";
            c4.Model = "Sonata";
            c4.Color = "Raindow";

            carList.Add(c4);

            //build a for loop

            for (int i = 0; i < carList.Count; i++) {
                /*
                string sold = "";
                if (carList[i].Sold)
                {
                    sold = "Sold";
                }
                else {
                    sold = "Not sold";
                }*/
                Console.WriteLine("{0}, {1} is {2}, listed for {3:c}", carList[i].Make, carList[i].Model, carList[i].Sold ? "sold": "not sold", carList[i].Price);

               // Console.WriteLine("{0}, {1} is {2}, listed for {3:c}", carList[i].Make, carList[i].Model, sold, carList[i].Price);
            }

            foreach (Car item in carList) {
                Console.WriteLine("{0}, {1} is {2}, listed for {3:c}", item.Make, item.Model, item.Sold ? "sold" : "not sold", item.Price);
            }
            Console.ReadLine();
        }
    }
}
