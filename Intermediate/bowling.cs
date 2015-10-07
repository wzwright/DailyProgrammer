// Scoring a Bowling Game, 07 Oct 2015, https://www.reddit.com/r/dailyprogrammer/comments/3ntsni/20151007_challenge_235_intermediate_scoring_a/

public int score(string s)
{
	string[] frames = s.Split(' ');
	int sum=0;
	for(int i=0;i<10;i++)
	{
		if(i==9){
			if(frames[i].Length==3){
				if(frames[i][0]=='X')
					sum+=10+value(frames[i][1])+value(frames[i][2]);
				else
					sum+=10+value(frames[i][2]);
			}
			else
			{
				sum+=value(frames[i][0])+value(frames[i][1]);
			}
		}
		else{
			if(frames[i][0]=='X')
			{
				if(frames[i+1].Length==1)
					sum+=20+value(frames[i+2][0]);
				else
					sum+=10+value(frames[i+1][0])+value(frames[i+1][1]);
			}
			else if(frames[i][1]=='/')
				sum+=10+value(frames[i+1][0]);
			else
				sum+=value(frames[i][0])+value(frames[i][1]);
		}
	}
	return sum;
}

public int value(char c)
{
	if(c=='X'||c=='/')
		return 10;
	if(c=='-')
		return 0;
	return Convert.ToInt32(c)-48;
}