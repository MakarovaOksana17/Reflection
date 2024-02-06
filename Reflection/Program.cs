// See https://aka.ms/new-console-template for more information
//using Newtonsoft.Json;
using Reflection;
using Reflections;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Text.Json;

namespace Reflections
{
    class Program
    {
        static void Main(string[] args)
        {
            Company company = new Company().Get();
            string stringCompanyJson = "{\"Company\":{\"id\": \"1\",\"shortName\": \"RADUGACompany\",\"inn\": \"9701087101\",\"kpp\": \"770101001\",\"fullCompanyName\": \"OOO RADUGA\",\"legalAddress\": \"\",\"actualAddress\": \"\",\"regNum\": \"1177746937015\",\"okato\": \"45293598000\",\"okopf\": \"12300\",\"okpo\": \"05056301\",\"oktmo\": \"45910000000\"}}\r\n";
            SerializeClassToCSV cSV = new SerializeClassToCSV();
            SerialazeClassToJson json = new SerialazeClassToJson();
            Console.ReadKey();

            SerialazeClass serialaze = new SerialazeClass(cSV);
            Console.WriteLine($"Выполнение метода serialized заняло {howLongMethodRun(100000, serialaze, company)} мс");
            Console.WriteLine($"Выполнение метода serialized заняло {howLongMethodRun(100000, serialaze, stringCompanyJson)} мс");
            serialaze = new SerialazeClass(json);
            Console.WriteLine($"Выполнение метода JsonSerializer.Serialize заняло {howLongMethodRun(100000, serialaze, company)} мс");
            Console.WriteLine($"Выполнение метода JsonSerializer.Deserialize заняло {howLongMethodRun(100000, serialaze, stringCompanyJson)} мс");

            Console.ReadLine();
        }

        public static long howLongMethodRun(int count, SerialazeClass serialaze, object classN)
        {
            var timer = Stopwatch.StartNew();
            Type type = classN.GetType();
            for (int i = 0; i < count; i++)
            {
               
                if (type.Name == "String")
                {
                    serialaze.Serialazed((string)classN);
                }
                else
                {
                    serialaze.Serialazed(classN);
                }
            }
                timer.Stop();
            return timer.ElapsedMilliseconds;
        }
    } 
}
           

