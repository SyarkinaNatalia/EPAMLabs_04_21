using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab2
{
    abstract class Doctor
    {
        public abstract int Ncabinet { get; }
        public abstract void Note();
        public void ShowInfo()
        {
            Console.WriteLine($"{ GetType().Name} Ncabinet: { Ncabinet}");
        }
    }
}
