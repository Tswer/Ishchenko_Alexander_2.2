using System;

namespace _2._2
{
    class Program
    {
        static void Main(string[] args)
        {

            Account ac1 = new Account(1, "Bitcoin");
            ac1.Add(new Currency(5, new DateTime(2020, 07, 19)));
            ac1.Add(new Currency(6, new DateTime(2020, 07, 01)));
            ac1.Add(new Currency(7, new DateTime(2020, 07, 05)));
            ac1.Add(new Currency(2, new DateTime(2020, 07, 12)));
            Console.WriteLine("list not sort");
            foreach (Currency i in ac1.Gr)
            {
                Console.WriteLine($"{i.Sum} {i.DateTime}");
            }
            ac1.SortAccount();
            Console.WriteLine("list sort");
            foreach (Currency i in ac1.Gr)
            {
                Console.WriteLine($"{i.Sum} {i.DateTime}");
            }
            Console.WriteLine("Sum=" + ac1.Sum());
            Console.WriteLine("Day=" + ac1.AddDay(new DateTime(2020, 07, 01)));
            Console.WriteLine("Week=" + ac1.AddWeek(new DateTime(2020, 07, 01)));
            Console.WriteLine("Month=" + ac1.AddMonth(new DateTime(2020, 07, 01)));
            ac1.CloseAccount();
            foreach (Currency i in ac1.Gr)
            {
                Console.WriteLine($"{i.Sum} {i.DateTime}");
            }

        }
    }
}