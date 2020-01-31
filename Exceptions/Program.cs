using System;

namespace Exceptions
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            var demo = new DemoCode();
            try
            {
                var result = demo.GrandParentMethod(5);
                Console.WriteLine(result);
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);

                var inner = e.InnerException;
                while (inner != null)
                {
                    Console.WriteLine(inner.StackTrace);
                    inner = inner.InnerException;
                }
            }
        }
    }
}