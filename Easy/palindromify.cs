// Making Numbers Palindromic, 7 Jun 2015, https://www.reddit.com/r/dailyprogrammer/comments/38yy9s/20150608_challenge_218_easy_making_numbers/

//this actually overflows on the biggest challenge input. I suppose I could convert it to BigInteger, but there's not much difference.
public void palindromify(long input)
{
	long result=input;
	int count=0;
	long reverse=reverseLong(result);
	try{
		while(result!=reverse)
		{
			result+=reverse;
			count++;
			reverse=reverseLong(result);
		}
		Console.WriteLine("{0} gets palindromic after {1} steps: {2}",input, count, result);
	}
	catch(Exception e){
		Console.WriteLine("{0} does not palindromify or does so at too large a number", input);
	}
}

public long reverseLong(long input)
{
	return Convert.ToInt64(new string(input.ToString().ToCharArray().Reverse().ToArray()));
}