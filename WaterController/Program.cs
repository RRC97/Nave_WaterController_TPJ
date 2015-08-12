using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WaterController
{
    class Program
    {
        static void Main(string[] args)
        {
            Water obj = new Water();
            Console.WriteLine("WaterElement Created\n");
            obj.GetState();
            String read = null;
            while (read != "q" && (read == null || read == ""))
            {
                int action = Actions();
                obj.ToAct(action);
                obj.GetState();
                read = Console.ReadLine();
            }
        }

        static int Actions()
        {
            String read = null;
            int value = -1;
            while(value <= 0 || value > 4)
            {
                Console.WriteLine("Choose an action");
                Console.WriteLine("1 - To Freeze");
                Console.WriteLine("2 - To Boil");
                Console.WriteLine("3 - To Sublimate");
                Console.WriteLine("4 - To Deposition");
                Console.WriteLine("");
                read = Console.ReadLine();
                Int32.TryParse(read, out value);
            }
            return value;
        }
    }
}
