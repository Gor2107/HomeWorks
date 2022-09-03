using System;

namespace Lesson1_2
{
    internal class Program
    {
        static void Main()
        {
            //Citizen[] citizens = new Citizen[] { new Pensioner("Papik", "Papikyan"),
            //                                     new Student("Usanox","Usanoxyan"),
            //                                     new Worker ("Banvor","Bsnvoryan") };
            CitizensCollection citizensCollection = new CitizensCollection(){
                                                 new Worker("Worker1", "Workeryan1"){ Passport = "AF1" },
                                                 new Pensioner("Pensioner1","Pensioneryan1"){ Passport = "AF2" },
                                                 new Worker ("Worker2","Workeryan2"){ Passport = "AF3" } };


            citizensCollection.Add(new Pensioner("Pensioner2", "Pensioneryan2") { Passport = "AF4" });
            int x = citizensCollection.Add(new Pensioner("Pensioner3", "Pensioneryan3") { Passport = "AF5" });
            citizensCollection.Add(new Pensioner("qqqqq", "qqqqq") { Passport = "AF5" });
            foreach (Citizen item in citizensCollection)
            {
                Console.WriteLine(item.FullName + ", Passport = " + item.Passport);
            }
            Console.WriteLine("pensionerIndex =" + x);
        }
    }
}
