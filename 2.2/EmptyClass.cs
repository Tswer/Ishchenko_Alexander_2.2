using System;
using System.Collections.Generic;
namespace _2._2
{

    /*class AccountComparer : IComparer<Currency>
    {
        public int Compare(Currency gr1, Currency gr2)
        {
            if (gr1.Sum > gr2.Sum)
            {
                return 1;
            }
            else
            {
                return 0;
            }
        }
    }*/
    class Account : CryptoMarket
    {
        public Account(int Num, string Name) : base(Num, true, Name)
        {

        }
        public List<Currency> Gr = new List<Currency>();

        public void Add(Currency gryvna)
        {
            Gr.Add(gryvna);
        }

        public void CloseAccount()
        {
            int k = Gr.Count;
            while (k > 0)
            {
                Gr.RemoveAt(k - 1);
                k--;
            }
            TypeCrypto = false;
            Console.WriteLine($"Currency number = {NameCrypto} name = {NameCrypto} close");
        }
        public double Sum()
        {
            double sum = 0;
            foreach (Currency i in Gr)
            {
                sum += i.Sum;
            }
            return sum;
        }
        public void SortAccount()
        {
            Gr.Sort();
        }
        public double AddDay(DateTime datatime)
        {
            double sum = 0;
            foreach (Currency i in Gr)
            {
                if (i.DateTime.Day == datatime.Day)
                {
                    sum += i.Sum;
                }
            }
            return sum;
        }
        public double AddMonth(DateTime datatime)
        {
            double sum = 0;
            foreach (Currency i in Gr)
            {
                if (i.DateTime.Month == datatime.Month)
                {
                    sum += i.Sum;
                }
            }
            return sum;
        }
        public double AddWeek(DateTime datatime)
        {
            double sum = 0;
            foreach (Currency i in Gr)
            {
                if (i.DateTime.Day >= datatime.Day && i.DateTime.Day <= datatime.Day + 7)
                {
                    sum += i.Sum;
                }
            }
            return sum;
        }
    }
}