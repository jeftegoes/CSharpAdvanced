/* 
    - This expression don't be possible, because DateTime is a value type, and value type cannot be null.
    DateTime date = null;
*/


/*
    - Nullable is a generic structure defined in the System namespace.
    Nullable<DateTime> date = null;

    - Short expression.
    DateTime? date = null;

    int? number = null;

    Console.WriteLine("GetValueOrDefault(): Date: {0} Number: {1}", date.GetValueOrDefault(), number.GetValueOrDefault());
    Console.WriteLine("HasValue: Date: {0} Number: {1}", date.HasValue, number.HasValue);
    
    - In the expression below, this error will be returned: System.InvalidOperationException: Nullable object must have a value.
    - Because date.Value and number.Value don't has value
    Console.WriteLine("Value: {0} Number: {1}", date.Value, number.Value);
*/


/*
    DateTime? date = new DateTime(1991, 04, 10);
    DateTime date2 = date.GetValueOrDefault();
    DateTime? date3 = date2;

    Console.WriteLine("GetValueOrDefault(): Date: {0}", date3.GetValueOrDefault());
*/


/*
    - This example demonstrate how to use the Null Coalescence Operator.
    - Here don't use operator, is a long expression.
    DateTime? date = null;
    DateTime date2;

    if (date != null)
        date2 = date.GetValueOrDefault();
    else
        date2 = DateTime.Today;
*/

// This expression using Null Coalescence Operator ??
DateTime? date = null;
DateTime date2 = date ?? DateTime.Today;
DateTime date3 = (date != null) ? date.GetValueOrDefault() : DateTime.Today;
Console.WriteLine("Date: {0}", date2);
