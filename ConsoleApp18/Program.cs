using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp18
{
    class Program
    {

        
       

        

        static void Main(string[] args)
        {

            //Build dom = new Build();
            //dom.name = "sdfgs";
            //dom.area = 100;
            //dom.kvo = 50;
            //Console.WriteLine(dom.Func());

            // Build dom2 = new Build("twins", 80, 100);


            /*

            Console.WriteLine("Name dom=");
            string name = Console.ReadLine();
            Console.WriteLine("Enter area");
            int area = int.Parse(Console.ReadLine());
            Console.WriteLine("Entaer people");
            int kvo = int.Parse(Console.ReadLine());
            Console.WriteLine("Entaer floor");
            int floor = int.Parse(Console.ReadLine());

            Build dom3 = new Build(name,area,kvo,floor);
            Console.WriteLine(dom3.Func());
            */


            Computer pk1 = new Computer("Asus", 4, 255);
            pk1.Info();

           Class1 transport = new Class1("Bike",Class1.Color.GreenYellow,25,1002);
 Console.WriteLine(transport.ToString());
 Console.ReadLine()

        }
    }
}
