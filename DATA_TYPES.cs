using System;
using System.ComponentModel.DataAnnotations;
using System.Globalization;
using System.Reflection.Metadata.Ecma335;
using System.Runtime.CompilerServices;
using Microsoft.VisualBasic;
using System.Text;
namespace Data_Types
{
    class Data_Types
    {
        public static void ObjectFunctionality()
        {
            Console.WriteLine("=> System.Object Functionality:");
            // A C# int is really a shorthand for System.Int32,
            // which inherits the following members from System.Object.
            Console.WriteLine("12.GetHashCode() = {0}", 12.GetHashCode());
            Console.WriteLine("12.Equals(23) = {0}", 12.Equals(23));
            Console.WriteLine("12.ToString() = {0}", 12.ToString());
            Console.WriteLine("12.GetType() = {0}", 12.GetType());
            Console.WriteLine();
        }
        public static void DataTypeFunctionality()
        {
            Console.WriteLine("=> Data type Functionality:");
            Console.WriteLine("Max of int: {0}", int.MaxValue);
            Console.WriteLine("Min of int: {0}", int.MinValue);
            Console.WriteLine("Max of double: {0}", double.MaxValue);
            Console.WriteLine("Min of double: {0}", double.MinValue);
            Console.WriteLine("double.Epsilon: {0}", double.Epsilon);
            Console.WriteLine("double.PositiveInfinity: {0}",
            double.PositiveInfinity);
            Console.WriteLine("double.NegativeInfinity: {0}",
            double.NegativeInfinity);
            Console.WriteLine();
        }
        public static void CharFunctionality()
        {
            Console.WriteLine("=> char type Functionality:");
            char myChar = 'a';
            Console.WriteLine("char.IsDigit('a'): {0}", char.IsDigit(myChar));
            Console.WriteLine("char.IsLetter('a'): {0}", char.IsLetter(myChar));
            Console.WriteLine("char.IsWhiteSpace('Hello There', 5): {0}",
            char.IsWhiteSpace("Hello There", 5));
            Console.WriteLine("char.IsWhiteSpace('Hello There', 6): {0}",
            char.IsWhiteSpace("Hello There", 6));
            Console.WriteLine("char.IsPunctuation('?'): {0}",
            char.IsPunctuation('?'));
            Console.WriteLine();
        }
        public static void ParseFromStrings()
        {
            Console.WriteLine("=> Data type parsing:");
            bool b = bool.Parse("True");
            Console.WriteLine("Value of b: {0}", b);
            double d = double.Parse("99.884");
            Console.WriteLine("Value of d: {0}", d);
            int i = int.Parse("8");
            Console.WriteLine("Value of i: {0}", i);
            char c = Char.Parse("w");
            Console.WriteLine("Value of c: {0}", c);
            Console.WriteLine();
        }
        public static void ParseFromStringsWithTryParse()
        {
            Console.WriteLine("=> Data type parsing with TryParse:");
            if (bool.TryParse("True", out bool b))
                {
                    Console.WriteLine("Value of b: {0}", b);
                }
            else
                {
                    Console.WriteLine("Default value of b: {0}", b);
                }
            string value = "Hello";
            if (double.TryParse(value, out double d))
                {
                    Console.WriteLine("Value of d: {0}", d);
                }
            else
                {
                    Console.WriteLine("Failed to convert the input ({0}) to a double and the variable was assigned the default {1}", value,d);
                }
                Console.WriteLine();
        }
        public static void UseDatesAndTimes()
        {
            Console.WriteLine("=> Dates and Times:");
            // This constructor takes (year, month, day).
            DateTime dt = new DateTime(2015, 10, 17);
            // What day of the month is this?
            Console.WriteLine("The day of {0} is {1}", dt.Date, dt.DayOfWeek);
            // Month is now December.
            dt = dt.AddMonths(2);
            Console.WriteLine("Daylight savings: {0}", dt.IsDaylightSavingTime());
            Console.WriteLine(dt);
            // This constructor takes (hours, minutes, seconds).
            TimeSpan ts = new TimeSpan(4, 30, 0);
            Console.WriteLine(ts);
            // Subtract 15 minutes from the current TimeSpan and
            // print the result.
            Console.WriteLine(ts.Subtract(new TimeSpan(0, 15, 0)));
            Console.WriteLine("=> Dates and Times:");
            DateOnly d = new DateOnly(2021,07,21);
            Console.WriteLine(d);
            TimeOnly t = new TimeOnly(13,30,0,0);
            Console.WriteLine(t);
        }
        public static void DigitSeparators()
        {
            Console.WriteLine("=> Use Digit Separators:");
            Console.Write("Integer:");
            Console.WriteLine(123_456);
            Console.Write("Long:");
            Console.WriteLine(123_456_789L);
            Console.Write("Float:");
            Console.WriteLine(123_456.1234F);
            Console.Write("Double:");
            Console.WriteLine(123_456.12);
            Console.Write("Decimal:");
            Console.WriteLine(123_456.12M);
        }
        public static void BinaryLiterals()
        {
            //Updated in 7.2, Binary can begin with _
            Console.WriteLine("=> Use Binary Literals:");
            Console.WriteLine("Sixteen: {0}",0b_0001_0000);
            Console.WriteLine("Thirty Two: {0}",0b_0010_0000);
            Console.WriteLine("Sixty Four: {0}",0b_0100_0000);
        }
        public static void BasicStringFunctionality()
        {
            Console.WriteLine("=> Basic String functionality:");
            string firstName = "Freddy";
            Console.WriteLine("Value of firstName: {0}", firstName);
            Console.WriteLine("firstName has {0} characters.", firstName.Length);
            Console.WriteLine("firstName in uppercase: {0}", firstName.ToUpper());
            Console.WriteLine("firstName in lowercase: {0}", firstName.ToLower());
            Console.WriteLine("firstName contains the letter y?: {0}",
            firstName.Contains("y"));
            Console.WriteLine("New first name: {0}", firstName.Replace("dy", ""));
            Console.WriteLine();
        }
        public static void StringConcatenation()
        {
            Console.WriteLine("=> String concatenation:");
            string s1 = "Programming the ";
            string s2 = "PsychoDrill (PTP)";
            string s3 = s1 + s2;
            string s4 = String.Concat(s1,s2);
            //operator + = String.Concat(s1,s2)
            Console.WriteLine(s3);
            Console.WriteLine(s4);
            Console.WriteLine();
        }
        public static void StringInterpolation()
        {
            Console.WriteLine("=> String interpolation:\a");
            // Some local variables we will plug into our larger string
            int age = 4;
            string name = "Soren";
            // Using curly-bracket syntax.
            string greeting = String.Format("Hello {0} you are {1} years old.", name.ToUpper(), age);
            Console.WriteLine(greeting);
            // Using string interpolation
            string greeting2 = $"Hello {name.ToUpper()} you are {age} years old.";
            Console.WriteLine(greeting2);
        }
        public static void StringEquality()
        {
            Console.WriteLine("=> String equality:");
            string s1 = "Hello!";
            string s2 = "Yo!";
            Console.WriteLine("s1 = {0}", s1);
            Console.WriteLine("s2 = {0}", s2);
            Console.WriteLine();
            // Test these strings for equality.
            Console.WriteLine("s1 == s2: {0}", s1 == s2);
            Console.WriteLine("s1 == Hello!: {0}", s1 == "Hello!");
            Console.WriteLine("s1 == HELLO!: {0}", s1 == "HELLO!");
            Console.WriteLine("s1 == hello!: {0}", s1 == "hello!");
            Console.WriteLine("s1.Equals(s2): {0}", s1.Equals(s2));
            Console.WriteLine("Yo!.Equals(s2): {0}", "Yo!".Equals(s2));
            Console.WriteLine();
            System.String.Compare(s1,s2);
        }
        public static void StringsAreImmutable2()
        {
            Console.WriteLine("=> Immutable Strings 2:\a");
            string s2 = "My other string";
            s2 = "New string value";
            Console.WriteLine(s2);
        }
        public static void FunWithStringBuilder()
        {
            //a StringBuilder is only able to initially hold a string of 16 characters or fewer 
            // a Stringbuilder can make changes on a string. .ToString() can convert a string builder to a string but its not neccesary.
            Console.WriteLine("=> Using the StringBuilder:");
            StringBuilder sb = new StringBuilder("**** Fantastic Games ****");
            sb.Append("\n");
            sb.AppendLine("Half Life");
            sb.AppendLine("Morrowind");
            sb.AppendLine("Deus Ex" + "2");
            sb.AppendLine("System Shock");
            sb.Replace("2", " Invisible War");
            Console.WriteLine("sb has {0} chars.", sb.Length);
            Console.WriteLine(sb);
            // Make a StringBuilder with an initial size of 256.
            StringBuilder sb1 = new StringBuilder("**** Fantastic Games ****", 256);
            Console.WriteLine(sb1.Length);
        }
        
    }
}