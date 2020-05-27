using System;
namespace _2._2
{
    class CryptoMarket
    {
        private int numberCrypto;
        private bool typeCrypto;
        private string nameCrypto;
        public int NumberCrypto
        {
            get { return numberCrypto; }
            set
            {
                if (value < 0)
                    Console.WriteLine("Number Crypto is incorect");
                else numberCrypto = value;
            }
        }
        public bool TypeCrypto
        {
            get { return typeCrypto; }
            set { typeCrypto = value;  }
         
        }
        public string NameCrypto
        {
            get { return nameCrypto; }
            set
            {
                if (value == "")
                    Console.WriteLine("Name Crypto is incorect");
                else nameCrypto = value;
            }
        }
        public CryptoMarket(int NumberCrypto, bool TypeCrypto, string NameCrypto)
        {
            numberCrypto = NumberCrypto;
            typeCrypto = TypeCrypto;
            nameCrypto = NameCrypto;
        }
    }
}
