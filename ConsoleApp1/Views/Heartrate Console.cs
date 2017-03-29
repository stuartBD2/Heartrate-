using ConsoleApp1.Models;
using ConsoleApp1.Services;
using System;

namespace ConsoleApp1
{
    class Heart
    {
        static void Main(string[] args)
        {
            bool notInt = true;
            int age = 0;
            int heartrate = 0;
            while (notInt)
            {
                Console.WriteLine("Please enter your age: ");
                try
                {
                    age = Convert.ToInt32(Console.ReadLine());
                    Console.Clear();
                    Console.WriteLine("Please enter your resting heartrate");
                    try
                    {
                        heartrate = Convert.ToInt32(Console.ReadLine());
                        notInt = false;
                    }
                    catch
                    {
                        Console.Clear();
                    }
                }
                catch
                {
                    Console.Clear();
                }
            }
            HeartrateModelCreator modelCreator = new HeartrateModelCreator();
            ListIntensityHeartrate model = new ListIntensityHeartrate();
            model = modelCreator.createModel(age, heartrate);
            Console.Clear();
            Console.WriteLine(string.Format("Age: {0}    Resting Heart Rate: {1}", age, heartrate));
            Console.WriteLine("");
            Console.WriteLine("Intensity | Heartrate");
            Console.WriteLine("---------------------");
            foreach (var heartrateintensity in model.ListOfIntensityHeartrates)
            {
                Console.WriteLine(string.Format("      {0}% | {1}", heartrateintensity.Intensity, heartrateintensity.Heartrate));
            }
            Console.ReadKey();
        }
    }
}
