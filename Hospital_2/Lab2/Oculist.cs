using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab2
{
    class Oculist : Doctor
    {
        public override int Ncabinet => 15;


        public override void Note()
        {
            Console.WriteLine("Сидоров");
        }
    }
}
