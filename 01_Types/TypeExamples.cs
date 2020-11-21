using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Runtime.Remoting.Channels;
using System.Security.Cryptography;

namespace _01_Types
{
    [TestClass]
    public class TypeExamples
    {
        [TestMethod]
        public void ValueTypes()
        {
            //-- Whole Numbers
            byte oneBytesWorth;
            oneBytesWorth = 255;
            short smallWholeNumber = 16;   //Int16
            Int16 anotherSmallNumber = 16;
            int wholeNumber = 32;   //Int32 
            long largeWholeNumber = 64;  //Int64

            int newNumber = oneBytesWorth;

            //--Decimals
            float floatExample = 1.234567f;
            double doubleExample = 1.237909d;
            decimal decimalExample = 1.7000000m;

            char letter = 'j';

            //--Operators
            int numOne = 17;
            int numTwo = 5;

            int sum = numOne + numTwo;
            Console.WriteLine(sum);
            int diff = numOne - numTwo;
            Console.WriteLine(diff);
            int prod = numOne * numTwo;
            Console.WriteLine(prod);
            int quot = numOne / numTwo;
            Console.WriteLine(quot);
            int remainder = numOne % numTwo;
            Console.WriteLine(remainder);

            Console.WriteLine("hello");
        }

        [TestMethod]
        public void ReferenceTypes()
        {
            //--Strings
            string stringExample = "This is a string.";
            string name = "Joshua";

            string declared;
            declared = "Now it's initialized.";

            //Formatting strings
            string concatenate = stringExample + " " + name;  //This is a string. Joshua
            string interpolate = $"{name}. Here is the string: {stringExample}"; //Joshua. Here is the string: This is a string.  
            Console.WriteLine(concatenate);
            Console.WriteLine(interpolate);

            //--Other Object Examples

            DateTime now = DateTime.Now;
            Console.WriteLine(now);


        }
    }
}
