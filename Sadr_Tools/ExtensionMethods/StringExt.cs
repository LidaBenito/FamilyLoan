using Sadr_Tools.Utility;
using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Security.Cryptography;
using System.Text;
using System.Text.RegularExpressions;

namespace Sadr_Tools.ExtensionMethods
{
    public static class StringExt
    {
        #region [ Private Methods ]
        /// <summary>
        /// تک رقمی - برگرداندن عبارت متنی یک عدد
        /// </summary>
        private static string OneDigitToText(this string str, int order)
        {
            switch (order)
            {
                case 0:
                    {
                        switch (str)
                        {
                            case "0":
                                return "";

                            case "1":
                                return "یک";

                            case "2":
                                return "دو";

                            case "3":
                                return "سه";

                            case "4":
                                return "چهار";

                            case "5":
                                return "پنج";

                            case "6":
                                return "شش";

                            case "7":
                                return "هفت";

                            case "8":
                                return "هشت";

                            case "9":
                                return "نه";

                            default:
                                return "";
                        }
                    }

                case 1:
                    {
                        switch (str)
                        {
                            case "0":
                                return "";

                            case "1":
                                return "";

                            case "2":
                                return "بیست";

                            case "3":
                                return "سی";

                            case "4":
                                return "چهل";

                            case "5":
                                return "پنجاه";

                            case "6":
                                return "شصت";

                            case "7":
                                return "هفتاد";

                            case "8":
                                return "هشتاد";

                            case "9":
                                return "نود";

                            default:
                                return "";

                        }
                    }

                case 2:
                    {
                        switch (str)
                        {
                            case "0":
                                return "";

                            case "1":
                                return "یکصد";

                            case "2":
                                return "دویست";

                            case "3":
                                return "سیصد";

                            case "4":
                                return "چهارصد";

                            case "5":
                                return "پانصد";

                            case "6":
                                return "ششصد";

                            case "7":
                                return "هفتصد";

                            case "8":
                                return "هشتصد";

                            case "9":
                                return "نهصد";

                            default:
                                return "";

                        }
                    }
                default:
                    return "";
            }
        }

        /// <summary>
        /// دو رقمی - برگرداندن عبارت متنی یک عدد
        /// </summary>
        private static string TwoDigitToText(this string str)
        {
            switch (str)
            {
                case "10":
                    return "ده";

                case "11":
                    return "یازده";

                case "12":
                    return "دوازده";

                case "13":
                    return "سیزده";

                case "14":
                    return "چهارده";

                case "15":
                    return "پانزده";

                case "16":
                    return "شانزده";

                case "17":
                    return "هفده";

                case "18":
                    return "هجده";

                case "19":
                    return "نوزده";

                default:
                    return "";
            }
        }

        private static T EnumParse<T>(this string str, bool ignorecase = true)
        {
            if (str == null)
                throw new ArgumentNullException(CommonConsts.Messages.Exception.InvalidObject);

            str = str.Trim();

            if (str.Length == 0)
                throw new ArgumentException(CommonConsts.Messages.Exception.InvalidObject);

            Type t = typeof(T);

            if (!t.IsEnum)
                throw new ArgumentException(CommonConsts.Messages.Exception.InvalidObject);

            return (T)Enum.Parse(t, str, ignorecase);
        }

        private static IEnumerable<string> SplitCamelCase(this string source)
        {
            const string pattern = @"[A-Z][a-z]*|[a-z]+|\d+";
            var matches = Regex.Matches(source, pattern);
            foreach (Match match in matches)
            {
                yield return match.Value;
            }
        }


        #endregion

        public static string ToUpperFirstLetter(this string str)
        {
            if (!str.IsNullOrEmpty())
                return str.Substring(0, 1).ToUpper() + str.Substring(1);
            return str;
        }

        public static string RemoveLastChar(this string str)
        {
            if (!str.IsNullOrEmpty() && str.Length >= 1)
                return str.Substring(0, str.Length - 1);
            return str;
        }

        public static bool IsNumber(this string str)
        {
            for (int i = 0; i < str.Length; i++)
                if (!char.IsDigit(str[i]))
                    return false;
            return true;
        }

        /// <summary>
        /// نمایش اعداد با فونت فارسی
        /// </summary>
        /// <param name="str">متن</param>
        public static string NumberToPersianFont(this string str)
        {
            if (!str.IsNullOrEmpty())
            {
                for (int i = 0; i < str.Length; i++)
                {
                    if (str[i] >= '0' && str[i] <= '9')
                    {
                        if ((str[i]) < 1776)
                        {
                            char ch = Convert.ToChar(str[i] + 1776 - '0');
                            str = str.Replace(str[i], ch);
                        }
                    }
                }
            }
            return str;
        }

        public static string ToEnglishNumber(this string str)
        {
            for (int i = 0; i < str.Length; i++)
            {
                if (str[i] >= 1776 && str[i] <= 1785)
                {
                    char ch = Convert.ToChar(str[i] - 1776 + '0');
                    str = str.Replace(str[i], ch);
                }
            }
            return str;
        }

        /// <summary>
        /// برگرداندن عبارت متنی یک عدد
        /// </summary>
        /// <param name="str">ورودی</param>
        public static string NumberToPersianText(this string str)
        {
            StringBuilder output = new StringBuilder();
            if (!str.IsNullOrEmpty())
            {
                int i = str.Length - 1;
                int j = 0;
                int part = 0;
                while (i >= 0)
                {
                    string temp = str[i].ToString();
                    if ((i != 0) && (j == 0) & (str[i - 1] == '1'))
                    {
                        temp = str.Substring(i - 1, 2);
                        temp = temp.TwoDigitToText();
                        output.Insert(0, temp);
                        if ((i != 0) & ((i - 1) != 0))
                            output.Insert(0, " و ");
                        i -= 2;
                        j++;
                    }
                    else
                    {
                        temp = temp.OneDigitToText(j);
                        if (temp != "")
                        {
                            output.Insert(0, temp);
                            if (i != 0)
                                output.Insert(0, " و ");
                        }
                        i--;
                    }
                    if (j == 2)
                    {
                        part++;
                        if (i != -1)
                            if (i == 1)
                            {
                                output.Insert(0, " " + NumericMethods.PartsName(part) + " ");
                            }
                            else
                            {
                                if (i == 0)
                                {
                                    output.Insert(0, " " + NumericMethods.PartsName(part) + " ");
                                }
                                else
                                {
                                    if (str.Substring(i - 2, 3) != "000")
                                        output.Insert(0, " " + NumericMethods.PartsName(part) + " ");
                                }
                            }
                        j = 0;
                    }
                    else
                        j++;
                }
            }
            return output.ToString();
        }

        /// <summary>
        /// تبدیل حروف عربی به فارسی
        /// </summary>
        public static string ArabicToPersianLetter(this string str)
        {
            string result = null;

            foreach (char c in str)
            {
                //کد یونیکد "ک" عربی = 1603
                //کد یونیکد "ی" عربی = 1610
                //کد یونیکد "ک" فارسی = 1705
                //کد یونیکد "ى" فارسی = 1740
                int ascii = c;
                switch (ascii)
                {
                    case 1577:
                        result = $"{result}{((char)1578)}";
                        break;

                    case 1610:
                        result = $"{result}{((char)1740)}";
                        break;

                    case 1603:
                        result = $"{result}{((char)1705)}";
                        break;

                    default:
                        result = $"{result}{((char)ascii)}";
                        break;
                }
            }

            return result;
        }

        /// <summary>
        /// برگرداندن عدد
        /// </summary>
        public static string ExtractNumber(this string str)
        {
            bool isNegative = false;
            string temp = "";
            str = str.Trim();

            if (str[0] == '-' || (str[0] == '(' && str[str.Length - 1] == ')'))
                isNegative = true;

            char[] arr = new char[] { '0', '1', '2', '3', '4', '5', '6', '7', '8', '9', '.' };

            for (int i = 0; i < str.Length; i++)
            {
                foreach (char c in arr)
                {
                    if (str[i] == c)
                        temp += str[i];
                }
            }
            if (isNegative)
                temp = "-" + temp;

            return temp;
        }

        /// <summary>
        /// سه رقم سه رقم
        /// </summary>
        public static string ThousandSeprator(this string str)
        {
            str = str.Trim();
            string next = "";
            int counter = 0;
            string result = "";

            int pos = str.IndexOf(".");
            if (pos > -1)
            {
                next = str.Substring(pos, str.Length - pos);
                str = str.Substring(0, pos);
            }
            int pos2 = str.IndexOf("-");
            if (pos2 > -1)
            {
                str = str.Substring(1, str.Length - 1);
            }

            if (str.Length >= 4)
            {
                for (int i = str.Length - 1; i >= 0; i--)
                {
                    counter++;
                    if ((counter % 3) == 0 && counter != str.Length)
                        result = result.Insert(0, "," + str.Substring(i, 3));
                    else
                        if (counter == str.Length)
                        result = result.Insert(0, str.Substring(i, ((counter % 3) == 0 ? 3 : (counter % 3))));
                }
            }
            else
                result = str;

            result += next;

            if (pos2 > -1)
                result = "(" + result + ")";
            return result;
        }

        public static T EnumParse<T>(this string value)
        {
            return EnumParse<T>(value, false);
        }

        public static Stream ToStream(this string str)
        {
            var byteArray = str.GetBytes();
            return new MemoryStream(byteArray);
        }

        public static byte[] GetBytes(this string str)
        {
            return Encoding.UTF8.GetBytes(str);
        }

        public static void ToFile(this string str, string path, bool isAppend = true)
        {
            using (StreamWriter sw = new StreamWriter(path, isAppend))
            {
                sw.WriteLine(str);
            }
        }

        public static int Occurrence(this String instr, string search)
        {
            return System.Text.RegularExpressions.Regex.Matches(instr, search).Count;
        }

        public static bool IsMatchRegex(this string value, string pattern)
        {
            Regex regex = new Regex(pattern);
            return (regex.IsMatch(value));
        }

        public static bool IsValidEmailAddress(this string email)
        {
            return email.IsMatchRegex(@"^[\w-\.]+@([\w-]+\.)+[\w-]{2,4}$");
        }

        public static bool IsValidUrl(this string str)
        {
            return str.IsMatchRegex(@"http(s)?://([\w-]+\.)+[\w-]+(/[\w- ./?%&=]*)?");
        }

        public static bool IsNullOrEmpty(this string input)
        {
            return (input == null || input == "");
        }

        /// <summary>
        /// رمزگذاری با الگوریتم RSA
        /// </summary>
        /// <param name="str">عبارت مورد نظر</param>
        /// <param name="key">کلید</param>
        public static string EncryptViaRSA(this string str, string key)
        {
            if (str.IsNullOrEmpty())
                throw new ArgumentException(CommonConsts.Messages.Exception.InvalidObject);

            if (key.IsNullOrEmpty())
                throw new ArgumentException(CommonConsts.Messages.Exception.InvalidObject);

            // Cryptographic Service Provider (CSP)
            var cspp = new CspParameters
            {
                KeyContainerName = key
            };

            var rsa = new RSACryptoServiceProvider(cspp)
            {
                PersistKeyInCsp = true
            };

            byte[] bytes = rsa.Encrypt(str.GetBytes(), true);

            return bytes.BitToString();
        }

        /// <summary>
        /// دیکریپشن با الگوریتم RSA
        /// </summary>
        /// <param name="str">عبارت مورد نظر</param>
        /// <param name="key">کلید</param>
        public static string DecryptViaRSA(this string str, string key)
        {
            string result = null;

            if (str.IsNullOrEmpty())
                throw new ArgumentException(CommonConsts.Messages.Exception.InvalidObject);

            if (key.IsNullOrEmpty())
                throw new ArgumentException(CommonConsts.Messages.Exception.InvalidObject);

            try
            {
                var cspp = new CspParameters
                {
                    KeyContainerName = key
                };

                var rsa = new RSACryptoServiceProvider(cspp)
                {
                    PersistKeyInCsp = true
                };

                string[] decryptArray = str.Split('-');
                byte[] decryptByteArray = Array.ConvertAll(decryptArray, s =>
                {
                    return Convert.ToByte(byte.Parse(s, NumberStyles.HexNumber));
                });


                byte[] bytes = rsa.Decrypt(decryptByteArray, true);

                result = Encoding.UTF8.GetString(bytes);

            }

            catch (Exception ex)
            {
                ex.LogToTextFile("StringExt.DecryptViaRSA");
            }

            return result;
        }

        /// <summary>
        /// حرف اول هر کلمه بر اساس کاراکترهای خاص کپیتال میشود
        /// </summary>
        public static string ToUpperLowerNameVariant(this string str)
        {
            if (str.IsNullOrEmpty())
                return "";

            char[] charArray = str.ToLower().ToCharArray();

            bool nextUpper = true;

            for (int i = 0; i < (charArray.Length - 1); i++)
            {
                if (nextUpper)
                {
                    charArray[i] = char.Parse(charArray[i].ToString().ToUpper());
                    nextUpper = false;
                }
                else
                {
                    switch (charArray[i])
                    {
                        case ' ':
                        case '-':
                        case '.':
                        case ':':
                        case '\n':
                            nextUpper = true;
                            break;
                        default:
                            nextUpper = false;
                            break;
                    }
                }
            }
            return new string(charArray);
        }

        public static bool Like(this string value, string search)
        {
            return value.Contains(search) /*|| value.StartsWith(search) || value.EndsWith(search)*/;
        }

        /// <summary>
        /// بر اساس قرارداد کمل بین کلمات فاصله میندازد
        /// </summary>
        /// <param name="source"></param>
        /// <returns></returns>
        public static string CamelCaseToHumanCase(this string source)
        {
            var words = source.SplitCamelCase();
            return words.Join(" ");
        }

        /// <summary>
        /// ساختن هَش
        /// </summary>
        /// <param name="str">متن</param>
        /// <returns></returns>
        public static string MakeItHash(this string str)
        {
            using (SHA512 sha = SHA512.Create())
            {
                byte[] bytes = sha.ComputeHash(Encoding.UTF8.GetBytes(str));
                string result = bytes.BitToString();
                return result;
            }
        }


        /// <summary>
        ///  سالت و ترکیب آن با پسورد و هش کردن آن
        /// </summary>
        /// <param name="password">پسورد</param>
        /// <param name="salt">سالت</param>
        /// <returns></returns>
        public static string MakeSaltedHashPassword(this string password, string salt)
        {
            var saltedPass = salt + password;
            var hashedPass = saltedPass.MakeItHash();
            return hashedPass;
        }
        public static byte[] GetFile(this string fileName)
        {

            FileInfo fi = new FileInfo(fileName);
            byte[] fileDate;
            using (FileStream fs=new FileStream(fi.FullName,FileMode.Open,FileAccess.Read))
            {
                using (BinaryReader binaryReader=new BinaryReader(fs))
                {
                    fileDate = binaryReader.ReadBytes((int)fs.Length);
                }

            }
            return fileDate; 
        }
    }
}
