using System;
using System.Collections.Generic;
using System.Linq;

namespace Lab2
{
    class Program
    {
        static void Main(string[] args)
        {
            {
                Patient patient = new Patient();
                Doctor[] schedule = { new Therapist("Иан", 56), new Surgeon(), new Oculist() };
                foreach (var item in schedule)
                {
                    patient.CheckInfo(item);
                    patient.Note(item);
                    Console.WriteLine();
                }

                List<Therapist> therapistList = new List<Therapist>();
                Therapist therapist1 = new Therapist("Илья", 30);
                Therapist therapist2 = new Therapist("Иван", 25);
                Therapist therapist3 = new Therapist("Мария", 22);
                Therapist therapist4 = new Therapist("Екатерина", 65);
                Therapist therapist5 = new Therapist("Дмитрий", 48);
                therapistList.Add(therapist1);
                therapistList.Add(therapist2);
                therapistList.Add(therapist3);
                therapistList.Add(therapist4);
                therapistList.Add(therapist5);
                Console.WriteLine(therapistList.Count);
                var sortT = from st in therapistList
                            orderby st.Name,st.Age
                            select st;
                foreach (Therapist st in sortT) 
                {
                    Console.WriteLine($"Имя {st.Name}, возраст {st.Age}");
                }
                try
                {
                    foreach (var tmp in therapistList)
                    {
                        if (tmp.Age == 22)
                        {
                            throw new Exception("Минимальный возраст врача 23 года");
                        }
                    }
                }
                    catch (Exception e)
                    {
                        Console.WriteLine($"Ошибка: {e.Message}");
                    }
                    Console.Read();
                }
        }


        }
}



