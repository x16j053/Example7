using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Example7
{
    class Program
    {
        static void Main(string[] args)
        {
            //  整数型
            sbyte valueSByte = -100;
            byte valueByte = 100;
            short valueShort = -20000;
            ushort valueUShort = 50000;
            int valueInt = -1000000000;
            uint valueUInt = 4000000000;
            long valueLong = -800000000000;
            ulong valueULong = 9000000000000000000;

            //  実数型
            float valueFloat = 3.1415F;
            double valueDouble = 3.1415926535;

            //文字型、文字列型
            char valueChar = 'A';
            string valueString = "C# PROGRAM";

            //論理型
            bool valueBool = true;

            Console.WriteLine("sbyte　：{0}",valueSByte);
            Console.WriteLine("byte 　：{0}", valueByte);
            Console.WriteLine("short　：{0}", valueShort);
            Console.WriteLine("ushort ：{0}", valueUShort);
            Console.WriteLine("int　　：{0}", valueInt);
            Console.WriteLine("uint 　：{0}", valueUInt);
            Console.WriteLine("long 　：{0}", valueLong);
            Console.WriteLine("ulong　：{0}", valueULong);
            Console.WriteLine("flort　：{0}", valueFloat);
            Console.WriteLine("double ：{0}", valueDouble);
            Console.WriteLine("char 　：{0}", valueChar);
            Console.WriteLine("string ：{0}", valueString);
            Console.WriteLine("bool 　：{0}", valueBool);
        }
    }
}
