﻿using System;

namespace Sadr_Tools.Utility
{
    public static class NumericMethods
    {
        public static int ReturnRandomNumber()
        {
            GeneralMethod.Sleep();
            return new Random().Next();
        }

        public static int ReturnRandomNumber(int max)
        {
            GeneralMethod.Sleep();
            return new Random().Next(max);
        }

        public static int ReturnRandomNumber(int min, int max)
        {
            GeneralMethod.Sleep();

            return new Random().Next(min, max);
        }

        public static void ReturnRandomNumber(byte[] numbers)
        {
            GeneralMethod.Sleep();

            new Random().NextBytes(numbers);
        }

        public static void ReturnRandomNumber(int[] numbers)
        {
            for (int i = 0; i < numbers.Length; i++)
            {
                numbers[i] = ReturnRandomNumber();
            }
        }

        internal static string PartsName(int part)
        {
            switch (part)
            {
                case 1:
                    return "هزار";

                case 2:
                    return "میلیون";

                case 3:
                    return "میلیارد";

                default:
                    return "";
            }
        }

    }
}
