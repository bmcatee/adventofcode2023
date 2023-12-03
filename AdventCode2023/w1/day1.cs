using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdventCode2023.w1
{
    internal class day1
    {
        public static void ReadFromFile()
        {
            string folder = Environment.CurrentDirectory;
            string inputfile = "coordsfile.txt";
            int newint1 = 0;

            using (var sr = new StreamReader(Path.Combine(folder, inputfile)))
            {
                string line = sr.ReadLine();
                while (line != null)
                {
                    char[] newarray1 = ConvertStringToCharArray(line);
                    string newstring1 = CheckForNumberWords(newarray1);
                    newint1 += ParseStringsIntoCoords(newstring1);
                    line = sr.ReadLine();
                }
            }
            Console.WriteLine($"Final answer: {newint1}");
            Console.ReadLine();
        }


        public static string CheckForNumberWords(char[] linechars)
        {
            string finalline = "";
            bool foo = false;
            for (int i = 0; i < linechars.Length; i++)
            {
                for (int j = 1; j < 10; j++)
                {
                    (int nwi, char[] nwa) = ConvertNumberWord(j);

                    if (nwa[0] == linechars[i])
                    {
                        int newcheck = linechars.Length - i;
                        if (newcheck >= nwa.Length)
                        {
                            char[] newchar = new char[nwa.Length];
                            for (int k = 0; k < nwa.Length; k++)
                            {
                                newchar[k] = linechars[i + k];
                            }

                            string x = new string(newchar);
                            string num = new string(nwa);
                            int check = string.Compare(x, num);

                            if (check == 0)
                            {
                                finalline += nwi;
                                foo = true;
                            }
                        }
                    }
                }
                if (foo == false)
                {
                    finalline += linechars[i];
                }
                foo = false;
            }
            return finalline;
        }

        public static int ParseStringsIntoCoords(string line)
        {

            char coordchar1 = '0';
            char coordchar2 = '0';
            bool checker1 = false;


            char[] chars = new char[line.Length];

            for (int i = 0; i < chars.Length; i++)
            {
                chars[i] = line[i];
            }

            for (int i = 0; i < chars.Length; i++)
            {
                bool result;
                char ch1 = chars[i];
                result = Char.IsNumber(ch1);

                if (result == true)
                {
                    if (checker1 == false)
                    {
                        coordchar1 = ch1;
                        coordchar2 = ch1;
                        checker1 = true;
                    }
                    else if (checker1 == true)
                    {
                        coordchar2 = ch1;
                    }
                }
            }
            string s1 = Char.ToString(coordchar1);
            string s2 = Char.ToString(coordchar2);
            string s3 = s1 + s2;
            int final = int.Parse(s3);
            return final;

        }
        public static char[] ConvertStringToCharArray(string line)
        {
            char[] chars = new char[line.Length];

            for (int i = 0; i < chars.Length; i++)
            {
                chars[i] = line[i];
            }
            return chars;
        }
        public static (int, char[]) ConvertNumberWord(int numword)
        {
            string s = "";
            int i = 0;
            char[] c0 = new char[0];
            switch (numword)
            {
                case 0:
                    return (i, c0);
                case 1:
                    s = "one";
                    i = 1;
                    char[] c1 = ConvertStringToCharArray(s);
                    return (i, c1);
                case 2:
                    s = "two";
                    i = 2;
                    char[] c2 = ConvertStringToCharArray(s);
                    return (i, c2);
                case 3:
                    s = "three";
                    i = 3;
                    char[] c3 = ConvertStringToCharArray(s);
                    return (i, c3);
                case 4:
                    s = "four";
                    i = 4;
                    char[] c4 = ConvertStringToCharArray(s);
                    return (i, c4);
                case 5:
                    s = "five";
                    i = 5;
                    char[] c5 = ConvertStringToCharArray(s);
                    return (i, c5);
                case 6:
                    s = "six";
                    i = 6;
                    char[] c6 = ConvertStringToCharArray(s);
                    return (i, c6);
                case 7:
                    s = "seven";
                    i = 7;
                    char[] c7 = ConvertStringToCharArray(s);
                    return (i, c7);
                case 8:
                    s = "eight";
                    i = 8;
                    char[] c8 = ConvertStringToCharArray(s);
                    return (i, c8);
                case 9:
                    s = "nine";
                    i = 9;
                    char[] c9 = ConvertStringToCharArray(s);
                    return (i, c9);
                default:
                    return (i, c0); ;
            }
        }
    }
}
