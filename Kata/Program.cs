using System;
using System.Threading.Tasks;
using KataLib;
using Newtonsoft.Json.Linq;
using System.Linq;

namespace Kata
{
    class Program
    {
        static async Task Main(string[] args)
        {
            // var result = KataService.EnglishToMorse("The wizard quickly jinxed the gnomes before they vaporized.");
            var result = KataService.MorseToEnglish("..- .... ..-. .-.. --- .-    ...-");
            
            Console.WriteLine(result);
        }
    }
}
