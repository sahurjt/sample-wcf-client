using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ServiceModel;
using Simple_WCF_Client;

namespace Simple_WCF_Client
{
    class Program
    {
        static void Main(string[] args)
        { 
            Console.WriteLine("press Y to stop");
            CalculationServiceClient client = new CalculationServiceClient();
            var res=client.Sum(5, 5);
            Console.WriteLine("sum: " + res);
            Console.WriteLine("Name: " + client.FullName(new SImple_Wcf_Example.Person { First="rajat", Last="sahu" }));
            
            do
            {
                Console.WriteLine("Count: "+client.Count());
            } while (Console.ReadLine()!="Y");
            client.Close();
            
        }
    }
}
