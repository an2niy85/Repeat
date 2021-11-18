using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Repeat
{
    class Program
    {
        static void Main(string[] args)
        {
            string phrase;
            int countRepetitions;
           
            
            Console.WriteLine("Введите фразу?");
            phrase = Console.ReadLine();
            Console.WriteLine("Введите кол-во повторов?");
            countRepetitions = Convert.ToInt32(Console.ReadLine());

            for (int i = 0; i < countRepetitions; i++)
            {
                Console.WriteLine(phrase);
            }
            Console.ReadLine();
        }
    }
}
