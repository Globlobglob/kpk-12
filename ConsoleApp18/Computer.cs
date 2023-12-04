using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp18
{
    class Computer
    {
        public string name;
        public sbyte memory;
        public byte hardmem;
       
        public Computer()
        {

        }
        public Computer(string name,sbyte memory,byte hardmem)
        {
            this.name = name;
            this.memory = memory;
            this.hardmem = hardmem;

        }

        public void Info()
        {
            Console.WriteLine($"Model: {name}\n Memory GB: {memory} \n Harddisk : {hardmem}");
        }
    }
}
