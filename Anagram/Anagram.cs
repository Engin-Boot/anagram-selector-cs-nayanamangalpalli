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
			
                Dictionary<char,int> ReturnedCharKeyIntValueDictionary = addStringCharactersToDictionary(word1);
		return checkParameterStringCharactersContainInDictionary(ReturnedCharKeyIntValueDictionary,word2);
	    }
                
        }
	
	public Dictionary<char,int> addStringCharactersToDictionary(string _WordParameter){
		
		Dictionary<char,int> _LocalCharKeyIntValueDictionary = new Dictionary<char,int>();
                
		foreach(char charKeyElement in _WordParameter) 
                {
                    if(_LocalCharKeyIntValueDictionary.ContainsKey(charKeyElement))
                        _LocalCharKeyIntValueDictionary[charKeyElement]++;
                    else
                        _LocalCharKeyIntValueDictionary.Add(charKeyElement, 1);
                }
		
		return _LocalCharKeyIntValueDictionary;
	}
		
	public bool checkParameterStringCharactersContainInDictionary(Dictionary<char,int> _CharKeyIntValueDictionaryParameter, string _WordParameter){
		
		foreach(char charKeyElement in _WordParameter)    
                {
                    if(!_CharKeyIntValueDictionaryParameter.ContainsKey(charKeyElement)) 
                        return false;
                    _CharKeyIntValueDictionaryParameter[charKeyElement]--;
                    if(_CharKeyIntValueDictionaryParameter[charKeyElement]== 0) 
			_CharKeyIntValueDictionaryParameter.Remove(charKeyElement);
                }
                return _CharKeyIntValueDictionaryParameter.Count == 0;
	}
            
        public List<string> SelectAnagrams(string word, List<string> candidates) {
		
		foreach(string candidateElement in candidates){

			if(!PairIsAnagram(word, candidateElement)){
				_SelectedAnagramsList.Remove(candidateElement);
			}
            	return  candidates;
        }
    }
}
