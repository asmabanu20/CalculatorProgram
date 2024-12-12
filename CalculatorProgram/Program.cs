using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CalculatorProgram
{
    internal class calculator
    {
      
       public int Add (int a,int b)
        {
            return a + b;
        }
        public double Add (double a,double b)
        {
            return a + b;

        }
        static void Main(string[] args)
        {
            calculator calculator1 = new calculator();          
           int intsum= calculator1.Add(10,20);
            Console.WriteLine("interger sum: "+intsum);

           calculator calculator2 = new calculator();
            double doublesum=calculator2.Add(20.57, 30.56);
            Console.WriteLine("double sum: " + doublesum);
        }
    }
}
