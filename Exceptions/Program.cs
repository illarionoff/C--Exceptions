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
            catch (ArgumentException ex)
            {
                Console.WriteLine("Your number is out of range");
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);

                var inner = ex.InnerException;
                while (inner != null)
                {
                    Console.WriteLine(inner.StackTrace);
                    inner = inner.InnerException;
                }
            }
        }
    }
}