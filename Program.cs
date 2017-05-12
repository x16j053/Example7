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

            Console.WriteLine("{1}：{0}",valueSByte,valueSByte.GetType().Name);
            Console.WriteLine("{1}：{0}", valueByte, valueByte.GetType().Name);
            Console.WriteLine("{1}：{0}", valueShort, valueShort.GetType().Name);
            Console.WriteLine("{1}：{0}", valueUShort, valueUShort.GetType().Name);
            Console.WriteLine("{1}：{0}", valueInt, valueInt.GetType().Name);
            Console.WriteLine("{1}：{0}", valueUInt, valueUInt.GetType().Name);
            Console.WriteLine("{1}：{0}", valueLong, valueLong.GetType().Name);
            Console.WriteLine("{1}：{0}", valueULong, valueULong.GetType().Name);
            Console.WriteLine("{1}：{0}", valueFloat, valueFloat.GetType().Name);
            Console.WriteLine("{1}：{0}", valueDouble, valueDouble.GetType().Name);
            Console.WriteLine("{1}：{0}", valueChar, valueChar.GetType().Name);
            Console.WriteLine("{1}：{0}", valueString, valueString.GetType().Name);
            Console.WriteLine("{1}：{0}", valueBool, valueBool.GetType().Name);
        }
    }
}
