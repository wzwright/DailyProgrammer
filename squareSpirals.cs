// Square Spirals, 10 Aug 2015, https://www.reddit.com/r/dailyprogrammer/comments/3ggli3/20150810_challenge_227_easy_square_spirals/

//The idea here is that I find the size of the largest complete square filled in before the given point or number,
//and then I count the remaining partial spiral
public void calculatePosition(string sizeInput, string input)
{
	long size = Convert.ToInt64(sizeInput);
	string[] inputSplit=input.Split();
	if(inputSplit.Length==1)
	{
		long[] result= getCoord(Convert.ToInt64(input));
		long offset=(size-result[2])/2;
		Console.WriteLine("("+(result[0]+offset)+", "+(result[1]+offset)+")");
	}
	else
	{
		long x = Convert.ToInt64(inputSplit[0]);
		long y = Convert.ToInt64(inputSplit[1]);
		Console.WriteLine(getNum(x,y,size));
	}
}

public long[] getCoord(long num)
{
	if(num==1)
		return new long[] {0,0,-1};
	long root = (long)Math.Sqrt(num);
	long diff = num-root*root;
	switch((long)(diff/(root+1)))
	{
		case 0: return new long[] {root+1,root-diff+1,root};
		case 1: return new long[] {root*2-diff+2,0,root};
		case 2: return new long[] {0,root*3-diff+3,root};
		default: return new long[] {root*4-diff+4,root+1,root};
	}

	return null;
}

public long getNum(long shiftedX, long shiftedY, long size)
{
	long x=shiftedX-(size+1)/2;
	long y=-shiftedY+(size+1)/2;
	if(x>=y)
	{
		if(x>-y)
			return (x*2-1)*(x*2-1)+y+Math.Abs(x);
		else
			return (y*2+1)*(y*2+1)+Math.Abs(y*7)+x;
	}
	else
	{
		if(x>-y)
			return (y*2-1)*(y*2-1)+Math.Abs(y*3)-x;
		else
			return (x*2+1)*(x*2+1)-y+Math.Abs(x*5);
	}
}