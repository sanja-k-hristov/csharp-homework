using System;

namespace homework04
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Task 01");

            static void FunWithStrings(string myString)
            {

                static string StringReverse(string myString)
                {
                    char[] chars = myString.ToCharArray();
                    char[] result = new char[chars.Length];
                    for (int i = 0, j = myString.Length - 1; i < myString.Length; i++, j--)
                    {
                        result[i] = chars[j];
                    }
                    //return new string(result);
                    Console.Write("\nThe reverse string is : {0}\n", result);
                }
                static int NumberOfVowel(string myString)
                {


                    int vowel = 0;

                    for (int i = 0; i < myString.Length; i++)
                    {

                        if (myString[i] == 'a' || myString[i] == 'e' || myString[i] == 'i' || myString[i] == 'o' || myString[i] == 'u' || myString[i] == 'A' || myString[i] == 'E' || myString[i] == 'I' || myString[i] == 'O' || myString[i] == 'U')
                        {
                            vowel++;
                        }

                    }
                    //return vowel;
                    Console.Write("\nThe total number of vowel in the string is : {0}\n", vowel);
                }
                static string Palindrome(string myString)
                {
                    char[] ch = myString.ToCharArray();
                    Array.Reverse(ch);
                    string rev = new string(ch);
                    bool b = myString.Equals(rev, StringComparison.OrdinalIgnoreCase);
                    if (b == true)
                    {
                        Console.WriteLine("" + myString + " is a Palindrome!");
                    }
                    else
                    {
                        Console.WriteLine(" " + myString + " is not a Palindrome!");
                    }
                }
                static string LargestAndSmalestWord(string myString)
                {

                    string myString = myString + " ";
                    int len = myString.Length;
                    String k = " ", max = " ", min = " ";
                    char ch;

                    int p, max1 = 0;
                    int min1 = len;

                    for (int i = 0; i < len; i++)
                    {
                        ch = myString[i];
                        if (ch != ' ')
                        {
                            k = k + ch;
                        }
                        else
                        {
                            p = k.Length - 1;
                            if (p < min1)
                            {
                                min1 = p;
                                min = k;
                            }
                            if (p > max1)
                            {
                                max1 = p;
                                max = k;
                            }
                            k = " ";
                        }
                    }
                    Console.Write("Shortest Word = " + min + " Length of the Word = " + min1 + "\n");
                    Console.Write("Longest Word = " + max + " Length of the Word = " + max1);
                }
                static string CountOfWords(string myString)
                {

                    int l = 0;
                    int wrd = 1;

                    /* loop till end of string */
                    while (l <= myString.Length - 1)
                    {
                        /* check whether the current character is white space or new line or tab character*/
                        if (myString[l] == ' ' || myString[l] == '\n' || myString[l] == '\t')
                        {
                            wrd++;
                        }

                        l++;
                    }

                    Console.Write("Total number of words in the string is : {0}\n", wrd);
                }
                static char MostUsedCharacter(string myString)
                {
                    char resultChar = ' ';
                    int max = int.MinValue;
                    foreach (var grouping in myString.GroupBy(x => x))
                    {
                        int count = grouping.Count();
                        if (count > max)
                        {
                            max = count;
                            resultChar = grouping.Key;
                        }
                    }
                    Console.Write("The most used character (not space obviously) is : {0}\n", resultChar);
                    //return resultChar;
                }
            }

            Console.WriteLine("Input the string : ");
            string myString01 = Console.ReadLine();
            Console.WriteLine(FunWithStrings(myString01));

            Console.WriteLine("Task 02");


            static string RemoveExtraWhitespace(string str)
            {
                System.Text.StringBuilder sb = new System.Text.StringBuilder();
                var prevIsWhitespace = false;
                foreach (var ch in str)
                {
                    var isWhitespace = char.IsWhiteSpace(ch);
                    if (prevIsWhitespace && isWhitespace)
                    {
                        continue;
                    }
                    sb.Append(ch);
                    prevIsWhitespace = isWhitespace;
                }
                return sb.ToString();
            }
            string str01 = $"The    best Lorem  Ipsum Generator in all the  sea!   Heave this   scurvy copyfiller fer yar         next adventure  and cajol yar clients   into walking the plank with ev'ry layout!    Configure       above, then get yer pirate ipsum...own the high seas,    argh!";
            Console.WriteLine(RemoveExtraWhitespace(str: str01));
            Console.ReadLine();
        }
    }
}
