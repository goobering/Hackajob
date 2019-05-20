using System;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;

namespace KataLib
{
    public static class KataService
    {
        private static HttpClient Client = new HttpClient();

        public static async Task<string> GetResponseStringAsync(string url)
        {
            var response = await Client.GetAsync(url);
            var contents = await response.Content.ReadAsStringAsync();

            return contents;
        }

        public static string EnglishToMorse(string input)
        {
            var inputLowered = input.ToLower();
            var resultBuilder = new StringBuilder();
            
            for(int i = 0; i < input.Length; i++)
            {
                if(i == ' ')
                {   
                    resultBuilder.Append(KataConstants.EnglishToMorse[inputLowered[i]]);
                    continue;
                }

                resultBuilder.Append(KataConstants.EnglishToMorse[inputLowered[i]] + " ");
            }

            return resultBuilder.ToString();
        }

        public static string MorseToEnglish(string input)
        {
            if(!IsMorse(input))
            {
                return "Invalid Morse Code Or Spacing";
            }

            var resultBuilder = new StringBuilder();
            var inputWords = input.Split(new string[]{"   "}, StringSplitOptions.None);
            for(int i = 0; i < inputWords.Length; i++)
            {
                var morseChars = inputWords[i].Split(' ');
                foreach(var morseChar in morseChars)
                {
                    resultBuilder.Append(KataConstants.MorseToEnglish[morseChar]);
                }

                if(i < inputWords.Length - 1)
                {
                    resultBuilder.Append(" ");
                }
            }

            return resultBuilder.ToString();
        }

        private static bool IsMorse(string input)
        {
            var isMorse = input.All(c => ".- ".Contains(c));
            var splitInput = input.Split(new string[]{"   "}, StringSplitOptions.None);
            return isMorse;
        }
    }
}
