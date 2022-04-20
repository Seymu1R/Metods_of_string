using System;
using System.Globalization;

namespace METHOD_FOR_STRINGS
{
    class Program
    {
        static void Main(string[] args)
        {
            
            MetHod_for_string("bU tasKI metHodla yAzmAliSiz");

        }

        public static void MetHod_for_string(string sentence ){
            string result;
           TextInfo new_word = CultureInfo.CurrentCulture.TextInfo;
            result = sentence.ToLower();
            result = new_word.ToTitleCase(sentence);
            Console.WriteLine(result);

            
        }

    }

}
