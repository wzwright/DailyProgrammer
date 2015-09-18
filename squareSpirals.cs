// Square Spirals, 10 Aug 2015, https://www.reddit.com/r/dailyprogrammer/comments/3ggli3/20150810_challenge_227_easy_square_spirals/

//The idea here is that I find the size of the largest complete square filled in before the given point or number,
//and then I count the remaining partial spiral
public void calculatePosition(string sizeInput, string input)
{
	int size = Convert.ToInt32(sizeInput);
	string[] inputSplit=input.Split();
	if(inputSplit.Length==1)
	{
		int[] result= getCoord(Convert.ToInt32(input));
		int offset=(size-result[2])/2;
		Console.WriteLine("("+(result[0]+offset)+", "+(result[1]+offset)+")");
	}
	else
	{
		int x = Convert.ToInt32(inputSplit[0]);
		int y = Convert.ToInt32(inputSplit[1]);
		Console.WriteLine(getNum(x,y,size));
	}
}

public int[] getCoord(int num)
{
	if(num==1)
		return new int[] {0,0,-1};
	int root = (int)Math.Sqrt(num);
	int diff = num-root*root;
	switch((int)(diff/(root+1)))
	{
		case 0: return new int[] {root+1,root-diff+1,root};
		case 1: return new int[] {root*2-diff+2,0,root};
		case 2: return new int[] {0,root*3-diff+3,root};
		default: return new int[] {root*4-diff+4,root+1,root};
	}

	return null;
}

public int getNum(int shiftedX, int shiftedY, int size)
{
	int x=shiftedX-(size+1)/2;
	int y=-shiftedY+(size+1)/2;
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