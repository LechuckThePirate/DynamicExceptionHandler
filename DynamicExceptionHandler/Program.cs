using System;
using System.CodeDom;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace DynamicExceptionHandler
{
    class Program
    {

        private static void GenerateNullReference()
        {
            Console.WriteLine(">>> Generating NullReferenceException");
            string a = null;
            var b = a.ToString();
        }

        private static void GenerateDivideByZero()
        {
            Console.WriteLine(">>> Generating DivideByZeroException");
            var i = 0;
            var j = 100 / i;
        }

        private static void GenerateNotImplemented()
        {
            Console.WriteLine(">>> Generating NotImplementedException");
            throw new NotImplementedException();
        }

        private static ConsoleKeyInfo ReadOption()
        {
            Console.WriteLine("Select to generate a exception\r\n1 - NullReference\r\n2 - DivideByZero\r\n3 - NotImplemented\r\n4 - Exit");
            var result = Console.ReadKey();
            Console.WriteLine();
            return result;
        }

        static void Main(string[] args)
        {

            ConsoleKeyInfo k = new ConsoleKeyInfo();
            do
            {
                try
                {
                    k = ReadOption();
                    switch (k.KeyChar)
                    {
                        case '1':
                            GenerateNullReference();
                            break;
                        case '2':
                            GenerateDivideByZero();
                            break;
                        case '3':
                            GenerateNotImplemented();
                            break;
                    }
                }
                catch (Exception ex)
                {
                    DynExceptionHandler.HandleException(ex);
                    Console.WriteLine("Press any key to continue...");
                    Console.ReadKey();
                    Console.Clear();
                }
            } while (k.KeyChar != '4');


        }
    }
}
