using System;
namespace _2._2
{
    class Currency : IComparable<Currency>
    {
        public int CompareTo(Currency gr1)
        {
            Currency c = gr1 as Currency;
            return this.Sum.CompareTo(c.Sum);
        }
        private double sum;
        private DateTime dateTime;
        public double Sum
        {
            get { return sum; }
            set { if (value < 0) Console.WriteLine("Sum is incorect"); else sum = value; }
        }
        public DateTime DateTime
        {
            get { return dateTime; }
            set { dateTime = value; }
        }
        public Currency(double Sum, DateTime DateTime)
        {
            sum = Sum;
            dateTime = DateTime;
        }
    }
    /*class Bitcoin : CryptoMarket
    {
        private double sum;
        private DateTime dateTime;

        public double Sum
        {
            get { return sum; }
            set { if (sum < 0) Console.WriteLine("Sum is inncorect"); else sum = value; }
        }

        public DateTime DateTime
        {
            get { return dateTime; }
            set { dateTime = value; }

        }

        public Bitcoin(int Num, bool Type, string Name, double Sum, DateTime DateTime) : base(Num, Type, Name)
        {
            sum = Sum;
            dateTime = DateTime;
        }

    }
    class Ethereum : CryptoMarket
    {
        private double sum;
        private DateTime dateTime;

        public double Sum
        {
            get { return sum; }
            set { if (sum < 0) Console.WriteLine("Sum is inncorect"); else sum = value; }
        }

        public DateTime DateTime
        {
            get { return dateTime; }
            set { dateTime = value; }

        }

        public Ethereum(int Num, bool Type, string Name, double Sum, DateTime DateTime) : base(Num, Type, Name)
        {
            sum = Sum;
            dateTime = DateTime;
        }

    }
    class Ripple : CryptoMarket
    {
        private double sum;
        private DateTime dateTime;

        public double Sum
        {
            get { return sum; }
            set { if (sum < 0) Console.WriteLine("Sum is inncorect"); else sum = value; }
        }

        public DateTime DateTime
        {
            get { return dateTime; }
            set { dateTime = value; }

        }

        public Ripple(int Num, bool Type, string Name, double Sum, DateTime DateTime) : base(Num, Type, Name)
        {
            sum = Sum;
            dateTime = DateTime;
        }

    }
    class EOS : CryptoMarket
    {
        private double sum;
        private DateTime dateTime;

        public double Sum
        {
            get { return sum; }
            set { if (sum < 0) Console.WriteLine("Sum is inncorect"); else sum = value; }
        }

        public DateTime DateTime
        {
            get { return dateTime; }
            set { dateTime = value; }

        }

        public EOS(int Num, bool Type, string Name, double Sum, DateTime DateTime) : base(Num, Type, Name)
        {
            sum = Sum;
            dateTime = DateTime;
        }

    }
    class Ardor : CryptoMarket
    {
        private double sum;
        private DateTime dateTime;

        public double Sum
        {
            get { return sum; }
            set { if (sum < 0) Console.WriteLine("Sum is inncorect"); else sum = value; }
        }

        public DateTime DateTime
        {
            get { return dateTime; }
            set { dateTime = value; }

        }

        public Ardor(int Num, bool Type, string Name, double Sum, DateTime DateTime) : base(Num, Type, Name)
        {
            sum = Sum;
            dateTime = DateTime;
        }

    }
    class Currensy : CryptoMarket
    {
        private double sum;
        private DateTime dateTime;

        public double Sum
        {
            get { return sum; }
            set { if (sum < 0) Console.WriteLine("Sum is inncorect"); else sum = value; }
        }

        public DateTime DateTime
        {
            get { return dateTime; }
            set { dateTime = value; }

        }

        public Currensy(int Num, bool Type, string Name, double Sum, DateTime DateTime) : base(Num, Type, Name)
        {
            sum = Sum;
            dateTime = DateTime;
        }

    }

    class Gryvna : CryptoMarket
    {
        private double sum;
        private DateTime dateTime;

        public double Sum
        {
            get { return sum; }
            set { if (sum < 0) Console.WriteLine("Sum is inncorect"); else sum = value; }
        }

        public DateTime DateTime
        {
            get { return dateTime; }
            set { dateTime = value; }

        }

        public Gryvna(int Num, bool Type, string Name, double Sum, DateTime DateTime) : base(Num, Type, Name)
        {
            sum = Sum;
            dateTime = DateTime;
        }

    }*/
}