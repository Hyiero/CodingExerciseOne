using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.Practices.Unity;
using Coding_Exercise.BusinessLayer;

namespace Coding_Exercise
{
    public class Application : IApplication
    {
        private IUnityContainer unityContainer;

        public Application(IUnityContainer _unityContainer)
        {
            unityContainer = _unityContainer;
        }

        public void RegisterTypes()
        {
            unityContainer.RegisterType<OccurenceWork>();
            unityContainer.RegisterType<ILineAnalyzer, LineAnalyzer>();
        }

        public void Run()
        {
            List<string> linesForAnalysis = new List<string>()
            {
                "XM0GGWTX7WUO0Z1K3IXI",
                "LHUKOOHTN1PN2XO2V1DD",
                "94BWMADMP480IA03THLQ",
                "COO6OE94NUXPOUYXOLM3",
                "P0CM35IUJ01W2VHJOYW3",
                "UAWBE3T1DZY0B9E69QYC",
                "6F2IKBL5KNPOD73W96QT",
                "YS7Y2HDJMICC20SAUKTD",
                "DIT1LR8MGR3UO18OU0GA",
                "M7YFN6JMDLSVCV31XFJ9"
            };

            OccurenceWork work = unityContainer.Resolve<OccurenceWork>();

            Console.WriteLine("--------Highest Occurences Per Row--------");
            foreach(var line in linesForAnalysis)
            {
                work.DisplayHighestOccurenceInLine(line);
            }

            Console.WriteLine("--------Lowest Occurences Per Row--------");
            foreach(var line in linesForAnalysis)
            {
                work.DisplayLowestOccurenceInLine(line);
            }

            Console.WriteLine("--------Count for each Character--------");
            string singleLineToAnalyze = string.Join("", linesForAnalysis);
            work.DisplayTotalOrderedOccurencesInLine(singleLineToAnalyze);

            Console.WriteLine("--------Highest Occurence for Whole Block--------");
            work.DisplayHighestOccurenceInLine(singleLineToAnalyze);

            Console.WriteLine("--------Lowest Occurence for Whole Block--------");
            work.DisplayLowestOccurenceInLine(singleLineToAnalyze);
        }
    }
}
