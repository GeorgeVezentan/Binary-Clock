using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Binary_Clock
{
    class BinaryClock
    {

        static void Main()
        {
            while (true)
            {
                Console.Clear();
                DateTime currentTIme = DateTime.Now;
                Console.WriteLine("Binary Clock/n");
                Console.WriteLine($"Hour:  {ToBinary(currentTIme.Hour, 5)}");
                Console.WriteLine($"Minute:  {ToBinary(currentTIme.Minute, 6)}");
                Console.WriteLine($"Second:  {ToBinary(currentTIme.Second, 6)}");
                System.Threading.Thread.Sleep(1000);
            }
        }

        private static object ToBinary(int minute)
        {
            throw new NotImplementedException();
        }

        private static object ToBinary(int value, int lenght)
        {
            return Convert.ToString(value, 2).PadLeft(lenght, '0');
        }
    }
        
}
