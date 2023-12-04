using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp18
{
    class Build
    {
        public string name;
        public double area;
        public double kvo;
        public int floor;
        
        public Build()
        {
           


        }
         public Build(string name,double area,double kvo)
        {
            this.name = name;
            this.area = area;
            this.kvo = kvo;

        }
        public Build(string name, double area, double kvo,int floor):this(name,area,kvo)
        {
            
          
            this.floor = floor;
        }
        public string Func()
        {
            return $"Name= {name} \t Area= {area} \t People= {kvo} \t Floor={floor}\n  Square kvo= {area/kvo}";

        }

        


    }
}
