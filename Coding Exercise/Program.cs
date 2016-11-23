using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.Practices.Unity;
using Coding_Exercise.BusinessLayer;

namespace Coding_Exercise
{
    class Program
    {
        private static IUnityContainer unityContainer = new UnityContainer();
        static void Main(string[] args)
        {
            Application app = new Application(unityContainer);
            app.RegisterTypes();
            app.Run();

            Console.WriteLine("Press Any Key to Contine");
            Console.ReadLine();
        }
    }
}
