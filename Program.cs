namespace Assignment_7_2_3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            {
                Console.WriteLine("Enter the first string (s):");
                string s = Console.ReadLine();

                Console.WriteLine("Enter the second string (t):");
                string t = Console.ReadLine();

                bool result = IsAnagram(s, t);
                Console.WriteLine($"Are the strings anagrams? {result}");
            }
        }

        static bool IsAnagram(string s, string t)
        {
            
            if (s.Length != t.Length)
                return false;
                        
            Dictionary<char, int> charCount = new Dictionary<char, int>();
                        
            foreach (char c in s)
            {
                if (charCount.ContainsKey(c))
                    charCount[c]++;
                else
                    charCount[c] = 1;
            }
                        
            foreach (char c in t)
            {
                if (!charCount.ContainsKey(c))
                    return false;

                charCount[c]--;

                if (charCount[c] == 0)
                    charCount.Remove(c);
            }
                       
            return charCount.Count == 0;
        }
    }
}

