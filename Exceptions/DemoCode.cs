using System;

namespace Exceptions
{
    public class DemoCode
    {
        public int GrandParentMethod(int position)
        {
            var output = 0;
            Console.WriteLine("Connection opened");
            try
            {
                output = ParentMethod(position);
            }
            catch (Exception ex)
            {
                throw new ArgumentException("You passed wrong data", ex);
                throw; //Exception bubbling
            }
            finally
            {
                Console.WriteLine("Connection closed");
            }

            return output;
        }

        public int ParentMethod(int position)
        {
            return GetNumber(position);
        }

        public int GetNumber(int position)
        {
            //try
            //{
            int[] numbers = {1, 2, 3, 4, 5};
            return numbers[position];
            //}
            //catch (Exception e)
            //{
            //    Console.WriteLine(e.Message);
            //    Console.WriteLine(e.StackTrace);
            //    throw;
            //}
        }
    }
}