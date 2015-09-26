// Mangling Sentences, 22 Jun 2015, https://www.reddit.com/r/dailyprogrammer/comments/3aqvjn/20150622_challenge_220_easy_mangling_sentences/

// Sorts sentences, leaving non-word characters and first letter capitalization intact
import java.util.*;
import java.lang.*;
import java.io.*;

class ManglingSentences
{
    public static void main(String[] args)
    {
    	BufferedReader in = new BufferedReader(new InputStreamReader(System.in));
    	String sentence="";
    	try{
    		sentence = in.readLine();
    	}
    	catch(IOException e){
    		e.printStackTrace();
    	}
    	
    	StringBuilder result = new StringBuilder();
    	for(String s : sentence.split(" "))
    	{
    		result.append(" "+sortWord(s));
    	}
    	System.out.println(result.toString().trim());
    }

    public static String sortWord(String s)
    {
    	boolean caps = Character.isUpperCase(s.charAt(0));
        StringBuilder wordCharacters = new StringBuilder();
        ArrayList<Character> nonWord = new ArrayList<Character>();
        ArrayList<Integer> indices = new ArrayList<Integer>();
        for(int i=0;i<s.length();i++)
        {
        	if(Character.isLetter(s.charAt(i)))
        		wordCharacters.append(Character.toLowerCase(s.charAt(i)));
        	else{
        		nonWord.add(s.charAt(i));
        		indices.add(i);
        	}
        		
        }
    	char[] chars = wordCharacters.toString().toCharArray();
        Arrays.sort(chars);
        StringBuilder sorted = new StringBuilder(new String(chars));
        for(int i=0;i<nonWord.size();i++)
        	sorted.insert(indices.get(i),(Object)nonWord.get(i)); //leaving this as char was showing ambiguous reference error
        if(caps)
        	sorted.replace(0,1,""+Character.toUpperCase(sorted.charAt(0)));
        return sorted.toString();
    }
}