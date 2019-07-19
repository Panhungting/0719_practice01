using System;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");

            Program pr = new Program();

            pr.random01();
        }

        public void random01()
        {

            Random r = new Random();

            int rNumber = 0;

            do
            {
                rNumber = r.Next(1, 100);

                Console.WriteLine(rNumber);
            }
            while (rNumber != 10);
            


        }

        public void test02(int i, string id, string pw)
        {

        }
    }
}
