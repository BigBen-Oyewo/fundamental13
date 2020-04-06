using System;
using System.Collections.Generic;

namespace fundamental13
{
    class Program
    {


        static void Print1To255() 
        {
            for(int i=0; i<256; i++)
            {
                Console.WriteLine(i);
            }
        }

        static void Main(string[] args)
        {
            Print1To255();
        }
    }
}
