using System;

namespace Properties
{
    class Income
    {
        private int _income = 45000;
        public int income { 
            get { return _income; }
            set {
                if (value <= 0) {
                    _income = 0;
                }

                else if (value >= 45000)
                {
                    _income = 45000;
                }

                else
                {
                    _income = value;
                }
            } 
        }


        public void Debit(int monyspend)
        {
            _income = _income - monyspend;
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            /* DateTime currntTime = DateTime.Now;
             Console.WriteLine(currntTime);
             Console.ReadKey();*/
            Income amountleft = new Income();
            amountleft.Debit(25000);
            Console.WriteLine(amountleft.income);
            amountleft.income = amountleft.income - 50000;
            Console.WriteLine(amountleft.income);
            amountleft.income += 70000;
            Console.WriteLine(amountleft.income);
        }
    }
}
