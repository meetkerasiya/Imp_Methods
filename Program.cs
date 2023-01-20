using System.Collections.Generic;
using System.Linq;
using static System.Net.Mime.MediaTypeNames;

namespace SingleValue1
{
    public static class SingleValue1
    {    
        public static string GetFirstSingleLetterWord(IEnumerable<string> words)
        {
            return words.First(word => word.Length == 1);    
        }    
        public static string GetLastWordWithHerInIt(IEnumerable<string> words)
        {
            return words.Last(word => word.Contains("her"));    
        } 
   
        public static string GetFifthWordIfItExists(IEnumerable<string> words)
        {
            return words.ElementAtOrDefault(4);    
        }    
        public static string GetLastWordIfAny(IEnumerable<string> words)
        {
            if (words.Any() == true)
                return words.Last();
            else
                return null;    
        }
        public static void Main(string[] args)
        {
            IEnumerable<string> w= new List<string>() { "a", "b", "c", "d" };
            Console.WriteLine( GetFirstSingleLetterWord(w));
            IEnumerable<string> word = new List<string>() { "First", "Single", "letter", "is", "a", "and", "it's", "her" };
            Console.WriteLine(GetLastWordWithHerInIt(word));
            Console.WriteLine(GetFifthWordIfItExists(word));
            Console.WriteLine(GetLastWordIfAny(w));
        }
    }
}