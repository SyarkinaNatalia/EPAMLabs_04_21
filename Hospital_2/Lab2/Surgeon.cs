using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab2
{
    class Surgeon : Doctor
    {
        public override int Ncabinet => 5;

        public override void Note()
        {
            Console.WriteLine("Петров");
        }
    }
}
