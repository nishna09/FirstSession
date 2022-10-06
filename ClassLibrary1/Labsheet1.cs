using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Remoting.Services;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary1
{
    public class Labsheet1
    {

        public static void Display()
        {
            int previous = 0;
            foreach (var cat in Enum.GetValues(typeof(Category)))
            {
                Console.WriteLine("Category " + cat + " has the range of " + previous + " - " + (int)cat);
                previous = (int)cat + 1;

            }
        }
        public static void Check()
        {
            int value = 0;

            do {
                Display();

                Console.Write("Enter a value: ");
                value = int.Parse(Console.ReadLine());

                if (value == -1)
                    break;
                

                Category userCat = new Category();
                int previous=0; 

                foreach (var cat in Enum.GetValues(typeof(Category)))
                {
                   
                    if (value >= previous && value <= (int)cat)
                    {
                        userCat = (Category)cat;
                        break;
                    }
                    previous = (int)cat + 1;

                }
               
                Console.WriteLine("Your category: "+ userCat);
               

            }while(value != -1);


            
        }
    }
}
