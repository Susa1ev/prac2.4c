using System;

namespace prac2._4_c_
{
    class prac
    {
        public prac()
        {
            Main();
        }
        void Main()
        {
            for(int i = 0; i < 5; i++)
            {
                for (int j = 4 - i; j >= 0; j--)
                {
                    Console.Write(j + "\t");
                }
                Console.Write("\v");
            }
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            prac p = new prac();
        }
    }
}
