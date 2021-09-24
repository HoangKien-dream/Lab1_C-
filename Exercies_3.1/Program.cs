using System;
using System.Runtime.InteropServices;

namespace Exercies_3._1
{
   class Car
   {
       public string make;
       public string model;
       public string color;
       public int yearBuilt;

       public void Start()
       {
           Console.WriteLine(model + "started");
       }

       public void Stop()
       {
           Console.WriteLine(model +"stopped");
       }
   }

   class Program
   {
       public static void Main(string[] args)
       {
           Car myCar;
           Console.WriteLine("Creating a Car object and assigning" + "its memory location to myCar");
           myCar = new Car();
           myCar.make = "Toyota";
           myCar.model = "MR2";
           myCar.color = "black";
           myCar.yearBuilt = 1995;

           Console.WriteLine("My car detail :");
           Console.WriteLine("Make: "+myCar.make);
           Console.WriteLine("Model: "+myCar.model);
           Console.WriteLine("Color: "+myCar.color);
           Console.WriteLine("Color: "+myCar.yearBuilt);
           
           myCar.Start();
           myCar.Stop();
           Console.WriteLine("Creating another car object and "+"assigning its memory location to redPorsche");
           Car redPorsche = new Car();
           redPorsche.make = "Porsche";
           redPorsche.model = "Boxster";
           redPorsche.color = "Red";
           redPorsche.yearBuilt = 2000;

           Console.WriteLine("redPorsche is a "+redPorsche.model);
           Console.WriteLine("Assigning redPorsche to myCar");
           myCar = redPorsche;
           Console.WriteLine("my car detail: ");
           Console.WriteLine("Make: "+myCar.make);
           Console.WriteLine("Model: "+myCar.model);
           Console.WriteLine("Color: "+myCar.color);
           Console.WriteLine("YearBuilt: "+ myCar.yearBuilt);
           myCar = null;
           Console.ReadLine();
       }
   }
}