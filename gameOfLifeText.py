# Game of Text Life, 23 Sep 2015, https://www.reddit.com/r/dailyprogrammer/comments/3m2vvk/20150923_challenge_233_intermediate_game_of_text/

# Conway's game of life, but cells can be represented by characters rather than a single marker
from random import randint

lines = [list(x) for x in open('C:/Python33/gameOfLife.txt').read().splitlines()]
max=0
for line in lines:
	if len(line)>max:
		max=len(line)
for line in lines:
	if len(line)<max:
		for i in range(max-len(line)):
			line.append(' ')

def step():
	newLines=[]
	global lines
	for y in range(len(lines)):
		newLines.append([])
		for x in range(len(lines[0])):
			newLines[y].append(' ')
	for y in range(len(lines)):
		for x in range(len(lines[0])):
			characters=[]
			neighborCount=0
			for i in (-1,0,1):
				for j in (-1,0,1):
					if((i!=0 or j!=0) and y+j>=0 and x+i>=0):
						try:
							if not lines[y+j][x+i].isspace():
								characters.append(lines[y+j][x+i])
								neighborCount+=1
						except IndexError:
							pass
			if not lines[y][x].isspace():
				if neighborCount<2 or neighborCount>3:
					pass
				else:
					newLines[y][x]=lines[y][x]
			elif neighborCount==3:
				newLines[y][x]=characters[randint(0,len(characters)-1)]
	lines=list(newLines)

step()
for line in lines:
	print(''.join(line))

