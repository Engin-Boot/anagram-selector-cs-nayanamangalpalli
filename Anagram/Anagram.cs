using System;
using System.Collections.Generic;

namespace Anagram
{
    public class AnagramSelector
    {
        public bool WordPairIsAnagram(string word1, string word2) {
            
            if(word1.Length != word2.Length)
            {
                return false;
	        }
            else{
	
                Dictionary<char,int> TempDictionary = new Dictionary<char,int>();
                foreach(char charKeyElement in word1) 
                {
                    if(TempDictionary.ContainsKey(charKeyElement))
                        TempDictionary[charKeyElement]++;
                    else
                        TempDictionary.Add(charKeyElement, 1);
                }
                foreach(char charKeyElement in word2)    
                {
                    if(!TempDictionary.ContainsKey(charKeyElement)) 
                        return false;
                    TempDictionary[charKeyElement]--;
                    if(TempDictionary[charKeyElement]== 0) 
                        TempDictionary.Remove(element);
                }
                return TempDictionary.Count == 0;
        }
            
        public List<string> SelectAnagrams(string word, List<string> candidates) {
            //Insert the correct implementation here
            return candidates;
        }
    }
}
