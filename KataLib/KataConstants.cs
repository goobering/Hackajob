using System.Collections.Generic;

namespace KataLib
{
    public static class KataConstants
    {
        public static readonly IDictionary<string, string> Endpoints;
        public static readonly IDictionary<char, string> EnglishToMorse;
        public static readonly IDictionary<string, char> MorseToEnglish;

        static KataConstants()
        {
            Endpoints = new Dictionary<string, string>();
            Endpoints.Add("peopleSearch", @"https://challenges.hackajob.co/swapi/api/people/?search=");
            Endpoints.Add("footballResults", @"https://raw.githubusercontent.com/openfootball/football.json/master/2014-15/en.1.json");

            EnglishToMorse = new Dictionary<char, string>();
            EnglishToMorse.Add('a', ".-");
            EnglishToMorse.Add('b', "-...");
            EnglishToMorse.Add('c', "-.-.");
            EnglishToMorse.Add('d', "-..");
            EnglishToMorse.Add('e', ".");
            EnglishToMorse.Add('f', "..-.");
            EnglishToMorse.Add('g', "--.");
            EnglishToMorse.Add('h', "....");
            EnglishToMorse.Add('i', "..");
            EnglishToMorse.Add('j', ".---");
            EnglishToMorse.Add('k', "-.-");
            EnglishToMorse.Add('l', ".-..");
            EnglishToMorse.Add('m', "--");
            EnglishToMorse.Add('n', "-.");
            EnglishToMorse.Add('o', "---");
            EnglishToMorse.Add('p', ".--.");
            EnglishToMorse.Add('q', "--.-");
            EnglishToMorse.Add('r', ".-.");
            EnglishToMorse.Add('s', "...");
            EnglishToMorse.Add('t', "-");
            EnglishToMorse.Add('u', "..-");
            EnglishToMorse.Add('v', "...-");
            EnglishToMorse.Add('w', ".--");
            EnglishToMorse.Add('x', "-..-");
            EnglishToMorse.Add('y', "-.--");
            EnglishToMorse.Add('z', "--..");
            EnglishToMorse.Add('0', "-----");
            EnglishToMorse.Add('1', ".----");
            EnglishToMorse.Add('2', "..---");
            EnglishToMorse.Add('3', "...--");
            EnglishToMorse.Add('4', "....-");
            EnglishToMorse.Add('5', ".....");
            EnglishToMorse.Add('6', "-....");
            EnglishToMorse.Add('7', "--...");
            EnglishToMorse.Add('8', "---..");
            EnglishToMorse.Add('9', "----.");
            EnglishToMorse.Add('&', ".-...");
            EnglishToMorse.Add('\'', ".----.");
            EnglishToMorse.Add('@', ".--.-.");
            EnglishToMorse.Add(')', "-.--.-");
            EnglishToMorse.Add('(', "-.--.");
            EnglishToMorse.Add(':', "---...");
            EnglishToMorse.Add(',', "--..--");
            EnglishToMorse.Add('=', "-...-");
            EnglishToMorse.Add('!', "-.-.--");
            EnglishToMorse.Add('.', ".-.-.-");
            EnglishToMorse.Add('-', "-....-");
            EnglishToMorse.Add('+', ".-.-.");
            EnglishToMorse.Add('\"', ".-..-.");
            EnglishToMorse.Add('?', "..--..");
            EnglishToMorse.Add('/', "-..-.");
            EnglishToMorse.Add(' ', "   ");

            MorseToEnglish = new Dictionary<string, char>();
            MorseToEnglish.Add(".-", 'a');
            MorseToEnglish.Add("-...", 'b');
            MorseToEnglish.Add("-.-.", 'c');
            MorseToEnglish.Add("-..", 'd');
            MorseToEnglish.Add(".", 'e');
            MorseToEnglish.Add("..-.", 'f');
            MorseToEnglish.Add("--.", 'g');
            MorseToEnglish.Add("....", 'h');
            MorseToEnglish.Add("..", 'i');
            MorseToEnglish.Add(".---", 'j');
            MorseToEnglish.Add("-.-", 'k');
            MorseToEnglish.Add(".-..", 'l');
            MorseToEnglish.Add("--", 'm');
            MorseToEnglish.Add("-.", 'n');
            MorseToEnglish.Add("---", 'o');
            MorseToEnglish.Add(".--.", 'p');
            MorseToEnglish.Add("--.-", 'q');
            MorseToEnglish.Add(".-.", 'r');
            MorseToEnglish.Add("...", 's');
            MorseToEnglish.Add("-", 't');
            MorseToEnglish.Add("..-", 'u');
            MorseToEnglish.Add("...-", 'v');
            MorseToEnglish.Add(".--", 'w');
            MorseToEnglish.Add("-..-", 'x');
            MorseToEnglish.Add("-.--", 'y');
            MorseToEnglish.Add("--..", 'z');
            MorseToEnglish.Add("-----", '0');
            MorseToEnglish.Add(".----", '1');
            MorseToEnglish.Add("..---", '2');
            MorseToEnglish.Add("...--", '3');
            MorseToEnglish.Add("....-", '4');
            MorseToEnglish.Add(".....", '5');
            MorseToEnglish.Add("-....", '6');
            MorseToEnglish.Add("--...", '7');
            MorseToEnglish.Add("---..", '8');
            MorseToEnglish.Add("----.", '9');
            MorseToEnglish.Add(".-...", '&');
            MorseToEnglish.Add(".----.", '\'');
            MorseToEnglish.Add(".--.-.", '@');
            MorseToEnglish.Add("-.--.-", ')');
            MorseToEnglish.Add("-.--.", '(');
            MorseToEnglish.Add("---...", ':');
            MorseToEnglish.Add("--..--", ',');
            MorseToEnglish.Add("-...-", '=');
            MorseToEnglish.Add("-.-.--", '!');
            MorseToEnglish.Add(".-.-.-", '.');
            MorseToEnglish.Add("-....-", '-');
            MorseToEnglish.Add(".-.-.", '+');
            MorseToEnglish.Add(".-..-.", '\"');
            MorseToEnglish.Add("..--..", '?');
            MorseToEnglish.Add("-..-.", '/');
            MorseToEnglish.Add("   ", ' ');
        }
    }
}