using System;

namespace Lab2
{
    class Program
    {
        static void Main(string[] args)
        {
            Patient patient = new Patient();
            Doctor[] schedule = { new Therapist(), new Surgeon(), new Oculist() };
            foreach (var item in schedule)
            {
                patient.CheckInfo(item);
                patient.Note(item);
                Console.WriteLine();
            }
        }
    }
}
