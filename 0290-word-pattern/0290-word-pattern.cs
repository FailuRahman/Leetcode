public class Solution {
    public bool WordPattern(string pattern, string s) {
        string[] words = s.Split(' ');

        if(pattern.Length != words.Length){
            return false;
        }

        Dictionary<char,string> map = new Dictionary<char,string>();
        HashSet<string> used = new HashSet<string>();

            for(int i = 0; i < pattern.Length; i++){
                char c =  pattern[i];
                string word = words[i];


                if(map.ContainsKey(c)){
                    if(map[c] != word)
                    return false;
                }else{
                    if(used.Contains(word))
                        return false;

                    map[c] = word;
                    used.Add(word);
                    
                }



            }
            return true;

    }
}