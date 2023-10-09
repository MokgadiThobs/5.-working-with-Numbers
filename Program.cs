using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _5.working_with_Numbers
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //you can just poin out numbers as below
            Console.WriteLine(5);
            //you can also us operators right in the writeline method ie + - */
            Console.WriteLine(6 + 5);
            //modulo opeator, to get the remainder of division, use %
            Console.WriteLine(5 % 2);
            //BODMAS stillaplie, 4+2*3 gets 10, use brackets to change the order
            Console.WriteLine(4 + 2 * 3);
            //whatever you do just with integers you always get an integer back
            Console.WriteLine(5 / 2); //yu get   2 not 2.5!
            //if you use a decimal and an integer you always get a double
            Console.WriteLine(5 / 2.0);// you  get 2.5
            //can also  give a nembert a variable
            int num = 6;
            //can increment od decrement by 1
            num++;
            Console.WriteLine(num);
            //calling methods eg the math method, Abs meanas Absolute
            //you will always get the positive nrmber
            Console.WriteLine(Math.Abs(-40));
            //to raiseto powers
            Console.WriteLine(Math.Pow(2, 2));

        }
    }
}
