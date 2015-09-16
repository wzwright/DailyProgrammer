#Cellular Automata: Rule 90, 7 Sep 2015, https://www.reddit.com/r/dailyprogrammer/comments/3jz8tt/20150907_challenge_213_easy_cellular_automata/
def automata(input, steps):
    length = len(input)
    if length<=1:
        print("input must be longer than 1 character")
    row=input
    tempRow=""
    for c in row:
        tempRow+="x" if c=="1" else " "
    print(tempRow)
    for i in range(steps):
        newRow=""
        for x in range(length):
            if x==0:
                newRow+="x" if int(row[1]) else " "
            elif x==length-1:
                newRow+="x" if int(row[length-2]) else " "
            else:
                newRow+="x" if int(row[x-1])^int(row[x+1]) else " "
        print(newRow)
        row=""
        for c in newRow:
            row+="1" if c=="x" else "0"