using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab2
{
    class Therapist : Doctor
    {
        public override int Ncabinet => 10;
        public string Name { get; set; }
        public int Age { get; set; }
        public Therapist(string name, int age)
        {
            this.Name = name;
            this.Age = age;
        }

        public override void Note()
        {
            Console.WriteLine("Иванов");
        }
    }
}
