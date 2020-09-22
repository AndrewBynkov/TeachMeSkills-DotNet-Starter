using System;

namespace TeachMeSkills.DotNet.Task8
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("!!!!TRANSLATOR Ru-Eng DEMO v1.0 Light!!!!\n");

            (string[] rusWords, string[] engWords) = Words();
            string inpRusWord = inpRussianWord(rusWords);
            string resultTranslator = TranslatorRuEng(rusWords, engWords, inpRusWord);

            Console.WriteLine($"{inpRusWord} - {resultTranslator}");
        }
        private static (string[] ruWords, string[] enWords) Words()
        {
            string[] enWords = new string[]
            {
                "degrees", "weather",
                "weatherman", "cloudy",
                "foggy","heat", "cold",
                "frosty", "hot", "cool","rain"
            };

            string[] ruWords = new string[]
            {
                "градусы", "погода",
                "метеоролог", "облачно",
                "туманный", "жара", "холод",
                "морозный", "горячий", "прохладный",
                "дождь"
            };
            return (ruWords, enWords);
        }

        private static string inpRussianWord(string[] ruWords)
        {
            int count = 0;
            string inpWordRu = null;

            while (count == 0)
            {
                Console.Write("Enter word in russian language (anything about weather ---> жара, холод, морозный): ");
                inpWordRu = Console.ReadLine().ToLower().Replace(" ", "");

                for (int i = 0; i < ruWords.Length; i++)
                {
                    if (inpWordRu == ruWords[i])
                    {
                        count++;
                        break;
                    }
                    else
                    {
                        continue;
                    }
                }
            }
            return inpWordRu;
        }

        private static string TranslatorRuEng(string[] ruWord, string[] enWords, string inpUserWord)
        {
            string translatedWord = null;

            for (int i = 0; i < ruWord.Length; i++)
            {
                if (inpUserWord == ruWord[i])
                {
                    translatedWord = enWords[i];
                }
            }
            return translatedWord;
        }
    }
}
