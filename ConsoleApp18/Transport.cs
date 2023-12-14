using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp18
{
    class Transport
    {
        
        public string tip;
        public enum Color
        {
            Green, Blue, GreenYellow, GreenGreen
        }
        
        public int speed;
        public int mase;
        

        public Color color;


        public Class1() { }

        public Class1(string tip,Color color,int speed,int mase) 
        {
            this.tip = tip;
            this.color = color;
            this.speed = speed;
            this.mase = mase;

        
        }

        public override string ToString()
        {
            return $"{tip}\n{color}\n{speed}\n{mase}";
        }
    }
}
