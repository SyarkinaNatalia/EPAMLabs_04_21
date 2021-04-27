using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab2
{
    class Patient 
    {
        public void Note(Doctor doctor)
        {
            doctor.Note();
        }
        public void CheckInfo(Doctor doctor)
        {
            doctor.ShowInfo();
        }
    }
}
