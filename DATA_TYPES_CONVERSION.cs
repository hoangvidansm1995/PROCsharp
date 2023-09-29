using System;
using System.ComponentModel.DataAnnotations;
using System.Globalization;
using System.Reflection.Metadata.Ecma335;
using System.Runtime.CompilerServices;
using Microsoft.VisualBasic;
using System.Text;
namespace DataTypesConversion
{
    public class Data_Types_Conversion
    {
        public static int Add(int x, int y)
        {
        return x + y;
        }
        public static void NarrowingAttempt()
        {
            byte myByte = 0;
            int myInt = 200;
            // Explicitly cast the int into a byte (no loss of data).
            myByte = (byte)myInt;
            Console.WriteLine("Value of myByte: {0}", myByte);
            Console.WriteLine("***** Fun with type conversions *****");
            short numb1 = 30000, numb2 = 30000;
            // Explicitly cast the int into a short (and allow loss of data).
            short answer = (short)Add(numb1, numb2);
            Console.WriteLine("{0} + {1} = {2}",
            numb1, numb2, answer);
            Console.ReadLine();
        }
        //check if overflow has occured
        public static void ProcessBytes()
        {
            byte b1 = 100;
            byte b2 = 250;
            // This time, tell the compiler to add CIL code
            // to throw an exception if overflow/underflow takes place.
            try
            {
                byte sum = checked((byte)Add(b1, b2));
                Console.WriteLine("sum = {0}", sum);
            }
            catch (OverflowException ex)
            {
                Console.WriteLine(ex.Message);
            }
        }
        public static void DeclareImplicitVars()
        {
            // Implicitly typed local variables.
            var myInt = 0;
            var myBool = true;
            var myString = "Time, marches on...";
            // Print out the underlying type.
            Console.WriteLine("myInt is a: {0}", myInt.GetType().Name);
            Console.WriteLine("myBool is a: {0}", myBool.GetType().Name);
            Console.WriteLine("myString is a: {0}", myString.GetType().Name);
        }
    }
}