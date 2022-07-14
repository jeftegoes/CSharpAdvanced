using System;

namespace NullableTypes
{
    class Program
    {
        static void Main(string[] args)
        {
            /*
                Nullable<DateTime> date = null;

                DateTime? date = null;
            
                int? number = null;

                Console.WriteLine("GetValueOrDefault(): Date: {0} Number: {1}", date.GetValueOrDefault(), number.GetValueOrDefault());
                Console.WriteLine("HasValue: Date: {0} Number: {1}", date.HasValue, number.HasValue);
                
                System.InvalidOperationException: Nullable object must have a value.
                Console.WriteLine("Value: {0} Number: {1}", date.Value, number.Value);
            */
            
            /*
                DateTime? date = new DateTime(2014, 1, 1);
                DateTime date2 = date.GetValueOrDefault();
                DateTime? date3 = date2;

                Console.WriteLine("GetValueOrDefault(): Date: {0}", date3.GetValueOrDefault());
            */
            DateTime? date = null;
            // Short form...
            DateTime date2 = date ?? DateTime.Today;
            DateTime date3 = (date != null) ? date.GetValueOrDefault() : DateTime.Today;

            /* Long form...
                if (date != null)
                    date2 = date.GetValueOrDefault();
                else
                    date2 = DateTime.Today;
            */

            Console.WriteLine("Date: {0}", date2);
        }
    }
}
