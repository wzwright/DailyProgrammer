# Eight Husbands for Eight Sisters, 11 Sep 2015, https://www.reddit.com/r/dailyprogrammer/comments/3kj1v9/20150911_challenge_231_hard_eight_husbands_for/

# Finding a stable matching from preferences 
pairs = {}
preferences = {}

for line in open('C:/Python33/stableMarriage.txt').read().splitlines():
    name, *prefs = line.split(', ')
    preferences[name] = prefs

availableMen = [person for person in preferences if person.isupper()]
availableWomen = [person for person in preferences if person.islower()]
while availableMen:
    currentMan = availableMen[0]
    currentWoman = preferences[currentMan].pop(0)
    if currentWoman in availableWomen:
        pairs[currentWoman] = currentMan
        availableWomen.remove(currentWoman)
        availableMen.remove(currentMan)
    else:
        otherMan = pairs[currentWoman]
        if preferences[currentWoman].index(currentMan) < preferences[currentWoman].index(otherMan):
            availableMen.append(otherMan)
            availableMen.remove(currentMan)
            pairs[currentWoman] = currentMan

#The sort sorts values instead of keys, kind of useless as it is
for woman, man in sorted(pairs.items()): 
    print("("+man+"; "+woman+")")