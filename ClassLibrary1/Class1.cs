using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary1
{
    public class Class1
    {
        public static void TurnaryExp()
        {
            var value=int.Parse(Console.ReadLine());
            string msg=string.Empty;

            msg = value < 10 ? "Value less than 10" : "Value greater than 10";
            Console.WriteLine(msg);

            Console.ReadLine();
        }
    }
}
