using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Vehicles
{
    class Vehicle
    {
        protected internal int year;
        protected internal string brand;
        protected internal double[] priceOverYears;

        public Vehicle()
        {
            year = 0;
            brand = "default";
            priceOverYears = new double[3] { 300.0, 400.0, 500.0 };
        }

        public Vehicle(int year, string brand, double[] priceOverYears)
        {
            this.year = year;
            this.brand = brand;
            this.priceOverYears = priceOverYears;
        }
        ~Vehicle()
        {
            Console.WriteLine("Going --> deleting");
        }

        public int GetYear()
        {
            return this.year;
        }

        public void SetYear(int y)
        {
            this.year = y;
        }
        public virtual void ShowDetails()
        {
            Console.WriteLine("This is a vehicle with brand {0}", brand);
        }
    }

    class Car:Vehicle
    {
        protected internal string model = "boring";
        public Car() : base()
        {
        }
        public Car(int year, string brand, double[] priceOverYears, string model) : base(year, brand, priceOverYears)
        {
            this.model = model;
        }

        public static Car operator+ (Car b, Car c)
        {
            Car car = new Car();
            car.year = b.year + c.year;
            car.brand = b.brand;
            car.priceOverYears = c.priceOverYears;
            car.model = b.model;
            return car;
        }

        public override void ShowDetails()
        {
            Console.WriteLine("This is a car with brand {0} and of model {1}", brand, model);
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Vehicle v1 = new Vehicle();
            Console.WriteLine("the vehicle v1 has " + v1.GetYear());
            Car c1 = new Car(1990, "Toyota", new double[3] { 300.00, 600.00, 900.00 }, "Camry");
            Car c2 = new Car(2000, "Audi", new double[3] { 150.00, 200.0, 400.00 }, "R8");
            Car c3 = new Car();
            c3 = c1 + c2;
            v1.ShowDetails();
            c1.ShowDetails();
            Console.WriteLine("car c3 has {0}", c3.GetYear());
            Console.ReadLine();
        }
    }
}
