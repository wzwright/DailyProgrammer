# Random Bag System, 12 Oct 2015, https://www.reddit.com/r/dailyprogrammer/comments/3ofsyb/20151012_challenge_236_easy_random_bag_system/

from random import *

letters=['O','I','S','Z','L','J','T']
result=""
for x in range(7):
	shuffle(letters)
	result+="".join(letters)
result+=letters[randint(0,6)]
print (result)