public class Solution {
    public bool IsAnagram(string s, string t)
    {
        if (s.Length != t.Length)
            return false;

        Dictionary<char, int> dictionaryS = [];
        Dictionary<char, int> dictionaryT = [];

        foreach (char character in s)
        {
            dictionaryS[character] = dictionaryS.GetValueOrDefault(character) + 1;
        }

        foreach (char character in t)
        {
            dictionaryT[character] = dictionaryT.GetValueOrDefault(character) + 1;
        }

        foreach (var pair in dictionaryS)
        {

            if (dictionaryT.GetValueOrDefault(pair.Key) != pair.Value)
            {
                return false;
            }
        }

        return true;
    }
}
