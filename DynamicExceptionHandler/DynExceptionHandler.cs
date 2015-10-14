using System;
using System.Diagnostics;

namespace DynamicExceptionHandler
{
    public class DynExceptionHandler
    {

        private static void DynHandle(NullReferenceException ex)
        {
            Console.WriteLine("Null reference exception thrown!");
            Trace.TraceError("{0}",ex);
        }

        private static void DynHandle(DivideByZeroException ex)
        {
            Console.WriteLine("Divide by zero exception thrown!");
            Trace.TraceError("{0}", ex);
        }

        private static void DynHandle(NotImplementedException ex)
        {
            Console.WriteLine("Not implemented exception thrown!");
            Trace.TraceError("{0}", ex);
        }

        private static void DynHandle(Exception ex)
        {
            Console.WriteLine("Unknown exception type! {0}", ex.GetType());
            Trace.TraceError("{0}",ex);
        }

        private static void DynHandle(object ex)
        {
            Console.WriteLine("Not an exception!!! {0}", ex.GetType());
            Trace.TraceError("{0}", ex);
        }

        public static void HandleException(dynamic ex)
        {
            if (ex == null) 
                DynHandle(new Exception("Null Exception thrown?",ex));
            DynHandle(ex);
            Console.WriteLine();
            Console.WriteLine();
        }


    }
}
