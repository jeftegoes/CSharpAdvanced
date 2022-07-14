using System;

namespace Dynamic
{
    class Program
    {
        static void Main(string[] args)
        {
            /*
            object obj = "Mosh";
            
                Normal call... using reflection
                var methodInfo = obj.GetType().GetMethod("GetHashCode");
                methodInfo.Invoke(null, null);
            */

            /*
                Optimized call... using dynamic
                dynamic excelObject = "Mosh";
                excelObject.Optimize();
            */
            dynamic name = "mosh";
            Console.WriteLine("Type {0} Value: {1}", name.GetType(), name);

            name = 10;
            Console.WriteLine("Type {0} Value: {1}", name.GetType(), name);

            dynamic a = 10;
            dynamic b = 5;
            var c = a + b;
            Console.WriteLine(c);

            int i = 5;
            dynamic d = i;
            Console.WriteLine(d);
        }
    }
}
